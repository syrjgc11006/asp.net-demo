using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;


namespace WebApplication2
{
    public partial class _Default : System.Web.UI.Page
    {
        //创建一个分页数据源的对象且一定要声明为静态的
        protected static PagedDataSource ps = new PagedDataSource();

        protected void Page_Load(object sender, EventArgs e)
        {
            Bind();
        }

        //定义一个数据绑定的方法
        public void Bind()
        {
            int CurrentPage = Convert.ToInt32(labNowPage.Text);
            PagedDataSource ps = new PagedDataSource();//生成PagedDataSource的实例
            //实例化SqlConnection对象
            SqlConnection sqlCon = new SqlConnection();
            //实例化SqlConnection对象连接数据库的字符串
            sqlCon.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\C#资料\\ASP.NET\\[ASP.NET从入门到精通].MR\\SL\\10\\DATABASE\\DB_STUDENT.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True";
            //定义SQL语句
            string SqlStr = "select * from tb_StuInfo";
            //实例化SqlDataAdapter对象
            SqlDataAdapter da = new SqlDataAdapter(SqlStr, sqlCon);
            //实例化数据集DataSet
            DataSet ds = new DataSet();
            da.Fill(ds, "tb_StuInfo");
            ps.DataSource = ds.Tables["tb_StuInfo"].DefaultView;
           
            ps.AllowPaging = true; //是否可以分页
            ps.PageSize = 2; //显示的数量
            ps.CurrentPageIndex = CurrentPage - 1; //取得当前页的页码
            
            lnkbtnFront.Enabled = true;
            lnkbtnFirst.Enabled = true;
            lnkbtnNext.Enabled = true;
            lnkbtnLast.Enabled = true;
            
            if (CurrentPage == 1)
            {
                lnkbtnFirst.Enabled = false;//不显示第一页按钮
                lnkbtnFront.Enabled = false;//不显示上一页按钮
            }
           
            if (CurrentPage == ps.PageCount)
            {
                lnkbtnNext.Enabled = false;//不显示下一页
                lnkbtnLast.Enabled = false;//不显示最后一页

            }
           
            this.labCount.Text = Convert.ToString(ps.PageCount);
            this.DataList1.DataSource = ps;
            //显示数据库中的主键
            this.DataList1.DataKeyField = "stuID";
            this.DataList1.DataBind();
        }

        //当改变datalist控件中item项时发生
        //在该事件中设置单击【首页】、、、、时当前页索引以及绑定当前页，并实现跳转到指定页码的功能
        //protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        //{
        //    //获取跳转名称,点击的是（“首页”、“上一页”、“下一页”、尾页、页面跳转）
        //    switch(e.CommandName)
        //    {
        //        case "first"://首页
        //            ps.CurrentPageIndex=0;
        //            Bind();
        //        break;
        //        case "pre"://上一页
        //            ps.CurrentPageIndex = ps.CurrentPageIndex-1;
        //            Bind();
        //        break;
        //        case "next"://下一页
        //            ps.CurrentPageIndex = ps.CurrentPageIndex+1;
        //            Bind(ps.CurrentPageIndex);
        //        break;
        //        case "last"://尾页
        //            ps.CurrentPageIndex = ps.PageCount-1;
        //            Bind(ps.CurrentPageIndex);
        //        break;
        //        case "search"://页面跳转
        //            //如果列表控件为页脚控件
        //        if (e.Item.ItemType == ListItemType.Footer)
        //        {
        //            int PageCount = int.Parse(ps.PageCount.ToString());

        //            TextBox txtPage = e.Item.FindControl("txtPage") as TextBox;

        //            int MyPageNum = 0;
        //            //如果文本框中的显示的页数不为空的话
        //            if (!txtPage.Text.Equals(""))
        //            {
        //                MyPageNum = Convert.ToInt32(txtPage.Text.ToString());
        //            }
        //            if (MyPageNum <= 0 || MyPageNum > PageCount)
        //            {
        //                Response.Write("<script>alert('请输入页数并确定没有超过总页数')</script>");
        //            }
        //            else
        //            {
        //                Bind(MyPageNum-1);
        //            }
        //        }
        //        break;
        //    }
        //}

        protected void lnkbtnFirst_Click(object sender, EventArgs e)
        {
            this.labNowPage.Text = "1";
            this.Bind();
        }

        protected void lnkbtnFront_Click(object sender, EventArgs e)
        {
            this.labNowPage.Text = Convert.ToString(Convert.ToInt32(this.labNowPage.Text) - 1);
            this.Bind();
        }

        protected void lnkbtnNext_Click(object sender, EventArgs e)
        {
            this.labNowPage.Text = Convert.ToString(Convert.ToInt32(this.labNowPage.Text) + 1);
            this.Bind();
        }

        protected void lnkbtnLast_Click(object sender, EventArgs e)
        {
            this.labNowPage.Text = this.labCount.Text;
            this.Bind();
        }
    }
}

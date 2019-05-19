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
using System.Data;
using System.Data.SqlClient;

namespace 在GridView控件中对数据进行编辑操作
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList ddl;//定义一个控件

            if (!IsPostBack)
            {
                GridViewBind();
                DropDownList1.DataSource = ddlbind();
                DropDownList1.DataBind();
            }
        }

        //为dropdownlist控件设置数据源
        public SqlDataReader ddlbind()
        {
            string sqlstr = "select distinct stuSex  from tb_StuInfo";
            SqlConnection sqlcon = GetCon();
            SqlCommand sqlcom = new SqlCommand(sqlstr, sqlcon);
            sqlcon.Open();
            return sqlcom.ExecuteReader();            
        }

        

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //设置GridView控件的编辑项的索引为选择的当前的索引
            GridView1.EditIndex = e.NewEditIndex;
            //数据绑定
            GridViewBind();
        }

        //该方法返回链接字符串对象
        public SqlConnection GetCon()
        {
            //实例化SqlConnection对象
            SqlConnection sqlcon = new SqlConnection();
            //实例化SqlConnection对象连接数据库的字符串
            sqlcon.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\C#资料\\ASP.NET\\[ASP.NET从入门到精通].MR\\SL\\10\\DATABASE\\DB_STUDENT.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True";
            return sqlcon;
        }

        //进行数据绑定
        public void GridViewBind()
        {
            //SqlConnection myConn = GetCon();
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\C#资料\\ASP.NET\\[ASP.NET从入门到精通].MR\\SL\\10\\DATABASE\\DB_STUDENT.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True";
            //定义SQL语句
            string SqlStr = "select * from tb_StuInfo";
            //实例化SqlDataAdapter对象
            SqlDataAdapter da = new SqlDataAdapter(SqlStr, myConn);
            //实例化数据集DataSet
            DataSet ds = new DataSet();
            da.Fill(ds, "tb_StuInfo");
            //绑定GridView控件
            GridView1.DataSource = ds;
            //获取一个数组，该数组保存的是表中的主键的值
            GridView1.DataKeyNames = new string[] { "stuID" };

            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //取得编辑行的关键字段的值
            string stuID = GridView1.DataKeys[e.RowIndex].Value.ToString();
            
            //取得文本框中输入的内容
            string stuName = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[1].Controls[0])).Text.ToString();
            string stuSex = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text.ToString();
            string stuHobby = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[3].Controls[0])).Text.ToString();

            //更新数据表中的信息
            string sqlStr = "update tb_StuInfo set stuName='" + stuName + "',stuSex='" + stuSex + "',stuHobby='" + stuHobby + "'where stuID=" + stuID;
            SqlConnection myConn = GetCon();
            //打开数据库连接，进行增、删。改
            myConn.Open();
            //创造进行增删改、查的对象
            SqlCommand myCmd = new SqlCommand(sqlStr, myConn);
            myCmd.ExecuteNonQuery();
            myCmd.Dispose();
            myConn.Close();
            //设置编辑的索引，取消编辑
            GridView1.EditIndex = -1;
            //重新绑定
            GridViewBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //设置GridView控件的编辑项的索引为-1，即取消编辑
            GridView1.EditIndex = -1;
            //数据绑定
            GridViewBind();
        }


        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //高亮显示鼠标所在的行
            //如果当前选定的行为数据行
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onmouseover", "currentcolor=this.style.backgroundColor;this.style.backgroundColor='#6699ff'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=currentcolor");
            }

            //如果绑定的是数据行
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //格式化字符串
                ////当有编辑列时，避免出错，要加的RowState判断 
                //e.Row.Cells[1].Text = string.Format("{0:c2}",Convert.ToString(e.Row.Cells[1].Text));
                if (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate)
                {
                    ((LinkButton)e.Row.Cells[5].Controls[0]).Attributes.Add("onclick", "javascript:return confirm('你确认要删除：\"" + e.Row.Cells[1].Text + "\"吗?')");
                }
            }          

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //获取的是主键，所以这里获取的是一行中代表数据库中主键数据的信息
            string sqlStr = "delete from tb_StuInfo where stuID=" + GridView1.DataKeys[e.RowIndex].Value.ToString();
            SqlConnection myConn = GetCon();
            //打开数据库连接，进行增、删。改
            myConn.Open();
            //创造进行增删改、查的对象
            SqlCommand myCmd = new SqlCommand(sqlStr, myConn);
            myCmd.ExecuteNonQuery();
            myConn.Close();
            myCmd.Dispose();
            //设置编辑的索引，取消编辑
            GridView1.EditIndex = -1;
            //重新绑定
            GridViewBind();
        }

    }
}

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

namespace WebApplication3
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();//数据绑定
            }
        }

        //进行数据绑定的方法
        public void Bind()
        {
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
            this.DataList1.DataSource = ds;
            //获取主键
            this.DataList1.DataKeyField = "stuID";
            this.DataList1.DataBind();
        }

        //当选中datalist中的某一项是发生
        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            //与控件相关联的命令
            if (e.CommandName == "select")
            {
                //设置选中行的索引为当前选择行的索引
                DataList1.SelectedIndex = e.Item.ItemIndex;
                //数据绑定
                Bind();
            }
            if (e.CommandName == "back")
            {
                //设置选中行的索引为-1,取消该数据项的选择
                DataList1.SelectedIndex = -1;
                //数据绑定
                Bind();
            }
        }
    }
}

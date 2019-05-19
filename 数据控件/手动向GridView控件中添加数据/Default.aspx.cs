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

namespace 手动向GridView控件中添加数据
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if (!IsPostBack)
            {
                GridViewBind();
            }
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
    }
}

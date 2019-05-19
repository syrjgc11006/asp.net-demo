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


namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //实例化一个连接字符串类
            SqlConnection sqlCon;
            //连接字符串
            string strCon = "Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\C#资料\\ASP.NET\\[ASP.NET从入门到精通].MR\\SL\\10\\DATABASE\\DB_STUDENT.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True";

            sqlCon = new SqlConnection(strCon);

            //定义SQL语句
            string SqlStr = "select * from tb_StuInfo";

            //实例化一个适配器对象
            SqlDataAdapter da = new SqlDataAdapter(SqlStr, sqlCon);

            //实例化一个数据集
            DataSet ds = new DataSet();
            //填充数据集
            da.Fill(ds,"tb_StuInfo");

            DataList1.DataSource = ds;//设置数据源，用于填充控件中的项的值列表
            DataList1.DataBind();
        }
    }
}

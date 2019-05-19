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

namespace 使用command对象查询数据
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //该方法用来获取数据库连接字符串
        public SqlConnection GetConnection()
        {
            //获取配置文件中的数据库链接字符串
            string mystr = ConfigurationManager.AppSettings["ConnectionString"].ToString();
            SqlConnection myConn = new SqlConnection(mystr);
            return myConn;
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                SqlConnection myConn = GetConnection();
                myConn.Open();
                //参数化查询
                string sqlStr = "select * from tb_Student where Name=@Name";
                SqlCommand myCmd = new SqlCommand(sqlStr, myConn);
                myCmd.Parameters.Add("@Name", SqlDbType.VarChar, 20).Value = txtName.Text.Trim();

                //创建一个适配器对象
                SqlDataAdapter myDa = new SqlDataAdapter(myCmd);
                DataSet myDs = new DataSet();
                //填充数据集
                myDa.Fill(myDs);

                if (myDs.Tables[0].Rows.Count > 0)
                {
                    GridView1.DataSource = myDs;
                    GridView1.DataBind();
                }
                else
                {
                    Response.Write("<script>alert('没有相关记录')</script>");
                }
                myDa.Dispose();
                myDs.Dispose();
                myConn.Close();
            }
        }
    }
}

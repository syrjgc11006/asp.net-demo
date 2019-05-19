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

namespace 在GridView控件中实现全选和全不选功能
{
    public partial class _Default : System.Web.UI.Page
    {
        //  字符串连接对象
        SqlConnection sqlcon;
        //连接字符串
        string strCon = "Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\C#资料\\ASP.NET\\[ASP.NET从入门到精通].MR\\SL\\10\\DATABASE\\DB_STUDENT.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True";

        public void bind()
        {
            //SqlConnection myConn = GetCon();
            sqlcon = new SqlConnection(strCon);      
            //定义SQL语句
            string SqlStr = "select * from tb_StuInfo";
            //实例化SqlDataAdapter对象
            SqlDataAdapter da = new SqlDataAdapter(SqlStr, sqlcon);
            //实例化数据集DataSet
            sqlcon.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "tb_StuInfo");
            //绑定GridView控件
            GridView1.DataSource = ds;
            //获取一个数组，该数组保存的是表中的主键的值
            GridView1.DataKeyNames = new string[] { "stuID" };
            GridView1.DataBind();
            sqlcon.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }
        }


        protected void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
            {
                //建立模板列中CheckBox控件的引用
                CheckBox chk = (CheckBox)GridView1.Rows[i].FindControl("chkcheck");
                if (chkAll.Checked == true)
                {
                    chk.Checked = true;
                }
                else
                {
                    chk.Checked = false;
                }
            }
        }

        //取消全选
        protected void Button1_Click(object sender, EventArgs e)
        {
            chkAll.Checked = false;
            for (int i = 0; i <=GridView1.Rows.Count - 1; i++)
            {
                CheckBox cbox = (CheckBox)GridView1.Rows[i].FindControl("chkcheck");
                cbox.Checked = false;
            }
        }

        //删除选定的内容
        protected void Button2_Click(object sender, EventArgs e)
        {
            //新建连接
            sqlcon = new SqlConnection(strCon);
            //新建数据库操作对象
            SqlCommand sqlcom;
            for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
            {
                CheckBox cbox = (CheckBox)GridView1.Rows[1].FindControl("chkcheck");
                
                //如果为选中状态
                if (cbox.Checked == true)
                {
                   //删除语句的sql语句，获取主键值
                    string sqlstr = "delete from tb_StuInfo where stuID=" + GridView1.DataKeys[i].Value;
                    //实例化数据库操作对象
                    sqlcom = new SqlCommand(sqlstr, sqlcon);
                    sqlcon.Open();
                    //执行删除操作
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();
                }
                //重新绑定
                bind();
            }
        }
    }
}

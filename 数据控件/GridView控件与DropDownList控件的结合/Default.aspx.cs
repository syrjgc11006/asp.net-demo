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

namespace GridView控件与DropDownList控件的结合
{
    public partial class _Default : System.Web.UI.Page
    {
        
        //  字符串连接对象
        SqlConnection sqlcon;                   
        //连接字符串
        string strCon ="Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\C#资料\\ASP.NET\\[ASP.NET从入门到精通].MR\\SL\\10\\DATABASE\\DB_STUDENT.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True";
       
        protected void Page_Load(object sender, EventArgs e)
        {
            //DataTextFiled  获取或设置为列表项提供文本内容的数据源字段
            //DataValueField 获取或设置为各列表项提供值的数据源字段
            if (!IsPostBack)
            {
                DropDownList ddl;//定义一个控件用来作为子控件
                //sql语句
                string sqlstr = "select * from tb_StuInfo";
                //实例化字符串连接对象
                sqlcon = new SqlConnection(strCon);
                //获取适配器对象
                SqlDataAdapter myda = new SqlDataAdapter(sqlstr,sqlcon);
                //定义数据集
                DataSet myds = new DataSet();
                //打开连接
                sqlcon.Open();
                //填充数据集
                myda.Fill(myds);
                //获取数据源
                GridView1.DataSource = myds;
                //对数据源进行绑定
                GridView1.DataBind();


                //将dropdownlist控件作为子控件绑定到gridview当中
                for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
                {
                    //获取视图中的记录
                    DataRowView mydrv = myds.Tables[0].DefaultView[i];
                    //判断指定数据列是否满足要求
                    if (Convert.ToString(mydrv["stuSex"]).Trim() == "男")
                    {
                        //在容器中搜索带有指定名称的服务器控件
                        ddl = (DropDownList)GridView1.Rows[i].FindControl("DropDownList1");
                        ddl.SelectedIndex = 0;
                    }
                    if (Convert.ToString(mydrv["stuSex"]).Trim() == "女")
                    {
                        //在容器中搜索带有指定名称的服务器控件
                        ddl = (DropDownList)GridView1.Rows[i].FindControl("DropDownList1");
                        ddl.SelectedIndex = 1;
                    }
                }
                //关闭连接
                sqlcon.Close();
            }           
        }

        //绑定数据源到dropdownlist控件中
        public SqlDataReader ddlbind()
        {
            string sqlstr = "select distinct stuSex  from tb_StuInfo";
            SqlConnection sqlcon = new SqlConnection(strCon);
            SqlCommand sqlcom = new SqlCommand(sqlstr, sqlcon);
            sqlcon.Open();
            return sqlcom.ExecuteReader();
        }

    }
}

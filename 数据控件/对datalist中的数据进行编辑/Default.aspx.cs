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

namespace WebApplication4
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
            }
        }

        public SqlConnection GetCon()
        {
            //实例化SqlConnection对象
            SqlConnection sqlCon = new SqlConnection();
            //实例化SqlConnection对象连接数据库的字符串
            sqlCon.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\C#资料\\ASP.NET\\[ASP.NET从入门到精通].MR\\SL\\10\\DATABASE\\DB_STUDENT.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True";
            return sqlCon;
        }

        public void Bind()
        {
            SqlConnection sqlCon = GetCon();
            //定义SQL语句
            string SqlStr = "select * from tb_StuInfo";
            //实例化SqlDataAdapter对象
            SqlDataAdapter da = new SqlDataAdapter(SqlStr, sqlCon);
            //实例化数据集DataSet
            DataSet ds = new DataSet();
            da.Fill(ds, "tb_StuInfo");
            //绑定DataList控件
            DataList1.DataSource = ds;//设置数据源，用于填充控件中的项的值列表
            DataList1.DataKeyField = "stuID";//设置数据表的主键
            DataList1.DataBind();//将控件及其所有子控件绑定到指定的数据源
        }

        protected void DataList1_EditCommand(object source, DataListCommandEventArgs e)
        {
            //设置DataList1控件的编辑项的索引为选择的当前索引
            DataList1.EditItemIndex = e.Item.ItemIndex;
            //数据绑定
            Bind();
        }

        protected void DataList1_CancelCommand(object source, DataListCommandEventArgs e)
        {
            //设置DataList1控件的编辑项的索引为－1，即取消编辑
            DataList1.EditItemIndex = -1;
            //数据绑定
            Bind();
        }

        protected void DataList1_UpdateCommand(object source, DataListCommandEventArgs e)
        {
            //取得编辑行的关键字段的值
            string stuID = DataList1.DataKeys[e.Item.ItemIndex].ToString();
            //取得文本框中输入的内容
            string stuName = ((TextBox)e.Item.FindControl("txtName")).Text;
            string stuSex = ((TextBox)e.Item.FindControl("txtSex")).Text;
            string stuHobby = ((TextBox)e.Item.FindControl("txtHobby")).Text;
            string sqlStr = "update tb_StuInfo set stuName='" + stuName + "',stuSex='" + stuSex + "',stuHobby='" + stuHobby + "' where stuID=" + stuID;
            //更新数据库
            SqlConnection myConn = GetCon();
            myConn.Open();
            SqlCommand myCmd = new SqlCommand(sqlStr, myConn);
            myCmd.ExecuteNonQuery();
            myCmd.Dispose();
            myConn.Close();
            //取消编辑状态
            DataList1.EditItemIndex = -1;
            Bind();
        }
    }
}

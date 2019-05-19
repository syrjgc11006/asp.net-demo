using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Label1.Text = DateTime.Now.ToString();

        //获取上一页面的消息
        if (Request.QueryString["area"] != null)
        {
            string sqlStr = "select * from tb_Member where City=@City";
            SqlConnection myConn = GetConnection();
            SqlDataAdapter myAdapter = new SqlDataAdapter(sqlStr, myConn);
            myAdapter.SelectCommand.Parameters.Add("@City", SqlDbType.VarChar);
            myAdapter.SelectCommand.Parameters["@City"].Value = Request.QueryString["area"].ToString();
            DataSet myDs = new DataSet();
            myAdapter.Fill(myDs, "tb_Member");
            this.GridView1.Visible = true;
            GridView1.DataSource = myDs.Tables["tb_Member"].DefaultView;
            GridView1.DataKeyNames = new string[] { "MemberID" };
            GridView1.DataBind();
        }
        else
        {
            this.GridView1.Visible = false;

        }
    }
    
    //连接数据库
    public SqlConnection GetConnection()
    {
        //以windows用户方式登录
        string myStr = ConfigurationManager.AppSettings["ConnectionString"].ToString();
        SqlConnection myConn = new SqlConnection(myStr);
        return myConn;
    }
    public void ddlbind()
    {
        string sqlStr = "select City from tb_Member";
        SqlConnection myConn = GetConnection();
        SqlDataAdapter myAdapter = new SqlDataAdapter(sqlStr, myConn);
        DataSet myDs = new DataSet();
        myConn.Open();
        myAdapter.Fill(myDs, "tb_Member");
        this.DropDownList1.DataSource = myDs.Tables["tb_Member"].DefaultView;
        this.DropDownList1.DataTextField = myDs.Tables["tb_Member"].Columns[0].ToString();
        this.DropDownList1.DataBind();
        myAdapter.Dispose();
        myDs.Dispose();
        myConn.Close();
        this.DropDownList1.Items.Insert(0,"请选择地区");
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (this.DropDownList1.SelectedIndex != 0)
        {
            //area是缓存的信息
            Response.Redirect("default.aspx?area="+this.DropDownList1.SelectedItem.Value);
        
        }
    }
}

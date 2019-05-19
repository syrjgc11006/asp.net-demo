using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class manage_list : System.Web.UI.Page
{
    CommonClass CC = new CommonClass();
    //定义一个静态的全局变量，用于标识是否已单击站内搜索控钮
    public static int IntSearch;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //页面初始化时，指定IntSearch=0
            IntSearch = 0;
            //使用Request对象获取页面传递的值
            int n = Convert.ToInt32(Request.QueryString["id"]);
            //指定新闻类别名
            this.ddlNewsStyle.SelectedIndex = (n - 1);
            this.bind(); 
        }
    }
    protected void bind()
    {
        //调用CommonClass类的GetDataSet方法，查询需要管理的新闻信息，并绑定GridView控件上
        this.gvNewsList.DataSource = CC.GetDataSet("select * from tb_News where style='" + this.ddlNewsStyle.SelectedValue.Trim() + "' order by id", "tbNews");
        this.gvNewsList.DataKeyNames = new string[] { "id" };
        this.gvNewsList.DataBind();
    }
    protected void searchBind()
    {
        //使用Like运算符，定义一个查询字符串
        string strSql = "select * from tb_News where style='" + this.ddlNewsStyle.SelectedValue.ToString() + "'";
        strSql += " and (( content like '%" + this.txtKey.Text + "%')";
        strSql += " or (Title like '%" + this.txtKey.Text + "%'))";
        //调用CommonClass类的GetDataSet方法，获取符合条件的新闻信息
        //将获取的新闻信息绑定到数据控件GridView控件中
        gvNewsList.DataSource = CC.GetDataSet(strSql, "tbNews");
        gvNewsList.DataKeyNames = new string[] { "id" };
        gvNewsList.DataBind();
    
    }
    protected void gvNewsList_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //调用CommonClass类的ExecSQL方法，删除指定的新闻
        CC.ExecSQL("delete  from tb_News where id='" + this.gvNewsList.DataKeys[e.RowIndex].Value.ToString() + "'");
        if (IntSearch == 1)
        {
            this.searchBind();
        }
        else
        {
            bind();
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        //单击站内搜索按钮时，IntSearch=1;
        IntSearch = 1;
        this.searchBind();

    }
    protected void gvNewsList_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvNewsList.PageIndex = e.NewPageIndex;
        if (IntSearch == 1)
        {
            this.searchBind();
        }
        else
        {
            bind();
        }
    }
   
    protected void gvNewsList_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Cells[3].Text =Convert.ToDateTime(e.Row.Cells[3].Text).ToShortDateString();
        }
    }
}

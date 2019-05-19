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

public partial class search : System.Web.UI.Page
{
    CommonClass CC = new CommonClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        //获取符合条件的新闻信息
        this.dlNews.DataSource = CC.GetDataSet(Convert.ToString(Session["search"]), "tbNews");
        this.dlNews.DataKeyField = "id";
        this.dlNews.DataBind();
        //显示查询条件
        this.labSC.Text = Convert.ToString(Session["tool"]);
    }
    protected void dlNews_ItemCommand(object source, DataListCommandEventArgs e)
    {
        int id = Convert.ToInt32(dlNews.DataKeys[e.Item.ItemIndex].ToString());
        Response.Write("<script language=javascript>window.open('showNews.aspx?id=" + id + "','','width=520,height=260')</script>");
       
    }
}

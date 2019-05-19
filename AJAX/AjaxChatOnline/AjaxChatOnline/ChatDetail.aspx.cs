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

public partial class ChatDetail : System.Web.UI.Page
{
    public int curpage,pgcount;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] == "" || Session["User"] == null)
            Response.Redirect("Login.aspx");
        User us = new User();
        DataTable dt= us.GetChat();
        int page =Convert.ToInt32(Request.QueryString["page"]);
        PagedDataSource pg = us.GetPageDataSource(dt, 15, page);
        curpage = pg.CurrentPageIndex + 1;
        pgcount = pg.PageCount;


        Repeater1.DataSource = pg;       
        Repeater1.DataBind();
    }
}

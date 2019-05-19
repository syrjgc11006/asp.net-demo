using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        
    }
    protected void imgbtnAdd_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/addVote.aspx");//跳转到添加投票页
    }
    protected void imgbtnAll_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/AllVote.aspx");//跳转到所有投票页
    }
    protected void imgbtnManage_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/ManageVote.aspx");//跳转到投票项管理页
    }
}

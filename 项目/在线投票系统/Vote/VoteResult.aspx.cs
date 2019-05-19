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

public partial class VoteResult : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string P_Str_voteID = Request["voteID"];
        string P_Str_title = Server.UrlDecode(Request["title"]);
        imgVoteImage.ImageUrl = "~/ResultImage.aspx?voteID=" + P_Str_voteID + " &title=" + Server.UrlEncode (P_Str_title);
    }
    protected void imgbtnImage_Click(object sender, ImageClickEventArgs e)
    {
        Response.Write("<script>window.close();</script>");
    }
}


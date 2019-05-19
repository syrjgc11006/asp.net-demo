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
        Master.MValue = "Welcome";
    }
    protected void Page_LoadComplete(object sender, EventArgs e)
    {
        Label MLable1 = (Label)this.Master.FindControl("labMaster");
        this.labContent.Text = MLable1.Text;
    }
}

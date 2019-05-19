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
    protected void btnSelect_Click(object sender, EventArgs e)
    {
        webserver.Mobile.QQ mobile = new webserver.Mobile.QQ();
        labMessage.Text ="所在地："+mobile.Mobile(TextBox1.Text);
    }
}

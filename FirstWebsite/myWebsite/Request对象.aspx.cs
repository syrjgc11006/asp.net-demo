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

namespace myWebsite
{
    public partial class Request对象 : System.Web.UI.Page
    {
        protected void btnRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("Request.aspx?value=获取页面间的传值");
        }
    }
}

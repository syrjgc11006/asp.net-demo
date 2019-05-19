using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace ConfigTest
{
    public partial class appSettingsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ImgType = ConfigurationManager.AppSettings["ImgType"];
            Response.Write(ImgType);
        }
    }
}
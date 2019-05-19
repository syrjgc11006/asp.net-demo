using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Collections;

namespace ConfigTest
{
    public partial class SectionHandlerPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Hashtable ht = ConfigurationManager.GetSection("mySectionGroup/mySection") as Hashtable;
            foreach (DictionaryEntry de in ht)
            {
                Response.Write(de.Key + " - " + de.Value + "<br>");
            }
        }
    }
}
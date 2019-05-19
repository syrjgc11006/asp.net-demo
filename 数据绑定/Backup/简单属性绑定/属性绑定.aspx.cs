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

namespace 简单属性绑定
{
    public partial class _Default : System.Web.UI.Page
    {
        public string GoodsName
        {
            get
            {
                return "彩色电视机";
            }
        }

        public string GoodsKind
        {
            get
            {
                return "家用电器";
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.DataBind();
        }
    }
}

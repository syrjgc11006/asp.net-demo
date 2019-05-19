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

namespace 非空数据验证
{
    public partial class 自定义验证控件 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ValidateEven(object source, ServerValidateEventArgs args)
        {
            try
            {
                if ((Convert.ToInt32(args.Value) % 2) == 0)
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
            catch (Exception)
            {

                args.IsValid = false;
            }
        }

        protected void btnCheck_Click(object sender, EventArgs e)
        {

        }
    }
}

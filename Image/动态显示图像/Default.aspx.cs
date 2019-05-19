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

namespace 动态显示图像
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList arrList = new ArrayList();
            arrList.Add("我自己！");
            arrList.Add("风景！");
            if (!IsPostBack)
            {
                DropDownList1.DataSource = arrList;
                DropDownList1.DataBind();
            }
        }
        
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //用户选择DropDownList控件中的不同项时，显示不同的用户头像
            if (DropDownList1.SelectedIndex == 0)
            {
                Image1.ImageUrl = "~/SAM_3223.JPG";
            }
            else if (DropDownList1.SelectedIndex == 1)
            {
                Image1.ImageUrl = "~/IMG_20130504_170231.jpg";
            }
            else
            {
                Image1.ImageUrl = "";
            }
        }
    }
}

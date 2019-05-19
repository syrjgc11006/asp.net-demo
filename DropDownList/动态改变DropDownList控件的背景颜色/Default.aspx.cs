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
using System.Drawing;

namespace 动态改变DropDownList控件的背景颜色
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList arrList = new ArrayList();
            arrList.Add("请选择列表项");
            arrList.Add("Red");
            arrList.Add("Green");
            arrList.Add("Blue");
            arrList.Add("LightGray");
            //首次加载时绑定数据源，再次加载时不再绑定
            if (!IsPostBack)
            {
                DropDownList1.DataSource = arrList;
                DropDownList1.DataBind();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //用来记录列表控件的背景颜色
            string color = DropDownList1.SelectedItem.Value;
            switch (color)
            {
                case "Red":
                    DropDownList1.BackColor = Color.Red;
                    break;
                case "Green":
                    DropDownList1.BackColor = Color.Green;
                    break;
                case "Blue":
                    DropDownList1.BackColor = Color.Blue ;
                    break;
                case "LightGray":
                    DropDownList1.BackColor = Color.LightGray;
                    break;
                default:
                    DropDownList1.BackColor = Color.White;
                    break;
            }
        }
    }
}

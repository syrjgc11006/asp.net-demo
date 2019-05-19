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
    
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
            string url = Request.Path + "?theme=" + DropDownList1.SelectedItem.Value;
            Response.Redirect(url);
    }
    /// <summary>
    /// 使用Theme属性指定页面的主题，只能在页面的preInit事件发生过程中或者之前设置。
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    void Page_PreInit(Object sender, EventArgs e)
    {
        string theme="Theme1";
        if (Request.QueryString["theme"] == null)
        {
            theme = "Theme1";
        }
        else
        {
            theme = Request.QueryString["theme"];
        }
        Page.Theme = theme;
        ListItem item = DropDownList1.Items.FindByValue(theme);
        if (item != null)
        {
            item.Selected = true;
        }
    }

}

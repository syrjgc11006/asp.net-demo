using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

[PartialCaching(100)]
//注意使用PartialCachingAttribute类设置用户控件缓存过期时间的目的是实现使用
//PartialCachingAttribute类对用户控件的包装，否则，在ASP.NET也中调用CachePolicy
//属性获取的ControlCachPolicy实例是无效的
public partial class WebUserControl : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = DateTime.Now.ToLongTimeString();
    }

  
}




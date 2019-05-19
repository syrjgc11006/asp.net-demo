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

public partial class _Default : System.Web.UI.Page
{
    //动态加载用户控件
    protected void Page_Init(object sender, EventArgs e)
    {
        this.Label1.Text = DateTime.Now.ToLongTimeString();
        //动态加载用户控件，并返回PartialCachingControl的实例对象
        PartialCachingControl pcc = LoadControl("WebUserControl.ascx") as PartialCachingControl;
        
        
        //如果用户控件的缓存时间大于60秒，那么重新设置缓存时间为10秒
        if (pcc.CachePolicy.Duration > TimeSpan.FromSeconds(60))
        {
            //设置用户控件过期时间
            pcc.CachePolicy.SetExpires(DateTime.Now.Add(TimeSpan.FromSeconds(10)));
            //设置缓存绝对过期
            pcc.CachePolicy.SetSlidingExpiration(false);
        }
        Controls.Add(pcc);  //将用户控件添加到页面中
    }
}


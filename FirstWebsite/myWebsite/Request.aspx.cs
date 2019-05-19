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
    public partial class Request : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("使用request[string key]方法"+Request["value"]+"</br>");
            Response.Write("使用request.params[string key]方法" + Request.Params["value"] + "</br>");
            Response.Write("使用request.Querystring[string key]方法"+Request.QueryString["value"]+"</br>");

            //获取客户端浏览器信息
            HttpBrowserCapabilities b = Request.Browser;
            Response.Write("客户端浏览器信息：");
            //输入一条分隔线
            Response.Write("<hr>");
            Response.Write("类型：" + b.Type + "<br>");
            Response.Write("<hr>");
        }
    }
}

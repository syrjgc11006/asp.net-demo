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

namespace 使用session对象存储和读取数据
{
    public partial class welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("欢迎用户" + Session["UserName"].ToString() + "登录本系统!<br>");
            Response.Write("您登录的时间为：" + Session["LoginTime"].ToString());
        }
    }
}

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

namespace 用cookie对象保存和读取客户端信息
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnWrite_Click(object sender, EventArgs e)
        {
            string UserIP = Request.UserHostAddress.ToString(); //向浏览器获取信息，获取本机的ip地址
            //用于存储一个cookie变量（客户端变量）
            Response.Cookies["IP"].Value = UserIP;              //向浏览器输出信息，获取当前请求的cookies
        }

        protected void btnRead_Click(object sender, EventArgs e)
        {
            //取回cookie
            this.Label1.Text = Request.Cookies["IP"].Value;     //获取客户端发送的cookies
        }
    }
}

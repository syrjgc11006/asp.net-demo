using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Xml.Linq;

namespace chatline
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //在程序启动时运行的代码
            //建立用户在线列表
            string user = "";   //用户列表
            Application["user"] = user;
            Application["userNum"] = 0;
            string chats = "";  //聊天记录
            Application["chats"] = chats;
            Application["current"] = 0;//当前聊天记录数
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            //在新会话启动时运行的代码，可能会有多个客户端访问你的网站
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            //服务器开始请求信息时发生
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            // 在出现未处理的错误时运行的代码
            //服务器出错的时候发生
        }

        protected void Session_End(object sender, EventArgs e)
        {
            // 在会话结束时运行的代码。 
            // 注意: 只有在 Web.config 文件中的 sessionstate 模式设置为
            // InProc 时，才会引发 Session_End 事件。如果会话模式设置为 StateServer 
            // 或 SQLServer，则不会引发该事

        }

        protected void Application_End(object sender, EventArgs e)
        {
            //在应用程序关闭时运行的代码
            //当服务器关闭时运行的代码
            Application["user"] = "";
            Application["chats"] = "";
        }
    }
}
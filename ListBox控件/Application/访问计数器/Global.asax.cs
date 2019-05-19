using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Xml.Linq;

namespace 访问计数器
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //在应用程序启动时运行的代码
            //获取Appllication对象变量的数量
            Application["count"] = 0;
        }

        //当用新客户访问网站时，将建立一个session对象，并在session对象的session_start事件
        //中对application加锁，以防止多个用户同时访问页面时造成并行，同时将访问人数增加1；当用户
        //退出该网站时，将关闭该用户的session对象，同理对application对象枷锁，然后将访问人数减1
        protected void Session_Start(object sender, EventArgs e)
        {
            //在会话启动时运行的代码
            Application.Lock();
            Application["count"] = (int)Application["count"] + 1;
            Application.UnLock();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            //在会话结束时运行的代码
            //注意：只有在webconfig文件中的sessionstate模式设置为InProc时，才会引发session_End事件。如果模式设置为StateSever或者SQLServer
            //则不会引发该事件。
            Application.Lock();
            Application["count"] = (int)Application["count"] - 1;
            Application.UnLock();
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}
<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        // 在应用程序启动时运行的代码

    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  在应用程序关闭时运行的代码

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // 在出现未处理的错误时运行的代码

    }

    void Session_Start(object sender, EventArgs e) 
    {
        Session.Timeout = 1;
        // 在新会话启动时运行的代码
        Session["IP"] = Request.UserHostAddress;//获取客户端IP
        Session["LoginTime"] = DateTime.Now;//获取用户访问时间，即当前时间
        Session["Browser"] = Request.Browser.Browser;//获取用户使用的浏览器信息
        Session["OS"] = Request.Browser.Platform;//获取用户使用的操作系统信息
    }

    void Session_End(object sender, EventArgs e)
    {
        // 在会话结束时运行的代码。 
        // 注意: 只有在 Web.config 文件中的 sessionstate 模式设置为
        // InProc 时，才会引发 Session_End 事件。如果会话模式设置为 StateServer 
        // 或 SQLServer，则不会引发该事件。
        Session["LeaveTime"] = DateTime.Now;
        DB.ExSql("insert into tb_CounterInfo  (IP, LoginTime, LeaveTime, Browser, OS) values('" + Session["IP"].ToString() + "','" + Session["LoginTime"].ToString() + "','" + Session["LeaveTime"].ToString() + "','" + Session["Browser"].ToString() + "','" + Session["OS"].ToString() + "')");
    }
       
</script>

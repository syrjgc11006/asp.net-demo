<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        if (Application["Chat"] == null)
        {
            Application["Chat"] = "";
        }
        if (Application["Count"] == null || Application["Count"] == "")
        {
            Application["Count"] = 0;
        }
    }
    
    void Application_End(object sender, EventArgs e) 
    {
       

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // 在出现未处理的错误时运行的代码

    }

    void Session_Start(object sender, EventArgs e) 
    {
        
        Application.Lock();
        Application["Count"] = Convert.ToInt32(Application["Count"]) + 1;
        Application.UnLock();  
    }
    void Session_End(object sender, EventArgs e) 
    {
        Application.Lock();
        Application["Count"] = Convert.ToInt32(Application["Count"]) - 1;
        Application.UnLock(); 
    }
       
</script>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>
<%@ OutputCache Duration="10" VaryByParam="none" %>>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>设置页面缓存过期时间为当前时间加上10秒</title>
</head>

<script language ="C#" runat="server">
    void Page_Load(object sender, EventArgs e)
    {
        Response.Write("页面缓存设置示例：<br>设置缓存时间为10秒，当前时间为："+DateTime.Now.ToString()); 
    }
</script>

<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>

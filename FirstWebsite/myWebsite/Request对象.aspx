<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Request对象.aspx.cs" Inherits="myWebsite.Request对象" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>request对象</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnRedirect" runat="server" onclick="btnRedirect_Click" 
            Text="重定向" />    
    </div>
    </form>
</body>
</html>

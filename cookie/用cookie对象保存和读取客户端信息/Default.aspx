<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="用cookie对象保存和读取客户端信息._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>用cookie对象保存和读取客户端信息</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnWrite" runat="server" Text="将用户IP写入Cookie" 
            onclick="btnWrite_Click" /><br />
        <asp:Button ID="btnRead" runat="server" Text="将用户IP从Cookie中读出" 
            onclick="btnRead_Click" /><br />
       <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>&nbsp;
    </div>
    </form>
</body>
</html>

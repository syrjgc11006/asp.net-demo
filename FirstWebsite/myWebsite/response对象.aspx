<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="response对象.aspx.cs" Inherits="myWebsite.response对象" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>response将数据从服务器发送会浏览器</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="姓名:"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="姓名:"></asp:Label>
        <asp:RadioButton ID="rtbSexMan" runat="server" Text="男" />
    
        <asp:RadioButton ID="rtbSexWoman" runat="server" Text="女" />
    
    </div>
    <asp:Button ID="btnOK" runat="server" Text="确定" onclick="btnOK_Click" />
    <br />
    <asp:Button ID="btnImage" runat="server" onclick="btnImage_Click" Text="输出图像" />
    </form>
</body>
</html>

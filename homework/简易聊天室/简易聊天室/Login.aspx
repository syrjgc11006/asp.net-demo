<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web_HomeWork.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
            <asp:Label ID="Label1" runat="server" Text="Label">我的聊天室</asp:Label>
        <br /><br />
        <asp:Label ID="Label2" runat="server" Text="Label">用户名：</asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvName" runat="server" ErrorMessage="必须输入用户名" ControlToValidate="txtName" Text="*"></asp:RequiredFieldValidator><br />
            <asp:Label ID="Label3" runat="server" Text="Label">密&nbsp;&nbsp;码：</asp:Label>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator
                ID="rtfPassword" runat="server" ErrorMessage="密码不能为空" Text="*" ControlToValidate="txtPassword"></asp:RequiredFieldValidator><br />
            <asp:Button ID="btnLogin" runat="server" Text="登录" onclick="btnLogin_Click" />
        </center>

    </div>
    </form>
</body>
</html>

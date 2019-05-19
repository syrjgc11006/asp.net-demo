<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>登录</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="font-size: 9pt; width: 228px">
            <tr>
                <td style="width: 54px">
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td style="width: 54px">
                    用户名：</td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server" Width="116px">mr</asp:TextBox>(mr)</td>
            </tr>
            <tr>
                <td style="width: 54px">
                    密码：</td>
                <td>
                    <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" Width="117px">mrsoft</asp:TextBox>(mrsoft)</td>
            </tr>
            <tr>
                <td style="width: 54px">
                </td>
                <td>
                    <asp:Button ID="btnLogin" runat="server" Text="登录" OnClick="btnLogin_Click" />
                    <asp:Button ID="btnCancel" runat="server" Text="取消" OnClick="btnCancel_Click" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

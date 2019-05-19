<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>登录</title>
</head>
<body style="font-size: 9pt; text-align: center;">
    <form id="form1" runat="server">
      <table align="center" style="background-image: url(Image/登录.jpg); width: 405px; height: 265px">
            <tr>
                <td style="height: 38px">
                </td>
            </tr>
            <tr>
                <td>
        <table style="width: 353px; color: #ffffff;">
            <tr>
                <td style="width: 49px">
                    用户名：</td>
                <td style="width: 97px">
                    <asp:TextBox ID="txtUserName" runat="server" Width="98px"></asp:TextBox></td>
                <td>
                </td>
            </tr>
            <tr>
                <td style="width: 49px">
                    密 &nbsp;码：</td>
                <td style="width: 97px">
                    <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" Width="98px"></asp:TextBox></td>
                <td>
                </td>
            </tr>
            <tr>
                <td style="width: 49px">
                    验证码：</td>
                <td style="width: 97px">
                    <asp:TextBox ID="txtValidateNum" runat="server" Width="98px"></asp:TextBox></td>
                <td>
                    <asp:Image ID="Image1" runat="server" Height="22px"
                        Width="58px" ImageUrl="~/ValidateNum.aspx" />请输入图片中验证码！</td>
            </tr>
            <tr>
                <td style="width: 49px">
                </td>
                <td colspan="2" align="left">
                    <asp:Button ID="btnLogin" runat="server" Text="登录" OnClick="btnLogin_Click" ForeColor="DodgerBlue" /><asp:Button ID="btnRegister"
                        runat="server" Text="注册" OnClick="btnRegister_Click" ForeColor="DodgerBlue" /></td>
            </tr>
        </table>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="chatline.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>登录</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="center" cellpadding="0" cellspacing="0" 
            style="width: 330px; height: 158px">
        <tr>
            <td colspan="2" 
                style="font-weight: bold; font-size: 16pt; color: #ffffff; background-color: #0000FF; text-align: center;"> 登录</td>                         
        </tr>
        <tr>
            <td style="font-size: 16pt; background-color: #f7f6f3; text-align: center">用户名：</td>
            <td style="background-color: #f7f6f3; text-align: center">
                <asp:TextBox ID="txtname" runat="server" Height="28px" 
                    style="margin-left: 0px" Width="143px"></asp:TextBox>
                    </td>
        </tr>
        <tr>
            <td style="background-color: #f7f6f3">
                &nbsp;</td>
            <td style="background-color: #f7f6f3; text-align: center">
                <asp:Button ID="btnLogin" runat="server" Text="登录" Font-Size="9pt" 
                    Height="28px" style="padding-left: 0px" Width="65px" 
                    onclick="btnLogin_Click" />
                &nbsp;
                <asp:Button ID="btnExit" runat="server" Text="退出" Font-Size="9pt" Height="31px" 
                    Width="66px" onclick="btnExit_Click" />
                    </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>

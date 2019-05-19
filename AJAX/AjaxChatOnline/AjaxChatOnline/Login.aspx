<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>用户登录</title>
    <script src="Ajax.js" type="text/javascript"></script>
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
        <table border="1" cellpadding="0" cellspacing="0" style="width: 336px; height: 194px">
            <tr>
                <td style="width: 100px; text-align: center">
        <table style="width: 300px; height: 184px" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td colspan="2" style="height: 27px">
                    <strong><em><span style="font-size: 16pt">
                    欢迎来到聊天室</span></em></strong></td>
            </tr>
            <tr>
                <td style="width: 60px; text-align: right; height: 27px;">
                    用户名</td>
                <td style="width: 100px; text-align: left; height: 27px;">
                    <input id="yhm" type="text" maxlength="20" /></td>
            </tr>
            <tr>
                <td style="width: 60px; text-align: right; height: 29px;">
                    密 码&nbsp;
                </td>
                <td style="width: 100px; text-align: left; height: 29px;">
                    <input id="mima" type="password" /></td>
            </tr>
            <tr>
                <td colspan="2" id="msg">
                </td>
            </tr>
            <tr>
                <td style="width: 60px">
                </td>
                <td style="width: 100px">
                    <input id="dl" type="button" value="登录" onclick="Login()" style="width: 62px" /><a href="UserReg.aspx">注册</a></td>
            </tr>
        </table>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

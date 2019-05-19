<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserReg.aspx.cs" Inherits="UserReg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>用户注册</title>
    <script src="Ajax.js" type="text/javascript"></script>
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
        <table border="0" cellpadding="0" cellspacing="0" style="width: 364px; height: 150px">
            <tr>
                <td style="height: 16px; width: 80px;">
                </td>
                <td style="width: 178px; height: 16px">
        用户注册
                </td>
            </tr>
            <tr>
                <td style="width: 80px; text-align: right">
                    用户名</td>
                <td style="width: 178px; text-align: left;">
                    <input id="yhm" type="text" /></td>
            </tr>
            <tr>
                <td style="width: 80px; text-align: right">
                    &nbsp;密码</td>
                <td style="width: 178px; text-align: left;">
                    <input id="mima" type="text" /></td>
            </tr>
            <tr>
                <td style="width: 80px; text-align: right">
                    &nbsp;密码确认</td>
                <td style="width: 178px; text-align: left;">
                    <input id="remima" type="text" /></td>
            </tr>
            <tr>
                <td style="width: 80px">
                    &nbsp;</td>
                <td style="width: 178px; text-align: left;">
                    <input id="Button1" type="button" value="注册" onclick="Reg()" />
                    <a href="Login.aspx">返回登录</a></td>
            </tr>
        </table>
    </form>
</body>
</html>

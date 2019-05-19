<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="使用session对象存储和读取数据.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>登录</title>
    <style type="text/css">
        .style1
        {
            padding: 0;
            margin: 0;
            width: 85px;
            letter-spacing: 0;
        }
        .style3
        {
            width: 114px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        <table style="width: auto; height: 73px;">
            <tr>
                <td class="style1" bgcolor="#66CCFF" style="text-align: center">
                    用户名：</td>
                <td class="style3" rowspan="1" align="center" style="padding: 0px; margin: 0px">
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                </td>             
            </tr>
            <tr>
                <td class="style1" bgcolor="#66CCFF" style="text-align: center">
                    密码：</td>
                <td class="style3">
                    <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
                </td>                
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style3">
                    <asp:Button ID="btnLogin" runat="server" onclick="btnLogin_Click" Text="登录" />
                    <asp:Button ID="btnCancel" runat="server" onclick="btnCancel_Click" Text="取消" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

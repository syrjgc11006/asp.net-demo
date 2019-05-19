<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="自定义验证控件.aspx.cs" Inherits="非空数据验证.自定义验证控件" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>自定义验证控件</title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        <table style="width: auto;">
            <tr>
                <td colspan="2">
                    自定义验证</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    请输入一个偶数：</td>
                <td>
                    <asp:TextBox ID="txtNum" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" 
                        ControlToValidate="txtNum" ErrorMessage="您输入的不是偶数" 
                        onservervalidate="ValidateEven"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnCheck" runat="server" Text="验证" onclick="btnCheck_Click" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

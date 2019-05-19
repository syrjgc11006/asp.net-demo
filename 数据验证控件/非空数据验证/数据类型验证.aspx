<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="数据类型验证.aspx.cs" Inherits="非空数据验证.数据类型验证" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>数据类型控件验证</title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        <table style="width: auto;">
            <tr>
                <td colspan="2">
                    用户信息</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    姓名：</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtName" ErrorMessage="姓名不能为空" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    密码：</td>
                <td>
                    <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    确认密码:</td>
                <td>
                    <asp:TextBox ID="txtRePwd" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="CompareValidator2" runat="server" 
                        ControlToCompare="txtPwd" ControlToValidate="txtRePwd" 
                        ErrorMessage="确认密码与密码不匹配"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>
                    出生日期：</td>
                <td>
                    <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToValidate="txtDate" ErrorMessage="日期格式有误" Operator="DataTypeCheck" 
                        SetFocusOnError="True" Type="Date"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnCheck" runat="server" Text="验证" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

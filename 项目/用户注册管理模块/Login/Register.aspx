<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>注册</title>
</head>
<body style="font-size: 9pt; text-align: center;">
    <form id="form1" runat="server">
    <div>
        &nbsp;</div>
        <table style="background-image: url(Image/注册.jpg); width: 501px; height: 300px">
            <tr>
                <td style="height: 57px">
                </td>
            </tr>
            <tr>
                <td style="height: 203px">
        <table style="font-size: 9pt; width: 367px; height: 136px">
            <tr>
                <td style="width: 62px">
                    用户名：</td>
                <td style="width: 114px">
                    <asp:TextBox ID="txtUserName" runat="server" Width="98px"></asp:TextBox><asp:RequiredFieldValidator
                        ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                <td style="width: 164px; color: #000000;" align="left">
                    <asp:LinkButton ID="lnkbtnCheck" runat="server" CausesValidation="False" OnClick="lnkbtnCheck_Click">检测用户名是否存在</asp:LinkButton></td>
            </tr>
            <tr style="color: #000000; text-decoration: underline">
                <td style="width: 62px; height: 28px">
                    密码：</td>
                <td style="width: 114px; height: 28px">
                    <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" Width="98px"></asp:TextBox><asp:RequiredFieldValidator
                        ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPwd" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                <td style="width: 164px; height: 28px" align="left">
                </td>
            </tr>
            <tr>
                <td style="width: 62px">
                    确认密码：</td>
                <td style="width: 114px">
                    <asp:TextBox ID="txtRepwd" runat="server" TextMode="Password" Width="98px"></asp:TextBox><asp:RequiredFieldValidator
                        ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtRepwd" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                <td style="width: 164px" align="left">
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPwd"
                        ControlToValidate="txtRepwd" ErrorMessage="确认密码不符!"></asp:CompareValidator></td>
            </tr>
            <tr>
                <td style="width: 62px; height: 26px">
                    Email：</td>
                <td style="width: 114px; height: 26px">
                    <asp:TextBox ID="txtEmail" runat="server" Width="98px"></asp:TextBox><asp:RequiredFieldValidator
                        ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtEmail" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                <td style="width: 164px; height: 26px" align="left">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail"
                        ErrorMessage="Email格式不正确！" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td style="width: 62px; height: 15px">
                </td>
                <td colspan="2" style="color: red; height: 15px">
                    以上内容为必填项，请正确填写，否则无法完成注册！</td>
            </tr>
            <tr>
                <td style="width: 62px; height: 26px">
                </td>
                <td style="width: 114px; height: 26px">
                    <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="注册" />
                    <asp:Button ID="btnBack" runat="server" CausesValidation="False" OnClick="btnBack_Click"
                        Text="返回" /></td>
                <td style="width: 164px; height: 26px">
                </td>
            </tr>
        </table>
                </td>
            </tr>
            <tr>
                <td>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

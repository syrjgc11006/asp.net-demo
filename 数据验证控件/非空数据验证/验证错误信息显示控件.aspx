<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="验证错误信息显示控件.aspx.cs" Inherits="非空数据验证.验证错误信息显示控件" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>验证错误信息显示</title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        <table style="width: 440px; height: 173px;">
            <tr>
                <td colspan="2">
                    学生成绩信息</td>
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
                    数学：</td>
                <td>
                    <asp:TextBox ID="txtMath" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" 
                        ControlToValidate="txtMath" ErrorMessage="分数在0~100之间" MaximumValue="100" 
                        MinimumValue="0" SetFocusOnError="True" Type="Integer"></asp:RangeValidator>
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
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

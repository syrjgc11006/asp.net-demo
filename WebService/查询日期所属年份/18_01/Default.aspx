<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 478px">
            <tr>
                <td>
                    万年历</td>
            </tr>
            <tr>
                <td>
                    输入年份：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:Button ID="btnCalculate" runat="server" Text="计算" OnClick="btnCalculate_Click" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                        ErrorMessage="*"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TextBox1"
                        ErrorMessage="日期格式不正确!" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="labMessage" runat="server"></asp:Label></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

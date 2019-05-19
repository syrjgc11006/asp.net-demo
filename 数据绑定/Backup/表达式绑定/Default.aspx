<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="表达式绑定._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>表达式绑定</title>
    <style type="text/css">
        .style1
        {
            height: 26px;
        }
        .style2
        {
            height: 33px;
        }
        .style3
        {
            height: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        <table style="width:322px; height: 157px;">
            <tr>
                <td colspan="3" class="style3">
                    表达式绑定</td>

            </tr>
            <tr>
                <td class="style2">
                    单价：</td>
                <td class="style2">
                    <asp:TextBox ID="TextBox1" runat="server">0</asp:TextBox>
                </td>
                <td class="style2">
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToValidate="TextBox1" ErrorMessage="请输入double型数据" 
                        Operator="DataTypeCheck" Type="Double"></asp:CompareValidator>
                </td>

            </tr>
            <tr>
                <td class="style1">
                    数量：</td>
                <td class="style1">
                    <asp:TextBox ID="TextBox2" runat="server">0</asp:TextBox>
                </td>
                <td class="style1">
                    <asp:CompareValidator ID="CompareValidator2" runat="server" 
                        ControlToValidate="TextBox2" ErrorMessage="请输入整形数据" Operator="DataTypeCheck" 
                        Type="Integer"></asp:CompareValidator>
                </td>

            </tr>
            <tr>
                <td colspan="3">
                    <asp:Button ID="btnOk" runat="server" Text="确定" onclick="btnOk_Click" />
                </td>

            </tr>
            <tr>
                <td>
                    总金额为：</td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text='<%#"总金额为："+Convert.ToString(Convert.ToDecimal(TextBox1.Text) * Convert.ToInt32(TextBox2.Text)) %>'></asp:Label>
                </td>
                <td>
                    &nbsp;</td>

            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

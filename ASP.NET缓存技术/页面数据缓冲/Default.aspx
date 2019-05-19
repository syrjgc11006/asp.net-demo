<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <style >
    body:{margin-top:0px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style ="font-size :9pt">
        <table style="width: 253px; height: 53px">
            <tr>
                <td colspan="2" align =left >
                    &nbsp; &nbsp; &nbsp; &nbsp;
                   页面数据缓存的应用</td>
            </tr>
             <tr>
                <td colspan="2">
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="添加" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="检索" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="移除" /></td>
            </tr>
            <tr>
                <td colspan="2">
        <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan"
            BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
            <FooterStyle BackColor="Tan" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
        </asp:GridView>
            </td>
            </tr>
           
            <tr>
                <td colspan="2">
        <asp:Label ID="Label1" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2">
        <asp:Label ID="Label2" runat="server"></asp:Label></td>
            </tr>
        </table>
        <br />
        </div>
    </form>
</body>
</html>

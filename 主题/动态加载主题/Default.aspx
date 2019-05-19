<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>动态加载主题</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    动态加载主题<br />
        <table>
            <tr>
                <td style="width: 100px">
                    选择主题：</td>
                <td style="width: 100px">
                    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem Value="Theme1">主题一</asp:ListItem>
                        <asp:ListItem Value="Theme2">主题二</asp:ListItem>
                    </asp:DropDownList></td>
                <td style="width: 100px">
                <a href ="default.aspx">返回</a>
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                    默认外观：</td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                    命名外观：</td>
                <td style="width: 100px">
                    <asp:TextBox SkinID="textboxSkin" ID="TextBox2" runat="server" ></asp:TextBox></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                    <input id="Button1" type="button" value="button" /></td>
                <td style="width: 100px">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

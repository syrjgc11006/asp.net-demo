<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default"　Theme="TextBoxSkin"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>创建一个简单的外观</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td style="width: 100px">
                    默认外观：</td>
                <td style="width: 247px">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    命名外观：</td>
                <td style="width: 247px">
                    <asp:TextBox ID="TextBox2" runat="server" SkinID ="textboxSkin"></asp:TextBox></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>

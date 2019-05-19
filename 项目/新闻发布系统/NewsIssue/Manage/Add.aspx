<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="manage_fzAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>添加新闻信息</title>
    <link href="../css/css.css" rel="stylesheet" type="text/css" /> 
</head>
<body style="margin-top: 0px; padding-top: 0px">
    <form id="form1" runat="server">
    <div>
        <table class="txt" style="width: 545px; height: 303px">
            <tr>
                <td align="center" class="title" colspan="3">
                    新闻添加『<asp:Label ID="labTitle" runat="server" Text="Label"></asp:Label>』</td>
            </tr>
            <tr>
                <td style="width: 66px">
                    新闻类别：</td>
                <td style="width: 324px">
                    <asp:DropDownList ID="ddlNewsType" runat="server" Width="116px" AutoPostBack="True" CssClass="css">
                        <asp:ListItem>国际新闻</asp:ListItem>
                        <asp:ListItem>国内新闻</asp:ListItem>
                    </asp:DropDownList></td>
                <td style="width: 85px">
                </td>
            </tr>
            <tr>
                <td style="width: 66px">
                    新闻标题：</td>
                <td style="width: 324px">
                    <asp:TextBox ID="txtNewsTitle" runat="server" CssClass="txt" MaxLength="15" Width="200px"></asp:TextBox>(控制在15个字符以内)</td>
                <td style="width: 85px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNewsTitle"
                        ErrorMessage="**"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 66px">
                    新闻内容：</td>
                <td style="width: 324px">
                    <asp:TextBox ID="txtNewsContent" runat="server" Height="211px" TextMode="MultiLine" Width="384px" CssClass="txt"></asp:TextBox></td>
                <td style="width: 85px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNewsContent"
                        ErrorMessage="**"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 66px">
                </td>
                <td align="center" style="width: 324px">
                    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="添　加" Width="66px" />
                    <asp:Button ID="btnReset" runat="server" CausesValidation="False" OnClick="btnReset_Click"
                        Text="重　置" /></td>
                <td style="width: 85px">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="showNews.aspx.cs" Inherits="showNews" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>新闻具体内容</title>
    <link href="css/css.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 500px; height: 200px">
            <tr>
                <td align="center" colspan="3" style="height: 30px;" >
                    <asp:Label ID="labTitle" runat="server" CssClass="title"  Text="Label"
                        Width="373px"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:TextBox ID="txtContent" runat="server" CssClass="txt" Height="159px" TextMode="MultiLine"
                        Width="486px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 144px; height: 19px">
                </td>
                <td align="center" style="width: 12px; height: 19px">
                    <asp:Button ID="btnClose" runat="server" OnClick="btnClose_Click" Text="关闭窗口" Width="103px" /></td>
                <td style="width: 127px; height: 19px">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

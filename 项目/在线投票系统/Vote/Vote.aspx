<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Vote.aspx.cs" Inherits="Vote" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>投票页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
        <table border="0" cellpadding="0" cellspacing="0" style="width: 546px; height: 373px">
            <tr>
                <td colspan="1" style="background-image: url(Image/子页切/子页1.jpg); width: 546px; height: 102px">
                </td>
            </tr>
            <tr>
                <td style="background-image: url(Image/子页切/子页2.jpg); width: 546px; height: 271px"
                    valign="top" align="center">
        <table style="width: 398px" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td style="width: 47px; height: 20px">
                </td>
                <td style="height: 20px" align="right">
                    <asp:HyperLink ID="hpLinkBack" runat="server" NavigateUrl="~/AllVote.aspx" ImageUrl="~/Image/子页切/返回按钮.jpg">返回</asp:HyperLink>
                    &nbsp;&nbsp;
                </td>
            </tr>
            <tr style="color: #000000">
                <td style="width: 47px">
                </td>
                <td align="left">
                    还等什么！赶快投票吧！</td>
            </tr>
            <tr>
                <td style="width: 47px">
                </td>
                <td align="left">
                    <asp:Label ID="labVoteTitle" runat="server" ForeColor="#C04000"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 47px">
                </td>
                <td align="left">
                    <asp:RadioButtonList ID="rblVoteItem" runat="server" ForeColor="#C04000">
                    </asp:RadioButtonList></td>
            </tr>
            <tr>
                <td style="width: 47px">
                </td>
                <td align="left">
                    <asp:Button ID="btnVote" runat="server" OnClick="btnVote_Click" Text="我要投票"/>
                   <asp:Button ID="btnResult" runat="server" Text="查看结果" OnClick="btnResult_Click" /></td>
            </tr>
        </table>
                </td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>

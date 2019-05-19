<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AllVote.aspx.cs" Inherits="AllVote" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>全部投票</title>
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
    <div  style="background-image: url(Image/主页切/投票主页大背景.jpg); width: 546px; height: 373px">
        <table border="0" cellpadding="0" cellspacing="0" style="height: 82px">
            <tr>
                <td style="background-image: url(Image/子页切/子页1.jpg); width: 546px; height: 102px">
                </td>
            </tr>
        </table>
        <table style="width: 546px; background-image: url(Image/子页切/子页2.jpg); height: 250px;" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td style="width: 115px">
                </td>
                <td style="width: 353px" align="right">
                    <asp:HyperLink ID="hpLinkBack" runat="server" NavigateUrl="~/Default.aspx" ImageUrl="~/Image/子页切/返回按钮.jpg">返回</asp:HyperLink>
                    &nbsp; &nbsp;&nbsp;
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td style="width: 115px">
                </td>
                <td style="width: 353px" align="left">
                    以下列出的是本系统的全部投票主题，选择你感兴趣的进行投票吧！</td>
                <td>
                </td>
            </tr>
            <tr>
                <td style="width: 115px; height: 150px">
                </td>
                <td style="width: 353px; height: 150px" align="left" valign="top">
                    <asp:DataList ID="dlVote" runat="server">
                        <ItemTemplate>
                            <asp:HyperLink ID="HplinkVoteTitle" runat="server" NavigateUrl='<%# "~/Vote.aspx?voteID="+DataBinder.Eval(Container.DataItem,"voteID") %>' Text='<%# DataBinder.Eval(Container.DataItem,"voteTitle") %>' ForeColor="#C04000"></asp:HyperLink>
                        </ItemTemplate>
                        <ItemStyle ForeColor="#C04000" />
                    </asp:DataList></td>
                <td style="height: 150px">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

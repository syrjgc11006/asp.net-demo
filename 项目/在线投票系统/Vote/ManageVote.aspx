<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ManageVote.aspx.cs" Inherits="ManageVote" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>管理投票</title>
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
                    <table style="width: 400px" border="0" cellpadding="0" cellspacing="0">
                        <tr>
                            <td style="width: 462px">
                            </td>
                            <td align="right" style="width: 462px">
                                <asp:ImageButton ID="imgbtnBack" runat="server" ImageUrl="~/Image/子页切/返回按钮.jpg" OnClick="imgbtnBack_Click" />
                                &nbsp;&nbsp;
                            </td>
                        </tr>
            <tr>
                <td style="width: 462px">
                </td>
                <td style="width: 462px">
                    <asp:DataList ID="dlVoteManage" runat="server" GridLines="Horizontal" OnDeleteCommand="dlVoteManage_DeleteCommand">
                        <ItemTemplate>
                            <table style="width: 333px" border="0" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td style="width: 288px" align="left">
                                        <asp:Label ID="labTitle" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"voteTitle") %>' ForeColor="#C04000"></asp:Label></td>
                                    <td style="width: 45px">
                                        <asp:Button ID="btnDelete" runat="server" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"voteID") %>'
                                            CommandName="delete" Text="删除" CausesValidation="False" OnLoad="btnDelete_Load" /></td>
                                </tr>
                            </table>
                        </ItemTemplate>
                        <ItemStyle Font-Size="10pt" />
                    </asp:DataList></td>
            </tr>
        </table>
                </td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>

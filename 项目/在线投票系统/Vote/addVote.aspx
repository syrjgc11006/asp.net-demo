<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addVote.aspx.cs" Inherits="addVote"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>添加投票</title>
</head>
<body >
    <form id="form1" runat="server">
    <div style="text-align: center">
        <table style="width: 546px; height: 373px;" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td colspan="1" style="width: 546px; height: 102px; background-image: url(Image/子页切/子页1.jpg);">
                </td>
            </tr>
            <tr>
                <td style="background-image: url(Image/子页切/子页2.jpg); width: 546px; height: 271px" valign="top" align="center">
                    <table style="width: 411px; font-size: 10pt; height: 205px;" cellpadding="0" cellspacing="0">
                        <tr>
                            <td style="width: 73px; height: 20px">
                            </td>
                            <td style="height: 20px">
                            </td>
                            <td align="right" style="height: 20px; width: 266px;">
                                <asp:ImageButton ID="imgbtnBack" runat="server" CausesValidation="False" ImageUrl="~/Image/子页切/返回按钮.jpg"
                                    OnClick="imgbtnBack_Click" />&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</td>
                            <td align="right" style="height: 20px">
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 73px; height: 20px">
                            </td>
                            <td style="width: 56px; height: 20px">
                    标题：</td>
                            <td style="height: 20px; width: 266px;">
                    <asp:TextBox ID="txtTitle" runat="server" Width="138px"></asp:TextBox><asp:RequiredFieldValidator
                        ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTitle" ErrorMessage="*"></asp:RequiredFieldValidator>&nbsp;
                                <asp:ImageButton ID="imgbtnAdd" runat="server" ImageUrl="~/Image/子页切/添加按钮.jpg" OnClick="imgbtnAdd_Click" /></td>
                            <td style="height: 20px">
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 73px; height: 140px">
                            </td>
                            <td style="height: 140px;">
                            </td>
                            <td style="height: 165px; width: 266px;" valign="top">
                    <asp:Panel ID="panelItem" runat="server" Height="140px" Width="125px">
                        <table style="width: 209px; font-size: 10pt; height: 140px;" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td align="right" style="width: 200px; height: 20px;">
                                    <asp:ImageButton ID="imgbtnClose" runat="server" CausesValidation="False" ImageUrl="~/Image/关闭.bmp"
                                        OnClick="imgbtnClose_Click" /></td>
                            </tr>
                            <tr>
                                <td>
                                    请在下面输入投票选项：</td>
                            </tr>
                            <tr>
                                <td style="width: 200px; height: 20px;">
                                    <asp:TextBox ID="txtItem" runat="server" Width="138px"></asp:TextBox><asp:RequiredFieldValidator
                                        ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtItem" ErrorMessage="*" Enabled="False"></asp:RequiredFieldValidator><asp:LinkButton ID="lnkbtnAddItem" runat="server" OnClick="lnkbtnAddItem_Click" ForeColor="Black">插入</asp:LinkButton></td>
                            </tr>
                            <tr>
                                <td style="width: 200px; height: 62px;">
                                    <asp:ListBox ID="lbItem" runat="server" Width="138px" Height="60px"></asp:ListBox><asp:LinkButton ID="lnkbtnRemove" runat="server" CausesValidation="False" OnClick="lnkbtnRemove_Click" ForeColor="Black">移除</asp:LinkButton></td>
                            </tr>
                        </table>
                    </asp:Panel>
                            </td>
                            <td style="height: 165px" valign="top">
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

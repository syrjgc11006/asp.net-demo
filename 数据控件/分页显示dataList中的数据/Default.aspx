<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>分页显示DataList中的数据</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
 <table style="width: 590px; height: 218px;" cellpadding="0" cellspacing="0">
            <tr>
                <td style="width: 112px; height: 240px">
                    <asp:DataList ID="DataList1" runat="server" Width="239px" CellPadding="0" 
                        Height="61px">
                        <HeaderTemplate>
                            <table border="1" cellpadding="0" cellspacing="0" style="width: 300px; text-align: center;">
                                <tr>
                                    <td colspan="4" style="font-size: 16pt; color: #006600; text-align: center">
                                       分页显示DataList控件中的数据</td>
                                </tr>
                                <tr>
                                    <td style="height: 19px; width: 50px; color: #669900;">
                                        编号</td>
                                    <td style="height: 19px; width: 50px; color: #669900;">
                                        姓名</td>
                                    <td style="height: 19px; width: 50px; color: #669900;">
                                        性别</td>
                                    <td style="width: 150px; height: 19px; color: #669900;">
                                        爱好</td>
                                </tr>
                            </table>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <table border="1" cellpadding="0" cellspacing="0" style="width: 300px; color: #000000;
                                text-align: center;">
                                <tr>
                                    <td style="height: 21px; width: 50px; color: #669900;">
                                        <asp:Label ID="lblStuID" runat="server" Text='<%# Eval("stuID") %>'></asp:Label></td>
                                    <td style="height: 21px; width: 50px; color: #669900;">
                                        <asp:Label ID="lblStuName" runat="server" Text='<%# Eval("stuName") %>'></asp:Label></td>
                                    <td style="height: 21px; width: 50px; color: #669900;">
                                        <asp:Label ID="lblStuSex" runat="server" Text='<%# Eval("stuSex") %>'></asp:Label></td>
                                    <td style="width: 150px; height: 21px; color: #669900;">
                                        <asp:Label ID="lblstuHobby" runat="server" Text='<%# Eval("stuHobby") %>'></asp:Label></td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
            </tr>
            <tr>
                <td style="width: 112px; height: 12px">
                    <table style="width: 413px" cellpadding="0" cellspacing="0">
                        <tr>
                            <td style="width: 71px; height: 4px" valign="middle">
                                共有<asp:Label ID="labCount" runat="server" ForeColor="#FF3300" Width="12px"/>页</td>
                            <td style="width: 73px; height: 4px" valign="middle">
                                当前<asp:Label ID="labNowPage" runat="server" ForeColor="Brown">1</asp:Label>页</td>
                            <td style="width: 46px; height: 4px" valign="middle">
                                <asp:LinkButton ID="lnkbtnFirst" runat="server" CausesValidation="False"
                                    Font-Underline="False" ForeColor="Black" OnClick="lnkbtnFirst_Click" Width="43px">首页</asp:LinkButton></td>
                            <td style="width: 55px; height: 4px" valign="middle">
                                <asp:LinkButton ID="lnkbtnFront" runat="server" CausesValidation="False" 
                                    Font-Underline="False" ForeColor="Black" OnClick="lnkbtnFront_Click" Width="62px">上一页</asp:LinkButton></td>
                            <td style="width: 51px; height: 4px" valign="middle">
                                <asp:LinkButton ID="lnkbtnNext" runat="server" CausesValidation="False" 
                                    Font-Underline="False" ForeColor="Black" OnClick="lnkbtnNext_Click" Width="61px">下一页</asp:LinkButton></td>
                            <td style="width: 29px; height: 4px" valign="middle">
                                <asp:LinkButton ID="lnkbtnLast" runat="server" CausesValidation="False" Font-Overline="False"
                                    Font-Underline="False" ForeColor="Black" OnClick="lnkbtnLast_Click" Width="38px">尾页</asp:LinkButton></td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>

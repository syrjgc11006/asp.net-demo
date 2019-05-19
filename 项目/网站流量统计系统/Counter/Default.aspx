<%@ Page Language="C#" MasterPageFile="~/Counter.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="font-size: 9pt; width: 581px">
        <tr>
            <td style="font-weight: bold; font-size: 18pt" align="center">
                概况统计</td>
        </tr>
        <tr>
            <td align="left">
                统计日期：<asp:Label ID="labCountDate" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 581px" align="center">
                <table style="font-size: 9pt; width: 326px; text-align: left;">
                    <tr>
                        <td style="width: 174px">
                            本日访问人数：</td>
                        <td>
                            <asp:Label ID="labCountDay" runat="server" Text="Label"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 174px">
                            本周访问人数：</td>
                        <td>
                            <asp:Label ID="labCountWeek" runat="server" Text="Label"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 174px">
                            本月访问人数：</td>
                        <td>
                            <asp:Label ID="labCountMonth" runat="server" Text="Label"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 174px">
                            最高日访问量：</td>
                        <td>
                            <asp:Label ID="labMaxCountDay" runat="server" Text="Label"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 174px">
                            最高日访问日期：</td>
                        <td>
                            <asp:Label ID="labMaxCountDayDate" runat="server" Text="Label"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 174px">
                            最高月访问量：</td>
                        <td>
                            <asp:Label ID="labMaxCountMonth" runat="server" Text="Label"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 174px">
                            最高月访问日期：</td>
                        <td>
                            <asp:Label ID="labMaxCountMonthDate" runat="server" Text="Label"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 174px">
                            最高年访问量：</td>
                        <td>
                            <asp:Label ID="labMaxCountYear" runat="server" Text="Label"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 174px">
                            最高年访问日期：</td>
                        <td>
                            <asp:Label ID="labMaxCountYearDate" runat="server" Text="Label"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 174px">
                            常用浏览器：</td>
                        <td>
                            <asp:Label ID="labBrowser" runat="server" Text="Label"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 174px">
                            常用操作系统：</td>
                        <td>
                            <asp:Label ID="labOS" runat="server" Text="Label"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 174px">
                            总访问人数：</td>
                        <td>
                            <asp:Label ID="labTotalCount" runat="server" Text="Label"></asp:Label></td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>


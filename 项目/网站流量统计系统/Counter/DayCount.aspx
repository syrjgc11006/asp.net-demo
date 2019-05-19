<%@ Page Language="C#" MasterPageFile="~/Counter.master" AutoEventWireup="true" CodeFile="DayCount.aspx.cs" Inherits="DayCount" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="font-size: 9pt; width: 508px">
        <tr>
            <td>
                当日访问统计</td>
        </tr>
        <tr>
            <td>
                日期：<asp:Label ID="labDay" runat="server" Text="Label"></asp:Label>&nbsp;&nbsp;本日累计：<asp:Label ID="labTotal" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td>
                <asp:DataList ID="DataList1" runat="server">
                    <ItemTemplate>
                        <table style="font-size: 9pt; width: 472px">
                            <tr>
                                <td align="left" style="width: 85px">
                                    <asp:Label ID="labTime" runat="server" Text='<%# Time(Container.ItemIndex)%>'></asp:Label></td>
                                <td align="left" style="width: 67px">
                                    <asp:Label ID="labCount" runat="server" Text='<%# Count(Container.ItemIndex)%>'></asp:Label></td>
                                <td align="left" style="width: 200px">
                                    <asp:Image ID="imgPercent" runat="server" ImageUrl="~/Image/bar1.gif" Width='<%# Percent(Container.ItemIndex)*150 %>' Height ="9px" />
                                <%# Convert.ToInt32(Percent(Container.ItemIndex) * 100)%>%</td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <HeaderTemplate>
                        <table style="font-size: 9pt; width: 472px">
                            <tr>
                                <td align="left" style="width: 85px">
                                    日期</td>
                                <td align="left" style="width: 67px">
                                    人数</td>
                                <td align="left" style="width: 200px">
                                    比例</td>
                            </tr>
                        </table>
                    </HeaderTemplate>
                    <HeaderStyle Font-Bold="True" />
                </asp:DataList></td>
        </tr>
    </table>
</asp:Content>


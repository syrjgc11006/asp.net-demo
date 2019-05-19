<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="search.aspx.cs" Inherits="search" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table style="height: 580px; width :778px; margin-top: 0px; padding-top: 0px; background-color: #ffffff; font-size :9pt" align="center" class="txt" cellspacing="0" cellpadding="0" background ="Images/新闻发布系统二级页.jpg">
            <tr style=" height: 48px; width: 778px;">
                <td colspan="2" style=" height: 48px; width: 778px;">
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
                   <asp:Label ID="labSC" runat="server" Text="Label" Width="488px"></asp:Label></td>
            </tr>
            <tr style=" height: 40px; width: 778px;">
            <td ></td>
            </tr>
            <tr style=" height: 500px; width: 778px;">
                <td style=" height: 490px; width: 100px;"> </td>
                <td  style="width: 678px;" valign =top >
                    <asp:DataList ID="dlNews" runat="server"  OnItemCommand="dlNews_ItemCommand" BackColor="White">
                        <ItemTemplate>
                            <table border="0" cellspacing="0"  style="width: 100%; height: 100%; margin-top: 0px; padding-top: 0px; font-size :9pt" align =center>
                                <tr>
                                    <td align="left" style="border-bottom: 1px dashed #000000;width: 150px; height: 21px;">
                                        &nbsp; ·&nbsp;
                                        『
                                        <%# DataBinder.Eval(Container.DataItem,"type")%>
                                        』</td>
                                    <td style="border-bottom: 1px dashed #000000;" align="left">
                                        <asp:LinkButton ID="lbtnTitle" runat="server" CommandName="select"><%# DataBinder.Eval(Container.DataItem,"title") %></asp:LinkButton>
                                        </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                        <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" ForeColor="Blue" HorizontalAlign="Center" />
                    </asp:DataList></td>
            </tr>
           
        </table>
</asp:Content>


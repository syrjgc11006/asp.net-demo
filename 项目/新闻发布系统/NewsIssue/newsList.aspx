<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="newsList.aspx.cs" Inherits="newsList" Title="分类显示新闻" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="height: 580px; width :778px; font-size :9pt" align="center" cellspacing="0" background ="Images/新闻发布系统二级页.jpg">
            <tr style =" width :778px;height: 38px">
                <td colspan="2" style=" height: 38px; font-size :9pt">
                    &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;
                    <asp:Label ID="labTitle" runat="server"  Text="" Width="363px"></asp:Label></td>
            </tr>
            <tr style =" width :778px;height: 38px">
                <td colspan="2" style=" height: 19px; font-size :9pt" valign =middle>
                      &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;
                     <asp:Image ID="imageTitle" runat="server" Height="19px" ImageUrl="~/Images/二级页时政要闻.jpg" Width="486px" />
                    </td>
            </tr>
            <tr style =" width :778px;height: 504px">
                <td align="center" style="width: 178px; height: 154px" valign =top >
                <asp:Image ID="imageLag" runat="server" Height="79px" ImageUrl="~/Images/图片时政要闻.jpg" Width="86px" />
                </td>
                <td  style="width :600px; height: 350px; font-size :9pt" valign =top >
                    <asp:DataList ID="dlNews" runat="server"  OnItemCommand="dlNews_ItemCommand">
                        <ItemTemplate>
                            <table border="0" cellspacing="0"  style="width: 100%; height:100%; padding-left: 0px; margin-left: 0px; margin-top: 0px; padding-top: 0px; font-size :9pt ">
                                <tr>
                                    <td align="left" style="width: 90px; height: 21px;border-bottom: 1px dashed #000000;">
                                        『
                                        <%# DataBinder.Eval(Container.DataItem,"type")%>
                                        』</td>
                                    <td align="left" style="height: 21px;border-bottom: 1px dashed #000000;">
                                        <asp:LinkButton ID="lbtnTitle" runat="server" CommandName="select"><%# DataBinder.Eval(Container.DataItem,"title") %></asp:LinkButton></td>
                                </tr>
                            </table>
                        </ItemTemplate>
                        <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                            Font-Underline="False" ForeColor="Blue" HorizontalAlign="Center" />
                    </asp:DataList>
                     <table style="width: 500px" cellpadding="0" cellspacing="0" align =left >
                        <tr>
                            <td style="width: 500px; text-align: left; font-size: 9pt; height: 15px;" >
                             <asp:Label ID="labCP" runat="server" Text="当前页码为："></asp:Label>
                                [
                                <asp:Label ID="labPage" runat="server" Text="1"></asp:Label>
                                &nbsp;]
                                <asp:Label ID="labTP" runat="server" Text="总页码为："></asp:Label>
                                [
                                <asp:Label ID="labBackPage" runat="server"></asp:Label>
                                &nbsp;]<asp:LinkButton ID="lnkbtnOne" runat="server" Font-Underline="False" ForeColor="Red"
                                    OnClick="lnkbtnOne_Click">第一页</asp:LinkButton>
                                <asp:LinkButton ID="lnkbtnUp" runat="server" Font-Underline="False" ForeColor="Red"
                                    OnClick="lnkbtnUp_Click">上一页</asp:LinkButton>
                                <asp:LinkButton ID="lnkbtnNext" runat="server" Font-Underline="False" ForeColor="Red"
                                    OnClick="lnkbtnNext_Click">下一页</asp:LinkButton>&nbsp;
                                <asp:LinkButton ID="lnkbtnBack" runat="server" Font-Underline="False" ForeColor="Red"
                                    OnClick="lnkbtnBack_Click" Width="48px">最后一页</asp:LinkButton>&nbsp;&nbsp;</td>
                        </tr>
                    </table>
                    </td>
            </tr>
          
        </table>
</asp:Content>


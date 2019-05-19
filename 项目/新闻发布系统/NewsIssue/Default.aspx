<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="新闻发布系统前台首页分类显示" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style ="font-size :9pt;height: 677px; width :768px" cellpadding =0 cellspacing =0>
        <tr>
            <td>
                <table style ="font-size :9pt;height: 166px; width :381px" background ="Images/时政要闻.jpg" cellpadding =0 cellspacing =0>
                    <tr style ="font-size :9pt;height: 30px; width :381px">
                        <td colspan="2" align =right valign="middle" >
                        <br />
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/更多.jpg" PostBackUrl="~/newsList.aspx?id=1" /> 
                        </td>
                       
                    </tr>
                    <tr  style ="font-size :9pt;height: 136px; width :381px">
                        <td style="margin-top: 0px;  padding-top: 0px; width: 141px;  " align="center">
                         <asp:Image ID="Image1" runat="server" Height="79px" ImageUrl="~/Images/图片时政要闻.jpg" Width="86px" />
                        </td>
                        <td style="font-size :9pt;width :240px">
                         <asp:DataList ID="dlSZ" runat="server"  OnItemCommand="dlSZ_ItemCommand" BackColor="White">
                            <ItemTemplate>
                              <table border="0" style=" font-size :9pt; width: 100%; height: 100%;" cellspacing="0"  cellpadding =0 >
                                  <tr>
                                      <td style="width: 90px; height: 20px;">
                                           『
                                              <%# DataBinder.Eval(Container.DataItem,"type")%>
                                             』
                                       </td>
                                       <td colspan="2" >
                                          <asp:LinkButton ID="lbtnTitle" runat="server" CommandName="select" CausesValidation="False"><%# DataBinder.Eval(Container.DataItem,"title") %></asp:LinkButton>
                                       </td>
                                   </tr>
                                </table>
                       </ItemTemplate>
                       <HeaderStyle ForeColor="Blue" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" />
                        </asp:DataList>
                        </td>

                    </tr>
                </table>
            </td>
            <td>
                 <table  style ="font-size :9pt;height: 166px; width :397px" background ="Images/经济动向.jpg" cellpadding =0 cellspacing =0>
                     <tr style ="font-size :9pt;height: 30px; width :397px">
                        <td colspan="2" align =right valign="middle" >
                        <br />
                        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Images/更多2.jpg"  PostBackUrl="~/newsList.aspx?id=2" />&nbsp;&nbsp; &nbsp;&nbsp;
                        </td>
                       
                    </tr>
                    <tr  style ="font-size :9pt;height: 136px; width :397px">
                        <td style="margin-top: 0px;  padding-top: 0px; width: 141px;  " align="center">
                         <asp:Image ID="Image2" runat="server" Height="79px"  Width="86px" ImageUrl ="~/Images/经济动向图片.jpg" />
                        </td>
                        <td style="font-size :9pt;width :240px">
                         <asp:DataList ID="dlJJ" runat="server"  OnItemCommand="dlJJ_ItemCommand" BackColor="White">
                     <ItemTemplate>
                          <table border="0" style="width: 100%; height: 100%;font-size :9pt" cellspacing="0" cellpadding =0 >
                              <tr>
                                  <td style="width: 90px; height: 20px;">
                                       『
                                          <%# DataBinder.Eval(Container.DataItem,"type")%>
                                         』
                                   </td>
                                   <td colspan="2" >
                                      <asp:LinkButton ID="lbtnTitle" runat="server" CommandName="select" CausesValidation="False"><%# DataBinder.Eval(Container.DataItem,"title") %></asp:LinkButton>
                                   </td>
                               </tr>
                            </table>
                       </ItemTemplate>
                       <HeaderStyle ForeColor="Blue" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" />
                   </asp:DataList>
                        </td>

                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table style ="font-size :9pt;height: 165px; width :381px" background ="Images/科学教育.jpg" cellpadding =0 cellspacing =0>
                    <tr style ="font-size :9pt;height: 30px; width :381px">
                        <td colspan="2" align =right valign="middle" >
                        <br />
                        <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/Images/更多.jpg"  PostBackUrl="~/newsList.aspx?id=4"  /> 
                        </td>
                       
                    </tr>
                    <tr  style ="font-size :9pt;height: 135px; width :381px">
                        <td style="margin-top: 0px;  padding-top: 0px; width: 141px;  " align="center">
                         <asp:Image ID="Image4" runat="server" Height="79px" ImageUrl="~/Images/图片科学教育.jpg" Width="86px" />
                        </td>
                        <td style="font-size :9pt;width :240px">
                          <asp:DataList ID="dlKJ" runat="server" OnItemCommand="dlKJ_ItemCommand" BackColor="White">
                     <ItemTemplate>
                          <table border="0" style="width: 100%; height: 100%;font-size :9pt" cellpadding =0 cellspacing =0>
                              <tr>
                                  <td style="width: 90px; height: 20px;">
                                       『
                                          <%# DataBinder.Eval(Container.DataItem,"type")%>
                                         』
                                   </td>
                                   <td colspan="2">
                                      <asp:LinkButton ID="lbtnTitle" runat="server" CommandName="select" CausesValidation="False"><%# DataBinder.Eval(Container.DataItem,"title") %></asp:LinkButton>
                                   </td>
                               </tr>
                            </table>
                       </ItemTemplate>
                       <HeaderStyle ForeColor="Blue" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" />
                   </asp:DataList>
                        </td>

                    </tr>
                </table>
            </td>
            <td>
                 <table  style ="font-size :9pt;height: 165px; width :397px" background ="Images/法制道德.jpg" cellpadding =0 cellspacing =0>
                    <tr style ="font-size :9pt;height: 30px; width :381px">
                        <td colspan="2" align =right valign="middle" >
                        <br />
                        <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/Images/更多2.jpg"  PostBackUrl="~/newsList.aspx?id=5"  />&nbsp;&nbsp; &nbsp;&nbsp; 
                        </td>
                       
                    </tr>
                    <tr  style ="font-size :9pt;height: 135px; width :381px">
                        <td style="margin-top: 0px;  padding-top: 0px; width: 141px;  " align="center">
                         <asp:Image ID="Image5" runat="server" Height="79px" ImageUrl="~/Images/法制道德图片.jpg" Width="86px" />
                        </td>
                        <td style="font-size :9pt;width :240px">
                          <asp:DataList ID="dlFZ" runat="server"  OnItemCommand="dlFZ_ItemCommand" BackColor="White">
                             <ItemTemplate>
                                  <table border="0" style="width: 100%; height: 100%;font-size :9pt" cellpadding =0 cellspacing =0>
                                      <tr>
                                          <td style="width: 90px; height: 20px;">
                                               『
                                                  <%# DataBinder.Eval(Container.DataItem,"type")%>
                                                 』
                                           </td>
                                           <td colspan="2">
                                              <asp:LinkButton ID="lbtnTitle" runat="server" CommandName="select" CausesValidation="False"><%# DataBinder.Eval(Container.DataItem,"title") %></asp:LinkButton>
                                           </td>
                                       </tr>
                                    </table>
                               </ItemTemplate>
                       <HeaderStyle ForeColor="Blue" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" />
                   </asp:DataList>
                        </td>

                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table style ="font-size :9pt;height: 165px; width :381px" background ="Images/社会现象.jpg" cellpadding =0 cellspacing =0>
                   <tr style ="font-size :9pt;height: 30px; width :381px">
                        <td colspan="2" align =right valign="middle" >
                        <br />
                        <asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="~/Images/更多.jpg"  PostBackUrl="~/newsList.aspx?id=6"  /> 
                        </td>
                       
                    </tr>
                    <tr  style ="font-size :9pt;height: 135px; width :381px">
                        <td style="margin-top: 0px;  padding-top: 0px; width: 141px;  " align="center">
                         <asp:Image ID="Image6" runat="server" Height="79px" ImageUrl="~/Images/社会现象图片.jpg" Width="86px" />
                        </td>
                        <td style="font-size :9pt;width :240px">
                          <asp:DataList ID="dlSH" runat="server"  OnItemCommand="dlSH_ItemCommand" BackColor="White">
                     <ItemTemplate>
                          <table border="0" style="width: 100%; height: 100%;font-size :9pt" cellspacing="0" class="txt">
                              <tr>
                                  <td style="width: 90px; height: 20px;">
                                       『
                                          <%# DataBinder.Eval(Container.DataItem,"type")%>
                                         』
                                   </td>
                                   <td colspan="2">
                                      <asp:LinkButton ID="lbtnTitle" runat="server" CommandName="select" CausesValidation="False"><%# DataBinder.Eval(Container.DataItem,"title") %></asp:LinkButton>
                                   </td>
                               </tr>
                            </table>
                       </ItemTemplate>
                       <HeaderStyle ForeColor="Blue" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" />
                   </asp:DataList>

                        </td>

                    </tr>
                </table>
            </td>
            <td>
                 <table  style ="font-size :9pt;height: 165px; width :397px" background ="Images/体育世界.jpg" cellpadding =0 cellspacing =0>
                    <tr style ="font-size :9pt;height: 30px; width :397px">
                        <td colspan="2" align =right valign="middle" >
                        <br />
                        <asp:ImageButton ID="ImageButton7" runat="server" ImageUrl="~/Images/更多2.jpg"  PostBackUrl="~/newsList.aspx?id=7"  /> &nbsp;&nbsp; &nbsp;&nbsp;
                        </td>
                       
                    </tr>
                    <tr  style ="font-size :9pt;height: 135px; width :397px">
                        <td style="margin-top: 0px;  padding-top: 0px; width: 141px;  " align="center">
                         <asp:Image ID="Image7" runat="server" Height="79px" ImageUrl="~/Images/体育世界图片.jpg" Width="86px" />
                        </td>
                        <td style="font-size :9pt;width :256px">
                           <asp:DataList ID="dlTY" runat="server"  OnItemCommand="dlTY_ItemCommand" BackColor="White">
                     <ItemTemplate>
                          <table border="0" style="width: 100%; height: 100%;font-size :9pt" cellspacing="0" class="txt" cellpadding =0 >
                              <tr>
                                  <td style="width: 90px; height: 20px;">
                                       『
                                          <%# DataBinder.Eval(Container.DataItem,"type")%>
                                         』
                                   </td>
                                   <td colspan="2">
                                      <asp:LinkButton ID="lbtnTitle" runat="server" CommandName="select" CausesValidation="False"><%# DataBinder.Eval(Container.DataItem,"title") %></asp:LinkButton>
                                   </td>
                               </tr>
                            </table>
                       </ItemTemplate>
                       <HeaderStyle ForeColor="Blue" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" />
                   </asp:DataList>
                        </td>

                    </tr>
                </table>
            </td>
        </tr>
         <tr>
            <td>
                <table style ="font-size :9pt;height: 181px; width :381px" background ="Images/时尚娱乐.jpg" cellpadding =0 cellspacing =0>
                    <tr style ="font-size :9pt;height: 30px; width :397px">
                        <td colspan="2" align =right valign="middle" >
                        <br />
                        <asp:ImageButton ID="ImageButton8" runat="server" ImageUrl="~/Images/更多.jpg"  PostBackUrl="~/newsList.aspx?id=8"  /> 
                        </td>
                       
                    </tr>
                    <tr  style ="font-size :9pt;height: 151px; width :397px">
                        <td style="margin-top: 0px;  padding-top: 0px; width: 141px;  " align="center">
                         <asp:Image ID="Image8" runat="server" Height="79px" ImageUrl="~/Images/时尚娱乐图片.jpg" Width="86px" />
                        </td>
                        <td style="font-size :9pt;width :256px">
                           <asp:DataList ID="dlYL" runat="server"  OnItemCommand="dlYL_ItemCommand" BackColor="White">
                     <ItemTemplate>
                          <table border="0" style="width: 100%; height: 100%;font-size :9pt" cellspacing="0" class="txt" cellpadding =0 >
                              <tr>
                                  <td style="width: 90px; height: 20px;">
                                       『
                                          <%# DataBinder.Eval(Container.DataItem,"type")%>
                                         』
                                   </td>
                                   <td colspan="2">
                                      <asp:LinkButton ID="lbtnTitle" runat="server" CommandName="select" CausesValidation="False"><%# DataBinder.Eval(Container.DataItem,"title") %></asp:LinkButton>
                                   </td>
                               </tr>
                            </table>
                       </ItemTemplate>
                       <HeaderStyle ForeColor="Blue" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" />
                   </asp:DataList>
                        </td>

                    </tr>
                </table>
            </td>
            <td>
                 <table  style ="font-size :9pt;height: 181px; width :397px" background ="Images/世界军事.jpg" cellpadding =0 cellspacing =0>
                     <tr style ="font-size :9pt;height: 30px; width :397px">
                        <td colspan="2" align =right valign="middle" >
                        <br />
                        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/Images/更多2.jpg"  PostBackUrl="~/newsList.aspx?id=3"  />&nbsp;&nbsp; &nbsp;&nbsp; 
                        </td>
                       
                    </tr>
                    <tr  style ="font-size :9pt;height: 151px; width :397px">
                        <td style="margin-top: 0px;  padding-top: 0px; width: 141px;  " align="center">
                         <asp:Image ID="Image3" runat="server" Height="79px" ImageUrl="~/Images/世界军事图片.jpg" Width="86px" />
                        </td>
                        <td style="font-size :9pt;width :256px">
                           <asp:DataList ID="dlJS" runat="server" OnItemCommand="dlJS_ItemCommand" BackColor="White">
                     <ItemTemplate>
                          <table border="0" style="width: 100%; height: 100%;font-size :9pt" cellspacing="0" class="txt" cellpadding =0>
                              <tr>
                                  <td style="width: 90px; height: 20px;">
                                       『
                                          <%# DataBinder.Eval(Container.DataItem,"type")%>
                                         』
                                   </td>
                                   <td colspan="2">
                                      <asp:LinkButton ID="lbtnTitle" runat="server" CommandName="select" CausesValidation="False"><%# DataBinder.Eval(Container.DataItem,"title") %></asp:LinkButton>
                                   </td>
                               </tr>
                            </table>
                       </ItemTemplate>
                       <HeaderStyle ForeColor="Blue" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" />
                   </asp:DataList>
                        </td>

                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>


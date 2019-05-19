<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShoppingCart.aspx.cs" Inherits="ShoppingCart" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>购物车</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table align="center" border="0" cellpadding="0" cellspacing="0" style="font-size: 10pt;
            width: 637px;">
            <tr>
                <td style="width: 637px;
                    height: 120px;background-image: url(Image/购物车/子页头.jpg);" align="left" valign="bottom">
                    <table border="0" cellpadding="0" cellspacing="0" style="width: 630px">
                        <tr>
                            <td align="left" style="width: 159px">
                            </td>
                            <td align="left" style="width: 319px">
                                <asp:Image ID="Image1" runat="server" ImageUrl="~/Image/购物车/购物车.jpg" /></td>
                            <td align="right" style="width: 310px">
                            </td>
                            <td style="width: 42px">
                            </td>
                        </tr>
                        <tr>
                            <td align="left" style="width: 159px; height: 17px">
                            </td>
                            <td align="left" style="width: 319px; height: 17px;">
                            </td>
                            <td align="right" style="width: 310px; height: 17px;">
                    <asp:LinkButton ID="lnkbtnContinue" runat="server" OnClick="lnkbtnContinue_Click" ForeColor="#FF8000">继续购物</asp:LinkButton>
                                <asp:LinkButton ID="lnkbtnSettleAccounts" runat="server" OnClick="lnkbtnSettleAccounts_Click" ForeColor="#FF8000">结账</asp:LinkButton>
                                <asp:LinkButton ID="lnkbtnClear" runat="server" OnClick="lnkbtnClear_Click" OnLoad="lnkbtnClear_Load" ForeColor="#FF8000">清空购物车</asp:LinkButton></td>
                            <td style="width: 42px; height: 17px">
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td style="vertical-align: top; text-align: center; background-image: url(Image/购物车/子页中间.jpg); width: 637px; height: 341px;">
                    <asp:DataList ID="dlShoppingCart" runat="server" OnItemDataBound="dlShoppingCart_ItemDataBound" OnDeleteCommand="dlShoppingCart_DeleteCommand" OnItemCommand="dlShoppingCart_ItemCommand">
                        <ItemTemplate>
                            <table style="width: 368px; font-size: 10pt;" border="0" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td style="width: 88px; height: 26px;">
                                        <asp:Label ID="labGoodName" runat="server" Text='<%# Eval("GoodsName") %>'></asp:Label></td>
                                    <td style="width: 102px; height: 26px;">
                                        <asp:Label ID="labGoodsPrice" runat="server" Text='<%# Eval("GoodsPrice") %>'></asp:Label></td>
                                    <td style="width: 50px; height: 26px;">
                                        <asp:TextBox ID="txtGoodsNum" runat="server" Text='<%# Eval("Num") %>' Width="33px"></asp:TextBox></td>
                                    <td style="width: 76px; height: 26px">
                                        <asp:LinkButton ID="lnkbtnUpdateCart" runat="server" CommandArgument='<%# Eval("GoodsID") %>'
                                            CommandName="updateNum" ForeColor="Black">更新购物车</asp:LinkButton></td>
                                    <td style="height: 26px">
                                        &nbsp;<asp:LinkButton ID="lnkbtnDel" runat="server" CommandArgument='<%# Eval("GoodsID") %>'
                                            CommandName="delete" ForeColor="Black" OnLoad="lnkbtnDel_Load">删除</asp:LinkButton></td>
                                </tr>
                            </table>
                        </ItemTemplate>
                        <HeaderTemplate><table style="width: 368px; font-size: 10pt;" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td style="width: 88px; height: 26px;">
                                        商品名称</td>
                                <td style="width: 102px; height: 26px;">
                                        单价</td>
                                <td style="width: 50px; height: 26px;">
                                        数量</td>
                                <td style="width: 76px; height: 26px">
                                </td>
                                <td style="height: 26px">
                                    &nbsp;</td>
                            </tr>
                        </table>
                        </HeaderTemplate>
                        <FooterTemplate>
                            <table style="width: 368px; font-size: 10pt;" border="0" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td align="left" colspan="4">
                                        合计金额：<%#M_str_Count %>￥</td>
                                </tr>
                            </table>
                        </FooterTemplate>
                        <FooterStyle BackColor="#FFC080" />
                        <AlternatingItemStyle BackColor="White" />
                        <ItemStyle BackColor="#FFE0C0" />
                        <HeaderStyle BackColor="#FFC080" />
                    </asp:DataList></td>
            </tr>
            <tr>
                <td style="height: 140px; text-align: right; background-image: url(Image/购物车/子页底.jpg); width: 637px;">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

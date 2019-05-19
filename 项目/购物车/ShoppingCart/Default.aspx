<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>网上商城</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
        <table border="0" cellpadding="0" cellspacing="0" style="width: 637px">
            <tr>
                <td  width: 637px; height: 120px">
                </td>
                <td style="background-image: url(Image/购物车/主页/头.jpg); width: 637px; height: 120px" align="center">
                    <table style="width: 428px">
                        <tr>
                            <td style="height: 26px">
                            </td>
                        </tr>
                        <tr>
                            <td style="height: 26px" align ="left" >
                    <asp:Panel ID="pl1" runat="server" Width="125px">
                        <table style="width: 474px" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td style="font-size: 10pt; width: 36px; height: 17px">
                                </td>
                                <td style="font-size: 10pt; height: 17px" align="left">
                                    用户名<asp:TextBox ID="txtUserName" runat="server" Width="53px" Height="15px"></asp:TextBox>密码<asp:TextBox
                                        ID="txtPwd" runat="server" TextMode="Password" Width="52px" Height="15px"></asp:TextBox>
                                    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="登录" Height="20px" /></td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <asp:Panel ID="pl2" runat="server" Width="125px"><table style="width: 474px" border="0" cellpadding="0" cellspacing="0">
                        <tr>
                            <td style="font-size: 10pt; width: 36px; height: 17px">
                            </td>
                            <td style="font-size: 10pt; height: 17px" align="left">
                        <asp:Label ID="labMessage" runat="server" Text="Label"></asp:Label></td>
                        </tr>
                    </table>
                    </asp:Panel>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 100px; height: 27px">
                                <table border="0" cellpadding="0" cellspacing="0" style="width: 484px">
                                    <tr>
                                        <td style="width: 38px">
                                        </td>
                                        <td align="left">
                                            <asp:Image ID="Image1" runat="server" ImageUrl="~/Image/购物车/主页/最新商品信息.jpg" /></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td style="background-image: url(Image/购物车/主页/中间.jpg)" align="center">
        <table style="width: 565px" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td style="width: 51px">
                </td>
                <td style="width: 527px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 51px">
                </td>
                <td style="width: 527px" align="center">
                    <asp:DataList ID="dlGoodsInfo" runat="server" RepeatColumns="2" OnItemCommand="dlGoodsInfo_ItemCommand" Width="438px">
                        <ItemTemplate>
                            <table style="font-size: 10pt; width: 227px; height: 105px" border="0" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td rowspan="4" style="width: 101px">
                                        <asp:Image ID="imgGoodsPhoto" runat="server" ImageUrl='<%# Eval("GoodsPhoto") %>' Width="66px" Height="92px" /></td>
                                    <td style="width: 201px">
                                        名称：<asp:Label ID="labGoodsName" runat="server" Text='<%# Eval("GoodsName") %>'></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="width: 201px">
                                        类别：<asp:Label ID="labGoodsKind" runat="server" Text='<%# Eval("GoodsKind") %>'></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="width: 201px">
                                        单价：<asp:Label ID="labGoodzPrice" runat="server" Text='<%# Eval("GoodsPrice") %>'></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="width: 201px">
                                        <asp:LinkButton ID="lnkbtnGoodsDescribe" runat="server" CommandArgument='<%# Eval("GoodsID")%>' CommandName="describe">详细信息</asp:LinkButton>
                                        <asp:LinkButton ID="lnkbtnBuy" runat="server" CommandArgument='<%# Eval("GoodsID") %>' Width="32px" CommandName="buy">购买</asp:LinkButton></td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList>
                    </td>
            </tr>
        </table>
                </td>
            </tr>
            <tr>
                <td style="height: 140px">
                </td>
                <td style="background-image: url(Image/购物车/主页/底部.jpg); height: 140px" align="center">
                    <asp:HyperLink ID="hylinkGoback" runat="server" ImageUrl="~/Image/购物车/进入后台按钮.jpg"
                        NavigateUrl="~/GoodsInfo.aspx">HyperLink</asp:HyperLink></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

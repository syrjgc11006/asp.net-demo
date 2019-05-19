<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Describe.aspx.cs" Inherits="Describe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>详细信息</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="0" cellpadding="0" cellspacing="0" width="637">
            <tr>
                <td style="background-image: url(Image/购物车/子页头.jpg); width: 637px; height: 120px"
                    valign="bottom">
                    <table border="0" cellpadding="0" cellspacing="0" style="width: 383px">
                        <tr>
                            <td style="width: 103px">
                            </td>
                            <td>
                                <asp:Image ID="Image1" runat="server" ImageUrl="~/Image/购物车/详细信息.jpg" /></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td style="background-image: url(Image/购物车/子页中间.jpg); width: 637px; height: 341px">
        <table align="center" border="0" cellpadding="0" cellspacing="0" style="font-size: 10pt;
            width: 352px">
            <tr>
                <td align="left" style="width: 200px">
                    商品名称：</td>
                <td style="width: 359px">
                    <asp:TextBox ID="txtGoodsName" runat="server" Enabled="False"></asp:TextBox>
                    <font color="red"></font>
                </td>
            </tr>
            <tr style="color: #000000">
                <td align="left" style="width: 200px">
                    商品类别：</td>
                <td style="width: 359px">
                    <asp:TextBox ID="txtKind" runat="server" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr style="color: #000000">
                <td align="left" style="width: 200px; height: 19px">
                    商品价格：
                </td>
                <td colspan="3" style="width: 269px; height: 19px">
                    <asp:TextBox ID="txtGoodsPrice" runat="server" Enabled="False">0</asp:TextBox>￥</td>
            </tr>
            <tr>
                <td align="left" style="width: 200px; height: 87px">
                    商品图像：
                </td>
                <td colspan="3" style="width: 269px; height: 87px">
                    <asp:Image ID="imgGoodsPhoto" runat="server" Height="103px" Width="90px">
                    </asp:Image>
                </td>
            </tr>
            <tr>
                <td align="left" style="width: 200px; height: 97px">
                    商品介绍：
                </td>
                <td style="width: 359px; height: 97px">
                    <asp:TextBox ID="txtGoodsDesc" runat="server" Height="84px" TextMode="MultiLine"
                        Width="245px" Enabled="False"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="left" colspan="2" style="height: 8px">
                    <asp:Button ID="btnClose" runat="server" OnClick="btnClose_Click" Text="关闭" /></td>
            </tr>
        </table>
                </td>
            </tr>
            <tr>
                <td style="background-image: url(Image/购物车/子页底.jpg); width: 637px; height: 140px">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

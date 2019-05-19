<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GoodsInfo.aspx.cs" Inherits="GoodsInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>添加商品</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table align="center" border="0" cellpadding="0" cellspacing="0" style="font-size: 10pt; width: 637px;"
            width="480">
            <tr>
                <td style="background-image: url(Image/购物车/子页头.jpg); width: 637px; height: 120px" valign="bottom">
                    <table border="0" cellpadding="0" cellspacing="0" style="width: 481px">
                        <tr>
                            <td style="width: 68px">
                            </td>
                            <td style="width: 247px">
                                <asp:Image ID="Image1" runat="server" ImageUrl="~/Image/购物车/商品基本信息.jpg" /></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td style="background-image: url(Image/购物车/子页中间.jpg); width: 637px; height: 341px">
                    <table align="center" border="0" cellpadding="0" cellspacing="0" style="font-size: 10pt; width: 71%;">
                        <tr>
                            <td align="left" style="width: 19px">
                            </td>
                            <td align="left" style="width: 77px">
                                商品名称：</td>
                            <td style="width: 359px">
                                <asp:TextBox ID="txtGoodsName" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtGoodsName"
                                    ErrorMessage="请输入商品名称！"></asp:RequiredFieldValidator><font color="red"></font></td>
                        </tr>
                        <tr style="color: #000000">
                            <td align="left" style="width: 19px">
                            </td>
                            <td align="left" style="width: 77px">
                                商品类别：</td>
                            <td style="width: 359px">
                                <asp:TextBox ID="txtKind" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtKind"
                                    ErrorMessage="请输入商品类别！"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr style="color: #000000">
                            <td align="left" style="width: 19px; height: 19px">
                            </td>
                            <td align="left" style="height: 19px; width: 77px;">
                                商品价格：
                            </td>
                            <td colspan="3" style="height: 19px">
                                <asp:TextBox ID="txtGoodsPrice" runat="server">0</asp:TextBox>￥<asp:CompareValidator
                                    ID="CompareValidator1" runat="server" ControlToValidate="txtGoodsPrice"
                                    ErrorMessage="格式错误!" Operator="DataTypeCheck" Type="Currency"></asp:CompareValidator></td>
                        </tr>
                        <tr>
                            <td align="left" style="width: 19px; height: 82px">
                            </td>
                            <td align="left" style="height: 82px; width: 77px;">
                                商品图像：
                            </td>
                            <td colspan="3" style="height: 82px">
                                <asp:ImageMap ID="imgGoodsPhoto" runat="server" Height="103px" Width="90px">
                                </asp:ImageMap>
                                <asp:Label ID="labMessage" runat="server" ForeColor="Red" Text="请选择图片!" Visible="False"></asp:Label></td>
                        </tr>
                        <tr>
                            <td align="left" style="width: 19px; height: 14px">
                            </td>
                            <td align="left" style="height: 14px; width: 77px;">
                            </td>
                            <td colspan="3" style="height: 14px">
                                &nbsp;<asp:FileUpload ID="fulPhoto" runat="server" /><asp:Button ID="btnShow" runat="server"
                                    CausesValidation="False" Height="20px" OnClick="btnShow_Click" Text="显示" /></td>
                        </tr>
                        <tr>
                            <td align="left" style="width: 19px; height: 97px">
                            </td>
                            <td align="left" style="height: 97px; width: 77px;">
                                商品介绍：
                            </td>
                            <td style="width: 359px; height: 97px">
                                <asp:TextBox ID="txtGoodsDesc" runat="server" Height="84px" TextMode="MultiLine"
                                    Width="245px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                                        runat="server" ControlToValidate="txtGoodsDesc" ErrorMessage="请输入商品介绍！"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td align="center" colspan="1" style="width: 19px; height: 20px">
                            </td>
                            <td align="center" colspan="4" style="height: 20px">
                                <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="添加" />
                                <asp:Button ID="btnBack" runat="server" CausesValidation="False" OnClick="btnBack_Click"
                                    Text="返回" /></td>
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

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="动态显示图像._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>利用Image动态显示头像功能</title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        <table style="width:225px; height: 84px; text-align: center;">
            <tr>
                <td colspan="2"> 
                    动态显示头像</td>


            </tr>
            <tr>
                <td>
                    请选择头像：</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                        Height="18px" onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
                        Width="106px">
                    </asp:DropDownList>
                </td>

            </tr>
            <tr>
                <td>
                    头像显示：</td>
                <td>
                    <asp:Image ID="Image1" runat="server" AlternateText="显示头像" Height="100px" />
                </td>

            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

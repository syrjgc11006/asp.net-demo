<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ListBox控件选项按钮的上移和下移操作._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>ListBox选项的上移和下移操作</title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        <table style="margin: 0; width:auto;">
            <tr>
                <td colspan="2">
                    ListBox控件的应用</td>
            </tr>
            <tr>
                <td rowspan="4">
                    <asp:ListBox ID="lbxSource" runat="server" Height="113px" Width="94px" 
                        SelectionMode="Multiple">
                    </asp:ListBox>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="上移" onclick="Button1_Click" 
                        Width="74px" />
                    <tr>
                        <td>
                            <asp:Button ID="Button2" runat="server" Text="下移" onclick="Button2_Click" 
                                Width="73px" />
                        </td>                        
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button3" runat="server" Text="循环上移" onclick="Button3_Click" />
                        </td>                        
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button4" runat="server" Text="循环下移" onclick="Button4_Click" />
                        </td>                        
                    </tr>
                </td>
            </tr>

        </table>
    
    </div>
    </form>
</body>
</html>

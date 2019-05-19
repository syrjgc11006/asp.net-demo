<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Listbox控件选项的多选和单选操作._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>ListBox控件的单选和多选操作</title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
   
        <table style="margin: 0; width:auto; text-align: center;" border="0">
        <tr>
                <td colspan="3" align="center">
                     ListBox控件的应用</td>
            </tr>
            <tr>
                <td rowspan="4">
                    <asp:ListBox ID="lbxDest" runat="server" SelectionMode="Multiple" 
                        Height="123px" Width="67px"></asp:ListBox>
                </td>
                <td style="width: auto">
                    <asp:Button ID="btnChooseAll" runat="server" Text="&lt;&lt;" 
                        onclick="btnChooseAll_Click" />
                </td>
                
                <td rowspan="4">
                    <asp:ListBox ID="lbxSource" runat="server" SelectionMode="Multiple" 
                        Height="123px" Width="67px">
                    </asp:ListBox>
                </td>
            </tr>
            <tr>
                <td style="width: auto">
                    <asp:Button ID="btnDeleteAll" runat="server" Text="&gt;&gt;" 
                        onclick="btnDeleteAll_Click" />
                </td>
            </tr>
            <tr>
                <td style="width: auto">
                    <asp:Button ID="btnSelectSingle" runat="server" Text="&lt;" Width="30px" 
                        onclick="btnSelectSingle_Click" />
                </td>
            </tr>
            <tr>
                <td style="width: auto">
                    <asp:Button ID="btnDeleteSingle" runat="server" Text="&gt;" Width="29px" 
                        onclick="btnDeleteSingle_Click" />
                </td>
            </tr>
        </table>
   
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication4._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>在datalist控件中对数据进行编辑操作</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     &nbsp;<table style="width: 582px; height: 97px">
            <tr>
                <td style="width: 578px">
        <asp:DataList ID="DataList1" runat="server" OnCancelCommand="DataList1_CancelCommand" OnEditCommand="DataList1_EditCommand" OnUpdateCommand="DataList1_UpdateCommand" CellPadding="0" GridLines="Both" RepeatColumns="2" RepeatDirection="Horizontal">
            <ItemTemplate>
                <table>
                    <tr>
                        <td style="width: 58px">
                            姓名：</td>
                        <td style="width: 100px">
                            <asp:Label ID="lblName" runat="server" Text='<%# Eval("stuName")%>'></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 58px">
                        </td>
                        <td style="width: 100px">
                            <asp:Button ID="btnEdit" runat="server" CommandName="edit" Text="编辑" /></td>
                    </tr>
                </table>
            </ItemTemplate>
            <EditItemTemplate>
                <table>
                    <tr>
                        <td style="width: 57px">
                            编号：</td>
                        <td style="width: 100px">
                            <asp:Label ID="lblID" runat="server" Text='<%#Eval("stuID")%>'></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 57px">
                            姓名：</td>
                        <td style="width: 100px">
                            <asp:TextBox ID="txtName" runat="server" Text='<%#Eval("stuName")%>' Width="90px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 57px">
                            性别：</td>
                        <td style="width: 100px">
                            <asp:TextBox ID="txtSex" runat="server" Text='<%#Eval("stuSex")%>' Width="90px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 57px">
                            爱好：</td>
                        <td style="width: 100px">
                            <asp:TextBox ID="txtHobby" runat="server" Text='<%#Eval("stuHobby")%>' Width="90px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 57px">
                        </td>
                        <td style="width: 100px">
                            <asp:Button ID="btnUpdate" runat="server" CommandName="update" Text="更新" /><asp:Button
                                ID="btnCancel" runat="server" CommandName="cancel" Text="取消" /></td>
                    </tr>
                </table>
            </EditItemTemplate>
            <EditItemStyle BackColor="Teal" ForeColor="White" />
        </asp:DataList></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>

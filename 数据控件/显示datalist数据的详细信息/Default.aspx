<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>查看datalist控件中数据的详细信息</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="width: 255px; height: 198px">
            <tr>
                <td>
                    <asp:DataList ID="DataList1" runat="server" OnItemCommand="DataList1_ItemCommand">
                        <SelectedItemStyle BackColor="Teal" ForeColor="White" />
                        <ItemTemplate>
                            <table>
                                <tr>
                                    <td style="width: 100px; height: 21px">
                                        学生姓名：</td>
                                    <td style="width: 100px; height: 21px">
                                        <asp:LinkButton ID="lnkbtnName" runat="server" CommandName="select" Text='<%# DataBinder.Eval(Container.DataItem,"stuName") %>'></asp:LinkButton></td>
                                </tr>
                            </table>
                        </ItemTemplate>
                        <SelectedItemTemplate>
                            <table>
                                <tr>
                                    <td style="width: 77px">
                                        编号：</td>
                                    <td style="width: 100px">
                                        <asp:Label ID="lblID" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"stuID") %>'></asp:Label>
                                        <asp:LinkButton ID="lnkbtnBack" runat="server" CommandName="back">返回</asp:LinkButton></td>
                                </tr>
                                <tr>
                                    <td style="width: 77px">
                                        姓名：</td>
                                    <td style="width: 100px">
                                        <asp:Label ID="lblName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"stuName") %>'></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="width: 77px">
                                        性别：</td>
                                    <td style="width: 100px">
                                        <asp:Label ID="lblSex" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"stuSex") %>'></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="width: 77px">
                                        爱好：</td>
                                    <td style="width: 100px">
                                        <asp:Label ID="lblHobby" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"stuHobby") %>'></asp:Label></td>
                                </tr>
                            </table>
                        </SelectedItemTemplate>
                    </asp:DataList></td>
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserManagement.aspx.cs" Inherits="UserManagement" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>用户操作</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-size: 9pt; text-align: center;">
        <table style="font-size: 9pt; width: 501px; height: 54px; border-right: #0066cc 1px double;border-left: #0066cc 1px double; text-align: center; border-top: 1px double; border-bottom: 1px double;" cellpadding="0" cellspacing="0">
            <tr>
                <td style="background-image: url(Image/用户管理Head.jpg); height: 60px" align="right" valign="bottom">
                    <asp:LinkButton ID="lnkbtnExit" runat="server" OnClick="lnkbtnExit_Click" ForeColor="White">退出</asp:LinkButton></td>
            </tr>
            <tr>
                <td style="height: 253px">
                
                    <asp:DataList ID="DataList1" runat="server" CellPadding="4" ForeColor="#333333" OnEditCommand="DataList1_EditCommand" OnCancelCommand="DataList1_CancelCommand" OnUpdateCommand="DataList1_UpdateCommand" OnDeleteCommand="DataList1_DeleteCommand" OnItemCommand="DataList1_ItemCommand" OnItemDataBound="DataList1_ItemDataBound" Font-Size="9pt">
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                       <ItemTemplate>
                            <table style="width: 470px; font-size: 9pt;">
                                <tr>
                                    <td style="width: 47px">
                                        <asp:LinkButton ID="lnkbtnUserName" runat="server" CommandName="select" Text='<%# DataBinder.Eval(Container.DataItem,"UserName") %>'></asp:LinkButton></td>
                                    <td style="width: 74px">
                                        <asp:Label ID="Label2" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Email")%>'></asp:Label></td>
                                    <td style="width: 81px">
                                        <asp:CheckBox ID="chkRole" Checked ='<%#DataBinder.Eval(Container.DataItem,"Role")%>' runat="server" Enabled="False" /></td>
                                    <td style="width: 90px">
                                        <asp:Button ID="btnEdit" runat="server" CommandName="edit" Text="编辑" />
                                        <asp:Button ID="btnDelete" runat="server" CommandName="delete" Text="删除" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"UserID") %>' OnLoad="btnDelete_Load" /></td>
                                    <td style="width: 86px">
                                        <asp:Button ID="btnSetRole" runat="server" CommandName="setRole" Text='<%# (bool) DataBinder.Eval(Container.DataItem,"Role")==true?"取消管理员权限":"设为管理员权限" %>' CommandArgument = '<%# DataBinder.Eval(Container.DataItem,"UserID") %>'/></td>
                                </tr>
                            </table>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <table style="width: 297px; height: 59px; font-size: 9pt;">
                                <tr>
                                    <td style="width: 75px; height: 19px;">
                                        用户名：</td>
                                    <td style="width: 131px; height: 19px;">
                                        <asp:Label ID="lblUserName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"UserName") %>'></asp:Label></td>
                                    <td style="width: 95px; height: 19px;">
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 75px">
                                        旧密码：</td>
                                    <td style="width: 131px">
                                        <asp:TextBox ID="txtOldpwd" runat="server" TextMode="Password" Width="98px"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtOldpwd"
                                            ErrorMessage="*"></asp:RequiredFieldValidator></td>
                                    <td style="width: 95px">
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 75px">
                                        新密码：</td>
                                    <td style="width: 131px">
                                        <asp:TextBox ID="txtNewpwd" runat="server" TextMode="Password" Width="98px"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNewpwd"
                                            ErrorMessage="*"></asp:RequiredFieldValidator></td>
                                    <td style="width: 95px">
                                        </td>
                                </tr>
                                <tr>
                                    <td style="width: 75px">
                                        确认密码：</td>
                                    <td style="width: 131px">
                                        <asp:TextBox ID="txtRepwd" runat="server" TextMode="Password" Width="98px"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtRepwd"
                                            ErrorMessage="*"></asp:RequiredFieldValidator></td>
                                    <td style="width: 95px">
                                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtNewpwd"
                                            ControlToValidate="txtRepwd" ErrorMessage="与密码不符！" Width="73px"></asp:CompareValidator></td>
                                </tr>
                                <tr>
                                    <td style="width: 75px">
                                    </td>
                                    <td style="width: 131px">
                                        <asp:Button ID="btnUpdate" runat="server" CommandName="update" CommandArgument = '<%#DataBinder.Eval(Container.DataItem,"PassWord")%>' Text="修改密码" />
                                        <asp:Button ID="btnCancel" runat="server" CommandName="cancel" Text="取消" CausesValidation="False" /></td>
                                    <td style="width: 95px">
                                    </td>
                                </tr>
                            </table>
                        </EditItemTemplate>
                        <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                        <ItemStyle BackColor="#EBF6FD" ForeColor="#333333" />
                        <HeaderTemplate>
                            <table style="width: 471px; font-size: 9pt;">
                                <tr>
                                    <td style="width: 47px">
                                        用户名</td>
                                    <td style="width: 77px">
                                        电子邮件</td>
                                    <td style="width: 81px">
                                        是否为管理员</td>
                                    <td style="width: 89px;">
                                        操作</td>
                                    <td style="width: 89px">
                                        管理员设置</td>
                                </tr>
                            </table>
                        </HeaderTemplate>
                        <HeaderStyle BackColor="#0973DC" Font-Bold="True" ForeColor="White" />
                        <SelectedItemTemplate>
                            <table style="width: 297px; height: 59px; font-size: 9pt;">
                                <tr>
                                    <td style="width: 58px; height: 19px;">
                                        用户名：</td>
                                    <td style="width: 131px; height: 19px;">
                                        <asp:TextBox ID="txtUserName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"UserName") %>'
                                            Width="98px"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtUserName"
                                            ErrorMessage="*"></asp:RequiredFieldValidator></td>
                                </tr>
                                <tr>
                                    <td style="width: 58px">
                                        Email：</td>
                                    <td style="width: 131px">
                                        <asp:TextBox ID="txtEmail" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"Email") %>'
                                            Width="98px"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmail"
                                            ErrorMessage="*"></asp:RequiredFieldValidator></td>
                                </tr>
                                <tr>
                                    <td style="width: 58px">
                                    </td>
                                    <td style="width: 131px">
                                        <asp:Button ID="btnUpdateName" runat="server" CommandName="updateName" CommandArgument = '<%# DataBinder.Eval(Container.DataItem,"UserID") %>' Text="修改用户信息" Width="84px" />
                                        <asp:Button ID="btnCancel" runat="server" CommandName="cancel" Text="取消" CausesValidation="False" /></td>
                                </tr>
                            </table>
                        </SelectedItemTemplate>
                    </asp:DataList></td>
            </tr>
            <tr>
                <td style="height: 30px; background-image: url(Image/用户管理Bottom.jpg);">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

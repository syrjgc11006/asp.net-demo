<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MemberEdit.aspx.cs" Inherits="Manage_MemberEdit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>编辑管理员</title>
    <link href="../css/css.css" rel="stylesheet" type="text/css" />
</head>
<body style="margin-top: 0px; padding-top: 0px">
    <form id="form1" runat="server">
    <div>
    <table  class="txt" cellSpacing="0" cellPadding="0" width="640" align="center" border="0">
				<tr>
					<td class="tableHeaderText" height="25" align="left">
                        &nbsp; &nbsp;&nbsp;
						编辑管理员</td>
				</tr>
				<tr>
					<td>
						<table  class="txt" cellSpacing="0" cellPadding="0" width="95%" align="center" border="0">
				            <tr>
					            <td height="23" >
                                   <asp:GridView ID="gvEditMember" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                        PageSize="5" DataKeyNames ="ID"  Width="100%" HorizontalAlign="Center" CssClass="txt"
							            HeaderStyle-CssClass="summary-title" OnPageIndexChanging="gvEditMember_PageIndexChanging" OnRowCancelingEdit="gvEditMember_RowCancelingEdit" OnRowDeleting="gvEditMember_RowDeleting" OnRowEditing="gvEditMember_RowEditing" OnRowUpdating="gvEditMember_RowUpdating">
							            <HeaderStyle Font-Bold="True" CssClass="summary-title"></HeaderStyle>
                                        <Columns>
                                            <asp:BoundField DataField="ID" HeaderText="管理员代号" ReadOnly="True" >
                                                <ItemStyle HorizontalAlign="Left" Width="80px" />
                                                <HeaderStyle HorizontalAlign="Left" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="Name" HeaderText="管理员名称" >
                                                <ItemStyle HorizontalAlign="Left" />
                                                <HeaderStyle HorizontalAlign="Left" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="PassWord" HeaderText="管理员密码"  HeaderStyle-HorizontalAlign =left ItemStyle-HorizontalAlign =left />
                                            <asp:CommandField ShowDeleteButton="True" >
                                                <ItemStyle HorizontalAlign="Left" Width="30px" />
                                            </asp:CommandField>
                                            <asp:CommandField ShowEditButton="True" />
                                        </Columns>
                                    </asp:GridView>
					            </td>
				            </tr>
			</table>
					</td>
				</tr>
			</table>
			
    </div>
    </form>
</body>
</html>

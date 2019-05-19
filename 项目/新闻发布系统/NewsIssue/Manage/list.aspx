<%@ Page Language="C#" AutoEventWireup="true" CodeFile="list.aspx.cs" Inherits="manage_list" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>新闻列表</title>
    <link href="../css/css.css" rel="stylesheet" type="text/css" />
</head>
<body style="margin-top: 0px; padding-top: 0px;">
    <form id="form1" runat="server">
    <div>
        &nbsp;</div>
        <table style="width: 511px" class="css">
            <tr>
                <td style="width: 305px; height: 25px;" align="center">
                    输入关键字：</td>
                <td style="width: 403px; height: 25px;" align="center">
                    <asp:TextBox ID="txtKey" runat="server" CssClass="css" Width="232px"></asp:TextBox>&nbsp;
                    <asp:DropDownList ID="ddlNewsStyle" runat="server" CssClass="css" Width="78px" CausesValidation="True">
                        <asp:ListItem>时政要闻</asp:ListItem>
                        <asp:ListItem>经济动向</asp:ListItem>
                        <asp:ListItem>世界军事</asp:ListItem>
                        <asp:ListItem>科学教育</asp:ListItem>
                        <asp:ListItem>法治道德</asp:ListItem>
                        <asp:ListItem>社会现象</asp:ListItem>
                        <asp:ListItem>体育世界</asp:ListItem>
                        <asp:ListItem>时尚娱乐</asp:ListItem>
                    </asp:DropDownList></td>
                <td style="width: 4px; height: 25px;">
                    <asp:Button ID="btnSearch" runat="server" Height="20px" OnClick="btnSearch_Click"
                        Text="站内搜索" /></td>
            </tr>
            <tr>
                <td colspan="3">
        <asp:GridView ID="gvNewsList" runat="server" AllowPaging="True" AutoGenerateColumns="False"
            CellSpacing="1" Height="1px" PageSize="26" Width="500px" CssClass="txt" OnPageIndexChanging="gvNewsList_PageIndexChanging" OnRowDeleting="gvNewsList_RowDeleting" OnRowDataBound="gvNewsList_RowDataBound">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="title" HeaderText="新闻标题" />
                <asp:BoundField DataField="Type" HeaderText="新闻类别" />
                <asp:BoundField DataField="IssueDate" HeaderText="发布日期" />
                <asp:HyperLinkField HeaderText="编辑" Text="编辑" DataNavigateUrlFields="id" DataNavigateUrlFormatString="Edit.aspx?id={0}" Target="right" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

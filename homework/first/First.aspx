<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="First.aspx.cs"
    Inherits="Web_HomeWork.TeacherSelectClass" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>菜单控件的使用</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label">学年：</asp:Label>
        <asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="True">
        </asp:DropDownList>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Label">学期：</asp:Label>
        <asp:DropDownList
            ID="ddlTerm" runat="server" AutoPostBack="True">
        </asp:DropDownList>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Label">分院：</asp:Label>
        <asp:DropDownList
            ID="ddlCollege" runat="server" AutoPostBack="True" 
            onselectedindexchanged="ddlCollege_SelectedIndexChanged">    
        </asp:DropDownList>&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label runat="server" Text="Label">教师：</asp:Label>
        <asp:DropDownList ID="ddlTeacher" runat="server" AutoPostBack="True">
        </asp:DropDownList>&nbsp;&nbsp;&nbsp;&nbsp;
    </div>
    </form>
</body>
</html>

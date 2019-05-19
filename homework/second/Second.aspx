<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Second.aspx.cs" Inherits="Web_HomeWork.Danxuan" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>web服务器控件</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:Label ID="Label1" runat="server" Text="Label">1.Web服务器的控件不包括（）。</asp:Label>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="true" >
            <asp:ListItem Value="0">A.Wizard</asp:ListItem>
            <asp:ListItem Value="1">B.Input</asp:ListItem>
            <asp:ListItem Value="2">C.Adrotator</asp:ListItem>
            <asp:ListItem Value="3">D.Calender</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="Button1" runat="server" Text="提交" onclick="Button1_Click" />
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>

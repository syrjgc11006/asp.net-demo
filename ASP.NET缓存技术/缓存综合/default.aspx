<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ OutputCache Duration ="10" VaryByParam ="area" %>
<!--将网页缓存一段时间等到过了10秒之后再-->
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div  align =center >
       <table style=" font-size :9pt"  >
            <tr>
                <td align =left >
        缓存网页的不同版本</td>
            </tr>
            <tr>
                <td align =left >
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td align =left >
                    地区：<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack =true   OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>请选择</asp:ListItem>
                        <asp:ListItem>shanghai</asp:ListItem>
                        <asp:ListItem>bijing</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td align="left">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>

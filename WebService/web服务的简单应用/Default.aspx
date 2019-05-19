<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>使用Web服务</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 497px">
            <tr>
                <td>
                    在下面文本框中输入要查询学生的姓名!</td>
            </tr>
            <tr>
                <td>
                    学生姓名：<asp:TextBox ID="TextBox1" runat="server" Width="117px"></asp:TextBox>
                    <asp:Button ID="btnSelect" runat="server" OnClick="btnSelect_Click" Text="查询" /></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="labMessage" runat="server"></asp:Label></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

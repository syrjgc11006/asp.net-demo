<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChatDetail.aspx.cs" Inherits="ChatDetail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>       
        <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate>聊天记录详细<br/></HeaderTemplate>
        <ItemTemplate>
        <font color="red"><%#Eval("User_ID")%></font>在<font color="red"><%#Eval("Time")%></font>说:<%#Eval("Content")%><hr/>
        </ItemTemplate>        
        </asp:Repeater>
        <br />当前<%=curpage%>/<%=pgcount %>页
        <input id="Button1" type="button" value="首页" onclick="javascript:window.location='ChatDetail.aspx'"/>
        <input id="Button2" type="button" value="上一页" onclick="javascript:window.location='ChatDetail.aspx?page=<%=curpage-1%>'" />
        <input id="Button3" type="button" value="下一页" onclick="javascript:window.location='ChatDetail.aspx?page=<%=curpage+1%>'"/>
        <input id="Button4" type="button" value="尾页" onclick="javascript:window.location='ChatDetail.aspx?page=<%=pgcount%>'"/></div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VoteResult.aspx.cs" Inherits="VoteResult" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>投票结果</title>    
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
        <asp:ImageButton ID="imgbtnImage" runat="server" ImageUrl="~/Image/子页切/关闭按钮.jpg"
            OnClick="imgbtnImage_Click" /><br />
        <asp:Image ID="imgVoteImage" runat="server" />&nbsp;</div>
    </form>
</body>

</html>

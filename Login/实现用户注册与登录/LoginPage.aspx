﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="实现用户注册与登录._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>实现用户的注册与登录</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <asp:Login ID="Login1" runat="server" CreateUserText="新用户注册" 
        CreateUserUrl="~/createNewMember.aspx" DestinationPageUrl="~/Navigator.aspx" 
            BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" 
            Font-Names="Verdana" Font-Size="10pt">
        <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
    </asp:Login>
    
    </div>
    </form>
</body>
</html>

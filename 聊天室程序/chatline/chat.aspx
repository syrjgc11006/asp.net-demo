<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="chat.aspx.cs" Inherits="chatline.chat" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>聊天室</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center; font-size: 9pt;">
        <table style="width: 603px; height: 442px; background-color: #FFFFFF;" 
            border="1" cellpadding="0" cellspacing="0">
            <tr>
                <td colspan="2" 
                    
                    style="height: 51px; width: auto; font-size: 16pt; color: #FFFFFF; background-color: #54a4ff; background-image: url('App_Themes/图片/11062215161524.jpg');">聊天室</td>
            </tr>
            <tr>
                <td style="width: 404px; height: 18px" bgcolor="#CCFFFF">聊天内容</td>
                <td style="width: 200px; height: 18px; font-size: 9pt; border-right-style: none; border-left-style: none" 
                    bgcolor="#CCFFFF" align="center">当前在线人数:<asp:TextBox ID="txtNum" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width:404px; height: 354px;">
                    <iframe id="Iframe1" src="Content.aspx" runat="server" scrolling="auto" 
                        frameborder="0" style="width: 400px; height: 350px"></iframe>
                </td>
                <td style="width: 200px; height: 354px">
                    <iframe id="Iframe2" src="List.aspx" runat="server" scrolling="auto" frameborder="0" style="width: 180px; height: 350px"></iframe>               <!--插入内联框架，允许在文本块中插入框架-->
                </td>
            </tr> 
            <tr>
                <td align="left" style="width: 400px">
                    <asp:TextBox ID="txtMessage" runat="server"></asp:TextBox>
                    <asp:Button ID="btnSend" runat="server" Text="发送" onclick="btnSend_Click" />
                    <asp:Button ID="btnExit" runat="server" Text="退出" onclick="btnExit_Click" />
                </td>
                <td style="width: 200px"></td>
            </tr>          
        </table>
    </div>
    </form>
</body>
</html>

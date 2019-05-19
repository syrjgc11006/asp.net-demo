<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Src="WebUserControl.ascx" TagName="WebUserControl" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>使用PartialCachingAttribute类设置用户控件（WebUserControl.ascx文件）的缓存有效期时间是20秒</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style =" font-size :9pt">
     <table style="width: 335px; height: 60px" border="2" bordercolor="#000000">
            <tr>
                <td align =center style ="color :Blue ;">
                Web页中的时间与用户控件中的时间对比
                </td>
            </tr>
            <tr>
                <td >
                    <uc1:WebUserControl ID="WebUserControl1" runat="server" />
                </td>
            </tr>
            <tr>
                <td >
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
            </tr>
        </table>
       
   </div>
       
    </form>
</body>
</html>

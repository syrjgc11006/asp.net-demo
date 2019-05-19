<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>在线投票系统</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
        <table style="background-image: url(Image/主页切/投票主页大背景.jpg); width: 546px; height: 373px">
            <tr>
                <td style="height: 55px">
                    <table border="0" cellpadding="0" cellspacing="0" style="width: 361px; height: 241px">
                        <tr>
                            <td style="background-image: url(Image/主页切/投票主页1.jpg); width: 361px; height: 48px">
                            </td>
                        </tr>
                        <tr>
                            <td style="background-image: url(Image/主页切/投票主页2.jpg); width: 361px; height: 158px">
                                <table border="0" cellpadding="0" cellspacing="0" style="width: 346px; height: 115px">
                                    <tr>
                                        <td style="width: 183px">
                                        </td>
                                        <td>
                                            <asp:ImageButton ID="imgbtnAdd" runat="server" ImageUrl="~/Image/主页切/主页按钮---添加投票项.jpg"
                                                OnClick="imgbtnAdd_Click" /></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 183px; height: 21px">
                                        </td>
                                        <td style="height: 21px">
                                            <asp:ImageButton ID="imgbtnAll" runat="server" ImageUrl="~/Image/主页切/主页按钮---所有投票.jpg"
                                                OnClick="imgbtnAll_Click" /></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 183px">
                                        </td>
                                        <td>
                                            <asp:ImageButton ID="imgbtnManage" runat="server" ImageUrl="~/Image/主页切/主页按钮---投票项管理.jpg"
                                                OnClick="imgbtnManage_Click" /></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td style="background-image: url(Image/主页切/投票主页3.jpg); width: 361px; height: 35px">
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

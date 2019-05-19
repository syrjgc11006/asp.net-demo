<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>使用dataList控件绑定数据源</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DataList ID="DataList1" runat="server" 
            onselectedindexchanged="DataList1_SelectedIndexChanged">
            <HeaderTemplate>
                <table style="width:300px; text-align: center;" cellpadding="0" cellspacing="0" border="1">
                    <tr>
                        <td colspan="4" style="font-size: 16pt; color: #808000">
                          使用DataList控件绑定数据源</td>

                    </tr>
                    <tr>
                        <td style="height: 19px; width: 50px; color: #000080">编号</td>
                        <td style="height: 19px; width: 50px; color: #000080">姓名</td>
                        <td style="height: 19px; width: 50px; color: #000080">性别</td>
                        <td style="height: 19px; width: 50px; color: #000080">爱好</td>
                    </tr>
           
                </table>
            </HeaderTemplate>
            <ItemTemplate>
                <table style="width:300px; text-align: center; color: #000000;" border="1" cellpadding="0" cellspacing="0";>
                    <tr>
                        <td>
                            <asp:Label ID="lblStuID" runat="server" Text='<%# Eval("stuID") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="labStuName" runat="server" Text='<%# Eval("StuName") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblStuSex" runat="server" Text='<%# Eval("stuSex") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblStuHobby" runat="server" Text='<%# Eval("stuHobby") %>'></asp:Label>
                        </td>
                    </tr>                    
                </table>
            </ItemTemplate>
        </asp:DataList>
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="在GridView控件中实现全选和全不选功能._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>在GridView控件中实现全选和全不选功能</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:CheckBox ID="chkcheck" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="stuID" HeaderText="编号" />
                <asp:BoundField DataField="stuName" HeaderText="姓名" />
                <asp:BoundField DataField="stuSex" HeaderText="性别" />
                <asp:BoundField DataField="stuHobby" HeaderText="爱好" />
            </Columns>
        
        </asp:GridView>
        <asp:CheckBox ID="chkAll" runat="server" AutoPostBack="True" Text="全选" 
            oncheckedchanged="chkAll_CheckedChanged" />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="取消" />
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="删除" />
        <br />
        （设置其postback属性设置为true，单击控件时自动回发到服务器）</div>
    </form>
</body>
</html>

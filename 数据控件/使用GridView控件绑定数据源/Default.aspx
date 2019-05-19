<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="使用GridView控件绑定数据源._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>使用GridView控件绑定数据源</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: left">
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" BorderStyle="Solid" CellPadding="4" 
            DataKeyNames="stuID" DataSourceID="SqlDataSource1" ForeColor="#333333" 
            GridLines="Horizontal" Caption="设置标题" 
            onselectedindexchanged="GridView1_SelectedIndexChanged">
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <Columns>
                <asp:BoundField DataField="stuID" HeaderText="编号" ReadOnly="True" 
                    SortExpression="stuID" />
                <asp:BoundField DataField="stuName" HeaderText="姓名" SortExpression="stuName" />
                <asp:BoundField DataField="stuSex" HeaderText="性别" SortExpression="stuSex" />
                <asp:BoundField DataField="stuHobby" HeaderText="爱好" 
                    SortExpression="stuHobby" />
            </Columns>
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#999999" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:db_StudentConnectionString %>" 
            DeleteCommand="DELETE FROM [tb_StuInfo] WHERE [stuID] = @stuID" 
            InsertCommand="INSERT INTO [tb_StuInfo] ([stuID], [stuName], [stuSex], [stuHobby]) VALUES (@stuID, @stuName, @stuSex, @stuHobby)" 
            SelectCommand="SELECT * FROM [tb_StuInfo]" 
            
            UpdateCommand="UPDATE [tb_StuInfo] SET [stuName] = @stuName, [stuSex] = @stuSex, [stuHobby] = @stuHobby WHERE [stuID] = @stuID" 
            ProviderName="<%$ ConnectionStrings:db_StudentConnectionString.ProviderName %>">
            <DeleteParameters>
                <asp:Parameter Name="stuID" Type="String" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="stuName" Type="String" />
                <asp:Parameter Name="stuSex" Type="String" />
                <asp:Parameter Name="stuHobby" Type="String" />
                <asp:Parameter Name="stuID" Type="String" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="stuID" Type="String" />
                <asp:Parameter Name="stuName" Type="String" />
                <asp:Parameter Name="stuSex" Type="String" />
                <asp:Parameter Name="stuHobby" Type="String" />
            </InsertParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>

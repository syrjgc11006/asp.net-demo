<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="查看GridView控件中数据的详细信息._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>查看GridView控件中的详细信息</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            Caption="系统详细信息" DataKeyNames="deptID" DataSourceID="SqlDataSource1" onselectedindexchanging="GridView1_SelectedIndexChanging" 
            >
            <Columns>
                <asp:CommandField SelectText="详细信息" ShowSelectButton="True" />
                <asp:BoundField DataField="deptID" HeaderText="deptID" ReadOnly="True" 
                    SortExpression="deptID" />
                <asp:BoundField DataField="deptName" HeaderText="deptName" 
                    SortExpression="deptName" />
                <asp:BoundField DataField="deptRemark" HeaderText="deptRemark" 
                    SortExpression="deptRemark" />
            </Columns>
        </asp:GridView>
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:db_StudentConnectionString %>" 
            SelectCommand="SELECT * FROM [tb_Department]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>

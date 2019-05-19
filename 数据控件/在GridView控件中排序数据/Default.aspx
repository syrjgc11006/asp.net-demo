<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="在GridView控件中排序数据._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>在GridView控件中排序数据</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" 
            AutoGenerateColumns="False"  style="margin-right: 0px" 
            onsorting="GridView1_Sorting">
            <Columns>
                <asp:BoundField DataField="stuID" HeaderText="编号" ReadOnly="True" 
                    SortExpression="stuID" />
                <asp:BoundField DataField="stuName" HeaderText="姓名" SortExpression="stuName" />
                <asp:BoundField DataField="stuSex" HeaderText="性别" SortExpression="stuSex" />
                <asp:BoundField DataField="stuHobby" HeaderText="爱好" 
                    SortExpression="stuHobby" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:db_StudentConnectionString %>" 
            SelectCommand="SELECT * FROM [tb_StuInfo]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>

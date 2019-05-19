<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="向GridView控件中插入记录._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>向gridview控件中插入记录</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:db_StudentConnectionString %>" 
            DeleteCommand="DELETE FROM [tb_Class] WHERE [classID] = @classID" 
            InsertCommand="INSERT INTO [tb_Class] ([classID], [className], [deptID], [classRemark]) VALUES (@classID, @className, @deptID, @classRemark)" 
            SelectCommand="SELECT * FROM [tb_Class]" 
            UpdateCommand="UPDATE [tb_Class] SET [className] = @className, [deptID] = @deptID, [classRemark] = @classRemark WHERE [classID] = @classID">
            <DeleteParameters>
                <asp:Parameter Name="classID" Type="String" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="className" Type="String" />
                <asp:Parameter Name="deptID" Type="String" />
                <asp:Parameter Name="classRemark" Type="String" />
                <asp:Parameter Name="classID" Type="String" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="classID" Type="String" />
                <asp:Parameter Name="className" Type="String" />
                <asp:Parameter Name="deptID" Type="String" />
                <asp:Parameter Name="classRemark" Type="String" />
            </InsertParameters>
        </asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="classID" 
            DataSourceID="SqlDataSource1" onrowcommand="GridView1_RowCommand">
            <Columns>
                <asp:BoundField DataField="classID" HeaderText="classID" ReadOnly="True" 
                    SortExpression="classID" />
                <asp:BoundField DataField="className" HeaderText="className" 
                    SortExpression="className" />
                <asp:BoundField DataField="deptID" HeaderText="deptID" 
                    SortExpression="deptID" />
                <asp:BoundField DataField="classRemark" HeaderText="classRemark" 
                    SortExpression="classRemark" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:ButtonField CommandName="Insert" Text="insert" />
            </Columns>
            <EmptyDataTemplate>
                <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
                    DataKeyNames="classID" DataSourceID="SqlDataSource1" Height="50px" 
                    oniteminserted="DetailsView1_ItemInserted" Width="125px">
                    <Fields>
                        <asp:BoundField DataField="classID" HeaderText="classID" ReadOnly="True" 
                            SortExpression="classID" />
                        <asp:BoundField DataField="className" HeaderText="className" 
                            SortExpression="className" />
                        <asp:BoundField DataField="deptID" HeaderText="deptID" 
                            SortExpression="deptID" />
                        <asp:BoundField DataField="classRemark" HeaderText="classRemark" 
                            SortExpression="classRemark" />
                        <asp:CommandField ShowInsertButton="True" />
                    </Fields>
                </asp:DetailsView>
            </EmptyDataTemplate>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>

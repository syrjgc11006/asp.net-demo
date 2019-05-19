<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="在GridView控件中对数据进行编辑操作._Default"MaintainScrollPositionOnPostback="true" %>

<!--单击gridview控件某行的按钮之后，刷新页面不会回到页面顶端-->
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>在GridView控件中对数据进行编辑操作</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="144px" 
            onrowediting="GridView1_RowEditing" 
            Width="219px" CellPadding="4" ForeColor="#333333" GridLines="None" 
            onrowcancelingedit="GridView1_RowCancelingEdit" 
            onrowdatabound="GridView1_RowDataBound" 
            onrowupdating="GridView1_RowUpdating" onrowdeleting="GridView1_RowDeleting">
            <RowStyle BackColor="#E3EAEB" />
            <Columns>
                <asp:BoundField HeaderText="编号" ReadOnly="True" DataField="stuID" />
                <asp:BoundField HeaderText="姓名" DataField="stuName" />
                <asp:BoundField HeaderText="性别" DataField="stuSex" />
                <asp:BoundField HeaderText="爱好" DataField="stuHobby" />
                <asp:CommandField ShowEditButton="True" HeaderText="编辑" />
                <asp:CommandField HeaderText="删除" ShowDeleteButton="True" />
            </Columns>
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
    
        <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="stuSex" 
            DataValueField="stuSex">
        </asp:DropDownList>
  
    
    </div>
    </form>
</body>
</html>

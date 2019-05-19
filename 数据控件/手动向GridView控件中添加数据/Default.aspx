<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="手动向GridView控件中添加数据._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField />
                <asp:BoundField />
                <asp:BoundField />
                <asp:BoundField />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>

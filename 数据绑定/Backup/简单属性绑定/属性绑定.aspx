<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="属性绑定.aspx.cs" Inherits="简单属性绑定._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>简单数据绑定</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        简单属性绑定<br />
        商品名称：<%#GoodsName%><br />
        商品种类：<%#GoodsKind%>
    </div>
    </form>
</body>
</html>

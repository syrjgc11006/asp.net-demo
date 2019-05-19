<%@ Control Language="C#" AutoEventWireup="true" CodeFile="menu.ascx.cs" Inherits="WebUserControl" %>
<table style="font-size: 10pt; color: #000099; margin-top: 0px; padding-top: 0px; width: 778px; height:214px" border="0" cellspacing="0"  background ="Images/新闻发布系统首页1.jpg">
    <tr style ="width :778px; height :10px">
    <td align=center  colspan =11>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    <a href="#" onclick ="this.style.behavior='url(#default#homepage)';this.sethomepage('http://www.mingrisoft.com')" style=" color:Black; font-size: 9pt; font-family: 宋体;  text-decoration :none;" >设置主页</a>
            &nbsp;<a href="#" onclick="window.external.addFavorite('http://www.mingrisoft.com','新闻发布网站');" style=" color:Black; font-size: 9pt; font-family: 宋体;  text-decoration :none;" >收藏本站</a>
    </td>
    </tr>
    <tr style ="width :778px; height :27px" >
        <td align="right" colspan="11" >
            输入关键字：<asp:TextBox ID="txtKey" runat="server" Width="240px" ></asp:TextBox>&nbsp;
            <asp:DropDownList ID="ddlStyle" runat="server" Width="78px"  >
                <asp:ListItem>时政要闻</asp:ListItem>
                <asp:ListItem>经济动向</asp:ListItem>
                <asp:ListItem>世界军事</asp:ListItem>
                <asp:ListItem>科学教育</asp:ListItem>
                <asp:ListItem>法治道德</asp:ListItem>
                <asp:ListItem>社会现象</asp:ListItem>
                <asp:ListItem>体育世界</asp:ListItem>
                <asp:ListItem>时尚娱乐</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="btnSearch" runat="server" Text="站内搜索"  OnClick="btnSearch_Click" />
           </td>       
    </tr>
    <tr style ="width :778px; height :27px" >
        <td align="left" rowspan="1" style="width: 154px; ">
          
             <asp:Label ID="labDate" runat="server" Text=""  ></asp:Label>
        </td>
        <td align="center" style="width: 58px;">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx" Font-Underline="False" ForeColor="#333333">主页</asp:HyperLink></td>
        <td align="center" style="width: 49px;">
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/newsList.aspx?id=1" Font-Underline="False" ForeColor="#333333">时政</asp:HyperLink></td>
        <td align="center" style="width: 60px;">
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/newsList.aspx?id=2" Font-Underline="False" ForeColor="#333333">经济</asp:HyperLink></td>
        <td align="center" style=" width: 55px;">
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/newsList.aspx?id=3" Font-Underline="False" ForeColor="#333333">军事</asp:HyperLink></td>
        <td align="center" style="width: 56px;">
            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/newsList.aspx?id=4" Font-Underline="False" ForeColor="#333333">科教</asp:HyperLink></td>
        <td align="center" style=" width: 53px;">
            <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/newsList.aspx?id=5" Font-Underline="False" ForeColor="#333333">法制</asp:HyperLink></td>
        <td align="center" style=" width: 53px;">
            <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/newsList.aspx?id=6" Font-Underline="False" ForeColor="#333333">社会</asp:HyperLink></td>
        <td align="center" style=" width: 56px;">
            <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/newsList.aspx?id=7" Font-Underline="False" ForeColor="#333333">体育</asp:HyperLink></td>
        <td align="center" style=" width: 78px;">
            <asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl="~/newsList.aspx?id=8" Font-Underline="False" ForeColor="#333333">娱乐</asp:HyperLink></td>
    <td >
    
    </td>
    </tr>
    <tr style ="width :778px; height :142px" >
    <td colspan="11"></td>
    </tr>
   
</table>
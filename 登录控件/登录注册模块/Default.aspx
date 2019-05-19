<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table style=" width: 200px; height: 177px; background-image: url(images/登录.jpg); background-repeat :no-repeat" border="0" cellpadding="0" cellspacing="0" runat =server   id=tabLoading align="center"  >
              <tr>
              <td colspan =2 style="height: 27px">
              </td>
              </tr>
                <tr style ="width: 152px;height: 18px; font-size: 9pt; font-family: 宋体;">
                    <td style="height: 12px; width: 152px;" >
                        &nbsp;
                        会员名：</td>
                    <td style="width: 158px;height: 12px; ">
                        <asp:TextBox ID="txtName" runat="server"  Width="101px" Height="14px"></asp:TextBox></td>
                  
                </tr>
                <tr style ="width: 152px;height: 18px;font-size: 9pt; font-family: 宋体;">
                    <td style="width: 1014px" >
                        &nbsp; &nbsp;
                        密码：</td>
                    <td style="width: 158px; ">
                        <asp:TextBox ID="txtPassword" runat="server"  TextMode="Password" Height="12px" Width="101px"></asp:TextBox></td>
                   
                </tr>
                <tr>
                    <td colspan="2" style="height: 28px">
                        &nbsp; &nbsp; &nbsp;<asp:ImageButton ID="btnLoad" runat="server" OnClick="btnLoad_Click" Height="18px" Width="40px" CausesValidation="False" ImageUrl="~/images/登录按钮.jpg" />
                        <asp:ImageButton ID="btnRegister" runat="server" OnClick="btnRegister_Click" Height="18px" Width="40px" CausesValidation="False" ImageUrl="~/images/注册按钮.jpg"/>
                        </td>
                        
                </tr>
         <tr>
             <td colspan="2" style="height: 28px">
             </td>
         </tr>
            </table>  
    </div>
    </form>
</body>
</html>

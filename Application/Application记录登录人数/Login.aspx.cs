using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtUserName.Text=="mr" && txtPwd .Text =="mrsoft")
        {
            Session["UserName"] = txtUserName.Text;//使用Session变量记录用户名
            Application.Lock();
            Application["count"] = (int)Application["count"] + 1;
            Application.UnLock();
            Response.Redirect("~/Welcome.aspx");//跳转到主页
        }
        else
        {
            Response.Write("<script>alert('登录失败！请返回查找原因');location='Login.aspx'</script>");
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtPwd.Text = "";
        txtUserName.Text = "";
    }
}

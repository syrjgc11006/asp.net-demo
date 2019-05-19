using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page
{
    UserManage usermanage = new UserManage();//声明一个UserManage
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLoad_Click(object sender, ImageClickEventArgs e)
    {
        if (txtName.Text == string.Empty)
        {
            Response.Write("<script language=javascript>alert('登录名不能为空！')</script>");
            return;
        }
        else
        {
            DataSet ds = null;
            usermanage.UserName = txtName.Text;
            usermanage.UserPwd = txtPassword.Text;
            ds = usermanage.Login(usermanage);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Response.Write("<script language=javascript>alert('您是合法用户！')</script>");
            }
            else
            {
                Response.Write("<script language=javascript>alert('用户名称或密码不正确！')</script>");
            }
        }
    }
    protected void btnRegister_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
}

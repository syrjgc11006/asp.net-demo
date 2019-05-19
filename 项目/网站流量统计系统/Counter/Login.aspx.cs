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
        //获取用户信息
        DataSet ds = DB.reDs("select * from tb_UserInfo where UserName='" + txtUserName.Text.Trim() + "' and PassWord='" + txtPwd.Text.Trim() + "'");

        if (ds.Tables[0].Rows.Count != 0)//通过dr中是否包含行判断用户是否通过身份验证
        {
            Response.Redirect("~/Default.aspx");//跳转到主页
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

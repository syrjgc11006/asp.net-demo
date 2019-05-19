using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_HomeWork
{
    public partial class Login : System.Web.UI.Page
    {
        string[,] user = { { "张三", "123" }, { "王五", "456" }, { "李四", "789" } };
      
        protected void Page_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 2; i++)
            {
                if(txtName.Text==user[i,0]&&txtPassword.Text==user[i,1])
                {
                    Session["user"] = user[i, 0];
                    Response.Redirect("chat.htm");
                }

            }
            Response.Write("<script type='text/javascript'> alert('用户名或密码错误！');</script>");
        }
    }
}
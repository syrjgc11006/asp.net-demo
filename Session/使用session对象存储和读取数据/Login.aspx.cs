using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace 使用session对象存储和读取数据
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "mr" && txtPwd.Text =="123")
            {
                Session["UserName"] = txtUserName.Text;     //使用session变量记录用户名
                Session["LoginTime"] = DateTime.Now;      //记录用户登录系统的时间
                Response.Redirect("welcome.aspx");
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
}

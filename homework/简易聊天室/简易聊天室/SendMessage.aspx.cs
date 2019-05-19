using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_HomeWork
{
    public partial class SendMessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblName.Text = "发言人：" + Session["user"];
            //如果该页面不是首次加载，没有响应客户端回发
            if (!IsPostBack)
            {
                //全局变量，对共享数据信息
                Application["message"] += Session["user"] + "进入聊天室<br/>";
            }
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            Application.Lock();
            Application["message"] += Session["user"] + "说:" + txtMessage.Text + "(" + DateTime.Now.ToString() + ")<br/>";
            Application.UnLock();
            txtMessage.Text = "";
        }
    }
}
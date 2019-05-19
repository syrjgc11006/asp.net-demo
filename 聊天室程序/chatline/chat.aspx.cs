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

namespace chatline
{
    public partial class chat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtNum.Text = Application["userNum"].ToString();
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            int p_int_current = Convert.ToInt32(Application["current"]);            //记录当前在线用户数目
            Application.Lock();                                                     //互斥共享数据
            //如果当前在线用户数目为0
            if (p_int_current == 0 || p_int_current > 20)
            {
                p_int_current = 0;
                //记录当前聊天的信息
                Application["chats"] = Session["userName"].ToString() + "说：" + txtMessage.Text.Trim() + "(" + DateTime.Now.ToString() + ")";
            }
            else
            {
                //将新登录的用户添加到在线用户列表，并记录他们聊天内容
                Application["chats"]=Application["chats"].ToString()+","+Session["userName"].ToString() +"说：" + txtMessage.Text.Trim() + "(" + DateTime.Now.ToString() + ")";
            }
            p_int_current += 1;                     //当前在线人数加1
            Application["current"] = p_int_current; //更新全局变量的值
            Application.UnLock();
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            Application.Lock();
            //记录在线用户
            string p_str_userName = Application["user"].ToString();
            //用列表中在线的用户代替刚刚进入聊天室的对象
            Application["user"] = p_str_userName.Replace(Session["userName"].ToString(),"");
            Application.UnLock();
            Response.Write("<script>window.opener=null;window.close();</script>");
        }
    }
}

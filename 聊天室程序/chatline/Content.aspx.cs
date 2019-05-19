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
    public partial class Content : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //记录当前在线用户数量
            int p_int_current = Convert.ToInt32(Application["current"]);
            Application.Lock();
            //记录聊天内容
            string p_str_chats = Application["chats"].ToString();
            //用逗号分隔聊天内容
            string[] p_str_chat = p_str_chats.Split(',');
            //遍历聊天数组中的内容
            for (int i = p_str_chat.Length - 1; i >= 0; i--)
            {
                //如果当前没有用户
                if (p_int_current == 0)
                {
                    txtContent.Text = p_str_chat[i].ToString();
                }
                else
                {
                    txtContent.Text = txtContent.Text + "\n" + p_str_chat[i].ToString();
                }
            }
            Application.UnLock();
        }
    }
}

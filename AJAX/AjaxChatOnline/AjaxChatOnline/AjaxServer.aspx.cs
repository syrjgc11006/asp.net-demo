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

public partial class AjaxServer : System.Web.UI.Page
{
    User us = new User();
    protected void Page_Load(object sender, EventArgs e)
    {
        string type;
        type = Request.QueryString["type"];
        if (type == "1")
            Login();
        else if (type == "2")
            Talk();
        else if (type == "3")
        {
            us.SetLastActive(Session["User"].ToString(), DateTime.Now.ToString());
            Response.Write(Application["Chat"].ToString());
        }
        else if (type == "4")
            Reg();
        else
            Response.Write("出错啦");
    }
    //登录
    public void Login()
    {
        string uid, pwd;
        uid = Request.QueryString["yhm"];
        pwd = Request.QueryString["mm"];

        if (us.Is_Login(uid, pwd))
        {
            TimeSpan ts = DateTime.Now - Convert.ToDateTime(us.GetLastActive(uid));
            if (ts.TotalSeconds < 60)
            {                
                Response.Write("0");
            }
            else
            {
                Session["User"] = uid;

                us.SetLastActive(uid,DateTime.Now.ToString());

                Application.Lock();
                Application["Chat"]= Application["Chat"].ToString()+"欢迎【<font color='blue'>"+uid+"</font>】进入聊天室["+DateTime.Now.ToString()+"]<br />";
                Application.UnLock();

                Response.Write("1");
            }
        }
    }
    //发言
    public void Talk()
    {
        string msg,time,uid;

        msg = Request.QueryString["msg"];
        time=DateTime.Now.ToString();
        uid = Session["User"].ToString();

        if (us.IsAllowChat(uid))
        {
            us.AddChat(uid, msg, time);            
            Application.Lock();
            if (Application["Chat"].ToString().Length > 500)
            {                
               Application["Chat"] = "<a href='ChatDetail.aspx'>查看更多...</a><br/>";
            }
            Application["Chat"] = Application["Chat"].ToString() + uid + "说:" + msg + "<br/>";
            Application.UnLock();
            us.SetLastActive(uid, DateTime.Now.ToString());
            Response.Write(Application["Chat"].ToString());
                      
        }
        else
        {
            us.AddNoChat(uid, msg, time);
            Response.Write("0");
        }
     
    }
    //注册
    public void Reg()
    {
        string uid, pwd;
        uid = Request.QueryString["yhm"];
        pwd = Request.QueryString["mm"];
        if (us.IsUse(uid))
        {
            Response.Write("-1");
        }
        else
        {
            us.AddUser(uid, pwd);
            Session["User"] = uid;

            us.SetLastActive(uid, DateTime.Now.ToString());
            Application.Lock();
            Application["Chat"] = Application["Chat"].ToString() + "欢迎新用户【<font color='blue'>" + uid + "</font>】进入聊天室[" + DateTime.Now.ToString() + "]<br />";
            Application.UnLock();                  
        }   
    }

}

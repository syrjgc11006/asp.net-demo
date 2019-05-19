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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            int p_int_judge = 0;                             //在页面刷新前运行的代码
            p_int_judge = Convert.ToInt32(Request["value"]); //记录该用户访问的次数
            
            //判断该网页不是首次被加载
            if (!IsPostBack)
            {
                //加入该用户正在访问
                if (p_int_judge == 1)
                {
                    Response.Write("<script>alert('该用户已经登录!')</script>");
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Application.Lock();                                         //锁定对当前页面的访问，促进线程的同步
            int p_int_num;                                              //在线人数
            string p_str_name;                                          //登录用户名
            string p_str_names;                                         //已在线用户
            string[] p_str_uer;                                         //在线用户数组

            p_int_num = int.Parse(Application["userNum"].ToString());   //获取当前在线的人数

            //如果在用户名中输入空值，则弹出提示
            if (txtname.Text == "")
            {
                Response.Write("<script>alert('用户名不能为空')</script>");
                txtname.Focus();
            }
            else
            {
                p_str_name = txtname.Text.Trim();                              //记录当前登录的用户的用户名
                p_str_names = Application["user"].ToString();                  //获取已经在线的用户的用户名
                p_str_uer = p_str_names.Split(',');                            //将当前在线用户列表中的用户名用“分隔符”分开并且存放到一个当前在线用户列表数组中
               
                //遍历当前在线用户列表，判断当前登录的用户是否已经登录了
                for (int i = 0; i <= p_int_num - 1; i++)
                {
                    //如果该用户已经在用户列表中了
                    if (p_str_name == p_str_uer[i].Trim())
                    {
                        int p_int_judge = 1;                                    //表明当前用户已经在用户列表中了
                        Response.Redirect("~Login.aspx?value=" + p_int_judge);  //重定向到登录窗口重新登录，并且将信息返回到当前页面
                    }              
                }
                //如果当前在线用户数为0，则将当前用户信息存储application对象中
                if (p_int_num == 0)
                {
                    Application["user"] = p_str_name.ToString();
                }
                else
                {
                    Application["user"] = Application["user"] + "," + p_str_name.ToString();//将登录的用户名加入到服务端对象中
                }
                p_int_num += 1;                                                             //当前用户数量增加一个
                Application["userNum"] = p_int_num;                                         //将用户数量信息交给服务端对象
                //记录当前登录用户的用户名
                Session["userName"] = txtname.Text.Trim();
                Application.UnLock();                                                       //解锁
                Response.Redirect("chat.aspx");
            }
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.close()</script>");
        }
    }
}

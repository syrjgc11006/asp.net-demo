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
using System.Data.SqlClient;//需引入的命名空间

public partial class Register : System.Web.UI.Page
{
    int reValue;//用于保存返回值。返回值为-1（用户名存在），0（失败），1（成功），2（用户名不存在）
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //注册新用户
    protected void btnOk_Click(object sender, EventArgs e)
    {
        reValue = CheckName();
        if (reValue == -1)
        {
            Response.Write("<script>alert('用户名存在！');</script>");
        }
        else
        {
            DB db = new DB();
            string UserName = this.txtUserName.Text;
            string PassWord = db.MD5 (this.txtPwd.Text.ToString ());//MD5加密
            string Email = this.txtEmail.Text;
            
            string cmdstr = "insert into tb_User(UserName,PassWord,Email) values('" + UserName + "','" + PassWord + "','" + Email + "')";
            try
            {
                reValue = db.sqlEx(cmdstr);
                if (reValue == 1)
                {
                    Response.Write("<script>alert('注册成功！');</script>");
                    Clear();//清空文本框
                }
                else if (reValue == 0)
                {
                    Response.Write("<script>alert('注册失败！');</script>");
                }
            }
            catch (Exception ee)
            {
                Response.Write("<script>alert('注册失败！');</script>");
            }
        }
    }
    //检测用户名是否存在
    protected void lnkbtnCheck_Click(object sender, EventArgs e)
    {
        //查找用户名是否存在,已经存在返回-1，不存在返回2
        reValue = CheckName();
        if (reValue == -1)
        {
            Response.Write("<script>alert('用户名存在！');</script>");
            this.txtUserName.Focus();
        }
        else if (reValue == 2)
        {
            Response.Write("<script>alert('恭喜您！该用户名尚未注册！');</script>");
            this.txtUserName.Focus();
        }
    }
    //验证用户名是否存在
    public int CheckName()
    {
        //实例化公共类对象
        DB db = new DB();
        string str = "select count(*) from tb_User where UserName='" + this.txtUserName.Text + "'";
        try
        {
            DataTable dt =db.reDt(str);
            if (dt.Rows[0][0].ToString() != "0")
            {
                return -1;//该用户名已经存在
            }
            else
            {
                return 2;//该用户名尚未注册
            }
        }
        catch (Exception ee)
        {
            return 0;
        }
    }
    //清空文本框
    public void Clear()
    {
        this.txtUserName.Text = "";
        this.txtPwd.Text = "";
        this.txtRepwd.Text = "";
        this.txtEmail.Text = "";
    }
    //返回登录页
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Login.aspx");
    }
}

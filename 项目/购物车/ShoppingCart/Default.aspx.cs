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
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds = DB.reDs("select * from tb_GoodsInfo");
        dlGoodsInfo.DataSource = ds;//指定数据源
        dlGoodsInfo.DataBind();
        //是否显示登录
        if (Session["UserID"] == null)
        {
            pl1.Visible = true;//显示登录面板
            pl2.Visible = false;//不显示登录名户名显示面板
        }
        else
        {
            pl1.Visible = false;//不显示登录面板
            pl2.Visible = true;//显示登录名户名显示面板
            labMessage.Text = "欢迎" + txtUserName.Text + "的光临！";
        }
    }
    protected void dlGoodsInfo_ItemCommand(object source, DataListCommandEventArgs e)
    {

        if (e.CommandName == "describe")
        {
            string P_str_GoodsID = e.CommandArgument.ToString();
            Response.Write("<script>window.open('Describe.aspx?GoodsID=" + P_str_GoodsID + "','','width=637px,height=601px')</script>");
        }
        if (e.CommandName == "buy")
        {
            if (Session["UserID"] != null)
            {
                string P_str_GoodsID = e.CommandArgument.ToString();
                Response.Redirect("~/ShoppingCart.aspx?GoodsID=" + P_str_GoodsID);
            }
            else
            {
                Response.Write("<script>alert('您还没有登录，请先登录再购买！');</script>");
            }
        }
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //获取用户信息
        DataSet ds = DB.reDs("select * from tb_User where UserName='" + txtUserName.Text.Trim() + "' and PassWord='" + txtPwd.Text.Trim() + "'");

        if (ds.Tables[0].Rows.Count != 0)//判断用户是否通过身份验证
        {
            Session["UserID"] = ds.Tables[0].Rows[0][0].ToString();
            labMessage.Text = "欢迎"+txtUserName.Text+"的光临！";
            pl1.Visible = false;
            pl2.Visible = true;
        }
        else
        {
            Response.Write("<script>alert('登录失败！请返回查找原因');</script>");
        }
    }
}

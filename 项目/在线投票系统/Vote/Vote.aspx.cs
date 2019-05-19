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

public partial class Vote : System.Web.UI.Page
{
    public static string M_Str_voteID;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            M_Str_voteID = Request["voteID"];
            labBind();//显示投票标题
            rblBind();//显示投票选项
        }
    }
    //绑定Label控件
    public void labBind()
    {
        DataSet ds = DB.reDs("select voteTitle from tb_Vote where voteID="+M_Str_voteID);
        labVoteTitle.Text = ds.Tables[0].Rows[0][0].ToString();
    }
    //绑定RadioButtonList控件
    public void rblBind()
    {
        DataSet ds = DB.reDs("select * from tb_VoteItem where voteID=" + M_Str_voteID);
        rblVoteItem.DataSource = ds;
        rblVoteItem.DataTextField = "voteContent";
        rblVoteItem.DataValueField = "voteItemID";
        rblVoteItem.DataBind();
    }
    protected void btnVote_Click(object sender, EventArgs e)
    {

        //投票防作弊
        HttpCookie makecookie= new HttpCookie("Vote" + M_Str_voteID);//制造cookie
        HttpCookie readcookie = Request.Cookies["Vote"+M_Str_voteID];//读出cookie

        if (readcookie == null)//从未投过票
        {
            makecookie.Values.Add("VoteItem", "<" + M_Str_voteID + ">");//设置其值
            makecookie.Expires = DateTime.MaxValue;//设置过期时间
        }
        else//已经投过票
        {
            string P_Str_AllItem = readcookie.Values["VoteItem"].ToString();//读取已投票的项
            if (P_Str_AllItem.IndexOf("<" + M_Str_voteID + ">") == -1)//未对该主题投过票
            {
                makecookie.Values.Add("VoteItem", readcookie.Values["VoteItem"] + "<" + M_Str_voteID + ">");
            }
            else//已对该主题投过票
            {
                Response.Write("<script language=javascript>alert('该主题你已经成功投过票，不能重新投票！');</script>");
                return;
            }
        }
        
        //执行投票操作，票数加1
        string P_Str_voteItemID = this.rblVoteItem.SelectedValue;
        string P_Str_cmdtxt = "update tb_VoteItem set voteTotal=voteTotal+1 where voteItemID=" + P_Str_voteItemID + " and voteID=" + M_Str_voteID;
        bool P_Bl_reVal = DB.ExSql(P_Str_cmdtxt);
        if (P_Bl_reVal)
        {
            Response.AppendCookie(makecookie);//写入Cookie
            Response.Write("<script>alert('投票成功，感谢您的支持！');window.open('VoteResult.aspx?voteID=" + M_Str_voteID + "&title=" + Server.UrlEncode (labVoteTitle.Text) + "','new');</script>");
        }
        else
            Response.Write("<script>alert('投票失败！');</script>");

    }
    protected void btnResult_Click(object sender, EventArgs e)
    {
        Response.Write("<script>window.open('VoteResult.aspx?voteID=" + M_Str_voteID + "&title=" + Server.UrlEncode (labVoteTitle.Text) + "','new');</script>");
    }
}

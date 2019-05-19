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

public partial class ManageVote : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { 
             Bind();
        }
    }
    public void Bind()
    {
        DataSet ds = DB.reDs("select * from tb_Vote");
        dlVoteManage.DataSource = ds;
        dlVoteManage.DataKeyField = "voteID";
        dlVoteManage.DataBind();
    }
    protected void dlVoteManage_DeleteCommand(object source, DataListCommandEventArgs e)
    {
        string P_Str_voteID = e.CommandArgument.ToString();
        bool P_Bl_reVal = DB.ExSql("delete from tb_Vote where voteID=" + P_Str_voteID);
        if (P_Bl_reVal)
            DB.ExSql("delete from tb_VoteItem where voteID=" + P_Str_voteID);
        else
            Response.Write("<script>alert('删除失败！');</script>");
        Bind();
    }


    protected void btnDelete_Load(object sender, EventArgs e)
    {
        //删除前给出提示信息
        ((Button)sender).Attributes["onclick"] = "javascript:return confirm('你确认要删除该条记录吗？')";
    }
    protected void imgbtnBack_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/Default.aspx");//跳转到主页
    }
}

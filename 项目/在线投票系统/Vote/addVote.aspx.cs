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

public partial class addVote : System.Web.UI.Page
{
    public static string M_Str_voteID = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            set(true);
        }
    }
    //页面设置
    #region
    public void set(bool P_Bl_value)
    {
        txtTitle.Enabled = P_Bl_value;//输入标题的文本框是否可用
        RequiredFieldValidator1.Enabled = P_Bl_value;//验证标题文本框的验证控件是否启用
        imgbtnAdd.Enabled = P_Bl_value;//添加按钮是否可用
        panelItem.Visible = !P_Bl_value;//Panel控件是否显示
        RequiredFieldValidator2.Enabled = !P_Bl_value;//验证投票选项的文本框的验证控件是否启用
    }
    #endregion

    //自动编号
    #region
    public string AutoID(string P_Str_tbName, string P_Str_colName)
    {
        string P_Str_ID = null;
        try
        {
            DataSet ds = DB.reDs("select Max(" + P_Str_colName + ") from " + P_Str_tbName);
            string P_Str_value = ds.Tables[0].Rows[0][0].ToString();
            if (P_Str_value != "")
            {
                P_Str_ID = Convert.ToString(Convert.ToInt32(P_Str_value) + 1);
            }
            else
            {
                P_Str_ID = "1";
            }
        }
        catch (Exception ee)
        {
            Response.Write("<script>alert('" + ee.Message + "');</script>");
        }
        return P_Str_ID;
    }
    #endregion

    //绑定ListBox控件
    #region
    public void Bind(string P_Str_voteID)
    {
        DataSet ds = DB.reDs("select * from tb_VoteItem where voteID=" + P_Str_voteID);
        lbItem.DataSource = ds;
        lbItem.DataTextField = "voteContent";//设置为列表项提供文本内容的字段
        lbItem.DataValueField = "voteItemID";//设置为列表项提供值的字段
        lbItem.DataBind();//将数据源绑定到ListBox控件
    }
    #endregion

    //添加投票
    #region
    protected void imgbtnAdd_Click(object sender, ImageClickEventArgs e)
    {
        M_Str_voteID = AutoID("tb_Vote", "voteID");
        string P_Str_Title = this.txtTitle.Text.Trim();
        if (M_Str_voteID != null)
        {
            bool P_Bl_reVal = DB.ExSql("insert into tb_Vote values(" + M_Str_voteID + ",'" + P_Str_Title + "')");
            if (P_Bl_reVal)
                set(false);//设置页面
            else
                Response.Write("<script>alert('添加失败，请查找原因!');</script>");
        }
    }
    #endregion

    //添加投票选项
    #region
    protected void lnkbtnAddItem_Click(object sender, EventArgs e)
    {
        string P_Str_itemID = AutoID("tb_VoteItem", "voteItemID");
        string P_Str_voteID = M_Str_voteID;
        string P_Str_voteContent = this.txtItem.Text.Trim();
        string P_Str_cmdtxt = "insert into tb_VoteItem(voteItemID,voteID,voteContent) values(" + P_Str_itemID + "," + P_Str_voteID + ",'" + P_Str_voteContent + "')";
        if (P_Str_itemID != null)
        {
            bool P_Bl_reVal = DB.ExSql(P_Str_cmdtxt);
            if (P_Bl_reVal)
            {
                Bind(P_Str_voteID);//绑定ListBox
                this.txtItem.Text = "";
            }
            else
                Response.Write("<script>alert('添加失败，请查找原因!');</script>");

        }
    }
    #endregion

    //删除投票选项
    #region
    protected void lnkbtnRemove_Click(object sender, EventArgs e)
    {
        string P_Str_itemID = this.lbItem.SelectedValue;
        bool P_Bl_reVal = DB.ExSql("delete from tb_VoteItem where voteItemID=" + P_Str_itemID);
        if (P_Bl_reVal)
            Bind(M_Str_voteID);//重新绑定
        else
            Response.Write("<script>alert('移除失败，请查找原因!');</script>");
    }
    #endregion

    //结束投票选项的编辑
    #region
    protected void imgbtnClose_Click(object sender, ImageClickEventArgs e)
    {
        set(true);
        this.txtTitle.Text = "";
    }
    #endregion

    //返回
    #region
    protected void imgbtnBack_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/Default.aspx");//跳转到主页
    }
    #endregion

}

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

public partial class Manage_MemberEdit : System.Web.UI.Page
{
    CommonClass CC = new CommonClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }
    }
    public void bind()
    {
        this.gvEditMember.DataSource = CC.GetDataSet("select * from tb_User order by ID", "tbUser");
        this.gvEditMember.DataKeyNames=new string []{"ID"};
        this.gvEditMember.DataBind();
    }
    protected void gvEditMember_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvEditMember.PageIndex = e.NewPageIndex;
        bind();
    }
    protected void gvEditMember_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int IntAdminID = Convert.ToInt32(gvEditMember.DataKeys[e.RowIndex].Value.ToString());
        CC.ExecSQL("Delete from tb_User where ID='" + IntAdminID + "'");
        bind();
    }
    protected void gvEditMember_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvEditMember.EditIndex = -1;
        bind();
    }
    protected void gvEditMember_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvEditMember.EditIndex = e.NewEditIndex;
        bind();
    }
    protected void gvEditMember_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int IntAdminID = Convert.ToInt32(gvEditMember.DataKeys[e.RowIndex].Value.ToString());
        string strAdmin = ((TextBox)(gvEditMember.Rows[e.RowIndex].Cells[1].Controls[0])).Text.ToString();
        string strPassword = ((TextBox)(gvEditMember.Rows[e.RowIndex].Cells[2].Controls[0])).Text.ToString();
        CC.ExecSQL("Update tb_User set Name='" + strAdmin + "',PassWord='" + strPassword + "' where ID='" + IntAdminID + "'");
        gvEditMember.EditIndex = -1;
        bind();
    }
    //protected void gvEditMember_RowDataBound(object sender, GridViewRowEventArgs e)
    //{
    //    if (e.Row.RowType == DataControlRowType.DataRow)
    //    {
    //        ((LinkButton)(e.Row.Cells[3].Controls[0])).Attributes.Add("onclick","return confirm('确定要删除吗？')");
        
    //    }
    //}
}

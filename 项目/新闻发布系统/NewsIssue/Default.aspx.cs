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
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    CommonClass CC = new CommonClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        //时政要闻
        dlSZ.DataSource = CC.GetDataSet("SELECT TOP 5 * FROM tb_News WHERE Style = '时政要闻' order by issueDate Desc", "tbNews");
        dlSZ.DataKeyField = "id";
        dlSZ.DataBind();
        //经济动向
        dlJJ.DataSource = CC.GetDataSet("SELECT TOP 5 * FROM tb_News WHERE Style = '经济动向' order by issueDate Desc", "tbNews");
        dlJJ.DataKeyField = "id";
        dlJJ.DataBind();
        //世界军事
        dlJS.DataSource = CC.GetDataSet("SELECT TOP 5 * FROM tb_News WHERE Style = '世界军事'order by issueDate Desc", "tbNews");
        dlJS.DataKeyField = "id";
        dlJS.DataBind();
        //科学教育
        dlKJ.DataSource = CC.GetDataSet("SELECT TOP 5 * FROM tb_News WHERE Style = '科学教育'order by issueDate Desc", "tbNews");
        dlKJ.DataKeyField = "id";
        dlKJ.DataBind();
        //法制道德
        dlFZ.DataSource = CC.GetDataSet("SELECT TOP 5 * FROM tb_News WHERE Style = '法治道德' order by issueDate Desc", "tbNews");
        dlFZ.DataKeyField = "id";
        dlFZ.DataBind();
        //社会现象
        dlSH.DataSource = CC.GetDataSet("SELECT TOP 5 * FROM tb_News WHERE Style = '社会现象' order by issueDate Desc", "tbNews");
        dlSH.DataKeyField = "id";
        dlSH.DataBind();
        //体育世界
        dlTY.DataSource = CC.GetDataSet("SELECT TOP 5 * FROM tb_News WHERE Style = '体育世界'order by issueDate Desc", "tbNews");
        dlTY.DataKeyField = "id";
        dlTY.DataBind();
        //时尚娱乐
        dlYL.DataSource = CC.GetDataSet("SELECT TOP 5 * FROM tb_News WHERE Style = '时尚娱乐'order by issueDate Desc", "tbNews");
        dlYL.DataKeyField = "id";
        dlYL.DataBind();
    }

    protected void dlSZ_ItemCommand(object source, DataListCommandEventArgs e)
    {
        int id = Convert.ToInt32(dlSZ.DataKeys[e.Item.ItemIndex].ToString());
        Response.Write("<script language=javascript>window.open('showNews.aspx?id=" + id + "','','width=520,height=260')</script>");
    }
    protected void dlJJ_ItemCommand(object source, DataListCommandEventArgs e)
    {
        int id = Convert.ToInt32(dlJJ.DataKeys[e.Item.ItemIndex].ToString());
        Response.Write("<script language=javascript>window.open('showNews.aspx?id=" + id + "','','width=520,height=260')</script>");
    }
    protected void dlJS_ItemCommand(object source, DataListCommandEventArgs e)
    {
        int id = Convert.ToInt32(dlJS.DataKeys[e.Item.ItemIndex].ToString());
        Response.Write("<script language=javascript>window.open('showNews.aspx?id=" + id + "','','width=520,height=260')</script>");
    }
    protected void dlKJ_ItemCommand(object source, DataListCommandEventArgs e)
    {
        int id = Convert.ToInt32(dlKJ.DataKeys[e.Item.ItemIndex].ToString());
        Response.Write("<script language=javascript>window.open('showNews.aspx?id=" + id + "','','width=520,height=260')</script>");
    }
    protected void dlFZ_ItemCommand(object source, DataListCommandEventArgs e)
    {
        int id = Convert.ToInt32(dlFZ.DataKeys[e.Item.ItemIndex].ToString());
        Response.Write("<script language=javascript>window.open('showNews.aspx?id=" + id + "','','width=520,height=260')</script>");
    }

    protected void dlTY_ItemCommand(object source, DataListCommandEventArgs e)
    {
        int id = Convert.ToInt32(dlTY.DataKeys[e.Item.ItemIndex].ToString());
        Response.Write("<script language=javascript>window.open('showNews.aspx?id=" + id + "','','width=520,height=260')</script>");
    }
    protected void dlYL_ItemCommand(object source, DataListCommandEventArgs e)
    {
        int id = Convert.ToInt32(dlYL.DataKeys[e.Item.ItemIndex].ToString());
        Response.Write("<script language=javascript>window.open('showNews.aspx?id=" + id + "','','width=520,height=260')</script>");
    }
    protected void dlSH_ItemCommand(object source, DataListCommandEventArgs e)
    {
        int id = Convert.ToInt32(dlSH.DataKeys[e.Item.ItemIndex].ToString());
        Response.Write("<script language=javascript>window.open('showNews.aspx?id=" + id + "','','width=520,height=260')</script>");
    }
}

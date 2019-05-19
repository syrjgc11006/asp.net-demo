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
using System.Data.SqlClient;  //添加类库

public partial class showNews : System.Web.UI.Page
{
    CommonClass CC = new CommonClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds = CC.GetDataSet("select * from tb_News", "tbNews");
        DataRow[] row = ds.Tables["tbNews"].Select("id=" + Request.QueryString["id"]);
        foreach (DataRow rs in row)
        {
            this.Page.Title = rs["title"].ToString();
            this.labTitle.Text = rs["title"].ToString();
            this.txtContent.Text ="　　"+ rs["content"].ToString();
        }

    }
    protected void btnClose_Click(object sender, EventArgs e)
    {
        Response.Write("<script language=javascript>window.close()</script>");
    }
}

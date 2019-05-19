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

public partial class AllVote : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind();
        }
    }
    //绑定DataList控件
    public void Bind()
    {
        DataSet ds = DB.reDs("select * from tb_Vote");
        dlVote.DataSource = ds;
        dlVote.DataBind();
    }
}

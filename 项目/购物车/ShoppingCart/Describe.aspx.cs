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

public partial class Describe : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string P_str_GoodsID=Request["GoodsID"];
        DataSet ds = DB.reDs("select * from tb_GoodsInfo where GoodsID=" + P_str_GoodsID);
        txtGoodsName.Text = ds.Tables[0].Rows[0][1].ToString();
        txtKind.Text = ds.Tables[0].Rows[0][2].ToString();
        imgGoodsPhoto.ImageUrl = ds.Tables[0].Rows[0][3].ToString();
        txtGoodsPrice.Text = ds.Tables[0].Rows[0][4].ToString();
        txtGoodsDesc.Text = ds.Tables[0].Rows[0][5].ToString();
    }
    //关闭窗口
    protected void btnClose_Click(object sender, EventArgs e)
    {
        Response.Write("<script>window.close();</script>");
    }
}

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

public partial class SuccessShop : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds = DB.reDs("select Money from tb_User where UserID=" + Session["UserID"].ToString());
        string P_str_Money = ds.Tables[0].Rows[0][0].ToString() ;
        labMessage.Text = "您已经成功购买了购物车中的商品，当前余额为" + P_str_Money + "￥";
    }
}

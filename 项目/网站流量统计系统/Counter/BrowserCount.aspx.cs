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

public partial class BrowserCount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //浏览器统计
            DataSet ds = DB.reDs("SELECT COUNT(*) AS count, Browser FROM tb_CounterInfo GROUP BY Browser");
            DataList1.DataSource = ds;
            DataList1.DataBind();
            this.labBrowser.Text = Total().ToString();
        }
    }
    //使用浏览器统计
    public int Total()
    {
        DataSet ds = DB.reDs("select count(*) from tb_CounterInfo");
        int P_Int_total = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
        return P_Int_total;
    }
    //所占百分比
    public float Percent(string P_str_count)
    {
        float P_Fl_percent = 0;
        if (Total() != 0)
        {
            P_Fl_percent = Convert.ToSingle(P_str_count) / Convert.ToSingle(Total());
        }
        return P_Fl_percent;
    }
}

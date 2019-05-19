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

public partial class MasterPage : System.Web.UI.MasterPage
{
    string mValue = "";
    public string MValue
    {
        get
        {
            return mValue;
        }
        set
        {
            mValue = value;
        }

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        this.labMaster.Text = "今天是"+DateTime.Today.Year+"年"+DateTime.Today.Month+"月"+DateTime .Today.Day+"日";
    }
}

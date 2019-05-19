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

public partial class DayCount : System.Web.UI.Page
{
    string M_Str_mindate = DateTime.Now.ToShortDateString() + " 0:00:00";
    string M_Str_maxdate = DateTime.Now.AddDays(1).ToShortDateString() + " 0:00:00";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int[] P_Int_hour = new int[24];
            for (int i = 0; i < 24; i++)
            {
                P_Int_hour[i] = i;
            }
            DataList1.DataSource = P_Int_hour;
            DataList1.DataBind();
            labDay.Text = DateTime.Now.ToShortDateString();//当日日期
            this.labTotal.Text = Total().ToString();//本日累计
        }
    }
    //访问人数统计
    public int Total()
    {
        DataSet ds = DB.reDs("select * from tb_CounterInfo where LoginTime>='" + M_Str_mindate + "'and LoginTime<'" + M_Str_maxdate + "'");
        int P_Int_total = ds.Tables[0].Rows.Count;//访问人数统计
        return P_Int_total;
    }

    public string Time(int i)
    {
        string P_Str_time="";
        if (i < 24 & i >= 0)
        {
            P_Str_time = i.ToString() + ":00--" + Convert.ToString(i + 1) + ":00";
        }
        return P_Str_time;
    }
    //各时间段的统计人数
    public int Count(int i)
    {
        int P_Int_count = 0;
        DataSet ds = DB.reDs("select COUNT(*) AS count, DATEPART(hh, LoginTime) AS hour from tb_CounterInfo where LoginTime>='" + M_Str_mindate + "'and LoginTime<'" + M_Str_maxdate + "' and DATEPART(hh,LoginTime)="+i+" GROUP BY DATEPART(hh, LoginTime)");
        if(ds.Tables[0].Rows.Count !=0)    
            P_Int_count =Convert .ToInt32 (ds.Tables [0].Rows [0]["count"]);
        
        return P_Int_count;
    }
    //所占百分比
    public float Percent(int i)
    {
        float P_Fl_percent = 0;
        if (Total() != 0)
        {
            P_Fl_percent = Convert.ToSingle(Count(i)) / Convert.ToSingle(Total()); 
        }
        return P_Fl_percent;
    }
}

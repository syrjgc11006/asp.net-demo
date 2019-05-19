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

public partial class Default : System.Web.UI.Page
{
    string M_Str_mindate;//用于存储最小日期
    string M_Str_maxdate;//用于存储最大日期
    protected void Page_Load(object sender, EventArgs e)
    {
        //显示统计时间
        labCountDate.Text = DateTime.Now.ToString();
        //本日访问人数的计算
        M_Str_mindate = DateTime.Now.ToShortDateString() + " 0:00:00";
        M_Str_maxdate = DateTime.Now.AddDays(1).ToShortDateString() + " 0:00:00";
        DataSet ds = DB.reDs("select * from tb_CounterInfo where LoginTime>='" + M_Str_mindate + "'and LoginTime<'" + M_Str_maxdate + "'");
        labCountDay.Text = ds.Tables[0].Rows.Count.ToString();

        //本周访问人数
        switch (DateTime.Now.DayOfWeek)
        {
            case DayOfWeek .Monday :
                M_Str_mindate = DateTime.Now.AddDays (0).ToShortDateString() + " 0:00:00";
                M_Str_maxdate = DateTime.Now.AddDays(6).ToShortDateString() + " 0:00:00";
                break;
            case DayOfWeek.Tuesday:
                M_Str_mindate = DateTime.Now.AddDays(-1).ToShortDateString() + " 0:00:00";
                M_Str_maxdate = DateTime.Now.AddDays(5).ToShortDateString() + " 0:00:00";
                break;
            case DayOfWeek.Wednesday:
                M_Str_mindate = DateTime.Now.AddDays(-2).ToShortDateString() + " 0:00:00";
                M_Str_maxdate = DateTime.Now.AddDays(4).ToShortDateString() + " 0:00:00";
                break;
            case DayOfWeek.Thursday:
                M_Str_mindate = DateTime.Now.AddDays(-3).ToShortDateString() + " 0:00:00";
                M_Str_maxdate = DateTime.Now.AddDays(3).ToShortDateString() + " 0:00:00";
                break;
            case DayOfWeek.Friday:
                M_Str_mindate = DateTime.Now.AddDays(-4).ToShortDateString() + " 0:00:00";
                M_Str_maxdate = DateTime.Now.AddDays(2).ToShortDateString() + " 0:00:00";
                break;
            case DayOfWeek.Saturday:
                M_Str_mindate = DateTime.Now.AddDays(-5).ToShortDateString() + " 0:00:00";
                M_Str_maxdate = DateTime.Now.AddDays(1).ToShortDateString() + " 0:00:00";
                break;
            case DayOfWeek.Sunday:
                M_Str_mindate = DateTime.Now.AddDays(-6).ToShortDateString() + " 0:00:00";
                M_Str_maxdate = DateTime.Now.AddDays(0).ToShortDateString() + " 0:00:00";
                break;
        }
        ds = DB.reDs("select * from tb_CounterInfo where LoginTime>='" + M_Str_mindate + "'and LoginTime<'" + M_Str_maxdate + "'");
        labCountWeek.Text = ds.Tables[0].Rows.Count.ToString();
        //本月访问人数
        ds = DB.reDs("select * from tb_CounterInfo where Year(LoginTime)="+DateTime .Now.Year+" and Month(LoginTime)=" + DateTime.Now.Month.ToString());
        this.labCountMonth.Text = ds.Tables[0].Rows.Count.ToString();
        //最高日访问量
        ds = DB.reDs("SELECT COUNT(*) AS count, MAX(LoginTime) AS date FROM tb_CounterInfo GROUP BY YEAR(LoginTime), MONTH(LoginTime), DAY(LoginTime)");
        int P_Int_max = 0;//最大值
        string P_Str_date = "";
        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            if (!dr.IsNull(0))
            {
                if (P_Int_max <= Convert.ToInt32(dr[0]))
                {
                    P_Int_max = Convert.ToInt32(dr[0]);
                    P_Str_date = Convert.ToDateTime(dr[1]).ToShortDateString();
                }
            }
        }
        labMaxCountDay.Text = P_Int_max.ToString ();
        //最高日访问日期
        DateTime P_Date_date=Convert.ToDateTime (P_Str_date);
        labMaxCountDayDate.Text = P_Date_date.Year + "年" + P_Date_date.Month + "月" + P_Date_date.Day + "日";
        //最高月访问量
        P_Int_max = 0;//最大值
        P_Str_date = "";
        ds=DB.reDs ("SELECT YEAR(LoginTime) FROM tb_CounterInfo GROUP BY YEAR(LoginTime)");
        foreach (DataRow drYear in ds.Tables[0].Rows)
        {
            drYear[0].ToString();
            DataSet dsMonth = DB.reDs("SELECT COUNT(*) as count, MAX(Month(LoginTime)) as month FROM tb_CounterInfo where YEAR(LoginTime)=" + drYear[0].ToString() + " GROUP BY Month(LoginTime)");
            foreach (DataRow drMonth in dsMonth.Tables[0].Rows)
            {
                if (!drMonth.IsNull(0))
                {
                    if (P_Int_max <=Convert.ToInt32(drMonth[0]))
                    {
                        P_Int_max = Convert.ToInt32(drMonth[0]);
                        P_Str_date =drYear[0].ToString() + "年" + drMonth[1].ToString() + "月";
                    }
                }
            }
        }
        labMaxCountMonth.Text = P_Int_max.ToString();
        //最高月访问日期
        labMaxCountMonthDate.Text = P_Str_date;

        //最高年访问量
        ds = DB.reDs("SELECT COUNT(*), MAX(Year(LoginTime)) FROM tb_CounterInfo GROUP BY Year(LoginTime)");
        P_Int_max = 0;//最大值
        P_Str_date = "";
        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            if (!dr.IsNull(0))
            {
                if (P_Int_max <= Convert.ToInt32(dr[0]))
                {
                    P_Int_max = Convert.ToInt32(dr[0]);
                    P_Str_date = dr[1].ToString() + "年";
                }
            }
        }
        labMaxCountYear.Text = P_Int_max.ToString();
        //最高年访问日期
        labMaxCountYearDate.Text = P_Str_date;
        //常用浏览器
        ds = DB.reDs("SELECT COUNT(*) AS count, Browser FROM tb_CounterInfo GROUP BY Browser");
       P_Int_max = 0;//最大值
        string P_Str_Browser = "";
        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            if (!dr.IsNull(0))
            {
                if (P_Int_max <= Convert.ToInt32(dr[0]))
                {
                    P_Int_max = Convert.ToInt32(dr[0]);
                    P_Str_Browser = dr[1].ToString();
                }
            }
        }
        this.labBrowser.Text = P_Str_Browser;
        //常用操作系统
         ds = DB.reDs("SELECT COUNT(*) AS count, OS FROM tb_CounterInfo GROUP BY OS");
         P_Int_max = 0;//最大值
         string P_Str_OS = "";
         foreach (DataRow dr in ds.Tables[0].Rows)
         {
             if (!dr.IsNull(0))
             {
                 if (P_Int_max <= Convert.ToInt32(dr[0]))
                 {
                     P_Int_max = Convert.ToInt32(dr[0]);
                     P_Str_OS = dr[1].ToString();
                 }
             }
         }
         this.labOS.Text = P_Str_OS;
        //总访问人数
         ds = DB.reDs("select count(*) from tb_CounterInfo");
         this.labTotalCount.Text = ds.Tables[0].Rows[0][0].ToString();
    }
}

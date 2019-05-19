using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

/// <summary>
/// ChineseClardent 的摘要说明
/// </summary>
public class ChineseClardent
{
	public ChineseClardent()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    System.Globalization.ChineseLunisolarCalendar calendar = new System.Globalization.ChineseLunisolarCalendar();
    //int GetYear (DateTime time) 获取指定公历日期的农历年份，使用的还是公历纪元。
    public string GetYear(DateTime time)
    {
        StringBuilder sb = new StringBuilder();
        int year = calendar.GetYear(time);
        int d;
        do
        {
            d = year % 10;
            sb.Insert(0, ChineseNumber[d]);
            year = year / 10;
        } while (year > 0);
        return sb.ToString();
    }
    // int GetMonth (DateTime time)获取指定公历日期的农历月份
    public string GetMonth(DateTime time)
    {
        int month = calendar.GetMonth(time);
        int year = calendar.GetYear(time);
        int leap = 0;
        //正月不可能闰月
        for (int i = 3; i <= month; i++)
        {
            if (calendar.IsLeapMonth(year, i))
            {
                leap = i;
                break;  //一年中最多有一个闰月
            }
        }
        if (leap > 0) month--;
        return (leap == month + 1 ? "闰" : "") + ChineseMonthName[month - 1];
    }
    //int GetDayOfMonth (DateTime time) 获取指定公历日期的农历天数，这个值根据大月或者小月取值是1到30或者1到29, 
    public string GetDay(DateTime time)
    {
        return ChineseDayName[calendar.GetDayOfMonth(time) - 1];
    }
    //int GetSexagenaryYear (DateTime time) 获取指定公历日期的农历年份的干支纪年
    //int GetSexagenaryYear (DateTime time) 获取指定公历日期的农历年份的干支纪年，从1到60，分别是甲子、乙丑、丙寅、….癸亥, 比如戊戌变法、辛亥革命就是按这个来命名的。当然算八字也少不了这个。
    //nt GetTerrestrialBranch (int sexagenaryYear) ) 获取一个干支的地支，, 从1到12, 表示子、丑、寅、…今年是狗年，
    public string GetStemBranch(DateTime time)
    {
        int sexagenaryYear = calendar.GetSexagenaryYear(time);
        string stemBranch = CelestialStem.Substring(calendar.GetCelestialStem(sexagenaryYear) - 1, 1) + TerrestrialBranch.Substring(calendar.GetTerrestrialBranch(sexagenaryYear) - 1, 1);
        return stemBranch;
    }
    public string getReturnYear(DateTime time)
    {
        int sexagenaryYear = calendar.GetSexagenaryYear(time);
        string Tree = TreeYear.Substring(calendar.GetTerrestrialBranch(sexagenaryYear) - 1, 1);
        return Tree;
    }
    private static string ChineseNumber = "〇一二三四五六七八九";
    public const string CelestialStem = "甲乙丙丁戊己庚辛壬癸";
    public const string TreeYear = "鼠牛虎兔龙蛇马羊猴鸡狗猪";
    public const string TerrestrialBranch = "子丑寅卯辰巳午未申酉戌亥";
    public static readonly string[] ChineseDayName = new string[] {
            "初一","初二","初三","初四","初五","初六","初七","初八","初九","初十",
            "十一","十二","十三","十四","十五","十六","十七","十八","十九","二十",
            "廿一","廿二","廿三","廿四","廿五","廿六","廿七","廿八","廿九","三十"};
    public static readonly string[] ChineseMonthName = new string[] { "正", "二", "三", "四", "五", "六", "七", "八", "九", "十", "十一", "十二" };


    /*
三、农历类的使用 
既然.net框架不支持直接将日期转换成农历格式的字符串，那么要将显示农历格式的日期，就只要自已写代码了。不过由于已经有了ChineseLunisolarCalendar类实现了公历转换为农历日期的功能，所以要写这样的代码也比较简单。需要用到ChineseLunisolarCalendar以下几个主要方法：
int GetYear (DateTime time) 获取指定公历日期的农历年份，使用的还是公历纪元。在每年的元旦之后春节之前农历的纪年会比公历小1,其它时候等于公历纪年。虽然农历使用传说中的耶稣生日纪元似乎不太妥当，不过我们确实已经几十年没有实行一个更好的纪年办法，也只有将就了。
int GetMonth (DateTime time) 获取指定公历日期的农历月份。这里要注意了，由于农历有接近三分之一的年份存在闰月，则在这些年份里会有十三个，而具体哪一个月是闰月也说不准，这里不同于希伯来历。以今年为例，今年闰七月，则此方法在参数为闰七月的日期是返回值为8，参数为农历十二月的日期时返回值为13
bool IsLeapMonth ( int year,   int month) 获取指定农历年份和月份是否为闰月，这个函数和上个函数配合使用就可以算出农历的月份了。
int GetDayOfMonth (DateTime time) 获取指定公历日期的农历天数，这个值根据大月或者小月取值是1到30或者1到29, MSDN上说的1到31显然是错的, 没有哪个农历月份会有31天。
int GetSexagenaryYear (DateTime time) 获取指定公历日期的农历年份的干支纪年，从1到60，分别是甲子、乙丑、丙寅、….癸亥, 比如戊戌变法、辛亥革命就是按这个来命名的。当然算八字也少不了这个。
int GetCelestialStem (int sexagenaryYear) 获取一个天支的天干, 从1到10, 表示甲、乙、丙….，说白了就是对10取模。
int GetTerrestrialBranch (int sexagenaryYear) ) 获取一个干支的地支，, 从1到12, 表示子、丑、寅、…今年是狗年，那么今年年份的地支就是“戌”。
有了这几个方法，显示某天的农历月份日期、农历节日等都是小菜一碟，算命先生排八字用这几个方法，又快又准确，写出的代码也很短。



     */
}

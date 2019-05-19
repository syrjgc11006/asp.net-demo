using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Service : System.Web.Services.WebService
{
    public Service () {

        //如果使用设计的组件，请取消注释以下行 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }
    [WebMethod(Description = "万年历，输入一个公历日期，返回一个农历日期")]
    public string ChineseLunisolarCalendar(string datatime)
    {
        DateTime dt = Convert.ToDateTime(datatime);
        ChineseClardent clarden = new ChineseClardent();
        string year = clarden.GetYear(dt);
        string month = clarden.GetMonth(dt);
        string day = clarden.GetDay(dt);
        string stemBranch = clarden.GetStemBranch(dt);
        string returnYear = clarden.getReturnYear(dt);
        return "公元"+year+"年" + month+"月" + day + stemBranch + returnYear+"年";
    }
}

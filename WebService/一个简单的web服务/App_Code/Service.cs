using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data.SqlClient;

[WebService(Namespace = "http://contoso.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Service : System.Web.Services.WebService
{
    public Service()
    {

        //如果使用设计的组件，请取消注释以下行 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }
    
    [WebMethod(Description = "第一个测试方法，输入学生姓名，返回学生信息")]
    public string Select(string stuName)
    {
        //以Windows的方式进行登录的
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=F:\\实践小组\\WEB编程\\ASP.NET\\WEBSERVICE\\一个简单的WEB服务\\APP_DATA\\DB_18.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True");
        conn.Open();

        SqlCommand cmd = new SqlCommand("select * from tb_StuInfo where stuName='" + stuName + "'", conn);
        SqlDataReader dr = cmd.ExecuteReader();

        string txtMessage = "";

        if (dr.Read())
        {
            txtMessage = "学生编号：" + dr["stuID"] + "  ,";
            txtMessage += "姓名：" + dr["stuName"] + "  ,";
            txtMessage += "性别：" + dr["stuSex"] + "  ,";
            txtMessage += "爱好：" + dr["stuHobby"] + "  ,";
        }
        else
        {
            if (String.IsNullOrEmpty(stuName))
            {
                txtMessage = "<Font Color='Blue'>请输入姓名</Font>";
            }
            else
            {
                txtMessage = "<Font Color='Red'>查无此人！</Font>";
            }
        }

        cmd.Dispose();
        dr.Dispose();
        conn.Dispose();
        return txtMessage;  //返回用户详细信息

    }

}


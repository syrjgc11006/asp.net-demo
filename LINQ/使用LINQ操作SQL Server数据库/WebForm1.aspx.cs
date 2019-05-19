using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;


namespace 使用LINQ操作SQL_Server数据库
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LinqDBDataContext lqDB = new LinqDBDataContext(ConfigurationManager.ConnectionStrings["db_StudentConnectionString"].ConnectionString.ToString());
            var result = from v in lqDB.tb_Class
                         where v.classID > 0
                         select v;
            GridView1.DataSource = result;
            GridView1.DataBind();
        }
    }
}

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

namespace from子句用法
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Linq操作数组对象           
            int [] values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            var result = from v in values
                         where v % 2 == 0
                         select v;
            Response.Write("查询结果：<br>");
            foreach(var t in result)
            {
                Response.Write(t.ToString() + "<br>");
            }
        }
    }
}

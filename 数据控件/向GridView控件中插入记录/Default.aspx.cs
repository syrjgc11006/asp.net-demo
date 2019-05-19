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

namespace 向GridView控件中插入记录
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //这里我们检查了GridViewCommandEventArgs的CommandName是否是“Insert”。 如果我们设置了GridView的DataSourceID属性为空，然后调用GridView的DataBind()方法的话， 那么GridView将不会有任何数据，从而显示Empty Data Template。
       
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Insert")
            {
                GridView1.DataSourceID = "";
                GridView1.DataBind();
            }

        }
        //这里我们再次设置了GridView的DataSourceID属性为SqlDataSource1，然后再次绑定它。 这样GridView就可以显示出最新插入的记录。
        protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
        {
            GridView1.DataSourceID = "SqlDataSource1";
            GridView1.DataBind();
        }
    }
}

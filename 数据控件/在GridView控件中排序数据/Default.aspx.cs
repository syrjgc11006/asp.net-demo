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
using System.Data;
using System.Data.SqlClient;

namespace 在GridView控件中排序数据
{
    public partial class _Default : System.Web.UI.Page
    {
        //用视图状态保存默认的排序表达式和排序顺序
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //在页面间存储变量的状态，类似于哈希表的键值对用法
                ViewState["SortOrder"] = "stuID";
                ViewState["OrderDire"] = "ASC";
                GridViewBind();
            }
        }
        /// <summary>
        /// 设置数据视图的sort属性，最后把该视图和GridView控件进行绑定
        /// </summary>
        public void GridViewBind()
        {
            //绑定数据源
            string sqlStr = "select * from tb_StuInfo";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\C#资料\\ASP.NET\\[ASP.NET从入门到精通].MR\\SL\\10\\DATABASE\\DB_STUDENT.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True";//连接本地计算机
            SqlDataAdapter da = new SqlDataAdapter(sqlStr, con);
            //实例化数据集
            DataSet ds = new DataSet();
            //填充数据集
            da.Fill(ds);
            //获取数据集的默认视图
            DataView dv = ds.Tables[0].DefaultView;
            string sort = (string)ViewState["SortOrder"] + " " + (string)ViewState["OrderDire"];
            //将排序表达式赋给
            dv.Sort = sort;
            //绑定DataList控件
            GridView1.DataSource = dv;//设置数据源，用于填充控件中的项的值列表
            GridView1.DataBind();//将控件及其所有子控件绑定到指定的数据源
        }
        /// <summary>
        /// 在控件进行排序时发生
        /// 首先获得指定的表达式，然后判断是否是当前的排序方式，如果是则改变当前的排序方式；如果不是则设置新的排序表达式，并重新进行数据绑定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {
            string sPage = e.SortExpression;//获取排序表达式
            if (ViewState["SortOrder"].ToString() == sPage)
            {
                //获取排序方式
                if (ViewState["OrderDire"].ToString() == "Desc")
                {
                    ViewState["OrderDire"]="ASC";
                }
                else
                {
                    ViewState["OrderDire"]="Desc";
                }
            }
            //对数据进行重新绑定
            GridViewBind();
        }
    }
}

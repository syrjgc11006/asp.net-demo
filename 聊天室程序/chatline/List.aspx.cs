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

namespace chatline
{
    public partial class List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //声明一个数组对象
            ArrayList ItemList = new ArrayList();
            Application.Lock();
            string p_str_names;     //已经在线的用户名
            string[] p_str_user;    //用户在线数组
            //在线用户的数量
            int p_int_num = Convert.ToInt32(Application["userNum"]);
            //获取已经在线的用户名
            p_str_names = Application["user"].ToString();
            p_str_user = p_str_names.Split(',');

            //从刚进入聊天室的用户开始遍历
            for (int i = (p_int_num - 1); i >= 0; i--)
            {
                //如果在线用户名为空
                if (p_str_user[i].ToString() != "")
                {
                    ItemList.Add(p_str_user[i].ToString());
                }
            }
            
            //说明列表数据来自于动态数组
            lbList.DataSource = ItemList;
            //将数据源绑定到列表控件中
            lbList.DataBind();
            Application.UnLock();
        }
    }
}

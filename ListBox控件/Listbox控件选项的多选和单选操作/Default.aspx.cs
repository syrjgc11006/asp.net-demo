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

namespace Listbox控件选项的多选和单选操作
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //定义一个数组来给列表框赋值
            ArrayList arrList = new ArrayList();
            arrList.Add("星期日");
            arrList.Add("星期一");
            arrList.Add("星期二");
            arrList.Add("星期三");
            arrList.Add("星期四");
            arrList.Add("星期五");
            arrList.Add("星期六");
            // if (!IsPostBack)表示，如果IspostBack(回传，多次加载)为假
            //如果页面首次加载，如果不是则每次按一下其他按钮同样会使得页面被加载一次
            if (!IsPostBack)
            {
                lbxSource.DataSource = arrList;
                lbxSource.DataBind();
            }
           
        }

        protected void btnChooseAll_Click(object sender, EventArgs e)
        {
            //获取列表框的选项数
            int count = lbxSource.Items.Count;
            //循环从源列表中转移到目的列表框中
            int index = 0;
            for (int i = 0; i < count; i++)
            {
                ListItem Item = lbxSource.Items[index];
                lbxSource.Items.Remove(Item);//将源列表框中的数据项移除
                lbxDest.Items.Add(Item);//将源列表框中的数据项添加到目标列表框中 
            }
            //获取下一个索引值,每查找到一个选项就对全部选项遍历一次,这里的下一个索引值加1
            index++;
        }

        protected void btnDeleteAll_Click(object sender, EventArgs e)
        {

            //获取列表框的选项数
            int count = lbxDest.Items.Count;
            //循环从源列表中转移到目的列表框中
            int index = 0;
            for (int i = 0; i < count; i++)
            {
                ListItem Item = lbxDest.Items[index];
                lbxDest.Items.Remove(Item);//将源列表框中的数据项移除
                lbxSource.Items.Add(Item);//将源列表框中的数据项添加到目标列表框中
            }
            //获取下一个索引值
            index++;
        }

        //实现单选功能
        protected void btnSelectSingle_Click(object sender, EventArgs e)
        {
            //获取列表的选项数
            int count = lbxSource.Items.Count;
            int index = 0;
            //循环判断各个项的选中状态
            for (int i = 0; i < count; i++)
            {
                ListItem Item = lbxSource.Items[index];
                //如果选项为选中状态，则从源列表框中删除并添加到目标列表框中
                if (lbxSource.Items[index].Selected == true)
                {
                    lbxSource.Items.Remove(Item);
                    lbxDest.Items.Add(Item);
                    //既然已经移除了一个选项，就应该将index的值减少一个
                    index--;
                }
                //获取下一个选项的索引值
                index++;
            }
        }

        protected void btnDeleteSingle_Click(object sender, EventArgs e)
        {
            //获取列表的选项数
            int count = lbxDest.Items.Count;
            int index = 0;
            //循环判断各个项的选中状态
            for (int i = 0; i < count; i++)
            {
                ListItem Item = lbxDest.Items[index];
                //如果选项为选中状态，则从源列表框中删除并添加到目标列表框中
                if (lbxDest.Items[index].Selected == true)
                {
                    lbxDest.Items.Remove(Item);
                    lbxSource.Items.Add(Item);
                    //index--;
                }
                //获取下一个选项的索引值
                index++;
            }
        }
    }
}

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

namespace ListBox控件选项按钮的上移和下移操作
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList arrList = new ArrayList();
            arrList.Add("星期日");
            arrList.Add("星期一");
            arrList.Add("星期二");
            arrList.Add("星期三");
            arrList.Add("星期四");
            arrList.Add("星期五");
            arrList.Add("星期六");

            //页面首次加载
            if (!IsPostBack)
            {
                //将数组作为数据源绑定到listbox控件当中
                lbxSource.DataSource = arrList;
                lbxSource.DataBind();
            }
        }

        //上移
        protected void Button1_Click(object sender, EventArgs e)
        {
            //若不是第1行则上移
            if (lbxSource.SelectedIndex > 0 && lbxSource.SelectedIndex <= lbxSource.Items.Count - 1)
            {
                //记录当前选项的值
                string name = lbxSource.SelectedItem.Text;
                string value = lbxSource.SelectedItem.Value;

                //获取当前选项的索引号
                int index = lbxSource.SelectedIndex;

                //交换当前选项和其前一项的索引号
                lbxSource.SelectedItem.Text = lbxSource.Items[index - 1].Text;
                lbxSource.SelectedItem.Value = lbxSource.Items[index - 1].Value;

                lbxSource.Items[index - 1].Text = name;
                lbxSource.Items[index - 1].Value = value;

                //设定上一项为当前选项
                lbxSource.SelectedIndex--;
            }
        }

        //下移
        protected void Button2_Click(object sender, EventArgs e)
        {
            //若不是第最后一行则下移
            if (lbxSource.SelectedIndex < lbxSource.Items.Count - 1 && lbxSource.SelectedIndex >=0)
            {

                //记录当前选项的值
                string name = lbxSource.SelectedItem.Text;
                string value = lbxSource.SelectedItem.Value;

                //获取当前选项的索引号
                int index = lbxSource.SelectedIndex;

                //交换当前选项和其前一项的索引号
                lbxSource.SelectedItem.Text = lbxSource.Items[index + 1].Text;
                lbxSource.SelectedItem.Value = lbxSource.Items[index + 1].Value;

                lbxSource.Items[index + 1].Text = name;
                lbxSource.Items[index + 1].Value = value;

                //设定上一项为当前选项
                lbxSource.SelectedIndex++;
            }
        }

        //循环上移
        protected void Button3_Click(object sender, EventArgs e)
        {
            //若不是第一行则上移
            if (lbxSource.SelectedIndex > 0 && lbxSource.SelectedIndex < lbxSource.Items.Count)
            {
                string name = lbxSource.SelectedItem.Text;
                string value = lbxSource.SelectedItem.Value;
                //获取当前选项的索引号
                int index = lbxSource.SelectedIndex;
                //交换当前选项的索引号
                lbxSource.SelectedItem.Text = lbxSource.Items[index - 1].Text;
                lbxSource.SelectedItem.Value = lbxSource.Items[index - 1].Value;
                lbxSource.Items[index - 1].Text = name;
                lbxSource.Items[index - 1].Value = value;

                //设定上一项为当期选项
                lbxSource.SelectedIndex--;
            }
            //若是第一行被选择，则循环移到最后一行
            else if (lbxSource.SelectedIndex == 0)
            {
                ListItem Item = lbxSource.Items[0];
                lbxSource.Items.Remove(Item);
                lbxSource.Items.Add(Item);
            }
        }
        //循环下移
        protected void Button4_Click(object sender, EventArgs e)
        {
            //若不是第最后一行则下移
            if (lbxSource.SelectedIndex < lbxSource.Items.Count - 1 && lbxSource.SelectedIndex >= 0)
            {

                //记录当前选项的值
                string name = lbxSource.SelectedItem.Text;
                string value = lbxSource.SelectedItem.Value;

                //获取当前选项的索引号
                int index = lbxSource.SelectedIndex;

                //交换当前选项和其前一项的索引号
                lbxSource.SelectedItem.Text = lbxSource.Items[index + 1].Text;
                lbxSource.SelectedItem.Value = lbxSource.Items[index + 1].Value;

                lbxSource.Items[index + 1].Text = name;
                lbxSource.Items[index + 1].Value = value;

                //设定上一项为当前选项
                lbxSource.SelectedIndex++;
            }
            else if (lbxSource.SelectedIndex == (lbxSource.Items.Count - 1))
            {
                ListItem Item = lbxSource.Items[lbxSource.Items.Count - 1];
                lbxSource.Items.Remove(Item);
                lbxSource.Items.Insert(0, Item);
            }
        }
    }
}

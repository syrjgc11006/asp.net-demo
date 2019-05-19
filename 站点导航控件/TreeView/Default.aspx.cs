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

namespace TreeView
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDataBase();
                TreeView1.ShowLines = true;//显示连接父节点与子节点之间的线条
            }
        }


        //绑定数据库
        public void BindDataBase()
        {
            //实例化SqlConnection对象
            SqlConnection sqlcon = new SqlConnection();
            //实例化SqlConnection对象连接数据库的字符串
            sqlcon.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\C#资料\\ASP.NET\\[ASP.NET从入门到精通].MR\\SL\\10\\DATABASE\\DB_STUDENT.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True";
            //定义SQL语句
            string strcon = "select * from tb_StuInfo";
            //定义一个适配器对象
            SqlDataAdapter da = new SqlDataAdapter(strcon,sqlcon);
            //实例化一个数据集
            DataSet ds = new DataSet();
            da.Fill(ds);

            //动态添加TreeView跟节点和子节点
            //设置TreeView的根节点
            TreeNode tree1 = new TreeNode("学生信息");
            //增加根节点
            TreeView1.Nodes.Add(tree1);
            //在根节点底下添加父节点
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                //获取数据集中第2列的所有数据
                //每一个节点都包含着两个信息，文本和值
                TreeNode tree2 = new TreeNode(ds.Tables[0].Rows[i][1].ToString(), ds.Tables[0].Rows[i][1].ToString());
                //在根目录下添加父节点
                tree1.ChildNodes.Add(tree2);
                //在父节点中添加叶子节点
                for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                {
                    TreeNode tree3 = new TreeNode(ds.Tables[0].Rows[i][j].ToString(), ds.Tables[0].Rows[i][j].ToString());
                    tree2.ChildNodes.Add(tree3);
                }
            }
        }
    }
}

using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class manage_govEdit : System.Web.UI.Page
{
    CommonClass CC = new CommonClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //调用CommonClass类中的GetDataSet获取数据集
            DataSet ds = CC.GetDataSet("select * from tb_News where id='" + Request.QueryString["id"] + "'", "tbNews");
            DataRow[] row = ds.Tables["tbNews"].Select();
            foreach (DataRow rs in row)
            {
                //显示编辑的新闻类别名
                this.txtNewsTitle.Text = rs["title"].ToString();
                //显示编辑的新闻内容
                this.txtNewsContent.Text = rs["content"].ToString();
                //显示编辑的新闻标题
                this.labTitle.Text = rs["Style"].ToString();
                //显示编辑的新闻类型
                switch (rs["type"].ToString())
                {
                    case "国内新闻":
                        this.ddlNewsType.SelectedIndex =1;
                        break;
                    case "国际新闻":
                        this.ddlNewsType.SelectedIndex =0;
                        break;
                    default:
                        break;
                }
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        CC.ExecSQL("UPDATE tb_News SET Title = '"+this.txtNewsTitle.Text+"', Content = '"+this.txtNewsContent.Text+"', Style = '"+this.labTitle.Text.Trim()+"', Type = '"+this.ddlNewsType.SelectedValue.ToString()+"' WHERE (ID = '"+Request.QueryString["id"]+"')");
        Response.Write(CC.MessageBox("数据修改成功！","list.aspx"));
    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        this.txtNewsTitle.Text = "";
        this.txtNewsContent.Text = "";
    }
}

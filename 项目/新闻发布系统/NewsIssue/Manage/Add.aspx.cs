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

public partial class manage_fzAdd : System.Web.UI.Page
{
    CommonClass CC = new CommonClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        //使用Request对象获取页面传递的值
        //使用switch语句，获取添加的新闻类别名
        switch (Convert.ToInt32(Request["id"].ToString()))
        {
            case 1:
                this.labTitle.Text = "时政要闻";
                break;
            case 2:
                this.labTitle.Text = "经济动向";
                break;
            case 3:
                this.labTitle.Text = "世界军事";
                break;
            case 4:
                this.labTitle.Text = "科学教育";
                break;
            case 5:
                this.labTitle.Text = "法治道德";
                break;
            case 6:
                this.labTitle.Text = "社会现象";
                break;
            case 7:
                this.labTitle.Text = "体育世界";
                break;
            case 8:
                this.labTitle.Text = "时尚娱乐";
                break;
            default:
                this.labTitle.Text = "";
                break;
        }
       
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //调用CommonClass类的ExecSQL方法，将填写的新闻信息添加到数据库中
        CC.ExecSQL("INSERT INTO tb_News( Title, Content, Style, Type, IssueDate)VALUES ('" + this.txtNewsTitle.Text.Trim() + "', '" + this.txtNewsContent.Text.Trim() + "', '" + this.labTitle.Text.Trim()+ "', '" + this.ddlNewsType.SelectedValue.ToString() + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
        //调用CommonClass类的MessageBox方法，弹出提示框，提示用户添加成功
        Response.Write(CC.MessageBox("添加成功！"));
    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        this.txtNewsContent.Text = "";
        this.txtNewsTitle.Text = "";
    }
    
}

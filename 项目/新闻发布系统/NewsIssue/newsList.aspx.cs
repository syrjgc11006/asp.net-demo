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

public partial class newsList : System.Web.UI.Page
{
    CommonClass CC = new CommonClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        bind();
    }
    string strStyle;
    protected void bind()
    {  
        int n = Convert.ToInt32(Request.QueryString["id"]);
        switch (n)
        {
            case 1: strStyle = "时政要闻";
                this.labTitle.Text = "新闻网络中心－＞时政要闻";
                this.imageLag.ImageUrl = "~/Images/图片时政要闻.jpg";
                this.imageTitle.ImageUrl = "~/Images/二级页时政要闻.jpg";
                break;
            case 2: strStyle = "经济动向";
                this.labTitle.Text = "新闻网络中心－＞经济动向";
                this.imageLag.ImageUrl = "~/Images/经济动向图片.jpg";
                this.imageTitle.ImageUrl = "~/Images/二级页经济动向.jpg";
                break;
            case 3: strStyle = "世界军事";
                this.labTitle.Text = "新闻网络中心－＞世界军事";
                this.imageLag.ImageUrl = "~/Images/世界军事图片.jpg";
                this.imageTitle.ImageUrl = "~/Images/二级页世界军事.jpg";
                break;
            case 4: strStyle = "科学教育";
                this.labTitle.Text = "新闻网络中心－＞科学教育";
                this.imageLag.ImageUrl = "~/Images/图片科学教育.jpg";
                this.imageTitle.ImageUrl = "~/Images/二级页科学教育.jpg";
                break;
            case 5: strStyle = "法治道德";
                this.labTitle.Text = "新闻网络中心－＞法治道德";
                this.imageLag.ImageUrl = "~/Images/法制道德图片.jpg";
                this.imageTitle.ImageUrl = "~/Images/二级页法制道德.jpg";
                break;
            case 6: strStyle = "社会现象";
                this.labTitle.Text = "新闻网络中心－＞社会现象";
                this.imageLag.ImageUrl = "~/Images/社会现象图片.jpg";
                this.imageTitle.ImageUrl = "~/Images/二级页社会现象.jpg";
                break;
            case 7: strStyle = "体育世界";
                this.labTitle.Text = "新闻网络中心－＞体育世界";
                this.imageLag.ImageUrl = "~/Images/体育世界图片.jpg";
                this.imageTitle.ImageUrl = "~/Images/二级页体育世界.jpg";
                break;
            case 8: strStyle = "时尚娱乐";
                this.labTitle.Text = "新闻网络中心－＞时尚娱乐";
                this.imageLag.ImageUrl = "~/Images/时尚娱乐图片.jpg";
                this.imageTitle.ImageUrl = "~/Images/二级页时尚娱乐.jpg";
                break;
        }
        //取得当前页的页码
        int curpage = Convert.ToInt32(this.labPage.Text);
        //使用PagedDataSource类实现DataList控件的分页功能
        PagedDataSource ps = new PagedDataSource();
        //获取数据集
        DataSet ds = CC.GetDataSet("select * from tb_News where style='" + strStyle + "' order by  issueDate Desc", "tbNews");
        ps.DataSource = ds.Tables["tbNews"].DefaultView;
        //是否可以分页
        ps.AllowPaging = true;
        //显示的数量
        ps.PageSize =16; 
        //取得当前页的页码
        ps.CurrentPageIndex = curpage - 1;
        this.lnkbtnUp.Enabled = true;
        this.lnkbtnNext.Enabled = true;
        this.lnkbtnBack.Enabled = true;
        this.lnkbtnOne.Enabled = true;
        if (curpage == 1)
        {
            //不显示第一页按钮
            this.lnkbtnOne.Enabled = false;
            //不显示上一页按钮
            this.lnkbtnUp.Enabled = false;
        }
        if (curpage == ps.PageCount)
        {
            //不显示下一页
            this.lnkbtnNext.Enabled = false;
            //不显示最后一页
            this.lnkbtnBack.Enabled = false;
        }
        //显示分页数量
        this.labBackPage.Text = Convert.ToString(ps.PageCount);
        //绑定DataList控件
        this.dlNews.DataSource = ps;
        this.dlNews.DataKeyField = "id";
        this.dlNews.DataBind();
    
    }
   //第一页
    protected void lnkbtnOne_Click(object sender, EventArgs e)
    {
        this.labPage.Text = "1";
        this.bind();
    }
    //上一页
    protected void lnkbtnUp_Click(object sender, EventArgs e)
    {
        this.labPage.Text = Convert.ToString(Convert.ToInt32(this.labPage.Text) - 1);
        this.bind();
    }
    //下一页
    protected void lnkbtnNext_Click(object sender, EventArgs e)
    {
        this.labPage.Text = Convert.ToString(Convert.ToInt32(this.labPage.Text) + 1);
        this.bind();
    }
    //最后一页
    protected void lnkbtnBack_Click(object sender, EventArgs e)
    {
        this.labPage.Text = this.labBackPage.Text;
        this.bind();
    }
    protected void dlNews_ItemCommand(object source, DataListCommandEventArgs e)
    {
        int id = Convert.ToInt32(dlNews.DataKeys[e.Item.ItemIndex].ToString());
        Response.Write("<script language=javascript>window.open('showNews.aspx?id=" + id + "','','width=520,height=260')</script>");
    }

}

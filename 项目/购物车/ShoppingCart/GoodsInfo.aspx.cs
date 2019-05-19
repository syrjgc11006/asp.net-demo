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

public partial class GoodsInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["UserID"] == null)
            {
                Response.Write("<script>alert('请先登录！');</script>");
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                if (Session["UserID"].ToString() != "1")
                {
                    Response.Write("<script>alert('您还没有此权限！');</script>");
                    Response.Redirect("~/Default.aspx");
                }
            }
        }

    }
    //显示商品图片
    protected void btnShow_Click(object sender, EventArgs e)
    {
        string P_str_name = this.fulPhoto.FileName;//获取上载文件的名称
        bool P_bool_fileOK = false;
        if (fulPhoto.HasFile)
        {
            String fileExtension =System.IO.Path.GetExtension(fulPhoto.FileName).ToLower();
            String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg", ".bmp" };
            for (int i = 0; i < allowedExtensions.Length; i++)
            {
                if (fileExtension == allowedExtensions[i])
                {
                    P_bool_fileOK = true;
                }
            }
        }
        if (P_bool_fileOK)
        {
            this.fulPhoto.PostedFile.SaveAs(Server.MapPath("~/Image/") + P_str_name);//将文件保存在相应的路径下
            this.imgGoodsPhoto.ImageUrl = "~/Image/" + P_str_name;//将图片显示在Image控件上
        }
        else
        {
            Response.Write("<script>alert('请选择.gif,.png,.jpeg,.jpg,.bmp格式的图片文件!');</script>");
        }
    }
    protected void btnInsert_Click(object sender, EventArgs e)
    {
        if (imgGoodsPhoto.ImageUrl != "")
        {
            labMessage.Visible = false;
            bool P_Bool_reVal = DB.ExSql("insert into tb_GoodsInfo values('" + txtGoodsName.Text + "','" + txtKind.Text + "','" + imgGoodsPhoto.ImageUrl + "','" + txtGoodsPrice.Text + "','" + txtGoodsDesc.Text + "')");
            if (!P_Bool_reVal)
            {
                Response.Write("<script>alert('操作失败，请重试！');</script>");
            }
            else
            {
                txtGoodsName.Text = "";
                txtKind.Text = "";
                txtGoodsPrice.Text = "0";
                txtGoodsDesc.Text = "";
                imgGoodsPhoto.ImageUrl = "";
            }
        }
        else
        {
            labMessage.Visible = true;
        }
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx");
    }
}

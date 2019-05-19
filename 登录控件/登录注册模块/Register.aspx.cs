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
using System.Data.SqlClient;

public partial class Register : System.Web.UI.Page
{
    UserManage usermanage = new UserManage();
    ImageManage imagemanage = new ImageManage();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlPhoto.DataSource = imagemanage.GetAllPhoto("tb_Image").Tables[0].DefaultView;
            ddlPhoto.DataTextField = "编号";
            ddlPhoto.DataBind();
            imagemanage.PhotoID = ddlPhoto.SelectedValue;
            imgPhoto.ImageUrl = imagemanage.FindPhotoByID(imagemanage, "tb_Image").Tables[0].Rows[0][1].ToString();
        }
    }
    protected void btnTest_Click(object sender, EventArgs e)
    {
        if (txtName.Text == string.Empty)
        {
            Response.Write("<script language=javascript>alert('用户名不能为空！')</script>");
        }
        else
        {
            usermanage.UserName = txtName.Text;
            DataSet ds = usermanage.FindUserByName(usermanage, "tb_User");
            if (ds.Tables[0].Rows.Count > 0)
            {
                Response.Write("<script language=javascript>alert('该用户已经存在！')</script>");
                txtName.Text = string.Empty;
                txtName.Focus();
            }
            else
                Response.Write("<script language=javascript>alert('您可以使用该用户名进行注册！')</script>");
        }
    }
    protected void btnSelDate_Click(object sender, EventArgs e)
    {
        calDate.Visible = true;
    }
    protected void calDate_SelectionChanged(object sender, EventArgs e)
    {
        txtBirthday.Text = calDate.SelectedDate.ToShortDateString();
        calDate.Visible = false;
    }
    protected void btnReg_Click(object sender, EventArgs e)
    {
        if (txtName.Text == string.Empty)
        {
            Response.Write("<script language=javascript>alert('用户名不能为空！')</script>");
        }
        else
        {
            usermanage.UserName = txtName.Text;
            DataSet ds = usermanage.FindUserByName(usermanage, "tb_User");
            if (ds.Tables[0].Rows.Count > 0)
            {
                Response.Write("<script language=javascript>alert('该用户已经存在！')</script>");
                txtName.Text = string.Empty;
                txtName.Focus();
            }
            else
            {
                usermanage.UserPwd = txtPwd.Text;
                usermanage.TName = txtTName.Text;
                if (ddlSex.SelectedIndex == 0)
                    usermanage.Sex = true;
                if (ddlSex.SelectedIndex == 1)
                    usermanage.Sex = false;
                usermanage.Birthday = DateTime.Parse(txtBirthday.Text);
                usermanage.Tel = txtTel.Text;
                usermanage.Mobile = txtMobile.Text;
                if (txtQQ.Text == string.Empty)
                {
                    usermanage.QQ =0;
                }
                else
                {
                    usermanage.QQ = Int32.Parse(txtQQ.Text);
                }
               
                imagemanage.PhotoID = ddlPhoto.SelectedValue;
                usermanage.Photo = imagemanage.FindPhotoByID(imagemanage, "tb_Image").Tables[0].Rows[0][1].ToString();
                usermanage.Email = txtEmail.Text;
                usermanage.FAddress = txtHAddress.Text;
                usermanage.RAddress = txtRAddress.Text;
                usermanage.Index = txtIndex.Text;
                usermanage.AddUser(usermanage);
                Response.Write("<script language=javascript>alert('用户注册成功！')</script>");
               
            }
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    protected void ddlPhoto_SelectedIndexChanged(object sender, EventArgs e)
    {
        imagemanage.PhotoID = ddlPhoto.SelectedValue;
        imgPhoto.ImageUrl = imagemanage.FindPhotoByID(imagemanage, "tb_Image").Tables[0].Rows[0][1].ToString();

    }
}

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

public partial class Manger_MemberAdd : System.Web.UI.Page
{
    CommonClass CC = new CommonClass();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtName.Text = "";
        txtPass.Text = "";
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (txtName.Text == "")
        {
            Response.Write(CC.MessageBox("请输入管理员名！", "MemberAdd.aspx"));
        }
        else
        {
            int IntUserIn = CC.checkLogin(this.txtName.Text.Trim(), this.txtPass.Text.Trim());
            if (IntUserIn > 0)
            {
                Response.Write(CC.MessageBox("该管理员名已存在！", "MemberAdd.aspx"));
            }
            else
            {
                CC.ExecSQL("INSERT INTO tb_User( Name, PassWord) VALUES ('" + this.txtName.Text.Trim() + "', '" + this.txtPass.Text.Trim() + "')");
              
                Response.Write(CC.MessageBox("添加成功！", "MemberAdd.aspx"));
            }
        }
    }
}

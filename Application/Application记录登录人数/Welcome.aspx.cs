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

public partial class Welcome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("欢迎用户"+Session["UserName"].ToString ()+"登录本系统!<br>");
        char[] c=Application["count"].ToString ().ToCharArray ();
        Image []img=new Image [c.Length];
        Label lab1 = new Label();
        lab1.Text = "您是本网站第";
        this.form1.Controls .Add (lab1);
        for (int i = 0; i < c.Length; i++)
        {
            img[i] = new Image();
            img[i].ImageUrl = "~/Image/" + c[i].ToString () + ".jpg";
            this.form1.Controls.Add(img[i]);
        }
        Label lab2 = new Label();
        lab2.Text = "位登录的用户！";
        this.form1.Controls.Add(lab2);
    }
}

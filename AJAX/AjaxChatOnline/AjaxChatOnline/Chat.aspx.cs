﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Chat : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] == "" || Session["User"] == null)
            Response.Redirect("Login.aspx");
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["User"] = "";
        Session.Abandon();
        Response.Redirect("Login.aspx");
    }
}

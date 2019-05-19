using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_HomeWork
{
    public partial class Danxuan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            switch (RadioButtonList1.SelectedItem.Value)
            {
                case "0":
                    Label2.Text = "你选择了：A";
                    break;
                case "1":
                    Label2.Text = "你选择了：B";
                    break;
                case "2":
                    Label2.Text = "你选择了：C";
                    break;
                case "3":
                    Label2.Text = "你选择了：D";
                    break;

            }
        }
    }
}
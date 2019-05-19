using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Web.Services.Description;


public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSelect_Click(object sender, EventArgs e)
    {
        //声明Web服务的实例
        localhost.Service service = new localhost.Service();
        //调用Web服务的Select方法
        string strMessage = service.Select(TextBox1.Text);
        string[] strMessages = strMessage.Split(new Char[] { ',' });
       // string[] message = strMessage.Split(',');
        labMessage.Text = "详细信息：</br>";
        foreach (string str in strMessages)
        {
            labMessage.Text += str + "</br>";
        }
    }
}

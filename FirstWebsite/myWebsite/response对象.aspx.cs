using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.IO;

namespace myWebsite
{
    public partial class response对象 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            char c = 'a';               //定义一个字符变量
            string s = "Hello World!";  //定义一个字符串变量
            char []cArrry={'H','E','I'};//定义一个字符数组
            Page p = new Page();        //定义一个page对象
            Response.Write("输出单个字符");
            Response.Write(c);
            Response.Write("<br>");
            Response.Write("输出一个字符串"+s+"<br>");
            Response.Write("输出字符数组");
            Response.Write(cArrry,0,cArrry.Length);
            Response.Write("<br>");
            Response.Write("输出一个对象");
            Response.Write(p);
            Response.Write("<br>");
            Response.Write("输出一个文件");
            Response.WriteFile(@"f:\联通.txt");
        }

        //重定向
        protected void btnOK_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string sex = "先生";
            if (rtbSexWoman.Checked)
            {
                sex = "女士";
            }
            //Response.Redirect("外部链接的html代码/20.html?");
            //Response.Redirect("~/外部链接的html代码/20.html?");
            Response.Redirect("~/welcom.aspx?Name="+name+"&Sex="+sex);

        }

        protected void btnImage_Click(object sender, EventArgs e)
        {
            //打开图片文件，并存在文件流中
            FileStream stream = new FileStream(Server.MapPath(@"App_Themes\图片\IMG_20130505_125447.gif"), FileMode.Open);
            //获取图片流的长度
            long FileSize =stream.Length;
            //定义一个二进制数组
            byte[] Buffer = new byte[(int)FileSize];
            //从流中读取字节块并将该数据写入给定缓冲区中
            stream.Read(Buffer, 0, (int)FileSize);
            //关闭流
            stream.Close();
            //将图片输出在页面上
            Response.BinaryWrite(Buffer);
        }

    }
}

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

namespace 使用FileUpload控件上传图片
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            bool fileIsValid = false;
            //如果确认了上传文件，则判断文件类型是否符合要求
            if (FileUpload1.HasFile)//如果控件中已经包含了文件
            {
                //获取上传文件的后缀
                string fileExtension = Path.GetExtension(FileUpload1.FileName).ToLower();
                //设置服务器上传路径
                string path = Server.MapPath("~/images/");
                string[] restrictExtension = { ".gif", ".jpg", ".bmp", ".png" };
                //判断文件类型是否符合要求
                for (int i = 0; i < restrictExtension.Length; i++)
                {
                    if (fileExtension == restrictExtension[i])
                    {
                        fileIsValid = true;
                    }
                }
                //如果文件类型符合要求，调用SaveAs方法实现上传，并显示相关信息
                if (fileIsValid == true)
                {
                    try
                    {
                        Image1.ImageUrl = "~/images/" + FileUpload1.FileName;
                        FileUpload1.SaveAs(path + FileUpload1.FileName);
                        Label1.Text = "文件上传成功！";
                        Label1.Text += "<br/>";
                        Label1.Text += "<li>" + "原文件路径：" + FileUpload1.PostedFile.FileName;
                        Label1.Text += "<br/>";
                        Label1.Text += "<li>" + "文件大小：" + FileUpload1.PostedFile.ContentLength + "字节";
                        this.Label1.Text += "<Br/>";
                        this.Label1.Text += "<li>" + "文件类型：" + this.FileUpload1.PostedFile.ContentType;
                    }
                    catch (Exception)
                    {

                        this.Label1.Text = "文件上传不成功！";
                    }
                }
                else
                {
                    this.Label1.Text = "只能够上传后缀为.gif,.jpg,.bmp,.png的文件夹";
                }
            }
        }
    }
}

using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Drawing;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Bitmap bitmap = new Bitmap(800, 600);
        Graphics graphics = Graphics.FromImage(bitmap);
        graphics.Clear(Color.White);//清空背景
        SolidBrush mySolidBrush = new SolidBrush(Color.Yellow);
        graphics.FillEllipse(mySolidBrush, 70, 20, 100, 50);
        System.IO.MemoryStream ms = new System.IO.MemoryStream();
        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
        Response.ClearContent();
        Response.ContentType = "image/Gif";
        Response.BinaryWrite(ms.ToArray());
    }
}

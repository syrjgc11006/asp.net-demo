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
        Bitmap bit = new Bitmap(360, 260);
        Graphics g = Graphics.FromImage(bit);
        g.Clear(Color.White);
        Pen pen = new Pen(Color.Blue, 2);
        Rectangle[] rects ={ new Rectangle(10, 10, 100, 200), new Rectangle(100, 200, 250, 50), new Rectangle(100, 50, 150, 150) };
        g.DrawEllipse (pen, rects[0]);
        pen.Color = Color.Red;
        g.DrawArc(pen, rects[1], -60, 180);
        pen.Color = Color.Turquoise;
        g.DrawPie(pen, rects[2], 60, -120);
        System.IO.MemoryStream ms = new System.IO.MemoryStream();
        bit.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        Response.ClearContent();
        Response.ContentType = "image/Jpeg";
        Response.BinaryWrite(ms.ToArray());
    }
}

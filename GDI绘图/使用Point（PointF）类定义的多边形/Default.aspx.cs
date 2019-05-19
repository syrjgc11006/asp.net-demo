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
        Bitmap bit = new Bitmap(240, 200);
        Graphics g = Graphics.FromImage(bit);
        g.Clear(Color.White);
        Pen pen = new Pen(Color.Blue, 2);
        Point[] pts = new Point[]{  new Point( 10, 120 ),
                                   new Point( 120, 100),
                                   new Point( 180,120),
                                   new Point( 240, 200),
                                   new Point( 60, 200)};
        g.DrawPolygon(pen, pts);
        System.IO.MemoryStream ms = new System.IO.MemoryStream();
        bit.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        Response.ClearContent();
        Response.ContentType = "image/Jpeg";
        Response.BinaryWrite(ms.ToArray());
    }
}

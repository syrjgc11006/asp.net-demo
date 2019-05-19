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
        Bitmap bit = new Bitmap(260, 120);
        Graphics g = Graphics.FromImage(bit);
        g.Clear(Color.White);
        
        Pen pen = new Pen(Color.Black, 3);
        Point[] points = { new Point(10, 10), new Point(10, 100), new Point(200, 50), new Point(260, 120) };
        g.DrawLines(pen, points);   
        
        System.IO.MemoryStream ms = new System.IO.MemoryStream();
        bit.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        Response.ClearContent();
        Response.ContentType = "image/Jpeg";
        Response.BinaryWrite(ms.ToArray());
    }
}

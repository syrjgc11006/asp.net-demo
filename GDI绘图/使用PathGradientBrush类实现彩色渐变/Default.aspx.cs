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
using System.Drawing.Drawing2D;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Bitmap bit = new Bitmap(400, 200);
        Graphics g = Graphics.FromImage(bit);
        g.Clear(Color.White);
        Point centerPoint = new Point(100, 100);
        int R = 100;
        GraphicsPath path = new GraphicsPath();
        path.AddEllipse(centerPoint.X - R, centerPoint.Y - R, 2 * R, 2 * R);
        PathGradientBrush myPathGradientBrush = new PathGradientBrush(path);
        //指定路径中心点
        myPathGradientBrush.CenterPoint = centerPoint;
        //指定路径中心点的颜色
        myPathGradientBrush.CenterColor = Color.DarkGreen;
        //Color类型的数组指定与路径上每个顶点对应的颜色
        myPathGradientBrush.SurroundColors = new Color[] { Color.Gold };
        g.FillEllipse(myPathGradientBrush, centerPoint.X - R, centerPoint.Y - R, 2 * R, 2 * R);

        centerPoint = new Point(300, 100);
        R = 33;
        path = new GraphicsPath();
        path.AddEllipse(centerPoint.X - R, centerPoint.Y - R, 2 * R, 2 * R);
        path.AddEllipse(centerPoint.X - 2 * R, centerPoint.Y - 2 * R,
                       4 * R, 4 * R);
        path.AddEllipse(centerPoint.X - 3 * R, centerPoint.Y - 3 * R,
                       6 * R, 6 * R);
        myPathGradientBrush = new PathGradientBrush(path);
        myPathGradientBrush.CenterPoint = centerPoint;
        myPathGradientBrush.CenterColor = Color.Gold;
        myPathGradientBrush.SurroundColors = new
                     Color[] { Color.Black, Color.Blue, Color.DarkGreen };
        g.FillPath(myPathGradientBrush, path);

        System.IO.MemoryStream ms = new System.IO.MemoryStream();
        bit.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        Response.ClearContent();
        Response.ContentType = "image/Jpeg";
        Response.BinaryWrite(ms.ToArray());

    }
}

using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Drawing ;
using System.Drawing .Drawing2D ;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Bitmap bitmap = new Bitmap(200, 100);
        Graphics graphics = Graphics.FromImage(bitmap);
        graphics.Clear(Color.White);//清空背景
        HatchBrush myhatchBrush = new HatchBrush(HatchStyle.BackwardDiagonal, Color.Green,Color .Orange);
        graphics.FillEllipse(myhatchBrush, 0, 0, 200, 100);
        System.IO.MemoryStream ms = new System.IO.MemoryStream();
        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg );
        Response.ClearContent();
        Response.ContentType = "image/Jpeg";
        Response.BinaryWrite(ms.ToArray());
    }
}

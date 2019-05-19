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
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        this.CreateImage();
    }
    private void CreateImage()
    {
        int height = 440, width = 600;
        Bitmap image = new Bitmap(width, height);
        Graphics g = Graphics.FromImage(image);

        try
        {
            //清空图片背景色
            g.Clear(Color.White);

            Font font = new System.Drawing.Font("Arial", 9, FontStyle.Regular);
            Font font1 = new System.Drawing.Font("宋体", 20, FontStyle.Regular);
            Font font2 = new System.Drawing.Font("Arial", 8, FontStyle.Regular);
            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Blue, Color.Blue, 1.2f, true);
            g.FillRectangle(Brushes.AliceBlue, 0, 0, width, height);
            Brush brush1 = new SolidBrush(Color.Blue);
            Brush brush2 = new SolidBrush(Color.SaddleBrown);

            g.DrawString("1997年-2006年出生人口的男女比例", font1, brush1, new PointF(100, 30));
            //画图片的边框线
            g.DrawRectangle(new Pen(Color.Blue), 0, 0, image.Width - 1, image.Height - 1);

            Pen mypen = new Pen(brush, 1);
            Pen mypen2 = new Pen(Color.Red, 2);
            //绘制线条
            //绘制纵向线条
            int x = 60;
            for (int i = 0; i < 10; i++)
            {
                g.DrawLine(mypen, x, 80, x, 340);
                x = x + 50;
            }
            Pen mypen1 = new Pen(Color.Blue, 2);
            g.DrawLine(mypen1, x - 500, 80, x - 500, 340);

            //绘制横向线条
            int y = 106;
            for (int i = 0; i < 9; i++)
            {
                g.DrawLine(mypen, 60, y, 560, y);
                y = y + 26;
            }
            g.DrawLine(mypen1, 60, y, 560, y);

            //x轴
            String[] n = {"1997年", "1998年", "1999年", "2000年", "2001年", "2002年",
                     "2003年", "  2004年", "2005年", "2006年"};
            x = 45;
            for (int i = 0; i < 10; i++)
            {
                g.DrawString(n[i].ToString(), font, Brushes.Red, x, 348); //设置文字内容及输出位置
                x = x + 50;
            }

            //y轴
            String[] m = {"2200人", " 2000人", " 1800人", "1600人", " 1400人", " 1200人", " 1000人", " 800人",
                     " 600人"};
            y = 106;
            for (int i = 0; i < 9; i++)
            {
                g.DrawString(m[i].ToString(), font, Brushes.Red, 10, y); //设置文字内容及输出位置
                y = y + 26;
            }

            int[] Count1 = new int[10];
            int[] Count2 = new int[10];
            SqlConnection Con = new SqlConnection(ConfigurationManager.AppSettings["ConSql"]);
            Con.Open();
            string cmdtxt2 = "SELECT * FROM tb_11 WHERE Year<=2006 and Year>=1997";
            SqlDataAdapter da = new SqlDataAdapter(cmdtxt2 ,Con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            for (int j = 0; j < 10; j++)
            {
                if (ds.Tables[0].Rows.Count == 0)
                {
                    Count1[j] = 0;
                }
                else
                {
                    Count1[j] = Convert.ToInt32(ds.Tables [0].Rows [j][0].ToString ()) * 13 / 100;
                }
            }
            for (int k = 0; k < 10; k++)
            {
                if (ds.Tables[0].Rows.Count == 0)
                {
                    Count2[k] = 0;
                }
                else
                {
                    Count2[k] = Convert.ToInt32(ds.Tables[0].Rows[k][1].ToString()) * 13 / 100;
                }
            }

            //显示折线效果
            SolidBrush mybrush = new SolidBrush(Color.Red);
            Point[] points1 = new Point[10];
            points1[0].X = 60; points1[0].Y = 390 - Count1[0];
            points1[1].X = 110; points1[1].Y = 390 - Count1[1];
            points1[2].X = 160; points1[2].Y = 390 - Count1[2];
            points1[3].X = 210; points1[3].Y = 390 - Count1[3];
            points1[4].X = 260; points1[4].Y = 390 - Count1[4];
            points1[5].X = 310; points1[5].Y = 390 - Count1[5];
            points1[6].X = 360; points1[6].Y = 390 - Count1[6];
            points1[7].X = 410; points1[7].Y = 390 - Count1[7];
            points1[8].X = 460; points1[8].Y = 390 - Count1[8];
            points1[9].X = 510; points1[9].Y = 390 - Count1[9];
            g.DrawLines(mypen2, points1);  //绘制折线

            Pen mypen3 = new Pen(Color.Black, 2);
            Point[] points2 = new Point[10];
            points2[0].X = 60; points2[0].Y = 390 - Count2[0];
            points2[1].X = 110; points2[1].Y = 390 - Count2[1];
            points2[2].X = 160; points2[2].Y = 390 - Count2[2];
            points2[3].X = 210; points2[3].Y = 390 - Count2[3];
            points2[4].X = 260; points2[4].Y = 390 - Count2[4];
            points2[5].X = 310; points2[5].Y = 390 - Count2[5];
            points2[6].X = 360; points2[6].Y = 390 - Count2[6];
            points2[7].X = 410; points2[7].Y = 390 - Count2[7];
            points2[8].X = 460; points2[8].Y = 390 - Count2[8];
            points2[9].X = 510; points2[9].Y = 390 - Count2[9];
            g.DrawLines(mypen3, points2);  //绘制折线

            //绘制标识
            g.DrawRectangle(new Pen(Brushes.Red), 150, 370, 250, 50);  //绘制范围框
            g.FillRectangle(Brushes.Red, 250, 380, 20, 10);  //绘制小矩形
            g.DrawString("女孩", font2, Brushes.Red, 270, 380);
            g.FillRectangle(Brushes.Black, 250, 400, 20, 10);
            g.DrawString("男孩", font2, Brushes.Black, 270, 400);

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            Response.ClearContent();
            Response.ContentType = "image/Jpeg";
            Response.BinaryWrite(ms.ToArray());
        }
        finally
        {
            g.Dispose();
            image.Dispose();
        }
    }
}

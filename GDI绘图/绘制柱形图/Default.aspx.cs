using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.CreateImage();
    }

    //访问人数统计
    public int Total()
    {
        SqlConnection Con = new SqlConnection(ConfigurationManager.AppSettings["ConSql"]);
        Con.Open();
        string cmdtxt1 = "select * from tb_10 where Year(LoginTime)=2007";
        SqlDataAdapter dap = new SqlDataAdapter(cmdtxt1, Con);
        DataSet ds = new DataSet();
        dap.Fill(ds);
        int P_Int_total = ds.Tables[0].Rows.Count;//访问人数统计
        return P_Int_total;
    }
    private void CreateImage()
    {
        int height = 400, width = 600;
        Bitmap image = new Bitmap(width, height);
        //创建Graphics类对象
        Graphics g = Graphics.FromImage(image);

        try
        {
            //清空图片背景色
            g.Clear(Color.White);

            Font font = new Font("Arial", 9, FontStyle.Regular);
            Font font1 = new Font("宋体", 20, FontStyle.Bold);

            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Blue , Color.BlueViolet, 1.2f, true);
            g.FillRectangle(Brushes.WhiteSmoke, 0, 0, width, height);
           // Brush brush1 = new SolidBrush(Color.Blue);

            g.DrawString("2007年各月份网站流量统计", font1, brush, new PointF(130, 30));
            //画图片的边框线
            g.DrawRectangle(new Pen(Color.Blue), 0, 0, image.Width - 1, image.Height - 1);

            Pen mypen = new Pen(brush, 1);
            //绘制线条
            //绘制横向线条
            int x = 100;
            for (int i = 0; i < 11; i++)
            {
                g.DrawLine(mypen, x, 80, x, 340);
                x = x + 40;
            }
            Pen mypen1 = new Pen(Color.Blue, 2);
            g.DrawLine(mypen1, x - 480, 80, x - 480, 340);

            //绘制纵向线条
            int y = 106;
            for (int i = 0; i < 9; i++)
            {
                g.DrawLine(mypen, 60, y, 540, y);
                y = y + 26;
            }
            g.DrawLine(mypen1, 60, y, 540, y);

            //x轴
            String[] n = {"  一月", "  二月", "  三月", "  四月", "  五月", "  六月", "  七月",
                     "  八月", "  九月", "  十月", "十一月", "十二月"};
            x = 62;
            for (int i = 0; i < 12; i++)
            {
                g.DrawString(n[i].ToString(), font, Brushes.Black , x, 348); //设置文字内容及输出位置
                x = x + 40;
            }

            //y轴
            String[] m = {"100%", " 90%", " 80%", " 70%", " 60%", " 50%", " 40%", " 30%",
                     " 20%", " 10%", "  0%"};
            y = 85;
            for (int i = 0; i < 11; i++)
            {
                g.DrawString(m[i].ToString(), font, Brushes.Black, 25, y); //设置文字内容及输出位置
                y = y + 26;
            }

            int[] Count = new int[12];
            string cmdtxt2 = "";
            SqlConnection Con = new SqlConnection(ConfigurationManager.AppSettings["ConSql"]);
            Con.Open();
            SqlDataAdapter da;
            DataSet ds=new DataSet();
            for (int i = 0; i < 12; i++)
            {
                cmdtxt2 = "select COUNT(*) AS count, Month( LoginTime) AS month from tb_10 where Year(LoginTime)=2007 and Month(LoginTime)=" + (i + 1) + "Group By Month(LoginTime)";
                da = new SqlDataAdapter(cmdtxt2, Con);
                da.Fill(ds,i.ToString ());
                if (ds.Tables[i].Rows.Count == 0)
                {
                    Count[i] = 0;
                }
                else
                {
                    Count[i] = Convert.ToInt32(ds.Tables[i].Rows[0][0].ToString()) * 100 / Total();
                }
            }
            //显示柱状效果
            x = 70;
            for (int i = 0; i < 12; i++)
            {
                SolidBrush mybrush = new SolidBrush(Color.Blue);
                g.FillRectangle(mybrush, x, 340 - Count[i] * 26 / 10, 20, Count[i] * 26 / 10);
                x = x + 40;
            }

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

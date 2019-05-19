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
using System.Drawing ;
using System.Drawing.Drawing2D ;
using System.Collections;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CreateImage();
    }
    private void CreateImage()
    {
        //把连接字串指定为一个常量
        SqlConnection Con = new SqlConnection("Server=.\\SQLEXPRESS;Database=db_A;Uid=sa;Pwd=sa");
        Con.Open();
        string cmdtxt = "select *  from tb_12";
        //SqlCommand Com = new SqlCommand(cmdtxt, Con);
        DataSet ds = new DataSet();
        SqlDataAdapter Da = new SqlDataAdapter(cmdtxt, Con);
        Da.Fill(ds);
        Con.Close();
        float Total = 0.0f, Tmp;

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            //转换成单精度。也可写成Convert.ToInt32
            Tmp = Convert.ToSingle(ds.Tables[0].Rows[i]["Quantity"]);
            Total += Tmp;
        }

        //设置字体，fonttitle为主标题的字体
        Font fontlegend = new Font("verdana", 9);
        Font fonttitle = new Font("verdana", 10, FontStyle.Bold);

        //背景宽
        int width = 230;
        int bufferspace = 15;
        int legendheight = fontlegend.Height * (ds.Tables[0].Rows.Count + 1) + bufferspace;
        int titleheight = fonttitle.Height + bufferspace;
        int height = width + legendheight + titleheight + bufferspace;//白色背景高
        int pieheight = width;
        Rectangle pierect = new Rectangle(0, titleheight, width, pieheight);

        //加上各种随机色
        ArrayList colors = new ArrayList();
        Random rnd = new Random();
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            colors.Add(new SolidBrush(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255))));

        //创建一个bitmap实例
        Bitmap objbitmap = new Bitmap(width, height);
        Graphics objgraphics = Graphics.FromImage(objbitmap);

        //画一个白色背景
        objgraphics.FillRectangle(new SolidBrush(Color.White), 0, 0, width, height);

        //画一个亮黄色背景      
        objgraphics.FillRectangle(new SolidBrush(Color.Beige), pierect);

        //以下为画饼图(有几行row画几个)
        float currentdegree = 0.0f;
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            objgraphics.FillPie((SolidBrush)colors[i], pierect, currentdegree,
              Convert.ToSingle(ds.Tables[0].Rows[i]["Quantity"]) / Total * 360);
            currentdegree += Convert.ToSingle(ds.Tables[0].Rows[i]["Quantity"]) / Total * 360;
        }
        //以下为生成主标题
        SolidBrush blackbrush = new SolidBrush(Color.Black);
        string title = " 各类图书销售比例调查";
        StringFormat stringFormat = new StringFormat();
        stringFormat.Alignment = StringAlignment.Center;
        stringFormat.LineAlignment = StringAlignment.Center;

        objgraphics.DrawString(title, fonttitle, blackbrush,
            new Rectangle(0, 0, width, titleheight), stringFormat);
        //列出各字段与得数目
        objgraphics.DrawRectangle(new Pen(Color.Black, 2), 0, height - legendheight, width, legendheight);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            objgraphics.FillRectangle((SolidBrush)colors[i], 5, height - legendheight + fontlegend.Height * i + 5, 10, 10);
            objgraphics.DrawString(((String)ds.Tables[0].Rows[i]["BookKind"]) + " —— " + Convert.ToString(Convert.ToSingle(ds.Tables[0].Rows[i]["Quantity"]) * 100 / Total).Substring(0, 5) + "%", fontlegend, blackbrush,
         20, height - legendheight + fontlegend.Height * i + 1);
        }
        //图像总的高度-一行字体的高度，即是最底行的一行字体高度(height - fontlegend.Height )
        objgraphics.DrawString("图书销售总数:" + Convert.ToString(Total) + "万本", fontlegend, blackbrush, 5, height - fontlegend.Height);
        Response.ContentType = "image/Jpeg";
        objbitmap.Save(Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);
        objgraphics.Dispose();
        objbitmap.Dispose();
    }
}

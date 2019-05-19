using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Drawing;//引入绘图的命名空间
using System.IO;

public partial class ResultImage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string P_Str_voteID = Request["voteID"];
        string P_Str_title = Server.UrlDecode (Request["title"]);
        img(P_Str_voteID, P_Str_title);
    }
    public void img(string P_Str_voteID, string P_Str_title)
    {
        #region
        DataSet myds1 = DB.reDs("select *  from tb_VoteItem where voteID=" + P_Str_voteID);
        //计算总票数
        DataSet myds2 = DB.reDs("select sum(voteTotal) as total FROM tb_VoteItem where voteID=" + P_Str_voteID);
        int P_Int_sum = Convert.ToInt32(myds2.Tables[0].Rows[0][0].ToString());

        //获取该投票主题的选项个数
        int P_Int_ItemCount = myds1.Tables[0].Rows.Count;
        //存储每个选项的投票名称
        string[] P_Str_voteContent = new string[P_Int_ItemCount];
        //存储每个选项的投票数
        string[] P_Str_voteTotal = new string[P_Int_ItemCount];
        int P_Int_val = 0;//变量,用于设置数组的下标
        foreach (DataRow dr in myds1.Tables[0].Rows)
        {
            //获取每个选项的投票名称
            P_Str_voteContent[P_Int_val] = dr[2].ToString();
            //获取每个选项的投票数
            P_Str_voteTotal[P_Int_val] = dr[3].ToString();
            P_Int_val++;
        }
        Bitmap bitmap = new Bitmap(600, 800);
        Graphics graphics = Graphics.FromImage(bitmap);
        try
        {
            graphics.Clear(Color.White);
            Pen pen1 = new Pen(Color.Red);
            Brush[] brush = new Brush[P_Int_ItemCount + 1];
            Brush brush1 = new SolidBrush(Color.White);
            for (int i = 0; i < P_Int_ItemCount; i++)
            {
                int red = RandomNum(i);
                int green =RandomNum(i + 100);
                int blue = RandomNum(i + 500);
                brush[i] = new SolidBrush(Color.FromArgb(red, green, blue));
            }
            Font font1 = new Font("Courier New", 16, FontStyle.Bold);
            Font font2 = new Font("Courier New", 8);
            graphics.FillRectangle(brush1, 0, 0, 370, 350);    //绘制背景
            graphics.DrawString(P_Str_title + "投票比例分析", font1, brush[1], new Point(60, 20));  //书写标题
            //保存各投票项在圆中分配的角度
            float[] P_Fl_angle = new float[P_Int_ItemCount];
            for (int i = 0; i < P_Int_ItemCount; i++)
            {
                //获取各投票项在圆中所占角度
                P_Fl_angle[i] = Convert.ToSingle((360 * (Convert.ToSingle(P_Str_voteTotal[i]) / Convert.ToSingle(P_Int_sum))));
            }
            float P_Int_angle = 0;
            for (int i = 0; i < P_Int_ItemCount; i++)
            {

                graphics.FillPie(brush[i], 100, 60, 180, 180, P_Int_angle, P_Fl_angle[i]);//绘制各投票项所占比例
                P_Int_angle += P_Fl_angle[i];
            }
            //绘制标识
            //graphics.DrawRectangle(pen1, 50, 255, 260, 50 + P_Int_ItemCount * 10);  //绘制范围框

            for (int i = 0; i < P_Int_ItemCount; i++)
            {
                graphics.FillRectangle(brush[i], 85, 265 + i * 20, 20, 10);  //绘制小矩形
                graphics.DrawString(P_Str_voteContent[i] + Convert.ToString(Convert.ToSingle(P_Str_voteTotal[i]) * 100 / Convert.ToSingle(P_Int_sum)) + "%", font2, brush[i], 120, 265 + i * 20);
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex.Message + "');<script>");
        }
        MemoryStream ms = new MemoryStream();
        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
        Response.ClearContent();
        Response.ContentType = "image/Gif";
        Response.BinaryWrite(ms.ToArray());
        graphics.Dispose();
        #endregion
    }
    //产生0-255之间的随机数
    public int RandomNum(int i)
    {
        Random rnd = new Random(i*unchecked((int)DateTime.Now.Ticks));//初始化一个Random实例
        int rndNum = rnd.Next(255);//返回小于255的非负随机数
        return rndNum;
    }
    
}

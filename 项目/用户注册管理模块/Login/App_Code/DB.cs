using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;//数据库操作需引入的命名空间
using System.Security.Cryptography;//MD5加密需引入的命名空间

/// <summary>
/// DB 的摘要说明
/// </summary>
public class DB
{
	public DB()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}

    /// <summary>
    /// 连接数据库
    /// </summary>
    /// <returns>返回SqlConnection对象</returns>
    public SqlConnection GetCon()
    {
        return new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"].ToString());
    }

    /// <summary>
    /// 执行SQL语句
    /// </summary>
    ///<param name="cmdstr">SQL语句</param>
    /// <returns>返回值为int型：成功返1，失败返回0</returns>
    public int sqlEx(string cmdstr)
    {
        SqlConnection con = GetCon();//连接数据库
        con.Open();//打开连接
        SqlCommand cmd = new SqlCommand(cmdstr, con);
        try
        {
            cmd.ExecuteNonQuery();//执行SQL 语句并返回受影响的行数
            return 1;//成功返回１
        }
        catch (Exception e)
        {
            return 0;//失败返回０
        }
        finally
        {
            con.Dispose();//释放连接对象资源
        }
    }
    
    /// <summary>
    /// 执行SQL查询语句
    /// </summary>
    /// <param name="cmdstr">查询语句</param>
    /// <returns>返回DataTable数据表</returns>
    public DataTable reDt(string cmdstr)
    {
        SqlConnection con =GetCon();
        SqlDataAdapter da = new SqlDataAdapter(cmdstr, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return (ds.Tables[0]);
    }
    /// <summary>
    /// 执行SQL查询语句
    /// </summary>
    /// <param name="str">查询语句</param>
    /// <returns>返回SqlDataReader对象dr</returns>
    public SqlDataReader reDr(string str)
    {
        SqlConnection conn = GetCon();//连接数据库
        conn.Open();//并打开了连接
        SqlCommand com = new SqlCommand(str, conn);
        SqlDataReader dr = com.ExecuteReader(CommandBehavior.CloseConnection);
        return dr;//返回SqlDataReader对象dr
    }
    /// <summary>
    /// MD5加密
    /// </summary>
    /// <param name="strPwd">被加密的字符串</param>
    /// <returns>返回加密后的字符串</returns>
    public string MD5(string strPwd)
    {
        MD5 md5 = new MD5CryptoServiceProvider();
        byte[] data = System.Text.Encoding.Default.GetBytes(strPwd);//将字符编码为一个字节序列
        byte[] md5data = md5.ComputeHash(data);//计算data字节数组的哈希值
        md5.Clear();
        string str = "";
        for (int i = 0; i <md5data.Length-1; i++)
        {
            str += md5data[i].ToString("x").PadLeft(2,'0');
        }
        return str;
    }
}

using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using System.Data.OleDb;
/// <summary>
/// User 的摘要说明
/// </summary>
public class User
{
    
    string sql;
    SQLHelper sh = new SQLHelper();
	public User()
	{
		
	}
    //登录
    public bool Is_Login(string uid,string pwd)
    {
        OleDbParameter[] par ={new OleDbParameter("@uid",uid),new OleDbParameter("@pwd",pwd) };
        sql = "SELECT *FROM [User] WHERE [User_ID]=@uid AND [User_Pwd]=@pwd";
        DataTable dt=sh.ExecuteQuery(sql, par,CommandType.Text);
        if (dt.Rows.Count > 0)
        {
            
            return (true);
            
        }
        else
        {
            return (false);
        }    
    }
    //设置最后活动时间
    public void SetLastActive(string uid, string now)
    {
        OleDbParameter[] par ={new OleDbParameter("@now", now), new OleDbParameter("@uid", uid)};
        sql = "UPDATE [User] SET [Last_Active]=@now WHERE [User_ID]=@uid";
        sh.ExecuteNonQuery(sql, par, CommandType.Text);
    
    }
    //得到最后活动时间
    public string GetLastActive(string uid)
    {
        OleDbParameter[] par ={ new OleDbParameter("@uid", uid) };
        sql = "SELECT [Last_Active] FROM[User] WHERE [User_ID]=@uid";
        return (sh.ExecuteScalar(sql, par, CommandType.Text).ToString());
    }
    //添加发言内容
    public int AddChat(string uid,string contents,string now)
    {
           OleDbParameter[] par ={ new OleDbParameter("@contents", contents), new OleDbParameter("@uid", uid), new OleDbParameter("@time", now) };
           sql = "INSERT INTO [Chat]([Content],[User_ID],[Time]) VALUES(@contents,@uid,@time)";
           return (sh.ExecuteNonQuery(sql, par, CommandType.Text));
     
    }
    //返回聊天记录
    public DataTable GetChat()
    {
        sql = "SELECT *FROM [Chat] order by [Time] desc";
        return (sh.ExecuteQuery(sql, CommandType.Text));    
    }
    //判断是否允许发言
    public bool IsAllowChat(string uid)
    {
        int n;
        OleDbParameter[] par ={ new OleDbParameter("@uid", uid) };
        sql = "SELECT [Is_AllowChat] FROM [User] WHERE [User_ID]=@uid";
        n=Convert.ToInt32(sh.ExecuteScalar(sql,par,CommandType.Text));
        if (n > 0)
            return (true);
        else
            return (false);
    }
    //判断用户是否存在
    public bool IsUse(string uid)
    {
        OleDbParameter[] par ={new OleDbParameter("@uid",uid) };
        sql = "SELECT *FROM [User] WHERE [User_ID]=@uid";
        DataTable dt = sh.ExecuteQuery(sql, par, CommandType.Text);
        if (dt.Rows.Count > 0)
        {
            return (true);
        }
        else
        {
            return (false);        
        }
    }
    //添加用户
    public void AddUser(string uid,string pwd)
    {
        OleDbParameter[] par ={ new OleDbParameter("@uid", uid),new OleDbParameter("@pwd",pwd)};
        sql = "INSERT INTO [User]([User_ID],[User_Pwd]) VALUES(@uid,@pwd)";
        sh.ExecuteNonQuery(sql, par, CommandType.Text);           
    
    }
    //添加禁言用户的发言内容
    public void AddNoChat(string uid, string contents, string now)
    {
        OleDbParameter[] par ={ new OleDbParameter("@contents", contents), new OleDbParameter("@uid", uid), new OleDbParameter("@time", now) };
        sql = "INSERT INTO [NoChat]([Content],[User_ID],[Time]) VALUES(@contents,@uid,@time)";
        sh.ExecuteNonQuery(sql, par, CommandType.Text);

    }
    //数据源分页
    /// <summary>
    /// DataTable数据源分页
    /// </summary>
    /// <param name="dt">数据源</param>
    /// <param name="pagesize">每页数量</param>
    /// <param name="curpage">当前页</param>
    /// <returns>分页数据源</returns>
    public PagedDataSource GetPageDataSource(DataTable dt, int pagesize, int curpage)    //分页
    {

        PagedDataSource pg = new PagedDataSource();
        pg.AllowPaging = true;
        pg.DataSource = dt.DefaultView;
        pg.PageSize = pagesize;

        int total = pg.PageCount;
        if (curpage < 1)
            curpage = 1;
        if (curpage > total)
            curpage = total;

        pg.CurrentPageIndex = curpage - 1;

        return pg;
    }
}

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

/// <summary>
/// UserManage 的摘要说明
/// </summary>
public class UserManage
{
    public UserManage()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    DataBase data = new DataBase();

    #region 定义注册用户--数据结构
    private string username = "";
    private string userpwd = "";
    private string tname = "";
    private bool sex = false;
    private DateTime birthday = Convert.ToDateTime(DateTime.Now.ToShortDateString());
    private string tel = "";
    private string mobile = "";
    private int qq = 0;
    private string photo = "";
    private string email = "";
    private string faddress = "";
    private string raddress = "";
    private string index = "";
    private string userpop = "用户";
    /// <summary>
    /// 用户名
    /// </summary>
    public string UserName
    {
        get { return username; }
        set { username = value; }
    }
    /// <summary>
    /// 用户密码
    /// </summary>
    public string UserPwd
    {
        get { return userpwd; }
        set { userpwd = value; }
    }
    /// <summary>
    /// 真实姓名
    /// </summary>
    public string TName
    {
        get { return tname; }
        set { tname = value; }
    }
    /// <summary>
    /// 性别
    /// </summary>
    public bool Sex
    {
        get { return sex; }
        set { sex = value; }
    }
    /// <summary>
    /// 出生日期
    /// </summary>
    public DateTime Birthday
    {
        get { return birthday; }
        set { birthday = value; }
    }
    /// <summary>
    /// 联系电话
    /// </summary>
    public string Tel
    {
        get { return tel; }
        set { tel = value; }
    }
    /// <summary>
    /// 手机
    /// </summary>
    public string Mobile
    {
        get { return mobile; }
        set { mobile = value; }
    }
    /// <summary>
    /// QQ号
    /// </summary>
    public int QQ
    {
        get { return qq; }
        set { qq = value; }
    }
    /// <summary>
    /// 头像
    /// </summary>
    public string Photo
    {
        get { return photo; }
        set { photo = value; }
    }
    /// <summary>
    /// Email
    /// </summary>
    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    /// <summary>
    /// 家庭住址
    /// </summary>
    public string FAddress
    {
        get { return faddress; }
        set { faddress = value; }
    }
    /// <summary>
    /// 联系地址
    /// </summary>
    public string RAddress
    {
        get { return raddress; }
        set { raddress = value; }
    }
    /// <summary>
    /// 个人首页
    /// </summary>
    public string Index
    {
        get { return index; }
        set { index = value; }
    }
    /// <summary>
    /// 用户权限
    /// </summary>
    public string UserPop
    {
        get { return userpop; }
        set { userpop = value; }
    }
    #endregion

    #region 添加--用户信息
    /// <summary>
    /// 添加--用户信息
    /// </summary>
    /// <param name="usermanage"></param>
    /// <returns></returns>
    public int AddUser(UserManage usermanage)
    {
        SqlParameter[] prams = {
									    data.MakeInParam("@username",  SqlDbType.NVarChar, 50, usermanage.UserName),
                						data.MakeInParam("@userpwd",  SqlDbType.NVarChar, 50,usermanage.UserPwd ),
                						data.MakeInParam("@tname",  SqlDbType.NVarChar, 20, usermanage.TName ),
                						data.MakeInParam("@sex",  SqlDbType.Bit, 1, usermanage.Sex ),
                						data.MakeInParam("@birthday",  SqlDbType.SmallDateTime, 8, usermanage.Birthday ),
                						data.MakeInParam("@tel",  SqlDbType.NVarChar, 20, usermanage.Tel ),
                                        data.MakeInParam("@mobile",  SqlDbType.NVarChar, 20, usermanage.Mobile ),
                						data.MakeInParam("@qq",  SqlDbType.BigInt, 8,usermanage.QQ ),
                						data.MakeInParam("@photo",  SqlDbType.NVarChar, 200, usermanage.Photo ),
                						data.MakeInParam("@email",  SqlDbType.NVarChar, 50, usermanage.Email ),
                						data.MakeInParam("@faddress",  SqlDbType.NVarChar, 100, usermanage.FAddress ),
                						data.MakeInParam("@raddress",  SqlDbType.NVarChar, 100, usermanage.RAddress ),
                                        data.MakeInParam("@index",  SqlDbType.NVarChar, 50, usermanage.Index ),
			};
        return (data.RunProc("INSERT INTO tb_User (用户名,用户密码,真实姓名,性别,出生日期,联系电话,手机,QQ号,头像,Email,家庭住址,联系地址,个人首页,用户权限) "
            + "VALUES (@username,@userpwd,@tname,@sex,@birthday,@tel,@mobile,@qq,@photo,@email,@faddress,@raddress,@index,'" + userpop + "')", prams));
    }
    #endregion

    #region 查询--用户信息
    /// <summary>
    /// 根据--用户姓名--得到用户信息
    /// </summary>
    /// <param name="usermanage"></param>
    /// <param name="tbName"></param>
    /// <returns></returns>
    public DataSet FindUserByName(UserManage usermanage, string tbName)
    {
        SqlParameter[] prams = {
									    data.MakeInParam("@username",  SqlDbType.NVarChar, 50, usermanage.UserName+"%"),
			};
        return (data.RunProcReturn("select * from tb_User where 用户名 like @username", prams, tbName));
    }
    /// <summary>
    /// 得到所有--用户信息
    /// </summary>
    /// <param name="tbName"></param>
    /// <returns></returns>
    public DataSet GetAllUser(string tbName)
    {
        return (data.RunProcReturn("select * from tb_User ORDER BY 用户名", tbName));
    }
    #endregion

    #region 用户登录
    /// <summary>
    /// 用户登录
    /// </summary>
    /// <param name="usermanage"></param>
    /// <returns></returns>
    public DataSet Login(UserManage usermanage)
    {
        SqlParameter[] prams = {
									    data.MakeInParam("@username",  SqlDbType.NVarChar, 50, usermanage.UserName),
                						data.MakeInParam("@userpwd",  SqlDbType.NVarChar, 50,usermanage.UserPwd ),
			};
        return (data.RunProcReturn("SELECT * FROM tb_User WHERE (用户名 = @username) AND (用户密码 = @userpwd)", prams, "tb_User"));
    }
    #endregion
}

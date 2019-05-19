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
/// ImageManage 的摘要说明
/// </summary>
public class ImageManage
{
	public ImageManage()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}

    DataBase data = new DataBase();
    #region 定义头像--数据结构
    private string photoid = "";
    private string photo = "";
    /// <summary>
    /// 编号
    /// </summary>
    public string PhotoID
    {
        get { return photoid; }
        set { photoid = value; }
    }
    /// <summary>
    /// 头像
    /// </summary>
    public string Photo
    {
        get { return photo; }
        set { photo = value; }
    }
    #endregion

    #region 查询--头像信息
    /// <summary>
    /// 根据--头像编号--得到头像信息
    /// </summary>
    /// <param name="imagemanage"></param>
    /// <param name="tbName"></param>
    /// <returns></returns>
    public DataSet FindPhotoByID(ImageManage imagemanage, string tbName)
    {
        SqlParameter[] prams = {
									    data.MakeInParam("@photoid",  SqlDbType.NVarChar, 20, imagemanage.PhotoID),
			};
        return (data.RunProcReturn("select * from tb_Image where 编号 like @photoid", prams, tbName));
    }
    /// <summary>
    /// 得到所有--头像信息
    /// </summary>
    /// <param name="tbName"></param>
    /// <returns></returns>
    public DataSet GetAllPhoto(string tbName)
    {
        return (data.RunProcReturn("select * from tb_Image ORDER BY 编号", tbName));
    }
    #endregion
}

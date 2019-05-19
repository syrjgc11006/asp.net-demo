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
using System.Web.Caching;
using System.Data.SqlClient;
using System.Xml;

public partial class _Default : System.Web.UI.Page
{
    //页面加载时，首先判断缓存中是否包含关键字为“key”的数据
    //如果在缓存中存在该数据，读取缓存中的数据，否则，读取XML文件中的数据
    protected void Page_Load(object sender, EventArgs e)
    {
            DataSet ds = new DataSet();
            if (Cache["key"] == null)
            {
                ds.ReadXml(Server.MapPath("~/XMLFile.xml"));
                this.GridView1.DataSource = ds;
                this.GridView1.DataBind();
            }
            else
            {
                ds = (DataSet)Cache["key"];
                this.GridView1.DataSource = ds;
                this.GridView1.DataBind();
            }
    }
    
    //显示缓存数据
    protected void DisplayCacheInfo()
    {
        string cacheCount = Cache.Count.ToString();
        this.Label1.Text = "共包括"+cacheCount+"个缓存对象：";
        IDictionaryEnumerator cacheEnum = Cache.GetEnumerator();
        while (cacheEnum.MoveNext())
        {
            this.Label1.Text+= cacheEnum.Key.ToString() + "，";
        
        }    
    }
    //添加按钮，用于将数据信息保存在缓存中
    protected void Button3_Click(object sender, EventArgs e)
    {
        //判断缓存中是否存在该数据，如果不存在，则将数据信息添加到缓存中
        if (Cache["key"] == null)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("~/XMLFile.xml"));
            //将文件中的XML数据插入缓存，无需在以后请求时从文件读取
            //System.Web.Caching.CacheDependency是确保缓存在文件更改后立即到期，以便从文件中提取最新数据，重新进行缓存，若缓存的数据来自若干个文件，还可以指定一个文件名的数组
            //如System.Web.Caching.CacheDependency(new string[]{},new string[]{"key"});
            Cache.Insert("key", ds, new System.Web.Caching.CacheDependency(Server.MapPath("XMLFile.xml")));
        
        }
        this.Label2.Text = "";
        DisplayCacheInfo();
    }
    //检索按钮，用于从缓存中检索指定的数据信息是否存在
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Cache["key"] != null)
        { 
        this.Label2.Text ="已检索到缓存中包括该数据！";
        }
        else 
        {
            this.Label2.Text = "未检索到缓存中包括该数据！";
        }
        DisplayCacheInfo();
    }
    //移除按钮，用于从缓存中移除指定的数据信息
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Cache["key"] == null)
        {
            this.Label2.Text = "未缓存该数据，无法删除！";

        }
        else
        {
            Cache.Remove("key");
            this.Label2.Text = "删除成功！";       
        }
        DisplayCacheInfo();
    }
  
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_HomeWork
{
    public partial class TeacherSelectClass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //页面第一次载入，各下拉列表值填充
            if (!IsPostBack)
            {
                BindYear();
                BindTerm();
                BindCollege();
                BindTeacher();

            }
           
        }
        //自定义BingYear()
        protected void BindYear()
        {
            //清空学年下拉框中的项
            ddlYear.Items.Clear();
            int startYear = DateTime.Now.Year - 10;
            int currentYear = DateTime.Now.Year;
            //向学年下拉框列表项
            for (int i = startYear; i <= currentYear; i++)
            {
                ddlYear.Items.Add(new ListItem((i-1).ToString()+"-"+i.ToString()));

            }
            ddlYear.SelectedValue = (currentYear - 1).ToString() + "-" + currentYear.ToString();
        }

        //自定义学期
        protected void BindTerm()
        {
            ddlTerm.Items.Clear();
            for (int i = 0; i < 2; i++)
            {
                ddlTerm.Items.Add(new ListItem((i+1).ToString()));
            }
        }
        //自定义院系
        protected void BindCollege()
        {
            ddlCollege.Items.Clear();
            ddlCollege.Items.Add(new ListItem("数学与信息工程学院"));
            ddlCollege.Items.Add(new ListItem("外国语学院"));
            ddlCollege.Items.Add(new ListItem("计算机学院"));
        }
        //自定义方法BingTeacher()
        protected void BindTeacher()
        {
            ddlTeacher.Items.Clear();
            switch (ddlCollege.SelectedValue)
            {
                case "数学与信息工程学院":
                    ddlTeacher.Items.Add(new ListItem("张三"));
                    ddlTeacher.Items.Add(new ListItem("李四"));
                    ddlTeacher.Items.Add(new ListItem("王五"));
                    break;

                case "外国语学院":
                    ddlTeacher.Items.Add(new ListItem("大毛"));
                    ddlTeacher.Items.Add(new ListItem("二毛"));
                    ddlTeacher.Items.Add(new ListItem("三毛"));
                    break;

                case "计算机学院":
                    ddlTeacher.Items.Add(new ListItem("周云才"));
                    ddlTeacher.Items.Add(new ListItem("李文华"));
                    ddlTeacher.Items.Add(new ListItem("王祖荣"));
                    break;
            }
        }

        //当院校发生改变时，教师的下拉框发生改变
        protected void ddlCollege_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindTeacher();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Webthuetro
{

    public partial class Default : System.Web.UI.Page
    {
        Connet create = new Connet();

        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = "select * from BAIDANG";
            DataTable dt = create.readdata(sql);
            string htmlString = "";

            foreach (DataRow row in dt.Rows)
            {

                //htmlString += "<a class=\"content-content\" href=\"Detaill.aspx?id=" + row["ID_BAIDANG"].ToString() + "\" >";
                htmlString += "<a class=\"content-content\" href=\"Detaill.aspx?id=" + row["ID_BAIDANG"].ToString() + "\" >";

                htmlString += "<div class=\"view_content\">";
                htmlString += "<div class=\"img\">";
                htmlString += " <img  src=\"/Images/"+row["HINHANH"].ToString()+"\" alt=\"\">";
                htmlString += "</div>";
                htmlString += " <div class=\"content\">";
                htmlString += " <h6 id = \"tieude\" > " + row["TIEUDE"].ToString() + "</h6>";
                htmlString += " <div class=\"content1\">";
                htmlString += "  <p class=\"dientich\" id=\"dientich\">" + row["DIENTICH"].ToString() + "</p>";
                htmlString += " <p class=\"sophong\" id=\"phong\">2 PN</p>";
                htmlString += " </div>";
                htmlString += "<div class=\"gia\" id=\"gia\">" + row["GIA"].ToString() + "triệu/tháng</div>";
                htmlString += " <div class=\"content2\">";
                htmlString += " <div class=\"gio\" id=\"ngaydang\">" + row["NGAYDANG"].ToString() + "</div>";
                htmlString += " <div class=\"diachi\" id=\"diachi\">" + row["DIACHI"].ToString() + "</div>";
                htmlString += "</div>";
                htmlString += " </div>";
                htmlString += "</div>";
                htmlString += " </a>";
            }

            // Gán chuỗi HTML cho Literal
            Literal1.Text = htmlString;
        }
        protected void LinkButton2Click(object sender, EventArgs e)
        {

            string sql = "select * from BAIDANG where LOAITIN= N'THUÊ TRỌ' ";
            DataTable dt = create.readdata(sql);
            string htmlString = "";

            foreach (DataRow row in dt.Rows)
            {

                //htmlString += "<a class=\"content-content\" href=\"Detaill.aspx?id=" + row["ID_BAIDANG"].ToString() + "\" >";
                htmlString += "<a class=\"content-content\" href=\"Detaill.aspx?id=" + row["ID_BAIDANG"].ToString() + "\" >";

                htmlString += "<div class=\"view_content\">";
                htmlString += "<div class=\"img\">";
                htmlString += " <img  src=\"/Images/" + row["HINHANH"].ToString() + "\" alt=\"\">";
                htmlString += "</div>";
                htmlString += " <div class=\"content\">";
                htmlString += " <h6 id = \"tieude\" > " + row["TIEUDE"].ToString() + "</h6>";
                htmlString += " <div class=\"content1\">";
                htmlString += "  <p class=\"dientich\" id=\"dientich\">" + row["DIENTICH"].ToString() + "</p>";
                htmlString += " <p class=\"sophong\" id=\"phong\">2 PN</p>";
                htmlString += " </div>";
                htmlString += "<div class=\"gia\" id=\"gia\">" + row["GIA"].ToString() + "triệu/tháng</div>";
                htmlString += " <div class=\"content2\">";
                htmlString += " <div class=\"gio\" id=\"ngaydang\">" + row["NGAYDANG"].ToString() + "</div>";
                htmlString += " <div class=\"diachi\" id=\"diachi\">" + row["DIACHI"].ToString() + "</div>";
                htmlString += "</div>";
                htmlString += " </div>";
                htmlString += "</div>";
                htmlString += " </a>";
            }

            // Gán chuỗi HTML cho Literal
            Literal1.Text = htmlString;


        }
        protected void LinkButton1Click(object sender, EventArgs e)
        {
            string sql = "select * from BAIDANG where LOAITIN= N'TÌM TRỌ ' ";
            DataTable dt = create.readdata(sql);
            string htmlString = "";

            foreach (DataRow row in dt.Rows)
            {

                //htmlString += "<a class=\"content-content\" href=\"Detaill.aspx?id=" + row["ID_BAIDANG"].ToString() + "\" >";
                htmlString += "<a class=\"content-content\" href=\"Detaill.aspx?id=" + row["ID_BAIDANG"].ToString() + "\" >";

                htmlString += "<div class=\"view_content\">";
                htmlString += "<div class=\"img\">";
                htmlString += " <img  src=\"/Images/" + row["HINHANH"].ToString() + "\" alt=\"\">";
                htmlString += "</div>";
                htmlString += " <div class=\"content\">";
                htmlString += " <h6 id = \"tieude\" > " + row["TIEUDE"].ToString() + "</h6>";
                htmlString += " <div class=\"content1\">";
                htmlString += "  <p class=\"dientich\" id=\"dientich\">" + row["DIENTICH"].ToString() + "</p>";
                htmlString += " <p class=\"sophong\" id=\"phong\">2 PN</p>";
                htmlString += " </div>";
                htmlString += "<div class=\"gia\" id=\"gia\">" + row["GIA"].ToString() + "triệu/tháng</div>";
                htmlString += " <div class=\"content2\">";
                htmlString += " <div class=\"gio\" id=\"ngaydang\">" + row["NGAYDANG"].ToString() + "</div>";
                htmlString += " <div class=\"diachi\" id=\"diachi\">" + row["DIACHI"].ToString() + "</div>";
                htmlString += "</div>";
                htmlString += " </div>";
                htmlString += "</div>";
                htmlString += " </a>";
            }

            // Gán chuỗi HTML cho Literal
            Literal1.Text = htmlString;


        }
        protected void LinkButton3Click(object sender, EventArgs e)
        {
            string sql = "select * from BAIDANG  ";
            DataTable dt = create.readdata(sql);
            string htmlString = "";

            foreach (DataRow row in dt.Rows)
            {

                //htmlString += "<a class=\"content-content\" href=\"Detaill.aspx?id=" + row["ID_BAIDANG"].ToString() + "\" >";
                htmlString += "<a class=\"content-content\" href=\"Detaill.aspx?id=" + row["ID_BAIDANG"].ToString() + "\" >";

                htmlString += "<div class=\"view_content\">";
                htmlString += "<div class=\"img\">";
                htmlString += " <img  src=\"/Images/" + row["HINHANH"].ToString() + "\" alt=\"\">";
                htmlString += "</div>";
                htmlString += " <div class=\"content\">";
                htmlString += " <h6 id = \"tieude\" > " + row["TIEUDE"].ToString() + "</h6>";
                htmlString += " <div class=\"content1\">";
                htmlString += "  <p class=\"dientich\" id=\"dientich\">" + row["DIENTICH"].ToString() + "</p>";
                htmlString += " <p class=\"sophong\" id=\"phong\">2 PN</p>";
                htmlString += " </div>";
                htmlString += "<div class=\"gia\" id=\"gia\">" + row["GIA"].ToString() + "triệu/tháng</div>";
                htmlString += " <div class=\"content2\">";
                htmlString += " <div class=\"gio\" id=\"ngaydang\">" + row["NGAYDANG"].ToString() + "</div>";
                htmlString += " <div class=\"diachi\" id=\"diachi\">" + row["DIACHI"].ToString() + "</div>";
                htmlString += "</div>";
                htmlString += " </div>";
                htmlString += "</div>";
                htmlString += " </a>";
            }

            // Gán chuỗi HTML cho Literal
            Literal1.Text = htmlString;


        }
    }
}
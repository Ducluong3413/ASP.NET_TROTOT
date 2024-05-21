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
    public partial class Detaill : System.Web.UI.Page
    {
        Connet create = new Connet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string baiDangId = Request.QueryString["id"];
                if (baiDangId != null)
                {
                   
                    string sql = "select * from BAIDANG where ID_BAIDANG = @baiDangId";
                    //DataTable dt = create.readdata(sql);
                    SqlConnection connection = create.getConnection();
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@baiDangId", baiDangId);
                    connection.Open();

                    // Thực thi truy vấn và lấy dữ liệu vào DataTable
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    // Đóng kết nối sau khi đã sử dụng xong
                    connection.Close();
                    string htmlString = "";
                    foreach (DataRow row in dt.Rows)
                    {
                        htmlString += "<div class=\"listimg\">";
                        htmlString += "<img src=\"/Images/" + row["HINHANH"].ToString() + "\" alt=\"\">";
                        htmlString += "</div>";
                        htmlString += "<h3>" + row["TIEUDE"].ToString() + "</h3>";
                        htmlString += "<div class=\"thongtin\">";
                        htmlString += "<p class=\"gia\">" + row["GIA"].ToString() + " /tháng</p>";
                        htmlString += "<p class=\"dientich\">-" + row["DIENTICH"].ToString() + "m2</p>";
                        htmlString += "<p><i class=\"fa-solid fa-share\"></i>chia sẽ</p>";
                        htmlString += "<p><i class=\"fa-solid fa-heart\"></i>lưu tin</p>";
                        htmlString += "</div>";
                        htmlString += "<div class=\"diachi \"><i class=\"fa-solid fa-location-dot\"></i>" + row["DIACHI"].ToString() + "</div>";
                        htmlString += "<div class=\"thoigian \"><i class=\"fa-solid fa-business-time\"></i>đăng 3 giờ trước</div>";
                        htmlString += "<div class=\"kiemduyet \"><i class=\"fa-solid fa-shield\"></i>tin đã được kiểm duyệt</div>";
                        htmlString += "<div class=\"content-characteristic\">";
                        htmlString += "<h4>đặc điểm bất động sản</h4>";
                        htmlString += "<div class=\"characteristic\">";
                        htmlString += "<div class=\"characteristic-left\">";
                        htmlString += "<p><i class=\"fa-solid fa-cart-shopping\"></i>cho thuê</p>";
                        htmlString += "<p><i class=\"fa-solid fa-couch\"></i>tình trạng nội thất: nội thất đầy đủ</p>";
                        htmlString += "</div>";
                        htmlString += "<div class=\"characteristic-right\">";
                        htmlString += "<p><i class=\"fa-brands fa-codepen\"></i>diện tích: " + row["DIENTICH"].ToString() + " m²</p>";
                        htmlString += "<p><i class=\"fa-solid fa-dollar-sign\"></i>số tiền cọc:" + row["TIENCOC"].ToString() + " đ</p>";
                        htmlString += "</div>";
                        htmlString += "</div>";
                        htmlString += "</div>";
                        htmlString += "<div class=\"content-characteristic\">";
                        htmlString += "<h4>mô tả chi tiết</h4>";
                        htmlString += "<p>" + row["NOIDUNGTIN"].ToString() + "</p>";
                        htmlString += "</div>";
                    }
                    Literal2.Text = htmlString;
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('ID chưa lấy thành công');", true);

                }
            }
            else
            {
                return; 
            }
            


        }
    }
}
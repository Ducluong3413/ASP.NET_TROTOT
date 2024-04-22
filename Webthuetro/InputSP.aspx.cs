using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace Webthuetro
{
    public partial class InputSP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string filename = "";
        protected void UploadButton_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                try
                {
                    filename = Path.GetFileName(FileUpload1.FileName);
                    string folderPath = Server.MapPath("~/Images/"); // Thay đổi đường dẫn nếu bạn muốn lưu ảnh vào thư mục khác
                    string filePath = Path.Combine(folderPath, filename);
                    FileUpload1.SaveAs(filePath);
                    // Thông báo thành công
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Ảnh đã được tải lên thành công!');", true);
                }
                catch (Exception ex)
                {
                    // Xử lý nếu có lỗi
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", $"alert('Đã xảy ra lỗi: {ex.Message}');", true);
                }
            }
            else
            {
                // Thông báo nếu không có tập tin được chọn
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Vui lòng chọn tập tin ảnh để tải lên.');", true);
            }
        }
        protected void BtnDangTin_Click(object sender, EventArgs e)
        {

            //ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('đăng tin');", true);
            string tieude = Tieude.Text;
            string giathue = Giathue.Text;
            string dientich = Dientich.Text;
            string diachi = Diachi.Text;
            string tinhtrang = Tinhtrang.Text;
            string tiencoc = Tiencoc.Text;
            string mota = Mota.Text;

            //string sqlCon = @"Data Source=DESKTOP-2GEPH8G\MSSQLSERVER01;Initial Catalog=DBTHUETRO;Integrated Security=True";
            //SqlConnection con = new SqlConnection(sqlCon);
            //con.Open();
            //SqlCommand cmd = new SqlCommand("", con);//câu truy vấn, chuỗi kết nối

            // cmd.CommandText = "INSERT INTO USERR (TENKHACHHANG, ID_TAIKHOAN, PASSWORK, SDT, EMAIL,GIOI TINH,LOAI_USER) " +
            //   "VALUES (@Name, @Username, @Password, @SDT, @Email, @GioiTinh,@LoaiUser)";

            string sqlCon = @"Data Source=DESKTOP-2GEPH8G\MSSQLSERVER01;Initial Catalog=DB_TROTOT;Integrated Security=True";

            string user = Session["UserID"] as string;
            if (user == null)
            {
                // Xử lý khi không có người dùng nào được xác định
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Vui lòng đăng nhập để đăng tin.');", true);
                return; // Dừng hàm xử lý ở đây
            }

            //string user = "";
            //using (SqlConnection con = new SqlConnection(sqlCon))
            //{
            //    con.Open();
            //    string sql = "SELECT ID_TAIKHOAN FROM USERR WHERE ID_TAIKHOAN = @Username AND PASSWORK = @Password";
            //    using (SqlCommand cmd = new SqlCommand(sql, con))
            //    {

            //        object result = cmd.ExecuteScalar();
            //        if (result != null) // Người dùng tồn tại trong cơ sở dữ liệu
            //        {
            //            user = result.ToString();
            //            Session["UserID"] = user; // Lưu ID_TAIKHOAN vào phiên làm việc

            //        }
            //        else
            //        {
            //            // Xử lý khi không tìm thấy người dùng trong cơ sở dữ liệu
            //            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Không tìm thấy người dùng.');", true);
            //        }
            //    }
            //}
            string loaitin = RadioButton3.Checked ? "THUÊ TRỌ" : "TÌM TRỌ";


            //int ID_TIN;
            //using (SqlConnection con = new SqlConnection(sqlCon))
            //{
            //    con.Open();
            //    string query = "SELECT MAX(ID_TIN) FROM BAIDANG";
            //    using (SqlCommand cmd = new SqlCommand(query, con))
            //    {
            //        object result = cmd.ExecuteScalar();
            //        if (result != DBNull.Value)
            //        {
            //            ID_TIN = Convert.ToInt32(result) + 1;
            //        }
            //        else
            //        {
            //            ID_TIN = 1;
            //        }
            //    }
            //}



            using (SqlConnection con = new SqlConnection(sqlCon))
            {
                con.Open();
                string query = "INSERT INTO BAIDANG (ID_TAIKHOAN,NOIDUNGTIN,NGAYDANG, GIA, TIEUDE, HINHANH,DIACHI,DIENTICH,TIENCOC,LOAITIN) " +
                               "VALUES (@id_TAIKHOAN,@MoTa,Getdate(),@Gia,@TieuDe,@hinhanh,@DiaChi,@DienTich,@TienCoc,@Loaitin)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id_TAIKHOAN", user);
                    //cmd.Parameters.AddWithValue("@idTIN", ID_TIN);
                    cmd.Parameters.AddWithValue("@TieuDe", tieude);
                    cmd.Parameters.AddWithValue("@Gia", giathue);
                    cmd.Parameters.AddWithValue("@DiaChi", diachi);
                    cmd.Parameters.AddWithValue("@DienTich", dientich);
                    cmd.Parameters.AddWithValue("@TinhTrang", tinhtrang);
                    cmd.Parameters.AddWithValue("@TienCoc", tiencoc);
                    cmd.Parameters.AddWithValue("@MoTa", mota);
                    cmd.Parameters.AddWithValue("@hinhanh", filename);
                    cmd.Parameters.AddWithValue("@Loaitin", loaitin);



                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Thành công: Thực hiện các hành động sau khi thêm dữ liệu vào cơ sở dữ liệu
                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Đăng ký thành công');", true);
                    }
                    else
                    {
                        // Xử lý trường hợp câu lệnh không thành công
                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Đăng ký thất bại');", true);
                    }
                }
                con.Close();

            }






        }
    }
}
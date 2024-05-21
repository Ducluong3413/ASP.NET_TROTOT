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
    public partial class forgot_password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Kiểm tra xem mật khẩu mới và xác nhận mật khẩu có khớp nhau không
            if (newPassword != confirmPassword)
            {
                // Hiển thị thông báo lỗi
                Response.Write("<script>alert('Mật khẩu mới và xác nhận mật khẩu không khớp.');</script>");
            }
            else
            {
                // Kết nối đến cơ sở dữ liệu
                string connectionString = @"Data Source=DESKTOP-2GEPH8G\MSSQLSERVER01;Initial Catalog=DB_TROTOT;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        // Mở kết nối
                        connection.Open();

                        // Tạo câu truy vấn SQL để kiểm tra tên đăng nhập
                        string query = "SELECT COUNT(*) FROM USERR WHERE ID_TAIKHOAN = @Username";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Username", username);

                        // Thực thi truy vấn và kiểm tra kết quả
                        int count = (int)command.ExecuteScalar();
                        if (count > 0)
                        {
                            // Tìm thấy tên đăng nhập trong cơ sở dữ liệu, cho phép đặt lại mật khẩu
                            // Tạo câu truy vấn SQL để cập nhật mật khẩu mới
                            query = "UPDATE USERR SET PASSWORK = @NewPassword WHERE ID_TAIKHOAN = @Username";
                            command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@NewPassword", newPassword);
                            command.Parameters.AddWithValue("@Username", username);

                            // Thực thi truy vấn cập nhật mật khẩu
                            int rowsAffected = command.ExecuteNonQuery();

                            // Kiểm tra xem có bất kỳ hàng nào bị ảnh hưởng hay không
                            if (rowsAffected > 0)
                            {
                                // Mật khẩu đã được thay đổi thành công
                                // Hiển thị thông báo thành công
                                Response.Write("<script>alert('Mật khẩu đã được thay đổi thành công.');</script>");
                            }
                            else
                            {
                                // Hiển thị thông báo lỗi nếu không thể cập nhật mật khẩu
                                Response.Write("<script>alert('Đã xảy ra lỗi khi cập nhật mật khẩu.');</script>");
                            }
                        }
                        else
                        {
                            // Không tìm thấy tên đăng nhập trong cơ sở dữ liệu
                            // Hiển thị thông báo lỗi
                            Response.Write("<script>alert('Tên đăng nhập không tồn tại.');</script>");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Xử lý lỗi nếu có
                        Response.Write("<script>alert('" + ex.Message + "');</script>");
                    }
                }
            }
        }
    }
}
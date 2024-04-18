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
    public partial class MasterPage : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("Button clicked!");

           

        }
        //Connet connet = new Connet();


        protected void MyButton_Click(object sender, EventArgs e)
        {
            string a = TextBox1.Text;
            string b = TextBox2.Text;

            string sqlCon = @"Data Source=DESKTOP-2GEPH8G\MSSQLSERVER01;Initial Catalog=DBTHUETRO;Integrated Security=True";
            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();
            string sql = "select * from TAIKHOAN";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                // Lấy giá trị của các cột từ mỗi hàng
                string usernameDB = row["ID_TAIKHOAN"].ToString();
                string passwordDB = row["PASSWORK"].ToString();
                string otherColumnDB = row["LOAI_USER"].ToString();

                // So sánh thông tin đăng nhập với thông tin trong cơ sở dữ liệu
                if (a == usernameDB && b == passwordDB)
                {
                    // Đăng nhập thành công, có thể thực hiện các hành động khác ở đây
                    Console.WriteLine("Đăng nhập thành công!");
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('thành công');", true);
                    // Nếu muốn sử dụng giá trị của cột khác (ví dụ: other_column), bạn có thể thực hiện tương tự.
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('thất bại');", true);
                }
            }

            
            con.Close();



        }


        protected void Btn_register_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Đăng ký');", true);
            string name = TB_name.Text;
            string username = TB_username.Text;
            string passwork = TB_password.Text;
            string sdt = TB_sdt.Text;
            string email = TB_email.Text;
            string gioiTinh;
            if (RadioButton1.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (RadioButton2.Checked)
            {
                gioiTinh = "Nữ";
            }
            string loai_user;

            if (RadioButton3.Checked)
            {
                loai_user = "nguoidung";
            }
            else if (RadioButton4.Checked)
            {
                loai_user = "chutro";
            }

            string sqlCon = @"Data Source=DESKTOP-2GEPH8G\MSSQLSERVER01;Initial Catalog=DBTHUETRO;Integrated Security=True";
            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();
            SqlCommand cmd = new SqlCommand("", con);//câu truy vấn, chuỗi kết nối

             cmd.CommandText = "INSERT INTO USERR (TENKHACHHANG, ID_TAIKHOAN, PASSWORK, SDT, EMAIL,GIOI TINH,LOAI_USER) " +
               "VALUES (@Name, @Username, @Password, @SDT, @Email, @GioiTinh,@LoaiUser)";

            //using (SqlConnection connection = new SqlConnection(Connet))
            //{
            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        // Thay thế TenBang và ColumnName1, ColumnName2,... bằng tên bảng và tên cột thực tế trong cơ sở dữ liệu của bạn

            //        // Thêm các tham số và giá trị tương ứng vào câu lệnh SQL
            //        command.Parameters.AddWithValue("@Name", name);
            //        command.Parameters.AddWithValue("@Username", username);
            //        command.Parameters.AddWithValue("@Password", passwork);
            //        command.Parameters.AddWithValue("@SDT", sdt);
            //        command.Parameters.AddWithValue("@Email", email);
            //        command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
            //        command.Parameters.AddWithValue("@GioiTinh", loai_user);

            //        // Mở kết nối
            //        connection.Open();

            //        // Thực thi câu lệnh SQL
            //        int rowsAffected = command.ExecuteNonQuery();

            //        // Kiểm tra xem câu lệnh đã thực hiện thành công hay không
            //        if (rowsAffected > 0)
            //        {
            //            // Câu lệnh đã thực hiện thành công
            //            // Thực hiện các hành động cần thiết sau khi thêm dữ liệu vào cơ sở dữ liệu
            //        }
            //        else
            //        {
            //            // Xử lý trường hợp câu lệnh không thành công
            //        }
            //    }
            //}
            

            con.Close();



        }


    }
}
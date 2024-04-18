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
            string sql = "select * from USERR";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            bool loggedIn = false;

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string usernameDB = row["ID_TAIKHOAN"].ToString();
                string passwordDB = row["PASSWORK"].ToString();

                if (a == usernameDB && b == passwordDB)
                {
                    loggedIn = true;
                    break;
                }
            }

            con.Close();

            if (loggedIn)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Đăng nhập thành công!');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Đăng nhập thất bại!');", true);
            }
        }

        //protected void MyButton_Click(object sender, EventArgs e)
        //{
        //    string a = TextBox1.Text;
        //    string b = TextBox2.Text;

        //    string sqlCon = @"Data Source=DESKTOP-2GEPH8G\MSSQLSERVER01;Initial Catalog=DBTHUETRO;Integrated Security=True";
        //    SqlConnection con = new SqlConnection(sqlCon);
        //    con.Open();
        //    string sql = "select * from USERR";
        //    SqlDataAdapter da = new SqlDataAdapter(sql, con);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    foreach (DataRow row in ds.Tables[0].Rows)
        //    {
        //        // Lấy giá trị của các cột từ mỗi hàng
        //        string usernameDB = row["ID_TAIKHOAN"].ToString();
        //        string name = row["TENKHACHHANG"].ToString();
        //        string gt = row["GIOITINH"].ToString();
        //        string sdt = row["SDT"].ToString();
        //        string email = row["EMAIL"].ToString();
        //        string passwordDB = row["PASSWORK"].ToString();
        //        string loai = row["LOAI_USER"].ToString();


        //        // So sánh thông tin đăng nhập với thông tin trong cơ sở dữ liệu
        //        if (a == usernameDB && b == passwordDB)
        //        {
        //            // Đăng nhập thành công, có thể thực hiện các hành động khác ở đây
        //            Console.WriteLine("Đăng nhập thành công!");
        //            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('thành công');", true);
        //            // Nếu muốn sử dụng giá trị của cột khác (ví dụ: other_column), bạn có thể thực hiện tương tự.
        //        }
        //        else
        //        {
        //            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('thất bại');", true);
        //        }
        //    }


        //    con.Close();



        //}

        protected void Btn_register_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Đăng ký');", true);
            string name = TB_name.Text;
            string username = TB_username.Text;
            string passwork = TB_password.Text;
            string sdt = TB_sdt.Text;
            string email = TB_email.Text;
            string gioiTinh = RadioButton1.Checked ? "Nam" : "Nữ";
            string loai_user = RadioButton3.Checked ? "nguoidung" : "chutro";

            //string sqlCon = @"Data Source=DESKTOP-2GEPH8G\MSSQLSERVER01;Initial Catalog=DBTHUETRO;Integrated Security=True";
            //SqlConnection con = new SqlConnection(sqlCon);
            //con.Open();
            //SqlCommand cmd = new SqlCommand("", con);//câu truy vấn, chuỗi kết nối

            // cmd.CommandText = "INSERT INTO USERR (TENKHACHHANG, ID_TAIKHOAN, PASSWORK, SDT, EMAIL,GIOI TINH,LOAI_USER) " +
            //   "VALUES (@Name, @Username, @Password, @SDT, @Email, @GioiTinh,@LoaiUser)";

            string sqlCon = @"Data Source=DESKTOP-2GEPH8G\MSSQLSERVER01;Initial Catalog=DBTHUETRO;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(sqlCon))
            {
                con.Open();
                string query = "INSERT INTO USERR (ID_TAIKHOAN,TENKHACHHANG,  GIOITINH,SDT, EMAIL, PASSWORK, LOAI_USER) " +
                               "VALUES (@Username,@Name, @GioiTinh, @SDT, @Email,  @Password, @LoaiUser)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", passwork);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@LoaiUser", loai_user);

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
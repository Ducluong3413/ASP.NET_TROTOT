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


        protected void myButton_Click(object sender, EventArgs e)
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


        protected void btn_register_Click(object sender, EventArgs e)
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


    }
}
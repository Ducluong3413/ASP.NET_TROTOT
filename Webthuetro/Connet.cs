using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Webthuetro
{
    public class Connet
    {
        SqlConnection con =new SqlConnection(@"Data Source=DESKTOP-2GEPH8G\MSSQLSERVER01;Initial Catalog=DB_TROTOT;Integrated Security=True");

        private void openconent()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
                Console.WriteLine("docduocj");
            }
        }
        private void closeconent()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public Boolean excedata(string cmd)
        {
            openconent();
            Boolean check = false;

            try
            {
                SqlCommand cmds = new SqlCommand(cmd, con);
                cmds.ExecuteNonQuery();
                check = true;
            }
            catch
            {

            }

            closeconent();
            return check;
        }

        public DataTable readdata (string cmd)
        {
            openconent();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmds = new SqlCommand(cmd, con);
                SqlDataAdapter da = new SqlDataAdapter(cmds);
                da.Fill(dt);
            }
            catch
            {
                dt = null;
            }

            closeconent();
            return dt;
        }

    }
}
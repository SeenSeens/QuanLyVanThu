using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataProvider
    {
        // Kết nối
        public static SqlConnection Connect()
        {
            string ConnectionString = @"Data Source=TUANIT;Initial Catalog=QuanLyVanThu;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            return con;
        }
        // Đóng kết nối
        public static void CloseConnect(SqlConnection con) { con.Close(); }
        //Lấy DataTable
        public static DataTable LayDataTable(string sQuery, SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter(sQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // Thực thi truy vấn ExecuteNonQuery
        public static bool ExecuteQueriesNonQuery(string sQuery, SqlConnection con)
        {
            try
            {
                SqlCommand com = new SqlCommand(sQuery, con);
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception e) { return false; }
        }
    }
}

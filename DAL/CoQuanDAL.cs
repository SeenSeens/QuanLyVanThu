using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CoQuanDAL
    {
        // Khởi tạo biến kết nối
        static SqlConnection con;
        // Load Cơ Quan
        public static List<CoQuanDTO> LoadCoQuan()
        {
            // Khai báo truy vấn
            string sQuery = @"SELECT * FROM CoQuan";
            // Tạo đối tượng kết nối
            con = DataProvider.Connect();
            // Truy vấn
            DataTable dt = DataProvider.LayDataTable(sQuery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Tạo list DTOSinhVien
            List<CoQuanDTO> lstcq = new List<CoQuanDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CoQuanDTO cq = new CoQuanDTO();               
                cq.IMaCQ = int.Parse(dt.Rows[i]["MaCQ"].ToString());
                cq.STenCQ = dt.Rows[i]["TenCQ"].ToString();
                cq.SDiaChi = dt.Rows[i]["DiaChi"].ToString();
                cq.ISDT = int.Parse(dt.Rows[i]["SDT"].ToString());
                cq.SNguoiDungDau = dt.Rows[i]["NguoiDungDau"].ToString();
                lstcq.Add(cq);
            }
            // Đóng kết nối
            DataProvider.CloseConnect(con);
            return lstcq;
        }

        // Thêm Cơ Quan
        public static bool ThemCoQuan(CoQuanDTO cqDTO)
        {
            // Khai báo truy vấn
            string sQuery = string.Format("INSERT INTO CoQuan VALUES (N'{0}', N'{1}', {2}, N'{3}')", cqDTO.STenCQ, cqDTO.SDiaChi, cqDTO.ISDT, cqDTO.SNguoiDungDau);
            // Tạo đối tượng kết nối
            con = DataProvider.Connect();
            // Thực thi truy vấn
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex) { DataProvider.CloseConnect(con); return false; }
        }

        // Xóa Cơ Quan
        public static bool XoaCoQuan(CoQuanDTO cqDTO)
        {
            // Khai báo truy vấn
            string sQuery = string.Format("DELETE FROM CoQuan WHERE MaCQ={0}", cqDTO.IMaCQ);
            // Tạo đối tượng kết nối
            con = DataProvider.Connect();
            // Thực thi truy vấn
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex) { DataProvider.CloseConnect(con); return false; }
        }

        // Sửa Cơ Quan
        public static bool SuaCoQuan(CoQuanDTO cqDTO)
        {
            // Khai báo truy vấn
            string sQuery = string.Format("UPDATE CoQuan SET TenCQ=N'{0}', DiaChi=N'{1}', SDT={2}, NguoiDungDau=N'{3}' WHERE MaCQ={4}", cqDTO.STenCQ, cqDTO.SDiaChi, cqDTO.ISDT, cqDTO.SNguoiDungDau, cqDTO.IMaCQ);
            // Tạo đối tượng kết nối
            con = DataProvider.Connect();
            // Thực thi truy vấn
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex) { DataProvider.CloseConnect(con); return false; }
        }

        public static List<CoQuanDTO> LoadcbCQ()
        {

            // Khai báo truy vấn.
            string sQuery = @"SELECT * FROM CoQuan";
            // Mở kết nối
            con = DataProvider.Connect();
            // Truy vấn
            DataTable dt = DataProvider.LayDataTable(sQuery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Tạo list LopDTO
            List<CoQuanDTO> lstCQ = new List<CoQuanDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CoQuanDTO cq = new CoQuanDTO();
                cq.IMaCQ = int.Parse(dt.Rows[i]["MaCQ"].ToString());
                cq.STenCQ = dt.Rows[i]["TenCQ"].ToString();
                lstCQ.Add(cq);
            }
            // Đóng kết nối
            DataProvider.CloseConnect(con);
            return lstCQ;
        }
    }
}

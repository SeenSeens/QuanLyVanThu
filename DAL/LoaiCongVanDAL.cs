using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class LoaiCongVanDAL
    {
        // Khởi tạo biến kết nối
        static SqlConnection con;
        public static List<LoaiCongVanDTO> LoadLoaiCongVan()
        {
            // Khai báo truy vấn
            string sQuery = @"SELECT * FROM LoaiCongVan";
            // Tạo đối tượng kết nối
            con = DataProvider.Connect();
            // Truy vấn
            DataTable dt = DataProvider.LayDataTable(sQuery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Tạo list DTOSinhVien
            List<LoaiCongVanDTO> lstlcv = new List<LoaiCongVanDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoaiCongVanDTO lcv = new LoaiCongVanDTO();
                lcv.IMaLCV = int.Parse(dt.Rows[i]["MaLCV"].ToString());
                lcv.STenLCV = dt.Rows[i]["TenLCV"].ToString();
                lstlcv.Add(lcv);
            }
            // Đóng kết nối
            DataProvider.CloseConnect(con);
            return lstlcv;
        }

        // Thêm loại công văn
        public static bool ThemLoaiCongVan(LoaiCongVanDTO lcvDTO)
        {
            string sQuery = string.Format("INSERT INTO LoaiCongVan VALUES (N'{0}')", lcvDTO.STenLCV);
            con = DataProvider.Connect();
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex) { DataProvider.CloseConnect(con); return false; }
        }

        // Xóa loại công văn
        public static bool XoaLoaiCongVan(LoaiCongVanDTO lcvDTO)
        {
            // Khai báo truy vấn
            string sQuery = string.Format("DELETE FROM LoaiCongVan WHERE MaLCV={0}", lcvDTO.IMaLCV);
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

        // Sửa loại công văn
        public static bool SuaLoaiCongVan(LoaiCongVanDTO lcvDTO)
        {
            // Khai báo truy vấn
            string sQuery = string.Format("UPDATE LoaiCongVan SET TenLCV=N'{0}' WHERE MaLCV={1}", lcvDTO.STenLCV, lcvDTO.IMaLCV);
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

        // Load combobox LoaiCongVan
        public static List<LoaiCongVanDTO> LoadcbLCV()
        {
            string sQuery = @"SELECT * FROM LoaiCongVan";
            con = DataProvider.Connect();
            DataTable dt = DataProvider.LayDataTable(sQuery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LoaiCongVanDTO> lstCVN = new List<LoaiCongVanDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoaiCongVanDTO lcv  = new LoaiCongVanDTO();
                lcv.IMaLCV = int.Parse(dt.Rows[i]["MaLCV"].ToString());
                lcv.STenLCV = dt.Rows[i]["TenLCV"].ToString();
                lstCVN.Add(lcv);
            }
            DataProvider.CloseConnect(con);
            return lstCVN;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class VanThuDAL
    {
        static SqlConnection con;
        public static List<VanThuDTO> LoadVanThu()
        {
            string sQuery = @"SELECT * 
                              FROM VanThu vt
                              INNER JOIN CoQuan cq
                                    ON cq.MaCQ = vt.MaCQ
                              INNER JOIN LoaiCongVan lcv
	                                ON lcv.MaLCV = vt.MaLCV";
            con = DataProvider.Connect();
            DataTable dt = DataProvider.LayDataTable(sQuery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<VanThuDTO> lstvt = new List<VanThuDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                VanThuDTO vt = new VanThuDTO();
                vt.IMaVT = int.Parse(dt.Rows[i]["MaVT"].ToString());
                vt.STieuDe = dt.Rows[i]["TieuDe"].ToString();
                vt.IMaCQ = int.Parse(dt.Rows[i]["MaCQ"].ToString());
                vt.STenCQ = dt.Rows[i]["TenCQ"].ToString();
                vt.IMaLCV = int.Parse(dt.Rows[i]["MaLCV"].ToString());
                vt.STenLCV = dt.Rows[i]["TenLCV"].ToString();
                lstvt.Add(vt);
            }
            DataProvider.CloseConnect(con);
            return lstvt;
        }

        public static bool ThemVanThu(VanThuDTO vtDTO)
        {
            string sQuery = string.Format("INSERT INTO VanThu VALUES (N'{0}', {1}, {2})", vtDTO.STieuDe, vtDTO.IMaCQ, vtDTO.IMaLCV);
            con = DataProvider.Connect();
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex) { DataProvider.CloseConnect(con); return false; }
        }

        public static bool XoaVanThu(VanThuDTO vtDTO)
        {
            string sQuery = string.Format("DELETE FROM VanThu WHERE MaVT={0}", vtDTO.IMaVT);
            con = DataProvider.Connect();
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex) { DataProvider.CloseConnect(con); return false; }
        }

        public static bool SuaVanThu(VanThuDTO vtDTO)
        {
            string sQuery = string.Format("UPDATE VanThu SET TieuDe=N'{0}', MaCQ={1}, MaLCV={2} WHERE MaVT={3}", vtDTO.STieuDe, vtDTO.IMaCQ, vtDTO.IMaLCV, vtDTO.IMaVT);
            con = DataProvider.Connect();
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex) { DataProvider.CloseConnect(con); return false; }
        }
        public static List<VanThuDTO> TimKiemvanThu(string key)
        {
            string sQuery = string.Format("SELECT * FROM VanThu WHERE TieuDe like N'%{0}%'", key);
            con = DataProvider.Connect();
            DataTable dt = DataProvider.LayDataTable(sQuery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<VanThuDTO> lstvt = new List<VanThuDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                VanThuDTO vt = new VanThuDTO();
                vt.IMaVT = int.Parse(dt.Rows[i]["MaVT"].ToString());
                vt.STieuDe = dt.Rows[i]["TieuDe"].ToString();
                vt.IMaCQ = int.Parse(dt.Rows[i]["MaCQ"].ToString());
                vt.IMaLCV = int.Parse(dt.Rows[i]["MaLCV"].ToString());
                lstvt.Add(vt);
            }
            // Đóng kết nối
            DataProvider.CloseConnect(con);
            return lstvt;
        }
    }
}

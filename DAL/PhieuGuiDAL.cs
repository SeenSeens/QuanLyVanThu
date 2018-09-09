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
    public class PhieuGuiDAL
    {
        static SqlConnection con;
        public static List<PhieuGuiDTO> LoadPhieuGui()
        {
            string sQuery = @"SELECT * FROM PhieuGui, CoQuan WHERE PhieuGui.MaCQ = CoQuan.MaCQ";
            con = DataProvider.Connect();
            DataTable dt = DataProvider.LayDataTable(sQuery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<PhieuGuiDTO> lstpg = new List<PhieuGuiDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuGuiDTO pg = new PhieuGuiDTO();
                pg.IMaPG = int.Parse(dt.Rows[i]["MaPG"].ToString());
                pg.DtNgayGui = DateTime.Parse(dt.Rows[i]["NgayGui"].ToString());            
                pg.SNguoiGui = dt.Rows[i]["NguoiGui"].ToString();
                pg.IMaCQ = int.Parse(dt.Rows[i]["MaCQ"].ToString());
                pg.STenCQ = dt.Rows[i]["TenCQ"].ToString();
                lstpg.Add(pg);
            }
            DataProvider.CloseConnect(con);
            return lstpg;
        }

        public static bool ThemPhieuGui(PhieuGuiDTO pgDTO)
        {
            string sQuery = string.Format(@"INSERT INTO PhieuGui VALUES (N'{0}', N'{1}', {2})", pgDTO.DtNgayGui, pgDTO.SNguoiGui, pgDTO.IMaCQ);
            con = DataProvider.Connect();
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex) { DataProvider.CloseConnect(con); return false; }
        }

        public static bool XoaPhieuGui(PhieuGuiDTO pgDTO)
        {
            string sQuery = string.Format("DELETE FROM PhieuGui WHERE MapG={0}", pgDTO.IMaPG);
            con = DataProvider.Connect();
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex) { DataProvider.CloseConnect(con); return false; }
        }

        public static bool SuaPhieuGui(PhieuGuiDTO pgDTO)
        {
            string sQuery = string.Format("UPDATE PhieuGui SET NgayGui=N'{0}', NguoiGui=N'{1}', MaCQ={2} WHERE MaPG={3}", pgDTO.DtNgayGui, pgDTO.SNguoiGui, pgDTO.IMaCQ, pgDTO.IMaPG);
            con = DataProvider.Connect();
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex) { DataProvider.CloseConnect(con); return false; }
        }
    }
}

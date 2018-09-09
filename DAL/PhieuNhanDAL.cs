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
    public class PhieuNhanDAL
    {
        static SqlConnection con;
        public static List<PhieuNhanDTO> LoadPhieuNhan()
        {
            string sQuery = @"SELECT * FROM PhieuNhan, DonViNhan WHERE PhieuNhan.MaDVN = DonViNhan.MaDVN";
            con = DataProvider.Connect();
            DataTable dt = DataProvider.LayDataTable(sQuery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<PhieuNhanDTO> lstpn = new List<PhieuNhanDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuNhanDTO pn = new PhieuNhanDTO();
                pn.IMaPN = int.Parse(dt.Rows[i]["MaPN"].ToString());
                pn.DtNgayNhan = DateTime.Parse(dt.Rows[i]["NgayNhan"].ToString());
                pn.SNguoiNhan = dt.Rows[i]["NguoiNhan"].ToString();
                pn.IMaDVN = int.Parse(dt.Rows[i]["MaDVN"].ToString());
                pn.STenDVN = dt.Rows[i]["TenDVN"].ToString();
                lstpn.Add(pn);
            }
            DataProvider.CloseConnect(con);
            return lstpn;
        }

        public static bool ThemPhieuNhan(PhieuNhanDTO pnDTO)
        {
            string sQuery = string.Format(@"INSERT INTO PhieuNhan VALUES (N'{0}', N'{1}', {2})", pnDTO.DtNgayNhan, pnDTO.SNguoiNhan, pnDTO.IMaDVN);
            con = DataProvider.Connect();
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex) { DataProvider.CloseConnect(con); return false; }
        }

        public static bool XoaPhieuNhan(PhieuNhanDTO pnDTO)
        {
            string sQuery = string.Format(@"DELETE FROM PhieuNhan WHERE MaPN={0}", pnDTO.IMaPN);
            con = DataProvider.Connect();
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex) { DataProvider.CloseConnect(con); return false; }
        }

        public static bool SuaPhieuNhan(PhieuNhanDTO pnDTO)
        {
            string sQuery = string.Format("UPDATE PhieuNhan SET NgayNhan=N'{0}', NguoiNhan=N'{1}', MaDVN={2} WHERE MaPN={3}", pnDTO.DtNgayNhan, pnDTO.SNguoiNhan, pnDTO.IMaDVN, pnDTO.IMaPN);
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

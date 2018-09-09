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
    public class DonViNhanDAL
    {
        static SqlConnection con;
        public static List<DonViNhanDTO> LoadDonViNhan()
        {
            string sQuery = @"SELECT * FROM DonViNhan, CoQuan WHERE DonViNhan.MaCQ = CoQuan.MaCQ";
            con = DataProvider.Connect();
            DataTable dt = DataProvider.LayDataTable(sQuery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DonViNhanDTO> lstdvn = new List<DonViNhanDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DonViNhanDTO dvn = new DonViNhanDTO();
                dvn.IMaDVN = int.Parse(dt.Rows[i]["MaDVN"].ToString());
                dvn.STenDVN = dt.Rows[i]["TenDVN"].ToString();
                dvn.SDiaChi = dt.Rows[i]["DiaChi"].ToString();
                dvn.ISDT = int.Parse(dt.Rows[i]["SDT"].ToString());
                dvn.DtNgayNhan = DateTime.Parse(dt.Rows[i]["NgayNhan"].ToString());
                dvn.IMaCQ = int.Parse(dt.Rows[i]["MaCQ"].ToString());
                dvn.STenCQ = dt.Rows[i]["TenCQ"].ToString();
                lstdvn.Add(dvn);
            }
            DataProvider.CloseConnect(con);
            return lstdvn;
        }

        public static bool ThemDonViNhan(DonViNhanDTO dvnDTO)
        {
            string sQuery = string.Format("INSERT INTO DonViNhan VALUES (N'{0}', N'{1}', {2}, N'{3}', '{4}')", dvnDTO.STenDVN, dvnDTO.SDiaChi, dvnDTO.ISDT, dvnDTO.DtNgayNhan, dvnDTO.IMaCQ);
            con = DataProvider.Connect();
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex) { DataProvider.CloseConnect(con); return false; }
        }

        public static bool XoaDonViNhan(DonViNhanDTO dvnDTO)
        {
            string sQuery = string.Format("DELETE FROM DonViNhan WHERE MaDVN={0}", dvnDTO.IMaDVN);
            con = DataProvider.Connect();
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex) { DataProvider.CloseConnect(con); return false; }
        }

        public static bool SuaDonViNhan(DonViNhanDTO dvnDTO)
        {
            string sQuery = string.Format("UPDATE DonViNhan SET TenDVN=N'{0}', DiaChi=N'{1}', SDT={2}, NgayNhan=N'{3}', MaCQ={4} WHERE MaDVN={5}", dvnDTO.STenDVN, dvnDTO.SDiaChi, dvnDTO.ISDT, dvnDTO.DtNgayNhan, dvnDTO.IMaCQ, dvnDTO.IMaDVN);
            con = DataProvider.Connect();
            try
            {
                DataProvider.ExecuteQueriesNonQuery(sQuery, con);
                DataProvider.CloseConnect(con);
                return true;
            }
            catch (Exception ex) { DataProvider.CloseConnect(con); return false; }
        }

        public static List<DonViNhanDTO> LoadcbDVN()
        {
            string sQuery = @"SELECT * FROM DonViNhan";
            con = DataProvider.Connect();
            DataTable dt = DataProvider.LayDataTable(sQuery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DonViNhanDTO> lstDVN = new List<DonViNhanDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DonViNhanDTO dvn = new DonViNhanDTO();
                dvn.IMaDVN = int.Parse(dt.Rows[i]["MaDVN"].ToString());
                dvn.STenDVN = dt.Rows[i]["TenDVN"].ToString();
                lstDVN.Add(dvn);
            }
            DataProvider.CloseConnect(con);
            return lstDVN;
        }
    }
}

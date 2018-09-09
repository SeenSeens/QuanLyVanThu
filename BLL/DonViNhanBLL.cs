using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class DonViNhanBLL
    {
        public static List<DonViNhanDTO> LoadDonViNhan()
        {
            return DonViNhanDAL.LoadDonViNhan();
        }
        public static bool ThemDonViNhan(DonViNhanDTO dvnDTO)
        {
            return DonViNhanDAL.ThemDonViNhan(dvnDTO);
        }
        public static bool XoaDonViNhan(DonViNhanDTO dvnDTO)
        {
            return DonViNhanDAL.XoaDonViNhan(dvnDTO);
        }
        public static bool SuaDonViNhan(DonViNhanDTO dvnDTO)
        {
            return DonViNhanDAL.SuaDonViNhan(dvnDTO);
        }
        public static List<DonViNhanDTO> LoadcbDVN()
        {
            return DonViNhanDAL.LoadcbDVN();
        }
    }
}

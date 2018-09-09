using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class PhieuNhanBLL
    {
        public static List<PhieuNhanDTO> LoadPhieuNhan()
        {
            return PhieuNhanDAL.LoadPhieuNhan();
        }
        public static bool ThemPhieuNhan(PhieuNhanDTO pnDTO)
        {
            return PhieuNhanDAL.ThemPhieuNhan(pnDTO);
        }
        public static bool XoaPhieuNhan(PhieuNhanDTO pnDTO)
        {
            return PhieuNhanDAL.XoaPhieuNhan(pnDTO);
        }
        public static bool SuaPhieuNhan(PhieuNhanDTO pnDTO)
        {
            return PhieuNhanDAL.SuaPhieuNhan(pnDTO);
        }
    }
}

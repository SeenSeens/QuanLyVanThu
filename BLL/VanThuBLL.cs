using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class VanThuBLL
    {
        public static List<VanThuDTO> LoadVanThu()
        {
            return VanThuDAL.LoadVanThu();
        }
        public static bool ThemVanThu(VanThuDTO vtDTO)
        {
            return VanThuDAL.ThemVanThu(vtDTO);
        }
        public static bool XoaVanThu(VanThuDTO vtDTO)
        {
            return VanThuDAL.XoaVanThu(vtDTO);
        }
        public static bool SuaVanThu(VanThuDTO vtDTO)
        {
            return VanThuDAL.SuaVanThu(vtDTO);
        }
        public static List<VanThuDTO> TimKiemvanThu(string key)
        {
            return VanThuDAL.TimKiemvanThu(key);
        }
    }
}

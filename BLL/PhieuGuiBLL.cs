using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class PhieuGuiBLL
    {
        public static List<PhieuGuiDTO> LoadPhieuGui()
        {
            return PhieuGuiDAL.LoadPhieuGui();
        }
        public static bool ThemPhieuGui(PhieuGuiDTO pgDTO)
        {
            return PhieuGuiDAL.ThemPhieuGui(pgDTO);
        }
        public static bool XoaPhieuGui(PhieuGuiDTO pgDTO)
        {
            return PhieuGuiDAL.XoaPhieuGui(pgDTO);
        }
        public static bool SuaPhieuGui(PhieuGuiDTO pgDTO)
        {
            return PhieuGuiDAL.SuaPhieuGui(pgDTO);
        }
    }
}

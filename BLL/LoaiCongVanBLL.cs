using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class LoaiCongVanBLL
    {
        // Load loại công văn
        public static List<LoaiCongVanDTO> LoadLoaiCongVan()
        {
            return LoaiCongVanDAL.LoadLoaiCongVan();
        }

        // Thêm loại công văn
        public static bool ThemLoaiCongVan(LoaiCongVanDTO lcvDTO)
        {
            return LoaiCongVanDAL.ThemLoaiCongVan(lcvDTO);
        }

        // Xóa loại công văn
        public static bool XoaLoaiCongVan(LoaiCongVanDTO lcvDTO)
        {
            return LoaiCongVanDAL.XoaLoaiCongVan(lcvDTO);
        }

        // Sửa loại công văn
        public static bool SuaLoaiCongVan(LoaiCongVanDTO lcvDTO)
        {
            return LoaiCongVanDAL.SuaLoaiCongVan(lcvDTO);
        }

        // Load combobox loại công văn
        public static List<LoaiCongVanDTO> LoadcbLCV()
        {
            return LoaiCongVanDAL.LoadcbLCV();
        }
    }
}

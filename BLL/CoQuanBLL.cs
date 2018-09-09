using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CoQuanBLL
    {
        // Load Cơ Quan
        public static List<CoQuanDTO> LoadCoQuan()
        {
            return CoQuanDAL.LoadCoQuan();
        }

        // Thêm Cơ Quan
        public static bool ThemCoQuan(CoQuanDTO cqDTO)
        {
            return CoQuanDAL.ThemCoQuan(cqDTO);
        }

        // Xóa Cơ Quan
        public static bool XoaCoQuan(CoQuanDTO cqDTO)
        {
            return CoQuanDAL.XoaCoQuan(cqDTO);
        }

        // Sửa Cơ Quan
        public static bool SuaCoQuan(CoQuanDTO cqDTO)
        {
            return CoQuanDAL.SuaCoQuan(cqDTO);
        }

        // Load cb Cơ Quan
        public static List<CoQuanDTO> LoadcbCQ()
        {
            return CoQuanDAL.LoadcbCQ();
        }
    }
}

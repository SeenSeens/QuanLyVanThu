using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiCongVanDTO
    {
        private int iMaLCV;

        public int IMaLCV
        {
            get
            {
                return iMaLCV;
            }

            set
            {
                iMaLCV = value;
            }
        }

        public string STenLCV
        {
            get
            {
                return sTenLCV;
            }

            set
            {
                sTenLCV = value;
            }
        }

        private string sTenLCV;
    }
}

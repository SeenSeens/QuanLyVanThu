using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VanThuDTO
    {
        private int iMaVT;

        public int IMaVT
        {
            get
            {
                return iMaVT;
            }

            set
            {
                iMaVT = value;
            }
        }

        public string STieuDe
        {
            get
            {
                return sTieuDe;
            }

            set
            {
                sTieuDe = value;
            }
        }

        public int IMaCQ
        {
            get
            {
                return iMaCQ;
            }

            set
            {
                iMaCQ = value;
            }
        }

        public string STenCQ
        {
            get
            {
                return sTenCQ;
            }

            set
            {
                sTenCQ = value;
            }
        }

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

        private string sTieuDe;

        private int iMaCQ;

        private string sTenCQ;

        private int iMaLCV;

        private string sTenLCV;

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuGuiDTO
    {
        private int iMaPG;

        public int IMaPG
        {
            get
            {
                return iMaPG;
            }

            set
            {
                iMaPG = value;
            }
        }

        public DateTime DtNgayGui
        {
            get
            {
                return dtNgayGui;
            }

            set
            {
                dtNgayGui = value;
            }
        }

        public string SNguoiGui
        {
            get
            {
                return sNguoiGui;
            }

            set
            {
                sNguoiGui = value;
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



        private DateTime dtNgayGui;

        private string sNguoiGui;

        private int iMaCQ;

        private string sTenCQ;
    }
}

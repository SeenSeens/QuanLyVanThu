using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhanDTO
    {
        private int iMaPN;
        public int IMaPN
        {
            get
            {
                return iMaPN;
            }

            set
            {
                iMaPN = value;
            }
        }

        public DateTime DtNgayNhan
        {
            get
            {
                return dtNgayNhan;
            }

            set
            {
                dtNgayNhan = value;
            }
        }

        public string SNguoiNhan
        {
            get
            {
                return sNguoiNhan;
            }

            set
            {
                sNguoiNhan = value;
            }
        }

        public int IMaDVN
        {
            get
            {
                return iMaDVN;
            }

            set
            {
                iMaDVN = value;
            }
        }

        public string STenDVN
        {
            get
            {
                return sTenDVN;
            }

            set
            {
                sTenDVN = value;
            }
        }

       

        private DateTime dtNgayNhan;

        private string sNguoiNhan;

        private int iMaDVN;

        private string sTenDVN;
    }
}

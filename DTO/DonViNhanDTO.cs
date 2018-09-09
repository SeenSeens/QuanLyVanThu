using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonViNhanDTO
    {
        private int iMaDVN;
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

        public string SDiaChi
        {
            get
            {
                return sDiaChi;
            }

            set
            {
                sDiaChi = value;
            }
        }

        public int ISDT
        {
            get
            {
                return iSDT;
            }

            set
            {
                iSDT = value;
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

       

        private string sTenDVN;

        private string sDiaChi;

        private int iSDT;

        private DateTime dtNgayNhan;

        private int iMaCQ;

        private string sTenCQ;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Presentation.VanThu
{
    public partial class OptionsVanThu : UserControl 
    {
        public OptionsVanThu()
        {
            InitializeComponent();
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            string key = txtKey.Text;
            List<VanThuDTO> lstKQ = VanThuBLL.TimKiemvanThu(key);
            if (lstKQ == null)
            {
                MessageBox.Show("Không tìm thấy học sinh nào.", "Thông báo!");
                return;
            }
            dgvVanThu.DataSource = lstKQ;
        }
    }
}

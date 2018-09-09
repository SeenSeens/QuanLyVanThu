using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace Presentation
{
    public partial class UILoaiCongVan : UserControl
    {
        public UILoaiCongVan()
        {
            InitializeComponent();
        }

        private void UILoaiCongVan_Load(object sender, EventArgs e)
        {
            LoadLoaiCongvan();
        }
        private void LoadLoaiCongvan()
        {
            List<LoaiCongVanDTO> lstLoaiCongvan = LoaiCongVanBLL.LoadLoaiCongVan();
            dgvlcv.DataSource = lstLoaiCongvan;
            // Đặt lại tên cho cột
            dgvlcv.Columns["IMaLCV"].HeaderText = "Mã loại công văn";
            dgvlcv.Columns["IMaLCV"].Visible = false;
            dgvlcv.Columns["STenLCV"].HeaderText = "Tên loại công văn";
           
        }

        private void dgvlcv_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvlcv.SelectedRows[0];
            txtMalcv.Text = dr.Cells["IMaLCV"].Value.ToString();
            txtTenlcv.Text = dr.Cells["STenLCV"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của dữ liệu
            if (txtTenlcv.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đày đủ thông tin.", "Thông báo!");
                return;
            }
            // Khởi tạo đối tượng LoaiCongVanDTO
            LoaiCongVanDTO lcvDTO = new LoaiCongVanDTO();
            lcvDTO.STenLCV = txtTenlcv.Text;
            // Gọi tới lơp nghiệp vụ LoaiCongVanBLL
            if (LoaiCongVanBLL.ThemLoaiCongVan(lcvDTO))
            {
                MessageBox.Show("Thêm thành công.", "Thông báo!");
                LoadLoaiCongvan();
                return;
            }
            MessageBox.Show("Thêm thất bại.", "Thông báo!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMalcv.Text == "")
            {
                MessageBox.Show("Hãy chọn cơ quan cần xóa.", "Thông báo!");
                return;
            }
            // Khởi tạo đối tượng LoaiCongVanDTO
            LoaiCongVanDTO lcvDTO = new LoaiCongVanDTO();
            lcvDTO.IMaLCV = int.Parse(txtMalcv.Text);
            // Gọi lớp nghiệp vụ LoaiCongVanBLL
            if (LoaiCongVanBLL.XoaLoaiCongVan(lcvDTO))
            {
                MessageBox.Show("Xóa thành công.", "Thông báo!");
                // Load lại dữ liệu
                LoadLoaiCongvan();
                return;
            }
            MessageBox.Show("Xóa thất bại.", "Thông báo!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Khởi tạo đối tượng LoaiCongVanDTO
            LoaiCongVanDTO lcvDTO = new LoaiCongVanDTO();
            lcvDTO.IMaLCV = int.Parse(txtMalcv.Text);
            lcvDTO.STenLCV = txtTenlcv.Text;
            // Gọi lớp nghiệp vụ LoaiCongVanBLL
            if (LoaiCongVanBLL.SuaLoaiCongVan(lcvDTO))
            {
                MessageBox.Show("Sửa thành công.", "Thông báo!");
                // Load lại dữ liệu
                LoadLoaiCongvan();
                return;
            }
            MessageBox.Show("Sửa thất bại.", "Thông báo!");
        }
    }
}

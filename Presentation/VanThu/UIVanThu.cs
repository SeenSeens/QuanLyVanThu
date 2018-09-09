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
using DAL;

namespace Presentation
{
    public partial class UIVanThu : UserControl
    {
        public UIVanThu()
        {
            InitializeComponent();
        }

        private void UIVanThu_Load(object sender, EventArgs e)
        {
            LoadcbCQ();
            LoadcbLCV();
            LoadVanThu();
        }
        private void LoadcbCQ()
        {
            List<CoQuanDTO> lstCQ = CoQuanBLL.LoadcbCQ();
            cbCoQuan.DataSource = lstCQ;
            cbCoQuan.DisplayMember = "sTenCQ";
            cbCoQuan.ValueMember = "iMaCQ";
        }
        private void LoadcbLCV()
        {
            List<LoaiCongVanDTO> lstLCV = LoaiCongVanBLL.LoadcbLCV();
            cbLoaiCongVan.DataSource = lstLCV;
            cbLoaiCongVan.DisplayMember = "sTenLCV";
            cbLoaiCongVan.ValueMember = "iMaLCV";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTieuDe.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đày đủ thông tin.", "Thông báo!");
                return;
            }
            VanThuDTO vtDTO = new VanThuDTO();
            vtDTO.STieuDe = txtTieuDe.Text;
            vtDTO.IMaCQ = int.Parse(cbCoQuan.SelectedValue.ToString());
            vtDTO.IMaLCV = int.Parse(cbLoaiCongVan.SelectedValue.ToString());
            if (VanThuBLL.ThemVanThu(vtDTO))
            {
                MessageBox.Show("Thêm thành công.", "Thông báo!");
                LoadVanThu();
                return;
            }
            MessageBox.Show("Thêm thất bại.", "Thông báo!");
        }

        private void dgvVanThu_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvVanThu.SelectedRows[0];
            txtMaVanThu.Text = dr.Cells["IMaVT"].Value.ToString();
            txtTieuDe.Text = dr.Cells["STieuDe"].Value.ToString();
            cbCoQuan.SelectedValue = int.Parse(dr.Cells["IMaCQ"].Value.ToString());
            cbLoaiCongVan.SelectedValue = int.Parse(dr.Cells["IMaLCV"].Value.ToString());
        }
        private void LoadVanThu()
        {
            List<VanThuDTO> lstVanThu = VanThuBLL.LoadVanThu();
            dgvVanThu.DataSource = lstVanThu;
            dgvVanThu.Columns["IMaVT"].HeaderText = "Mã Văn Thư";
            dgvVanThu.Columns["IMaVT"].Visible = false;
            dgvVanThu.Columns["STieuDe"].HeaderText = "Tiêu Đề";
            dgvVanThu.Columns["IMaCQ"].Visible = false;
            dgvVanThu.Columns["STenCQ"].HeaderText = "Tên Cơ Quan";
            dgvVanThu.Columns["IMaLCV"].Visible = false;
            dgvVanThu.Columns["STenLCV"].HeaderText = "Tên Loại Công Văn";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaVanThu.Text == "")
            {
                MessageBox.Show("Hãy chọn văn thư cần xóa.", "Thông báo!");
                return;
            }
            VanThuDTO vtDTO = new VanThuDTO();
            vtDTO.IMaVT = int.Parse(txtMaVanThu.Text);
            if (VanThuBLL.XoaVanThu(vtDTO))
            {
                MessageBox.Show("Xóa thành công.", "Thông báo!");
                LoadVanThu();
                return;
            }
            MessageBox.Show("Xóa thất bại.", "Thông báo!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            VanThuDTO vtDTO = new VanThuDTO();
            vtDTO.IMaVT = int.Parse(txtMaVanThu.Text);
            vtDTO.STieuDe = txtTieuDe.Text;
            vtDTO.IMaCQ = int.Parse(cbCoQuan.SelectedValue.ToString());
            vtDTO.IMaLCV = int.Parse(cbLoaiCongVan.SelectedValue.ToString());
            if (VanThuBLL.SuaVanThu(vtDTO))
            {
                MessageBox.Show("Sửa thành công.", "Thông báo!");
                LoadVanThu();
                return;
            }
            MessageBox.Show("Sửa thất bại.", "Thông báo!");
        }
        public void 
    }
}

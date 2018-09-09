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

namespace Presentation
{
    public partial class UIPhieuNhan : UserControl
    {
        public UIPhieuNhan()
        {
            InitializeComponent();
        }

        private void UIPhieuNhan_Load(object sender, EventArgs e)
        {
            LoadPhieuNhan();
            LoadcbDVN();
        }
        private void LoadcbDVN()
        {
            List<DonViNhanDTO> lstDVN = DonViNhanBLL.LoadcbDVN();
            cbDVN.DataSource = lstDVN;
            cbDVN.DisplayMember = "sTenDVN";
            cbDVN.ValueMember = "iMaDVN";
        }
        private void LoadPhieuNhan()
        {
            List<PhieuNhanDTO> lstPhieuNhan = PhieuNhanBLL.LoadPhieuNhan();
            dgvPhieuNhan.DataSource = lstPhieuNhan;
            dgvPhieuNhan.Columns["IMaPN"].HeaderText = "Mã Phiếu Nhận";
            dgvPhieuNhan.Columns["IMaPN"].Visible = false;
            dgvPhieuNhan.Columns["DtNgayNhan"].HeaderText = "Ngày Nhận";
            dgvPhieuNhan.Columns["SNguoiNhan"].HeaderText = "Người Nhận";
            dgvPhieuNhan.Columns["IMaDVN"].Visible = false;
            dgvPhieuNhan.Columns["STenDVN"].HeaderText = "Tên Đơn Vị Nhận";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtNguoiNhan.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đày đủ thông tin.", "Thông báo!");
                return;
            }
            PhieuNhanDTO pnDTO = new PhieuNhanDTO();
            pnDTO.DtNgayNhan = DateTime.Parse(dtpNgayNhan.Text);
            pnDTO.SNguoiNhan = txtNguoiNhan.Text;
            pnDTO.IMaDVN = int.Parse(cbDVN.SelectedValue.ToString());
            if (PhieuNhanBLL.ThemPhieuNhan(pnDTO))
            {
                MessageBox.Show("Thêm thành công.", "Thông báo!");
                LoadPhieuNhan();
                return;
            }
            MessageBox.Show("Thêm thất bại.", "Thông báo!");
        }

        private void dgvPhieuNhan_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvPhieuNhan.SelectedRows[0];
            txtMaPN.Text = dr.Cells["IMaPN"].Value.ToString();
            txtNguoiNhan.Text = dr.Cells["SNguoiNhan"].Value.ToString();
            dgvPhieuNhan.Text = dr.Cells["DtNgayNhan"].Value.ToString();
            cbDVN.SelectedValue = int.Parse(dr.Cells["IMaDVN"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPN.Text == "")
            {
                MessageBox.Show("Hãy chọn phiếu cần xóa.", "Thông báo!");
                return;
            }
            PhieuNhanDTO pnDTO = new PhieuNhanDTO();
            pnDTO.IMaPN = int.Parse(txtMaPN.Text);
            if (PhieuNhanBLL.XoaPhieuNhan(pnDTO))
            {
                MessageBox.Show("Xóa thành công.", "Thông báo!");
                LoadPhieuNhan();
                return;
            }
            MessageBox.Show("Xóa thất bại.", "Thông báo!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            PhieuNhanDTO pnDTO = new PhieuNhanDTO();
            pnDTO.IMaPN = int.Parse(txtMaPN.Text);
            pnDTO.DtNgayNhan = DateTime.Parse(dtpNgayNhan.Text);
            pnDTO.SNguoiNhan = txtNguoiNhan.Text;
            pnDTO.IMaDVN = int.Parse(cbDVN.SelectedValue.ToString());
            if (PhieuNhanBLL.SuaPhieuNhan(pnDTO))
            {
                MessageBox.Show("Sửa thành công.", "Thông báo!");
                LoadPhieuNhan();
                return;
            }
            MessageBox.Show("Sửa thất bại.", "Thông báo!");
        }
    }
}

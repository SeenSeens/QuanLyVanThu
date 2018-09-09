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
using DTO;

namespace Presentation
{
    public partial class UIPhieuGui : UserControl
    {
        public UIPhieuGui()
        {
            InitializeComponent();
        }
        private void LoadcbCQ()
        {
            List<CoQuanDTO> lstCQ = CoQuanBLL.LoadcbCQ();
            cbCoQuan.DataSource = lstCQ;
            cbCoQuan.DisplayMember = "sTenCQ";
            cbCoQuan.ValueMember = "iMaCQ";
        }
        private void dgvPhieuGui_Click(object sender, EventArgs e)
        {

            DataGridViewRow dr = dgvPhieuGui.SelectedRows[0];
            txtMaPG.Text = dr.Cells["IMaPG"].Value.ToString();
            txtNguoiGui.Text = dr.Cells["SNguoiGui"].Value.ToString();
            dtpNgayGui.Text = dr.Cells["DtNgayGui"].Value.ToString();
            cbCoQuan.SelectedValue = int.Parse(dr.Cells["IMaCQ"].Value.ToString());
        }

        private void UIPhieuGui_Load(object sender, EventArgs e)
        {
            LoadPhieuGui();
            LoadcbCQ();
        }

        private void LoadPhieuGui()
        {
            List<PhieuGuiDTO> lstPhieuGui = PhieuGuiBLL.LoadPhieuGui();
            dgvPhieuGui.DataSource = lstPhieuGui;
            dgvPhieuGui.Columns["IMaPG"].HeaderText = "Mã Phiếu Gửi";
            dgvPhieuGui.Columns["IMaPG"].Visible = false;
            dgvPhieuGui.Columns["DtNgayGui"].HeaderText = "Ngày Gửi";
            dgvPhieuGui.Columns["SNguoiGui"].HeaderText = "Người Gửi";
            //dgvPhieuGui.Columns["IMaCQ"].HeaderText = " Mã Cơ Quan";
            dgvPhieuGui.Columns["IMaCQ"].Visible = false;
            dgvPhieuGui.Columns["STenCQ"].HeaderText = "Tên Cơ Quan";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtNguoiGui.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đày đủ thông tin.", "Thông báo!");
                return;
            }
            PhieuGuiDTO pgDTO = new PhieuGuiDTO();
            pgDTO.DtNgayGui = DateTime.Parse(dtpNgayGui.Text);
            pgDTO.SNguoiGui = txtNguoiGui.Text;
            pgDTO.IMaCQ = int.Parse(cbCoQuan.SelectedValue.ToString());
            if (PhieuGuiBLL.ThemPhieuGui(pgDTO))
            {
                MessageBox.Show("Thêm thành công.", "Thông báo!");
                LoadPhieuGui();
                return;
            }
            MessageBox.Show("Thêm thất bại.", "Thông báo!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPG.Text == "")
            {
                MessageBox.Show("Hãy chọn đơn vị nhận cần xóa.", "Thông báo!");
                return;
            }
            PhieuGuiDTO pgDTO = new PhieuGuiDTO();
            pgDTO.IMaPG = int.Parse(txtMaPG.Text);
            if (PhieuGuiBLL.XoaPhieuGui(pgDTO))
            {
                MessageBox.Show("Xóa thành công.", "Thông báo!");
                LoadPhieuGui();
                return;
            }
            MessageBox.Show("Xóa thất bại.", "Thông báo!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            PhieuGuiDTO pgDTO = new PhieuGuiDTO();
            pgDTO.IMaPG = int.Parse(txtMaPG.Text);
            pgDTO.DtNgayGui = DateTime.Parse(dtpNgayGui.Text);
            pgDTO.SNguoiGui = txtNguoiGui.Text;
            pgDTO.IMaCQ = int.Parse(cbCoQuan.SelectedValue.ToString());
            if (PhieuGuiBLL.SuaPhieuGui(pgDTO))
            {
                MessageBox.Show("Sửa thành công.", "Thông báo!");
                LoadPhieuGui();
                return;
            }
            MessageBox.Show("Sửa thất bại.", "Thông báo!");
        }
    }
}

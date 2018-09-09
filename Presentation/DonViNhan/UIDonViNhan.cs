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
    public partial class UIDonViNhan : UserControl
    {
        public UIDonViNhan()
        {
            InitializeComponent();
        }
        private void dgvDonvinhan_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvDonvinhan.SelectedRows[0];
            txtMadvn.Text = dr.Cells["IMaDVN"].Value.ToString();
            txtTendvn.Text = dr.Cells["STenDVN"].Value.ToString();
            txtDiachi.Text = dr.Cells["SDiaChi"].Value.ToString();
            txtSdt.Text = dr.Cells["ISDT"].Value.ToString();
            dtpNgaynhan.Text = dr.Cells["DtNgayNhan"].Value.ToString();
            cbCoquan.SelectedValue = int.Parse(dr.Cells["IMaCQ"].Value.ToString());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTendvn.Text == "" || txtDiachi.Text == "" || txtSdt.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đày đủ thông tin.", "Thông báo!");
                return;
            }
            DonViNhanDTO dvnDTO = new DonViNhanDTO();
            dvnDTO.STenDVN = txtTendvn.Text;
            dvnDTO.SDiaChi = txtDiachi.Text;
            dvnDTO.ISDT = int.Parse(txtSdt.Text);
            dvnDTO.DtNgayNhan = DateTime.Parse(dtpNgaynhan.Text);
            dvnDTO.IMaCQ = int.Parse(cbCoquan.SelectedValue.ToString());
            if (DonViNhanBLL.ThemDonViNhan(dvnDTO))
            {
                MessageBox.Show("Thêm thành công.", "Thông báo!");
                LoadDonViNhan();
                return;
            }
            MessageBox.Show("Thêm thất bại.", "Thông báo!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMadvn.Text == "")
            {
                MessageBox.Show("Hãy chọn đơn vị nhận cần xóa.", "Thông báo!");
                return;
            }
            DonViNhanDTO dvnDTO = new DonViNhanDTO();
            dvnDTO.IMaDVN = int.Parse(txtMadvn.Text);
            if (DonViNhanBLL.XoaDonViNhan(dvnDTO))
            {
                MessageBox.Show("Xóa thành công.", "Thông báo!");
                LoadDonViNhan();
                return;
            }
            MessageBox.Show("Xóa thất bại.", "Thông báo!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DonViNhanDTO dvnDTO = new DonViNhanDTO();
            dvnDTO.IMaDVN = int.Parse(txtMadvn.Text);
            dvnDTO.STenDVN = txtTendvn.Text;
            dvnDTO.SDiaChi = txtDiachi.Text;
            dvnDTO.ISDT = int.Parse(txtSdt.Text);
            dvnDTO.DtNgayNhan = DateTime.Parse(dtpNgaynhan.Text);
            dvnDTO.IMaCQ = int.Parse(cbCoquan.SelectedValue.ToString());
            if (DonViNhanBLL.SuaDonViNhan(dvnDTO))
            {
                MessageBox.Show("Sửa thành công.", "Thông báo!");
                LoadDonViNhan();
                return;
            }
            MessageBox.Show("Sửa thất bại.", "Thông báo!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void UIDonViNhan_Load(object sender, EventArgs e)
        {
            LoadDonViNhan();
            LoadcbCQ();
        }
        private void LoadDonViNhan()
        {
            List<DonViNhanDTO> lstDonViNhan = DonViNhanBLL.LoadDonViNhan();
            dgvDonvinhan.DataSource = lstDonViNhan;
            dgvDonvinhan.Columns["IMaDVN"].HeaderText = "Mã Đơn Vị Nhận";
            dgvDonvinhan.Columns["IMaDVN"].Visible = false;
            dgvDonvinhan.Columns["STenDVN"].HeaderText = "Tên Đơn Vị Nhận";
            dgvDonvinhan.Columns["SDiaChi"].HeaderText = "Địa Chỉ";
            dgvDonvinhan.Columns["ISDT"].HeaderText = "Số Điện Thoại";
            dgvDonvinhan.Columns["DtNgayNhan"].HeaderText = "Ngày Nhận";
            dgvDonvinhan.Columns["IMaCQ"].HeaderText = "Mã Cơ Quan";
            dgvDonvinhan.Columns["IMaCQ"].Visible = false;
            dgvDonvinhan.Columns["STenCQ"].HeaderText = "Tên Cơ Quan";
            
        }
        private void LoadcbCQ()
        {
            List<CoQuanDTO> lstCQ = CoQuanBLL.LoadcbCQ();
            cbCoquan.DataSource = lstCQ;
            cbCoquan.DisplayMember = "sTenCQ";
            cbCoquan.ValueMember = "iMaCQ";
        }
    }
}

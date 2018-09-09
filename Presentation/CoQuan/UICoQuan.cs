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
    public partial class UICoQuan : UserControl
    {
        public UICoQuan()
        {
            InitializeComponent();
        }

        private void UICoQuan_Load(object sender, EventArgs e)
        {
            // Load dữ liệu controls datagridview
            LoadCoQuan();
        }

        private void LoadCoQuan()
        {
            List<CoQuanDTO> lstCoQuan = CoQuanBLL.LoadCoQuan();
            dgvCoQuan.DataSource = lstCoQuan;
            // Đặt lại tên cho cột
            dgvCoQuan.Columns["IMaCQ"].HeaderText = "Mã Cơ Quan";
            dgvCoQuan.Columns["IMaCQ"].Visible = false;
            dgvCoQuan.Columns["STenCQ"].HeaderText = "Tên Cơ Quan";
            dgvCoQuan.Columns["SDiaChi"].HeaderText = "Địa Chỉ";
            dgvCoQuan.Columns["ISDT"].HeaderText = "Số Điện Thoại";
            dgvCoQuan.Columns["SNguoiDungDau"].HeaderText = "Người Đứng Đầu";
        }

        private void dgvCoQuan_Click(object sender, EventArgs e)
        {
            // Đưa các dữ liệu từ datagridview lên các control
            DataGridViewRow dr = dgvCoQuan.SelectedRows[0];
            txtMaCQ.Text = dr.Cells["IMaCQ"].Value.ToString();
            txtTenCQ.Text = dr.Cells["STenCQ"].Value.ToString();
            txtDiaChi.Text = dr.Cells["SDiaChi"].Value.ToString();
            txtSDT.Text = dr.Cells["ISDT"].Value.ToString();
            txtNguoiDungDau.Text = dr.Cells["SNguoiDungDau"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của dữ liệu
            if (txtTenCQ.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtNguoiDungDau.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đày đủ thông tin.", "Thông báo!");
                return;
            }
            // Khởi tạo đối tượng CoQuanDTO
            CoQuanDTO cqDTO = new CoQuanDTO();
            cqDTO.STenCQ = txtTenCQ.Text;
            cqDTO.SDiaChi = txtDiaChi.Text;
            cqDTO.ISDT = int.Parse(txtSDT.Text);
            cqDTO.SNguoiDungDau = txtNguoiDungDau.Text;
            // Gọi tới lơp nghiệp vụ CoQuanBLL
            if(CoQuanBLL.ThemCoQuan(cqDTO))
            {
                MessageBox.Show("Thêm thành công.", "Thông báo!");
                LoadCoQuan();
                return;
            }
            MessageBox.Show("Thêm thất bại.", "Thông báo!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaCQ.Text == "")
            {
                MessageBox.Show("Hãy chọn cơ quan cần xóa.", "Thông báo!");
                return;
            }
            // Khởi tạo đối tượng CoQuanDTO
            CoQuanDTO cqDTO = new CoQuanDTO();
            cqDTO.IMaCQ = int.Parse(txtMaCQ.Text);
            // Gọi lớp nghiệp vụ CoQuanBLL
            if (CoQuanBLL.XoaCoQuan(cqDTO))
            {
                MessageBox.Show("Xóa thành công.", "Thông báo!");
                // Load lại dữ liệu
                LoadCoQuan();
                return;
            }
            MessageBox.Show("Xóa thất bại.", "Thông báo!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Khởi tạo đối tượng CoQuanDTO
            CoQuanDTO cqDTO = new CoQuanDTO();
            cqDTO.IMaCQ = int.Parse(txtMaCQ.Text);
            cqDTO.STenCQ = txtTenCQ.Text;
            cqDTO.SDiaChi = txtDiaChi.Text;
            cqDTO.ISDT = int.Parse(txtSDT.Text);
            cqDTO.SNguoiDungDau = txtNguoiDungDau.Text;
            // Gọi lớp nghiệp vụ CoQuanBLL
            if (CoQuanBLL.SuaCoQuan(cqDTO) == true)
            {
                MessageBox.Show("Sửa thành công.", "Thông báo!");
                // Load lại dữ liệu
                LoadCoQuan();
                return;
            }
            MessageBox.Show("Sửa thất bại.", "Thông báo!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.txtMaCQ.Clear();
            this.txtTenCQ.Clear();
            this.txtDiaChi.Clear();
            this.txtSDT.Clear();
            this.txtNguoiDungDau.Clear();
            LoadCoQuan();
        }
    }
}

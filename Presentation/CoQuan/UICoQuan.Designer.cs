namespace Presentation
{
    partial class UICoQuan
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenCQ = new System.Windows.Forms.TextBox();
            this.txtNguoiDungDau = new System.Windows.Forms.TextBox();
            this.txtMaCQ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvCoQuan = new System.Windows.Forms.DataGridView();
            this.search1 = new Presentation.Search();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 133);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtTenCQ);
            this.groupBox1.Controls.Add(this.txtNguoiDungDau);
            this.groupBox1.Controls.Add(this.txtMaCQ);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Cơ Quan";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(551, 35);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(293, 23);
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(551, 82);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(171, 23);
            this.txtSDT.TabIndex = 10;
            // 
            // txtTenCQ
            // 
            this.txtTenCQ.Location = new System.Drawing.Point(162, 57);
            this.txtTenCQ.Name = "txtTenCQ";
            this.txtTenCQ.Size = new System.Drawing.Size(218, 23);
            this.txtTenCQ.TabIndex = 9;
            // 
            // txtNguoiDungDau
            // 
            this.txtNguoiDungDau.Location = new System.Drawing.Point(162, 87);
            this.txtNguoiDungDau.Name = "txtNguoiDungDau";
            this.txtNguoiDungDau.Size = new System.Drawing.Size(218, 23);
            this.txtNguoiDungDau.TabIndex = 8;
            // 
            // txtMaCQ
            // 
            this.txtMaCQ.Location = new System.Drawing.Point(162, 27);
            this.txtMaCQ.Name = "txtMaCQ";
            this.txtMaCQ.ReadOnly = true;
            this.txtMaCQ.Size = new System.Drawing.Size(50, 23);
            this.txtMaCQ.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Người Đứng Đầu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số Điện Thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Cơ Quan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Cơ Quan:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.dgvCoQuan);
            this.panel2.Location = new System.Drawing.Point(3, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 274);
            this.panel2.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.Location = new System.Drawing.Point(251, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 30);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(168, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(84, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Location = new System.Drawing.Point(470, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 30);
            this.panel3.TabIndex = 3;
            // 
            // dgvCoQuan
            // 
            this.dgvCoQuan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCoQuan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCoQuan.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvCoQuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoQuan.Location = new System.Drawing.Point(0, 0);
            this.dgvCoQuan.Name = "dgvCoQuan";
            this.dgvCoQuan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCoQuan.Size = new System.Drawing.Size(876, 274);
            this.dgvCoQuan.TabIndex = 0;
            this.dgvCoQuan.Click += new System.EventHandler(this.dgvCoQuan_Click);
            // 
            // search1
            // 
            this.search1.BackColor = System.Drawing.Color.Transparent;
            this.search1.Location = new System.Drawing.Point(31, 142);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(382, 30);
            this.search1.TabIndex = 4;
            // 
            // UICoQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.search1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UICoQuan";
            this.Size = new System.Drawing.Size(882, 455);
            this.Load += new System.EventHandler(this.UICoQuan_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoQuan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenCQ;
        private System.Windows.Forms.TextBox txtNguoiDungDau;
        private System.Windows.Forms.TextBox txtMaCQ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSDT;
        private Search search1;
        private System.Windows.Forms.DataGridView dgvCoQuan;
    }
}

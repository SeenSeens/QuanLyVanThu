namespace Presentation
{
    partial class UIPhieuNhan
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
            this.cbDVN = new System.Windows.Forms.ComboBox();
            this.dtpNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.txtNguoiNhan = new System.Windows.Forms.TextBox();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPhieuNhan = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhan)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 133);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbDVN);
            this.groupBox1.Controls.Add(this.dtpNgayNhan);
            this.groupBox1.Controls.Add(this.txtNguoiNhan);
            this.groupBox1.Controls.Add(this.txtMaPN);
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
            this.groupBox1.Text = "Thông Tin Phiếu Nhận";
            // 
            // cbDVN
            // 
            this.cbDVN.FormattingEnabled = true;
            this.cbDVN.Location = new System.Drawing.Point(555, 83);
            this.cbDVN.Name = "cbDVN";
            this.cbDVN.Size = new System.Drawing.Size(171, 24);
            this.cbDVN.TabIndex = 20;
            // 
            // dtpNgayNhan
            // 
            this.dtpNgayNhan.Location = new System.Drawing.Point(555, 36);
            this.dtpNgayNhan.Name = "dtpNgayNhan";
            this.dtpNgayNhan.Size = new System.Drawing.Size(238, 23);
            this.dtpNgayNhan.TabIndex = 19;
            // 
            // txtNguoiNhan
            // 
            this.txtNguoiNhan.Location = new System.Drawing.Point(177, 83);
            this.txtNguoiNhan.Name = "txtNguoiNhan";
            this.txtNguoiNhan.Size = new System.Drawing.Size(171, 23);
            this.txtNguoiNhan.TabIndex = 18;
            // 
            // txtMaPN
            // 
            this.txtMaPN.Location = new System.Drawing.Point(177, 38);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.ReadOnly = true;
            this.txtMaPN.Size = new System.Drawing.Size(50, 23);
            this.txtMaPN.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Người Nhận:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Đơn Vị Nhận:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ngày Nhận:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã Phiếu Nhận:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.dgvPhieuNhan);
            this.panel2.Location = new System.Drawing.Point(3, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 274);
            this.panel2.TabIndex = 1;
            // 
            // dgvPhieuNhan
            // 
            this.dgvPhieuNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuNhan.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvPhieuNhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhieuNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuNhan.Location = new System.Drawing.Point(0, 0);
            this.dgvPhieuNhan.Name = "dgvPhieuNhan";
            this.dgvPhieuNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuNhan.Size = new System.Drawing.Size(876, 274);
            this.dgvPhieuNhan.TabIndex = 0;
            this.dgvPhieuNhan.Click += new System.EventHandler(this.dgvPhieuNhan_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Location = new System.Drawing.Point(508, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 30);
            this.panel3.TabIndex = 7;
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
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.Location = new System.Drawing.Point(251, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 30);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // UIPhieuNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UIPhieuNhan";
            this.Size = new System.Drawing.Size(882, 455);
            this.Load += new System.EventHandler(this.UIPhieuNhan_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDVN;
        private System.Windows.Forms.DateTimePicker dtpNgayNhan;
        private System.Windows.Forms.TextBox txtNguoiNhan;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPhieuNhan;
    }
}

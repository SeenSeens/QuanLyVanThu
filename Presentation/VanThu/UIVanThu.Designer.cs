namespace Presentation
{
    partial class UIVanThu
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
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.txtMaVanThu = new System.Windows.Forms.TextBox();
            this.cbLinhVuc = new System.Windows.Forms.ComboBox();
            this.cbCoQuan = new System.Windows.Forms.ComboBox();
            this.cbLoaiCongVan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvVanThu = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVanThu)).BeginInit();
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
            this.groupBox1.Controls.Add(this.txtTieuDe);
            this.groupBox1.Controls.Add(this.txtMaVanThu);
            this.groupBox1.Controls.Add(this.cbLinhVuc);
            this.groupBox1.Controls.Add(this.cbCoQuan);
            this.groupBox1.Controls.Add(this.cbLoaiCongVan);
            this.groupBox1.Controls.Add(this.label6);
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
            this.groupBox1.Text = "Thông Tin Văn Thư:";
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Location = new System.Drawing.Point(164, 60);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(293, 23);
            this.txtTieuDe.TabIndex = 17;
            // 
            // txtMaVanThu
            // 
            this.txtMaVanThu.Location = new System.Drawing.Point(164, 26);
            this.txtMaVanThu.Name = "txtMaVanThu";
            this.txtMaVanThu.ReadOnly = true;
            this.txtMaVanThu.Size = new System.Drawing.Size(50, 23);
            this.txtMaVanThu.TabIndex = 16;
            // 
            // cbLinhVuc
            // 
            this.cbLinhVuc.Enabled = false;
            this.cbLinhVuc.FormattingEnabled = true;
            this.cbLinhVuc.Location = new System.Drawing.Point(616, 82);
            this.cbLinhVuc.Name = "cbLinhVuc";
            this.cbLinhVuc.Size = new System.Drawing.Size(171, 24);
            this.cbLinhVuc.TabIndex = 14;
            this.cbLinhVuc.Text = "Tính năng này tạm thời chưa cần";
            // 
            // cbCoQuan
            // 
            this.cbCoQuan.FormattingEnabled = true;
            this.cbCoQuan.Location = new System.Drawing.Point(616, 26);
            this.cbCoQuan.Name = "cbCoQuan";
            this.cbCoQuan.Size = new System.Drawing.Size(171, 24);
            this.cbCoQuan.TabIndex = 13;
            // 
            // cbLoaiCongVan
            // 
            this.cbLoaiCongVan.FormattingEnabled = true;
            this.cbLoaiCongVan.Location = new System.Drawing.Point(164, 94);
            this.cbLoaiCongVan.Name = "cbLoaiCongVan";
            this.cbLoaiCongVan.Size = new System.Drawing.Size(171, 24);
            this.cbLoaiCongVan.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(524, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Lĩnh Vực:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Loại Công Văn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cơ Quan:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tiêu Đề:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Văn Thư:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.dgvVanThu);
            this.panel2.Location = new System.Drawing.Point(3, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 274);
            this.panel2.TabIndex = 1;
            // 
            // dgvVanThu
            // 
            this.dgvVanThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVanThu.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvVanThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVanThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVanThu.Location = new System.Drawing.Point(0, 0);
            this.dgvVanThu.Name = "dgvVanThu";
            this.dgvVanThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVanThu.Size = new System.Drawing.Size(876, 274);
            this.dgvVanThu.TabIndex = 0;
            this.dgvVanThu.Click += new System.EventHandler(this.dgvVanThu_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Location = new System.Drawing.Point(521, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 30);
            this.panel3.TabIndex = 8;
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
            // UIVanThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UIVanThu";
            this.Size = new System.Drawing.Size(882, 455);
            this.Load += new System.EventHandler(this.UIVanThu_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVanThu)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLinhVuc;
        private System.Windows.Forms.ComboBox cbCoQuan;
        private System.Windows.Forms.ComboBox cbLoaiCongVan;
        private System.Windows.Forms.TextBox txtMaVanThu;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.DataGridView dgvVanThu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

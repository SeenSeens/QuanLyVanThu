namespace Presentation
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnHori = new System.Windows.Forms.Panel();
            this.Main = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CoQuan = new System.Windows.Forms.ToolStripMenuItem();
            this.DonViNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.LoaiCongVan = new System.Windows.Forms.ToolStripMenuItem();
            this.PhieuGui = new System.Windows.Forms.ToolStripMenuItem();
            this.PhieuNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.VanThu = new System.Windows.Forms.ToolStripMenuItem();
            this.Title = new System.Windows.Forms.Panel();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHori
            // 
            this.pnHori.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnHori.BackColor = System.Drawing.Color.Transparent;
            this.pnHori.Location = new System.Drawing.Point(12, 107);
            this.pnHori.Name = "pnHori";
            this.pnHori.Size = new System.Drawing.Size(140, 488);
            this.pnHori.TabIndex = 1;
            // 
            // Main
            // 
            this.Main.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Main.BackColor = System.Drawing.Color.Transparent;
            this.Main.Location = new System.Drawing.Point(160, 107);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(882, 455);
            this.Main.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CoQuan,
            this.DonViNhan,
            this.LoaiCongVan,
            this.PhieuGui,
            this.PhieuNhan,
            this.VanThu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CoQuan
            // 
            this.CoQuan.Name = "CoQuan";
            this.CoQuan.Size = new System.Drawing.Size(124, 20);
            this.CoQuan.Text = "Danh Mục Cơ Quan";
            this.CoQuan.Click += new System.EventHandler(this.CoQuan_Click);
            // 
            // DonViNhan
            // 
            this.DonViNhan.Name = "DonViNhan";
            this.DonViNhan.Size = new System.Drawing.Size(144, 20);
            this.DonViNhan.Text = "Danh Mục Đơn Vị Nhận";
            this.DonViNhan.Click += new System.EventHandler(this.DonViNhan_Click);
            // 
            // LoaiCongVan
            // 
            this.LoaiCongVan.Name = "LoaiCongVan";
            this.LoaiCongVan.Size = new System.Drawing.Size(153, 20);
            this.LoaiCongVan.Text = "Danh Mục Loại Công Văn";
            this.LoaiCongVan.Click += new System.EventHandler(this.LoaiCongVan_Click);
            // 
            // PhieuGui
            // 
            this.PhieuGui.Name = "PhieuGui";
            this.PhieuGui.Size = new System.Drawing.Size(128, 20);
            this.PhieuGui.Text = "Danh Mục Phiếu Gửi";
            this.PhieuGui.Click += new System.EventHandler(this.PhieuGui_Click);
            // 
            // PhieuNhan
            // 
            this.PhieuNhan.Name = "PhieuNhan";
            this.PhieuNhan.Size = new System.Drawing.Size(139, 20);
            this.PhieuNhan.Text = "Danh Mục Phiếu Nhận";
            this.PhieuNhan.Click += new System.EventHandler(this.PhieuNhan_Click);
            // 
            // VanThu
            // 
            this.VanThu.Name = "VanThu";
            this.VanThu.Size = new System.Drawing.Size(120, 20);
            this.VanThu.Text = "Danh Mục Vãn Thư";
            this.VanThu.Click += new System.EventHandler(this.VanThu_Click);
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Location = new System.Drawing.Point(12, 58);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1030, 43);
            this.Title.TabIndex = 4;
            // 
            // pnBottom
            // 
            this.pnBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnBottom.Location = new System.Drawing.Point(160, 568);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(882, 27);
            this.pnBottom.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Presentation.Properties.Resources._39919952_700168793681035_1762591691367251968_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 607);
            this.Controls.Add(this.pnBottom);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.pnHori);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Văn Thư";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnHori;
        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CoQuan;
        private System.Windows.Forms.ToolStripMenuItem DonViNhan;
        private System.Windows.Forms.ToolStripMenuItem LoaiCongVan;
        private System.Windows.Forms.ToolStripMenuItem PhieuGui;
        private System.Windows.Forms.ToolStripMenuItem PhieuNhan;
        private System.Windows.Forms.ToolStripMenuItem VanThu;
        private System.Windows.Forms.Panel Title;
        private System.Windows.Forms.Panel pnBottom;
    }
}


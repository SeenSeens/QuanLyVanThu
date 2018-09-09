namespace Presentation
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKiemtraket = new System.Windows.Forms.Button();
            this.btnKetnoi = new System.Windows.Forms.Button();
            this.btnHuybo = new System.Windows.Forms.Button();
            this.cbTenmaychu = new System.Windows.Forms.ComboBox();
            this.cbCSDL = new System.Windows.Forms.ComboBox();
            this.cbAuthentication = new System.Windows.Forms.ComboBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên máy chủ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CSDL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Authentication:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Login:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "CƠ SỞ DỮ LIỆU";
            // 
            // btnKiemtraket
            // 
            this.btnKiemtraket.Location = new System.Drawing.Point(13, 256);
            this.btnKiemtraket.Name = "btnKiemtraket";
            this.btnKiemtraket.Size = new System.Drawing.Size(75, 23);
            this.btnKiemtraket.TabIndex = 6;
            this.btnKiemtraket.Text = "Kiểm tra kết nối";
            this.btnKiemtraket.UseVisualStyleBackColor = true;
            // 
            // btnKetnoi
            // 
            this.btnKetnoi.Location = new System.Drawing.Point(119, 256);
            this.btnKetnoi.Name = "btnKetnoi";
            this.btnKetnoi.Size = new System.Drawing.Size(75, 23);
            this.btnKetnoi.TabIndex = 7;
            this.btnKetnoi.Text = "Kết nối";
            this.btnKetnoi.UseVisualStyleBackColor = true;
            // 
            // btnHuybo
            // 
            this.btnHuybo.Location = new System.Drawing.Point(225, 256);
            this.btnHuybo.Name = "btnHuybo";
            this.btnHuybo.Size = new System.Drawing.Size(75, 23);
            this.btnHuybo.TabIndex = 8;
            this.btnHuybo.Text = "Hủy bỏ";
            this.btnHuybo.UseVisualStyleBackColor = true;
            // 
            // cbTenmaychu
            // 
            this.cbTenmaychu.FormattingEnabled = true;
            this.cbTenmaychu.Location = new System.Drawing.Point(103, 59);
            this.cbTenmaychu.Name = "cbTenmaychu";
            this.cbTenmaychu.Size = new System.Drawing.Size(186, 21);
            this.cbTenmaychu.TabIndex = 9;
            // 
            // cbCSDL
            // 
            this.cbCSDL.FormattingEnabled = true;
            this.cbCSDL.Location = new System.Drawing.Point(103, 99);
            this.cbCSDL.Name = "cbCSDL";
            this.cbCSDL.Size = new System.Drawing.Size(186, 21);
            this.cbCSDL.TabIndex = 10;
            // 
            // cbAuthentication
            // 
            this.cbAuthentication.FormattingEnabled = true;
            this.cbAuthentication.Location = new System.Drawing.Point(103, 139);
            this.cbAuthentication.Name = "cbAuthentication";
            this.cbAuthentication.Size = new System.Drawing.Size(186, 21);
            this.cbAuthentication.TabIndex = 10;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(119, 177);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(170, 20);
            this.txtLogin.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(119, 211);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(169, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 294);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.cbAuthentication);
            this.Controls.Add(this.cbCSDL);
            this.Controls.Add(this.cbTenmaychu);
            this.Controls.Add(this.btnHuybo);
            this.Controls.Add(this.btnKetnoi);
            this.Controls.Add(this.btnKiemtraket);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết nối";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKiemtraket;
        private System.Windows.Forms.Button btnKetnoi;
        private System.Windows.Forms.Button btnHuybo;
        private System.Windows.Forms.ComboBox cbTenmaychu;
        private System.Windows.Forms.ComboBox cbCSDL;
        private System.Windows.Forms.ComboBox cbAuthentication;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
    }
}
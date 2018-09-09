namespace Presentation.VanThu
{
    partial class OptionsVanThu
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
            this.Option = new System.Windows.Forms.GroupBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Option.SuspendLayout();
            this.SuspendLayout();
            // 
            // Option
            // 
            this.Option.BackColor = System.Drawing.Color.Transparent;
            this.Option.Controls.Add(this.label1);
            this.Option.Controls.Add(this.txtKey);
            this.Option.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Option.Location = new System.Drawing.Point(0, 0);
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(140, 488);
            this.Option.TabIndex = 0;
            this.Option.TabStop = false;
            this.Option.Text = "Option";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(6, 84);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(128, 36);
            this.txtKey.TabIndex = 0;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(17, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            // 
            // OptionsVanThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Option);
            this.Name = "OptionsVanThu";
            this.Size = new System.Drawing.Size(140, 488);
            this.Option.ResumeLayout(false);
            this.Option.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Option;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKey;
    }
}

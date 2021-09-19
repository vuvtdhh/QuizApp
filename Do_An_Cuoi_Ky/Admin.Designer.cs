namespace Do_An_Cuoi_Ky
{
    partial class frmAdmin
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
            this.btnQuanLyNguoiDung = new System.Windows.Forms.Button();
            this.btnQuanLyHeThong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuanLyNguoiDung
            // 
            this.btnQuanLyNguoiDung.Location = new System.Drawing.Point(12, 12);
            this.btnQuanLyNguoiDung.Name = "btnQuanLyNguoiDung";
            this.btnQuanLyNguoiDung.Size = new System.Drawing.Size(156, 57);
            this.btnQuanLyNguoiDung.TabIndex = 0;
            this.btnQuanLyNguoiDung.Text = "Quản Lý Người Dùng";
            this.btnQuanLyNguoiDung.UseVisualStyleBackColor = true;
            this.btnQuanLyNguoiDung.Click += new System.EventHandler(this.btnQuanLyNguoiDung_Click);
            // 
            // btnQuanLyHeThong
            // 
            this.btnQuanLyHeThong.Location = new System.Drawing.Point(192, 12);
            this.btnQuanLyHeThong.Name = "btnQuanLyHeThong";
            this.btnQuanLyHeThong.Size = new System.Drawing.Size(156, 57);
            this.btnQuanLyHeThong.TabIndex = 1;
            this.btnQuanLyHeThong.Text = "Quản Lý Hệ Thống";
            this.btnQuanLyHeThong.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 83);
            this.Controls.Add(this.btnQuanLyHeThong);
            this.Controls.Add(this.btnQuanLyNguoiDung);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmin_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuanLyNguoiDung;
        private System.Windows.Forms.Button btnQuanLyHeThong;
    }
}
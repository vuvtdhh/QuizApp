namespace Do_An_Cuoi_Ky
{
    partial class frmQuanLyHocSinh
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
            this.gvThongKe = new System.Windows.Forms.DataGridView();
            this.btnHocSinh = new System.Windows.Forms.Button();
            this.btnKyThi = new System.Windows.Forms.Button();
            this.btnCauHoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // gvThongKe
            // 
            this.gvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvThongKe.Location = new System.Drawing.Point(12, 11);
            this.gvThongKe.Name = "gvThongKe";
            this.gvThongKe.Size = new System.Drawing.Size(768, 289);
            this.gvThongKe.TabIndex = 0;
            // 
            // btnHocSinh
            // 
            this.btnHocSinh.Location = new System.Drawing.Point(69, 317);
            this.btnHocSinh.Name = "btnHocSinh";
            this.btnHocSinh.Size = new System.Drawing.Size(124, 30);
            this.btnHocSinh.TabIndex = 1;
            this.btnHocSinh.Text = "Học Sinh";
            this.btnHocSinh.UseVisualStyleBackColor = true;
            this.btnHocSinh.Click += new System.EventHandler(this.btnHocSinh_Click);
            // 
            // btnKyThi
            // 
            this.btnKyThi.Location = new System.Drawing.Point(327, 317);
            this.btnKyThi.Name = "btnKyThi";
            this.btnKyThi.Size = new System.Drawing.Size(124, 30);
            this.btnKyThi.TabIndex = 2;
            this.btnKyThi.Text = "Kỳ Thi";
            this.btnKyThi.UseVisualStyleBackColor = true;
            this.btnKyThi.Click += new System.EventHandler(this.btnKyThi_Click);
            // 
            // btnCauHoi
            // 
            this.btnCauHoi.Location = new System.Drawing.Point(579, 317);
            this.btnCauHoi.Name = "btnCauHoi";
            this.btnCauHoi.Size = new System.Drawing.Size(124, 30);
            this.btnCauHoi.TabIndex = 3;
            this.btnCauHoi.Text = "Câu Hỏi";
            this.btnCauHoi.UseVisualStyleBackColor = true;
            this.btnCauHoi.Click += new System.EventHandler(this.btnCauHoi_Click);
            // 
            // frmQuanLyHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 359);
            this.Controls.Add(this.btnCauHoi);
            this.Controls.Add(this.btnKyThi);
            this.Controls.Add(this.btnHocSinh);
            this.Controls.Add(this.gvThongKe);
            this.Name = "frmQuanLyHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Học Sinh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyHocSinh_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLyHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvThongKe;
        private System.Windows.Forms.Button btnHocSinh;
        private System.Windows.Forms.Button btnKyThi;
        private System.Windows.Forms.Button btnCauHoi;
    }
}
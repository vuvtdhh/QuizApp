namespace Do_An_Cuoi_Ky
{
    partial class frmQuanLyKyThiThu
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
            this.gbTaoKyThi = new System.Windows.Forms.GroupBox();
            this.btnTaoKyThiThu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaKyThi = new System.Windows.Forms.TextBox();
            this.pickerDenNgay = new System.Windows.Forms.DateTimePicker();
            this.pickerTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbThiSinh = new System.Windows.Forms.GroupBox();
            this.gvThiSinh = new System.Windows.Forms.DataGridView();
            this.gbDeThi = new System.Windows.Forms.GroupBox();
            this.gvDeThi = new System.Windows.Forms.DataGridView();
            this.gbKyThi = new System.Windows.Forms.GroupBox();
            this.gvKyThi = new System.Windows.Forms.DataGridView();
            this.btnThemThiSinh = new System.Windows.Forms.Button();
            this.btnXoaKyThi = new System.Windows.Forms.Button();
            this.btnThemDe = new System.Windows.Forms.Button();
            this.gbTaoKyThi.SuspendLayout();
            this.gbThiSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvThiSinh)).BeginInit();
            this.gbDeThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeThi)).BeginInit();
            this.gbKyThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvKyThi)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTaoKyThi
            // 
            this.gbTaoKyThi.Controls.Add(this.btnTaoKyThiThu);
            this.gbTaoKyThi.Controls.Add(this.label3);
            this.gbTaoKyThi.Controls.Add(this.txtMaKyThi);
            this.gbTaoKyThi.Controls.Add(this.pickerDenNgay);
            this.gbTaoKyThi.Controls.Add(this.pickerTuNgay);
            this.gbTaoKyThi.Controls.Add(this.label2);
            this.gbTaoKyThi.Controls.Add(this.label1);
            this.gbTaoKyThi.Location = new System.Drawing.Point(12, 10);
            this.gbTaoKyThi.Name = "gbTaoKyThi";
            this.gbTaoKyThi.Size = new System.Drawing.Size(747, 142);
            this.gbTaoKyThi.TabIndex = 0;
            this.gbTaoKyThi.TabStop = false;
            this.gbTaoKyThi.Text = "Tạo Kỳ Thi:";
            // 
            // btnTaoKyThiThu
            // 
            this.btnTaoKyThiThu.Location = new System.Drawing.Point(433, 83);
            this.btnTaoKyThiThu.Name = "btnTaoKyThiThu";
            this.btnTaoKyThiThu.Size = new System.Drawing.Size(143, 23);
            this.btnTaoKyThiThu.TabIndex = 4;
            this.btnTaoKyThiThu.Text = "Tạo Kỳ Thi Thử";
            this.btnTaoKyThiThu.UseVisualStyleBackColor = true;
            this.btnTaoKyThiThu.Click += new System.EventHandler(this.btnTaoKyThiThu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã Kỳ Thi:";
            // 
            // txtMaKyThi
            // 
            this.txtMaKyThi.Location = new System.Drawing.Point(433, 40);
            this.txtMaKyThi.Name = "txtMaKyThi";
            this.txtMaKyThi.Size = new System.Drawing.Size(143, 20);
            this.txtMaKyThi.TabIndex = 3;
            // 
            // pickerDenNgay
            // 
            this.pickerDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerDenNgay.Location = new System.Drawing.Point(150, 86);
            this.pickerDenNgay.Name = "pickerDenNgay";
            this.pickerDenNgay.Size = new System.Drawing.Size(143, 20);
            this.pickerDenNgay.TabIndex = 2;
            // 
            // pickerTuNgay
            // 
            this.pickerTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerTuNgay.Location = new System.Drawing.Point(150, 41);
            this.pickerTuNgay.Name = "pickerTuNgay";
            this.pickerTuNgay.Size = new System.Drawing.Size(143, 20);
            this.pickerTuNgay.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày:";
            // 
            // gbThiSinh
            // 
            this.gbThiSinh.Controls.Add(this.gvThiSinh);
            this.gbThiSinh.Location = new System.Drawing.Point(10, 158);
            this.gbThiSinh.Name = "gbThiSinh";
            this.gbThiSinh.Size = new System.Drawing.Size(407, 205);
            this.gbThiSinh.TabIndex = 1;
            this.gbThiSinh.TabStop = false;
            this.gbThiSinh.Text = "Thí Sinh:";
            // 
            // gvThiSinh
            // 
            this.gvThiSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvThiSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvThiSinh.Location = new System.Drawing.Point(6, 19);
            this.gvThiSinh.Name = "gvThiSinh";
            this.gvThiSinh.Size = new System.Drawing.Size(395, 180);
            this.gvThiSinh.TabIndex = 0;
            // 
            // gbDeThi
            // 
            this.gbDeThi.Controls.Add(this.gvDeThi);
            this.gbDeThi.Location = new System.Drawing.Point(423, 158);
            this.gbDeThi.Name = "gbDeThi";
            this.gbDeThi.Size = new System.Drawing.Size(332, 205);
            this.gbDeThi.TabIndex = 2;
            this.gbDeThi.TabStop = false;
            this.gbDeThi.Text = "Đề Thi:";
            // 
            // gvDeThi
            // 
            this.gvDeThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDeThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDeThi.Location = new System.Drawing.Point(6, 19);
            this.gvDeThi.Name = "gvDeThi";
            this.gvDeThi.Size = new System.Drawing.Size(320, 180);
            this.gvDeThi.TabIndex = 0;
            // 
            // gbKyThi
            // 
            this.gbKyThi.Controls.Add(this.gvKyThi);
            this.gbKyThi.Location = new System.Drawing.Point(16, 411);
            this.gbKyThi.Name = "gbKyThi";
            this.gbKyThi.Size = new System.Drawing.Size(747, 166);
            this.gbKyThi.TabIndex = 3;
            this.gbKyThi.TabStop = false;
            this.gbKyThi.Text = "Kỳ Thi:";
            // 
            // gvKyThi
            // 
            this.gvKyThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvKyThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvKyThi.Location = new System.Drawing.Point(6, 19);
            this.gvKyThi.Name = "gvKyThi";
            this.gvKyThi.Size = new System.Drawing.Size(731, 141);
            this.gvKyThi.TabIndex = 0;
            // 
            // btnThemThiSinh
            // 
            this.btnThemThiSinh.Location = new System.Drawing.Point(122, 369);
            this.btnThemThiSinh.Name = "btnThemThiSinh";
            this.btnThemThiSinh.Size = new System.Drawing.Size(153, 41);
            this.btnThemThiSinh.TabIndex = 5;
            this.btnThemThiSinh.Text = "Thêm Thí Sinh Vào Kỳ Thi";
            this.btnThemThiSinh.UseVisualStyleBackColor = true;
            this.btnThemThiSinh.Click += new System.EventHandler(this.btnThemThiSinh_Click);
            // 
            // btnXoaKyThi
            // 
            this.btnXoaKyThi.Location = new System.Drawing.Point(337, 369);
            this.btnXoaKyThi.Name = "btnXoaKyThi";
            this.btnXoaKyThi.Size = new System.Drawing.Size(153, 41);
            this.btnXoaKyThi.TabIndex = 6;
            this.btnXoaKyThi.Text = "Xóa Kỳ Thi";
            this.btnXoaKyThi.UseVisualStyleBackColor = true;
            this.btnXoaKyThi.Click += new System.EventHandler(this.btnXoaKyThi_Click);
            // 
            // btnThemDe
            // 
            this.btnThemDe.Location = new System.Drawing.Point(530, 369);
            this.btnThemDe.Name = "btnThemDe";
            this.btnThemDe.Size = new System.Drawing.Size(153, 41);
            this.btnThemDe.TabIndex = 7;
            this.btnThemDe.Text = "Thêm Đề Vào Kỳ Thi";
            this.btnThemDe.UseVisualStyleBackColor = true;
            this.btnThemDe.Click += new System.EventHandler(this.btnThemDe_Click);
            // 
            // frmQuanLyKyThiThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 579);
            this.Controls.Add(this.btnThemDe);
            this.Controls.Add(this.btnXoaKyThi);
            this.Controls.Add(this.btnThemThiSinh);
            this.Controls.Add(this.gbKyThi);
            this.Controls.Add(this.gbDeThi);
            this.Controls.Add(this.gbThiSinh);
            this.Controls.Add(this.gbTaoKyThi);
            this.Name = "frmQuanLyKyThiThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Kỳ Thi Thử";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyKyThiThu_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLyKyThiThu_Load);
            this.gbTaoKyThi.ResumeLayout(false);
            this.gbTaoKyThi.PerformLayout();
            this.gbThiSinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvThiSinh)).EndInit();
            this.gbDeThi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDeThi)).EndInit();
            this.gbKyThi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvKyThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTaoKyThi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTaoKyThiThu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaKyThi;
        private System.Windows.Forms.DateTimePicker pickerDenNgay;
        private System.Windows.Forms.DateTimePicker pickerTuNgay;
        private System.Windows.Forms.GroupBox gbThiSinh;
        private System.Windows.Forms.DataGridView gvThiSinh;
        private System.Windows.Forms.GroupBox gbDeThi;
        private System.Windows.Forms.DataGridView gvDeThi;
        private System.Windows.Forms.GroupBox gbKyThi;
        private System.Windows.Forms.DataGridView gvKyThi;
        private System.Windows.Forms.Button btnThemThiSinh;
        private System.Windows.Forms.Button btnXoaKyThi;
        private System.Windows.Forms.Button btnThemDe;
    }
}
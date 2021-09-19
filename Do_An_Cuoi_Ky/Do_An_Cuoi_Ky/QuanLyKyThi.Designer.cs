namespace Do_An_Cuoi_Ky
{
    partial class frmQuanLyKyThi
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
            this.gbThiSinh = new System.Windows.Forms.GroupBox();
            this.gvThiSinh = new System.Windows.Forms.DataGridView();
            this.gbDeThi = new System.Windows.Forms.GroupBox();
            this.gvDeThi = new System.Windows.Forms.DataGridView();
            this.gbKyThi = new System.Windows.Forms.GroupBox();
            this.gvKyThi = new System.Windows.Forms.DataGridView();
            this.btnTaoKyThi = new System.Windows.Forms.Button();
            this.btnThemDe = new System.Windows.Forms.Button();
            this.btnThemThiSinh = new System.Windows.Forms.Button();
            this.gbTaoKyThi = new System.Windows.Forms.GroupBox();
            this.pickerNgayThi = new System.Windows.Forms.DateTimePicker();
            this.txtMaKyThi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoaKyThi = new System.Windows.Forms.Button();
            this.gbThiSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvThiSinh)).BeginInit();
            this.gbDeThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeThi)).BeginInit();
            this.gbKyThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvKyThi)).BeginInit();
            this.gbTaoKyThi.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbThiSinh
            // 
            this.gbThiSinh.Controls.Add(this.gvThiSinh);
            this.gbThiSinh.Location = new System.Drawing.Point(12, 157);
            this.gbThiSinh.Name = "gbThiSinh";
            this.gbThiSinh.Size = new System.Drawing.Size(407, 205);
            this.gbThiSinh.TabIndex = 0;
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
            this.gbDeThi.Location = new System.Drawing.Point(435, 157);
            this.gbDeThi.Name = "gbDeThi";
            this.gbDeThi.Size = new System.Drawing.Size(332, 205);
            this.gbDeThi.TabIndex = 1;
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
            this.gbKyThi.Location = new System.Drawing.Point(18, 425);
            this.gbKyThi.Name = "gbKyThi";
            this.gbKyThi.Size = new System.Drawing.Size(755, 166);
            this.gbKyThi.TabIndex = 2;
            this.gbKyThi.TabStop = false;
            this.gbKyThi.Text = "Kỳ Thi:";
            // 
            // gvKyThi
            // 
            this.gvKyThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvKyThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvKyThi.Location = new System.Drawing.Point(6, 19);
            this.gvKyThi.Name = "gvKyThi";
            this.gvKyThi.Size = new System.Drawing.Size(743, 141);
            this.gvKyThi.TabIndex = 0;
            this.gvKyThi.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gvKyThi_CellBeginEdit);
            this.gvKyThi.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvKyThi_CellValueChanged);
            this.gvKyThi.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvKyThi_RowLeave);
            // 
            // btnTaoKyThi
            // 
            this.btnTaoKyThi.Location = new System.Drawing.Point(423, 49);
            this.btnTaoKyThi.Name = "btnTaoKyThi";
            this.btnTaoKyThi.Size = new System.Drawing.Size(144, 38);
            this.btnTaoKyThi.TabIndex = 3;
            this.btnTaoKyThi.Text = "Tạo Mới Kỳ Thi";
            this.btnTaoKyThi.UseVisualStyleBackColor = true;
            this.btnTaoKyThi.Click += new System.EventHandler(this.btnTaoKyThi_Click);
            // 
            // btnThemDe
            // 
            this.btnThemDe.Location = new System.Drawing.Point(535, 378);
            this.btnThemDe.Name = "btnThemDe";
            this.btnThemDe.Size = new System.Drawing.Size(153, 41);
            this.btnThemDe.TabIndex = 6;
            this.btnThemDe.Text = "Thêm Đề Vào Kỳ Thi";
            this.btnThemDe.UseVisualStyleBackColor = true;
            this.btnThemDe.Click += new System.EventHandler(this.btnThemDe_Click);
            // 
            // btnThemThiSinh
            // 
            this.btnThemThiSinh.Location = new System.Drawing.Point(123, 378);
            this.btnThemThiSinh.Name = "btnThemThiSinh";
            this.btnThemThiSinh.Size = new System.Drawing.Size(153, 41);
            this.btnThemThiSinh.TabIndex = 4;
            this.btnThemThiSinh.Text = "Thêm Thí Sinh Vào Kỳ Thi";
            this.btnThemThiSinh.UseVisualStyleBackColor = true;
            this.btnThemThiSinh.Click += new System.EventHandler(this.btnThemThiSinh_Click);
            // 
            // gbTaoKyThi
            // 
            this.gbTaoKyThi.Controls.Add(this.pickerNgayThi);
            this.gbTaoKyThi.Controls.Add(this.txtMaKyThi);
            this.gbTaoKyThi.Controls.Add(this.label2);
            this.gbTaoKyThi.Controls.Add(this.label1);
            this.gbTaoKyThi.Controls.Add(this.btnTaoKyThi);
            this.gbTaoKyThi.Location = new System.Drawing.Point(18, 12);
            this.gbTaoKyThi.Name = "gbTaoKyThi";
            this.gbTaoKyThi.Size = new System.Drawing.Size(743, 139);
            this.gbTaoKyThi.TabIndex = 6;
            this.gbTaoKyThi.TabStop = false;
            this.gbTaoKyThi.Text = "Tạo Mới Kỳ Thi:";
            // 
            // pickerNgayThi
            // 
            this.pickerNgayThi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerNgayThi.Location = new System.Drawing.Point(192, 84);
            this.pickerNgayThi.Name = "pickerNgayThi";
            this.pickerNgayThi.Size = new System.Drawing.Size(144, 20);
            this.pickerNgayThi.TabIndex = 2;
            // 
            // txtMaKyThi
            // 
            this.txtMaKyThi.Location = new System.Drawing.Point(192, 32);
            this.txtMaKyThi.Name = "txtMaKyThi";
            this.txtMaKyThi.Size = new System.Drawing.Size(144, 20);
            this.txtMaKyThi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày Thi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Kỳ Thi:";
            // 
            // btnXoaKyThi
            // 
            this.btnXoaKyThi.Location = new System.Drawing.Point(333, 378);
            this.btnXoaKyThi.Name = "btnXoaKyThi";
            this.btnXoaKyThi.Size = new System.Drawing.Size(153, 41);
            this.btnXoaKyThi.TabIndex = 5;
            this.btnXoaKyThi.Text = "Xóa Kỳ Thi";
            this.btnXoaKyThi.UseVisualStyleBackColor = true;
            this.btnXoaKyThi.Click += new System.EventHandler(this.btnXoaKyThi_Click);
            // 
            // frmQuanLyKyThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 603);
            this.Controls.Add(this.btnXoaKyThi);
            this.Controls.Add(this.gbTaoKyThi);
            this.Controls.Add(this.btnThemThiSinh);
            this.Controls.Add(this.btnThemDe);
            this.Controls.Add(this.gbKyThi);
            this.Controls.Add(this.gbDeThi);
            this.Controls.Add(this.gbThiSinh);
            this.Name = "frmQuanLyKyThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Kỳ Thi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyKyThi_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLyKyThi_Load);
            this.gbThiSinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvThiSinh)).EndInit();
            this.gbDeThi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDeThi)).EndInit();
            this.gbKyThi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvKyThi)).EndInit();
            this.gbTaoKyThi.ResumeLayout(false);
            this.gbTaoKyThi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThiSinh;
        private System.Windows.Forms.DataGridView gvThiSinh;
        private System.Windows.Forms.GroupBox gbDeThi;
        private System.Windows.Forms.GroupBox gbKyThi;
        private System.Windows.Forms.Button btnTaoKyThi;
        private System.Windows.Forms.Button btnThemDe;
        private System.Windows.Forms.Button btnThemThiSinh;
        private System.Windows.Forms.DataGridView gvDeThi;
        private System.Windows.Forms.DataGridView gvKyThi;
        private System.Windows.Forms.GroupBox gbTaoKyThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKyThi;
        private System.Windows.Forms.DateTimePicker pickerNgayThi;
        private System.Windows.Forms.Button btnXoaKyThi;
    }
}
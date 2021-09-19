namespace Do_An_Cuoi_Ky
{
    partial class frmQuanLyDeThi
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
            this.cbbTheoMonHoc = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHuongDan = new System.Windows.Forms.Button();
            this.gvCauHoi = new System.Windows.Forms.DataGridView();
            this.cbbTheoDoKho = new System.Windows.Forms.ComboBox();
            this.btnThemCauHoi = new System.Windows.Forms.Button();
            this.gbDeThi = new System.Windows.Forms.GroupBox();
            this.gvDeThi = new System.Windows.Forms.DataGridView();
            this.btnTaoDe = new System.Windows.Forms.Button();
            this.btnLoadDe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCauHoi)).BeginInit();
            this.gbDeThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeThi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Theo Môn Học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Theo Độ Khó:";
            // 
            // cbbTheoMonHoc
            // 
            this.cbbTheoMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTheoMonHoc.FormattingEnabled = true;
            this.cbbTheoMonHoc.Location = new System.Drawing.Point(122, 20);
            this.cbbTheoMonHoc.Name = "cbbTheoMonHoc";
            this.cbbTheoMonHoc.Size = new System.Drawing.Size(121, 21);
            this.cbbTheoMonHoc.TabIndex = 2;
            this.cbbTheoMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbbTheoMonHoc_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnHuongDan);
            this.groupBox1.Controls.Add(this.gvCauHoi);
            this.groupBox1.Controls.Add(this.cbbTheoDoKho);
            this.groupBox1.Controls.Add(this.cbbTheoMonHoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 273);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Câu Hỏi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnHuongDan.Location = new System.Drawing.Point(641, 18);
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.Size = new System.Drawing.Size(145, 23);
            this.btnHuongDan.TabIndex = 5;
            this.btnHuongDan.Text = "Hướng Dẫn";
            this.btnHuongDan.UseVisualStyleBackColor = false;
            this.btnHuongDan.Click += new System.EventHandler(this.btnHuongDan_Click);
            // 
            // gvCauHoi
            // 
            this.gvCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvCauHoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCauHoi.Location = new System.Drawing.Point(25, 57);
            this.gvCauHoi.Name = "gvCauHoi";
            this.gvCauHoi.ReadOnly = true;
            this.gvCauHoi.Size = new System.Drawing.Size(761, 210);
            this.gvCauHoi.TabIndex = 4;
            // 
            // cbbTheoDoKho
            // 
            this.cbbTheoDoKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTheoDoKho.FormattingEnabled = true;
            this.cbbTheoDoKho.Location = new System.Drawing.Point(369, 20);
            this.cbbTheoDoKho.Name = "cbbTheoDoKho";
            this.cbbTheoDoKho.Size = new System.Drawing.Size(121, 21);
            this.cbbTheoDoKho.TabIndex = 3;
            this.cbbTheoDoKho.SelectedIndexChanged += new System.EventHandler(this.cbbTheoDoKho_SelectedIndexChanged);
            // 
            // btnThemCauHoi
            // 
            this.btnThemCauHoi.Location = new System.Drawing.Point(344, 288);
            this.btnThemCauHoi.Name = "btnThemCauHoi";
            this.btnThemCauHoi.Size = new System.Drawing.Size(145, 32);
            this.btnThemCauHoi.TabIndex = 4;
            this.btnThemCauHoi.Text = "Thêm Câu Hỏi Vào Đề";
            this.btnThemCauHoi.UseVisualStyleBackColor = true;
            this.btnThemCauHoi.Click += new System.EventHandler(this.btnThemCauHoi_Click);
            // 
            // gbDeThi
            // 
            this.gbDeThi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDeThi.Controls.Add(this.gvDeThi);
            this.gbDeThi.Location = new System.Drawing.Point(12, 326);
            this.gbDeThi.Name = "gbDeThi";
            this.gbDeThi.Size = new System.Drawing.Size(803, 140);
            this.gbDeThi.TabIndex = 5;
            this.gbDeThi.TabStop = false;
            this.gbDeThi.Text = "Đề Thi:";
            // 
            // gvDeThi
            // 
            this.gvDeThi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvDeThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDeThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDeThi.Location = new System.Drawing.Point(25, 19);
            this.gvDeThi.Name = "gvDeThi";
            this.gvDeThi.Size = new System.Drawing.Size(761, 108);
            this.gvDeThi.TabIndex = 0;
            // 
            // btnTaoDe
            // 
            this.btnTaoDe.Location = new System.Drawing.Point(37, 288);
            this.btnTaoDe.Name = "btnTaoDe";
            this.btnTaoDe.Size = new System.Drawing.Size(145, 32);
            this.btnTaoDe.TabIndex = 6;
            this.btnTaoDe.Text = "Tạo Đề";
            this.btnTaoDe.UseVisualStyleBackColor = true;
            this.btnTaoDe.Click += new System.EventHandler(this.btnTaoDe_Click);
            // 
            // btnLoadDe
            // 
            this.btnLoadDe.Location = new System.Drawing.Point(653, 288);
            this.btnLoadDe.Name = "btnLoadDe";
            this.btnLoadDe.Size = new System.Drawing.Size(145, 32);
            this.btnLoadDe.TabIndex = 9;
            this.btnLoadDe.Text = "Load Đề Đã Có";
            this.btnLoadDe.UseVisualStyleBackColor = true;
            this.btnLoadDe.Click += new System.EventHandler(this.btnLoadDe_Click);
            // 
            // frmQuanLyDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 471);
            this.Controls.Add(this.btnLoadDe);
            this.Controls.Add(this.btnTaoDe);
            this.Controls.Add(this.gbDeThi);
            this.Controls.Add(this.btnThemCauHoi);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuanLyDeThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Đề Thi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyDeThi_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLyDeThi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCauHoi)).EndInit();
            this.gbDeThi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDeThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTheoMonHoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvCauHoi;
        private System.Windows.Forms.ComboBox cbbTheoDoKho;
        private System.Windows.Forms.Button btnThemCauHoi;
        private System.Windows.Forms.GroupBox gbDeThi;
        private System.Windows.Forms.DataGridView gvDeThi;
        private System.Windows.Forms.Button btnTaoDe;
        private System.Windows.Forms.Button btnLoadDe;
        private System.Windows.Forms.Button btnHuongDan;
        private System.Windows.Forms.Label label3;
    }
}
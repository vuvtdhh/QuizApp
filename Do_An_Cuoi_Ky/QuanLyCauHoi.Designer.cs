namespace Do_An_Cuoi_Ky
{
    partial class frmQuanLyCauHoi
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
            this.cbbTheoDoKho = new System.Windows.Forms.ComboBox();
            this.gvCauHoi = new System.Windows.Forms.DataGridView();
            this.txtDuongDan = new System.Windows.Forms.TextBox();
            this.btnHuongDan = new System.Windows.Forms.Button();
            this.btnDuyetFile = new System.Windows.Forms.Button();
            this.btnLoadLai = new System.Windows.Forms.Button();
            this.btnLuuCauHoi = new System.Windows.Forms.Button();
            this.btnThemCauHoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvCauHoi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Theo Môn Học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Theo Độ Khó:";
            // 
            // cbbTheoMonHoc
            // 
            this.cbbTheoMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTheoMonHoc.FormattingEnabled = true;
            this.cbbTheoMonHoc.Location = new System.Drawing.Point(100, 9);
            this.cbbTheoMonHoc.Name = "cbbTheoMonHoc";
            this.cbbTheoMonHoc.Size = new System.Drawing.Size(121, 21);
            this.cbbTheoMonHoc.TabIndex = 2;
            this.cbbTheoMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbbTheoMonHoc_SelectedIndexChanged);
            // 
            // cbbTheoDoKho
            // 
            this.cbbTheoDoKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTheoDoKho.FormattingEnabled = true;
            this.cbbTheoDoKho.Location = new System.Drawing.Point(333, 9);
            this.cbbTheoDoKho.Name = "cbbTheoDoKho";
            this.cbbTheoDoKho.Size = new System.Drawing.Size(121, 21);
            this.cbbTheoDoKho.TabIndex = 3;
            this.cbbTheoDoKho.SelectedIndexChanged += new System.EventHandler(this.cbbTheoDoKho_SelectedIndexChanged);
            // 
            // gvCauHoi
            // 
            this.gvCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvCauHoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCauHoi.Location = new System.Drawing.Point(12, 83);
            this.gvCauHoi.Name = "gvCauHoi";
            this.gvCauHoi.Size = new System.Drawing.Size(797, 221);
            this.gvCauHoi.TabIndex = 4;
            this.gvCauHoi.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCauHoi_CellValueChanged);
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Location = new System.Drawing.Point(276, 49);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.ReadOnly = true;
            this.txtDuongDan.Size = new System.Drawing.Size(178, 20);
            this.txtDuongDan.TabIndex = 6;
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.Location = new System.Drawing.Point(156, 46);
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.Size = new System.Drawing.Size(104, 23);
            this.btnHuongDan.TabIndex = 12;
            this.btnHuongDan.Text = "Hướng Dẫn";
            this.btnHuongDan.UseVisualStyleBackColor = true;
            this.btnHuongDan.Click += new System.EventHandler(this.btnHuongDan_Click);
            // 
            // btnDuyetFile
            // 
            this.btnDuyetFile.Location = new System.Drawing.Point(472, 47);
            this.btnDuyetFile.Name = "btnDuyetFile";
            this.btnDuyetFile.Size = new System.Drawing.Size(121, 23);
            this.btnDuyetFile.TabIndex = 13;
            this.btnDuyetFile.Text = "Duyệt File";
            this.btnDuyetFile.UseVisualStyleBackColor = true;
            this.btnDuyetFile.Click += new System.EventHandler(this.btnDuyetFile_Click);
            // 
            // btnLoadLai
            // 
            this.btnLoadLai.Location = new System.Drawing.Point(661, 46);
            this.btnLoadLai.Name = "btnLoadLai";
            this.btnLoadLai.Size = new System.Drawing.Size(148, 23);
            this.btnLoadLai.TabIndex = 14;
            this.btnLoadLai.Text = "Dừng Thêm, Load Lại";
            this.btnLoadLai.UseVisualStyleBackColor = true;
            this.btnLoadLai.Click += new System.EventHandler(this.btnLoadLai_Click);
            // 
            // btnLuuCauHoi
            // 
            this.btnLuuCauHoi.Location = new System.Drawing.Point(349, 325);
            this.btnLuuCauHoi.Name = "btnLuuCauHoi";
            this.btnLuuCauHoi.Size = new System.Drawing.Size(105, 23);
            this.btnLuuCauHoi.TabIndex = 15;
            this.btnLuuCauHoi.Text = "Lưu Câu Hỏi";
            this.btnLuuCauHoi.UseVisualStyleBackColor = true;
            this.btnLuuCauHoi.Click += new System.EventHandler(this.btnLuuCauHoi_Click);
            // 
            // btnThemCauHoi
            // 
            this.btnThemCauHoi.Location = new System.Drawing.Point(12, 47);
            this.btnThemCauHoi.Name = "btnThemCauHoi";
            this.btnThemCauHoi.Size = new System.Drawing.Size(138, 23);
            this.btnThemCauHoi.TabIndex = 16;
            this.btnThemCauHoi.Text = "Thêm Câu Hỏi";
            this.btnThemCauHoi.UseVisualStyleBackColor = true;
            this.btnThemCauHoi.Click += new System.EventHandler(this.btnThemCauHoi_Click);
            // 
            // frmQuanLyCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 360);
            this.Controls.Add(this.btnThemCauHoi);
            this.Controls.Add(this.btnLuuCauHoi);
            this.Controls.Add(this.btnLoadLai);
            this.Controls.Add(this.btnDuyetFile);
            this.Controls.Add(this.btnHuongDan);
            this.Controls.Add(this.txtDuongDan);
            this.Controls.Add(this.gvCauHoi);
            this.Controls.Add(this.cbbTheoDoKho);
            this.Controls.Add(this.cbbTheoMonHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmQuanLyCauHoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Câu Hỏi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyCauHoi_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLyCauHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCauHoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTheoMonHoc;
        private System.Windows.Forms.ComboBox cbbTheoDoKho;
        private System.Windows.Forms.DataGridView gvCauHoi;
        private System.Windows.Forms.TextBox txtDuongDan;
        private System.Windows.Forms.Button btnHuongDan;
        private System.Windows.Forms.Button btnDuyetFile;
        private System.Windows.Forms.Button btnLoadLai;
        private System.Windows.Forms.Button btnLuuCauHoi;
        private System.Windows.Forms.Button btnThemCauHoi;
    }
}
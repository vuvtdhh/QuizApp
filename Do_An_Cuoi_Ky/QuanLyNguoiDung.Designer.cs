namespace Do_An_Cuoi_Ky
{
    partial class frmQuanLyNguoiDung
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
            this.gvThongTin = new System.Windows.Forms.DataGridView();
            this.btnThemNguoiDung = new System.Windows.Forms.Button();
            this.btnFileXML = new System.Windows.Forms.Button();
            this.btnLoadLai = new System.Windows.Forms.Button();
            this.btnThemTatCa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // gvThongTin
            // 
            this.gvThongTin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvThongTin.Location = new System.Drawing.Point(12, 12);
            this.gvThongTin.Name = "gvThongTin";
            this.gvThongTin.Size = new System.Drawing.Size(764, 275);
            this.gvThongTin.TabIndex = 0;
            this.gvThongTin.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gvThongTin_CellBeginEdit);
            this.gvThongTin.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvThongTin_CellValueChanged);
            this.gvThongTin.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvThongTin_RowLeave);
            // 
            // btnThemNguoiDung
            // 
            this.btnThemNguoiDung.Location = new System.Drawing.Point(328, 303);
            this.btnThemNguoiDung.Name = "btnThemNguoiDung";
            this.btnThemNguoiDung.Size = new System.Drawing.Size(168, 38);
            this.btnThemNguoiDung.TabIndex = 2;
            this.btnThemNguoiDung.Text = "Thêm Người Dùng";
            this.btnThemNguoiDung.UseVisualStyleBackColor = true;
            this.btnThemNguoiDung.Click += new System.EventHandler(this.btnThemNguoiDung_Click);
            // 
            // btnFileXML
            // 
            this.btnFileXML.Location = new System.Drawing.Point(608, 303);
            this.btnFileXML.Name = "btnFileXML";
            this.btnFileXML.Size = new System.Drawing.Size(168, 38);
            this.btnFileXML.TabIndex = 3;
            this.btnFileXML.Text = "Thêm HS, GV Từ File XML";
            this.btnFileXML.UseVisualStyleBackColor = true;
            this.btnFileXML.Click += new System.EventHandler(this.btnFileXML_Click);
            // 
            // btnLoadLai
            // 
            this.btnLoadLai.Location = new System.Drawing.Point(12, 303);
            this.btnLoadLai.Name = "btnLoadLai";
            this.btnLoadLai.Size = new System.Drawing.Size(168, 38);
            this.btnLoadLai.TabIndex = 4;
            this.btnLoadLai.Text = "Load Lại Dữ Liệu";
            this.btnLoadLai.UseVisualStyleBackColor = true;
            this.btnLoadLai.Click += new System.EventHandler(this.btnLoadLai_Click);
            // 
            // btnThemTatCa
            // 
            this.btnThemTatCa.Location = new System.Drawing.Point(328, 303);
            this.btnThemTatCa.Name = "btnThemTatCa";
            this.btnThemTatCa.Size = new System.Drawing.Size(168, 38);
            this.btnThemTatCa.TabIndex = 5;
            this.btnThemTatCa.Text = "Thêm Tất Cả Vào CSDL";
            this.btnThemTatCa.UseVisualStyleBackColor = true;
            this.btnThemTatCa.Click += new System.EventHandler(this.btnThemTatCa_Click);
            // 
            // frmQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 353);
            this.Controls.Add(this.btnThemTatCa);
            this.Controls.Add(this.btnLoadLai);
            this.Controls.Add(this.btnFileXML);
            this.Controls.Add(this.btnThemNguoiDung);
            this.Controls.Add(this.gvThongTin);
            this.Name = "frmQuanLyNguoiDung";
            this.Text = "Quản Lý Người Dùng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyNguoiDung_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLyNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvThongTin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvThongTin;
        private System.Windows.Forms.Button btnThemNguoiDung;
        private System.Windows.Forms.Button btnFileXML;
        private System.Windows.Forms.Button btnLoadLai;
        private System.Windows.Forms.Button btnThemTatCa;
    }
}
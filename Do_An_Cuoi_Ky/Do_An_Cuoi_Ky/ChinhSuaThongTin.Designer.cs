namespace Do_An_Cuoi_Ky
{
    partial class frmChinhSuaThongTin
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
            this.gvChinhSuaThongTin = new System.Windows.Forms.DataGridView();
            this.btnLuuChinhSua = new System.Windows.Forms.Button();
            this.btnQuayLaiTrangChu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvChinhSuaThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // gvChinhSuaThongTin
            // 
            this.gvChinhSuaThongTin.AllowUserToAddRows = false;
            this.gvChinhSuaThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvChinhSuaThongTin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvChinhSuaThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvChinhSuaThongTin.Location = new System.Drawing.Point(12, 12);
            this.gvChinhSuaThongTin.Name = "gvChinhSuaThongTin";
            this.gvChinhSuaThongTin.Size = new System.Drawing.Size(774, 44);
            this.gvChinhSuaThongTin.TabIndex = 0;
            // 
            // btnLuuChinhSua
            // 
            this.btnLuuChinhSua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuChinhSua.Location = new System.Drawing.Point(217, 83);
            this.btnLuuChinhSua.Name = "btnLuuChinhSua";
            this.btnLuuChinhSua.Size = new System.Drawing.Size(110, 35);
            this.btnLuuChinhSua.TabIndex = 1;
            this.btnLuuChinhSua.Text = "Lưu Chỉnh Sửa";
            this.btnLuuChinhSua.UseVisualStyleBackColor = true;
            this.btnLuuChinhSua.Click += new System.EventHandler(this.btnLuuChinhSua_Click);
            // 
            // btnQuayLaiTrangChu
            // 
            this.btnQuayLaiTrangChu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuayLaiTrangChu.Location = new System.Drawing.Point(491, 83);
            this.btnQuayLaiTrangChu.Name = "btnQuayLaiTrangChu";
            this.btnQuayLaiTrangChu.Size = new System.Drawing.Size(110, 35);
            this.btnQuayLaiTrangChu.TabIndex = 2;
            this.btnQuayLaiTrangChu.Text = "Quay Lại Trang Chủ";
            this.btnQuayLaiTrangChu.UseVisualStyleBackColor = true;
            this.btnQuayLaiTrangChu.Click += new System.EventHandler(this.btnQuayLaiTrangChu_Click);
            // 
            // frmChinhSuaThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 130);
            this.Controls.Add(this.btnQuayLaiTrangChu);
            this.Controls.Add(this.btnLuuChinhSua);
            this.Controls.Add(this.gvChinhSuaThongTin);
            this.Name = "frmChinhSuaThongTin";
            this.Text = "Chỉnh Sửa Thông Tin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChinhSuaThongTin_FormClosing);
            this.Load += new System.EventHandler(this.frmChinhSuaThongTin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvChinhSuaThongTin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvChinhSuaThongTin;
        private System.Windows.Forms.Button btnLuuChinhSua;
        private System.Windows.Forms.Button btnQuayLaiTrangChu;
    }
}
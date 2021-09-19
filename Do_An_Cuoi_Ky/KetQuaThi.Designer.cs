namespace Do_An_Cuoi_Ky
{
    partial class frmKetQuaThi
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
            this.gvKetQuaThi = new System.Windows.Forms.DataGridView();
            this.btnQuayVeTrangChu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvKetQuaThi)).BeginInit();
            this.SuspendLayout();
            // 
            // gvKetQuaThi
            // 
            this.gvKetQuaThi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvKetQuaThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvKetQuaThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvKetQuaThi.Location = new System.Drawing.Point(12, 12);
            this.gvKetQuaThi.Name = "gvKetQuaThi";
            this.gvKetQuaThi.Size = new System.Drawing.Size(805, 191);
            this.gvKetQuaThi.TabIndex = 0;
            // 
            // btnQuayVeTrangChu
            // 
            this.btnQuayVeTrangChu.Location = new System.Drawing.Point(375, 226);
            this.btnQuayVeTrangChu.Name = "btnQuayVeTrangChu";
            this.btnQuayVeTrangChu.Size = new System.Drawing.Size(135, 23);
            this.btnQuayVeTrangChu.TabIndex = 1;
            this.btnQuayVeTrangChu.Text = "Quay Về Trang Chủ";
            this.btnQuayVeTrangChu.UseVisualStyleBackColor = true;
            this.btnQuayVeTrangChu.Click += new System.EventHandler(this.btnQuayVeTrangChu_Click);
            // 
            // frmKetQuaThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 261);
            this.Controls.Add(this.btnQuayVeTrangChu);
            this.Controls.Add(this.gvKetQuaThi);
            this.Name = "frmKetQuaThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết Quả Thi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKetQuaThi_FormClosing);
            this.Load += new System.EventHandler(this.frmKetQuaThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvKetQuaThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvKetQuaThi;
        private System.Windows.Forms.Button btnQuayVeTrangChu;
    }
}
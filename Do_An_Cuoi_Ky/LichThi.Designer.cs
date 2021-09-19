namespace Do_An_Cuoi_Ky
{
    partial class frmLichThi
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
            this.gvLichThi = new System.Windows.Forms.DataGridView();
            this.btnQuayVeTrangChu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvLichThi)).BeginInit();
            this.SuspendLayout();
            // 
            // gvLichThi
            // 
            this.gvLichThi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvLichThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvLichThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLichThi.Location = new System.Drawing.Point(12, 12);
            this.gvLichThi.Name = "gvLichThi";
            this.gvLichThi.Size = new System.Drawing.Size(564, 76);
            this.gvLichThi.TabIndex = 0;
            // 
            // btnQuayVeTrangChu
            // 
            this.btnQuayVeTrangChu.Location = new System.Drawing.Point(226, 107);
            this.btnQuayVeTrangChu.Name = "btnQuayVeTrangChu";
            this.btnQuayVeTrangChu.Size = new System.Drawing.Size(131, 23);
            this.btnQuayVeTrangChu.TabIndex = 1;
            this.btnQuayVeTrangChu.Text = "Quay Về Trang Chủ";
            this.btnQuayVeTrangChu.UseVisualStyleBackColor = true;
            this.btnQuayVeTrangChu.Click += new System.EventHandler(this.btnQuayVeTrangChu_Click);
            // 
            // frmLichThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 142);
            this.Controls.Add(this.btnQuayVeTrangChu);
            this.Controls.Add(this.gvLichThi);
            this.Name = "frmLichThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch Thi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLichThi_FormClosing);
            this.Load += new System.EventHandler(this.frmLichThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvLichThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvLichThi;
        private System.Windows.Forms.Button btnQuayVeTrangChu;
    }
}
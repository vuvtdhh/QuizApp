namespace Do_An_Cuoi_Ky
{
    partial class frmHuongDan
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
            this.gbDang1 = new System.Windows.Forms.GroupBox();
            this.picDang1 = new System.Windows.Forms.PictureBox();
            this.gbDang2 = new System.Windows.Forms.GroupBox();
            this.picDang2 = new System.Windows.Forms.PictureBox();
            this.btnDaHieu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbDang1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDang1)).BeginInit();
            this.gbDang2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDang2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDang1
            // 
            this.gbDang1.Controls.Add(this.picDang1);
            this.gbDang1.Location = new System.Drawing.Point(18, 17);
            this.gbDang1.Name = "gbDang1";
            this.gbDang1.Size = new System.Drawing.Size(412, 175);
            this.gbDang1.TabIndex = 0;
            this.gbDang1.TabStop = false;
            this.gbDang1.Text = "Câu Hỏi Dạng 1:";
            // 
            // picDang1
            // 
            this.picDang1.Location = new System.Drawing.Point(6, 19);
            this.picDang1.Name = "picDang1";
            this.picDang1.Size = new System.Drawing.Size(398, 149);
            this.picDang1.TabIndex = 0;
            this.picDang1.TabStop = false;
            // 
            // gbDang2
            // 
            this.gbDang2.Controls.Add(this.picDang2);
            this.gbDang2.Location = new System.Drawing.Point(436, 17);
            this.gbDang2.Name = "gbDang2";
            this.gbDang2.Size = new System.Drawing.Size(316, 397);
            this.gbDang2.TabIndex = 1;
            this.gbDang2.TabStop = false;
            this.gbDang2.Text = "Câu Hỏi Dạng 2:";
            // 
            // picDang2
            // 
            this.picDang2.Location = new System.Drawing.Point(3, 19);
            this.picDang2.Name = "picDang2";
            this.picDang2.Size = new System.Drawing.Size(311, 372);
            this.picDang2.TabIndex = 1;
            this.picDang2.TabStop = false;
            // 
            // btnDaHieu
            // 
            this.btnDaHieu.Location = new System.Drawing.Point(143, 365);
            this.btnDaHieu.Name = "btnDaHieu";
            this.btnDaHieu.Size = new System.Drawing.Size(154, 43);
            this.btnDaHieu.TabIndex = 2;
            this.btnDaHieu.Text = "Đã Hiểu!";
            this.btnDaHieu.UseVisualStyleBackColor = true;
            this.btnDaHieu.Click += new System.EventHandler(this.btnDaHieu_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 66);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chương trình hỗ trợ nhập câu hỏi theo 2 cách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "- Nhập thủ công.";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 44);
            this.label3.TabIndex = 5;
            this.label3.Text = "- Duyệt Câu Hỏi Có Sẵn Trong File XML Theo 2 Định Dạng Trên.";
            // 
            // frmHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 426);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDaHieu);
            this.Controls.Add(this.gbDang2);
            this.Controls.Add(this.gbDang1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmHuongDan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hướng Dẫn";
            this.Load += new System.EventHandler(this.HuongDan_Load);
            this.gbDang1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDang1)).EndInit();
            this.gbDang2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDang2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDang1;
        private System.Windows.Forms.PictureBox picDang1;
        private System.Windows.Forms.GroupBox gbDang2;
        private System.Windows.Forms.PictureBox picDang2;
        private System.Windows.Forms.Button btnDaHieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
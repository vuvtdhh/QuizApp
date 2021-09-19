namespace Do_An_Cuoi_Ky
{
    partial class frmOnLuyenThiThu
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
            this.cbbChonDe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXemGoiY = new System.Windows.Forms.Button();
            this.btnCauTruoc = new System.Windows.Forms.Button();
            this.btnCauSau = new System.Windows.Forms.Button();
            this.btnDungLam = new System.Windows.Forms.Button();
            this.lblCauHoi = new System.Windows.Forms.Label();
            this.gbCauHoi = new System.Windows.Forms.GroupBox();
            this.lblStt = new System.Windows.Forms.Label();
            this.radioA = new System.Windows.Forms.RadioButton();
            this.radioD = new System.Windows.Forms.RadioButton();
            this.radioB = new System.Windows.Forms.RadioButton();
            this.radioC = new System.Windows.Forms.RadioButton();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.gbGoiY = new System.Windows.Forms.GroupBox();
            this.lblGoiY = new System.Windows.Forms.Label();
            this.btnXemKetQua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.gbCauHoi.SuspendLayout();
            this.gbGoiY.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbChonDe
            // 
            this.cbbChonDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChonDe.FormattingEnabled = true;
            this.cbbChonDe.Location = new System.Drawing.Point(42, 12);
            this.cbbChonDe.Name = "cbbChonDe";
            this.cbbChonDe.Size = new System.Drawing.Size(121, 21);
            this.cbbChonDe.TabIndex = 0;
            this.cbbChonDe.SelectedIndexChanged += new System.EventHandler(this.cbbChonDe_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đề:";
            // 
            // btnXemGoiY
            // 
            this.btnXemGoiY.Location = new System.Drawing.Point(369, 196);
            this.btnXemGoiY.Name = "btnXemGoiY";
            this.btnXemGoiY.Size = new System.Drawing.Size(139, 35);
            this.btnXemGoiY.TabIndex = 14;
            this.btnXemGoiY.Text = "Xem Gợi Ý";
            this.btnXemGoiY.UseVisualStyleBackColor = true;
            this.btnXemGoiY.Click += new System.EventHandler(this.btnXemGoiY_Click);
            // 
            // btnCauTruoc
            // 
            this.btnCauTruoc.Location = new System.Drawing.Point(203, 314);
            this.btnCauTruoc.Name = "btnCauTruoc";
            this.btnCauTruoc.Size = new System.Drawing.Size(139, 35);
            this.btnCauTruoc.TabIndex = 20;
            this.btnCauTruoc.Text = "Câu Trước";
            this.btnCauTruoc.UseVisualStyleBackColor = true;
            this.btnCauTruoc.Click += new System.EventHandler(this.btnCauTruoc_Click);
            // 
            // btnCauSau
            // 
            this.btnCauSau.Location = new System.Drawing.Point(369, 314);
            this.btnCauSau.Name = "btnCauSau";
            this.btnCauSau.Size = new System.Drawing.Size(139, 35);
            this.btnCauSau.TabIndex = 21;
            this.btnCauSau.Text = "Câu Sau";
            this.btnCauSau.UseVisualStyleBackColor = true;
            this.btnCauSau.Click += new System.EventHandler(this.btnCauSau_Click);
            // 
            // btnDungLam
            // 
            this.btnDungLam.Location = new System.Drawing.Point(530, 196);
            this.btnDungLam.Name = "btnDungLam";
            this.btnDungLam.Size = new System.Drawing.Size(139, 35);
            this.btnDungLam.TabIndex = 22;
            this.btnDungLam.Text = "Dừng Làm, Chấm Điểm";
            this.btnDungLam.UseVisualStyleBackColor = true;
            this.btnDungLam.Click += new System.EventHandler(this.btnDungLam_Click);
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.AutoSize = true;
            this.lblCauHoi.Location = new System.Drawing.Point(27, 28);
            this.lblCauHoi.MaximumSize = new System.Drawing.Size(250, 80);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(52, 13);
            this.lblCauHoi.TabIndex = 23;
            this.lblCauHoi.Text = "lblCauHoi";
            // 
            // gbCauHoi
            // 
            this.gbCauHoi.Controls.Add(this.lblStt);
            this.gbCauHoi.Controls.Add(this.lblCauHoi);
            this.gbCauHoi.Location = new System.Drawing.Point(42, 59);
            this.gbCauHoi.Name = "gbCauHoi";
            this.gbCauHoi.Size = new System.Drawing.Size(300, 100);
            this.gbCauHoi.TabIndex = 24;
            this.gbCauHoi.TabStop = false;
            this.gbCauHoi.Text = "Câu Hỏi:";
            // 
            // lblStt
            // 
            this.lblStt.AutoSize = true;
            this.lblStt.Location = new System.Drawing.Point(6, 28);
            this.lblStt.Name = "lblStt";
            this.lblStt.Size = new System.Drawing.Size(30, 13);
            this.lblStt.TabIndex = 24;
            this.lblStt.Text = "lblStt";
            // 
            // radioA
            // 
            this.radioA.AutoSize = true;
            this.radioA.Location = new System.Drawing.Point(42, 196);
            this.radioA.Name = "radioA";
            this.radioA.Size = new System.Drawing.Size(35, 17);
            this.radioA.TabIndex = 25;
            this.radioA.TabStop = true;
            this.radioA.Text = "A:";
            this.radioA.UseVisualStyleBackColor = true;
            // 
            // radioD
            // 
            this.radioD.AutoSize = true;
            this.radioD.Location = new System.Drawing.Point(191, 264);
            this.radioD.Name = "radioD";
            this.radioD.Size = new System.Drawing.Size(36, 17);
            this.radioD.TabIndex = 26;
            this.radioD.TabStop = true;
            this.radioD.Text = "D:";
            this.radioD.UseVisualStyleBackColor = true;
            // 
            // radioB
            // 
            this.radioB.AutoSize = true;
            this.radioB.Location = new System.Drawing.Point(191, 196);
            this.radioB.Name = "radioB";
            this.radioB.Size = new System.Drawing.Size(35, 17);
            this.radioB.TabIndex = 27;
            this.radioB.TabStop = true;
            this.radioB.Text = "B:";
            this.radioB.UseVisualStyleBackColor = true;
            // 
            // radioC
            // 
            this.radioC.AutoSize = true;
            this.radioC.Location = new System.Drawing.Point(42, 264);
            this.radioC.Name = "radioC";
            this.radioC.Size = new System.Drawing.Size(35, 17);
            this.radioC.TabIndex = 28;
            this.radioC.TabStop = true;
            this.radioC.Text = "C:";
            this.radioC.UseVisualStyleBackColor = true;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(83, 198);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(24, 13);
            this.lblA.TabIndex = 29;
            this.lblA.Text = "lblA";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(232, 198);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(24, 13);
            this.lblB.TabIndex = 30;
            this.lblB.Text = "lblB";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(83, 266);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(24, 13);
            this.lblC.TabIndex = 31;
            this.lblC.Text = "lblC";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(233, 266);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(25, 13);
            this.lblD.TabIndex = 32;
            this.lblD.Text = "lblD";
            // 
            // gbGoiY
            // 
            this.gbGoiY.Controls.Add(this.lblGoiY);
            this.gbGoiY.Location = new System.Drawing.Point(369, 59);
            this.gbGoiY.Name = "gbGoiY";
            this.gbGoiY.Size = new System.Drawing.Size(300, 100);
            this.gbGoiY.TabIndex = 33;
            this.gbGoiY.TabStop = false;
            this.gbGoiY.Text = "Gợi Ý:";
            // 
            // lblGoiY
            // 
            this.lblGoiY.AutoSize = true;
            this.lblGoiY.Location = new System.Drawing.Point(20, 28);
            this.lblGoiY.MaximumSize = new System.Drawing.Size(250, 80);
            this.lblGoiY.Name = "lblGoiY";
            this.lblGoiY.Size = new System.Drawing.Size(40, 13);
            this.lblGoiY.TabIndex = 0;
            this.lblGoiY.Text = "lblGoiY";
            // 
            // btnXemKetQua
            // 
            this.btnXemKetQua.Location = new System.Drawing.Point(369, 244);
            this.btnXemKetQua.Name = "btnXemKetQua";
            this.btnXemKetQua.Size = new System.Drawing.Size(139, 35);
            this.btnXemKetQua.TabIndex = 35;
            this.btnXemKetQua.Text = "Xem Kết Quả";
            this.btnXemKetQua.UseVisualStyleBackColor = true;
            this.btnXemKetQua.Click += new System.EventHandler(this.btnXemKetQua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Kết Quả:";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(582, 255);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(53, 13);
            this.lblKetQua.TabIndex = 37;
            this.lblKetQua.Text = "lblKetQua";
            // 
            // frmOnLuyenThiThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 361);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXemKetQua);
            this.Controls.Add(this.gbGoiY);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.radioC);
            this.Controls.Add(this.radioB);
            this.Controls.Add(this.radioD);
            this.Controls.Add(this.radioA);
            this.Controls.Add(this.gbCauHoi);
            this.Controls.Add(this.btnDungLam);
            this.Controls.Add(this.btnCauSau);
            this.Controls.Add(this.btnCauTruoc);
            this.Controls.Add(this.btnXemGoiY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbChonDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmOnLuyenThiThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ôn Luyện Thi Thử";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOnLuyenThiThu_FormClosing);
            this.Load += new System.EventHandler(this.frmOnLuyenThiThu_Load);
            this.gbCauHoi.ResumeLayout(false);
            this.gbCauHoi.PerformLayout();
            this.gbGoiY.ResumeLayout(false);
            this.gbGoiY.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbChonDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXemGoiY;
        private System.Windows.Forms.Button btnCauTruoc;
        private System.Windows.Forms.Button btnCauSau;
        private System.Windows.Forms.Button btnDungLam;
        private System.Windows.Forms.Label lblCauHoi;
        private System.Windows.Forms.GroupBox gbCauHoi;
        private System.Windows.Forms.RadioButton radioA;
        private System.Windows.Forms.RadioButton radioD;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.GroupBox gbGoiY;
        private System.Windows.Forms.Label lblGoiY;
        private System.Windows.Forms.Button btnXemKetQua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblStt;
    }
}
namespace Do_An_Cuoi_Ky
{
    partial class frmLamBaiTracNghiem
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
            this.components = new System.ComponentModel.Container();
            this.tmThoiGian = new System.Windows.Forms.Timer(this.components);
            this.lblPhut = new System.Windows.Forms.Label();
            this.lblPhanCach = new System.Windows.Forms.Label();
            this.lblGiay = new System.Windows.Forms.Label();
            this.btnBatDauLamBai = new System.Windows.Forms.Button();
            this.cbbChonDe = new System.Windows.Forms.ComboBox();
            this.gbCauHoi = new System.Windows.Forms.GroupBox();
            this.lblCauHoi = new System.Windows.Forms.Label();
            this.lblStt = new System.Windows.Forms.Label();
            this.radioA = new System.Windows.Forms.RadioButton();
            this.radioB = new System.Windows.Forms.RadioButton();
            this.radioC = new System.Windows.Forms.RadioButton();
            this.radioD = new System.Windows.Forms.RadioButton();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.btnCauTruoc = new System.Windows.Forms.Button();
            this.btnCauSau = new System.Windows.Forms.Button();
            this.btnNopBaiSom = new System.Windows.Forms.Button();
            this.lblMonThi = new System.Windows.Forms.Label();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.lblTG = new System.Windows.Forms.Label();
            this.lblThoiGianThi = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.gbSoCauDaHoanThanh = new System.Windows.Forms.GroupBox();
            this.lblSoCauDaHoanThanh = new System.Windows.Forms.Label();
            this.gbSoCauConLai = new System.Windows.Forms.GroupBox();
            this.lblSoCauConLai = new System.Windows.Forms.Label();
            this.lblThoiGianThi2 = new System.Windows.Forms.Label();
            this.gbCauHoi.SuspendLayout();
            this.gbSoCauDaHoanThanh.SuspendLayout();
            this.gbSoCauConLai.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmThoiGian
            // 
            this.tmThoiGian.Tick += new System.EventHandler(this.tmThoiGian_Tick);
            // 
            // lblPhut
            // 
            this.lblPhut.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhut.Location = new System.Drawing.Point(570, 27);
            this.lblPhut.Name = "lblPhut";
            this.lblPhut.Size = new System.Drawing.Size(55, 39);
            this.lblPhut.TabIndex = 0;
            this.lblPhut.Text = "00";
            // 
            // lblPhanCach
            // 
            this.lblPhanCach.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanCach.Location = new System.Drawing.Point(614, 21);
            this.lblPhanCach.Name = "lblPhanCach";
            this.lblPhanCach.Size = new System.Drawing.Size(21, 39);
            this.lblPhanCach.TabIndex = 1;
            this.lblPhanCach.Text = ":";
            // 
            // lblGiay
            // 
            this.lblGiay.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiay.Location = new System.Drawing.Point(631, 27);
            this.lblGiay.Name = "lblGiay";
            this.lblGiay.Size = new System.Drawing.Size(55, 39);
            this.lblGiay.TabIndex = 2;
            this.lblGiay.Text = "00";
            // 
            // btnBatDauLamBai
            // 
            this.btnBatDauLamBai.Location = new System.Drawing.Point(554, 109);
            this.btnBatDauLamBai.Name = "btnBatDauLamBai";
            this.btnBatDauLamBai.Size = new System.Drawing.Size(148, 42);
            this.btnBatDauLamBai.TabIndex = 3;
            this.btnBatDauLamBai.Text = "Bắt Đầu Làm Bài";
            this.btnBatDauLamBai.UseVisualStyleBackColor = true;
            this.btnBatDauLamBai.Click += new System.EventHandler(this.btnBatDauLamBai_Click);
            // 
            // cbbChonDe
            // 
            this.cbbChonDe.FormattingEnabled = true;
            this.cbbChonDe.Location = new System.Drawing.Point(101, 118);
            this.cbbChonDe.Name = "cbbChonDe";
            this.cbbChonDe.Size = new System.Drawing.Size(121, 21);
            this.cbbChonDe.TabIndex = 4;
            this.cbbChonDe.SelectedIndexChanged += new System.EventHandler(this.cbbChonDe_SelectedIndexChanged);
            // 
            // gbCauHoi
            // 
            this.gbCauHoi.Controls.Add(this.lblCauHoi);
            this.gbCauHoi.Controls.Add(this.lblStt);
            this.gbCauHoi.Location = new System.Drawing.Point(65, 159);
            this.gbCauHoi.Name = "gbCauHoi";
            this.gbCauHoi.Size = new System.Drawing.Size(460, 125);
            this.gbCauHoi.TabIndex = 5;
            this.gbCauHoi.TabStop = false;
            this.gbCauHoi.Text = "Câu Hỏi:";
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.AutoSize = true;
            this.lblCauHoi.Location = new System.Drawing.Point(24, 29);
            this.lblCauHoi.MaximumSize = new System.Drawing.Size(445, 110);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(52, 13);
            this.lblCauHoi.TabIndex = 2;
            this.lblCauHoi.Text = "lblCauHoi";
            // 
            // lblStt
            // 
            this.lblStt.AutoSize = true;
            this.lblStt.Location = new System.Drawing.Point(6, 16);
            this.lblStt.Name = "lblStt";
            this.lblStt.Size = new System.Drawing.Size(30, 13);
            this.lblStt.TabIndex = 1;
            this.lblStt.Text = "lblStt";
            // 
            // radioA
            // 
            this.radioA.AutoSize = true;
            this.radioA.Location = new System.Drawing.Point(74, 299);
            this.radioA.Name = "radioA";
            this.radioA.Size = new System.Drawing.Size(35, 17);
            this.radioA.TabIndex = 6;
            this.radioA.TabStop = true;
            this.radioA.Text = "A:";
            this.radioA.UseVisualStyleBackColor = true;
            // 
            // radioB
            // 
            this.radioB.AutoSize = true;
            this.radioB.Location = new System.Drawing.Point(304, 299);
            this.radioB.Name = "radioB";
            this.radioB.Size = new System.Drawing.Size(35, 17);
            this.radioB.TabIndex = 7;
            this.radioB.TabStop = true;
            this.radioB.Text = "B:";
            this.radioB.UseVisualStyleBackColor = true;
            // 
            // radioC
            // 
            this.radioC.AutoSize = true;
            this.radioC.Location = new System.Drawing.Point(74, 366);
            this.radioC.Name = "radioC";
            this.radioC.Size = new System.Drawing.Size(35, 17);
            this.radioC.TabIndex = 8;
            this.radioC.TabStop = true;
            this.radioC.Text = "C:";
            this.radioC.UseVisualStyleBackColor = true;
            // 
            // radioD
            // 
            this.radioD.AutoSize = true;
            this.radioD.Location = new System.Drawing.Point(304, 366);
            this.radioD.Name = "radioD";
            this.radioD.Size = new System.Drawing.Size(36, 17);
            this.radioD.TabIndex = 9;
            this.radioD.TabStop = true;
            this.radioD.Text = "D:";
            this.radioD.UseVisualStyleBackColor = true;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(115, 301);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(24, 13);
            this.lblA.TabIndex = 10;
            this.lblA.Text = "lblA";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(345, 301);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(24, 13);
            this.lblB.TabIndex = 11;
            this.lblB.Text = "lblB";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(115, 368);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(24, 13);
            this.lblC.TabIndex = 12;
            this.lblC.Text = "lblC";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(346, 368);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(25, 13);
            this.lblD.TabIndex = 13;
            this.lblD.Text = "lblD";
            // 
            // btnCauTruoc
            // 
            this.btnCauTruoc.Location = new System.Drawing.Point(65, 417);
            this.btnCauTruoc.Name = "btnCauTruoc";
            this.btnCauTruoc.Size = new System.Drawing.Size(104, 33);
            this.btnCauTruoc.TabIndex = 14;
            this.btnCauTruoc.Text = "Câu Trước";
            this.btnCauTruoc.UseVisualStyleBackColor = true;
            this.btnCauTruoc.Click += new System.EventHandler(this.btnCauTruoc_Click);
            // 
            // btnCauSau
            // 
            this.btnCauSau.Location = new System.Drawing.Point(188, 417);
            this.btnCauSau.Name = "btnCauSau";
            this.btnCauSau.Size = new System.Drawing.Size(104, 33);
            this.btnCauSau.TabIndex = 15;
            this.btnCauSau.Text = "Câu Sau";
            this.btnCauSau.UseVisualStyleBackColor = true;
            this.btnCauSau.Click += new System.EventHandler(this.btnCauSau_Click);
            // 
            // btnNopBaiSom
            // 
            this.btnNopBaiSom.Location = new System.Drawing.Point(421, 417);
            this.btnNopBaiSom.Name = "btnNopBaiSom";
            this.btnNopBaiSom.Size = new System.Drawing.Size(104, 33);
            this.btnNopBaiSom.TabIndex = 16;
            this.btnNopBaiSom.Text = "Nộp Bài Sớm";
            this.btnNopBaiSom.UseVisualStyleBackColor = true;
            this.btnNopBaiSom.Click += new System.EventHandler(this.btnNopBaiSom_Click);
            // 
            // lblMonThi
            // 
            this.lblMonThi.AutoSize = true;
            this.lblMonThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonThi.Location = new System.Drawing.Point(241, 15);
            this.lblMonThi.Name = "lblMonThi";
            this.lblMonThi.Size = new System.Drawing.Size(98, 25);
            this.lblMonThi.TabIndex = 17;
            this.lblMonThi.Text = "Môn Thi:";
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMon.Location = new System.Drawing.Point(334, 15);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(114, 25);
            this.lblTenMon.TabIndex = 18;
            this.lblTenMon.Text = "lblTenMon";
            // 
            // lblTG
            // 
            this.lblTG.AutoSize = true;
            this.lblTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTG.Location = new System.Drawing.Point(249, 40);
            this.lblTG.Name = "lblTG";
            this.lblTG.Size = new System.Drawing.Size(91, 20);
            this.lblTG.TabIndex = 19;
            this.lblTG.Text = "Thời Gian:";
            // 
            // lblThoiGianThi
            // 
            this.lblThoiGianThi.AutoSize = true;
            this.lblThoiGianThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianThi.Location = new System.Drawing.Point(335, 40);
            this.lblThoiGianThi.Name = "lblThoiGianThi";
            this.lblThoiGianThi.Size = new System.Drawing.Size(123, 20);
            this.lblThoiGianThi.TabIndex = 20;
            this.lblThoiGianThi.Text = "lblThoiGianThi";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.Location = new System.Drawing.Point(62, 122);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(33, 17);
            this.lblDe.TabIndex = 21;
            this.lblDe.Text = "Đề:";
            // 
            // gbSoCauDaHoanThanh
            // 
            this.gbSoCauDaHoanThanh.Controls.Add(this.lblSoCauDaHoanThanh);
            this.gbSoCauDaHoanThanh.Location = new System.Drawing.Point(554, 159);
            this.gbSoCauDaHoanThanh.Name = "gbSoCauDaHoanThanh";
            this.gbSoCauDaHoanThanh.Size = new System.Drawing.Size(148, 124);
            this.gbSoCauDaHoanThanh.TabIndex = 22;
            this.gbSoCauDaHoanThanh.TabStop = false;
            this.gbSoCauDaHoanThanh.Text = "Số Câu Đã Hoàn Thành:";
            // 
            // lblSoCauDaHoanThanh
            // 
            this.lblSoCauDaHoanThanh.AutoSize = true;
            this.lblSoCauDaHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoCauDaHoanThanh.Location = new System.Drawing.Point(51, 43);
            this.lblSoCauDaHoanThanh.Name = "lblSoCauDaHoanThanh";
            this.lblSoCauDaHoanThanh.Size = new System.Drawing.Size(380, 39);
            this.lblSoCauDaHoanThanh.TabIndex = 1;
            this.lblSoCauDaHoanThanh.Text = "lblSoCauDaHoanThanh";
            // 
            // gbSoCauConLai
            // 
            this.gbSoCauConLai.Controls.Add(this.lblSoCauConLai);
            this.gbSoCauConLai.Location = new System.Drawing.Point(554, 292);
            this.gbSoCauConLai.Name = "gbSoCauConLai";
            this.gbSoCauConLai.Size = new System.Drawing.Size(148, 124);
            this.gbSoCauConLai.TabIndex = 23;
            this.gbSoCauConLai.TabStop = false;
            this.gbSoCauConLai.Text = "Số Câu Còn Lại:";
            // 
            // lblSoCauConLai
            // 
            this.lblSoCauConLai.AutoSize = true;
            this.lblSoCauConLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoCauConLai.Location = new System.Drawing.Point(51, 50);
            this.lblSoCauConLai.Name = "lblSoCauConLai";
            this.lblSoCauConLai.Size = new System.Drawing.Size(266, 39);
            this.lblSoCauConLai.TabIndex = 0;
            this.lblSoCauConLai.Text = "lblSoCauConLai";
            // 
            // lblThoiGianThi2
            // 
            this.lblThoiGianThi2.AutoSize = true;
            this.lblThoiGianThi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianThi2.Location = new System.Drawing.Point(359, 40);
            this.lblThoiGianThi2.Name = "lblThoiGianThi2";
            this.lblThoiGianThi2.Size = new System.Drawing.Size(51, 20);
            this.lblThoiGianThi2.TabIndex = 24;
            this.lblThoiGianThi2.Text = "Phút.";
            // 
            // frmLamBaiTracNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 493);
            this.Controls.Add(this.lblThoiGianThi2);
            this.Controls.Add(this.gbSoCauConLai);
            this.Controls.Add(this.gbSoCauDaHoanThanh);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.lblThoiGianThi);
            this.Controls.Add(this.lblTG);
            this.Controls.Add(this.lblTenMon);
            this.Controls.Add(this.lblMonThi);
            this.Controls.Add(this.btnNopBaiSom);
            this.Controls.Add(this.btnCauSau);
            this.Controls.Add(this.btnCauTruoc);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.radioD);
            this.Controls.Add(this.radioC);
            this.Controls.Add(this.radioB);
            this.Controls.Add(this.radioA);
            this.Controls.Add(this.gbCauHoi);
            this.Controls.Add(this.cbbChonDe);
            this.Controls.Add(this.btnBatDauLamBai);
            this.Controls.Add(this.lblGiay);
            this.Controls.Add(this.lblPhanCach);
            this.Controls.Add(this.lblPhut);
            this.Name = "frmLamBaiTracNghiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Làm Bài Trắc Nghiệm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLamBaiTracNghiem_FormClosing);
            this.Load += new System.EventHandler(this.frmLamBaiTracNghiem_Load);
            this.gbCauHoi.ResumeLayout(false);
            this.gbCauHoi.PerformLayout();
            this.gbSoCauDaHoanThanh.ResumeLayout(false);
            this.gbSoCauDaHoanThanh.PerformLayout();
            this.gbSoCauConLai.ResumeLayout(false);
            this.gbSoCauConLai.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmThoiGian;
        private System.Windows.Forms.Label lblPhut;
        private System.Windows.Forms.Label lblPhanCach;
        private System.Windows.Forms.Label lblGiay;
        private System.Windows.Forms.Button btnBatDauLamBai;
        private System.Windows.Forms.ComboBox cbbChonDe;
        private System.Windows.Forms.GroupBox gbCauHoi;
        private System.Windows.Forms.Label lblStt;
        private System.Windows.Forms.RadioButton radioA;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.RadioButton radioD;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Button btnCauTruoc;
        private System.Windows.Forms.Button btnCauSau;
        private System.Windows.Forms.Button btnNopBaiSom;
        private System.Windows.Forms.Label lblMonThi;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.Label lblTG;
        private System.Windows.Forms.Label lblThoiGianThi;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.GroupBox gbSoCauDaHoanThanh;
        private System.Windows.Forms.Label lblSoCauDaHoanThanh;
        private System.Windows.Forms.GroupBox gbSoCauConLai;
        private System.Windows.Forms.Label lblSoCauConLai;
        private System.Windows.Forms.Label lblCauHoi;
        private System.Windows.Forms.Label lblThoiGianThi2;
    }
}
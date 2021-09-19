using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_Cuoi_Ky
{
    public partial class frmHuongDan : Form
    {
        public frmHuongDan()
        {
            InitializeComponent();
        }

        private void HuongDan_Load(object sender, EventArgs e)
        {
            picDang1.Image = Image.FromFile("dang1.png");
            picDang1.SizeMode = PictureBoxSizeMode.AutoSize;
            picDang2.Image = Image.FromFile("dang2.png");
            picDang2.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void btnDaHieu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

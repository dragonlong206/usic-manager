using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void thêmHộiViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapHoiVienFrm frm = new NhapHoiVienFrm();
            frm.Show();
        }

        private void thêmBuổiSinhHoạtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapBuoiSinhHoatFrm frm = new NhapBuoiSinhHoatFrm();
            frm.Show();
        }
    }
}

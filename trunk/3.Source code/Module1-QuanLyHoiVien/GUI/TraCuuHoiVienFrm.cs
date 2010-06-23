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
    public partial class TraCuuHoiVienFrm : Form
    {
        public TraCuuHoiVienFrm()
        {
            InitializeComponent();
        }

        private void dgvDanhSach_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CapNhatHoiVienFrm frm = new CapNhatHoiVienFrm();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            CapNhatHoiVienFrm frm = new CapNhatHoiVienFrm();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnXemDanhSach_Click(object sender, EventArgs e)
        {
            XemDanhSachHoiVienFrm frm = new XemDanhSachHoiVienFrm();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}

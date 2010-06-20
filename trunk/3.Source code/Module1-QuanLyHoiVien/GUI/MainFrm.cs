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
            frm.MdiParent = this;
            frm.Show();
        }

        private void thêmBuổiSinhHoạtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapBuoiSinhHoatFrm frm = new NhapBuoiSinhHoatFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tracứuHộiViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraCuuHoiVienFrm frm = new TraCuuHoiVienFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void xóaHộiViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaHoiVienFrm frm = new XoaHoiVienFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void điểmDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiemDanhFrm frm = new DiemDanhFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cậpnhậtHộiViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatHoiVienFrm frm = new CapNhatHoiVienFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thêmThứhạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapThuHangFrm frm = new NhapThuHangFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thêmChuyênMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapChuyenMonFrm frm = new NhapChuyenMonFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thêmHoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapHoatDongFrm frm = new NhapHoatDongFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thêmKhoảnThuChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapChiPhiFrm frm = new NhapChiPhiFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tháchĐấuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapThachDauFrm frm = new NhapThachDauFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void điểmdanhHoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiemDanhHoatDongFrm frm = new DiemDanhHoatDongFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ghiNhậnKếtQuảTháchĐấuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatKetQuaThachDauFrm frm = new CapNhatKetQuaThachDauFrm();
            frm.MdiParent = this;
            frm.Show();
        }

    }
}

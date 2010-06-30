using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class XemDanhSachHoiVienFrm : Form
    {
        public XemDanhSachHoiVienFrm()
        {
            InitializeComponent();
        }

        private void XemDanhSachHoiVienFrm_Load(object sender, EventArgs e)
        {
            try
            {
                List<HoiVienDTO> DanhSachHoiVien = HoiVienBUS.LayDanhSachHoiVien();
                if (DanhSachHoiVien.Count > 0)
                {
                    this.dtgDanhSachHoiVien.DataSource = DanhSachHoiVien;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgDanhSachHoiVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

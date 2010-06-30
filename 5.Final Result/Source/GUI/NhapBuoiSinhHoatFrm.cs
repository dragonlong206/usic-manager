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
    public partial class NhapBuoiSinhHoatFrm : Form
    {
        int _intMaBuoiHienTai;
        public NhapBuoiSinhHoatFrm()
        {
            InitializeComponent();
            _intMaBuoiHienTai = BuoiSinhHoatBUS.GetMaxID();
        }

        private void NhapBuoiSinhHoatFrm_Load(object sender, EventArgs e)
        {
            try
            {
                this.ShowMaster();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowMaster()
        {
            this.txtMaBuoi.Text = (_intMaBuoiHienTai + 1).ToString();
            this.txtDiaDiem.Text = String.Empty;
            this.txtNoiDung.Text = String.Empty;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                BuoiSinhHoatDTO aBuoiSinhHoat = this.CreateBuoiSinhHoatDTO();
                bool blnIsInserted = BuoiSinhHoatBUS.InsertBuoiSinhHoat(aBuoiSinhHoat);
                if (blnIsInserted == true)
                {
                    MessageBox.Show("Đã thêm thành công");
                    _intMaBuoiHienTai++;
                    this.ShowMaster();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private BuoiSinhHoatDTO CreateBuoiSinhHoatDTO()
        {
            BuoiSinhHoatDTO result = new BuoiSinhHoatDTO();

            result.MaBuoi = int.Parse(this.txtMaBuoi.Text);
            result.ThoiGian = this.dtpThoiGian.Value.Date;
            result.DiaDiem = this.txtDiaDiem.Text;
            result.NoiDungChinh = this.txtNoiDung.Text;

            return result;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.ShowMaster();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            DiemDanhFrm frm = new DiemDanhFrm();
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
        }
    }
}

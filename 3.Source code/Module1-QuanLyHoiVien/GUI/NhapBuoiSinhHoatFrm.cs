using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class NhapBuoiSinhHoatFrm : Form
    {
        public NhapBuoiSinhHoatFrm()
        {
            InitializeComponent();
        }

        #region Nhap BuoiSinhHoat.
        private void btnLuu_Click(object sender, EventArgs e)
        {
            DTO.BuoiSinhHoatDTO aBuoiSinhHoat = NhapBuoiSinhHoat();
            if (aBuoiSinhHoat == null)
                return; //khong lam gi ca.  

            try
            {
                if (BUS.BuoiSinhHoatBUS.ThemBuoiSinhHoat(aBuoiSinhHoat))
                {
                    MessageBox.Show("Them buoi sinh hoat thanh cong");
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Vui long kiem tra du lieu nhap");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
            }
        }        

        private DTO.BuoiSinhHoatDTO NhapBuoiSinhHoat()
        {
            DTO.BuoiSinhHoatDTO aBuoiSinhHoat = new DTO.BuoiSinhHoatDTO();
            if (!KiemTraNhap())
                return null;

            if (txtMaBuoiSinhHoat.Text == String.Empty)
                aBuoiSinhHoat.MaBuoiSinhHoat = 0;
            else
                aBuoiSinhHoat.MaBuoiSinhHoat = int.Parse(txtMaBuoiSinhHoat.Text);
            aBuoiSinhHoat.DiaDiem = txtDiaDiem.Text;
            aBuoiSinhHoat.ThoiGian = DateTime.Parse(dtpThoiGian.Text);

            return aBuoiSinhHoat;
        }

        private bool KiemTraNhap()
        {
            bool blnKetQua = true;

            #region Kiem tra tinh hop le           
            blnKetQua &= !String.IsNullOrEmpty(txtDiaDiem.Text);
            blnKetQua &= !String.IsNullOrEmpty(dtpThoiGian.Text);
            if (!blnKetQua)
            {
                MessageBox.Show("Du lieu nhap vao khong day du\r\nVui long kiem tra lai");
                return blnKetQua;
            }
            #endregion

            #region Kiem tra cac rang buoc.
            //Kiem tra cac chuc vu nhu: ChuNhiem,P.ChuNhiem chi xh 1 lan.

            #endregion

            return blnKetQua;
        }

        private void ClearForm()
        {
            txtDiaDiem.Text = String.Empty;
            txtMaBuoiSinhHoat.Text = String.Empty;
            dtpThoiGian.Text = String.Empty;
        }
        #endregion        
    }
}

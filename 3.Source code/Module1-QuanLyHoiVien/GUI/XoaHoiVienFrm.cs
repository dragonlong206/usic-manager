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
    public partial class XoaHoiVienFrm : Form
    {
        public XoaHoiVienFrm()
        {
            InitializeComponent();
        }

        #region Xuat danh sach HoiVien.
        private void XoaHoiVienFrm_Load(object sender, EventArgs e)
        {
            try
            {
                List<DTO.HoiVienDTO> lstHoiVien = HoiVienBUS.LayDanhSachHoiVien();
                XuatDanhSachHoiVien(lstHoiVien);

                //Select tieu chi tiem kiem.
                cboTieuChiTimKiem.SelectedIndex = 0;                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }        

        private void XuatDanhSachHoiVien(List<DTO.HoiVienDTO> lstHoiVien)
        {
            if (lstHoiVien == null)
                return;     //khong lam gi ca.          

            lsvDanhSachHoiVien.Items.Clear();
            int nSoThuTu = 1;
            foreach (DTO.HoiVienDTO aHoiVienTemp in lstHoiVien)
            {
                lsvDanhSachHoiVien.Items.Add(TheHienListItem(nSoThuTu, aHoiVienTemp));
                nSoThuTu++;
            }
        }

        private ListViewItem TheHienListItem(int nSoThuTu, DTO.HoiVienDTO aHoiVien)
        {
            ListViewItem itemKetQua = new ListViewItem(nSoThuTu.ToString());
            itemKetQua.SubItems.Add(aHoiVien.MSSV);
            itemKetQua.SubItems.Add(aHoiVien.HoTen);
            itemKetQua.SubItems.Add(aHoiVien.Email);
            itemKetQua.Tag = aHoiVien;

            return itemKetQua;
        }
        #endregion

        #region Xoa HoiVien duoc chon.
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (lsvDanhSachHoiVien.CheckedItems.Count > 0)
            {
                try
                {
                    foreach (ListViewItem itemHoiVien in lsvDanhSachHoiVien.CheckedItems)
                    {
                        HoiVienDTO aHoiVien = (HoiVienDTO)itemHoiVien.Tag;
                        if (HoiVienBUS.XoaHoiVien(aHoiVien))
                        {
                            lsvDanhSachHoiVien.Items.Remove(itemHoiVien);
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
            }
            else
            {
                if (lsvDanhSachHoiVien.SelectedItems.Count > 0)
                {
                    try
                    {
                        foreach (ListViewItem itemHoiVien in lsvDanhSachHoiVien.SelectedItems)
                        {
                            HoiVienDTO aHoiVien = (HoiVienDTO)itemHoiVien.Tag;
                            if (HoiVienBUS.XoaHoiVien(aHoiVien))
                            {
                                lsvDanhSachHoiVien.Items.Remove(itemHoiVien);
                            }
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex.Message);
                    }
                }
                else
                    MessageBox.Show("Chua co hoi vien nao duoc chon");
            }
        }        

        private void chkChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChonTatCa.CheckState == CheckState.Checked)
            {
                foreach (ListViewItem itemHoiVien in lsvDanhSachHoiVien.Items)
                {
                    itemHoiVien.Checked = true;
                }
            }
            else
            {
                foreach (ListViewItem itemHoiVien in lsvDanhSachHoiVien.Items)
                {
                    itemHoiVien.Checked = false;
                }
            }
        }        
        #endregion                

        #region Tra cuu HoiVien.
        private void btn_Tim_Click(object sender, EventArgs e)
        {
            String strTieuChiTimKiem = NhapThamSoTimKiem();

            try
            {
                List<DTO.HoiVienDTO> lstHoiVien = BUS.HoiVienBUS.LayDanhSachHoiVien(strTieuChiTimKiem);
                XuatDanhSachHoiVien(lstHoiVien);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }        

        private String NhapThamSoTimKiem()
        {
            String strTieuChiTimKiem = String.Empty;

            if (txtGiaTriTimKiem.Text != String.Empty)
            {
                if (cboTieuChiTimKiem.Text == "MSSV")
                {
                    if (chk_TimChinhXac.CheckState == CheckState.Checked)
                        strTieuChiTimKiem += " [MSSV] = '" + txtGiaTriTimKiem.Text + "'";
                    else
                        strTieuChiTimKiem += " [MSSV] Like '%" + txtGiaTriTimKiem.Text + "%'";
                }
                if (cboTieuChiTimKiem.Text == "Họ tên")
                {
                    if (chk_TimChinhXac.CheckState == CheckState.Checked)
                        strTieuChiTimKiem += " [HoTen] = '" + txtGiaTriTimKiem.Text + "'";
                    else
                        strTieuChiTimKiem += " [HoTen] Like '%" + txtGiaTriTimKiem.Text + "%'";
                }
            }
            if (strTieuChiTimKiem == String.Empty)
                strTieuChiTimKiem = "[MSSV] = [MSSV]";

            return strTieuChiTimKiem;
        }
        #endregion        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}

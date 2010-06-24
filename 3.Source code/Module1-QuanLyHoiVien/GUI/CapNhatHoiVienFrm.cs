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
    public partial class CapNhatHoiVienFrm : Form
    {
        public CapNhatHoiVienFrm()
        {
            InitializeComponent();
        }

        #region Xuat danh sach HoiVien.
        private void CapNhatHoiVienFrm_Load(object sender, EventArgs e)
        {
            try
            {
                List<DTO.HoiVienDTO> lstHoiVien = HoiVienBUS.LayDanhSachHoiVien();
                XuatDanhSachHoiVien(lstHoiVien);

                //Select tieu chi tiem kiem.
                cboTieuChiTimKiem.SelectedIndex = 0;

                // Load danh sach loai hoi vien.
                List<LoaiHoiVienDTO> lstLoaiHoiVien = LoaiHoiVienBUS.LayDanhSachLoaiHoiVien();
                if (lstLoaiHoiVien.Count > 0)
                {
                    this.cboLoaiHoiVien.DataSource = lstLoaiHoiVien;
                    this.cboLoaiHoiVien.DisplayMember = "TenLoai";
                    this.cboLoaiHoiVien.ValueMember = "MaLoai";
                }

                //Load danh sach chuc vu.
                List<VaiTroDTO> lstVaiTro = VaiTroBUS.LayDanhSachVaiTro();
                if (lstVaiTro.Count > 0)
                {
                    this.cboVaiTro.DataSource = lstVaiTro;
                    this.cboVaiTro.DisplayMember = "TenVaiTro";
                    this.cboVaiTro.ValueMember = "MaVaiTro";
                }

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

        private void lsvDanhSachHoiVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSachHoiVien.SelectedItems.Count > 0)
            {
                ListViewItem itemHoiVien = lsvDanhSachHoiVien.SelectedItems[0];
                DTO.HoiVienDTO aHoiVien = (DTO.HoiVienDTO)itemHoiVien.Tag;
                XuatChiTietHoiVien(aHoiVien);
            }
        }        

        private void XuatChiTietHoiVien(DTO.HoiVienDTO aHoiVien)
        {
            txtMSSV.Text = aHoiVien.MSSV;
            txtHoTen.Text = aHoiVien.HoTen;
            String strEmail = aHoiVien.Email;
            String[] strSplit = strEmail.Split('@');
            if(strSplit.Length == 2)
            {
                txtEmail.Text = strSplit[0];
                cboEmail_Domain.Text = strSplit[1];
            }
            txtDienThoai.Text = aHoiVien.DienThoai;
            cboLoaiHoiVien.Text = LoaiHoiVienBUS.LayTenLoaiHoiVien(aHoiVien.MaLoaiHoiVien);
            chkDoanVien.CheckState = CheckState.Unchecked;
            if (aHoiVien.LaDoanVien)
                chkDoanVien.CheckState = CheckState.Checked;
            chkHoiVien.CheckState = CheckState.Unchecked;
            if (aHoiVien.LaHoiVien)
                chkHoiVien.CheckState = CheckState.Checked;
            chkDangVien.CheckState = CheckState.Unchecked;
            if (aHoiVien.LaDangVien)
                chkDangVien.CheckState = CheckState.Checked;
            txtChoO.Text = aHoiVien.ChoOHienNay;
            txtDiaChiThuongTru.Text = aHoiVien.DiaChiThuongTru;
            cboVaiTro.Text = VaiTroBUS.LayTenVaiTro(aHoiVien.MaVaiTro);
        }

        private void ClearForm()
        {
            txtMSSV.Text = String.Empty;
            txtHoTen.Text = String.Empty;
            txtDienThoai.Text = String.Empty;
            txtEmail.Text = String.Empty;
            //cboEmail_Domain.Text = String.Empty;
            txtChoO.Text = String.Empty;
            txtDiaChiThuongTru.Text = String.Empty;
            chkDoanVien.CheckState = CheckState.Unchecked;
            chkHoiVien.CheckState = CheckState.Unchecked;
            chkDangVien.CheckState = CheckState.Unchecked;
            cboLoaiHoiVien.Text = String.Empty;
            cboVaiTro.Text = String.Empty;
        }
        #endregion               

        #region Cap nhat thong tin HoiVien.
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtMSSV.Text))
            {
                try
                {
                    DTO.HoiVienDTO aHoiVien = NhapHoiVien();
                    if (aHoiVien == null)
                        return; //khong lam gi ca.                                                            

                    if (BUS.HoiVienBUS.CapNhatHoiVien(aHoiVien))
                    {
                        CapNhatHoiVienFrm_Load(sender, e);
                        ClearForm();
                    }
                }
                catch (System.Exception ex)
                {
                	MessageBox.Show("Exception: " + ex.Message);
                }                                   
            }
            else
            {
                MessageBox.Show("Chua co hoi vien nao dc chon");
            }
        }

        private DTO.HoiVienDTO NhapHoiVien()
        {
            DTO.HoiVienDTO aHoiVien = new DTO.HoiVienDTO();
            if (!KiemTraNhap())
                return null;

            aHoiVien.MSSV = txtMSSV.Text;
            aHoiVien.HoTen = txtHoTen.Text;
            aHoiVien.Email = txtEmail.Text + "@" + cboEmail_Domain.Text;
            aHoiVien.DienThoai = txtDienThoai.Text;
            aHoiVien.MaLoaiHoiVien = int.Parse(cboLoaiHoiVien.SelectedValue.ToString());
            aHoiVien.LaDoanVien = false;
            if (chkDoanVien.CheckState == CheckState.Checked)
                aHoiVien.LaDoanVien = true;
            aHoiVien.LaHoiVien = false;
            if (chkHoiVien.CheckState == CheckState.Checked)
                aHoiVien.LaHoiVien = true;
            aHoiVien.LaDangVien = false;
            if (chkDangVien.CheckState == CheckState.Checked)
                aHoiVien.LaDangVien = true;
            aHoiVien.ChoOHienNay = txtChoO.Text;
            aHoiVien.DiaChiThuongTru = txtDiaChiThuongTru.Text;
            aHoiVien.MaVaiTro = int.Parse(cboVaiTro.SelectedValue.ToString());

            return aHoiVien;
        }

        private bool KiemTraNhap()
        {
            bool blnKetQua = true;

            #region Kiem tra tinh hop le
            //Kiem tra du lieu nhap phai day du:
            blnKetQua &= !String.IsNullOrEmpty(txtMSSV.Text);
            blnKetQua &= !String.IsNullOrEmpty(txtHoTen.Text);
            blnKetQua &= !String.IsNullOrEmpty(txtEmail.Text);
            blnKetQua &= !String.IsNullOrEmpty(cboEmail_Domain.Text);
            //blnKetQua &= !String.IsNullOrEmpty(txtDienThoai.Text);
            blnKetQua &= !String.IsNullOrEmpty(cboLoaiHoiVien.Text);
            //blnKetQua &= !String.IsNullOrEmpty(txtChoO.Text);
            //blnKetQua &= !String.IsNullOrEmpty(txtDiaChiThuongTru.Text);
            blnKetQua &= !String.IsNullOrEmpty(cboVaiTro.Text);
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

            if(txtGiaTriTimKiem.Text != String.Empty)
            {
                if(cboTieuChiTimKiem.Text == "MSSV")
                {
                    if (chk_TimChinhXac.CheckState == CheckState.Checked)
                        strTieuChiTimKiem += " [MSSV] = '" + txtGiaTriTimKiem.Text + "'";
                    else
                        strTieuChiTimKiem += " [MSSV] Like '%" + txtGiaTriTimKiem.Text + "%'";
                }
                if(cboTieuChiTimKiem.Text == "Họ tên")
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}

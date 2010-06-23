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
    public partial class NhapHoiVienFrm : Form
    {
        public NhapHoiVienFrm()
        {
            InitializeComponent();
        }

        #region Xuat danh sach HoiVien.
        private void NhapHoiVienFrm_Load(object sender, EventArgs e)
        {
            try
            {
                List<DTO.HoiVienDTO> lstHoiVien = HoiVienBUS.LayDanhSachHoiVien();
                XuatDanhSachHoiVien(lstHoiVien);

                // Load danh sach loai hoi vien.
                List<LoaiHoiVienDTO> lstLoaiHoiVien = LoaiHoiVienBUS.LayDanhSachLoaiHoiVien();
                if (lstLoaiHoiVien.Count > 0)
                {
                    this.cboLoaiHoiVien.DataSource = lstLoaiHoiVien;
                    this.cboLoaiHoiVien.DisplayMember = "TenLoai";
                    this.cboLoaiHoiVien.ValueMember = "MaLoai";
                }

                //Load danh sach chuc vu.
                List<ChucVuDTO> lstChucVu = ChucVuBUS.LayDanhSachChucVu();
                if (lstChucVu.Count > 0)
                {
                    this.cboChucVu.DataSource = lstChucVu;
                    this.cboChucVu.DisplayMember = "TenChucVu";
                    this.cboChucVu.ValueMember = "MaChucVu";
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
            cboChucVu.Text = String.Empty;
        }
        #endregion

        #region Nhap HoiVien.
        private void btnLuu_Click(object sender, EventArgs e)
        {
            DTO.HoiVienDTO aHoiVien = NhapHoiVien();
            if (aHoiVien == null)
                return; //khong lam gi ca.  

            try
            {
                if (BUS.HoiVienBUS.ThemHoiVien(aHoiVien))
                {
                    NhapHoiVienFrm_Load(sender, e);
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
            aHoiVien.MaChucVu = int.Parse(cboChucVu.SelectedValue.ToString());

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
            blnKetQua &= !String.IsNullOrEmpty(cboChucVu.Text);
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

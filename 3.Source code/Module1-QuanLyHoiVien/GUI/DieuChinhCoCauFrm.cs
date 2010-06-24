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
    public partial class DieuChinhCoCauFrm : Form
    {
        public DieuChinhCoCauFrm()
        {
            InitializeComponent();
        }

        #region Xuat danh sach: VaiTro, LoaiHoiVien, ChuyenMon va CapBac.
        private void DieuChinhCoCauFrm_Load(object sender, EventArgs e)
        {
            LoadDanhSachVaiTro(sender, e);
            LoadDanhSachLoaiHoiVien(sender, e);
            LoadDanhSachChuyenMon(sender, e);
            LoadDanhSachCapBac(sender, e);
        }

        #region Load danh sach VaiTro.
        private void LoadDanhSachVaiTro(object sender, EventArgs e)
        {
            try
            {
                List<DTO.VaiTroDTO> lstVaiTro = BUS.VaiTroBUS.LayDanhSachVaiTro();
                XuatDanhSachVaiTro(lstVaiTro);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }        

        private void XuatDanhSachVaiTro(List<DTO.VaiTroDTO> lstVaiTro)
        {
            if (lstVaiTro == null)
                return;     //khong lam gi ca.          

            lsvDanhSachVaiTro.Items.Clear();
            int nSoThuTu = 1;
            foreach (DTO.VaiTroDTO aVaiTroTemp in lstVaiTro)
            {
                lsvDanhSachVaiTro.Items.Add(TheHienListItem(nSoThuTu, aVaiTroTemp));
                nSoThuTu++;
            }
        }
        
        private ListViewItem TheHienListItem(int nSoThuTu, DTO.VaiTroDTO aVaiTro)
        {
            ListViewItem itemKetQua = new ListViewItem(nSoThuTu.ToString());
            itemKetQua.SubItems.Add(aVaiTro.MaVaiTro.ToString());
            itemKetQua.SubItems.Add(aVaiTro.TenVaiTro.ToString());
            itemKetQua.SubItems.Add(aVaiTro.MoTa.ToString());
            itemKetQua.Tag = aVaiTro;

            return itemKetQua;
        }

        private void lsvDanhSachVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSachVaiTro.SelectedItems.Count > 0)
            {
                ListViewItem itemVaiTro = lsvDanhSachVaiTro.SelectedItems[0];
                DTO.VaiTroDTO aVaiTro = (DTO.VaiTroDTO)itemVaiTro.Tag;
                XuatChiTietVaiTro(aVaiTro);
            }
        }     

        private void XuatChiTietVaiTro(DTO.VaiTroDTO aVaiTro)
        {
            txtMaVaiTro.Text = aVaiTro.MaVaiTro.ToString();
            txtTenVaiTro.Text = aVaiTro.TenVaiTro;
            txtMoTaVaiTro.Text = aVaiTro.MoTa;
        }
        #endregion       

        #region Load danh sach LoaiHoiVien.
        private void LoadDanhSachLoaiHoiVien(object sender, EventArgs e)
        {
            try
            {
                List<DTO.LoaiHoiVienDTO> lstLoaiHoiVien = BUS.LoaiHoiVienBUS.LayDanhSachLoaiHoiVien();
                XuatDanhSachLoaiHoiVien(lstLoaiHoiVien);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void XuatDanhSachLoaiHoiVien(List<DTO.LoaiHoiVienDTO> lstLoaiHoiVien)
        {
            if (lstLoaiHoiVien == null)
                return;     //khong lam gi ca.          

            lsvDanhSachLoaiHoiVien.Items.Clear();
            int nSoThuTu = 1;
            foreach (DTO.LoaiHoiVienDTO aLoaiHoiVienTemp in lstLoaiHoiVien)
            {
                lsvDanhSachLoaiHoiVien.Items.Add(TheHienListItem(nSoThuTu, aLoaiHoiVienTemp));
                nSoThuTu++;
            }
        }

        private ListViewItem TheHienListItem(int nSoThuTu, DTO.LoaiHoiVienDTO aLoaiHoiVien)
        {
            ListViewItem itemKetQua = new ListViewItem(nSoThuTu.ToString());            
            itemKetQua.SubItems.Add(aLoaiHoiVien.TenLoai.ToString());
            itemKetQua.SubItems.Add(aLoaiHoiVien.MoTa.ToString());            
            itemKetQua.Tag = aLoaiHoiVien;

            return itemKetQua;
        }

        private void lsvDanhSachLoaiHoiVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSachLoaiHoiVien.SelectedItems.Count > 0)
            {
                ListViewItem itemLoaiHoiVien = lsvDanhSachLoaiHoiVien.SelectedItems[0];
                DTO.LoaiHoiVienDTO aLoaiHoiVien = (DTO.LoaiHoiVienDTO)itemLoaiHoiVien.Tag;
                XuatChiTietLoaiHoiVien(aLoaiHoiVien);
            }
        }

        private void XuatChiTietLoaiHoiVien(DTO.LoaiHoiVienDTO aLoaiHoiVien)
        {
            txtMaLoaiHoiVien.Text = aLoaiHoiVien.MaLoai.ToString();
            txtTenLoaiHoiVien.Text = aLoaiHoiVien.TenLoai;
            txtMoTaLoaiHoiVien.Text = aLoaiHoiVien.MoTa;
        }
        #endregion       

        #region Load danh sach ChuyenMon.
        private void LoadDanhSachChuyenMon(object sender, EventArgs e)
        {
            try
            {
                List<DTO.ChuyenMonDTO> lstChuyenMon = BUS.ChuyenMonBUS.LayDanhSachChuyenMon();
                XuatDanhSachChuyenMon(lstChuyenMon);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void XuatDanhSachChuyenMon(List<DTO.ChuyenMonDTO> lstChuyenMon)
        {
            if (lstChuyenMon == null)
                return;     //khong lam gi ca.          

            lsvDanhSachChuyenMon.Items.Clear();
            int nSoThuTu = 1;
            foreach (DTO.ChuyenMonDTO aChuyenMonTemp in lstChuyenMon)
            {
                lsvDanhSachChuyenMon.Items.Add(TheHienListItem(nSoThuTu, aChuyenMonTemp));
                nSoThuTu++;
            }
        }

        private ListViewItem TheHienListItem(int nSoThuTu, DTO.ChuyenMonDTO aChuyenMon)
        {
            ListViewItem itemKetQua = new ListViewItem(nSoThuTu.ToString());
            itemKetQua.SubItems.Add(aChuyenMon.TenChuyenMon.ToString());
            itemKetQua.SubItems.Add(aChuyenMon.MoTa.ToString());
            itemKetQua.Tag = aChuyenMon;

            return itemKetQua;
        }

        private void lsvDanhSachChuyenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSachChuyenMon.SelectedItems.Count > 0)
            {
                ListViewItem itemChuyenMon = lsvDanhSachChuyenMon.SelectedItems[0];
                DTO.ChuyenMonDTO aChuyenMon = (DTO.ChuyenMonDTO)itemChuyenMon.Tag;
                XuatChiTietChuyenMon(aChuyenMon);
            }
        }   

        private void XuatChiTietChuyenMon(DTO.ChuyenMonDTO aChuyenMon)
        {
            txtMaChuyenMon.Text = aChuyenMon.MaChuyenMon.ToString();
            txtTenChuyenMon.Text = aChuyenMon.TenChuyenMon;
            txtMoTaChuyenMon.Text = aChuyenMon.MoTa;
        }
        #endregion  

        #region Load danh sach CapBac.
        private void LoadDanhSachCapBac(object sender, EventArgs e)
        {
            try
            {
                List<DTO.CapBacDTO> lstCapBac = BUS.CapBacBUS.LayDanhSachCapBac();
                XuatDanhSachCapBac(lstCapBac);

                // Load danh sach chuyen mon.
                List<ChuyenMonDTO> lstChuyenMon = ChuyenMonBUS.LayDanhSachChuyenMon();
                if (lstChuyenMon.Count > 0)
                {
                    this.cboChuyenMon.DataSource = lstChuyenMon;
                    this.cboChuyenMon.DisplayMember = "TenChuyenMon";
                    this.cboChuyenMon.ValueMember = "MaChuyenMon";
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void XuatDanhSachCapBac(List<DTO.CapBacDTO> lstCapBac)
        {
            if (lstCapBac == null)
                return;     //khong lam gi ca.          

            lsvDanhSachCapBac.Items.Clear();
            int nSoThuTu = 1;
            foreach (DTO.CapBacDTO aCapBacTemp in lstCapBac)
            {
                lsvDanhSachCapBac.Items.Add(TheHienListItem(nSoThuTu, aCapBacTemp));
                nSoThuTu++;
            }
        }

        private ListViewItem TheHienListItem(int nSoThuTu, DTO.CapBacDTO aCapBac)
        {
            ListViewItem itemKetQua = new ListViewItem(nSoThuTu.ToString());
            itemKetQua.SubItems.Add(aCapBac.MaCapBac.ToString());
            itemKetQua.SubItems.Add(aCapBac.TenCapBac.ToString());
            itemKetQua.SubItems.Add(ChuyenMonBUS.LayTenChuyenMon(aCapBac.MaChuyenMon));
            itemKetQua.Tag = aCapBac;

            return itemKetQua;
        }

        private void lsvDanhSachCapBac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSachCapBac.SelectedItems.Count > 0)
            {
                ListViewItem itemCapBac = lsvDanhSachCapBac.SelectedItems[0];
                DTO.CapBacDTO aCapBac = (DTO.CapBacDTO)itemCapBac.Tag;
                XuatChiTietCapBac(aCapBac);
            }
        }   

        private void XuatChiTietCapBac(DTO.CapBacDTO aCapBac)
        {
            txtMaCapBac.Text = aCapBac.MaCapBac.ToString();
            txtTenCapBac.Text = aCapBac.TenCapBac;
            cboChuyenMon.Text = ChuyenMonBUS.LayTenChuyenMon(aCapBac.MaChuyenMon);
        }
        #endregion  
        #endregion

        #region Them thong tin VaiTro, LoaiHoiVien, ChuyenMon va CapBac.

        #region Them VaiTro.
        private void btn_ThemVaiTro_Click(object sender, EventArgs e)
        {
            DTO.VaiTroDTO aVaiTro = NhapVaiTro();
            if (aVaiTro == null)
                return; //khong lam gi ca.  

            try
            {
                if (BUS.VaiTroBUS.ThemVaiTro(aVaiTro))
                {
                    LoadDanhSachVaiTro(sender, e);
                    ClearFrmVaiTro();
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

        private DTO.VaiTroDTO NhapVaiTro()
        {
            DTO.VaiTroDTO aVaiTro = new DTO.VaiTroDTO();
            if (!KiemTraNhapVaiTro())
                return null;

            aVaiTro.MaVaiTro = int.Parse(txtMaVaiTro.Text);
            aVaiTro.TenVaiTro = txtTenVaiTro.Text;
            aVaiTro.MoTa = txtMoTaVaiTro.Text;

            return aVaiTro;
        }

        private bool KiemTraNhapVaiTro()
        {
            bool blnKetQua = true;

            blnKetQua &= !String.IsNullOrEmpty(txtMaVaiTro.Text);
            blnKetQua &= !String.IsNullOrEmpty(txtTenVaiTro.Text);
            //blnKetQua &= !String.IsNullOrEmpty(txtMoTaVaiTro.Text);
            if (!blnKetQua)
            {
                MessageBox.Show("Du lieu nhap vao khong day du\r\nVui long kiem tra lai");
                return blnKetQua;
            }

            return blnKetQua;
        }

        private void ClearFrmVaiTro()
        {
            txtMaVaiTro.Text = String.Empty;
            txtTenVaiTro.Text = String.Empty;
            txtMoTaVaiTro.Text = String.Empty;
        }
        #endregion

        #region Them LoaiHoiVien.
        private void btnThemLoaiHoiVien_Click(object sender, EventArgs e)
        {
            DTO.LoaiHoiVienDTO aLoaiHoiVien = NhapLoaiHoiVien();
            if (aLoaiHoiVien == null)
                return; //khong lam gi ca.  

            try
            {
                if (BUS.LoaiHoiVienBUS.ThemLoaiHoiVien(aLoaiHoiVien))
                {
                    LoadDanhSachLoaiHoiVien(sender, e);
                    ClearFrmLoaiHoiVien();
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

        private DTO.LoaiHoiVienDTO NhapLoaiHoiVien()
        {
            DTO.LoaiHoiVienDTO aLoaiHoiVien = new DTO.LoaiHoiVienDTO();
            if (!KiemTraNhapLoaiHoiVien())
                return null;

            if (txtMaLoaiHoiVien.Text == String.Empty)
                aLoaiHoiVien.MaLoai = 0;
            else
                aLoaiHoiVien.MaLoai = int.Parse(txtMaLoaiHoiVien.Text);            
            aLoaiHoiVien.TenLoai = txtTenLoaiHoiVien.Text;
            aLoaiHoiVien.MoTa = txtMoTaLoaiHoiVien.Text;

            return aLoaiHoiVien;
        }

        private bool KiemTraNhapLoaiHoiVien()
        {
            bool blnKetQua = true;

            //blnKetQua &= !String.IsNullOrEmpty(txtMaLoaiHoiVien.Text);
            blnKetQua &= !String.IsNullOrEmpty(txtTenLoaiHoiVien.Text);
            //blnKetQua &= !String.IsNullOrEmpty(txtMoTaLoaiHoiVien.Text);
            if (!blnKetQua)
            {
                MessageBox.Show("Du lieu nhap vao khong day du\r\nVui long kiem tra lai");
                return blnKetQua;
            }

            return blnKetQua;
        }

        private void ClearFrmLoaiHoiVien()
        {
            txtMaLoaiHoiVien.Text = String.Empty;
            txtTenLoaiHoiVien.Text = String.Empty;
            txtMoTaLoaiHoiVien.Text = String.Empty;
        }
        #endregion

        #region Them ChuyenMon.
        private void btnThemChuyenMon_Click(object sender, EventArgs e)
        {
            DTO.ChuyenMonDTO aChuyenMon = NhapChuyenMon();
            if (aChuyenMon == null)
                return; //khong lam gi ca.  

            try
            {
                if (BUS.ChuyenMonBUS.ThemChuyenMon(aChuyenMon))
                {
                    LoadDanhSachChuyenMon(sender, e);
                    ClearFrmChuyenMon();
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

        private DTO.ChuyenMonDTO NhapChuyenMon()
        {
            DTO.ChuyenMonDTO aChuyenMon = new DTO.ChuyenMonDTO();
            if (!KiemTraNhapChuyenMon())
                return null;

            if (txtMaChuyenMon.Text == String.Empty)
                aChuyenMon.MaChuyenMon = 0;
            else
                aChuyenMon.MaChuyenMon = int.Parse(txtMaChuyenMon.Text);
            aChuyenMon.TenChuyenMon = txtTenChuyenMon.Text;
            aChuyenMon.MoTa = txtMoTaChuyenMon.Text;

            return aChuyenMon;
        }

        private bool KiemTraNhapChuyenMon()
        {
            bool blnKetQua = true;

            //blnKetQua &= !String.IsNullOrEmpty(txtMaChuyenMon.Text);
            blnKetQua &= !String.IsNullOrEmpty(txtTenChuyenMon.Text);
            //blnKetQua &= !String.IsNullOrEmpty(txtMoTaChuyenMon.Text);
            if (!blnKetQua)
            {
                MessageBox.Show("Du lieu nhap vao khong day du\r\nVui long kiem tra lai");
                return blnKetQua;
            }

            return blnKetQua;
        }

        private void ClearFrmChuyenMon()
        {
            txtMaChuyenMon.Text = String.Empty;
            txtTenChuyenMon.Text = String.Empty;
            txtMoTaChuyenMon.Text = String.Empty;
        }
        #endregion

        #region Them CapBac.
        private void btnThemCapBac_Click(object sender, EventArgs e)
        {
            DTO.CapBacDTO aCapBac = NhapCapBac();
            if (aCapBac == null)
                return; //khong lam gi ca.  

            try
            {
                if (BUS.CapBacBUS.ThemCapBac(aCapBac))
                {
                    LoadDanhSachCapBac(sender, e);
                    ClearFrmCapBac();
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
       
        private DTO.CapBacDTO NhapCapBac()
        {
            DTO.CapBacDTO aCapBac = new DTO.CapBacDTO();
            if (!KiemTraNhapCapBac())
                return null;

            aCapBac.MaCapBac = int.Parse(txtMaCapBac.Text);
            aCapBac.TenCapBac = txtTenCapBac.Text;
            aCapBac.MaChuyenMon = int.Parse(cboChuyenMon.SelectedValue.ToString());

            return aCapBac;
        }

        private bool KiemTraNhapCapBac()
        {
            bool blnKetQua = true;

            blnKetQua &= !String.IsNullOrEmpty(txtMaCapBac.Text);
            blnKetQua &= !String.IsNullOrEmpty(txtTenCapBac.Text);
            blnKetQua &= !String.IsNullOrEmpty(cboChuyenMon.Text);
            if (!blnKetQua)
            {
                MessageBox.Show("Du lieu nhap vao khong day du\r\nVui long kiem tra lai");
                return blnKetQua;
            }

            return blnKetQua;
        }

        private void ClearFrmCapBac()
        {
            txtMaCapBac.Text = String.Empty;
            txtTenCapBac.Text = String.Empty;            
        }
        #endregion
        #endregion

        #region Xoa thong tin VaiTro, LoaiHoiVien, ChuyenMon va CapBac.

        #region Xoa VaiTro.
        private void btn_XoaVaiTro_Click(object sender, EventArgs e)
        {
            if (lsvDanhSachVaiTro.CheckedItems.Count > 0)
            {
                try
                {
                    foreach (ListViewItem itemVaiTro in lsvDanhSachVaiTro.CheckedItems)
                    {
                        DTO.VaiTroDTO aVaiTro = (DTO.VaiTroDTO)itemVaiTro.Tag;
                        if (BUS.VaiTroBUS.XoaVaiTro(aVaiTro))
                        {
                            lsvDanhSachVaiTro.Items.Remove(itemVaiTro);
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
                if (lsvDanhSachVaiTro.SelectedItems.Count > 0)
                {
                    try
                    {
                        foreach (ListViewItem itemVaiTro in lsvDanhSachVaiTro.SelectedItems)
                        {
                            DTO.VaiTroDTO aVaiTro = (DTO.VaiTroDTO)itemVaiTro.Tag;
                            if (BUS.VaiTroBUS.XoaVaiTro(aVaiTro))
                            {
                                lsvDanhSachVaiTro.Items.Remove(itemVaiTro);
                            }
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex.Message);
                    }
                }
                else
                    MessageBox.Show("Chua co vai tro nao duoc chon");
            }
        }

        private void chkChonTatCaVaiTro_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChonTatCaVaiTro.CheckState == CheckState.Checked)
            {
                foreach (ListViewItem itemVaiTro in lsvDanhSachVaiTro.Items)
                {
                    itemVaiTro.Checked = true;
                }
            }
            else
            {
                foreach (ListViewItem itemVaiTro in lsvDanhSachVaiTro.Items)
                {
                    itemVaiTro.Checked = false;
                }
            }
        } 
        #endregion

        #region Xoa LoaiHoiVien.
        private void btnXoaLoaiHoiVien_Click(object sender, EventArgs e)
        {
            if (lsvDanhSachLoaiHoiVien.CheckedItems.Count > 0)
            {
                try
                {
                    foreach (ListViewItem itemLoaiHoiVien in lsvDanhSachLoaiHoiVien.CheckedItems)
                    {
                        DTO.LoaiHoiVienDTO aLoaiHoiVien = (DTO.LoaiHoiVienDTO)itemLoaiHoiVien.Tag;
                        if (BUS.LoaiHoiVienBUS.XoaLoaiHoiVien(aLoaiHoiVien))
                        {
                            lsvDanhSachLoaiHoiVien.Items.Remove(itemLoaiHoiVien);
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
                if (lsvDanhSachLoaiHoiVien.SelectedItems.Count > 0)
                {
                    try
                    {
                        foreach (ListViewItem itemLoaiHoiVien in lsvDanhSachLoaiHoiVien.SelectedItems)
                        {
                            DTO.LoaiHoiVienDTO aLoaiHoiVien = (DTO.LoaiHoiVienDTO)itemLoaiHoiVien.Tag;
                            if (BUS.LoaiHoiVienBUS.XoaLoaiHoiVien(aLoaiHoiVien))
                            {
                                lsvDanhSachLoaiHoiVien.Items.Remove(itemLoaiHoiVien);
                            }
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex.Message);
                    }
                }
                else
                    MessageBox.Show("Chua co loai hoi vien nao duoc chon");
            }
        }

        private void chkChonTatCaLoaiHoiVien_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChonTatCaLoaiHoiVien.CheckState == CheckState.Checked)
            {
                foreach (ListViewItem itemLoaiHoiVien in lsvDanhSachLoaiHoiVien.Items)
                {
                    itemLoaiHoiVien.Checked = true;
                }
            }
            else
            {
                foreach (ListViewItem itemLoaiHoiVien in lsvDanhSachLoaiHoiVien.Items)
                {
                    itemLoaiHoiVien.Checked = false;
                }
            }
        } 
        #endregion

        #region Xoa ChuyenMon.
        private void btnXoaChuyenMon_Click(object sender, EventArgs e)
        {
            if (lsvDanhSachChuyenMon.CheckedItems.Count > 0)
            {
                try
                {
                    foreach (ListViewItem itemChuyenMon in lsvDanhSachChuyenMon.CheckedItems)
                    {
                        DTO.ChuyenMonDTO aChuyenMon = (DTO.ChuyenMonDTO)itemChuyenMon.Tag;
                        if (BUS.ChuyenMonBUS.XoaChuyenMon(aChuyenMon))
                        {
                            lsvDanhSachChuyenMon.Items.Remove(itemChuyenMon);
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
                if (lsvDanhSachChuyenMon.SelectedItems.Count > 0)
                {
                    try
                    {
                        foreach (ListViewItem itemChuyenMon in lsvDanhSachChuyenMon.SelectedItems)
                        {
                            DTO.ChuyenMonDTO aChuyenMon = (DTO.ChuyenMonDTO)itemChuyenMon.Tag;
                            if (BUS.ChuyenMonBUS.XoaChuyenMon(aChuyenMon))
                            {
                                lsvDanhSachChuyenMon.Items.Remove(itemChuyenMon);
                            }
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex.Message);
                    }
                }
                else
                    MessageBox.Show("Chua co chuyen mon nao duoc chon");
            }
        }

        private void chkChonTatCaChuyenMon_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChonTatCaChuyenMon.CheckState == CheckState.Checked)
            {
                foreach (ListViewItem itemChuyenMon in lsvDanhSachChuyenMon.Items)
                {
                    itemChuyenMon.Checked = true;
                }
            }
            else
            {
                foreach (ListViewItem itemChuyenMon in lsvDanhSachChuyenMon.Items)
                {
                    itemChuyenMon.Checked = false;
                }
            }
        }       
        #endregion

        #region Xoa CapBac.
        private void btnXoaCapBac_Click(object sender, EventArgs e)
        {
            if (lsvDanhSachCapBac.CheckedItems.Count > 0)
            {
                try
                {
                    foreach (ListViewItem itemCapBac in lsvDanhSachCapBac.CheckedItems)
                    {
                        DTO.CapBacDTO aCapBac = (DTO.CapBacDTO)itemCapBac.Tag;
                        if (BUS.CapBacBUS.XoaCapBac(aCapBac))
                        {
                            lsvDanhSachCapBac.Items.Remove(itemCapBac);
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
                if (lsvDanhSachCapBac.SelectedItems.Count > 0)
                {
                    try
                    {
                        foreach (ListViewItem itemCapBac in lsvDanhSachCapBac.SelectedItems)
                        {
                            DTO.CapBacDTO aCapBac = (DTO.CapBacDTO)itemCapBac.Tag;
                            if (BUS.CapBacBUS.XoaCapBac(aCapBac))
                            {
                                lsvDanhSachCapBac.Items.Remove(itemCapBac);
                            }
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex.Message);
                    }
                }
                else
                    MessageBox.Show("Chua co cap bac nao duoc chon");
            }
        }

        private void chkChonTatCaCapBac_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChonTatCaCapBac.CheckState == CheckState.Checked)
            {
                foreach (ListViewItem itemCapBac in lsvDanhSachCapBac.Items)
                {
                    itemCapBac.Checked = true;
                }
            }
            else
            {
                foreach (ListViewItem itemCapBac in lsvDanhSachCapBac.Items)
                {
                    itemCapBac.Checked = false;
                }
            }
        }   
        #endregion
        #endregion

        #region Sua thong tin VaiTro, LoaiHoiVien, ChuyenMon va CapBac.

        #region Sua VaiTro
        private void btn_SuaVaiTro_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMaVaiTro.Text))
            {
                try
                {
                    DTO.VaiTroDTO aVaiTro = NhapVaiTro();
                    if (aVaiTro == null)
                        return; //khong lam gi ca.                                                            

                    if (BUS.VaiTroBUS.CapNhatVaiTro(aVaiTro))
                    {
                        LoadDanhSachVaiTro(sender, e);
                        ClearFrmVaiTro();
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Chua co vai tro nao dc chon");
            }
        }        
        #endregion

        #region Sua LoaiHoiVien
        private void btnSuaLoaiHoiVien_Click(object sender, EventArgs e)
        {            
            if (!String.IsNullOrEmpty(txtMaLoaiHoiVien.Text))
            {
                try
                {
                    DTO.LoaiHoiVienDTO aLoaiHoiVien = NhapLoaiHoiVien();
                    if (aLoaiHoiVien == null)
                        return; //khong lam gi ca.                                                            
                    
                    if (LoaiHoiVienBUS.CapNhatLoaiHoiVien(aLoaiHoiVien))
                    {                        
                        LoadDanhSachLoaiHoiVien(sender, e);
                        ClearFrmLoaiHoiVien();
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Chua co loai hoi vien nao dc chon");
            }
        }        
        #endregion

        #region Sua ChuyenMon
        private void btnSuaChuyenMon_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMaChuyenMon.Text))
            {
                try
                {
                    DTO.ChuyenMonDTO aChuyenMon = NhapChuyenMon();
                    if (aChuyenMon == null)
                        return; //khong lam gi ca.                                                            

                    if (BUS.ChuyenMonBUS.CapNhatChuyenMon(aChuyenMon))
                    {
                        LoadDanhSachChuyenMon(sender, e);
                        ClearFrmChuyenMon();
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Chua co loai hoi vien nao dc chon");
            }
        }        
        #endregion

        #region Sua CapBac
        private void btnSuaCapBac_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMaCapBac.Text))
            {
                try
                {
                    DTO.CapBacDTO aCapBac = NhapCapBac();
                    if (aCapBac == null)
                        return; //khong lam gi ca.                                                            

                    if (BUS.CapBacBUS.CapNhatCapBac(aCapBac))
                    {
                        LoadDanhSachCapBac(sender, e);
                        ClearFrmCapBac();
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Chua co loai hoi vien nao dc chon");
            }
        }         
        #endregion
        #endregion

        #region Tra cuu CapBac theo ChuyenMon
        private void btnTrichLoc_Click(object sender, EventArgs e)
        {
            String strTieuChiTimKiem = NhapThamSoTimKiem();

            try
            {
                List<DTO.CapBacDTO> lstCapBac = CapBacBUS.LayDanhSachCapBac(strTieuChiTimKiem);
                XuatDanhSachCapBac(lstCapBac);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private String NhapThamSoTimKiem()
        {
            String strTieuChiTimKiem = String.Empty;

            if (cboChuyenMon.Text != String.Empty)
            {
                strTieuChiTimKiem += " [MaChuyenMon] = " + int.Parse(cboChuyenMon.SelectedValue.ToString());
            }

            return strTieuChiTimKiem;
        }

        #endregion                                            
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}

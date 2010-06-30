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
    public partial class TraCuuHoiVienFrm : Form
    {
        public TraCuuHoiVienFrm()
        {
            InitializeComponent();
        }

        #region Xuat danh sach HoiVien.
        private void TraCuuHoiVienFrm_Load(object sender, EventArgs e)
        {
            try
            {
                List<DTO.HoiVienDTO> lstHoiVien = HoiVienBUS.LayDanhSachHoiVien();
                XuatDanhSachHoiVien(lstHoiVien);

                //Select tieu chi tiem kiem.
                cboTieuChiTimKiem.SelectedIndex = 0;
                cboRangBuocTiemKiem.SelectedIndex = 0;
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
            itemKetQua.SubItems.Add(aHoiVien.DienThoai);
            //Xu ly van de DTL tai day.
            itemKetQua.Tag = aHoiVien;

            return itemKetQua;
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

            strTieuChiTimKiem += NhapThamSoTimKiem1();            
            strTieuChiTimKiem += " And " + NhapThamSoTimKiem2();
            
            return strTieuChiTimKiem;
        }

        private String NhapThamSoTimKiem1()
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
                if(cboTieuChiTimKiem.Text == "Loại hội viên")
                {
                    List<LoaiHoiVienDTO> lstLoaiHoiVien = LoaiHoiVienBUS.LayDanhSachLoaiHoiVien();
                    foreach(LoaiHoiVienDTO aLoaiHoiVien in lstLoaiHoiVien)
                    {
                        Boolean blnKiemTra = false;
                        blnKiemTra |= aLoaiHoiVien.TenLoai.ToLower().Contains(txtGiaTriTimKiem.Text.ToLower());
                        blnKiemTra |= (aLoaiHoiVien.TenLoai.ToLower() == txtGiaTriTimKiem.Text.ToLower());
                        if(blnKiemTra)
                        {
                            strTieuChiTimKiem += "[MaLoaiHoiVien] = " + aLoaiHoiVien.MaLoai;
                            break;
                        }
                    }
                    if(strTieuChiTimKiem == String.Empty)
                    {
                        strTieuChiTimKiem += "[MaLoaiHoiVien] < [MaLoaiHoiVien]";
                    }
                }
                if (cboTieuChiTimKiem.Text == "Vai trò")
                {                    
                    if(txtGiaTriTimKiem.Text.ToLower() == "ban quản lý")
                    {
                        strTieuChiTimKiem += "[MaVaiTro] > 19";
                    }
                    else if(txtGiaTriTimKiem.Text.ToLower() == "ban nhân sự")
                    {
                        strTieuChiTimKiem += "([MaVaiTro] / 10) = 2";
                    }
                    else if (txtGiaTriTimKiem.Text.ToLower() == "ban chuyên môn")
                    {
                        strTieuChiTimKiem += "([MaVaiTro] / 10) = 3";
                    }
                    else if (txtGiaTriTimKiem.Text.ToLower() == "ban tài chính")
                    {
                        strTieuChiTimKiem += "([MaVaiTro] / 10) = 4";
                    }
                    else if (txtGiaTriTimKiem.Text.ToLower() == "ban thông tin")
                    {
                        strTieuChiTimKiem += "([MaVaiTro] / 10) = 5";
                    }
                    else if (txtGiaTriTimKiem.Text.ToLower() == "ban chủ nhiệm")
                    {                        
                        strTieuChiTimKiem += "[MaVaiTro] > 99";
                    }
                    else
                    {
                        List<VaiTroDTO> lstVaiTro = VaiTroBUS.LayDanhSachVaiTro();
                        foreach (VaiTroDTO aVaiTro in lstVaiTro)
                        {
                            Boolean blnKiemTra = false;
                            blnKiemTra |= aVaiTro.TenVaiTro.ToLower().Contains(txtGiaTriTimKiem.Text.ToLower());
                            blnKiemTra |= (aVaiTro.TenVaiTro.ToLower() == txtGiaTriTimKiem.Text.ToLower());
                            if (blnKiemTra)
                            {                                
                                strTieuChiTimKiem += "[MaVaiTro] = " + aVaiTro.MaVaiTro;
                                break;
                            }
                        }  
                    }                                      
                    if (strTieuChiTimKiem == String.Empty)
                    {
                        MessageBox.Show("Tets");
                        strTieuChiTimKiem += "1 > 1";
                    }
                }
                if(cboTieuChiTimKiem.Text == "Chuyên môn")
                {
                    MessageBox.Show("Chức năng tra cứu theo chuyên môn sẽ được cập nhật sau");
                }
                if(cboTieuChiTimKiem.Text == "Cấp bậc chuyên môn")
                {
                    MessageBox.Show("Chức năng tra cứu theo cấp bậc chuyên môn sẽ được cập nhật sau");
                }                
            }

            if (strTieuChiTimKiem == String.Empty)
            {
                strTieuChiTimKiem = "1 = 1";                
            }

            return strTieuChiTimKiem;
        }

        private String NhapThamSoTimKiem2()
        {
            String strTieuChiTimKiem = String.Empty;
                        
            if (txtGiaTriRangBuoc.Text != String.Empty)
            {
                if(cboRangBuocTiemKiem.Text == "ĐRL")
                {
                    MessageBox.Show("Chức năng tra cứu theo ĐRL sẽ được cập nhật sau");
                }
                if(cboRangBuocTiemKiem.Text == "Là Đoàn viên")
                {
                    if (txtGiaTriRangBuoc.Text.ToLower() == "true")
                        strTieuChiTimKiem += "[LaDoanVien] = 'true'";
                    else if (txtGiaTriRangBuoc.Text.ToLower() == "false")
                        strTieuChiTimKiem += "[LaDoanVien] = 'false'";
                    else
                        strTieuChiTimKiem += "1 > 1";
                }
                if(cboRangBuocTiemKiem.Text == "Là Hội viên")
                {
                    if (txtGiaTriRangBuoc.Text.ToLower() == "true")
                        strTieuChiTimKiem += "[LaHoiVien] = 'true'";
                    else if (txtGiaTriRangBuoc.Text.ToLower() == "false")
                        strTieuChiTimKiem += "[LaHoiVien] = 'false'";
                    else
                        strTieuChiTimKiem += "1 > 1";
                }
                if(cboRangBuocTiemKiem.Text == "Là Đảng viên")
                {
                    if (txtGiaTriRangBuoc.Text.ToLower() == "true")
                        strTieuChiTimKiem += "[LaDangVien] = 'true'";
                    else if (txtGiaTriRangBuoc.Text.ToLower() == "false")
                        strTieuChiTimKiem += "[LaDangVien] = 'false'";
                    else
                        strTieuChiTimKiem += "1 > 1";
                }
                if(cboRangBuocTiemKiem.Text == "Email")
                {                    
                    if (chk_TimChinhXac.CheckState == CheckState.Checked)
                        strTieuChiTimKiem += "[Email] = '" + txtGiaTriRangBuoc.Text + "'";
                    else
                        strTieuChiTimKiem += "[Email] Like '%" + txtGiaTriRangBuoc.Text + "%'";
                }
                if(cboRangBuocTiemKiem.Text == "Điện thoại")
                {
                    if (chk_TimChinhXac.CheckState == CheckState.Checked)
                        strTieuChiTimKiem += "[DienThoai] = '" + txtGiaTriRangBuoc.Text + "'";
                    else
                        strTieuChiTimKiem += "[DienThoai] Like '%" + txtGiaTriRangBuoc.Text + "%'";
                }
                if(cboRangBuocTiemKiem.Text == "Chỗ ở hiện nay")
                {
                    if (chk_TimChinhXac.CheckState == CheckState.Checked)
                        strTieuChiTimKiem += "[ChoOHienNay] = '" + txtGiaTriRangBuoc.Text + "'";
                    else
                        strTieuChiTimKiem += "[ChoOHienNay] Like '%" + txtGiaTriRangBuoc.Text + "%'";
                }
                if(cboRangBuocTiemKiem.Text == "Địa chỉ thường trú")
                {
                    if (chk_TimChinhXac.CheckState == CheckState.Checked)
                        strTieuChiTimKiem += "[DiaChiThuongTru] = '" + txtGiaTriRangBuoc.Text + "'";
                    else
                        strTieuChiTimKiem += "[DiaChiThuongTru] Like '%" + txtGiaTriRangBuoc.Text + "%'";
                }                
            }

            if (strTieuChiTimKiem == String.Empty)
                strTieuChiTimKiem = "1 = 1";
            return strTieuChiTimKiem;
        }

        #endregion        

        #region Thao tac tren danh sach
        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng xem chi tiết sẽ được cập nhật sau");
        }

        private void btnXemToanBo_Click(object sender, EventArgs e)
        {
            XemDanhSachHoiVienFrm frm = new XemDanhSachHoiVienFrm();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }          

        private void btnLayEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng lấy email sẽ được cập nhật sau");
        }

        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng in danh sách sẽ được cập nhật sau");
        }

        private void dgvDanhSach_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CapNhatHoiVienFrm frm = new CapNhatHoiVienFrm();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
        #endregion

        #region Thao tac tren Dialog.
        private void btnThem_Click(object sender, EventArgs e)
        {
            NhapHoiVienFrm frm = new NhapHoiVienFrm();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaHoiVienFrm frm = new XoaHoiVienFrm();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            CapNhatHoiVienFrm frm = new CapNhatHoiVienFrm();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion                

    }
}

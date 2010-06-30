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
    public partial class DiemDanhFrm : Form
    {
        private List<BuoiSinhHoatDTO> _DanhSachBuoiSinhHoat;
        private List<HoiVienDTO> _DanhSachHoiVien;
        private bool _blnChonTatCa;
        public DiemDanhFrm()
        {
            InitializeComponent();
            _blnChonTatCa = false;
        }

        private void btnThemHoiVien_Click(object sender, EventArgs e)
        {
            NhapHoiVienFrm frm = new NhapHoiVienFrm();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void DiemDanhFrm_Load(object sender, EventArgs e)
        {
            try
            {
                _DanhSachBuoiSinhHoat = BuoiSinhHoatBUS.SelectAllBuoiSinhHoat();
                if (_DanhSachBuoiSinhHoat.Count > 0)
                {
                    this.cboNgaySinhHoat.DataSource = _DanhSachBuoiSinhHoat;
                    this.cboNgaySinhHoat.DisplayMember = "ThoiGian";
                    this.cboNgaySinhHoat.ValueMember = "MaBuoi";
                    this.cboNgaySinhHoat.SelectedIndex = this.cboNgaySinhHoat.Items.Count - 1;

                    _DanhSachHoiVien = HoiVienBUS.LayDanhSachHoiVien();
                    this.dgvDanhSach.AutoGenerateColumns = false;
                    this.dgvDanhSach.DataSource = _DanhSachHoiVien;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboNgaySinhHoat_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtDiaDiem.Text = _DanhSachBuoiSinhHoat[this.cboNgaySinhHoat.SelectedIndex].DiaDiem;
        }

        private void chkChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkChonTatCa.Checked == true)
            {
                foreach (DataGridViewRow aRow in this.dgvDanhSach.Rows)
                {
                    aRow.Cells["Chon"].Value = true;
                }
                this.chkChonTatCa.Text = "Bỏ chọn tất cả";
            }
            else 
            {
                foreach (DataGridViewRow aRow in this.dgvDanhSach.Rows)
                {
                    aRow.Cells["Chon"].Value = false;
                }
                this.chkChonTatCa.Text = "Chọn tất cả";
            }
        }

        private void btnThemBuoiSinhHoat_Click(object sender, EventArgs e)
        {
            NhapBuoiSinhHoatFrm frm = new NhapBuoiSinhHoatFrm();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThamGiaSinhHoatDTO aThamGiaSinhHoat = new ThamGiaSinhHoatDTO();
            aThamGiaSinhHoat.MaBuoi = int.Parse(this.cboNgaySinhHoat.SelectedValue.ToString());
            bool blnInsertSuccessfully = true;
            DataGridViewRow aRow = new DataGridViewRow();
            for (int i = 0; i < this.dgvDanhSach.Rows.Count; i++)
            {
                aRow = this.dgvDanhSach.Rows[i];
                if (aRow.Cells["Chon"] != null && aRow.Cells["Chon"].Value != null && (bool)aRow.Cells["Chon"].Value == true)
                {
                    try
                    {
                        aThamGiaSinhHoat.MSSV = this._DanhSachHoiVien[i].MSSV;
                        blnInsertSuccessfully &= ThamGiaSinhHoatBUS.InsertThamGiaSinhHoat(aThamGiaSinhHoat);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            if (blnInsertSuccessfully == true)
            {
                MessageBox.Show("Lưu thành công");
            }
            else
            {
                MessageBox.Show("Lưu thất bại");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDanhSach_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.ColumnIndex == 0)
            //{
            //    DataGridViewCheckBoxCell aCell =
            //        (DataGridViewCheckBoxCell)this.dgvDanhSach.Rows[e.RowIndex].Cells[0];
            //    if (aCell == null || aCell.Value == null || (CheckState)aCell.Value == CheckState.Unchecked)
            //    {
            //        aCell.Value = CheckState.Checked;
            //    }
            //    else
            //    {
            //        aCell.Value = CheckState.Unchecked;
            //    }
            //}
        }
    }
}

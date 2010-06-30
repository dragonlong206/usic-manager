using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class HoiVienDTO
    {
        #region Properites
        private String _strMSSV;
        private String _strHoTen = String.Empty;
        private String _strEmail = String.Empty;
        private String _strDienThoai = String.Empty;
        private bool _blnLaDoanVien;
        private bool _blnLaHoiVien;
        private bool _blnLaDangVien;
        private int _intMaLoaiHoiVien;
        private String _strChoOHienNay = String.Empty;        
        private String _strDiaChiThuongTru = String.Empty;
        private int _intMaVaiTro;
        private int _intMaCapBac;       
        #endregion               

        #region PublicAccess
        public String MSSV
        {
            get { return _strMSSV; }
            set { _strMSSV = value; }
        }

        public String HoTen
        {
            get { return _strHoTen; }
            set { _strHoTen = value; }
        }

        public String Email
        {
            get { return _strEmail; }
            set { _strEmail = value; }
        }

        public String DienThoai
        {
            get { return _strDienThoai; }
            set { _strDienThoai = value; }
        }

        public bool LaDoanVien
        {
            get { return _blnLaDoanVien; }
            set { _blnLaDoanVien = value; }
        }

        public bool LaHoiVien
        {
            get { return _blnLaHoiVien; }
            set { _blnLaHoiVien = value; }
        }

        public bool LaDangVien
        {
            get { return _blnLaDangVien; }
            set { _blnLaDangVien = value; }
        }

        public int MaLoaiHoiVien
        {
            get { return _intMaLoaiHoiVien; }
            set { _intMaLoaiHoiVien = value; }
        }

        public String ChoOHienNay
        {
            get { return _strChoOHienNay; }
            set { _strChoOHienNay = value; }
        }

        public String DiaChiThuongTru
        {
            get { return _strDiaChiThuongTru; }
            set { _strDiaChiThuongTru = value; }
        }

        public int MaVaiTro
        {
            get { return _intMaVaiTro; }
            set { _intMaVaiTro = value; }
        }

        public int MaCapBac
        {
            get { return _intMaCapBac; }
            set { _intMaCapBac = value; }
        }
        #endregion

        #region Constructor
        public HoiVienDTO()
        {
            _strMSSV = String.Empty;
            _strHoTen = String.Empty;
            _strEmail = String.Empty;
            _strDienThoai = String.Empty;
            _intMaLoaiHoiVien = 0;
            _blnLaHoiVien = false;
            _blnLaDoanVien = false;
            _blnLaDangVien = false;
            _strChoOHienNay = String.Empty;
            _strDiaChiThuongTru = String.Empty;
            _intMaVaiTro = 0;
            _intMaCapBac = 0;
        }
        #endregion
    }
}

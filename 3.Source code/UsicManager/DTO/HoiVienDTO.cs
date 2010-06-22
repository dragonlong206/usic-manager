using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class HoiVienDTO
    {
        #region Properites
        private string _strMSSV;
        private string _strHoTen = String.Empty;
        private string _strEmail = String.Empty;
        private string _strDienThoai = String.Empty;
        private bool _blnLaDoanVien;
        private bool _blnLaHoiVien;
        private bool _blnLaDangVien;
        private int _intLoaiHoiVien;
        #endregion

        #region PublicAccess
        public string MSSV
        {
            get { return _strMSSV; }
            set { _strMSSV = value; }
        }

        public string HoTen
        {
            get { return _strHoTen; }
            set { _strHoTen = value; }
        }

        public string Email
        {
            get { return _strEmail; }
            set { _strEmail = value; }
        }

        public string DienThoai
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

        public int LoaiHoiVien
        {
            get { return _intLoaiHoiVien; }
            set { _intLoaiHoiVien = value; }
        }
        #endregion

        #region Constructor
        public HoiVienDTO()
        {
            _strMSSV = String.Empty;
            _strHoTen = String.Empty;
            _strEmail = String.Empty;
            _strDienThoai = String.Empty;
            _intLoaiHoiVien = 0;
            _blnLaHoiVien = false;
            _blnLaDoanVien = false;
            _blnLaDangVien = false;
        }
        #endregion
    }
}

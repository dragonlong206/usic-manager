using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LoaiHoiVienDTO
    {
        #region Properties.
        private int _intMaLoai;        
        private String _strTenLoai;        
        #endregion

        #region PublicAcess.
        public int MaLoai
        {
            get { return _intMaLoai; }
            set { _intMaLoai = value; }
        }

        public String TenLoai
        {
            get { return _strTenLoai; }
            set { _strTenLoai = value; }
        }
        #endregion

        #region Construction.
        public LoaiHoiVienDTO()
        {
            _intMaLoai = 0;
            _strTenLoai = String.Empty;
        }
        #endregion
    }
}

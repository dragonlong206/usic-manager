using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChucVuDTO
    {
        #region Properties
        private int _intMaChucVu;        
        private String _strTenChucVu;        
        private String _strMoTa;        
        #endregion

        #region PublicAccess
        public int MaChucVu
        {
            get { return _intMaChucVu; }
            set { _intMaChucVu = value; }
        }

        public String TenChucVu
        {
            get { return _strTenChucVu; }
            set { _strTenChucVu = value; }
        }

        public String MoTa
        {
            get { return _strMoTa; }
            set { _strMoTa = value; }
        }
        #endregion

        #region Contructions
        public ChucVuDTO()
        {
            _intMaChucVu = 0;
            _strTenChucVu = String.Empty;
            _strMoTa = String.Empty;
        }
        #endregion
    }
}

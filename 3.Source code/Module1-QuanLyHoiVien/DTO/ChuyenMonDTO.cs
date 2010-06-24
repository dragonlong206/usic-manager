using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChuyenMonDTO
    {
        #region Properties
        private int _intMaChuyenMon;        
        private String _strTenChuyenMon;       
        private String _strMoTa;        
        #endregion

        #region PublicAccess
        public int MaChuyenMon
        {
            get { return _intMaChuyenMon; }
            set { _intMaChuyenMon = value; }
        }

        public String TenChuyenMon
        {
            get { return _strTenChuyenMon; }
            set { _strTenChuyenMon = value; }
        }

        public String MoTa
        {
            get { return _strMoTa; }
            set { _strMoTa = value; }
        }
        #endregion

        #region Contructions
        public ChuyenMonDTO()
        {
            _intMaChuyenMon = 0;
            _strTenChuyenMon = String.Empty;
            _strMoTa = String.Empty;
        }
        #endregion
    }
}

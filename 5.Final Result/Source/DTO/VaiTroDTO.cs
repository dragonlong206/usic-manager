using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class VaiTroDTO
    {
        #region Properties
        private int _intMaVaiTro;        
        private String _strTenVaiTro;        
        private String _strMoTa;        
        #endregion

        #region PublicAccess
        public int MaVaiTro
        {
            get { return _intMaVaiTro; }
            set { _intMaVaiTro = value; }
        }

        public String TenVaiTro
        {
            get { return _strTenVaiTro; }
            set { _strTenVaiTro = value; }
        }

        public String MoTa
        {
            get { return _strMoTa; }
            set { _strMoTa = value; }
        }
        #endregion

        #region Contructions
        public VaiTroDTO()
        {
            _intMaVaiTro = 0;
            _strTenVaiTro = String.Empty;
            _strMoTa = String.Empty;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class CapBacDTO
    {
        #region Properties
        private int _intMaCapBac;       
        private String _strTenCapBac;       
        private int _intMaChuyenMon;      
        #endregion

        #region PublicAccess
        public int MaCapBac
        {
            get { return _intMaCapBac; }
            set { _intMaCapBac = value; }
        }

        public String TenCapBac
        {
            get { return _strTenCapBac; }
            set { _strTenCapBac = value; }
        }

        public int MaChuyenMon
        {
            get { return _intMaChuyenMon; }
            set { _intMaChuyenMon = value; }
        }
        #endregion

        #region Constructions
        public CapBacDTO()
        {
            _intMaCapBac = 0;
            _strTenCapBac = String.Empty;
            _intMaChuyenMon = 0;
        }
        #endregion
    }
}

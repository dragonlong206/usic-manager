using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ThamGiaSinhHoatDTO
    {
        private int _intMaBuoi;
        private String _strMSSV;

        public int MaBuoi
        {
            get
            {
                return _intMaBuoi;
            }

            set
            {
                _intMaBuoi = value;
            }
        }

        public String MSSV
        {
            get
            {
                return _strMSSV;
            }

            set
            {
                _strMSSV = value;
            }
        }

        public ThamGiaSinhHoatDTO()
        {
            _intMaBuoi = -1;
            _strMSSV = String.Empty;
        }
    }
}

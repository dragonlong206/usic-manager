using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class BuoiSinhHoatDTO
    {
        #region Private Properties
        private int _intMaBuoi;
        private DateTime _dtmThoiGian;
        private string _strDiaDiem = String.Empty;
        private string _strNoiDungChinh = String.Empty;
        #endregion

        #region Constructor
        public BuoiSinhHoatDTO()
        {
            _intMaBuoi = -1;
            _dtmThoiGian = DateTime.MinValue;
            _strDiaDiem = String.Empty;
            _strNoiDungChinh = String.Empty;
        }
        #endregion

        #region Public Properties
        public int MaBuoi
		{
			get {return _intMaBuoi;}
			set {_intMaBuoi = value;}
		}
		
		public DateTime ThoiGian
		{
			get {return _dtmThoiGian;}
			set {_dtmThoiGian = value;}
		}

		public string DiaDiem
		{
			get {return _strDiaDiem;}
			set {_strDiaDiem = value;}
		}

		public string NoiDungChinh
		{
			get {return _strNoiDungChinh;}
			set {_strNoiDungChinh = value;}
		}
		#endregion
	}	
}

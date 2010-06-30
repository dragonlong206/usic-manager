using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class HoiVienBUS
    {
        public static Boolean ThemHoiVien(HoiVienDTO aHoiVien)
        {
            Boolean blnKetQua = false;

            try
            {
                blnKetQua = HoiVienDAO.ThemHoiVien(aHoiVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static Boolean XoaHoiVien(HoiVienDTO aHoiVien)
        {
            Boolean blnKetQua = false;

            try
            {
                blnKetQua = HoiVienDAO.XoaHoiVien(aHoiVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static Boolean CapNhatHoiVien(HoiVienDTO aHoiVien)
        {
            Boolean blnKetQua = false;

            try
            {
                blnKetQua = HoiVienDAO.CapNhatHoiVien(aHoiVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static List<HoiVienDTO> LayDanhSachHoiVien()
        {
            List<HoiVienDTO> lstHoiVien = new List<HoiVienDTO>();

            try
            {
                lstHoiVien = HoiVienDAO.LayDanhSachHoiVien();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lstHoiVien;
        }

        public static List<HoiVienDTO> LayDanhSachHoiVien(String strTieuChiTimKiem)
        {
            List<HoiVienDTO> lstHoiVien = new List<HoiVienDTO>();

            try
            {
                lstHoiVien = HoiVienDAO.LayDanhSachHoiVien(strTieuChiTimKiem);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lstHoiVien;
        }
    }
}

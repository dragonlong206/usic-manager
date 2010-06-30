using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class LoaiHoiVienBUS
    {
        public static Boolean ThemLoaiHoiVien(LoaiHoiVienDTO aLoaiHoiVien)
        {
            Boolean blnKetQua = false;

            aLoaiHoiVien.MaLoai = 0;
            List<LoaiHoiVienDTO> lstLoaiHoiVien = LayDanhSachLoaiHoiVien();
            foreach (LoaiHoiVienDTO aLoaiHoiVienTam in lstLoaiHoiVien)
            {
                if (aLoaiHoiVienTam.MaLoai > aLoaiHoiVien.MaLoai)
                    aLoaiHoiVien.MaLoai = aLoaiHoiVienTam.MaLoai;
            }
            aLoaiHoiVien.MaLoai++;

            try
            {
                blnKetQua = LoaiHoiVienDAO.ThemLoaiHoiVien(aLoaiHoiVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static Boolean XoaLoaiHoiVien(LoaiHoiVienDTO aLoaiHoiVien)
        {
            Boolean blnKetQua = false;

            try
            {
                blnKetQua = LoaiHoiVienDAO.XoaLoaiHoiVien(aLoaiHoiVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static Boolean CapNhatLoaiHoiVien(LoaiHoiVienDTO aLoaiHoiVien)
        {
            Boolean blnKetQua = false;

            try
            {
                blnKetQua = LoaiHoiVienDAO.CapNhatLoaiHoiVien(aLoaiHoiVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static String LayTenLoaiHoiVien(int nMaLoaiHoiVien)
        {
            String strTenLoaiHoiVien = String.Empty;

            try
            {
                strTenLoaiHoiVien = LoaiHoiVienDAO.LayTenLoaiHoiVien(nMaLoaiHoiVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return strTenLoaiHoiVien;
        }

        public static List<LoaiHoiVienDTO> LayDanhSachLoaiHoiVien()
        {
            List<LoaiHoiVienDTO> lstLoaiHoiVien = new List<LoaiHoiVienDTO>();

            try
            {
                lstLoaiHoiVien = LoaiHoiVienDAO.LayDanhSachLoaiHoiVien();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lstLoaiHoiVien;
        }
    }
}

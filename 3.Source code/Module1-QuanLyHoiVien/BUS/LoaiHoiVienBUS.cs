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

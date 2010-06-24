using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class CapBacBUS
    {
        public static Boolean ThemCapBac(CapBacDTO aCapBac)
        {
            Boolean blnKetQua = false;

            try
            {
                blnKetQua = CapBacDAO.ThemCapBac(aCapBac);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static Boolean XoaCapBac(CapBacDTO aCapBac)
        {
            Boolean blnKetQua = false;

            try
            {
                blnKetQua = CapBacDAO.XoaCapBac(aCapBac);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static Boolean CapNhatCapBac(CapBacDTO aCapBac)
        {
            Boolean blnKetQua = false;

            try
            {
                blnKetQua = CapBacDAO.CapNhatCapBac(aCapBac);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static String LayTenCapBac(int nMaCapBac)
        {
            String strTenCapBac = String.Empty;

            try
            {
                strTenCapBac = CapBacDAO.LayTenCapBac(nMaCapBac);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return strTenCapBac;
        }

        public static List<CapBacDTO> LayDanhSachCapBac()
        {
            List<CapBacDTO> lstCapBac = new List<CapBacDTO>();

            try
            {
                lstCapBac = CapBacDAO.LayDanhSachCapBac();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lstCapBac;
        }

        public static List<CapBacDTO> LayDanhSachCapBac(String strTieuChiTimKiem)
        {
            List<CapBacDTO> lstCapBac = new List<CapBacDTO>();

            try
            {
                lstCapBac = CapBacDAO.LayDanhSachCapBac(strTieuChiTimKiem);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lstCapBac;
        }
    }
}

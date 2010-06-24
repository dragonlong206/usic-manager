using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class VaiTroBUS
    {
        public static Boolean ThemVaiTro(VaiTroDTO aVaiTro)
        {
            Boolean blnKetQua = false;

            try
            {
                blnKetQua = VaiTroDAO.ThemVaiTro(aVaiTro);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static Boolean XoaVaiTro(VaiTroDTO aVaiTro)
        {
            Boolean blnKetQua = false;

            try
            {
                blnKetQua = VaiTroDAO.XoaVaiTro(aVaiTro);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static Boolean CapNhatVaiTro(VaiTroDTO aVaiTro)
        {
            Boolean blnKetQua = false;

            try
            {
                blnKetQua = VaiTroDAO.CapNhatVaiTro(aVaiTro);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static String LayTenVaiTro(int nMaVaiTro)
        {
            String strTenVaiTro = String.Empty;

            try
            {
                strTenVaiTro = VaiTroDAO.LayTenVaiTro(nMaVaiTro);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return strTenVaiTro;
        }

        public static List<VaiTroDTO> LayDanhSachVaiTro()
        {
            List<VaiTroDTO> lstVaiTro = new List<VaiTroDTO>();

            try
            {
                lstVaiTro = VaiTroDAO.LayDanhSachVaiTro();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lstVaiTro;
        }
    }
}

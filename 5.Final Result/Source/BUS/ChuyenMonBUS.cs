using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class ChuyenMonBUS
    {
        public static Boolean ThemChuyenMon(ChuyenMonDTO aChuyenMon)
        {
            Boolean blnKetQua = false;

            aChuyenMon.MaChuyenMon = 0;
            List<ChuyenMonDTO> lstChuyenMon = LayDanhSachChuyenMon();
            foreach (ChuyenMonDTO aChuyenMonTam in lstChuyenMon)
            {
                if (aChuyenMonTam.MaChuyenMon > aChuyenMon.MaChuyenMon)
                    aChuyenMon.MaChuyenMon = aChuyenMonTam.MaChuyenMon;
            }
            aChuyenMon.MaChuyenMon++;

            try
            {
                blnKetQua = ChuyenMonDAO.ThemChuyenMon(aChuyenMon);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static Boolean XoaChuyenMon(ChuyenMonDTO aChuyenMon)
        {
            Boolean blnKetQua = false;

            try
            {
                blnKetQua = ChuyenMonDAO.XoaChuyenMon(aChuyenMon);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static Boolean CapNhatChuyenMon(ChuyenMonDTO aChuyenMon)
        {
            Boolean blnKetQua = false;

            try
            {
                blnKetQua = ChuyenMonDAO.CapNhatChuyenMon(aChuyenMon);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static String LayTenChuyenMon(int nMaChuyenMon)
        {
            String strTenChuyenMon = String.Empty;

            try
            {
                strTenChuyenMon = ChuyenMonDAO.LayTenChuyenMon(nMaChuyenMon);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return strTenChuyenMon;
        }

        public static List<ChuyenMonDTO> LayDanhSachChuyenMon()
        {
            List<ChuyenMonDTO> lstChuyenMon = new List<ChuyenMonDTO>();

            try
            {
                lstChuyenMon = ChuyenMonDAO.LayDanhSachChuyenMon();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lstChuyenMon;
        }
    }
}

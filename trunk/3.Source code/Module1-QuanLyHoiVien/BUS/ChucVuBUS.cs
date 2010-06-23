using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class ChucVuBUS
    {
        public static String LayTenChucVu(int nMaChucVu)
        {
            String strTenChucVu = String.Empty;

            try
            {
                strTenChucVu = ChucVuDAO.LayTenChucVu(nMaChucVu);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return strTenChucVu;
        }

        public static List<ChucVuDTO> LayDanhSachChucVu()
        {
            List<ChucVuDTO> lstChucVu = new List<ChucVuDTO>();

            try
            {
                lstChucVu = ChucVuDAO.LayDanhSachChucVu();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lstChucVu;
        }
    }
}

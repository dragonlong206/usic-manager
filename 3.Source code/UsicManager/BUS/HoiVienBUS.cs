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
        public static List<HoiVienDTO> LayDanhSachHoiVien()
        {
            List<HoiVienDTO> KetQua = null;

            try
            {
                KetQua = HoiVienDAO.LayDanhSachHoiVien();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return KetQua;
        }
    }
}

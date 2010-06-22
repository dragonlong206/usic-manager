using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.Sql;

namespace DAO
{
    public class HoiVienDAO
    {
        public static List<HoiVienDTO> LayDanhSachHoiVien()
        {
            List<HoiVienDTO> KetQua = null;

            try
            {
                String spName = "sp_SelectHOI_VIENsAll";

                DataTable DanhSachHoiVien = SqlDataAccessHelper.ExcuteQuery(spName, null);

                if (DanhSachHoiVien.Rows.Count > 0)
                {
                    KetQua = new List<HoiVienDTO>();
                    foreach (DataRow aRow in DanhSachHoiVien.Rows)
                    {
                        HoiVienDTO aHoiVien = TaoDoiTuongDTO(aRow);
                        KetQua.Add(aHoiVien);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return KetQua;
        }

        public static HoiVienDTO TaoDoiTuongDTO(DataRow aRow)
        {
            HoiVienDTO KetQua = new HoiVienDTO();

            KetQua.MSSV = aRow["MSSV"].ToString();
            KetQua.HoTen = aRow["HoTen"].ToString();
            KetQua.Email = aRow["Email"].ToString();
            KetQua.DienThoai = aRow["DienThoai"].ToString();
            KetQua.LaDoanVien = Boolean.Parse(aRow["LaDoanVien"].ToString());
            KetQua.LaHoiVien = Boolean.Parse(aRow["LaHoiVien"].ToString());
            KetQua.LaDangVien = Boolean.Parse(aRow["LaDangVien"].ToString());
            KetQua.LoaiHoiVien = int.Parse(aRow["LoaiHoiVien"].ToString());

            return KetQua;
        }
    }
}

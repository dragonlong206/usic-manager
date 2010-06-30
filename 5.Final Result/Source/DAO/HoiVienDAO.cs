using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class HoiVienDAO
    {
        
        public static Boolean ThemHoiVien(HoiVienDTO aHoiVien)
        {
            Boolean blnKetQua = false;
            try
            {
                String spName = "sp_InsertHOI_VIEN";                
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MSSV", aHoiVien.MSSV));
                sqlParams.Add(new SqlParameter("@HoTen", aHoiVien.HoTen));
                sqlParams.Add(new SqlParameter("@Email", aHoiVien.Email));
                sqlParams.Add(new SqlParameter("@DienThoai", aHoiVien.DienThoai));
                sqlParams.Add(new SqlParameter("@MaLoaiHoiVien", aHoiVien.MaLoaiHoiVien));
                sqlParams.Add(new SqlParameter("@LaDoanVien", aHoiVien.LaDoanVien));
                sqlParams.Add(new SqlParameter("@LaHoiVien", aHoiVien.LaHoiVien));
                sqlParams.Add(new SqlParameter("@LaDangVien", aHoiVien.LaDangVien));
                sqlParams.Add(new SqlParameter("@ChoOHienNay", aHoiVien.ChoOHienNay));
                sqlParams.Add(new SqlParameter("@DiaChiThuongTru", aHoiVien.DiaChiThuongTru));
                sqlParams.Add(new SqlParameter("@MaVaiTro", aHoiVien.MaVaiTro));

                int n = SqlDataAccessHelper.ExcuteNonQuery(spName, sqlParams);
                if (n == 1)
                    blnKetQua = true;
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
                String spName = "sp_DeleteHOI_VIEN";
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MSSV", aHoiVien.MSSV));

                int n = SqlDataAccessHelper.ExcuteNonQuery(spName, sqlParams);
                if (n == 1)
                    blnKetQua = true;
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
                String spName = "sp_UpdateHOI_VIEN";  
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MSSV", aHoiVien.MSSV));
                sqlParams.Add(new SqlParameter("@HoTen", aHoiVien.HoTen));
                sqlParams.Add(new SqlParameter("@Email", aHoiVien.Email));
                sqlParams.Add(new SqlParameter("@DienThoai", aHoiVien.DienThoai));
                sqlParams.Add(new SqlParameter("@MaLoaiHoiVien", aHoiVien.MaLoaiHoiVien));
                sqlParams.Add(new SqlParameter("@LaDoanVien", aHoiVien.LaDoanVien));
                sqlParams.Add(new SqlParameter("@LaHoiVien", aHoiVien.LaHoiVien));
                sqlParams.Add(new SqlParameter("@LaDangVien", aHoiVien.LaDangVien));
                sqlParams.Add(new SqlParameter("@ChoOHienNay", aHoiVien.ChoOHienNay));
                sqlParams.Add(new SqlParameter("@DiaChiThuongTru", aHoiVien.DiaChiThuongTru));
                sqlParams.Add(new SqlParameter("@MaVaiTro", aHoiVien.MaVaiTro));

                int n = SqlDataAccessHelper.ExcuteNonQuery(spName, sqlParams);
                if (n == 1)
                    blnKetQua = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return blnKetQua;
        }                     

        public static List<HoiVienDTO> LayDanhSachHoiVien()
        {
            List<HoiVienDTO> KetQua = new List<HoiVienDTO>();

            try
            {
                String spName = "sp_SelectHOI_VIENsAll";
                DataTable DanhSachHoiVien = SqlDataAccessHelper.ExcuteQuery(spName, null);

                foreach (DataRow aRow in DanhSachHoiVien.Rows)
                {
                    HoiVienDTO aHoiVien = TaoDoiTuongDTO(aRow);
                    KetQua.Add(aHoiVien);
                }                                  
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return KetQua;
        }

        public static List<HoiVienDTO> LayDanhSachHoiVien(String strTieuChiTimKiem)
        {
            List<HoiVienDTO> lstHoiVien = new List<HoiVienDTO>();

            try
            {
                String spName = "sp_SelectHOI_VIENsDynamic";
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@WhereCondition", strTieuChiTimKiem));
                DataTable DanhSachHoiVien = SqlDataAccessHelper.ExcuteQuery(spName, sqlParams);

                foreach (DataRow aRow in DanhSachHoiVien.Rows)
                {
                    HoiVienDTO aHoiVien = TaoDoiTuongDTO(aRow);
                    lstHoiVien.Add(aHoiVien);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lstHoiVien;
        }

        public static HoiVienDTO TaoDoiTuongDTO(DataRow aRow)
        {
            HoiVienDTO aHoiVien = new HoiVienDTO();

            aHoiVien.MSSV = aRow["MSSV"].ToString();
            aHoiVien.HoTen = aRow["HoTen"].ToString();
            aHoiVien.Email = aRow["Email"].ToString();
            aHoiVien.DienThoai = aRow["DienThoai"].ToString();
            aHoiVien.LaDoanVien = Boolean.Parse(aRow["LaDoanVien"].ToString());
            aHoiVien.LaHoiVien = Boolean.Parse(aRow["LaHoiVien"].ToString());
            aHoiVien.LaDangVien = Boolean.Parse(aRow["LaDangVien"].ToString());            
            aHoiVien.MaLoaiHoiVien = int.Parse(aRow["MaLoaiHoiVien"].ToString());            
            aHoiVien.ChoOHienNay = aRow["ChoOHienNay"].ToString();
            aHoiVien.DiaChiThuongTru = aRow["DiaChiThuongTru"].ToString();
            aHoiVien.MaVaiTro = int.Parse(aRow["MaVaiTro"].ToString());

            return aHoiVien;
        }
    }
}

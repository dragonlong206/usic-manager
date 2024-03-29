﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class LoaiHoiVienDAO
    {
        public static Boolean ThemLoaiHoiVien(LoaiHoiVienDTO aLoaiHoiVien)
        {
            Boolean blnKetQua = false;
            try
            {
                String spName = "sp_InsertLOAI_HOI_VIEN";
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaLoai", aLoaiHoiVien.MaLoai));
                sqlParams.Add(new SqlParameter("@TenLoai", aLoaiHoiVien.TenLoai));
                sqlParams.Add(new SqlParameter("@MoTa", aLoaiHoiVien.MoTa));

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

        public static Boolean XoaLoaiHoiVien(LoaiHoiVienDTO aLoaiHoiVien)
        {
            Boolean blnKetQua = false;
            try
            {
                String spName = "sp_DeleteLOAI_HOI_VIEN";
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaLoai", aLoaiHoiVien.MaLoai));

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

        public static Boolean CapNhatLoaiHoiVien(LoaiHoiVienDTO aLoaiHoiVien)
        {
            Boolean blnKetQua = false;
            try
            {
                String spName = "sp_UpdateLOAI_HOI_VIEN";
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaLoai", aLoaiHoiVien.MaLoai));
                sqlParams.Add(new SqlParameter("@TenLoai", aLoaiHoiVien.TenLoai));
                sqlParams.Add(new SqlParameter("@MoTa", aLoaiHoiVien.MoTa));

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

        public static String LayTenLoaiHoiVien(int intMaLoaiHoiVien)
        {
            String strTenLoaiHoiVien = String.Empty;

            try
            {
                String spName = "sp_SelectLOAI_HOI_VIEN";
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaLoai", intMaLoaiHoiVien));
                DataTable aTable = SqlDataAccessHelper.ExcuteQuery(spName, sqlParams);

                if (aTable.Rows.Count == 1)
                {
                    LoaiHoiVienDTO aLoaiHoiVien = TaoDoiTuongDTO(aTable.Rows[0]);
                    strTenLoaiHoiVien = aLoaiHoiVien.TenLoai;
                }
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
                String spName = "sp_SelectLOAI_HOI_VIENsAll";
                DataTable aTable = SqlDataAccessHelper.ExcuteQuery(spName, null);

                foreach (DataRow aRow in aTable.Rows)
                {
                    LoaiHoiVienDTO aLoaiHoiVien = TaoDoiTuongDTO(aRow);
                    lstLoaiHoiVien.Add(aLoaiHoiVien);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lstLoaiHoiVien;
        }

        public static LoaiHoiVienDTO TaoDoiTuongDTO(DataRow aRow)
        {
            LoaiHoiVienDTO aLoaiHoiVien = new LoaiHoiVienDTO();

            aLoaiHoiVien.MaLoai = int.Parse(aRow["MaLoai"].ToString());
            aLoaiHoiVien.TenLoai = aRow["TenLoai"].ToString();

            return aLoaiHoiVien;
        }
    }
}

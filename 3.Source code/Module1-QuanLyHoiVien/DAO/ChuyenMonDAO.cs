using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class ChuyenMonDAO
    {
        public static Boolean ThemChuyenMon(ChuyenMonDTO aChuyenMon)
        {
            Boolean blnKetQua = false;
            try
            {
                String spName = "sp_InsertCHUYEN_MON";
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaChuyenMon", aChuyenMon.MaChuyenMon));
                sqlParams.Add(new SqlParameter("@TenChuyenMon", aChuyenMon.TenChuyenMon));
                sqlParams.Add(new SqlParameter("@MoTa", aChuyenMon.MoTa));

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

        public static Boolean XoaChuyenMon(ChuyenMonDTO aChuyenMon)
        {
            Boolean blnKetQua = false;
            try
            {
                String spName = "sp_DeleteCHUYEN_MON";
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaChuyenMon", aChuyenMon.MaChuyenMon));

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

        public static Boolean CapNhatChuyenMon(ChuyenMonDTO aChuyenMon)
        {
            Boolean blnKetQua = false;
            try
            {
                String spName = "sp_UpdateCHUYEN_MON";
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaChuyenMon", aChuyenMon.MaChuyenMon));
                sqlParams.Add(new SqlParameter("@TenChuyenMon", aChuyenMon.TenChuyenMon));
                sqlParams.Add(new SqlParameter("@MoTa", aChuyenMon.MoTa));

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

        public static String LayTenChuyenMon(int intMaChuyenMon)
        {
            String strTenChuyenMon = String.Empty;

            try
            {
                String spName = "sp_SelectCHUYEN_MON";
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaChuyenMon", intMaChuyenMon));
                DataTable aTable = SqlDataAccessHelper.ExcuteQuery(spName, sqlParams);

                if (aTable.Rows.Count == 1)
                {
                    ChuyenMonDTO aChuyenMon = TaoDoiTuongDTO(aTable.Rows[0]);
                    strTenChuyenMon = aChuyenMon.TenChuyenMon;
                }
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
                String spName = "sp_SelectCHUYEN_MONsAll";
                DataTable aTable = SqlDataAccessHelper.ExcuteQuery(spName, null);

                foreach (DataRow aRow in aTable.Rows)
                {
                    ChuyenMonDTO aChuyenMon = TaoDoiTuongDTO(aRow);
                    lstChuyenMon.Add(aChuyenMon);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lstChuyenMon;
        }

        public static ChuyenMonDTO TaoDoiTuongDTO(DataRow aRow)
        {
            ChuyenMonDTO aChuyenMon = new ChuyenMonDTO();

            aChuyenMon.MaChuyenMon = int.Parse(aRow["MaChuyenMon"].ToString());
            aChuyenMon.TenChuyenMon = aRow["TenChuyenMon"].ToString();
            aChuyenMon.MoTa = aRow["MoTa"].ToString();

            return aChuyenMon;
        }
    }
}

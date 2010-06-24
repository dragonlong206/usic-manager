using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class CapBacDAO
    {
        public static Boolean ThemCapBac(CapBacDTO aCapBac)
        {
            Boolean blnKetQua = false;
            try
            {
                String spName = "sp_InsertCAP_BAC";
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaCapBac", aCapBac.MaCapBac));
                sqlParams.Add(new SqlParameter("@TenCapBac", aCapBac.TenCapBac));
                sqlParams.Add(new SqlParameter("@MaChuyenMon", aCapBac.MaChuyenMon));

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

        public static Boolean XoaCapBac(CapBacDTO aCapBac)
        {
            Boolean blnKetQua = false;
            try
            {
                String spName = "sp_DeleteCAP_BAC";
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaCapBac", aCapBac.MaCapBac));

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

        public static Boolean CapNhatCapBac(CapBacDTO aCapBac)
        {
            Boolean blnKetQua = false;
            try
            {
                String spName = "sp_UpdateCAP_BAC";
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaCapBac", aCapBac.MaCapBac));
                sqlParams.Add(new SqlParameter("@TenCapBac", aCapBac.TenCapBac));
                sqlParams.Add(new SqlParameter("@MaChuyenMon", aCapBac.MaChuyenMon));

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

        public static String LayTenCapBac(int intMaCapBac)
        {
            String strTenCapBac = String.Empty;

            try
            {
                String spName = "sp_SelectCAP_BAC";
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaCapBac", intMaCapBac));
                DataTable aTable = SqlDataAccessHelper.ExcuteQuery(spName, sqlParams);

                if (aTable.Rows.Count == 1)
                {
                    CapBacDTO aCapBac = TaoDoiTuongDTO(aTable.Rows[0]);
                    strTenCapBac = aCapBac.TenCapBac;
                }
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
                String spName = "sp_SelectCAP_BACsAll";
                DataTable aTable = SqlDataAccessHelper.ExcuteQuery(spName, null);

                foreach (DataRow aRow in aTable.Rows)
                {
                    CapBacDTO aCapBac = TaoDoiTuongDTO(aRow);
                    lstCapBac.Add(aCapBac);
                }
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
                String spName = "sp_SelectCAP_BACsDynamic";
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@WhereCondition", strTieuChiTimKiem));
                DataTable DanhSachCapBac = SqlDataAccessHelper.ExcuteQuery(spName, sqlParams);

                foreach (DataRow aRow in DanhSachCapBac.Rows)
                {
                    CapBacDTO aCapBac = TaoDoiTuongDTO(aRow);
                    lstCapBac.Add(aCapBac);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lstCapBac;
        }

        public static CapBacDTO TaoDoiTuongDTO(DataRow aRow)
        {
            CapBacDTO aCapBac = new CapBacDTO();

            aCapBac.MaCapBac = int.Parse(aRow["MaCapBac"].ToString());
            aCapBac.TenCapBac = aRow["TenCapBac"].ToString();
            aCapBac.MaChuyenMon = int.Parse(aRow["MaChuyenMon"].ToString());

            return aCapBac;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class ChucVuDAO
    {
        public static String LayTenChucVu(int intMaChucVu)
        {
            String strTenChucVu = String.Empty;

            try
            {
                String spName = "sp_SelectCHUC_VU";
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaChucVu", intMaChucVu));
                DataTable aTable = SqlDataAccessHelper.ExcuteQuery(spName, sqlParams);

                if (aTable.Rows.Count == 1)
                {
                    ChucVuDTO aChucVu = TaoDoiTuongDTO(aTable.Rows[0]);
                    strTenChucVu = aChucVu.TenChucVu;
                }
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
                String spName = "sp_SelectCHUC_VUsAll";
                DataTable aTable = SqlDataAccessHelper.ExcuteQuery(spName, null);

                foreach (DataRow aRow in aTable.Rows)
                {
                    ChucVuDTO aChucVu = TaoDoiTuongDTO(aRow);
                    lstChucVu.Add(aChucVu);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lstChucVu;
        }

        public static ChucVuDTO TaoDoiTuongDTO(DataRow aRow)
        {
            ChucVuDTO aChucVu = new ChucVuDTO();

            aChucVu.MaChucVu = int.Parse(aRow["MaChucVu"].ToString());
            aChucVu.TenChucVu = aRow["TenChucVu"].ToString();

            return aChucVu;
        }
    }
}

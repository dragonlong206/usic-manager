using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class VaiTroDAO
    {
        public static String LayTenVaiTro(int intMaVaiTro)
        {
            String strTenVaiTro = String.Empty;

            try
            {
                String spName = "sp_SelectVAI_TRO";
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@MaVaiTro", intMaVaiTro));
                DataTable aTable = SqlDataAccessHelper.ExcuteQuery(spName, sqlParams);

                if (aTable.Rows.Count == 1)
                {
                    VaiTroDTO aVaiTro = TaoDoiTuongDTO(aTable.Rows[0]);
                    strTenVaiTro = aVaiTro.TenVaiTro;
                }
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
                String spName = "sp_SelectVAI_TROsAll";
                DataTable aTable = SqlDataAccessHelper.ExcuteQuery(spName, null);

                foreach (DataRow aRow in aTable.Rows)
                {
                    VaiTroDTO aVaiTro = TaoDoiTuongDTO(aRow);
                    lstVaiTro.Add(aVaiTro);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lstVaiTro;
        }

        public static VaiTroDTO TaoDoiTuongDTO(DataRow aRow)
        {
            VaiTroDTO aVaiTro = new VaiTroDTO();

            aVaiTro.MaVaiTro = int.Parse(aRow["MaVaiTro"].ToString());
            aVaiTro.TenVaiTro = aRow["TenVaiTro"].ToString();

            return aVaiTro;
        }
    }
}

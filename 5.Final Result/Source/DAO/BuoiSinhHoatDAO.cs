using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class BuoiSinhHoatDAO
    {
        #region 1.Select
        public static int GetMaxID()
        {
            int intResult = -1;
            String strSpName = "sp_SelectMaxBUOI_SINH_HOAT_ID";
            try
            {
                DataTable table = SqlDataAccessHelper.ExcuteQuery(strSpName, null);
                if (table.Rows.Count > 0)
                {
                    intResult = int.Parse(table.Rows[0][0].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return intResult;
        }

        public static BuoiSinhHoatDTO GetBuoiSinhHoatByThoiGian(DateTime dtmThoiGian)
        {
            List<SqlParameter> Params = new List<SqlParameter>();
            Params.Add(new SqlParameter("@ThoiGian", dtmThoiGian));

            BuoiSinhHoatDTO result = null;
            try
            {
                DataTable table = SqlDataAccessHelper.ExcuteQuery("sp_SelectBUOI_SINH_HOATByThoiGian", Params);
                if (table.Rows.Count > 0)
                {
                    result = CreateBuoiSinhHoatDTO(table.Rows[0]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public static List<BuoiSinhHoatDTO> SelectAllBuoiSinhHoat()
        {
            List<BuoiSinhHoatDTO> result = null;
            try
            {
                DataTable table = SqlDataAccessHelper.ExcuteQuery("sp_SelectBUOI_SINH_HOATsAll", null);
                if (table.Rows.Count > 0)
                {
                    result = new List<BuoiSinhHoatDTO>();
                    foreach (DataRow aRow in table.Rows)
                    {
                        BuoiSinhHoatDTO aBuoiSinhHoat = CreateBuoiSinhHoatDTO(aRow);
                        result.Add(aBuoiSinhHoat);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        #endregion

        #region 2.Insert
        public static int InsertBuoiSinhHoat(BuoiSinhHoatDTO aBuoiSinhHoat)
        {
            int intNRecord = 0;
            try
            {
                List<SqlParameter> Params = new List<SqlParameter>();
                Params.Add(new SqlParameter("@ThoiGian", aBuoiSinhHoat.ThoiGian));
                Params.Add(new SqlParameter("@DiaDiem", aBuoiSinhHoat.DiaDiem));
                Params.Add(new SqlParameter("@NoiDungChinh", aBuoiSinhHoat.NoiDungChinh));
                Params.Add(new SqlParameter("@MaBuoi", SqlDbType.Int));
                Params[3].Direction = ParameterDirection.Output;

                intNRecord = SqlDataAccessHelper.ExcuteNonQuery("sp_InsertBUOI_SINH_HOAT", Params);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intNRecord;
        }
        #endregion

        private static BuoiSinhHoatDTO CreateBuoiSinhHoatDTO(DataRow aRow)
        {
            BuoiSinhHoatDTO result = new BuoiSinhHoatDTO();
            result.MaBuoi = int.Parse(aRow["MaBuoi"].ToString());
            result.ThoiGian = DateTime.Parse(aRow["ThoiGian"].ToString());
            result.DiaDiem = aRow["DiaDiem"].ToString();
            result.NoiDungChinh = aRow["NoiDungChinh"].ToString();
            return result;
        }
    }
}

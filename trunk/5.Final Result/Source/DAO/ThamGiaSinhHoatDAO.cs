using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class ThamGiaSinhHoatDAO
    {
        #region 1.Insert
        public static int InsertThamGiaSinhHoat(ThamGiaSinhHoatDTO aThamGiaSinhHoat)
        {
            int intNRecord = 0;
            try
            {
                List<SqlParameter> Params = new List<SqlParameter>();
                Params.Add(new SqlParameter("@MaBuoiSH", aThamGiaSinhHoat.MaBuoi));
                Params.Add(new SqlParameter("@MSSV", aThamGiaSinhHoat.MSSV));
                intNRecord = SqlDataAccessHelper.ExcuteNonQuery("sp_InsertTHAM_GIA_SINH_HOAT", Params);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intNRecord;
        }
        #endregion
    }
}

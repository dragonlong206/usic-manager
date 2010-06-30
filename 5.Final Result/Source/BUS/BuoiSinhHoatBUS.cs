using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class BuoiSinhHoatBUS
    {
        #region 1.Select
        public static int GetMaxID()
        {
            int intResult = -1;
            try
            {
                intResult = BuoiSinhHoatDAO.GetMaxID();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intResult;
        }

        public static List<BuoiSinhHoatDTO> SelectAllBuoiSinhHoat()
        {
            List<BuoiSinhHoatDTO> result = null;
            try
            {
                result = BuoiSinhHoatDAO.SelectAllBuoiSinhHoat();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        #endregion

        #region 2.Insert
        public static bool InsertBuoiSinhHoat(BuoiSinhHoatDTO aBuoiSinhHoat)
        {
            bool blnResult = false;

            try
            {
                int intNRecord = BuoiSinhHoatDAO.InsertBuoiSinhHoat(aBuoiSinhHoat);
                if (intNRecord == 1)
                {
                    blnResult = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnResult;
        }
        #endregion
    }
}

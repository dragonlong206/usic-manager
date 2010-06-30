using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class ThamGiaSinhHoatBUS
    {
        public static bool InsertThamGiaSinhHoat(ThamGiaSinhHoatDTO aThamGiaSinhHoat)
        {
            bool blnIsInserted = false;
            try
            {
                int intNRecord = ThamGiaSinhHoatDAO.InsertThamGiaSinhHoat(aThamGiaSinhHoat);
                if (intNRecord == 1)
                {
                    blnIsInserted = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return blnIsInserted;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Xml;

namespace DAO
{
    public class SqlDataAccessHelper
    {
        #region ConnectionString

        public static String ConnectionString
        {
            get
            {                
                return ReadConnectionString("ConnectionString.xml");
            }
        }

        public static String ReadConnectionString(String strPath)
        {
            try
            {
                XmlDocument docConnectionString = new XmlDocument();
                docConnectionString.Load(strPath);
                XmlElement root = docConnectionString.DocumentElement;
                String strConnectionString = root.InnerText;
                return strConnectionString;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ExcuteQuery

        public static DataTable ExcuteQuery(string spName, List<SqlParameter> arrParameters)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                try
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spName;                    

                    if (arrParameters != null)
                    {
                        foreach (SqlParameter param in arrParameters)
                        {
                            command.Parameters.Add(param);
                        }
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
                catch (Exception ex1)
                {
                    throw ex1;
                }
                finally
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region ExcuteNonQuery

        public static int ExcuteNonQuery(String spName, List<SqlParameter> arrParams)
        {
            int nRecord = 0;

            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                try
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spName;

                    if (arrParams != null)
                    {
                        foreach (SqlParameter param in arrParams)
                        {
                            command.Parameters.Add(param);
                        }
                    }

                    nRecord = command.ExecuteNonQuery();
                }
                catch (Exception ex1)
                {
                    throw ex1;
                }
                finally
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return nRecord;
        }

        #endregion
    }
}

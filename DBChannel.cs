using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBChannel
{
    //This Class is responsible for All the funtion related to DataBase
    public class DBChannel
    {
        public static DBChannel channel = new DBChannel();
        public SqlConnection conn = null;
        public string connectionString = string.Empty;

        public DBChannel()
        {
            connectionString = "dbserver=NameOfSQLserverConnection ;Databse=NameOfDB;Uid=uid,password=password";
        }
        public bool ISConnected()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
            }
            catch (Exception ex)
            {
                //Log the Error
                return false;
            }
            return true;
        }

        public string GetStatusFromDB(int ID)
        {
            string status = string.Empty;
            try
            {
                
                string sqlCommand = "select UserStatus from TableName where UserStatus=" + ID.ToString();
                SqlDataReader reader;
                SqlCommand cmd = new SqlCommand(sqlCommand, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    status = Convert.ToString(reader["ColumnNane"]);
                }
            }
            catch (Exception ex)
            {
                //Log exception
            }
            return status;
        }
    }
}

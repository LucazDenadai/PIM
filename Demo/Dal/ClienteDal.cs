using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Dal
{
    public class ClienteDal
    {
        public bool Insert(string comand)
        {
            try
            {
                Connect con = new Connect();
                SqlConnection connection = con.OpenConnection();

                SqlCommand sqlCommand = new SqlCommand(comand, connection);
                SqlDataReader dr = sqlCommand.ExecuteReader();

                con.CloseConnection();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int InsertAndReturnId(string comand)
        {
            try
            {
                Connect con = new Connect();
                SqlConnection connection = con.OpenConnection();

                SqlCommand sqlCommand = new SqlCommand(comand, connection);
                SqlDataReader dr = sqlCommand.ExecuteReader();

                int idEnd = 0;

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        idEnd = int.Parse(dr.GetValue(0).ToString());
                    }
                }
                con.CloseConnection();

                return idEnd ;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

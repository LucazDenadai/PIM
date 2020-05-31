using Demo.Entity;
using System;
using System.Data.SqlClient;

namespace Demo.Dal
{
    public class UsuarioDal
    {

        public bool Login(string command)
        {
            try
            {
                Connect con = new Connect();
                SqlConnection conn = con.OpenConnection();

                SqlCommand sqlCommand = new SqlCommand(command, conn);
                SqlDataReader dr = sqlCommand.ExecuteReader();

                if (dr.HasRows)
                {
                    con.CloseConnection();
                    return true;
                }
                else
                {
                    con.CloseConnection();
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

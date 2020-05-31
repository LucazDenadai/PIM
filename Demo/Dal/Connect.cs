using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Demo.Dal
{
    public class Connect
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["conection"].ToString();

        // string ConnectionString = "Server=localhost;Database=PIM;User Id=sa Password=root;";
        SqlConnection conn;

        public SqlConnection OpenConnection()
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            return conn;
        }

        public void CloseConnection()
        {
            conn.Close();
            conn.Dispose();
        }


    }
}

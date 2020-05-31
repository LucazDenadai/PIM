using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.Dal
{
    public class Connect
    {
        string ConnectionString = "Server=localhost;Database=PIM;User Id=sa;" +
                         "Password=root;";
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

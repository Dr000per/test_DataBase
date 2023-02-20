using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace test_DataBase
{
    internal class DB_connection
    {
        SqlConnection sqlConnection = new SqlConnection(@"Server = db.edu.cchgeu.ru; DataBase = 193_Shelylin; User = 193_Shelylin; Password = 193_Shelylin");

        public void openConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }


    }
}

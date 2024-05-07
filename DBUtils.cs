using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace lab_3
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "mydb";
            string username = "monty";
            string password = "some_pass";

            return DBMySQLULits.GetDBConnection(host, port, database, username, password);
        }

    }



}

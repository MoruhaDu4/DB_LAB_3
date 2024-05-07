using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace lab_3
{

    class DBMySQLULits
    {

        public static MySqlConnection
            GetDBConnection(string host, int portn, string database, string username, string password)
        {
            String connString = "Server=" + host + ";Database=" + database
              + ";port=" + portn + ";User Id=" + username + ";password=" + password + ";charset=utf8";


            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }

    }


}

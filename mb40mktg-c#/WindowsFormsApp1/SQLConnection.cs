using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class SqlConnection
    {

        public static MySqlConnection GetMysqlConnection()
        {
            string mySqlConString = "port=3306;server=localhost;user id=root;database=mb40mktg";
            MySqlConnection dbConn = new MySqlConnection(mySqlConString);
            return dbConn;
        }
    }
}

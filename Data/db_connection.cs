using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppManager.Data
{
     class db_connection
    {
        static string conn = "server = localhost;userid =root;password=;port=3306;database=managersys ";
        public MySqlConnection connect = new MySqlConnection(conn);
    }
}

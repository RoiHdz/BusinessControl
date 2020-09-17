using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class Conexion
    {

        public static MySqlConnection getConnect()
        {
            //Variables que serviran de retorno
            MySqlConnection connect;

            //Variables de conexion 
            string server = "127.0.0.1";
            string database = "dbBusinessControl";
            string user = "root";
            string password = " ";

            //
            try
            {
                connect = new MySqlConnection(
                    "Server =" + server +
                    "; database = " + database +
                    "; uid = " + user  +
                    "; pwd = " + password
                    );
                connect.Open();
                return connect;
            }
            catch (Exception) { return connect = null; }
        }

    }
}

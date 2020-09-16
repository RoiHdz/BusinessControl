using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class ModelMain
    {
        public static bool InfoMail(string idUsuario)
        {
            bool retorno;
            try
            {
                string query = "SELECT email FROM tbusuarios WHERE idUsuario = binary ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idUsuario));
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
    }
}

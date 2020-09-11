using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modelo;

namespace Controlador
{
    public class LoginController 
    {
        public static MySqlConnection Conectar()
        {
            return Conexion.getConnect();
        }

        public static int VerificarPrimerUso_Controller()
        {
            return ModelLogin.ObtenerEmpresas();
        }
        
    }
}

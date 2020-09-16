using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modelo;

namespace Controlador
{
    public class LoginController : AtributosLogin
    {
        public static bool Acceso_Controller()
        {
            return ModelLogin.Acceso(usuario, clave);
        }
        public static MySqlConnection Conectar()
        {
            return Conexion.getConnect();
        }

        public static int VerificarPrimerUso_Controller()
        {
            return ModelLogin.ObtenerEmpresas();
        }
        
    }
    public class AtributosLogin
    {
        public static string usuario { get; set; }
        public static string clave { get; set; }
        public AtributosLogin() {}
    }
}

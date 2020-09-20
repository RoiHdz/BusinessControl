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

        public static bool VerificarPrimerUso_Controller()
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
    //public string recoverPassword(string userRequesting)
    //    {
    //        using (MySqlConnection connection = getConnect())
    //        {
    //            connection.Open();
    //            using (MySqlCommand command = new MySqlCommand())
    //            {
    //                command.Connection = connection;
    //                command.CommandText = "select *from tbusuarios where Usuario=@user or email=@mail";
    //                command.Parameters.AddWithValue("@user", userRequesting);
    //                command.Parameters.AddWithValue("@mail", userRequesting);
    //                command.CommandType = System.Data.CommandType.Text;
    //                MySqlDataReader reader = command.ExecuteReader();

    //                if (reader.Read() == true)
    //                {
    //                    string userName = reader.GetString(3) + ", " + reader.GetString(4);
    //                    string userMail = reader.GetString(5);
    //                    string accountPassword = reader.GetString(2);

    //                    var mailService = new MailServices.SystemSupportMail();
    //                    mailService.sendMail(
    //                        subject: "SYSTEM: Recuperacion de contraseña",
    //                        body: "Hi, " + userName + "Usted pidió cambio de contraseña" +
    //                        "Tu actual contraseña es: " + accountPassword + " ",
    //                        recipientMail: new List<string> { userMail }
    //                        );
    //                    return "Hola, " + userName + "Solicitaste cambio de contraseña" +
    //                        "Por favor revisa tu email:" + userMail + " ";
    //                }
    //                else
    //                    return "Lo sentimos no tiene una cuenta con este nombre de usuario o correo electronico";
    //            }
    //        }
    //    }
}

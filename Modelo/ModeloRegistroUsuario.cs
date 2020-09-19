using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModeloRegistroUsuario
    {
        public static DataTable CargarTipoUsuario()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbtipo_usuario";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.getConnect());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.getConnect().Close();
            }
        }

       

        public static bool RegistrarUsuario(string Usuario, string Contraseña, string Nombre, string Apellido, string Correo, int idTipoUsuario)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbusuarios(Usuario, Contrasenia,  Nombre, Apellido, email, idTipo_Usuario) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", Usuario, Contraseña, Nombre, Apellido, Correo, idTipoUsuario), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;

namespace Controlador
{
     public class RegistroUsuarioController
    {
        public static object Cargar_Estado()
        {
            return Conexion.getConnect();
        }
        //Metodo para mostrar los estados en el formulario FrmRegistroUsuario
        public static DataTable IdTipoUsuario()
        {
            return ModeloRegistroUsuario.Cargar_Estado();
        }
        
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public int idTipoUsuario { get; set; }

        public bool EnviarDatos_Controller()
        {
            return ModeloRegistroUsuario.RegistrarUsuario(Usuario, Contraseña, Nombre, Apellido, Correo, idTipoUsuario);
        }
    }
}

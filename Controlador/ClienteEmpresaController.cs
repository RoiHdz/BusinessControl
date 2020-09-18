using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Modelo;

namespace Controlador
{
     public class ClienteEmpresaController
    {
        public static MySqlConnection ConnectController()
        {
            return Conexion.getConnect();
        }
        //Metodo para mostrar los estados en el formulario FrmClienteEmpresa_hijo
        public static DataTable Cargar_Estado()
        {
            return ModeloClienteEmpresa.CargarEstado();
        }
        public static DataTable Cargar_Proveedor()
        {
            return ModeloClienteEmpresa.ListaClienteEmpresa();
        }
        public string NombreEmpresa { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public int EstadoCliente { get; set; }


        public bool EnviarDatos_Controller()
        {
            return ModeloClienteEmpresa.RegistrarClienteEmpresa(NombreEmpresa, Direccion, Correo, EstadoCliente);
        }

    }
}

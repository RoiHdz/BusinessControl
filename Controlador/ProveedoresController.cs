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
    public class ProveedoresController 
    {
        public static MySqlConnection ConnectController()
        {
            return Conexion.getConnect();
        }
        //Metodo para mostrar los estados en el formulario FrmProveedores
        public static DataTable Cargar_Estado()
        {
            return ModeloProveedores.CargarEstado();
        }
        public static DataTable Cargar_Proveedor()
        {
            return ModeloProveedores.ListaProveedores();
        }
        public string DUI { get; set; }
        public string NombreProveedor { get; set; }
        public string Direccion { get; set; }
        public string CorreoProveedor { get; set; }
        public string Descripcion { get; set; }
        public int EstadoProveedor { get; set; }

        
        public bool EnviarDatos_Controller()
        {
            return ModeloProveedores.RegistrarProveedor (DUI, NombreProveedor, Direccion, CorreoProveedor, Descripcion, EstadoProveedor);
        }

    }
}

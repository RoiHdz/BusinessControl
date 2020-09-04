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
    public class MainController
    {
        public static MySqlConnection ConnectController()
        {
            return Conexion.getConnect();
        }
        //Metodo para mostrar los estados en el fromulario FrmClientePE_hijo
        public static DataTable Cargar_Estado()
        {
            return ModeloClienteP.CargarEstado();
        }
        //Metodo para mostrar la lista de clientes que hemos ingresado al sistema
        public static DataTable Cargar_Cliente()
        {
            return ModeloClienteP.ListaClientes();
        }
        //Creamos atributos que permitan recibir los valores que provienen del
        //formulario y los valores los asignamos según el constructor
        public string dui { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        //public DateTime FechaNacimiento { get; set; }
        public string direccion { get; set; }
        public string Correo { get; set; }
        public int Estado { get; set; }
        //Constructor
        public MainController() {}
        public bool EnviarDatos_Controlle() {
            return ModeloClienteP.registrarCliente(PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, dui, Correo, direccion, Estado);
        }
    }
}

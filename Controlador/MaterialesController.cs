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
    public class MaterialesController
    {
        public static DataTable Cargar_Estado()
        {
            return ModeloMateriales.CargarEstadoMateriales();
        }
        public static DataTable Cargar_Proveedor()
        {
            return ModeloMateriales.CargarProveedorMateriales();
        }
        public static DataTable Cargar_Categoria()
        {
            return ModeloMateriales.CargarCategoriaMateriales();
        }
        //Metodo para mostrar la lista de materiales que hemos ingresado al sistema
        public static DataTable Cargar_Materiales()
        {
            return ModeloMateriales.ListaMateriales();
        }
        //Creamos atributos que permitan recibir los valores que provienen del
        //formulario y los valores los asignamos según el constructor
        public string NombreMaterial { get; set; }
        public string CodigoMaterial { get; set; }
        public double PrecioUnitario { get; set; }
        public string MarcaMaterial { get; set; }
        public int Proveedor { get; set; }
        public int Categoria { get; set; }
        public int Estado { get; set; }
        public string FechaIngreso { get; set; }
        public string Descripcion { get; set; }
        //Constructor
        public MaterialesController() { }
        public bool EnviarDatos_Controller()
        {
            return ModeloMateriales.registrarmateriales(NombreMaterial, CodigoMaterial, PrecioUnitario, MarcaMaterial, Proveedor, Categoria, Estado, FechaIngreso, Descripcion);
        }
    }
}

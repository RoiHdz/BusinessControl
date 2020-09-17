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
    public class PrimerUsoController
    {
        public static MySqlConnection ConnectController()
        {
            return Conexion.getConnect();
        }
        public static DataTable Cargar_TipoEmpresa()
        {
            return ModeloPrimerUso.CargarTipoEmpresa();
        }
        
        public string NombreEmpresa { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string NIT { get; set; }
        public string Representante { get; set; }
        public int TipoEmpresa { get; set; }

        public PrimerUsoController() { }
        public bool EnviarDatos_Controlleer()
        {
            return ModeloPrimerUso.registrarEmpresa(NombreEmpresa, Correo, NIT, Representante,Direccion, TipoEmpresa);
        }
    }
}

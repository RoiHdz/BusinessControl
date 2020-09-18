using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModeloMateriales
    {
        //Metodos para mostrar en los combobox
        public static DataTable CargarEstadoMateriales()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbestado_material";
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
        public static DataTable CargarProveedorMateriales()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbproveedor";
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
        public static DataTable CargarCategoriaMateriales()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbcategoria";
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
        //Metodo para mostrar los clientes en el data grid view
        public static DataTable ListaMateriales()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbmateriales";
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
        //Registrar los datos ingresados en el formulario
        public static bool registrarmateriales(string NombreMaterial, string CodigoMaterial, double PrecioUnitario, string MarcaMaterial, int Proveedor, int Categoria, int Estado, string FechaIngreso, string Descripcion)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbmateriales (Nombre, Codigo, Precio_Unitario, Descripcion, Marca, idProveedor, idCategoria, idEstado_Material, Fecha_Ingreso) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", NombreMaterial, CodigoMaterial, PrecioUnitario, Descripcion, MarcaMaterial, Proveedor, Categoria, Estado, FechaIngreso), Conexion.getConnect());
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

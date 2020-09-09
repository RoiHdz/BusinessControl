using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModeloProveedores
    {
        //Metodo para mostrar el estado del provedor
        public static DataTable CargarEstado()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbestado_proveedor";
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

        public static DataTable ListaProveedores()
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

        public static bool RegistrarProveedor(string DUI, string nombreProveedor, string direccion, string correoProveedor, string descripcion, int estadoProveedor)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbproveedor (NIF, Nombre,  Direccion, Correo,Descripcion, idEstado_Proveedor) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", DUI, nombreProveedor, direccion, correoProveedor, descripcion, estadoProveedor), Conexion.getConnect());
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

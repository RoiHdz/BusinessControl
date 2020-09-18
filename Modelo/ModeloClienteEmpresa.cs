using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModeloClienteEmpresa
    {
        public static DataTable CargarEstado()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbestado_cliente";
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

        public static DataTable ListaClienteEmpresa()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbcliente_empresa";
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

        public static bool RegistrarClienteEmpresa(string NombreEmpresa, string Direccion, string Correo, int Estadocliente)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbcliente_empresa ( Nombre_Empresa,  Direccion, Correo, idEstado_Cliente) VALUES ('{0}', '{1}', '{2}', '{3}')", NombreEmpresa, Direccion, Correo, Estadocliente), Conexion.getConnect());
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

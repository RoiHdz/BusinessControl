using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModeloPrimerUso
    {
        public static DataTable CargarTipoEmpresa()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbtipo_empresa";
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
        public static DataTable ListaEmpresa()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbempresa";
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

        public static bool RegistrarEmpresa(string NombreEmpresa, string Correo, string Direccion, string NIT, string Representante, int TipoEmpresa)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbempresa (Empresa, Correo,  Direccion, NIT, Representante Legal, idTipo_Empresa) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", NombreEmpresa, Correo, Direccion, NIT, Representante, TipoEmpresa), Conexion.getConnect());
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

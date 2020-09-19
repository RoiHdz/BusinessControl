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
       

        public static bool registrarEmpresa(string NombreEmpresa, string Correo,  string NIT, string Representante, string Direccion, int TipoEmpresa)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbempresa (Empresa, Correo, NIT, Representantelegal, idTipo_Empresa,Direccion) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", NombreEmpresa, Correo,  NIT, Representante, TipoEmpresa, Direccion ), Conexion.getConnect());
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

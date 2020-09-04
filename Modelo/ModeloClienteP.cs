using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModeloClienteP
    {
        //Metodo para mostrar el estado del cliente persona
        public static DataTable CargarEstado()
        {
                DataTable data;
                try
                {
                string query = "SELECT * FROM tbestado_clientep";
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
        public static DataTable ListaClientes()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbcliente_persona";
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
        public static bool registrarCliente(string PrimerNombre, string SegundNombre, string PrimerApellido, string SegundoApellido, string dui, string correo, string direccion, int estado) {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbCliente_Persona (DUI, Nombre1, Nombre2, Apellido1, Apellido2, Direccion, Correo, idEstado_ClienteP) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", dui, PrimerNombre, SegundNombre, PrimerApellido, SegundoApellido, direccion, correo, estado), Conexion.getConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
        //public static bool registrarTelefono(string telefono) {

        //}

    }
}

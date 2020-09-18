using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Controlador;

namespace BusinessControl
{
    public partial class FrmClienteEmpresa_hijo : Form
    {
        public FrmClienteEmpresa_hijo()
        {
            InitializeComponent();
  
        }
        void EnvioDatos()
        {
            ClienteEmpresaController agregar = new ClienteEmpresaController();
            agregar.NombreEmpresa = txtNombreEmpresa.Text;
            agregar.Direccion = txtDirección.Text;
            agregar.Correo = txtCorreo.Text;
            agregar.EstadoCliente = Convert.ToInt16(cmbEstado.SelectedValue);
            if (agregar.EnviarDatos_Controller() == false)
            {
                MessageBox.Show("El usuario no puedo ser ingresado", "Advertencia", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);

            }
            else
            {
                LimpiarCampos();
            }
        }



        void LimpiarCampos()
        {
            txtNombreEmpresa.Clear();
            txtDirección.Clear();
            txtCorreo.Clear();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EnvioDatos();
        }

        private void FrmClienteEmpresa_hijo_Load_1(object sender, EventArgs e)
        {
            try
            {
                cmbEstado.DataSource = ClienteEmpresaController.Cargar_Estado();
                cmbEstado.DisplayMember = "Estado";
                cmbEstado.ValueMember = "idEstado_Cliente";
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

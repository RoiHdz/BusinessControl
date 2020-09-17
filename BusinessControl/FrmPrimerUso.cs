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
using MySql.Data.MySqlClient;
using Controlador;

namespace BusinessControl
{
    public partial class FrmPrimerUso : Form
    {
        public FrmPrimerUso()
        {
            InitializeComponent();
        }

       

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void MenuSuperior_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void MenuSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
        void EnvioDatos()
        {
            PrimerUsoController agregar = new PrimerUsoController();
            agregar.NombreEmpresa = txtNombreEmpresa.Text;
            agregar.Correo = txtCorreoEmpresa.Text;
            agregar.Direccion = txtDireccionEmpresa.Text;
            agregar.NIT = txtNitEmpresa.Text;
            agregar.Representante = txtRepresentante.Text;
            agregar.TipoEmpresa = Convert.ToInt16(cmbTipoEmpresa.SelectedValue);
            if (agregar.EnviarDatos_Controlleer() == false)
            {
                MessageBox.Show("El usuario no puedo ser ingresado", "Advertencia", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            }
            else
            {
                LimpiarCampos();
            }
        }
        private void btnAgregarEmpresa_Click(object sender, EventArgs e)
        {
            EnvioDatos();
            this.Hide();
            Login mainMenu = new Login();
            mainMenu.Show();
            Hide();
        }
        void LimpiarCampos()
        {
            txtNombreEmpresa.Clear();
            txtCorreoEmpresa.Clear();
            txtDireccionEmpresa.Clear();
            txtNitEmpresa.Clear();
            txtRepresentante.Clear();
            

        }
       

        private void cmbTipoEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmPrimerUso_Load(object sender, EventArgs e)
        {
            try
            {
                cmbTipoEmpresa.DataSource = PrimerUsoController.Cargar_TipoEmpresa();
                cmbTipoEmpresa.DisplayMember = "TipoEmmpresa";
                cmbTipoEmpresa.ValueMember = "idTipo_Empresa";
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}

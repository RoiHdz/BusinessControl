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
            agregar.NIT = txtNitEmpresa.Text;
            agregar.Representante = txtRepresentante.Text;
            agregar.Direccion = txtDireccionEmpresa.Text;
            agregar.TipoEmpresa = Convert.ToInt16(cmbTipoEmpresa.SelectedValue);
            if (agregar.EnviarDatos_Controlleer() == false )
            {
                MessageBox.Show(Resources_Language.NotificacionesEspañol.Mensaje2, Resources_Language.NotificacionesEspañol.Encabezado2, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
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
            txtNitEmpresa.Clear();
            txtRepresentante.Clear();
            txtDireccionEmpresa.Clear();


        }
       

        private void cmbTipoEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmPrimerUso_Load(object sender, EventArgs e)
        {
            verificacionIdioma();

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
        void verificacionIdioma()
        {
            if (MainController.idioma == 1)
            {
                lblNombreEmpresa.Text = Resources_Language.español.lblNombreEmpresa;
                lblCorreoEmpresa.Text = Resources_Language.español.lblCorreoEmpresa;
                lblNitEmpresa.Text = Resources_Language.español.lblNitEmpresa;
                lblRepresentante.Text = Resources_Language.español.lblRepresentante;
                lblTipoEmpresa.Text = Resources_Language.español.lblTipoEmpresa;
                lblDireccionEmpresa.Text = Resources_Language.español.lblDireccionEmpresa;
                btnAgregarEmpresa.Text = Resources_Language.español.btnAgregarEmpresa;
            }
            else
            {
                lblNombreEmpresa.Text = Resources_Language.ingles.lblNombreEmpresa;
                lblCorreoEmpresa.Text = Resources_Language.ingles.lblCorreo;
                lblNitEmpresa.Text = Resources_Language.ingles.lblNitEmpresa;
                lblRepresentante.Text = Resources_Language.ingles.lblRepresentante;
                lblTipoEmpresa.Text = Resources_Language.ingles.lblTipoEmpresa;
                lblDireccionEmpresa.Text = Resources_Language.ingles.lblDireccion;
                btnAgregarEmpresa.Text = Resources_Language.ingles.btnAgregaar;
            }
        }
    }
}

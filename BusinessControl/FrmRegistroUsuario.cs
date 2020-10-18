using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Controlador;

namespace BusinessControl
{
    public partial class FrmRegistroUsuario : Form
    {
        public FrmRegistroUsuario()
        {
            InitializeComponent();
        }
        void EnvioDatos()
        {
            RegistroUsuarioController agregar = new RegistroUsuarioController();
            agregar.Usuario = txtUsuario.Text;
            agregar.Contraseña = txtContraseña.Text;
            agregar.Nombre = txtNombre.Text;
            agregar.Apellido = txtApellido.Text;
            agregar.Correo = txtCorreo.Text;
            agregar.idTipoUsuario = Convert.ToInt16(cmbIdTipoUsuario.SelectedValue);
            if (agregar.EnviarDatos_Controller() == false)
            {
                MessageBox.Show("El usuario no puedo ser ingresado", "Advertencia", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            }
            else
            {
                LimpiarCampos();
            }
        }

        private void bntAgragar_Click(object sender, EventArgs e)
        {
            EnvioDatos();

            this.Hide();
            Login mainMenu = new Login();
            mainMenu.Show();
            Hide();
        }

        void LimpiarCampos()
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();

        }

        private void FrmRegistroUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                cmbIdTipoUsuario.DataSource = RegistroUsuarioController.Cargar_TipoUsuario();
                cmbIdTipoUsuario.DisplayMember = "Tipo_Usuario";
                cmbIdTipoUsuario.ValueMember = "idTipo_Usuario";
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

        private void cmbIdTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}

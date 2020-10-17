using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Controlador;
using BusinessControl.Resources_Language;

namespace BusinessControl
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtUsuario_Enter_1(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASENA")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASENA";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO" || txtPassword.Text == "CONTRASENA")
            {
                MessageBox.Show("Los campos no pueden ir vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                EnviarDatosLog();
            }
        }
        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            txtPassword.Text = "CONTRASENA";
            txtPassword.UseSystemPasswordChar = false;
            txtUsuario.Text = "USUARIO";
            this.Show();
            txtUsuario.Focus();
        }
        void EnviarDatosLog()
        {
            AtributosLogin.usuario = txtUsuario.Text;
            AtributosLogin.clave = txtPassword.Text;
            bool acceso = LoginController.Acceso_Controller();
            if (acceso == true)
            {
                this.Hide();
                FrmBienvenida Bienvenida = new FrmBienvenida(txtUsuario.Text);
                Bienvenida.ShowDialog();
                FrmInicio mainMenu = new FrmInicio(txtUsuario.Text);
                mainMenu.Show();
                mainMenu.FormClosed += CerrarSesion;
                Hide();
            }
            else
            {
                MessageBox.Show("El usuario o la contrasena que ingresaste no coinciden con ninguna cuenta.",
                    "Error al iniciaer sensiom", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void VerficarPrimerUso()
        {
            bool valor = LoginController.VerificarPrimerUso_Controller();
            if (valor == true)
            {
                btnPrimerUso.Visible = false;
            }
            else if (valor == false)
            {
                btnPrimerUso.Visible = true;
            }
            else
            {
                MessageBox.Show("Error de verificacion inicial", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            VerficarPrimerUso();
        }

        private void btnPrimerUso_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrimerUso mainMenu = new FrmPrimerUso();
            mainMenu.Show();
            mainMenu.FormClosed += CerrarSesion;
            Hide();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistroUsuario mainMenu = new FrmRegistroUsuario();
            mainMenu.Show();
            mainMenu.FormClosed += CerrarSesion;
            Hide();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtUsuario.Text = Resources_Language.español.txtUsuario;
            txtPassword.Text = Resources_Language.español.txtPassword;
            btnRegistrarUsuario.Text = Resources_Language.español.btnRegistrarUsuario;
            label1.Text = español.label1;
            btnAcceder = Resources_Language.español.btnAcceder;
            linkLabel1 = Resources_Language.ingles.linkLabel1;
        }

        private void RdEnglish_CheckedChanged(object sender, EventArgs e)
        {
            txtUsuario.Text = Resources_Language.ingles.txtUsuario;
            txtPassword.Text = Resources_Language.ingles.txtPassword;
            btnRegistrarUsuario.Text = Resources_Language.ingles.btnRegistrarUsuario;
            label1.Text = Resources_Language.ingles.label1;
            btnAcceder = Resources_Language.ingles.btnAcceder;
            linkLabel1 = Resources_Language.ingles.linkLabel1;

        }
    }
}

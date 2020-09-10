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
            this.Hide();
            FrmBienvenida Bienvenida = new FrmBienvenida();
            Bienvenida.ShowDialog();
            FrmInicio mainMenu = new FrmInicio(txtUsuario.Text);
            mainMenu.Show();
            mainMenu.FormClosed += CerrarSesion;
            Hide();
        }
        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            txtPassword.Text = "CONTRASENA";
            txtPassword.UseSystemPasswordChar = false;
            txtUsuario.Text = "USUARIO";
            this.Show();
            txtUsuario.Focus();
        }

        void VerficarPrimerUso()
        {

        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

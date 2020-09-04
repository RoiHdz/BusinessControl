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
    public partial class FrmInicio : Form
    {
        public string usuario { get; set; }
        public FrmInicio(string user)
        {
            InitializeComponent();
            usuario = user;
            Desplegable();
        }
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public FrmInicio(/*string text*/)
        {
            //Text = text;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void Desplegable()
        {
            PanelClientes_SubMenu.Visible = false;
            //...
        }
        private void hideSubMenu()
        {
            if (PanelClientes_SubMenu.Visible == true)
            {
                PanelClientes_SubMenu.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu) {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de cerrar la aplicacion?",
                "Alerta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }
        private void BtnCliente_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelClientes_SubMenu);
        }
        private void horafecha_Tick_1(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de salir de la sesion?",
                "Alerta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnMateriales_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmMateriales());
        }

        private void BtnProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmProveedor());
        }

        private void BtnCliente_Empresa_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmmCliente_Empresa());
            hideSubMenu();
        }

        private void btnCliente_Persona_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmmClientes());
            hideSubMenu();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (MainController.ConnectController() == null)
            {
                MessageBox.Show("Error al intentar conectar", "ERROR 03", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Conexion exitosa!", "Prosceso compleatdo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            try
            {
                //lblUsuario = usuario;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {

        }
    }
}

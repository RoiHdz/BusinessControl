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
        public static string usuario { get; set; }
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
            if (MainController.idioma==1)
            {
                DialogResult dr = MessageBox.Show(Resources_Language.NotificacionesEspañol.Mensaje1,
             Resources_Language.NotificacionesEspañol.Encabezado1, MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning) ;
                if (dr == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show(Resources_Language.NotificacionesIngles.Mensaje1,
             Resources_Language.NotificacionesIngles.Encabezado1, MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    Application.Exit();
                }
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
            if (MainController.idioma == 1)
            {
                lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
                lblFecha.Text = DateTime.Now.ToLongDateString();
            }
            else
            {
                lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
                lblFecha.Text = DateTime.Now.ToString("MM/dd/yyy");
            }
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {

            if (MainController.idioma == 1)
            {
                DialogResult dr = MessageBox.Show(Resources_Language.NotificacionesEspañol.MensajeLogOut,
             Resources_Language.NotificacionesEspañol.Encabezado1, MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show(Resources_Language.NotificacionesIngles.MensajeLogOut,
             Resources_Language.NotificacionesIngles.Encabezado1, MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    this.Close();
                }
            }

        }

        void verificacionIdioma()
        {
            if (MainController.idioma == 1)
            {

            }
            else
            {
                BtnCliente.Text = Resources_Language.ingles.BtnCliente;
                BtnCliente_Empresa.Text = Resources_Language.ingles.BtnCliente_Empresa;
                btnCliente_Persona.Text = Resources_Language.ingles.btnCliente_Persona;
                BtnProveedor.Text = Resources_Language.ingles.BtnProveedor;
                BtnMateriales.Text = Resources_Language.ingles.BtnMateriales;
                BtnPresupuesto.Text = Resources_Language.ingles.BtnPresupuesto;
                btnProyecto.Text = Resources_Language.ingles.btnProyecto;
                btnAdministrar.Text = Resources_Language.ingles.btnAdministrar;
                BtnLogOut.Text = Resources_Language.ingles.BtnLogOut;
                btnConectar.Text = Resources_Language.ingles.btnConectar;
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
            if (MainController.ConnectController() == null  )
            {
                MessageBox.Show(Resources_Language.NotificacionesEspañol.MensajeConexion2,
                    Resources_Language.NotificacionesEspañol.EncabezadoConexion2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                MessageBox.Show(Resources_Language.NotificacionesEspañol.MensajeConexion1,
             Resources_Language.NotificacionesEspañol.EncabezadoConexion1, MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            if (MainController.idioma==1)
            {
                MessageBox.Show(Resources_Language.NotificacionesEspañol.MensajeConexion1,
             Resources_Language.NotificacionesEspañol.EncabezadoConexion1, MessageBoxButtons.OK,
             MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(Resources_Language.NotificacionesIngles.MensajeConexion1,
             Resources_Language.NotificacionesIngles.EncabezadoConexion1, MessageBoxButtons.OK,
             MessageBoxIcon.Information);
            }
            

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            verificacionIdioma();

            try
            {
                lblUsuaio.Text = usuario;
                VerificarDatos();
            }
            catch (Exception)
            {

                throw;
            }
        }
        void VerificarDatos()
        {
            AtributosMain.idUsuario = lblEmail.Text;
            bool info = MainController.infoMail_Controller();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {

        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }
    }
}

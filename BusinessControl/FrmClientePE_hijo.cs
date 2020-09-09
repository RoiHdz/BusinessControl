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
    public partial class FrmClientePE_hijo : Form
    {
        public FrmClientePE_hijo()
        {
            InitializeComponent();
            Desplegable();
        }
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Desplegable()
        {
            Panel_NumTelefono_SubMenu.Visible = false;
            //...
        }
        private void hideSubMenu()
        {
            if (Panel_NumTelefono_SubMenu.Visible == true)
            {
                Panel_NumTelefono_SubMenu.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
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

        private void BtnMostrarMas_Click(object sender, EventArgs e)
        {
            showSubMenu(Panel_NumTelefono_SubMenu);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuSuperior_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void FrmClientePE_hijo_Load(object sender, EventArgs e)
        {
            try
            {
                CmbEstado.DataSource = MainController.Cargar_Estado();
                CmbEstado.DisplayMember = "Estado";
                CmbEstado.ValueMember = "idEstado_ClienteP";
            }
            catch (Exception)
            {

                throw;
            }
        }
        void EnvioDatos()
        {
            MainController agregar = new MainController();
            agregar.PrimerNombre = txtPrimerNombre.Text;
            agregar.SegundoNombre = txtSegundoNombre.Text;
            agregar.PrimerApellido = txtPrimerApellido.Text;
            agregar.SegundoApellido = txtSegundoApellido.Text;
            agregar.dui = txtDui.Text;
            agregar.Correo = txtCorreo.Text;
            agregar.direccion = txtDireccion.Text;
            agregar.FechaNacimiento = dtpFechaNacimiento.Text;
            agregar.Estado = Convert.ToInt16(CmbEstado.SelectedValue);
            if (agregar.EnviarDatos_Controlle() == false)
            {
                MessageBox.Show("El usuario no puedo ser ingresado", "Advertencia", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            }
            else
            {
                LimpiarCampos();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EnvioDatos();
        }
        void LimpiarCampos()
        {
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtDui.Clear();
            txtPrimerApellido.Clear();
            txtPrimerNombre.Clear();
            txtSegundoApellido.Clear();
            txtSegundoNombre.Clear();
            txtTelefono1.Clear();
            txtTelefono2.Clear();
            txtTelefono3.Clear();
        }

        private void MenuSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////
    }
}

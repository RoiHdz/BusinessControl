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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
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
        private void lblNIF_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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

        private void MenuSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       
        void EnvioDatos()
        {
            ProveedoresController agregar = new ProveedoresController();
            agregar.DUI = txtDui.Text;
            agregar.NombreProveedor = txtPrimerNombre.Text;
            agregar.Direccion = txtDireccion.Text;
            agregar.CorreoProveedor = txtCorreoProveedor.Text;
            agregar.Descripcion = txtDescripcion.Text;
            agregar.EstadoProveedor = Convert.ToInt16(cmbEstado.SelectedValue);
            if (agregar.EnviarDatos_Controller() == false)
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
            txtDui.Clear();
            txtPrimerNombre.Clear();
            txtDireccion.Clear();
            txtCorreoProveedor.Clear();
            txtDescripcion.Clear();
            txtTelefono1.Clear();
            txtTelefono2.Clear();

        }

        private void FrmProveedores_Load_1(object sender, EventArgs e)
        {
            try
            {
                cmbEstado.DataSource = ProveedoresController.Cargar_Estado();
                cmbEstado.DisplayMember = "Estado";
                cmbEstado.ValueMember = "idEstado_Proveedor";
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

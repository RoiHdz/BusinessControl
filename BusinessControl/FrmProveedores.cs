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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EnvioDatos();
        }
       
        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox3.DataSource = ProveedoresController.Cargar_Proveedores();
                comboBox3.DisplayMember = "Estado";
                comboBox3.ValueMember = "idEstado_Proveedor";
            }
            catch (Exception)
            {

                throw;
            }
        }
        void EnvioDatos()
        {
            ProveedoresController agregar = new ProveedoresController();
            agregar.DUI = txtDui.Text;
            agregar.NombreProveedor = txtPrimerNombre.Text;
            agregar.Direccion = textBox2.Text;
            agregar.CorreoProveedor = textBox1.Text;
            agregar.Descripcion = txtDescripcion.Text;
            agregar.EstadoProveedor = Convert.ToInt16(comboBox3.SelectedValue);
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
            txtDui.Clear();
            txtPrimerNombre.Clear();
            textBox2.Clear();
            textBox1.Clear();
            txtDescripcion.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();

        }
    }
}

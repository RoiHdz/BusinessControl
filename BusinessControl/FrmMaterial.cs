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
    public partial class FrmMaterial : Form
    {
        public FrmMaterial()
        {
            InitializeComponent();
        }

        private void lblDescripcionMaterial_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EnvioDatos();
        }
        void EnvioDatos()
        {
            MaterialesController agregar = new MaterialesController();
            agregar.NombreMaterial = txtNombreMaterial.Text;
            agregar.CodigoMaterial = txtCodigoMaterial.Text;
            agregar.PrecioUnitario = Convert.ToDouble(txtPrecioUnitario.Text);
            agregar.Descripcion = txtDescripcion.Text;
            agregar.MarcaMaterial = txtMarcaMaterial.Text;
            agregar.FechaIngreso = dtpIngreso.Text;
            agregar.Proveedor = Convert.ToInt16(cmbProveedor.SelectedValue);
            agregar.Categoria = Convert.ToInt16(cmbCategoria.SelectedValue);
            agregar.Estado = Convert.ToInt16(cmbEstadoMaterial.SelectedValue);
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
            txtCodigoMaterial.Clear();
            txtDescripcion.Clear();
            txtMarcaMaterial.Clear();
            txtNombreMaterial.Clear();
            txtPrecioUnitario.Clear();
        }

        private void FrmMaterial_Load(object sender, EventArgs e)
        {
            verificacionIdioma();
            try
            {
                cmbEstadoMaterial.DataSource = MaterialesController.Cargar_Estado();
                cmbEstadoMaterial.DisplayMember = "Estado";
                cmbEstadoMaterial.ValueMember = "idEstado_material";

                cmbCategoria.DataSource = MaterialesController.Cargar_Categoria();
                cmbCategoria.DisplayMember = "Categoria";
                cmbCategoria.ValueMember = "idCategoria";

                cmbProveedor.DataSource = MaterialesController.Cargar_Proveedor();
                cmbProveedor.DisplayMember = "NIF";
                cmbProveedor.ValueMember = "idProveedor";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtNombreMaterial_TextChanged(object sender, EventArgs e)
        {
        }
        void verificacionIdioma()
        {
            if (MainController.idioma == 1)
            {

            }
            else
            {
                lblNombreMaterial.Text = Resources_Language.ingles.lblNombreMaterial;
                lblCodigoMaterial.Text = Resources_Language.ingles.lblCodigoMaterial;
                lblPrecioUnitario.Text = Resources_Language.ingles.lblPrecioUnitario;
                lblidProveedor.Text = Resources_Language.ingles.lblidProveedor;
                lblCategoria.Text = Resources_Language.ingles.lblCategoria;
                lblEstado.Text = Resources_Language.ingles.lblEstado;
                label1.Text = Resources_Language.ingles.label1;
                lblDescripcionMaterial.Text = Resources_Language.ingles.lblDescripcionMaterial;
                toolStripButton1.Text = Resources_Language.ingles.toolStripLabe1;
                btnAgregar.Text = Resources_Language.ingles.btnagregar;
                button2.Text = Resources_Language.ingles.button4;
                lblMarcaMaterial.Text = Resources_Language.ingles.lblMarcaMaterial;

            }
        }
    }
}

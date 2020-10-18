using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace BusinessControl
{
    public partial class FrmmClientes : Form
    {
        public FrmmClientes()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmClientePE_hijo Frm = new FrmClientePE_hijo();
            Frm.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmClientePE_hijo Frm = new FrmClientePE_hijo();
            Frm.ShowDialog();
        }

        private void FrmmClientes_Load(object sender, EventArgs e)
        {
            verificacionIdioma();
            try
            {
                DgvClientes_Persona.DataSource = MainController.Cargar_Cliente();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al capturar datos");
            }
        }

        private void DgvClientes_Persona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        void verificacionIdioma()
        {
            if (MainController.idioma == 1)
            {

            }
            else
            {
                btnAgregar.Text = Resources_Language.ingles.btnagregar;
                btnEditar.Text = Resources_Language.ingles.btnModificar;
                btnEliminar.Text = Resources_Language.ingles.btnEliminar;
                button4.Text = Resources_Language.ingles.button4;
            }
        }
    }
}

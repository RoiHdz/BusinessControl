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
    public partial class FrmMateriales : Form
    {
        public FrmMateriales()
        {
            InitializeComponent();
        }

        private void txtPrimerNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombreMaterial_Click(object sender, EventArgs e)
        {

        }

        private void lblCodigoMaterial_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrecioUnitario_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMaterial frm = new FrmMaterial();
            frm.ShowDialog();
        }

        private void FrmMateriales_Load(object sender, EventArgs e)
        {
            verificacionIdioma();
            try
            {
                DgvMateriales.DataSource = MaterialesController.Cargar_Materiales();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al capturar datos");
            }
        }

        private void DgvMateriales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        void verificacionIdioma()
        {
            if (MainController.idioma == 1)
            {

            }
            else
            {
                button1.Text = Resources_Language.ingles.button1;
                button2.Text = Resources_Language.ingles.button2;
                button3.Text = Resources_Language.ingles.button3;
                button4.Text = Resources_Language.ingles.button4;
            }
        }
    }
}

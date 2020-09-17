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
    public partial class FrmProveedor : Form
    {
        public FrmProveedor()
        {
            InitializeComponent();
        }

        private void DgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmProveedores Frm = new FrmProveedores();
            Frm.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmProveedores Frm = new FrmProveedores();
            Frm.ShowDialog();
        }
        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            try
            {
                DgvClientes.DataSource = ProveedoresController.Cargar_Proveedor();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al capturar datos");
            }
        }

    }
}

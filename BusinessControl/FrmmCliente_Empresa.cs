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
    public partial class FrmmCliente_Empresa : Form
    {
        public FrmmCliente_Empresa()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            FrmClienteEmpresa_hijo Frm = new FrmClienteEmpresa_hijo();
            Frm.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmClienteEmpresa_hijo Frm = new FrmClienteEmpresa_hijo();
            Frm.ShowDialog();
        }

        private void FrmmCliente_Empresa_Load(object sender, EventArgs e)
        {
            try
            {
                DgvClientes_Empresa.DataSource = ClienteEmpresaController.Cargar_ClienteEmpresa();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al capturar datos");
            }
        }

        private void DgvClientes_Empresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
 }
  

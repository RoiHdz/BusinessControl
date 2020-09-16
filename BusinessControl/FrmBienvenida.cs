using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessControl
{
    public partial class FrmBienvenida : Form
    {
        public static string usuario { get; set; }
        public FrmBienvenida( string user)
        {
            InitializeComponent();
            usuario = user;
        }

        private void FrmBienvenida_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            tmrFadeIn.Start();
            lblUsername.Text = usuario;
        }
        private void tmrFadeIn_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.05;
                progressBar1.Value += 1;
            if (progressBar1.Value == 100)
            {
                tmrFadeIn.Stop();
                tmrFadeOut.Start();
            }
        }

        private void tmrFadeOut_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                tmrFadeOut.Stop();
                this.Close();
            }
        }

        private void LoadingGif_Click(object sender, EventArgs e)
        {

        }
    }
}

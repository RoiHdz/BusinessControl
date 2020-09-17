namespace BusinessControl
{
    partial class FrmPrimerUso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuSuperior = new System.Windows.Forms.ToolStrip();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.lblCorreoEmpresa = new System.Windows.Forms.Label();
            this.txtCorreoEmpresa = new System.Windows.Forms.TextBox();
            this.lblNitEmpresa = new System.Windows.Forms.Label();
            this.txtNitEmpresa = new System.Windows.Forms.MaskedTextBox();
            this.lblRepresentante = new System.Windows.Forms.Label();
            this.txtRepresentante = new System.Windows.Forms.TextBox();
            this.lblDireccionEmpresa = new System.Windows.Forms.Label();
            this.txtDireccionEmpresa = new System.Windows.Forms.TextBox();
            this.lblLogoEmpresa = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnAgregarEmpresa = new System.Windows.Forms.Button();
            this.lblTipoEmpresa = new System.Windows.Forms.Label();
            this.cmbTipoEmpresa = new System.Windows.Forms.ComboBox();
            this.MenuSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuSuperior
            // 
            this.MenuSuperior.BackColor = System.Drawing.Color.White;
            this.MenuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCerrar,
            this.toolStripLabel1});
            this.MenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.MenuSuperior.Name = "MenuSuperior";
            this.MenuSuperior.Size = new System.Drawing.Size(771, 25);
            this.MenuSuperior.TabIndex = 2;
            this.MenuSuperior.Text = "Formulario Primer uso";
            this.MenuSuperior.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuSuperior_ItemClicked);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnCerrar.Image = global::BusinessControl.Properties.Resources.close_button;
            this.BtnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(23, 22);
            this.BtnCerrar.Text = "Salir";
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(125, 22);
            this.toolStripLabel1.Text = "Formulario Primer uso";
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNombreEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblNombreEmpresa.Location = new System.Drawing.Point(36, 50);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(118, 16);
            this.lblNombreEmpresa.TabIndex = 6;
            this.lblNombreEmpresa.Text = "Nombre Empresa:";
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Location = new System.Drawing.Point(39, 70);
            this.txtNombreEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(208, 20);
            this.txtNombreEmpresa.TabIndex = 7;
            // 
            // lblCorreoEmpresa
            // 
            this.lblCorreoEmpresa.AutoSize = true;
            this.lblCorreoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblCorreoEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblCorreoEmpresa.Location = new System.Drawing.Point(301, 50);
            this.lblCorreoEmpresa.Name = "lblCorreoEmpresa";
            this.lblCorreoEmpresa.Size = new System.Drawing.Size(52, 16);
            this.lblCorreoEmpresa.TabIndex = 10;
            this.lblCorreoEmpresa.Text = "Correo:";
            // 
            // txtCorreoEmpresa
            // 
            this.txtCorreoEmpresa.Location = new System.Drawing.Point(304, 70);
            this.txtCorreoEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCorreoEmpresa.Name = "txtCorreoEmpresa";
            this.txtCorreoEmpresa.Size = new System.Drawing.Size(208, 20);
            this.txtCorreoEmpresa.TabIndex = 11;
            // 
            // lblNitEmpresa
            // 
            this.lblNitEmpresa.AutoSize = true;
            this.lblNitEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNitEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblNitEmpresa.Location = new System.Drawing.Point(554, 50);
            this.lblNitEmpresa.Name = "lblNitEmpresa";
            this.lblNitEmpresa.Size = new System.Drawing.Size(33, 16);
            this.lblNitEmpresa.TabIndex = 12;
            this.lblNitEmpresa.Text = "NIT:";
            // 
            // txtNitEmpresa
            // 
            this.txtNitEmpresa.Location = new System.Drawing.Point(557, 70);
            this.txtNitEmpresa.Mask = "00000000-0";
            this.txtNitEmpresa.Name = "txtNitEmpresa";
            this.txtNitEmpresa.Size = new System.Drawing.Size(182, 20);
            this.txtNitEmpresa.TabIndex = 18;
            // 
            // lblRepresentante
            // 
            this.lblRepresentante.AutoSize = true;
            this.lblRepresentante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblRepresentante.ForeColor = System.Drawing.Color.White;
            this.lblRepresentante.Location = new System.Drawing.Point(36, 110);
            this.lblRepresentante.Name = "lblRepresentante";
            this.lblRepresentante.Size = new System.Drawing.Size(137, 16);
            this.lblRepresentante.TabIndex = 19;
            this.lblRepresentante.Text = "Representante Legal:";
            // 
            // txtRepresentante
            // 
            this.txtRepresentante.Location = new System.Drawing.Point(39, 132);
            this.txtRepresentante.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRepresentante.Name = "txtRepresentante";
            this.txtRepresentante.Size = new System.Drawing.Size(208, 20);
            this.txtRepresentante.TabIndex = 20;
            // 
            // lblDireccionEmpresa
            // 
            this.lblDireccionEmpresa.AutoSize = true;
            this.lblDireccionEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblDireccionEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblDireccionEmpresa.Location = new System.Drawing.Point(554, 110);
            this.lblDireccionEmpresa.Name = "lblDireccionEmpresa";
            this.lblDireccionEmpresa.Size = new System.Drawing.Size(68, 16);
            this.lblDireccionEmpresa.TabIndex = 21;
            this.lblDireccionEmpresa.Text = "Direccion:";
            // 
            // txtDireccionEmpresa
            // 
            this.txtDireccionEmpresa.Location = new System.Drawing.Point(557, 133);
            this.txtDireccionEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccionEmpresa.Name = "txtDireccionEmpresa";
            this.txtDireccionEmpresa.Size = new System.Drawing.Size(182, 20);
            this.txtDireccionEmpresa.TabIndex = 22;
            // 
            // lblLogoEmpresa
            // 
            this.lblLogoEmpresa.AutoSize = true;
            this.lblLogoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblLogoEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblLogoEmpresa.Location = new System.Drawing.Point(36, 181);
            this.lblLogoEmpresa.Name = "lblLogoEmpresa";
            this.lblLogoEmpresa.Size = new System.Drawing.Size(100, 16);
            this.lblLogoEmpresa.TabIndex = 23;
            this.lblLogoEmpresa.Text = "Logo Empresa:";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(39, 214);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(134, 63);
            this.pictureBoxLogo.TabIndex = 24;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnAgregarEmpresa
            // 
            this.btnAgregarEmpresa.Location = new System.Drawing.Point(634, 230);
            this.btnAgregarEmpresa.Name = "btnAgregarEmpresa";
            this.btnAgregarEmpresa.Size = new System.Drawing.Size(105, 47);
            this.btnAgregarEmpresa.TabIndex = 28;
            this.btnAgregarEmpresa.Text = "Agregar";
            this.btnAgregarEmpresa.UseVisualStyleBackColor = true;
            this.btnAgregarEmpresa.Click += new System.EventHandler(this.btnAgregarEmpresa_Click);
            // 
            // lblTipoEmpresa
            // 
            this.lblTipoEmpresa.AutoSize = true;
            this.lblTipoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblTipoEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblTipoEmpresa.Location = new System.Drawing.Point(301, 110);
            this.lblTipoEmpresa.Name = "lblTipoEmpresa";
            this.lblTipoEmpresa.Size = new System.Drawing.Size(97, 16);
            this.lblTipoEmpresa.TabIndex = 29;
            this.lblTipoEmpresa.Text = "Tipo Empresa:";
            // 
            // cmbTipoEmpresa
            // 
            this.cmbTipoEmpresa.FormattingEnabled = true;
            this.cmbTipoEmpresa.Location = new System.Drawing.Point(304, 132);
            this.cmbTipoEmpresa.Name = "cmbTipoEmpresa";
            this.cmbTipoEmpresa.Size = new System.Drawing.Size(208, 21);
            this.cmbTipoEmpresa.TabIndex = 37;
            this.cmbTipoEmpresa.SelectedIndexChanged += new System.EventHandler(this.cmbTipoEmpresa_SelectedIndexChanged);
            // 
            // FrmPrimerUso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(771, 299);
            this.Controls.Add(this.cmbTipoEmpresa);
            this.Controls.Add(this.lblTipoEmpresa);
            this.Controls.Add(this.btnAgregarEmpresa);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.lblLogoEmpresa);
            this.Controls.Add(this.txtDireccionEmpresa);
            this.Controls.Add(this.lblDireccionEmpresa);
            this.Controls.Add(this.txtRepresentante);
            this.Controls.Add(this.lblRepresentante);
            this.Controls.Add(this.txtNitEmpresa);
            this.Controls.Add(this.lblNitEmpresa);
            this.Controls.Add(this.txtCorreoEmpresa);
            this.Controls.Add(this.lblCorreoEmpresa);
            this.Controls.Add(this.txtNombreEmpresa);
            this.Controls.Add(this.lblNombreEmpresa);
            this.Controls.Add(this.MenuSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrimerUso";
            this.Text = "FrmPrimerUso";
            this.MenuSuperior.ResumeLayout(false);
            this.MenuSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MenuSuperior;
        private System.Windows.Forms.ToolStripButton BtnCerrar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label lblNombreEmpresa;
        public System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.Label lblCorreoEmpresa;
        public System.Windows.Forms.TextBox txtCorreoEmpresa;
        private System.Windows.Forms.Label lblNitEmpresa;
        public System.Windows.Forms.MaskedTextBox txtNitEmpresa;
        private System.Windows.Forms.Label lblRepresentante;
        public System.Windows.Forms.TextBox txtRepresentante;
        private System.Windows.Forms.Label lblDireccionEmpresa;
        public System.Windows.Forms.TextBox txtDireccionEmpresa;
        private System.Windows.Forms.Label lblLogoEmpresa;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnAgregarEmpresa;
        private System.Windows.Forms.Label lblTipoEmpresa;
        private System.Windows.Forms.ComboBox cmbTipoEmpresa;
    }
}
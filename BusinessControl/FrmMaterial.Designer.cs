namespace BusinessControl
{
    partial class FrmMaterial
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblNombreMaterial = new System.Windows.Forms.Label();
            this.txtNombreMaterial = new System.Windows.Forms.TextBox();
            this.lblCodigoMaterial = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.txtCodigoMaterial = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.lblDescripcionMaterial = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblMarcaMaterial = new System.Windows.Forms.Label();
            this.lblidProveedor = new System.Windows.Forms.Label();
            this.txtMarcaMaterial = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbEstadoMaterial = new System.Windows.Forms.ComboBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuSuperior
            // 
            this.MenuSuperior.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1});
            this.MenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.MenuSuperior.Name = "MenuSuperior";
            this.MenuSuperior.Size = new System.Drawing.Size(752, 27);
            this.MenuSuperior.TabIndex = 1;
            this.MenuSuperior.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::BusinessControl.Properties.Resources.close_button;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "Salir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(175, 24);
            this.toolStripLabel1.Text = "Formulario de materiales";
            // 
            // lblNombreMaterial
            // 
            this.lblNombreMaterial.AutoSize = true;
            this.lblNombreMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMaterial.ForeColor = System.Drawing.Color.White;
            this.lblNombreMaterial.Location = new System.Drawing.Point(9, 44);
            this.lblNombreMaterial.Name = "lblNombreMaterial";
            this.lblNombreMaterial.Size = new System.Drawing.Size(165, 20);
            this.lblNombreMaterial.TabIndex = 6;
            this.lblNombreMaterial.Text = "Nombre del material:";
            // 
            // txtNombreMaterial
            // 
            this.txtNombreMaterial.Location = new System.Drawing.Point(12, 64);
            this.txtNombreMaterial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreMaterial.Name = "txtNombreMaterial";
            this.txtNombreMaterial.Size = new System.Drawing.Size(229, 24);
            this.txtNombreMaterial.TabIndex = 7;
            this.txtNombreMaterial.TextChanged += new System.EventHandler(this.txtNombreMaterial_TextChanged);
            // 
            // lblCodigoMaterial
            // 
            this.lblCodigoMaterial.AutoSize = true;
            this.lblCodigoMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoMaterial.ForeColor = System.Drawing.Color.White;
            this.lblCodigoMaterial.Location = new System.Drawing.Point(253, 44);
            this.lblCodigoMaterial.Name = "lblCodigoMaterial";
            this.lblCodigoMaterial.Size = new System.Drawing.Size(158, 20);
            this.lblCodigoMaterial.TabIndex = 8;
            this.lblCodigoMaterial.Text = "Codigo del material:";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario.ForeColor = System.Drawing.Color.White;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(508, 44);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(122, 20);
            this.lblPrecioUnitario.TabIndex = 9;
            this.lblPrecioUnitario.Text = "Precio unitario:";
            // 
            // txtCodigoMaterial
            // 
            this.txtCodigoMaterial.Location = new System.Drawing.Point(256, 64);
            this.txtCodigoMaterial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoMaterial.Name = "txtCodigoMaterial";
            this.txtCodigoMaterial.Size = new System.Drawing.Size(229, 24);
            this.txtCodigoMaterial.TabIndex = 10;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(511, 64);
            this.txtPrecioUnitario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(229, 24);
            this.txtPrecioUnitario.TabIndex = 11;
            // 
            // lblDescripcionMaterial
            // 
            this.lblDescripcionMaterial.AutoSize = true;
            this.lblDescripcionMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionMaterial.ForeColor = System.Drawing.Color.White;
            this.lblDescripcionMaterial.Location = new System.Drawing.Point(508, 162);
            this.lblDescripcionMaterial.Name = "lblDescripcionMaterial";
            this.lblDescripcionMaterial.Size = new System.Drawing.Size(104, 20);
            this.lblDescripcionMaterial.TabIndex = 12;
            this.lblDescripcionMaterial.Text = "Descripcion:";
            this.lblDescripcionMaterial.Click += new System.EventHandler(this.lblDescripcionMaterial_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(511, 182);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(229, 55);
            this.txtDescripcion.TabIndex = 13;
            // 
            // lblMarcaMaterial
            // 
            this.lblMarcaMaterial.AutoSize = true;
            this.lblMarcaMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaMaterial.ForeColor = System.Drawing.Color.White;
            this.lblMarcaMaterial.Location = new System.Drawing.Point(12, 100);
            this.lblMarcaMaterial.Name = "lblMarcaMaterial";
            this.lblMarcaMaterial.Size = new System.Drawing.Size(61, 20);
            this.lblMarcaMaterial.TabIndex = 14;
            this.lblMarcaMaterial.Text = "Marca:";
            // 
            // lblidProveedor
            // 
            this.lblidProveedor.AutoSize = true;
            this.lblidProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidProveedor.ForeColor = System.Drawing.Color.White;
            this.lblidProveedor.Location = new System.Drawing.Point(253, 100);
            this.lblidProveedor.Name = "lblidProveedor";
            this.lblidProveedor.Size = new System.Drawing.Size(90, 20);
            this.lblidProveedor.TabIndex = 15;
            this.lblidProveedor.Text = "Proveedor:";
            // 
            // txtMarcaMaterial
            // 
            this.txtMarcaMaterial.Location = new System.Drawing.Point(12, 120);
            this.txtMarcaMaterial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMarcaMaterial.Name = "txtMarcaMaterial";
            this.txtMarcaMaterial.Size = new System.Drawing.Size(229, 24);
            this.txtMarcaMaterial.TabIndex = 16;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(508, 100);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(86, 20);
            this.lblCategoria.TabIndex = 18;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(12, 162);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(66, 20);
            this.lblEstado.TabIndex = 19;
            this.lblEstado.Text = "Estado:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(511, 244);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 41);
            this.btnAgregar.TabIndex = 34;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(641, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 41);
            this.button2.TabIndex = 35;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(511, 119);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(229, 27);
            this.cmbCategoria.TabIndex = 36;
            // 
            // cmbEstadoMaterial
            // 
            this.cmbEstadoMaterial.FormattingEnabled = true;
            this.cmbEstadoMaterial.Location = new System.Drawing.Point(12, 181);
            this.cmbEstadoMaterial.Name = "cmbEstadoMaterial";
            this.cmbEstadoMaterial.Size = new System.Drawing.Size(229, 27);
            this.cmbEstadoMaterial.TabIndex = 37;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(256, 120);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(229, 27);
            this.cmbProveedor.TabIndex = 38;
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.CustomFormat = "yyyy-MM-dd";
            this.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIngreso.Location = new System.Drawing.Point(256, 184);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(229, 24);
            this.dtpIngreso.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(253, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Fecha de ingreso:";
            // 
            // FrmMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(752, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpIngreso);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.cmbEstadoMaterial);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtMarcaMaterial);
            this.Controls.Add(this.lblidProveedor);
            this.Controls.Add(this.lblMarcaMaterial);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcionMaterial);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.txtCodigoMaterial);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.lblCodigoMaterial);
            this.Controls.Add(this.txtNombreMaterial);
            this.Controls.Add(this.lblNombreMaterial);
            this.Controls.Add(this.MenuSuperior);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMaterial_Load);
            this.MenuSuperior.ResumeLayout(false);
            this.MenuSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MenuSuperior;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label lblNombreMaterial;
        public System.Windows.Forms.TextBox txtNombreMaterial;
        private System.Windows.Forms.Label lblCodigoMaterial;
        private System.Windows.Forms.Label lblPrecioUnitario;
        public System.Windows.Forms.TextBox txtCodigoMaterial;
        public System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label lblDescripcionMaterial;
        public System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblMarcaMaterial;
        private System.Windows.Forms.Label lblidProveedor;
        public System.Windows.Forms.TextBox txtMarcaMaterial;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbEstadoMaterial;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.Label label1;
    }
}
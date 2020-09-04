namespace BusinessControl
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnPresupuesto = new System.Windows.Forms.Button();
            this.BtnMateriales = new System.Windows.Forms.Button();
            this.BtnProveedor = new System.Windows.Forms.Button();
            this.PanelClientes_SubMenu = new System.Windows.Forms.Panel();
            this.btnCliente_Persona = new System.Windows.Forms.Button();
            this.BtnCliente_Empresa = new System.Windows.Forms.Button();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNombre_U = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConectar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            this.PanelClientes_SubMenu.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.LimeGreen;
            this.PanelMenu.Controls.Add(this.button2);
            this.PanelMenu.Controls.Add(this.button1);
            this.PanelMenu.Controls.Add(this.BtnPresupuesto);
            this.PanelMenu.Controls.Add(this.BtnMateriales);
            this.PanelMenu.Controls.Add(this.BtnProveedor);
            this.PanelMenu.Controls.Add(this.PanelClientes_SubMenu);
            this.PanelMenu.Controls.Add(this.BtnLogOut);
            this.PanelMenu.Controls.Add(this.BtnCliente);
            this.PanelMenu.Controls.Add(this.pnlDatos);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 29);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(243, 616);
            this.PanelMenu.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::BusinessControl.Properties.Resources.profile;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 45);
            this.button2.TabIndex = 11;
            this.button2.Text = "Administrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::BusinessControl.Properties.Resources.list;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Proyecto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnPresupuesto
            // 
            this.BtnPresupuesto.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPresupuesto.FlatAppearance.BorderSize = 0;
            this.BtnPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPresupuesto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPresupuesto.ForeColor = System.Drawing.Color.White;
            this.BtnPresupuesto.Image = global::BusinessControl.Properties.Resources.calculator;
            this.BtnPresupuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPresupuesto.Location = new System.Drawing.Point(0, 313);
            this.BtnPresupuesto.Name = "BtnPresupuesto";
            this.BtnPresupuesto.Size = new System.Drawing.Size(243, 45);
            this.BtnPresupuesto.TabIndex = 9;
            this.BtnPresupuesto.Text = "Presupuesto";
            this.BtnPresupuesto.UseVisualStyleBackColor = true;
            // 
            // BtnMateriales
            // 
            this.BtnMateriales.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMateriales.FlatAppearance.BorderSize = 0;
            this.BtnMateriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMateriales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMateriales.ForeColor = System.Drawing.Color.White;
            this.BtnMateriales.Image = global::BusinessControl.Properties.Resources.book;
            this.BtnMateriales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMateriales.Location = new System.Drawing.Point(0, 268);
            this.BtnMateriales.Name = "BtnMateriales";
            this.BtnMateriales.Size = new System.Drawing.Size(243, 45);
            this.BtnMateriales.TabIndex = 8;
            this.BtnMateriales.Text = "Materiales";
            this.BtnMateriales.UseVisualStyleBackColor = true;
            this.BtnMateriales.Click += new System.EventHandler(this.BtnMateriales_Click_1);
            // 
            // BtnProveedor
            // 
            this.BtnProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProveedor.FlatAppearance.BorderSize = 0;
            this.BtnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProveedor.ForeColor = System.Drawing.Color.White;
            this.BtnProveedor.Image = global::BusinessControl.Properties.Resources.truck;
            this.BtnProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProveedor.Location = new System.Drawing.Point(0, 223);
            this.BtnProveedor.Name = "BtnProveedor";
            this.BtnProveedor.Size = new System.Drawing.Size(243, 45);
            this.BtnProveedor.TabIndex = 7;
            this.BtnProveedor.Text = "Proveedores";
            this.BtnProveedor.UseVisualStyleBackColor = true;
            this.BtnProveedor.Click += new System.EventHandler(this.BtnProveedor_Click);
            // 
            // PanelClientes_SubMenu
            // 
            this.PanelClientes_SubMenu.Controls.Add(this.btnCliente_Persona);
            this.PanelClientes_SubMenu.Controls.Add(this.BtnCliente_Empresa);
            this.PanelClientes_SubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelClientes_SubMenu.Location = new System.Drawing.Point(0, 137);
            this.PanelClientes_SubMenu.Name = "PanelClientes_SubMenu";
            this.PanelClientes_SubMenu.Size = new System.Drawing.Size(243, 86);
            this.PanelClientes_SubMenu.TabIndex = 6;
            // 
            // btnCliente_Persona
            // 
            this.btnCliente_Persona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCliente_Persona.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente_Persona.FlatAppearance.BorderSize = 0;
            this.btnCliente_Persona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente_Persona.Location = new System.Drawing.Point(0, 42);
            this.btnCliente_Persona.Name = "btnCliente_Persona";
            this.btnCliente_Persona.Size = new System.Drawing.Size(243, 42);
            this.btnCliente_Persona.TabIndex = 5;
            this.btnCliente_Persona.Text = "Persona";
            this.btnCliente_Persona.UseVisualStyleBackColor = false;
            this.btnCliente_Persona.Click += new System.EventHandler(this.btnCliente_Persona_Click);
            // 
            // BtnCliente_Empresa
            // 
            this.BtnCliente_Empresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnCliente_Empresa.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCliente_Empresa.FlatAppearance.BorderSize = 0;
            this.BtnCliente_Empresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCliente_Empresa.Location = new System.Drawing.Point(0, 0);
            this.BtnCliente_Empresa.Name = "BtnCliente_Empresa";
            this.BtnCliente_Empresa.Size = new System.Drawing.Size(243, 42);
            this.BtnCliente_Empresa.TabIndex = 4;
            this.BtnCliente_Empresa.Text = "Empresa";
            this.BtnCliente_Empresa.UseVisualStyleBackColor = false;
            this.BtnCliente_Empresa.Click += new System.EventHandler(this.BtnCliente_Empresa_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnLogOut.FlatAppearance.BorderSize = 0;
            this.BtnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOut.ForeColor = System.Drawing.Color.White;
            this.BtnLogOut.Image = global::BusinessControl.Properties.Resources._switch;
            this.BtnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogOut.Location = new System.Drawing.Point(0, 571);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(243, 45);
            this.BtnLogOut.TabIndex = 4;
            this.BtnLogOut.Text = "Cerrar Sesion";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.BackColor = System.Drawing.Color.Transparent;
            this.BtnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCliente.FlatAppearance.BorderSize = 0;
            this.BtnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente.ForeColor = System.Drawing.Color.White;
            this.BtnCliente.Image = global::BusinessControl.Properties.Resources.user_tie;
            this.BtnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCliente.Location = new System.Drawing.Point(0, 92);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(243, 45);
            this.BtnCliente.TabIndex = 1;
            this.BtnCliente.Text = "Clientes";
            this.BtnCliente.UseVisualStyleBackColor = false;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.lblCargo);
            this.pnlDatos.Controls.Add(this.lblUsuario);
            this.pnlDatos.Controls.Add(this.lblNombre_U);
            this.pnlDatos.Controls.Add(this.pictureBox3);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatos.Location = new System.Drawing.Point(0, 0);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(243, 92);
            this.pnlDatos.TabIndex = 0;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(88, 56);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(41, 16);
            this.lblCargo.TabIndex = 11;
            this.lblCargo.Text = "label4";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(88, 31);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(41, 16);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "label3";
            // 
            // lblNombre_U
            // 
            this.lblNombre_U.AutoSize = true;
            this.lblNombre_U.Location = new System.Drawing.Point(88, 6);
            this.lblNombre_U.Name = "lblNombre_U";
            this.lblNombre_U.Size = new System.Drawing.Size(41, 16);
            this.lblNombre_U.TabIndex = 9;
            this.lblNombre_U.Text = "label2";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BusinessControl.Properties.Resources.user_shape1;
            this.pictureBox3.Location = new System.Drawing.Point(12, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick_1);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(4, 648);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(65, 22);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "label2";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.DarkRed;
            this.lblHora.Location = new System.Drawing.Point(306, 648);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(65, 22);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Business control - Sistema de gestion empresarial v1.0.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BusinessControl.Properties.Resources.close_button;
            this.pictureBox1.Location = new System.Drawing.Point(1343, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BusinessControl.Properties.Resources.horizontal_line_remove_button;
            this.pictureBox2.Location = new System.Drawing.Point(1313, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::BusinessControl.Properties.Resources.close_button;
            this.btnCerrar.Location = new System.Drawing.Point(1282, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(10, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Image = global::BusinessControl.Properties.Resources.horizontal_line_remove_button;
            this.BtnMinimizar.Location = new System.Drawing.Point(1266, 2);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(10, 21);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinimizar.TabIndex = 4;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.BtnMinimizar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 29);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnConectar
            // 
            this.btnConectar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnConectar.Image = global::BusinessControl.Properties.Resources.high_wifi_signal_indicator;
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnConectar.Size = new System.Drawing.Size(119, 22);
            this.btnConectar.Text = "Probar conexion";
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConectar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 645);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1300, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(243, 29);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1057, 616);
            this.PanelContenedor.TabIndex = 8;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1300, 670);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.toolStrip2);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelClientes_SubMenu.ResumeLayout(false);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNombre_U;
        private System.Windows.Forms.Panel PanelClientes_SubMenu;
        private System.Windows.Forms.Button BtnProveedor;
        private System.Windows.Forms.Button BtnMateriales;
        private System.Windows.Forms.Button btnCliente_Persona;
        private System.Windows.Forms.Button BtnCliente_Empresa;
        private System.Windows.Forms.Button BtnPresupuesto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton btnConectar;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.Panel PanelContenedor;
    }
}


﻿namespace BusinessControl
{
    partial class FrmProveedores
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.lblNIT = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreoProveedor = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDui = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefono1 = new System.Windows.Forms.MaskedTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.Panel_NumTelefono_SubMenu = new System.Windows.Forms.Panel();
            this.txtTelefono2 = new System.Windows.Forms.MaskedTextBox();
            this.BtnMostrarMas = new System.Windows.Forms.PictureBox();
            this.MenuSuperior.SuspendLayout();
            this.Panel_NumTelefono_SubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMostrarMas)).BeginInit();
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
            this.MenuSuperior.Size = new System.Drawing.Size(752, 25);
            this.MenuSuperior.TabIndex = 1;
            this.MenuSuperior.Text = "toolStrip1";
            this.MenuSuperior.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuSuperior_ItemClicked);
            this.MenuSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuSuperior_MouseDown);
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
            this.toolStripLabel1.Size = new System.Drawing.Size(165, 22);
            this.toolStripLabel1.Text = "Formulario datos proveedores";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(243, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(127, 16);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre Proveedor:";
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Location = new System.Drawing.Point(246, 67);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(208, 21);
            this.txtPrimerNombre.TabIndex = 6;
            // 
            // lblNIT
            // 
            this.lblNIT.AutoSize = true;
            this.lblNIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNIT.ForeColor = System.Drawing.Color.White;
            this.lblNIT.Location = new System.Drawing.Point(32, 47);
            this.lblNIT.Name = "lblNIT";
            this.lblNIT.Size = new System.Drawing.Size(33, 16);
            this.lblNIT.TabIndex = 7;
            this.lblNIT.Text = "NIT:";
            this.lblNIT.Click += new System.EventHandler(this.lblNIF_Click);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(243, 106);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(52, 16);
            this.lblCorreo.TabIndex = 9;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtCorreoProveedor
            // 
            this.txtCorreoProveedor.Location = new System.Drawing.Point(246, 129);
            this.txtCorreoProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCorreoProveedor.Name = "txtCorreoProveedor";
            this.txtCorreoProveedor.Size = new System.Drawing.Size(208, 21);
            this.txtCorreoProveedor.TabIndex = 10;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(468, 47);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(68, 16);
            this.lblDireccion.TabIndex = 11;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(471, 67);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(269, 21);
            this.txtDireccion.TabIndex = 12;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(32, 106);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 16);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(32, 168);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(65, 16);
            this.lblTelefono.TabIndex = 15;
            this.lblTelefono.Text = "Telefono:";
            this.lblTelefono.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(35, 67);
            this.txtDui.Mask = "00000000-0";
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(201, 21);
            this.txtDui.TabIndex = 17;
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.Location = new System.Drawing.Point(35, 187);
            this.txtTelefono1.Mask = "0000-0000";
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.Size = new System.Drawing.Size(201, 21);
            this.txtTelefono1.TabIndex = 19;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(468, 106);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(83, 16);
            this.lblDescripcion.TabIndex = 20;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(471, 125);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(269, 83);
            this.txtDescripcion.TabIndex = 21;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(519, 244);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 41);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(641, 244);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(99, 41);
            this.btnActualizar.TabIndex = 33;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(35, 126);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(201, 24);
            this.cmbEstado.TabIndex = 36;
            // 
            // Panel_NumTelefono_SubMenu
            // 
            this.Panel_NumTelefono_SubMenu.Controls.Add(this.txtTelefono2);
            this.Panel_NumTelefono_SubMenu.Location = new System.Drawing.Point(35, 209);
            this.Panel_NumTelefono_SubMenu.Name = "Panel_NumTelefono_SubMenu";
            this.Panel_NumTelefono_SubMenu.Size = new System.Drawing.Size(205, 36);
            this.Panel_NumTelefono_SubMenu.TabIndex = 37;
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.Location = new System.Drawing.Point(0, 5);
            this.txtTelefono2.Mask = "0000-0000";
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.Size = new System.Drawing.Size(201, 21);
            this.txtTelefono2.TabIndex = 20;
            // 
            // BtnMostrarMas
            // 
            this.BtnMostrarMas.Image = global::BusinessControl.Properties.Resources.add_button_inside_black_circle;
            this.BtnMostrarMas.Location = new System.Drawing.Point(239, 185);
            this.BtnMostrarMas.Name = "BtnMostrarMas";
            this.BtnMostrarMas.Size = new System.Drawing.Size(26, 31);
            this.BtnMostrarMas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMostrarMas.TabIndex = 38;
            this.BtnMostrarMas.TabStop = false;
            this.BtnMostrarMas.Click += new System.EventHandler(this.BtnMostrarMas_Click);
            // 
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(752, 297);
            this.Controls.Add(this.BtnMostrarMas);
            this.Controls.Add(this.Panel_NumTelefono_SubMenu);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtTelefono1);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtCorreoProveedor);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblNIT);
            this.Controls.Add(this.txtPrimerNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.MenuSuperior);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProveedores";
            this.Load += new System.EventHandler(this.FrmProveedores_Load_1);
            this.MenuSuperior.ResumeLayout(false);
            this.MenuSuperior.PerformLayout();
            this.Panel_NumTelefono_SubMenu.ResumeLayout(false);
            this.Panel_NumTelefono_SubMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMostrarMas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MenuSuperior;
        private System.Windows.Forms.ToolStripButton BtnCerrar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.Label lblNIT;
        private System.Windows.Forms.Label lblCorreo;
        public System.Windows.Forms.TextBox txtCorreoProveedor;
        private System.Windows.Forms.Label lblDireccion;
        public System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTelefono;
        public System.Windows.Forms.MaskedTextBox txtDui;
        public System.Windows.Forms.MaskedTextBox txtTelefono1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Panel Panel_NumTelefono_SubMenu;
        public System.Windows.Forms.MaskedTextBox txtTelefono2;
        private System.Windows.Forms.PictureBox BtnMostrarMas;
    }
}
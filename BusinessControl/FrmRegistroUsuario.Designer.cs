﻿namespace BusinessControl
{
    partial class FrmRegistroUsuario
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblIdTipoUsuario = new System.Windows.Forms.Label();
            this.bntAgragar = new System.Windows.Forms.Button();
            this.cmbIdTipoUsuario = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.BtnCerrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(981, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(302, 24);
            this.toolStripLabel1.Text = "Formulario de datos de registro de ususario ";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnCerrar.Image = global::BusinessControl.Properties.Resources.close_button;
            this.BtnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(24, 24);
            this.BtnCerrar.Text = "Salir";
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUsuario.Location = new System.Drawing.Point(36, 49);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(67, 20);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(40, 73);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(320, 22);
            this.txtUsuario.TabIndex = 9;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.Window;
            this.lblContraseña.Location = new System.Drawing.Point(579, 49);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(95, 20);
            this.lblContraseña.TabIndex = 10;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(583, 73);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(320, 22);
            this.txtContraseña.TabIndex = 11;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNombre.Location = new System.Drawing.Point(36, 121);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(40, 144);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(320, 22);
            this.txtNombre.TabIndex = 13;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblApellido.ForeColor = System.Drawing.SystemColors.Window;
            this.lblApellido.Location = new System.Drawing.Point(579, 121);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(68, 20);
            this.lblApellido.TabIndex = 14;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(583, 156);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(320, 22);
            this.txtApellido.TabIndex = 15;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCorreo.Location = new System.Drawing.Point(44, 209);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(60, 20);
            this.lblCorreo.TabIndex = 16;
            this.lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(40, 233);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(320, 22);
            this.txtCorreo.TabIndex = 17;
            // 
            // lblIdTipoUsuario
            // 
            this.lblIdTipoUsuario.AutoSize = true;
            this.lblIdTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblIdTipoUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.lblIdTipoUsuario.Location = new System.Drawing.Point(579, 209);
            this.lblIdTipoUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdTipoUsuario.Name = "lblIdTipoUsuario";
            this.lblIdTipoUsuario.Size = new System.Drawing.Size(112, 20);
            this.lblIdTipoUsuario.TabIndex = 18;
            this.lblIdTipoUsuario.Text = "IdTipoUsuario";
            // 
            // bntAgragar
            // 
            this.bntAgragar.Location = new System.Drawing.Point(739, 282);
            this.bntAgragar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntAgragar.Name = "bntAgragar";
            this.bntAgragar.Size = new System.Drawing.Size(165, 41);
            this.bntAgragar.TabIndex = 20;
            this.bntAgragar.Text = "Agregar";
            this.bntAgragar.UseVisualStyleBackColor = true;
            this.bntAgragar.Click += new System.EventHandler(this.bntAgragar_Click);
            // 
            // cmbIdTipoUsuario
            // 
            this.cmbIdTipoUsuario.FormattingEnabled = true;
            this.cmbIdTipoUsuario.Location = new System.Drawing.Point(583, 233);
            this.cmbIdTipoUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbIdTipoUsuario.Name = "cmbIdTipoUsuario";
            this.cmbIdTipoUsuario.Size = new System.Drawing.Size(320, 24);
            this.cmbIdTipoUsuario.TabIndex = 21;
            this.cmbIdTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbIdTipoUsuario_SelectedIndexChanged);
            // 
            // FrmRegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(981, 337);
            this.Controls.Add(this.cmbIdTipoUsuario);
            this.Controls.Add(this.bntAgragar);
            this.Controls.Add(this.lblIdTipoUsuario);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmRegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistroUsuario";
            this.Load += new System.EventHandler(this.FrmRegistroUsuario_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton BtnCerrar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblIdTipoUsuario;
        private System.Windows.Forms.Button bntAgragar;
        private System.Windows.Forms.ComboBox cmbIdTipoUsuario;
    }
}
namespace BusinessControl
{
    partial class FrmClientePE_hijo
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
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.MenuSuperior = new System.Windows.Forms.ToolStrip();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblDUI = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.Panel_NumTelefono_SubMenu = new System.Windows.Forms.Panel();
            this.txtTelefono3 = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefono2 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDui = new System.Windows.Forms.MaskedTextBox();
            this.btnAgregaar = new System.Windows.Forms.Button();
            this.txtTelefono1 = new System.Windows.Forms.MaskedTextBox();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.BtnMostrarMas = new System.Windows.Forms.PictureBox();
            this.MenuSuperior.SuspendLayout();
            this.Panel_NumTelefono_SubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMostrarMas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Location = new System.Drawing.Point(14, 73);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(169, 21);
            this.txtPrimerNombre.TabIndex = 1;
            this.txtPrimerNombre.TextChanged += new System.EventHandler(this.txtPrimerNombre_TextChanged);
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Location = new System.Drawing.Point(199, 73);
            this.txtSegundoNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(169, 21);
            this.txtSegundoNombre.TabIndex = 2;
            this.txtSegundoNombre.TextChanged += new System.EventHandler(this.txtSegundoNombre_TextChanged);
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(384, 73);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(169, 21);
            this.txtPrimerApellido.TabIndex = 3;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(570, 73);
            this.txtSegundoApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(169, 21);
            this.txtSegundoApellido.TabIndex = 4;
            // 
            // MenuSuperior
            // 
            this.MenuSuperior.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCerrar,
            this.toolStripLabel1});
            this.MenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.MenuSuperior.Name = "MenuSuperior";
            this.MenuSuperior.Size = new System.Drawing.Size(752, 27);
            this.MenuSuperior.TabIndex = 0;
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
            this.BtnCerrar.Size = new System.Drawing.Size(24, 24);
            this.BtnCerrar.Text = "Salir";
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(190, 24);
            this.toolStripLabel1.Text = "Formulario datos clientes personas";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerNombre.ForeColor = System.Drawing.Color.White;
            this.lblPrimerNombre.Location = new System.Drawing.Point(11, 53);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(102, 16);
            this.lblPrimerNombre.TabIndex = 5;
            this.lblPrimerNombre.Text = "Primer Nombre:";
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNombre.ForeColor = System.Drawing.Color.White;
            this.lblSegundoNombre.Location = new System.Drawing.Point(196, 53);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(118, 16);
            this.lblSegundoNombre.TabIndex = 6;
            this.lblSegundoNombre.Text = "Segundo Nombre:";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.ForeColor = System.Drawing.Color.White;
            this.lblPrimerApellido.Location = new System.Drawing.Point(381, 53);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(106, 16);
            this.lblPrimerApellido.TabIndex = 7;
            this.lblPrimerApellido.Text = "Primer Apellido: ";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.ForeColor = System.Drawing.Color.White;
            this.lblSegundoApellido.Location = new System.Drawing.Point(567, 53);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(122, 16);
            this.lblSegundoApellido.TabIndex = 8;
            this.lblSegundoApellido.Text = "Segundo Apellido: ";
            this.lblSegundoApellido.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblDUI
            // 
            this.lblDUI.AutoSize = true;
            this.lblDUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDUI.ForeColor = System.Drawing.Color.White;
            this.lblDUI.Location = new System.Drawing.Point(196, 110);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(34, 16);
            this.lblDUI.TabIndex = 10;
            this.lblDUI.Text = "DUI:";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimiento.ForeColor = System.Drawing.Color.White;
            this.lblNacimiento.Location = new System.Drawing.Point(10, 110);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(136, 16);
            this.lblNacimiento.TabIndex = 11;
            this.lblNacimiento.Text = "Fecha de nacimiento:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(384, 130);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(355, 21);
            this.txtDireccion.TabIndex = 7;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(14, 130);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechaNacimiento.MaxDate = new System.DateTime(2060, 12, 31, 0, 0, 0, 0);
            this.dtpFechaNacimiento.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(169, 21);
            this.dtpFechaNacimiento.TabIndex = 5;
            this.dtpFechaNacimiento.Value = new System.DateTime(2020, 7, 19, 0, 0, 0, 0);
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.dtpFechaNacimiento_ValueChanged);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(381, 110);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(68, 16);
            this.lblDireccion.TabIndex = 14;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(262, 165);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(68, 16);
            this.lblTelefono.TabIndex = 16;
            this.lblTelefono.Text = "Telefono: ";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(12, 184);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(240, 21);
            this.txtCorreo.TabIndex = 8;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(10, 163);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(52, 16);
            this.lblCorreo.TabIndex = 19;
            this.lblCorreo.Text = "Correo:";
            // 
            // Panel_NumTelefono_SubMenu
            // 
            this.Panel_NumTelefono_SubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Panel_NumTelefono_SubMenu.Controls.Add(this.txtTelefono3);
            this.Panel_NumTelefono_SubMenu.Controls.Add(this.txtTelefono2);
            this.Panel_NumTelefono_SubMenu.Location = new System.Drawing.Point(265, 205);
            this.Panel_NumTelefono_SubMenu.Name = "Panel_NumTelefono_SubMenu";
            this.Panel_NumTelefono_SubMenu.Size = new System.Drawing.Size(103, 54);
            this.Panel_NumTelefono_SubMenu.TabIndex = 20;
            this.Panel_NumTelefono_SubMenu.Visible = false;
            // 
            // txtTelefono3
            // 
            this.txtTelefono3.Location = new System.Drawing.Point(0, 30);
            this.txtTelefono3.Mask = "0000-0000";
            this.txtTelefono3.Name = "txtTelefono3";
            this.txtTelefono3.Size = new System.Drawing.Size(77, 21);
            this.txtTelefono3.TabIndex = 29;
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.Location = new System.Drawing.Point(0, 3);
            this.txtTelefono2.Mask = "0000-0000";
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.Size = new System.Drawing.Size(77, 21);
            this.txtTelefono2.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(381, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Estado:";
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(199, 129);
            this.txtDui.Mask = "00000000-0";
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(169, 21);
            this.txtDui.TabIndex = 6;
            // 
            // btnAgregaar
            // 
            this.btnAgregaar.Location = new System.Drawing.Point(519, 244);
            this.btnAgregaar.Name = "btnAgregaar";
            this.btnAgregaar.Size = new System.Drawing.Size(99, 41);
            this.btnAgregaar.TabIndex = 26;
            this.btnAgregaar.Text = "Agregar";
            this.btnAgregaar.UseVisualStyleBackColor = true;
            this.btnAgregaar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.Location = new System.Drawing.Point(267, 184);
            this.txtTelefono1.Mask = "0000-0000";
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.Size = new System.Drawing.Size(74, 21);
            this.txtTelefono1.TabIndex = 9;
            // 
            // CmbEstado
            // 
            this.CmbEstado.BackColor = System.Drawing.Color.White;
            this.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Location = new System.Drawing.Point(384, 181);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(355, 24);
            this.CmbEstado.TabIndex = 10;
            this.CmbEstado.SelectedIndexChanged += new System.EventHandler(this.CmbEstado_SelectedIndexChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(640, 244);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(99, 41);
            this.btnActualizar.TabIndex = 32;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnMostrarMas
            // 
            this.BtnMostrarMas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnMostrarMas.Image = global::BusinessControl.Properties.Resources.add_button_inside_black_circle;
            this.BtnMostrarMas.Location = new System.Drawing.Point(347, 183);
            this.BtnMostrarMas.Name = "BtnMostrarMas";
            this.BtnMostrarMas.Size = new System.Drawing.Size(21, 22);
            this.BtnMostrarMas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnMostrarMas.TabIndex = 17;
            this.BtnMostrarMas.TabStop = false;
            this.BtnMostrarMas.Click += new System.EventHandler(this.BtnMostrarMas_Click);
            // 
            // FrmClientePE_hijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(752, 297);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.BtnMostrarMas);
            this.Controls.Add(this.txtTelefono1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregaar);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.Panel_NumTelefono_SubMenu);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.lblDUI);
            this.Controls.Add(this.lblSegundoApellido);
            this.Controls.Add(this.lblPrimerApellido);
            this.Controls.Add(this.lblSegundoNombre);
            this.Controls.Add(this.lblPrimerNombre);
            this.Controls.Add(this.MenuSuperior);
            this.Controls.Add(this.txtSegundoApellido);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.txtSegundoNombre);
            this.Controls.Add(this.txtPrimerNombre);
            this.Controls.Add(this.CmbEstado);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmClientePE_hijo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmClientePE_hijo_Load);
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
        private System.Windows.Forms.Label lblPrimerNombre;
        private System.Windows.Forms.Label lblSegundoNombre;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.Label lblDUI;
        private System.Windows.Forms.Label lblNacimiento;
        public System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.PictureBox BtnMostrarMas;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Panel Panel_NumTelefono_SubMenu;
        private System.Windows.Forms.Button btnAgregaar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnActualizar;
        public System.Windows.Forms.TextBox txtPrimerNombre;
        public System.Windows.Forms.TextBox txtSegundoNombre;
        public System.Windows.Forms.TextBox txtPrimerApellido;
        public System.Windows.Forms.TextBox txtSegundoApellido;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtCorreo;
        public System.Windows.Forms.MaskedTextBox txtDui;
        public System.Windows.Forms.MaskedTextBox txtTelefono3;
        public System.Windows.Forms.MaskedTextBox txtTelefono2;
        public System.Windows.Forms.MaskedTextBox txtTelefono1;
        public System.Windows.Forms.ComboBox CmbEstado;
    }
}
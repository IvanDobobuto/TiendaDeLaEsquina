namespace sistemaCompra
{
    partial class CtrlCliente
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
            pnlDesplegar = new Panel();
            pboxAceptarEditar = new PictureBox();
            pboxCancelar = new PictureBox();
            cboxSiYNo = new ComboBox();
            lblTelefono = new Label();
            cboxTipoIdentificacion = new ComboBox();
            txtDireccion = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtIdentificacion = new TextBox();
            lblDireccion = new Label();
            lblCorreo = new Label();
            lblIdentificacion = new Label();
            lblContribuyenteEspecial = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            pboxBarra6 = new PictureBox();
            pboxBarra5 = new PictureBox();
            pboxBarra4 = new PictureBox();
            pboxBarra3 = new PictureBox();
            pboxBarra2 = new PictureBox();
            pboxBarra = new PictureBox();
            pboxAgregar = new PictureBox();
            pboxCtrlClientes = new PictureBox();
            dtgvListaClientes = new DataGridView();
            lblBuscarIdentificacion = new Label();
            txtBuscarIdentificacion = new TextBox();
            pnlDesplegar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxAceptarEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCancelar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvListaClientes).BeginInit();
            SuspendLayout();
            // 
            // pnlDesplegar
            // 
            pnlDesplegar.Controls.Add(pboxAceptarEditar);
            pnlDesplegar.Controls.Add(pboxCancelar);
            pnlDesplegar.Location = new Point(906, 235);
            pnlDesplegar.Margin = new Padding(3, 2, 3, 2);
            pnlDesplegar.Name = "pnlDesplegar";
            pnlDesplegar.Size = new Size(119, 94);
            pnlDesplegar.TabIndex = 60;
            // 
            // pboxAceptarEditar
            // 
            pboxAceptarEditar.Image = Properties.Resources.BotonAceptar1;
            pboxAceptarEditar.Location = new Point(0, 2);
            pboxAceptarEditar.Margin = new Padding(3, 2, 3, 2);
            pboxAceptarEditar.Name = "pboxAceptarEditar";
            pboxAceptarEditar.Size = new Size(108, 38);
            pboxAceptarEditar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAceptarEditar.TabIndex = 76;
            pboxAceptarEditar.TabStop = false;
            pboxAceptarEditar.Click += pboxAceptarEditar_Click;
            // 
            // pboxCancelar
            // 
            pboxCancelar.Image = Properties.Resources.BotonCancelar1;
            pboxCancelar.Location = new Point(0, 44);
            pboxCancelar.Margin = new Padding(3, 2, 3, 2);
            pboxCancelar.Name = "pboxCancelar";
            pboxCancelar.Size = new Size(108, 40);
            pboxCancelar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCancelar.TabIndex = 63;
            pboxCancelar.TabStop = false;
            pboxCancelar.Click += pboxCancelar_Click;
            // 
            // cboxSiYNo
            // 
            cboxSiYNo.FormattingEnabled = true;
            cboxSiYNo.Items.AddRange(new object[] { "SI", "NO" });
            cboxSiYNo.Location = new Point(898, 87);
            cboxSiYNo.Margin = new Padding(3, 2, 3, 2);
            cboxSiYNo.Name = "cboxSiYNo";
            cboxSiYNo.Size = new Size(100, 23);
            cboxSiYNo.TabIndex = 63;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblTelefono.Location = new Point(470, 65);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 75;
            lblTelefono.Text = "Teléfono";
            // 
            // cboxTipoIdentificacion
            // 
            cboxTipoIdentificacion.FormattingEnabled = true;
            cboxTipoIdentificacion.Items.AddRange(new object[] { "V", "E", "J" });
            cboxTipoIdentificacion.Location = new Point(296, 87);
            cboxTipoIdentificacion.Margin = new Padding(3, 2, 3, 2);
            cboxTipoIdentificacion.Name = "cboxTipoIdentificacion";
            cboxTipoIdentificacion.Size = new Size(42, 23);
            cboxTipoIdentificacion.TabIndex = 63;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(593, 87);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(104, 23);
            txtDireccion.TabIndex = 74;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(734, 87);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(128, 23);
            txtCorreo.TabIndex = 73;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(471, 87);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(88, 23);
            txtTelefono.TabIndex = 72;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(154, 87);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(104, 23);
            txtApellido.TabIndex = 71;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 87);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(104, 23);
            txtNombre.TabIndex = 70;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(335, 87);
            txtIdentificacion.Margin = new Padding(3, 2, 3, 2);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(98, 23);
            txtIdentificacion.TabIndex = 58;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblDireccion.Location = new Point(593, 65);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(59, 15);
            lblDireccion.TabIndex = 69;
            lblDireccion.Text = "Dirección";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblCorreo.Location = new Point(734, 65);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(107, 15);
            lblCorreo.TabIndex = 68;
            lblCorreo.Text = "Correo electrónico";
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblIdentificacion.Location = new Point(322, 65);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(79, 15);
            lblIdentificacion.TabIndex = 67;
            lblIdentificacion.Text = "Identificación";
            // 
            // lblContribuyenteEspecial
            // 
            lblContribuyenteEspecial.AutoSize = true;
            lblContribuyenteEspecial.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblContribuyenteEspecial.Location = new Point(889, 65);
            lblContribuyenteEspecial.Name = "lblContribuyenteEspecial";
            lblContribuyenteEspecial.Size = new Size(109, 15);
            lblContribuyenteEspecial.TabIndex = 66;
            lblContribuyenteEspecial.Text = "Contribuyente Esp.";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblApellido.Location = new Point(154, 65);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 65;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblNombre.Location = new Point(12, 65);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(52, 15);
            lblNombre.TabIndex = 64;
            lblNombre.Text = "Nombre";
            // 
            // pboxBarra6
            // 
            pboxBarra6.Image = Properties.Resources.ControlDato2;
            pboxBarra6.Location = new Point(593, 106);
            pboxBarra6.Margin = new Padding(3, 2, 3, 2);
            pboxBarra6.Name = "pboxBarra6";
            pboxBarra6.Size = new Size(104, 20);
            pboxBarra6.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra6.TabIndex = 61;
            pboxBarra6.TabStop = false;
            // 
            // pboxBarra5
            // 
            pboxBarra5.Image = Properties.Resources.ControlDato2;
            pboxBarra5.Location = new Point(734, 106);
            pboxBarra5.Margin = new Padding(3, 2, 3, 2);
            pboxBarra5.Name = "pboxBarra5";
            pboxBarra5.Size = new Size(128, 22);
            pboxBarra5.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra5.TabIndex = 60;
            pboxBarra5.TabStop = false;
            // 
            // pboxBarra4
            // 
            pboxBarra4.Image = Properties.Resources.ControlDato2;
            pboxBarra4.Location = new Point(471, 106);
            pboxBarra4.Margin = new Padding(3, 2, 3, 2);
            pboxBarra4.Name = "pboxBarra4";
            pboxBarra4.Size = new Size(88, 20);
            pboxBarra4.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra4.TabIndex = 59;
            pboxBarra4.TabStop = false;
            // 
            // pboxBarra3
            // 
            pboxBarra3.Image = Properties.Resources.ControlDato2;
            pboxBarra3.Location = new Point(154, 106);
            pboxBarra3.Margin = new Padding(3, 2, 3, 2);
            pboxBarra3.Name = "pboxBarra3";
            pboxBarra3.Size = new Size(104, 20);
            pboxBarra3.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra3.TabIndex = 58;
            pboxBarra3.TabStop = false;
            // 
            // pboxBarra2
            // 
            pboxBarra2.Image = Properties.Resources.ControlDato2;
            pboxBarra2.Location = new Point(12, 106);
            pboxBarra2.Margin = new Padding(3, 2, 3, 2);
            pboxBarra2.Name = "pboxBarra2";
            pboxBarra2.Size = new Size(104, 23);
            pboxBarra2.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra2.TabIndex = 57;
            pboxBarra2.TabStop = false;
            // 
            // pboxBarra
            // 
            pboxBarra.Image = Properties.Resources.ControlDato2;
            pboxBarra.Location = new Point(335, 103);
            pboxBarra.Margin = new Padding(3, 2, 3, 2);
            pboxBarra.Name = "pboxBarra";
            pboxBarra.Size = new Size(98, 23);
            pboxBarra.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra.TabIndex = 56;
            pboxBarra.TabStop = false;
            // 
            // pboxAgregar
            // 
            pboxAgregar.Image = Properties.Resources.ControlAñadir;
            pboxAgregar.Location = new Point(926, 174);
            pboxAgregar.Margin = new Padding(3, 2, 3, 2);
            pboxAgregar.Name = "pboxAgregar";
            pboxAgregar.Size = new Size(50, 46);
            pboxAgregar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAgregar.TabIndex = 59;
            pboxAgregar.TabStop = false;
            pboxAgregar.Click += pboxAgregar_Click;
            // 
            // pboxCtrlClientes
            // 
            pboxCtrlClientes.Image = Properties.Resources.ControlClientes;
            pboxCtrlClientes.Location = new Point(364, 20);
            pboxCtrlClientes.Margin = new Padding(3, 2, 3, 2);
            pboxCtrlClientes.Name = "pboxCtrlClientes";
            pboxCtrlClientes.Size = new Size(288, 32);
            pboxCtrlClientes.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCtrlClientes.TabIndex = 58;
            pboxCtrlClientes.TabStop = false;
            // 
            // dtgvListaClientes
            // 
            dtgvListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvListaClientes.Location = new Point(12, 207);
            dtgvListaClientes.Margin = new Padding(3, 2, 3, 2);
            dtgvListaClientes.Name = "dtgvListaClientes";
            dtgvListaClientes.RowTemplate.Height = 25;
            dtgvListaClientes.Size = new Size(884, 246);
            dtgvListaClientes.TabIndex = 64;
            dtgvListaClientes.CellContentClick += dtgvListaClientes_CellClick;
            // 
            // lblBuscarIdentificacion
            // 
            lblBuscarIdentificacion.AutoSize = true;
            lblBuscarIdentificacion.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblBuscarIdentificacion.Location = new Point(22, 156);
            lblBuscarIdentificacion.Name = "lblBuscarIdentificacion";
            lblBuscarIdentificacion.Size = new Size(123, 15);
            lblBuscarIdentificacion.TabIndex = 87;
            lblBuscarIdentificacion.Text = "Buscar Identificación:";
            // 
            // txtBuscarIdentificacion
            // 
            txtBuscarIdentificacion.Location = new Point(22, 174);
            txtBuscarIdentificacion.Name = "txtBuscarIdentificacion";
            txtBuscarIdentificacion.Size = new Size(124, 23);
            txtBuscarIdentificacion.TabIndex = 85;
            // 
            // CtrlCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 476);
            Controls.Add(lblBuscarIdentificacion);
            Controls.Add(txtBuscarIdentificacion);
            Controls.Add(dtgvListaClientes);
            Controls.Add(txtCorreo);
            Controls.Add(cboxSiYNo);
            Controls.Add(lblCorreo);
            Controls.Add(txtDireccion);
            Controls.Add(lblTelefono);
            Controls.Add(lblContribuyenteEspecial);
            Controls.Add(lblDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(pboxBarra6);
            Controls.Add(cboxTipoIdentificacion);
            Controls.Add(pnlDesplegar);
            Controls.Add(pboxAgregar);
            Controls.Add(txtIdentificacion);
            Controls.Add(pboxCtrlClientes);
            Controls.Add(lblNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblIdentificacion);
            Controls.Add(lblApellido);
            Controls.Add(pboxBarra3);
            Controls.Add(pboxBarra2);
            Controls.Add(pboxBarra);
            Controls.Add(pboxBarra4);
            Controls.Add(pboxBarra5);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CtrlCliente";
            Text = "CtrlCliente";
            Load += CtrlCliente_Load;
            pnlDesplegar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pboxAceptarEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCancelar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvListaClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlDesplegar;
        private TextBox txtDireccion;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtIdentificacion;
        private Label lblDireccion;
        private Label lblCorreo;
        private Label lblIdentificacion;
        private Label lblContribuyenteEspecial;
        private Label lblApellido;
        private Label lblNombre;
        private PictureBox pboxCancelar;
        private PictureBox pboxBarra6;
        private PictureBox pboxBarra5;
        private PictureBox pboxBarra4;
        private PictureBox pboxBarra3;
        private PictureBox pboxBarra2;
        private PictureBox pboxBarra;
        private PictureBox pboxAgregar;
        private PictureBox pboxCtrlClientes;
        private ComboBox cboxTipoIdentificacion;
        private Label lblTelefono;
        private ComboBox cboxSiYNo;
        private PictureBox pboxAceptarEditar;
        private DataGridView dtgvListaClientes;
        private Label lblBuscarIdentificacion;
        private TextBox txtBuscarIdentificacion;
    }
}
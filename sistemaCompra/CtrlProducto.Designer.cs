namespace sistemaCompra
{
    partial class CtrlProducto
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
            pboxCtrlProductos = new PictureBox();
            pboxAgregar = new PictureBox();
            pboxDatos = new PictureBox();
            pnlDesplegar = new Panel();
            lblCantidadMinima = new Label();
            pictureBox2 = new PictureBox();
            txtCantidadMinima = new TextBox();
            pictureBox1 = new PictureBox();
            pboxAceptarEditar = new PictureBox();
            cboxSiYNo = new ComboBox();
            cboxUdMedidas = new ComboBox();
            txtPrecio = new TextBox();
            txtCosto = new TextBox();
            txtCantidad = new TextBox();
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            lblPrecio = new Label();
            lblCosto = new Label();
            lblUnidad = new Label();
            lblIVA = new Label();
            lblCantidad = new Label();
            lblNombre = new Label();
            lblCodigo = new Label();
            pboxCancelar = new PictureBox();
            pboxAceptarAgregar = new PictureBox();
            pboxBarra6 = new PictureBox();
            pboxBarra3 = new PictureBox();
            pboxBarra2 = new PictureBox();
            pboxBarra = new PictureBox();
            pboxEditar = new PictureBox();
            pboxEliminar = new PictureBox();
            pboxLista = new PictureBox();
            dtgvListaProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxDatos).BeginInit();
            pnlDesplegar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAceptarEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCancelar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAceptarAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxLista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvListaProductos).BeginInit();
            SuspendLayout();
            // 
            // pboxCtrlProductos
            // 
            pboxCtrlProductos.Image = Properties.Resources.ControlProductos;
            pboxCtrlProductos.Location = new Point(259, 12);
            pboxCtrlProductos.Name = "pboxCtrlProductos";
            pboxCtrlProductos.Size = new Size(306, 41);
            pboxCtrlProductos.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCtrlProductos.TabIndex = 51;
            pboxCtrlProductos.TabStop = false;
            // 
            // pboxAgregar
            // 
            pboxAgregar.Image = Properties.Resources.ControlAñadir;
            pboxAgregar.Location = new Point(401, 103);
            pboxAgregar.Name = "pboxAgregar";
            pboxAgregar.Size = new Size(50, 46);
            pboxAgregar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAgregar.TabIndex = 52;
            pboxAgregar.TabStop = false;
            pboxAgregar.Click += pboxAgregar_Click;
            // 
            // pboxDatos
            // 
            pboxDatos.Image = Properties.Resources.ControlDesplegar;
            pboxDatos.Location = new Point(6, 4);
            pboxDatos.Margin = new Padding(3, 2, 3, 2);
            pboxDatos.Name = "pboxDatos";
            pboxDatos.Size = new Size(374, 259);
            pboxDatos.SizeMode = PictureBoxSizeMode.Zoom;
            pboxDatos.TabIndex = 54;
            pboxDatos.TabStop = false;
            // 
            // pnlDesplegar
            // 
            pnlDesplegar.Controls.Add(lblCantidadMinima);
            pnlDesplegar.Controls.Add(pictureBox2);
            pnlDesplegar.Controls.Add(txtCantidadMinima);
            pnlDesplegar.Controls.Add(pictureBox1);
            pnlDesplegar.Controls.Add(pboxAceptarEditar);
            pnlDesplegar.Controls.Add(cboxSiYNo);
            pnlDesplegar.Controls.Add(cboxUdMedidas);
            pnlDesplegar.Controls.Add(txtPrecio);
            pnlDesplegar.Controls.Add(txtCosto);
            pnlDesplegar.Controls.Add(txtCantidad);
            pnlDesplegar.Controls.Add(txtNombre);
            pnlDesplegar.Controls.Add(txtCodigo);
            pnlDesplegar.Controls.Add(lblPrecio);
            pnlDesplegar.Controls.Add(lblCosto);
            pnlDesplegar.Controls.Add(lblUnidad);
            pnlDesplegar.Controls.Add(lblIVA);
            pnlDesplegar.Controls.Add(lblCantidad);
            pnlDesplegar.Controls.Add(lblNombre);
            pnlDesplegar.Controls.Add(lblCodigo);
            pnlDesplegar.Controls.Add(pboxCancelar);
            pnlDesplegar.Controls.Add(pboxAceptarAgregar);
            pnlDesplegar.Controls.Add(pboxBarra6);
            pnlDesplegar.Controls.Add(pboxBarra3);
            pnlDesplegar.Controls.Add(pboxBarra2);
            pnlDesplegar.Controls.Add(pboxBarra);
            pnlDesplegar.Controls.Add(pboxDatos);
            pnlDesplegar.Location = new Point(390, 165);
            pnlDesplegar.Name = "pnlDesplegar";
            pnlDesplegar.Size = new Size(383, 265);
            pnlDesplegar.TabIndex = 55;
            // 
            // lblCantidadMinima
            // 
            lblCantidadMinima.AutoSize = true;
            lblCantidadMinima.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblCantidadMinima.Location = new Point(250, 88);
            lblCantidadMinima.Name = "lblCantidadMinima";
            lblCantidadMinima.Size = new Size(112, 13);
            lblCantidadMinima.TabIndex = 79;
            lblCantidadMinima.Text = "Cantidad Mínima";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ControlDato2;
            pictureBox2.Location = new Point(253, 126);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(97, 11);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 78;
            pictureBox2.TabStop = false;
            // 
            // txtCantidadMinima
            // 
            txtCantidadMinima.Location = new Point(253, 104);
            txtCantidadMinima.Name = "txtCantidadMinima";
            txtCantidadMinima.Size = new Size(97, 23);
            txtCantidadMinima.TabIndex = 77;
            txtCantidadMinima.TextChanged += txtCantidadMinima_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ControlDato2;
            pictureBox1.Location = new Point(132, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 13);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 76;
            pictureBox1.TabStop = false;
            // 
            // pboxAceptarEditar
            // 
            pboxAceptarEditar.Image = Properties.Resources.BotonAceptar1;
            pboxAceptarEditar.Location = new Point(198, 216);
            pboxAceptarEditar.Margin = new Padding(3, 2, 3, 2);
            pboxAceptarEditar.Name = "pboxAceptarEditar";
            pboxAceptarEditar.Size = new Size(79, 23);
            pboxAceptarEditar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAceptarEditar.TabIndex = 75;
            pboxAceptarEditar.TabStop = false;
            pboxAceptarEditar.Click += pboxAceptarEditar_Click;
            // 
            // cboxSiYNo
            // 
            cboxSiYNo.FormattingEnabled = true;
            cboxSiYNo.Items.AddRange(new object[] { "SI", "NO" });
            cboxSiYNo.Location = new Point(61, 180);
            cboxSiYNo.Name = "cboxSiYNo";
            cboxSiYNo.Size = new Size(56, 23);
            cboxSiYNo.TabIndex = 64;
            cboxSiYNo.SelectedIndexChanged += cboxSiYNo_SelectedIndexChanged;
            // 
            // cboxUdMedidas
            // 
            cboxUdMedidas.FormattingEnabled = true;
            cboxUdMedidas.Items.AddRange(new object[] { "Kilogramo (Kg)", "Litro (L)", "Unidad (Ud.)" });
            cboxUdMedidas.Location = new Point(27, 104);
            cboxUdMedidas.Name = "cboxUdMedidas";
            cboxUdMedidas.Size = new Size(90, 23);
            cboxUdMedidas.TabIndex = 58;
            cboxUdMedidas.SelectedIndexChanged += cboxUdMedidas_SelectedIndexChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(132, 172);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 74;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(132, 104);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(100, 23);
            txtCosto.TabIndex = 73;
            txtCosto.TextChanged += txtCosto_TextChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(250, 41);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 71;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(132, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 70;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(27, 41);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(90, 23);
            txtCodigo.TabIndex = 58;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblPrecio.Location = new Point(127, 156);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(112, 13);
            lblPrecio.TabIndex = 69;
            lblPrecio.Text = "Precio de Venta";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblCosto.Location = new Point(127, 88);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(105, 13);
            lblCosto.TabIndex = 68;
            lblCosto.Text = "Costo Unitario";
            // 
            // lblUnidad
            // 
            lblUnidad.AutoSize = true;
            lblUnidad.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblUnidad.Location = new Point(27, 88);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(77, 13);
            lblUnidad.TabIndex = 67;
            lblUnidad.Text = "Ud. Medida";
            // 
            // lblIVA
            // 
            lblIVA.AutoSize = true;
            lblIVA.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblIVA.Location = new Point(27, 184);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(28, 13);
            lblIVA.TabIndex = 66;
            lblIVA.Text = "IVA";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblCantidad.Location = new Point(265, 22);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(63, 13);
            lblCantidad.TabIndex = 65;
            lblCantidad.Text = "Cantidad";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblNombre.Location = new Point(160, 22);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(49, 13);
            lblNombre.TabIndex = 64;
            lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblCodigo.Location = new Point(50, 22);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 13);
            lblCodigo.TabIndex = 56;
            lblCodigo.Text = "Código";
            // 
            // pboxCancelar
            // 
            pboxCancelar.Image = Properties.Resources.BotonCancelar1;
            pboxCancelar.Location = new Point(283, 216);
            pboxCancelar.Margin = new Padding(3, 2, 3, 2);
            pboxCancelar.Name = "pboxCancelar";
            pboxCancelar.Size = new Size(79, 23);
            pboxCancelar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCancelar.TabIndex = 63;
            pboxCancelar.TabStop = false;
            pboxCancelar.Click += pboxCancelar_Click;
            // 
            // pboxAceptarAgregar
            // 
            pboxAceptarAgregar.Image = Properties.Resources.BotonAceptar1;
            pboxAceptarAgregar.Location = new Point(198, 216);
            pboxAceptarAgregar.Margin = new Padding(3, 2, 3, 2);
            pboxAceptarAgregar.Name = "pboxAceptarAgregar";
            pboxAceptarAgregar.Size = new Size(79, 23);
            pboxAceptarAgregar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAceptarAgregar.TabIndex = 56;
            pboxAceptarAgregar.TabStop = false;
            pboxAceptarAgregar.Click += pboxAceptarAgregar_Click;
            // 
            // pboxBarra6
            // 
            pboxBarra6.Image = Properties.Resources.ControlDato2;
            pboxBarra6.Location = new Point(132, 192);
            pboxBarra6.Name = "pboxBarra6";
            pboxBarra6.Size = new Size(100, 11);
            pboxBarra6.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra6.TabIndex = 61;
            pboxBarra6.TabStop = false;
            // 
            // pboxBarra3
            // 
            pboxBarra3.Image = Properties.Resources.ControlDato2;
            pboxBarra3.Location = new Point(250, 64);
            pboxBarra3.Name = "pboxBarra3";
            pboxBarra3.Size = new Size(100, 10);
            pboxBarra3.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra3.TabIndex = 58;
            pboxBarra3.TabStop = false;
            // 
            // pboxBarra2
            // 
            pboxBarra2.Image = Properties.Resources.ControlDato2;
            pboxBarra2.Location = new Point(132, 61);
            pboxBarra2.Name = "pboxBarra2";
            pboxBarra2.Size = new Size(100, 13);
            pboxBarra2.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra2.TabIndex = 57;
            pboxBarra2.TabStop = false;
            // 
            // pboxBarra
            // 
            pboxBarra.Image = Properties.Resources.ControlDato2;
            pboxBarra.Location = new Point(27, 59);
            pboxBarra.Name = "pboxBarra";
            pboxBarra.Size = new Size(90, 15);
            pboxBarra.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra.TabIndex = 56;
            pboxBarra.TabStop = false;
            // 
            // pboxEditar
            // 
            pboxEditar.Image = Properties.Resources.VentasEditar;
            pboxEditar.Location = new Point(483, 102);
            pboxEditar.Margin = new Padding(3, 2, 3, 2);
            pboxEditar.Name = "pboxEditar";
            pboxEditar.Size = new Size(49, 46);
            pboxEditar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxEditar.TabIndex = 56;
            pboxEditar.TabStop = false;
            pboxEditar.Click += pboxEditar_Click;
            // 
            // pboxEliminar
            // 
            pboxEliminar.Image = Properties.Resources.ControlEliminar;
            pboxEliminar.Location = new Point(561, 102);
            pboxEliminar.Margin = new Padding(3, 2, 3, 2);
            pboxEliminar.Name = "pboxEliminar";
            pboxEliminar.Size = new Size(49, 46);
            pboxEliminar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxEliminar.TabIndex = 57;
            pboxEliminar.TabStop = false;
            pboxEliminar.Click += pboxEliminar_Click;
            // 
            // pboxLista
            // 
            pboxLista.Image = Properties.Resources.ControlTabla121;
            pboxLista.Location = new Point(12, 72);
            pboxLista.Name = "pboxLista";
            pboxLista.Size = new Size(356, 447);
            pboxLista.SizeMode = PictureBoxSizeMode.Zoom;
            pboxLista.TabIndex = 58;
            pboxLista.TabStop = false;
            // 
            // dtgvListaProductos
            // 
            dtgvListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvListaProductos.Location = new Point(23, 181);
            dtgvListaProductos.Name = "dtgvListaProductos";
            dtgvListaProductos.RowTemplate.Height = 25;
            dtgvListaProductos.Size = new Size(329, 315);
            dtgvListaProductos.TabIndex = 65;
            dtgvListaProductos.CellContentClick += dtgvListaProductos_CellContentClick;
            // 
            // CtrlProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 549);
            Controls.Add(dtgvListaProductos);
            Controls.Add(pboxEliminar);
            Controls.Add(pboxEditar);
            Controls.Add(pnlDesplegar);
            Controls.Add(pboxAgregar);
            Controls.Add(pboxCtrlProductos);
            Controls.Add(pboxLista);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CtrlProducto";
            Text = "CtrlProducto";
            Load += CtrlProducto_Load;
            ((System.ComponentModel.ISupportInitialize)pboxCtrlProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxDatos).EndInit();
            pnlDesplegar.ResumeLayout(false);
            pnlDesplegar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAceptarEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCancelar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAceptarAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxLista).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvListaProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pboxCtrlProductos;
        private PictureBox pboxAgregar;
        private PictureBox pboxDatos;
        private Panel pnlDesplegar;
        private PictureBox pboxBarra;
        private PictureBox pboxBarra2;
        private PictureBox pboxBarra3;
        private PictureBox pboxBarra6;
        private PictureBox pboxAceptarAgregar;
        private PictureBox pboxCancelar;
        private Label lblCodigo;
        private Label lblNombre;
        private Label lblCantidad;
        private Label lblUnidad;
        private Label lblIVA;
        private Label lblCosto;
        private Label lblPrecio;
        private PictureBox pboxEditar;
        private PictureBox pboxEliminar;
        private TextBox txtNombre;
        private TextBox txtCodigo;
        private TextBox txtPrecio;
        private TextBox txtCosto;
        private TextBox txtCantidad;
        private ComboBox cboxUdMedidas;
        private ComboBox cboxSiYNo;
        private PictureBox pboxAceptarEditar;
        private PictureBox pboxLista;
        private DataGridView dtgvListaProductos;
        private Label lblCantidadMinima;
        private PictureBox pictureBox2;
        private TextBox txtCantidadMinima;
        private PictureBox pictureBox1;
    }
}
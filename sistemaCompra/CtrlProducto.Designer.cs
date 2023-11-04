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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pboxCtrlProductos = new PictureBox();
            pboxAgregar = new PictureBox();
            pnlDesplegar = new Panel();
            pboxAceptarEditar = new PictureBox();
            pboxCancelar = new PictureBox();
            lblCantidadMinima = new Label();
            pictureBox2 = new PictureBox();
            txtCantidadMinima = new TextBox();
            pictureBox1 = new PictureBox();
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
            pboxBarra6 = new PictureBox();
            pboxBarra3 = new PictureBox();
            pboxBarra2 = new PictureBox();
            pboxBarra = new PictureBox();
            dtgvListaProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregar).BeginInit();
            pnlDesplegar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxAceptarEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCancelar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvListaProductos).BeginInit();
            SuspendLayout();
            // 
            // pboxCtrlProductos
            // 
            pboxCtrlProductos.Image = Properties.Resources.ControlProductos;
            pboxCtrlProductos.Location = new Point(393, 12);
            pboxCtrlProductos.Name = "pboxCtrlProductos";
            pboxCtrlProductos.Size = new Size(306, 41);
            pboxCtrlProductos.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCtrlProductos.TabIndex = 51;
            pboxCtrlProductos.TabStop = false;
            // 
            // pboxAgregar
            // 
            pboxAgregar.Image = Properties.Resources.ControlAñadir;
            pboxAgregar.Location = new Point(977, 73);
            pboxAgregar.Name = "pboxAgregar";
            pboxAgregar.Size = new Size(50, 46);
            pboxAgregar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAgregar.TabIndex = 52;
            pboxAgregar.TabStop = false;
            pboxAgregar.Click += pboxAgregar_Click;
            // 
            // pnlDesplegar
            // 
            pnlDesplegar.Controls.Add(pboxAceptarEditar);
            pnlDesplegar.Controls.Add(pboxCancelar);
            pnlDesplegar.Location = new Point(941, 169);
            pnlDesplegar.Name = "pnlDesplegar";
            pnlDesplegar.Size = new Size(115, 92);
            pnlDesplegar.TabIndex = 55;
            // 
            // pboxAceptarEditar
            // 
            pboxAceptarEditar.Image = Properties.Resources.BotonAceptar1;
            pboxAceptarEditar.Location = new Point(0, 2);
            pboxAceptarEditar.Margin = new Padding(3, 2, 3, 2);
            pboxAceptarEditar.Name = "pboxAceptarEditar";
            pboxAceptarEditar.Size = new Size(109, 37);
            pboxAceptarEditar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAceptarEditar.TabIndex = 75;
            pboxAceptarEditar.TabStop = false;
            pboxAceptarEditar.Click += pboxAceptarEditar_Click;
            // 
            // pboxCancelar
            // 
            pboxCancelar.Image = Properties.Resources.BotonCancelar1;
            pboxCancelar.Location = new Point(0, 43);
            pboxCancelar.Margin = new Padding(3, 2, 3, 2);
            pboxCancelar.Name = "pboxCancelar";
            pboxCancelar.Size = new Size(109, 37);
            pboxCancelar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCancelar.TabIndex = 63;
            pboxCancelar.TabStop = false;
            pboxCancelar.Click += pboxCancelar_Click;
            // 
            // lblCantidadMinima
            // 
            lblCantidadMinima.AutoSize = true;
            lblCantidadMinima.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblCantidadMinima.Location = new Point(393, 73);
            lblCantidadMinima.Name = "lblCantidadMinima";
            lblCantidadMinima.Size = new Size(101, 15);
            lblCantidadMinima.TabIndex = 79;
            lblCantidadMinima.Text = "Cantidad Mínima";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ControlDato2;
            pictureBox2.Location = new Point(393, 107);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(97, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 78;
            pictureBox2.TabStop = false;
            // 
            // txtCantidadMinima
            // 
            txtCantidadMinima.Location = new Point(393, 92);
            txtCantidadMinima.Name = "txtCantidadMinima";
            txtCantidadMinima.Size = new Size(97, 23);
            txtCantidadMinima.TabIndex = 77;
            txtCantidadMinima.TextChanged += txtCantidadMinima_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ControlDato2;
            pictureBox1.Location = new Point(637, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 76;
            pictureBox1.TabStop = false;
            // 
            // cboxSiYNo
            // 
            cboxSiYNo.FormattingEnabled = true;
            cboxSiYNo.Items.AddRange(new object[] { "SI", "NO" });
            cboxSiYNo.Location = new Point(892, 92);
            cboxSiYNo.Name = "cboxSiYNo";
            cboxSiYNo.Size = new Size(56, 23);
            cboxSiYNo.TabIndex = 64;
            cboxSiYNo.SelectedIndexChanged += cboxSiYNo_SelectedIndexChanged;
            // 
            // cboxUdMedidas
            // 
            cboxUdMedidas.FormattingEnabled = true;
            cboxUdMedidas.Items.AddRange(new object[] { "Kilogramo (Kg)", "Litro (L)", "Unidad (Ud.)" });
            cboxUdMedidas.Location = new Point(520, 92);
            cboxUdMedidas.Name = "cboxUdMedidas";
            cboxUdMedidas.Size = new Size(90, 23);
            cboxUdMedidas.TabIndex = 58;
            cboxUdMedidas.SelectedIndexChanged += cboxUdMedidas_SelectedIndexChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(765, 92);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(103, 23);
            txtPrecio.TabIndex = 74;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(637, 92);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(100, 23);
            txtCosto.TabIndex = 73;
            txtCosto.TextChanged += txtCosto_TextChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(267, 92);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 71;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(142, 92);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 70;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(26, 92);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(90, 23);
            txtCodigo.TabIndex = 58;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblPrecio.Location = new Point(765, 73);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(93, 15);
            lblPrecio.TabIndex = 69;
            lblPrecio.Text = "Precio de Venta";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblCosto.Location = new Point(632, 73);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(84, 15);
            lblCosto.TabIndex = 68;
            lblCosto.Text = "Costo Unitario";
            // 
            // lblUnidad
            // 
            lblUnidad.AutoSize = true;
            lblUnidad.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblUnidad.Location = new Point(520, 73);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(71, 15);
            lblUnidad.TabIndex = 67;
            lblUnidad.Text = "Ud. Medida";
            // 
            // lblIVA
            // 
            lblIVA.AutoSize = true;
            lblIVA.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblIVA.Location = new Point(892, 73);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(24, 15);
            lblIVA.TabIndex = 66;
            lblIVA.Text = "IVA";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblCantidad.Location = new Point(269, 73);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(56, 15);
            lblCantidad.TabIndex = 65;
            lblCantidad.Text = "Cantidad";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblNombre.Location = new Point(142, 73);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(52, 15);
            lblNombre.TabIndex = 64;
            lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblCodigo.Location = new Point(26, 73);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 56;
            lblCodigo.Text = "Código";
            // 
            // pboxBarra6
            // 
            pboxBarra6.Image = Properties.Resources.ControlDato2;
            pboxBarra6.Location = new Point(765, 107);
            pboxBarra6.Name = "pboxBarra6";
            pboxBarra6.Size = new Size(103, 24);
            pboxBarra6.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra6.TabIndex = 61;
            pboxBarra6.TabStop = false;
            // 
            // pboxBarra3
            // 
            pboxBarra3.Image = Properties.Resources.ControlDato2;
            pboxBarra3.Location = new Point(267, 107);
            pboxBarra3.Name = "pboxBarra3";
            pboxBarra3.Size = new Size(100, 24);
            pboxBarra3.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra3.TabIndex = 58;
            pboxBarra3.TabStop = false;
            // 
            // pboxBarra2
            // 
            pboxBarra2.Image = Properties.Resources.ControlDato2;
            pboxBarra2.Location = new Point(142, 107);
            pboxBarra2.Name = "pboxBarra2";
            pboxBarra2.Size = new Size(100, 24);
            pboxBarra2.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra2.TabIndex = 57;
            pboxBarra2.TabStop = false;
            // 
            // pboxBarra
            // 
            pboxBarra.Image = Properties.Resources.ControlDato2;
            pboxBarra.Location = new Point(26, 107);
            pboxBarra.Name = "pboxBarra";
            pboxBarra.Size = new Size(90, 24);
            pboxBarra.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra.TabIndex = 56;
            pboxBarra.TabStop = false;
            // 
            // dtgvListaProductos
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvListaProductos.Location = new Point(41, 169);
            dtgvListaProductos.Name = "dtgvListaProductos";
            dtgvListaProductos.RowTemplate.Height = 25;
            dtgvListaProductos.Size = new Size(894, 256);
            dtgvListaProductos.TabIndex = 65;
            dtgvListaProductos.CellContentClick += dtgvListaProductos_CellClick;
            // 
            // CtrlProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 476);
            Controls.Add(txtPrecio);
            Controls.Add(cboxSiYNo);
            Controls.Add(lblPrecio);
            Controls.Add(lblCantidadMinima);
            Controls.Add(lblIVA);
            Controls.Add(txtCantidadMinima);
            Controls.Add(dtgvListaProductos);
            Controls.Add(pnlDesplegar);
            Controls.Add(cboxUdMedidas);
            Controls.Add(txtCosto);
            Controls.Add(pboxAgregar);
            Controls.Add(pboxCtrlProductos);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            Controls.Add(txtCantidad);
            Controls.Add(lblCosto);
            Controls.Add(lblNombre);
            Controls.Add(lblUnidad);
            Controls.Add(txtNombre);
            Controls.Add(lblCantidad);
            Controls.Add(pboxBarra);
            Controls.Add(pboxBarra2);
            Controls.Add(pboxBarra3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pboxBarra6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CtrlProducto";
            Text = "CtrlProducto";
            Load += CtrlProducto_Load;
            ((System.ComponentModel.ISupportInitialize)pboxCtrlProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregar).EndInit();
            pnlDesplegar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pboxAceptarEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCancelar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvListaProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pboxCtrlProductos;
        private PictureBox pboxAgregar;
        private Panel pnlDesplegar;
        private PictureBox pboxBarra;
        private PictureBox pboxBarra2;
        private PictureBox pboxBarra3;
        private PictureBox pboxBarra6;
        private PictureBox pboxCancelar;
        private Label lblCodigo;
        private Label lblNombre;
        private Label lblCantidad;
        private Label lblUnidad;
        private Label lblIVA;
        private Label lblCosto;
        private Label lblPrecio;
        private TextBox txtNombre;
        private TextBox txtCodigo;
        private TextBox txtPrecio;
        private TextBox txtCosto;
        private TextBox txtCantidad;
        private ComboBox cboxUdMedidas;
        private ComboBox cboxSiYNo;
        private PictureBox pboxAceptarEditar;
        private DataGridView dtgvListaProductos;
        private Label lblCantidadMinima;
        private PictureBox pictureBox2;
        private TextBox txtCantidadMinima;
        private PictureBox pictureBox1;
    }
}
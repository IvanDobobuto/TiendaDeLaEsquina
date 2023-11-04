namespace sistemaCompra
{
    partial class Ventas
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            label5 = new Label();
            ImprimirFactura = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            subtotal = new Label();
            label3 = new Label();
            LabelDolares = new Label();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox9 = new PictureBox();
            factura = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
            Column4 = new DataGridViewButtonColumn();
            textBoxCliente = new TextBox();
            textBox2 = new TextBox();
            nombreTB = new TextBox();
            direccionTB = new TextBox();
            telefonoTB = new TextBox();
            apellidoTB = new TextBox();
            emailTB = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            tipoDeDocumentoCB = new ComboBox();
            Si = new RadioButton();
            No = new RadioButton();
            label12 = new Label();
            pictureBox8 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            cantidadTB = new TextBox();
            Cantidad = new Label();
            label4 = new Label();
            can = new Label();
            Dolar = new TextBox();
            label2 = new Label();
            pboxAgregarCliente = new PictureBox();
            btnVerProductos = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ImprimirFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)factura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregarCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(43, 53);
            label5.Name = "label5";
            label5.Size = new Size(201, 15);
            label5.TabIndex = 8;
            label5.Text = "Documento de identidad del cliente";
            // 
            // ImprimirFactura
            // 
            ImprimirFactura.BackgroundImageLayout = ImageLayout.Center;
            ImprimirFactura.Image = Properties.Resources.InterfazVentas2;
            ImprimirFactura.Location = new Point(562, 558);
            ImprimirFactura.Margin = new Padding(3, 4, 3, 4);
            ImprimirFactura.Name = "ImprimirFactura";
            ImprimirFactura.Size = new Size(271, 80);
            ImprimirFactura.SizeMode = PictureBoxSizeMode.StretchImage;
            ImprimirFactura.TabIndex = 23;
            ImprimirFactura.TabStop = false;
            ImprimirFactura.Click += ImprimirFactura_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.BotonRetroceder;
            pictureBox2.Location = new Point(12, 571);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ControlDato1;
            pictureBox3.Location = new Point(40, 85);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(266, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(314, 403);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 27;
            label1.Text = "Producto";
            // 
            // subtotal
            // 
            subtotal.AutoSize = true;
            subtotal.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            subtotal.Location = new Point(823, 403);
            subtotal.Name = "subtotal";
            subtotal.Size = new Size(58, 15);
            subtotal.TabIndex = 29;
            subtotal.Text = " Subtotal:";
            subtotal.Click += subtotal_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(823, 429);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 30;
            label3.Text = " IVA: ";
            label3.Click += label3_Click;
            // 
            // LabelDolares
            // 
            LabelDolares.AutoSize = true;
            LabelDolares.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            LabelDolares.Location = new Point(823, 487);
            LabelDolares.Name = "LabelDolares";
            LabelDolares.Size = new Size(108, 15);
            LabelDolares.TabIndex = 31;
            LabelDolares.Text = "Precio en Dolares:";
            LabelDolares.Click += LabelDolares_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.InterfazVentas1;
            pictureBox6.Location = new Point(593, 13);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(157, 56);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 32;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.IconoLupa;
            pictureBox7.Location = new Point(328, 71);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(33, 35);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 33;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.ControlAñadir;
            pictureBox9.Location = new Point(736, 416);
            pictureBox9.Margin = new Padding(3, 2, 3, 2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(33, 28);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 35;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // factura
            // 
            factura.BackgroundColor = Color.FromArgb(11, 87, 96);
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            factura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            factura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            factura.Columns.AddRange(new DataGridViewColumn[] { Codigo, Column1, Quantity, Column2, Column3, Total, Column5, Eliminar, Column4 });
            factura.Location = new Point(314, 141);
            factura.Margin = new Padding(3, 4, 3, 4);
            factura.Name = "factura";
            factura.ReadOnly = true;
            factura.RowHeadersWidth = 6;
            factura.RowTemplate.Height = 25;
            factura.ScrollBars = ScrollBars.Vertical;
            factura.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            factura.Size = new Size(863, 247);
            factura.TabIndex = 37;
            factura.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(11, 87, 96);
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(11, 87, 96);
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            Codigo.DefaultCellStyle = dataGridViewCellStyle10;
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 116;
            // 
            // Column1
            // 
            dataGridViewCellStyle11.BackColor = Color.FromArgb(11, 87, 96);
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(11, 87, 96);
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            Column1.DefaultCellStyle = dataGridViewCellStyle11;
            Column1.HeaderText = "Nombre";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 116;
            // 
            // Quantity
            // 
            dataGridViewCellStyle12.BackColor = Color.FromArgb(11, 87, 96);
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(11, 87, 96);
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            Quantity.DefaultCellStyle = dataGridViewCellStyle12;
            Quantity.HeaderText = "Cantidad";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 116;
            // 
            // Column2
            // 
            dataGridViewCellStyle13.BackColor = Color.FromArgb(11, 87, 96);
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.White;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(11, 87, 96);
            dataGridViewCellStyle13.SelectionForeColor = Color.White;
            Column2.DefaultCellStyle = dataGridViewCellStyle13;
            Column2.HeaderText = "Ud. Medida";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            dataGridViewCellStyle14.BackColor = Color.FromArgb(11, 87, 96);
            dataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(11, 87, 96);
            dataGridViewCellStyle14.SelectionForeColor = Color.White;
            Column3.DefaultCellStyle = dataGridViewCellStyle14;
            Column3.HeaderText = "Costo Unitario";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Total
            // 
            dataGridViewCellStyle15.BackColor = Color.FromArgb(11, 87, 96);
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = Color.White;
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(11, 87, 96);
            dataGridViewCellStyle15.SelectionForeColor = Color.White;
            Total.DefaultCellStyle = dataGridViewCellStyle15;
            Total.HeaderText = "Precio Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 125;
            // 
            // Column5
            // 
            dataGridViewCellStyle16.BackColor = Color.FromArgb(11, 87, 96);
            dataGridViewCellStyle16.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = Color.White;
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(11, 87, 96);
            dataGridViewCellStyle16.SelectionForeColor = Color.White;
            Column5.DefaultCellStyle = dataGridViewCellStyle16;
            Column5.HeaderText = "Iva";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 45;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Resizable = DataGridViewTriState.True;
            Eliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            Eliminar.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // textBoxCliente
            // 
            textBoxCliente.Location = new Point(123, 71);
            textBoxCliente.Name = "textBoxCliente";
            textBoxCliente.Size = new Size(183, 23);
            textBoxCliente.TabIndex = 38;
            textBoxCliente.TextChanged += textBoxCliente_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(314, 421);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 23);
            textBox2.TabIndex = 39;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // nombreTB
            // 
            nombreTB.Location = new Point(40, 160);
            nombreTB.Name = "nombreTB";
            nombreTB.Size = new Size(98, 23);
            nombreTB.TabIndex = 41;
            nombreTB.TextChanged += nombreTB_TextChanged;
            // 
            // direccionTB
            // 
            direccionTB.Location = new Point(40, 245);
            direccionTB.Name = "direccionTB";
            direccionTB.Size = new Size(208, 23);
            direccionTB.TabIndex = 42;
            direccionTB.TextChanged += direccionTB_TextChanged;
            // 
            // telefonoTB
            // 
            telefonoTB.Location = new Point(40, 330);
            telefonoTB.Name = "telefonoTB";
            telefonoTB.Size = new Size(208, 23);
            telefonoTB.TabIndex = 43;
            telefonoTB.TextChanged += telefonoTB_TextChanged;
            // 
            // apellidoTB
            // 
            apellidoTB.Location = new Point(153, 160);
            apellidoTB.Name = "apellidoTB";
            apellidoTB.Size = new Size(99, 23);
            apellidoTB.TabIndex = 44;
            apellidoTB.TextChanged += apellidoTB_TextChanged;
            // 
            // emailTB
            // 
            emailTB.Location = new Point(37, 414);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(208, 23);
            emailTB.TabIndex = 45;
            emailTB.TextChanged += emailTB_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(40, 142);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 46;
            label6.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(153, 142);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 47;
            label7.Text = "Apellido";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(408, 132);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 48;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(43, 227);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 49;
            label9.Text = "Direccion";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(43, 312);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 50;
            label10.Text = "Telefono";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(40, 396);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 51;
            label11.Text = "Email";
            // 
            // tipoDeDocumentoCB
            // 
            tipoDeDocumentoCB.FormattingEnabled = true;
            tipoDeDocumentoCB.Items.AddRange(new object[] { "V", "E", "J" });
            tipoDeDocumentoCB.Location = new Point(77, 71);
            tipoDeDocumentoCB.Name = "tipoDeDocumentoCB";
            tipoDeDocumentoCB.Size = new Size(40, 23);
            tipoDeDocumentoCB.TabIndex = 52;
            // 
            // Si
            // 
            Si.AutoSize = true;
            Si.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            Si.Location = new Point(43, 504);
            Si.Name = "Si";
            Si.Size = new Size(36, 19);
            Si.TabIndex = 53;
            Si.TabStop = true;
            Si.Text = "Si";
            Si.UseVisualStyleBackColor = true;
            Si.CheckedChanged += Si_CheckedChanged;
            // 
            // No
            // 
            No.AutoSize = true;
            No.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            No.Location = new Point(97, 504);
            No.Name = "No";
            No.Size = new Size(41, 19);
            No.TabIndex = 54;
            No.TabStop = true;
            No.Text = "No";
            No.UseVisualStyleBackColor = true;
            No.CheckedChanged += No_CheckedChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(40, 482);
            label12.Name = "label12";
            label12.Size = new Size(66, 15);
            label12.TabIndex = 55;
            label12.Text = "Excluyente";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.ControlDato2;
            pictureBox8.Location = new Point(37, 437);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(208, 27);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 62;
            pictureBox8.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.ControlDato2;
            pictureBox10.Location = new Point(40, 265);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(208, 22);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 63;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.ControlDato2;
            pictureBox11.Location = new Point(153, 180);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(99, 20);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 64;
            pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.ControlDato2;
            pictureBox12.Location = new Point(40, 180);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(98, 20);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 65;
            pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = Properties.Resources.ControlDato2;
            pictureBox13.Location = new Point(40, 350);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(208, 22);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 66;
            pictureBox13.TabStop = false;
            // 
            // cantidadTB
            // 
            cantidadTB.Location = new Point(657, 421);
            cantidadTB.Name = "cantidadTB";
            cantidadTB.Size = new Size(73, 23);
            cantidadTB.TabIndex = 68;
            cantidadTB.TextChanged += cantidadTB_TextChanged;
            // 
            // Cantidad
            // 
            Cantidad.AutoSize = true;
            Cantidad.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            Cantidad.Location = new Point(657, 403);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(56, 15);
            Cantidad.TabIndex = 69;
            Cantidad.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(823, 458);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 70;
            label4.Text = "Total:";
            label4.Click += label4_Click;
            // 
            // can
            // 
            can.AutoSize = true;
            can.Location = new Point(1130, 33);
            can.Name = "can";
            can.Size = new Size(0, 15);
            can.TabIndex = 71;
            can.Click += can_Click;
            // 
            // Dolar
            // 
            Dolar.Location = new Point(657, 485);
            Dolar.Name = "Dolar";
            Dolar.Size = new Size(73, 23);
            Dolar.TabIndex = 72;
            Dolar.TextChanged += Dolar_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(657, 467);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 73;
            label2.Text = "Tasa del Dólar";
            // 
            // pboxAgregarCliente
            // 
            pboxAgregarCliente.Image = Properties.Resources.ControlAñadir;
            pboxAgregarCliente.Location = new Point(367, 71);
            pboxAgregarCliente.Margin = new Padding(3, 2, 3, 2);
            pboxAgregarCliente.Name = "pboxAgregarCliente";
            pboxAgregarCliente.Size = new Size(41, 35);
            pboxAgregarCliente.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAgregarCliente.TabIndex = 74;
            pboxAgregarCliente.TabStop = false;
            pboxAgregarCliente.Click += pboxAgregarCliente_Click;
            // 
            // btnVerProductos
            // 
            btnVerProductos.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnVerProductos.Location = new Point(510, 421);
            btnVerProductos.Name = "btnVerProductos";
            btnVerProductos.Size = new Size(112, 23);
            btnVerProductos.TabIndex = 75;
            btnVerProductos.Text = "Ver productos";
            btnVerProductos.UseVisualStyleBackColor = true;
            btnVerProductos.Click += btnVerProductos_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(638, 645);
            button1.Name = "button1";
            button1.Size = new Size(112, 23);
            button1.TabIndex = 76;
            button1.Text = "Ver facturas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconoMusicaApagar;
            pictureBox1.Location = new Point(1054, 588);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 78;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 694);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(btnVerProductos);
            Controls.Add(pboxAgregarCliente);
            Controls.Add(label2);
            Controls.Add(Dolar);
            Controls.Add(can);
            Controls.Add(label4);
            Controls.Add(Cantidad);
            Controls.Add(cantidadTB);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox8);
            Controls.Add(label12);
            Controls.Add(No);
            Controls.Add(Si);
            Controls.Add(tipoDeDocumentoCB);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(emailTB);
            Controls.Add(apellidoTB);
            Controls.Add(telefonoTB);
            Controls.Add(direccionTB);
            Controls.Add(nombreTB);
            Controls.Add(textBox2);
            Controls.Add(textBoxCliente);
            Controls.Add(factura);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(LabelDolares);
            Controls.Add(label3);
            Controls.Add(subtotal);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(ImprimirFactura);
            Controls.Add(label5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox10);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Ventas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas";
            Load += Ventas_Load_1;
            ((System.ComponentModel.ISupportInitialize)ImprimirFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)factura).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregarCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private PictureBox ImprimirFactura;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label subtotal;
        private Label label3;
        private Label LabelDolares;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox9;
        private DataGridView factura;
        private TextBox textBoxCliente;
        private TextBox textBox2;
        private TextBox nombreTB;
        private TextBox direccionTB;
        private TextBox telefonoTB;
        private TextBox apellidoTB;
        private TextBox emailTB;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox tipoDeDocumentoCB;
        private RadioButton Si;
        private RadioButton No;
        private Label label12;
        private PictureBox pictureBox8;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private TextBox cantidadTB;
        private Label Cantidad;
        private Label label4;
        private Label can;
        private TextBox Dolar;
        private Label label2;
        private PictureBox pboxAgregarCliente;
        private Button btnVerProductos;
        private Button button1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewButtonColumn Eliminar;
        private DataGridViewButtonColumn Column4;
        private PictureBox pictureBox1;
    }
}
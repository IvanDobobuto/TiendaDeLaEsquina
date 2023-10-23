namespace sistemaCompra
{
    partial class CtrlUsuario
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
            pboxEliminar = new PictureBox();
            pboxEditar = new PictureBox();
            pnlDesplegar = new Panel();
            lblConfirmarPassword = new Label();
            pictureBox1 = new PictureBox();
            txtConfirmarPassword = new TextBox();
            pboxAceptarEditar = new PictureBox();
            txtNombre = new TextBox();
            txtPassword = new TextBox();
            lblNombre = new Label();
            lblPassword = new Label();
            pboxCancelar = new PictureBox();
            pboxAceptarAgregar = new PictureBox();
            pboxBarra2 = new PictureBox();
            pboxBarra = new PictureBox();
            pboxDatos = new PictureBox();
            pboxAgregar = new PictureBox();
            pboxCtrlUsuarios = new PictureBox();
            pboxLista = new PictureBox();
            dtgvListaUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pboxEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxEditar).BeginInit();
            pnlDesplegar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAceptarEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCancelar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAceptarAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxLista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvListaUsuarios).BeginInit();
            SuspendLayout();
            // 
            // pboxEliminar
            // 
            pboxEliminar.Image = Properties.Resources.ControlEliminar;
            pboxEliminar.Location = new Point(576, 77);
            pboxEliminar.Margin = new Padding(3, 2, 3, 2);
            pboxEliminar.Name = "pboxEliminar";
            pboxEliminar.Size = new Size(49, 46);
            pboxEliminar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxEliminar.TabIndex = 62;
            pboxEliminar.TabStop = false;
            pboxEliminar.Click += pboxEliminar_Click;
            // 
            // pboxEditar
            // 
            pboxEditar.Image = Properties.Resources.VentasEditar;
            pboxEditar.Location = new Point(496, 77);
            pboxEditar.Margin = new Padding(3, 2, 3, 2);
            pboxEditar.Name = "pboxEditar";
            pboxEditar.Size = new Size(49, 46);
            pboxEditar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxEditar.TabIndex = 61;
            pboxEditar.TabStop = false;
            pboxEditar.Click += pboxEditar_Click;
            // 
            // pnlDesplegar
            // 
            pnlDesplegar.Controls.Add(lblConfirmarPassword);
            pnlDesplegar.Controls.Add(pictureBox1);
            pnlDesplegar.Controls.Add(txtConfirmarPassword);
            pnlDesplegar.Controls.Add(pboxAceptarEditar);
            pnlDesplegar.Controls.Add(txtNombre);
            pnlDesplegar.Controls.Add(txtPassword);
            pnlDesplegar.Controls.Add(lblNombre);
            pnlDesplegar.Controls.Add(lblPassword);
            pnlDesplegar.Controls.Add(pboxCancelar);
            pnlDesplegar.Controls.Add(pboxAceptarAgregar);
            pnlDesplegar.Controls.Add(pboxBarra2);
            pnlDesplegar.Controls.Add(pboxBarra);
            pnlDesplegar.Controls.Add(pboxDatos);
            pnlDesplegar.Location = new Point(407, 138);
            pnlDesplegar.Name = "pnlDesplegar";
            pnlDesplegar.Size = new Size(388, 269);
            pnlDesplegar.TabIndex = 60;
            // 
            // lblConfirmarPassword
            // 
            lblConfirmarPassword.AutoSize = true;
            lblConfirmarPassword.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblConfirmarPassword.Location = new Point(123, 160);
            lblConfirmarPassword.Name = "lblConfirmarPassword";
            lblConfirmarPassword.Size = new Size(147, 13);
            lblConfirmarPassword.TabIndex = 78;
            lblConfirmarPassword.Text = "Confirmar Contraseña";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ControlDato2;
            pictureBox1.Location = new Point(123, 195);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 11);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 77;
            pictureBox1.TabStop = false;
            // 
            // txtConfirmarPassword
            // 
            txtConfirmarPassword.Location = new Point(123, 176);
            txtConfirmarPassword.Name = "txtConfirmarPassword";
            txtConfirmarPassword.Size = new Size(135, 23);
            txtConfirmarPassword.TabIndex = 76;
            txtConfirmarPassword.TextChanged += txtConfirmarPassword_TextChanged;
            // 
            // pboxAceptarEditar
            // 
            pboxAceptarEditar.Image = Properties.Resources.BotonAceptar1;
            pboxAceptarEditar.Location = new Point(89, 218);
            pboxAceptarEditar.Margin = new Padding(3, 2, 3, 2);
            pboxAceptarEditar.Name = "pboxAceptarEditar";
            pboxAceptarEditar.Size = new Size(83, 24);
            pboxAceptarEditar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAceptarEditar.TabIndex = 75;
            pboxAceptarEditar.TabStop = false;
            pboxAceptarEditar.Click += pboxAceptarEditar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(125, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(133, 23);
            txtNombre.TabIndex = 70;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(123, 108);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(135, 23);
            txtPassword.TabIndex = 58;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblNombre.Location = new Point(169, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(49, 13);
            lblNombre.TabIndex = 64;
            lblNombre.Text = "Nombre";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblPassword.Location = new Point(150, 92);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(77, 13);
            lblPassword.TabIndex = 56;
            lblPassword.Text = "Contraseña";
            // 
            // pboxCancelar
            // 
            pboxCancelar.Image = Properties.Resources.BotonCancelar1;
            pboxCancelar.Location = new Point(209, 218);
            pboxCancelar.Margin = new Padding(3, 2, 3, 2);
            pboxCancelar.Name = "pboxCancelar";
            pboxCancelar.Size = new Size(83, 24);
            pboxCancelar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCancelar.TabIndex = 63;
            pboxCancelar.TabStop = false;
            pboxCancelar.Click += pboxCancelar_Click;
            // 
            // pboxAceptarAgregar
            // 
            pboxAceptarAgregar.Image = Properties.Resources.BotonAceptar1;
            pboxAceptarAgregar.Location = new Point(89, 218);
            pboxAceptarAgregar.Margin = new Padding(3, 2, 3, 2);
            pboxAceptarAgregar.Name = "pboxAceptarAgregar";
            pboxAceptarAgregar.Size = new Size(83, 24);
            pboxAceptarAgregar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAceptarAgregar.TabIndex = 56;
            pboxAceptarAgregar.TabStop = false;
            pboxAceptarAgregar.Click += pboxAceptarAgregar_Click;
            // 
            // pboxBarra2
            // 
            pboxBarra2.Image = Properties.Resources.ControlDato2;
            pboxBarra2.Location = new Point(125, 61);
            pboxBarra2.Name = "pboxBarra2";
            pboxBarra2.Size = new Size(133, 17);
            pboxBarra2.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra2.TabIndex = 57;
            pboxBarra2.TabStop = false;
            // 
            // pboxBarra
            // 
            pboxBarra.Image = Properties.Resources.ControlDato2;
            pboxBarra.Location = new Point(123, 128);
            pboxBarra.Name = "pboxBarra";
            pboxBarra.Size = new Size(135, 18);
            pboxBarra.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra.TabIndex = 56;
            pboxBarra.TabStop = false;
            // 
            // pboxDatos
            // 
            pboxDatos.Image = Properties.Resources.ControlDesplegar;
            pboxDatos.Location = new Point(6, 4);
            pboxDatos.Margin = new Padding(3, 2, 3, 2);
            pboxDatos.Name = "pboxDatos";
            pboxDatos.Size = new Size(379, 259);
            pboxDatos.SizeMode = PictureBoxSizeMode.Zoom;
            pboxDatos.TabIndex = 54;
            pboxDatos.TabStop = false;
            // 
            // pboxAgregar
            // 
            pboxAgregar.Image = Properties.Resources.ControlAñadir;
            pboxAgregar.Location = new Point(413, 77);
            pboxAgregar.Margin = new Padding(3, 2, 3, 2);
            pboxAgregar.Name = "pboxAgregar";
            pboxAgregar.Size = new Size(50, 46);
            pboxAgregar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAgregar.TabIndex = 59;
            pboxAgregar.TabStop = false;
            pboxAgregar.Click += pboxAgregar_Click;
            // 
            // pboxCtrlUsuarios
            // 
            pboxCtrlUsuarios.Image = Properties.Resources.ControlUsuarios;
            pboxCtrlUsuarios.Location = new Point(265, 12);
            pboxCtrlUsuarios.Name = "pboxCtrlUsuarios";
            pboxCtrlUsuarios.Size = new Size(302, 30);
            pboxCtrlUsuarios.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCtrlUsuarios.TabIndex = 58;
            pboxCtrlUsuarios.TabStop = false;
            // 
            // pboxLista
            // 
            pboxLista.Image = Properties.Resources.ControlTabla123;
            pboxLista.Location = new Point(12, 59);
            pboxLista.Name = "pboxLista";
            pboxLista.Size = new Size(378, 481);
            pboxLista.SizeMode = PictureBoxSizeMode.Zoom;
            pboxLista.TabIndex = 63;
            pboxLista.TabStop = false;
            // 
            // dtgvListaUsuarios
            // 
            dtgvListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvListaUsuarios.Location = new Point(25, 182);
            dtgvListaUsuarios.Name = "dtgvListaUsuarios";
            dtgvListaUsuarios.RowTemplate.Height = 25;
            dtgvListaUsuarios.Size = new Size(349, 334);
            dtgvListaUsuarios.TabIndex = 65;
            dtgvListaUsuarios.CellContentClick += dtgvListaUsuarios_CellContentClick;
            // 
            // CtrlUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 549);
            Controls.Add(dtgvListaUsuarios);
            Controls.Add(pboxEliminar);
            Controls.Add(pboxEditar);
            Controls.Add(pnlDesplegar);
            Controls.Add(pboxAgregar);
            Controls.Add(pboxCtrlUsuarios);
            Controls.Add(pboxLista);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CtrlUsuario";
            Text = "CtrlUsuario";
            Load += CtrlUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pboxEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxEditar).EndInit();
            pnlDesplegar.ResumeLayout(false);
            pnlDesplegar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAceptarEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCancelar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAceptarAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxLista).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvListaUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pboxEliminar;
        private PictureBox pboxEditar;
        private Panel pnlDesplegar;
        private PictureBox pboxAceptarEditar;
        private TextBox txtNombre;
        private TextBox txtPassword;
        private Label lblNombre;
        private Label lblPassword;
        private PictureBox pboxCancelar;
        private PictureBox pboxAceptarAgregar;
        private PictureBox pboxBarra2;
        private PictureBox pboxBarra;
        private PictureBox pboxDatos;
        private PictureBox pboxAgregar;
        private PictureBox pboxCtrlUsuarios;
        private PictureBox pboxLista;
        private DataGridView dtgvListaUsuarios;
        private Label lblConfirmarPassword;
        private PictureBox pictureBox1;
        private TextBox txtConfirmarPassword;
    }
}
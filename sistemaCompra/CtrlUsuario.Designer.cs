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
            pnlDesplegar = new Panel();
            pboxAceptarEditar = new PictureBox();
            pboxCancelar = new PictureBox();
            lblConfirmarPassword = new Label();
            pictureBox1 = new PictureBox();
            txtConfirmarPassword = new TextBox();
            txtNombre = new TextBox();
            txtPassword = new TextBox();
            lblNombre = new Label();
            lblPassword = new Label();
            pboxBarra2 = new PictureBox();
            pboxBarra = new PictureBox();
            pboxAgregar = new PictureBox();
            pboxCtrlUsuarios = new PictureBox();
            dtgvListaUsuarios = new DataGridView();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            pictureBox2 = new PictureBox();
            pnlDesplegar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxAceptarEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCancelar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvListaUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnlDesplegar
            // 
            pnlDesplegar.Controls.Add(pboxAceptarEditar);
            pnlDesplegar.Controls.Add(pboxCancelar);
            pnlDesplegar.Location = new Point(856, 131);
            pnlDesplegar.Name = "pnlDesplegar";
            pnlDesplegar.Size = new Size(122, 123);
            pnlDesplegar.TabIndex = 60;
            // 
            // pboxAceptarEditar
            // 
            pboxAceptarEditar.Image = Properties.Resources.BotonAceptar1;
            pboxAceptarEditar.Location = new Point(6, 22);
            pboxAceptarEditar.Margin = new Padding(3, 2, 3, 2);
            pboxAceptarEditar.Name = "pboxAceptarEditar";
            pboxAceptarEditar.Size = new Size(100, 31);
            pboxAceptarEditar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxAceptarEditar.TabIndex = 75;
            pboxAceptarEditar.TabStop = false;
            pboxAceptarEditar.Click += pboxAceptarEditar_Click;
            // 
            // pboxCancelar
            // 
            pboxCancelar.Image = Properties.Resources.BotonCancelar1;
            pboxCancelar.Location = new Point(6, 57);
            pboxCancelar.Margin = new Padding(3, 2, 3, 2);
            pboxCancelar.Name = "pboxCancelar";
            pboxCancelar.Size = new Size(100, 33);
            pboxCancelar.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCancelar.TabIndex = 63;
            pboxCancelar.TabStop = false;
            pboxCancelar.Click += pboxCancelar_Click;
            // 
            // lblConfirmarPassword
            // 
            lblConfirmarPassword.AutoSize = true;
            lblConfirmarPassword.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblConfirmarPassword.Location = new Point(648, 67);
            lblConfirmarPassword.Name = "lblConfirmarPassword";
            lblConfirmarPassword.Size = new Size(127, 15);
            lblConfirmarPassword.TabIndex = 78;
            lblConfirmarPassword.Text = "Confirmar Contraseña";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ControlDato2;
            pictureBox1.Location = new Point(649, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 77;
            pictureBox1.TabStop = false;
            // 
            // txtConfirmarPassword
            // 
            txtConfirmarPassword.Location = new Point(649, 83);
            txtConfirmarPassword.Name = "txtConfirmarPassword";
            txtConfirmarPassword.Size = new Size(146, 23);
            txtConfirmarPassword.TabIndex = 76;
            txtConfirmarPassword.TextChanged += txtConfirmarPassword_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(31, 83);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(133, 23);
            txtNombre.TabIndex = 70;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(445, 83);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(148, 23);
            txtPassword.TabIndex = 58;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblNombre.Location = new Point(31, 67);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(52, 15);
            lblNombre.TabIndex = 64;
            lblNombre.Text = "Nombre";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblPassword.Location = new Point(445, 67);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 15);
            lblPassword.TabIndex = 56;
            lblPassword.Text = "Contraseña";
            // 
            // pboxBarra2
            // 
            pboxBarra2.Image = Properties.Resources.ControlDato2;
            pboxBarra2.Location = new Point(31, 106);
            pboxBarra2.Name = "pboxBarra2";
            pboxBarra2.Size = new Size(133, 17);
            pboxBarra2.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra2.TabIndex = 57;
            pboxBarra2.TabStop = false;
            // 
            // pboxBarra
            // 
            pboxBarra.Image = Properties.Resources.ControlDato2;
            pboxBarra.Location = new Point(445, 106);
            pboxBarra.Name = "pboxBarra";
            pboxBarra.Size = new Size(148, 18);
            pboxBarra.SizeMode = PictureBoxSizeMode.Zoom;
            pboxBarra.TabIndex = 56;
            pboxBarra.TabStop = false;
            // 
            // pboxAgregar
            // 
            pboxAgregar.Image = Properties.Resources.ControlAñadir;
            pboxAgregar.Location = new Point(897, 77);
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
            pboxCtrlUsuarios.Location = new Point(329, 12);
            pboxCtrlUsuarios.Name = "pboxCtrlUsuarios";
            pboxCtrlUsuarios.Size = new Size(302, 30);
            pboxCtrlUsuarios.SizeMode = PictureBoxSizeMode.Zoom;
            pboxCtrlUsuarios.TabIndex = 58;
            pboxCtrlUsuarios.TabStop = false;
            // 
            // dtgvListaUsuarios
            // 
            dtgvListaUsuarios.AllowUserToOrderColumns = true;
            dtgvListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvListaUsuarios.Location = new Point(31, 153);
            dtgvListaUsuarios.Name = "dtgvListaUsuarios";
            dtgvListaUsuarios.RowTemplate.Height = 25;
            dtgvListaUsuarios.Size = new Size(819, 304);
            dtgvListaUsuarios.TabIndex = 65;
            dtgvListaUsuarios.CellContentClick += dtgvListaUsuarios_CellContentClick;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblCorreo.Location = new Point(218, 67);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(107, 15);
            lblCorreo.TabIndex = 79;
            lblCorreo.Text = "Correo electrónico";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(218, 83);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(175, 23);
            txtCorreo.TabIndex = 80;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ControlDato2;
            pictureBox2.Location = new Point(218, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(175, 18);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 81;
            pictureBox2.TabStop = false;
            // 
            // CtrlUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 476);
            Controls.Add(pictureBox2);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(pictureBox1);
            Controls.Add(lblConfirmarPassword);
            Controls.Add(txtConfirmarPassword);
            Controls.Add(dtgvListaUsuarios);
            Controls.Add(pnlDesplegar);
            Controls.Add(txtPassword);
            Controls.Add(txtNombre);
            Controls.Add(pboxBarra);
            Controls.Add(pboxAgregar);
            Controls.Add(pboxCtrlUsuarios);
            Controls.Add(pboxBarra2);
            Controls.Add(lblPassword);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CtrlUsuario";
            Text = "CtrlUsuario";
            Load += CtrlUsuario_Load;
            pnlDesplegar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pboxAceptarEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCancelar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxBarra).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCtrlUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvListaUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlDesplegar;
        private PictureBox pboxAceptarEditar;
        private TextBox txtNombre;
        private TextBox txtPassword;
        private Label lblNombre;
        private Label lblPassword;
        private PictureBox pboxCancelar;
        private PictureBox pboxBarra2;
        private PictureBox pboxBarra;
        private PictureBox pboxAgregar;
        private PictureBox pboxCtrlUsuarios;
        private DataGridView dtgvListaUsuarios;
        private Label lblConfirmarPassword;
        private PictureBox pictureBox1;
        private TextBox txtConfirmarPassword;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private PictureBox pictureBox2;
    }
}
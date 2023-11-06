namespace sistemaCompra
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pboxAvatar = new PictureBox();
            pictureBox2 = new PictureBox();
            cajaUsuario = new TextBox();
            cajaClave = new TextBox();
            mostrarPass = new CheckBox();
            pboxUsuario = new PictureBox();
            pboxPassword = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pboxAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxPassword).BeginInit();
            SuspendLayout();
            // 
            // pboxAvatar
            // 
            pboxAvatar.AccessibleRole = AccessibleRole.None;
            pboxAvatar.Image = Properties.Resources.InterfazLogin2;
            resources.ApplyResources(pboxAvatar, "pboxAvatar");
            pboxAvatar.Name = "pboxAvatar";
            pboxAvatar.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.BotonEntrar;
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // cajaUsuario
            // 
            resources.ApplyResources(cajaUsuario, "cajaUsuario");
            cajaUsuario.Name = "cajaUsuario";
            cajaUsuario.TextChanged += cajaUsuario_TextChanged;
            // 
            // cajaClave
            // 
            cajaClave.BackColor = SystemColors.HighlightText;
            resources.ApplyResources(cajaClave, "cajaClave");
            cajaClave.Name = "cajaClave";
            cajaClave.UseSystemPasswordChar = true;
            cajaClave.TextChanged += cajaClave_TextChanged;
            // 
            // mostrarPass
            // 
            resources.ApplyResources(mostrarPass, "mostrarPass");
            mostrarPass.Name = "mostrarPass";
            mostrarPass.UseVisualStyleBackColor = true;
            mostrarPass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pboxUsuario
            // 
            pboxUsuario.Image = Properties.Resources.InterfazLogin3;
            resources.ApplyResources(pboxUsuario, "pboxUsuario");
            pboxUsuario.Name = "pboxUsuario";
            pboxUsuario.TabStop = false;
            // 
            // pboxPassword
            // 
            pboxPassword.Image = Properties.Resources.InterfazLogin4;
            resources.ApplyResources(pboxPassword, "pboxPassword");
            pboxPassword.Name = "pboxPassword";
            pboxPassword.TabStop = false;
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            BackColor = Color.Honeydew;
            Controls.Add(mostrarPass);
            Controls.Add(cajaClave);
            Controls.Add(cajaUsuario);
            Controls.Add(pictureBox2);
            Controls.Add(pboxAvatar);
            Controls.Add(pboxUsuario);
            Controls.Add(pboxPassword);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Name = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pboxAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pboxAvatar;
        private PictureBox pictureBox2;
        private TextBox cajaUsuario;
        private TextBox cajaClave;
        private CheckBox mostrarPass;
        private PictureBox pboxUsuario;
        private PictureBox pboxPassword;
    }
}
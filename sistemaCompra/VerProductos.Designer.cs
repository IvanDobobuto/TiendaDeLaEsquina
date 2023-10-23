namespace sistemaCompra
{
    partial class VerProductos
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pboxProductos = new PictureBox();
            dtgvListaProductos = new DataGridView();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            lblBuscarCodigo = new Label();
            lblBuscarNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)pboxProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvListaProductos).BeginInit();
            SuspendLayout();
            // 
            // pboxProductos
            // 
            pboxProductos.Image = Properties.Resources.ControlProductos2;
            pboxProductos.Location = new Point(168, 13);
            pboxProductos.Margin = new Padding(3, 4, 3, 4);
            pboxProductos.Name = "pboxProductos";
            pboxProductos.Size = new Size(232, 52);
            pboxProductos.SizeMode = PictureBoxSizeMode.Zoom;
            pboxProductos.TabIndex = 33;
            pboxProductos.TabStop = false;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgvListaProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dtgvListaProductos.Location = new Point(45, 185);
            dtgvListaProductos.Name = "dtgvListaProductos";
            dtgvListaProductos.ReadOnly = true;
            dtgvListaProductos.RowTemplate.Height = 25;
            dtgvListaProductos.Size = new Size(452, 449);
            dtgvListaProductos.TabIndex = 34;
            dtgvListaProductos.CellContentClick += dtgvListaProductos_CellContentClick;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(114, 124);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 35;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(338, 124);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 36;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblBuscarCodigo
            // 
            lblBuscarCodigo.AutoSize = true;
            lblBuscarCodigo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblBuscarCodigo.Location = new Point(114, 99);
            lblBuscarCodigo.Name = "lblBuscarCodigo";
            lblBuscarCodigo.Size = new Size(109, 15);
            lblBuscarCodigo.TabIndex = 37;
            lblBuscarCodigo.Text = "Buscar por código:";
            // 
            // lblBuscarNombre
            // 
            lblBuscarNombre.AutoSize = true;
            lblBuscarNombre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblBuscarNombre.Location = new Point(327, 99);
            lblBuscarNombre.Name = "lblBuscarNombre";
            lblBuscarNombre.Size = new Size(115, 15);
            lblBuscarNombre.TabIndex = 38;
            lblBuscarNombre.Text = "Buscar por nombre:";
            // 
            // VerProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 676);
            Controls.Add(lblBuscarNombre);
            Controls.Add(lblBuscarCodigo);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(dtgvListaProductos);
            Controls.Add(pboxProductos);
            Name = "VerProductos";
            Text = "VerProductos";
            ((System.ComponentModel.ISupportInitialize)pboxProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvListaProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pboxProductos;
        private DataGridView dtgvListaProductos;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private Label lblBuscarCodigo;
        private Label lblBuscarNombre;
    }
}
namespace sistemaCompra
{
    partial class InfoAdmin
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
            lblBienvenido = new Label();
            label2 = new Label();
            lblControl = new Label();
            lblImportacion = new Label();
            lblExportacion = new Label();
            lblControlDescripcion = new Label();
            lblImportacionDescripcion = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("OCR A Extended", 30F, FontStyle.Italic, GraphicsUnit.Point);
            lblBienvenido.Location = new Point(83, 31);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(858, 41);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "Bienvenido al Menú de Administrador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("OCR A Extended", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(380, 98);
            label2.Name = "label2";
            label2.Size = new Size(317, 29);
            label2.TabIndex = 1;
            label2.Text = "Aquí encontrarás...";
            // 
            // lblControl
            // 
            lblControl.Font = new Font("OCR A Extended", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblControl.Location = new Point(42, 161);
            lblControl.Name = "lblControl";
            lblControl.Size = new Size(317, 43);
            lblControl.TabIndex = 2;
            lblControl.Text = "Control de Usuarios, Productos y Clientes";
            // 
            // lblImportacion
            // 
            lblImportacion.Font = new Font("OCR A Extended", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblImportacion.Location = new Point(408, 161);
            lblImportacion.Name = "lblImportacion";
            lblImportacion.Size = new Size(258, 43);
            lblImportacion.TabIndex = 3;
            lblImportacion.Text = "Importación de Usuarios, Productos y Clientes";
            // 
            // lblExportacion
            // 
            lblExportacion.Font = new Font("OCR A Extended", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblExportacion.Location = new Point(728, 161);
            lblExportacion.Name = "lblExportacion";
            lblExportacion.Size = new Size(258, 43);
            lblExportacion.TabIndex = 4;
            lblExportacion.Text = "Exportación de Usuarios, Productos y Clientes";
            // 
            // lblControlDescripcion
            // 
            lblControlDescripcion.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblControlDescripcion.Location = new Point(42, 387);
            lblControlDescripcion.Name = "lblControlDescripcion";
            lblControlDescripcion.Size = new Size(317, 61);
            lblControlDescripcion.TabIndex = 5;
            lblControlDescripcion.Text = "Puedes ver la lista de Usuarios, Productos y Clientes guardados en el sistema. También podrás agregar, editar y eliminar de la lista.";
            lblControlDescripcion.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblImportacionDescripcion
            // 
            lblImportacionDescripcion.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblImportacionDescripcion.Location = new Point(380, 387);
            lblImportacionDescripcion.Name = "lblImportacionDescripcion";
            lblImportacionDescripcion.Size = new Size(286, 61);
            lblImportacionDescripcion.TabIndex = 6;
            lblImportacionDescripcion.Text = "Puedes importar desde tu computador archivos del tipo .csv que contengan datos de Usuario, Producto y Cliente, siguiendo el formato especificado.";
            lblImportacionDescripcion.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Font = new Font("OCR A Extended", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(700, 387);
            label1.Name = "label1";
            label1.Size = new Size(286, 61);
            label1.TabIndex = 7;
            label1.Text = "Puedes exportar los datos de Usuario, Producto y Cliente que se encuentren guardados en el programa, a través de una copia de ellos como archivos del tipo .csv.";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // InfoAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 476);
            Controls.Add(label1);
            Controls.Add(lblImportacionDescripcion);
            Controls.Add(lblControlDescripcion);
            Controls.Add(lblExportacion);
            Controls.Add(lblImportacion);
            Controls.Add(lblControl);
            Controls.Add(label2);
            Controls.Add(lblBienvenido);
            Name = "InfoAdmin";
            Text = "InfoAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido;
        private Label label2;
        private Label lblControl;
        private Label lblImportacion;
        private Label lblExportacion;
        private Label lblControlDescripcion;
        private Label lblImportacionDescripcion;
        private Label label1;
    }
}
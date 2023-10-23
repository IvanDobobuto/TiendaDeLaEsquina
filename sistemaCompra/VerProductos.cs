using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaCompra
{
    public partial class VerProductos : Form
    {
        private DataTable originalDt; // Mantener una copia del DataTable original para poder restablecer los datos

        public VerProductos()
        {
            InitializeComponent();
            CargarDatosDesdeCSV();
            originalDt = (DataTable)dtgvListaProductos.DataSource; // Guardar la copia original de los datos
            txtCodigo.TextChanged += txtCodigo_TextChanged; // Agregar el controlador de eventos
            txtNombre.TextChanged += txtNombre_TextChanged; // Agregar el controlador de eventos
        }

        private void CargarDatosDesdeCSV()
        {
            string filePath = "inventario.csv"; // Asegúrate de que el archivo está en el directorio correcto

            try
            {
                DataTable dt = new DataTable();
                string[] lines = File.ReadAllLines(filePath, Encoding.UTF8); // Especifica la codificación UTF-8 al leer el archivo

                if (lines.Length > 0)
                {
                    // Agrega columnas necesarias
                    dt.Columns.Add("Codigo", typeof(int)); // Cambia el tipo de datos de la columna a entero
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Cantidad");
                    dt.Columns.Add("PrecioDeVenta");

                    // Agrega filas
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] dataWords = lines[i].Split(',');
                        DataRow dr = dt.NewRow();

                        dr["Codigo"] = Convert.ToInt32(dataWords[0]); // Convierte el código a entero antes de agregarlo
                        dr["Nombre"] = dataWords[1];
                        dr["Cantidad"] = dataWords[2];
                        dr["PrecioDeVenta"] = dataWords[6];

                        dt.Rows.Add(dr);
                    }

                    DataView dv = dt.DefaultView;
                    dv.Sort = "Codigo ASC"; // Ordena por Codigo en orden ascendente
                    dt = dv.ToTable();
                }

                dtgvListaProductos.DataSource = dt;
                dtgvListaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgvListaProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir al cargar el archivo CSV.
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;

            if (originalDt != null)
            {
                DataView dv = originalDt.DefaultView;
                if (!string.IsNullOrEmpty(codigo))
                {
                    dv.RowFilter = string.Format("Convert(Codigo, 'System.String') LIKE '%{0}%'", codigo); // Convierte el campo Codigo a cadena antes de aplicar 'Like'
                }
                else
                {
                    dv.RowFilter = string.Empty;
                }
                dtgvListaProductos.DataSource = dv.ToTable();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            if (originalDt != null)
            {
                DataView dv = originalDt.DefaultView;
                if (!string.IsNullOrEmpty(nombre))
                {
                    dv.RowFilter = string.Format("Nombre LIKE '%{0}%'", nombre);
                }
                else
                {
                    dv.RowFilter = string.Empty;
                }
                dtgvListaProductos.DataSource = dv.ToTable();
            }
        }

        private void dtgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

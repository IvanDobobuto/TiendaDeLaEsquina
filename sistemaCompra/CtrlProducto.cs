using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Linq;

namespace sistemaCompra
{
    public partial class CtrlProducto : Form
    {
        private const string NOMBRE_ARCHIVO = "inventario.csv";
        private string encabezadoCSV = "Codigo,Nombre,Cantidad,CantidadMinima,UnidadDeMedida,CostoUnitario,PrecioDeVenta,tieneIVA";

        public CtrlProducto()
        {
            InitializeComponent();
            VerificarArchivoCSV();
            txtCodigo.KeyPress += new KeyPressEventHandler(ValidarNumerosEnteros);
            txtCantidad.KeyPress += new KeyPressEventHandler(ValidarNumerosEnteros);
            txtCosto.KeyPress += new KeyPressEventHandler(ValidarNumerosDecimales);
            txtPrecio.KeyPress += new KeyPressEventHandler(ValidarNumerosDecimales);
            txtCantidadMinima.KeyPress += new KeyPressEventHandler(ValidarNumerosDecimales);
            txtBuscarCodigo.KeyPress += new KeyPressEventHandler(ValidarNumerosEnteros);
            txtBuscarNombre.KeyPress += new KeyPressEventHandler(txtNombre_KeyPress);

            Image imgEditar = Image.FromFile("VentasEditar.png");
            Image imgEliminar = Image.FromFile("ControlEliminar.png");

            // Agregar columna de botón de edición con imagen
            DataGridViewImageColumn editarImageColumn = new DataGridViewImageColumn();
            editarImageColumn.HeaderText = "Editar";
            editarImageColumn.Image = imgEditar;
            editarImageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Ajusta la imagen al tamaño de la celda
            dtgvListaProductos.Columns.Add(editarImageColumn);

            // Agregar columna de botón de eliminación con imagen
            DataGridViewImageColumn eliminarImageColumn = new DataGridViewImageColumn();
            eliminarImageColumn.HeaderText = "Eliminar";
            eliminarImageColumn.Image = imgEliminar;
            eliminarImageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Ajusta la imagen al tamaño de la celda
            dtgvListaProductos.Columns.Add(eliminarImageColumn);

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ValidarNumerosEnteros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ValidarNumerosDecimales(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permite solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        private void VerificarArchivoCSV()
        {
            if (!File.Exists(NOMBRE_ARCHIVO))
            {
                using (StreamWriter sw = File.CreateText(NOMBRE_ARCHIVO))
                {
                    sw.WriteLine(encabezadoCSV);
                }
            }
        }

        private void AgregarProductoAlCSV(string codigo, string nombre, string cantidad, string cantidadMinima, string unidadMedida, string costo, string precio, string tieneIVA)
        {
            try
            {
                string nuevaLinea = $"{codigo},{nombre},{cantidad},{cantidadMinima},{unidadMedida},{costo},{precio},{tieneIVA}";

                using (StreamWriter sw = new StreamWriter(NOMBRE_ARCHIVO, true))
                {
                    sw.WriteLine(nuevaLinea); // Agrega la nueva línea al archivo con un salto de línea al final
                }

                MessageBox.Show("El producto ha sido agregado correctamente.", "Producto Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCasillas();

                // Volver a cargar los datos en el DataGridView
                CargarProductosEnDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCasillas()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCantidad.Text = "";
            txtCantidadMinima.Text = "";
            cboxUdMedidas.SelectedIndex = -1;
            txtCosto.Text = "";
            txtPrecio.Text = "";
        }

        private DataTable ObtenerTablaProductos()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Cantidad Mínima");
            dt.Columns.Add("UnidadMedida");
            dt.Columns.Add("Costo");
            dt.Columns.Add("Precio");
            dt.Columns.Add("TieneIVA");

            try
            {
                var lines = File.ReadAllLines(NOMBRE_ARCHIVO);
                var data = lines.Skip(1)
                                .Where(l => !string.IsNullOrWhiteSpace(l))
                                .Select(l => l.Split(','))
                                .Where(arr => arr.Length == dt.Columns.Count)
                                .Select(arr => new
                                {
                                    Codigo = arr[0],
                                    Nombre = arr[1],
                                    Cantidad = arr[2],
                                    CantidadMinima = arr[3],
                                    UnidadMedida = arr[4],
                                    Costo = arr[5],
                                    Precio = arr[6],
                                    TieneIVA = arr[7]
                                });

                foreach (var item in data)
                {
                    dt.Rows.Add(item.Codigo, item.Nombre, item.Cantidad, item.CantidadMinima, item.UnidadMedida, item.Costo, item.Precio, item.TieneIVA);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo CSV: {ex.Message}", "Error de Lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }


        private void CargarProductosEnDataGridView()
        {
            DataTable dtProductos = ObtenerTablaProductos();
            dtgvListaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataView dv = dtProductos.DefaultView;
            dv.Sort = "Codigo ASC";
            DataTable dtSorted = dv.ToTable();

            dtgvListaProductos.DataSource = dtSorted;
        }

        private void MostrarDataGrid(DataTable dt)
        {
            dtgvListaProductos.DataSource = dt;
        }
        private void CtrlProducto_Load(object sender, EventArgs e)
        {
            pnlDesplegar.Visible = false;
            CargarProductosEnDataGridView();
            dtgvListaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void pboxAgregar_Click(object sender, EventArgs e)
        {
            pboxAceptarEditar.Visible = false;
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) || cboxUdMedidas.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtCosto.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                cboxSiYNo.SelectedItem == null)
            {
                MessageBox.Show("Por favor complete todos los campos antes de agregar el producto.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string codigo = txtCodigo.Text;
                if (VerificarCodigoExistente(codigo))
                {
                    int maxCodigo = ObtenerCodigoMasAlto();
                    MessageBox.Show($"El código ya existe. Use un código superior al último código más alto, por ejemplo, {maxCodigo + 1}.", "Código Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string nombre = txtNombre.Text;
                    string cantidad = txtCantidad.Text;
                    string cantidadMinima = txtCantidadMinima.Text;
                    string unidadMedida = cboxUdMedidas.SelectedItem.ToString();
                    string costo = txtCosto.Text;
                    string precio = txtPrecio.Text;
                    string tieneIVA = cboxSiYNo.SelectedItem.ToString();

                    AgregarProductoAlCSV(codigo, nombre, cantidad, cantidadMinima, unidadMedida, costo, precio, tieneIVA);
                    pnlDesplegar.Visible = false;
                }
            }
        }


        private void pboxCancelar_Click(object sender, EventArgs e)
        {
            pnlDesplegar.Visible = false;
            LimpiarCasillas();
        }

        private void dtgvListaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dgv = sender as DataGridView;
                if (e.ColumnIndex >= 0 && e.ColumnIndex < dgv.Columns.Count)
                {
                    if (dgv.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                    {
                        string codigoValue = dgv.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                        string nombreProducto = dgv.Rows[e.RowIndex].Cells["Nombre"].Value.ToString(); // Obtener el nombre del producto
                        if (dgv.Columns[e.ColumnIndex].HeaderText.Equals("Editar"))
                        {
                            string codigo = dgv.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                            CargarDatosParaEdicion(codigo);
                        }
                        else if (dgv.Columns[e.ColumnIndex].HeaderText.Equals("Eliminar"))
                        {
                            var confirmResult = MessageBox.Show($"¿Estás seguro de que deseas eliminar el producto '{nombreProducto}'?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                            if (confirmResult == DialogResult.Yes)
                            {
                                EliminarProductoDeCSV(codigoValue);
                                MessageBox.Show("Producto eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CargarProductosEnDataGridView();
                                LimpiarCasillas();
                                pboxAceptarEditar.Visible = false;
                                pboxCancelar.Visible = false;
                            }
                        }
                    }
                }
            }
        }
        private void CargarDatosParaEdicion(string codigo)
        {
            try
            {
                using (StreamReader sr = new StreamReader(NOMBRE_ARCHIVO))
                {
                    sr.ReadLine(); // Saltar la primera línea (encabezado)
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] campos = line.Split(',');
                        if (campos[0] == codigo)
                        {
                            txtCodigo.Text = campos[0];
                            txtNombre.Text = campos[1];
                            txtCantidad.Text = campos[2];
                            txtCantidadMinima.Text = campos[3];
                            cboxUdMedidas.SelectedItem = campos[4];
                            txtCosto.Text = campos[5];
                            txtPrecio.Text = campos[6];
                            cboxSiYNo.SelectedItem = campos[7];
                            pnlDesplegar.Visible = true;
                            pboxAceptarEditar.Visible = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos para edición: {ex.Message}", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarProductoDeCSV(string codigo)
        {
            try
            {
                string tempFile = Path.GetTempFileName();
                var linesToKeep = File.ReadLines(NOMBRE_ARCHIVO).Where(l => !l.StartsWith(codigo + ","));
                File.WriteAllLines(tempFile, linesToKeep);
                File.Delete(NOMBRE_ARCHIVO);
                File.Move(tempFile, NOMBRE_ARCHIVO);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el producto: {ex.Message}", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboxUdMedidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboxSiYNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ActualizarProductoEnCSV(string codigo, string nombre, string cantidad, string cantidadMinima, string unidadMedida, string costo, string precio, string tieneIVA)
        {
            string tempFile = Path.GetTempFileName();
            var linesToKeep = File.ReadLines(NOMBRE_ARCHIVO).Where(l => !l.StartsWith(codigo + ","));
            File.WriteAllLines(tempFile, linesToKeep);

            string nuevaLinea = $"{codigo},{nombre},{cantidad},{cantidadMinima},{unidadMedida},{costo},{precio},{tieneIVA}";
            File.AppendAllText(tempFile, nuevaLinea + Environment.NewLine);

            File.Delete(NOMBRE_ARCHIVO);
            File.Move(tempFile, NOMBRE_ARCHIVO);
        }

        private void pboxAceptarEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) || cboxUdMedidas.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtCosto.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                cboxSiYNo.SelectedItem == null)
            {
                MessageBox.Show("Por favor complete todos los campos antes de editar el producto.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string codigo = txtCodigo.Text;
                string nombre = txtNombre.Text;
                string cantidad = txtCantidad.Text;
                string cantidadMinima = txtCantidadMinima.Text;
                string unidadMedida = cboxUdMedidas.SelectedItem.ToString();
                string costo = txtCosto.Text;
                string precio = txtPrecio.Text;
                string tieneIVA = cboxSiYNo.SelectedItem.ToString();

                ActualizarProductoEnCSV(codigo, nombre, cantidad, cantidadMinima, unidadMedida, costo, precio, tieneIVA);

                MessageBox.Show("El producto ha sido editado correctamente.", "Producto Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCasillas();
                pnlDesplegar.Visible = false;

                // Volver a cargar los datos en el DataGridView
                DataTable dt = ObtenerTablaProductos();
                MostrarDataGrid(dt);
            }
        }

        // Método para verificar si un código ya existe en el archivo CSV utilizando LINQ
        private bool VerificarCodigoExistente(string codigo)
        {
            bool codigoExistente = false;
            try
            {
                var lines = File.ReadAllLines(NOMBRE_ARCHIVO);
                codigoExistente = lines.Skip(1) // Saltar la primera línea (encabezado)
                                      .Any(line => line.Split(',')[0] == codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo CSV: {ex.Message}", "Error de Lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return codigoExistente;
        }

        // Método para obtener el código más alto en el archivo CSV utilizando LINQ
        private int ObtenerCodigoMasAlto()
        {
            int maxCodigo = 0;
            try
            {
                var lines = File.ReadAllLines(NOMBRE_ARCHIVO);
                maxCodigo = lines.Skip(1)
                                .Select(line => int.TryParse(line.Split(',')[0], out int codigo) ? codigo : 0)
                                .Max();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo CSV: {ex.Message}", "Error de Lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return maxCodigo;
        }

        private void txtCantidadMinima_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtBuscarCodigo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscarCodigo.Text))
            {
                string textoBusqueda = txtBuscarCodigo.Text;
                DataTable dt = ObtenerTablaProductos();
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"Codigo LIKE '%{textoBusqueda}%'";
                DataTable dtFiltered = dv.ToTable();
                MostrarDataGrid(dtFiltered);
            }
            else
            {
                CargarProductosEnDataGridView();
            }
        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscarNombre.Text))
            {
                string textoBusqueda = txtBuscarNombre.Text;
                DataTable dt = ObtenerTablaProductos();
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"Nombre LIKE '%{textoBusqueda}%'";
                DataTable dtFiltered = dv.ToTable();
                MostrarDataGrid(dtFiltered);
            }
            else
            {
                CargarProductosEnDataGridView();
            }
        }
    }
}

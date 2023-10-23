using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
                using (StreamReader sr = new StreamReader(NOMBRE_ARCHIVO))
                {
                    sr.ReadLine(); // Saltar la primera línea
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(line)) // Verificar si la línea no está vacía
                        {
                            string[] campos = line.Split(',');
                            if (campos.Length == dt.Columns.Count) // Verificar si el número de campos es igual al número de columnas
                            {
                                dt.Rows.Add(campos);
                            }
                        }
                    }
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
            dtgvListaProductos.DataSource = dtProductos;
            dtgvListaProductos.Columns["Cantidad"].Visible = false;
            dtgvListaProductos.Columns["Cantidad Mínima"].Visible = false;
            dtgvListaProductos.Columns["UnidadMedida"].Visible = false;
            dtgvListaProductos.Columns["Costo"].Visible = false;
            dtgvListaProductos.Columns["Precio"].Visible = false;
            dtgvListaProductos.Columns["TieneIVA"].Visible = false;
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
            pnlDesplegar.Visible = true;
            LimpiarCasillas();
            pboxAceptarEditar.Visible = false;
            pboxAceptarAgregar.Visible = true;
        }

        private void pboxEditar_Click(object sender, EventArgs e)
        {
            pboxAceptarAgregar.Visible = false;
            pboxAceptarEditar.Visible = true;
            // Obtener el producto seleccionado
            if (dtgvListaProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgvListaProductos.SelectedRows[0];
                txtCodigo.Text = filaSeleccionada.Cells[0].Value.ToString();
                txtNombre.Text = filaSeleccionada.Cells[1].Value.ToString();
                txtCantidad.Text = filaSeleccionada.Cells[2].Value.ToString();
                txtCantidadMinima.Text = filaSeleccionada.Cells[3].Value.ToString();
                cboxUdMedidas.SelectedItem = filaSeleccionada.Cells[4].Value.ToString();
                txtCosto.Text = filaSeleccionada.Cells[5].Value.ToString();
                txtPrecio.Text = filaSeleccionada.Cells[6].Value.ToString();
                cboxSiYNo.SelectedItem = filaSeleccionada.Cells[7].Value.ToString();

                pnlDesplegar.Visible = true;
            }
        }

        private void pboxCancelar_Click(object sender, EventArgs e)
        {
            pnlDesplegar.Visible = false;
        }

        private void dtgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        // Método para verificar si un código ya existe en el archivo CSV
        private bool VerificarCodigoExistente(string codigo)
        {
            bool codigoExistente = false;
            try
            {
                using (StreamReader sr = new StreamReader(NOMBRE_ARCHIVO))
                {
                    sr.ReadLine(); // Saltar la primera línea (encabezado)
                    while (!sr.EndOfStream)
                    {
                        string[] campos = sr.ReadLine().Split(',');
                        if (campos[0] == codigo)
                        {
                            codigoExistente = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo CSV: {ex.Message}", "Error de Lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return codigoExistente;
        }

        // Método para obtener el código más alto en el archivo CSV
        private int ObtenerCodigoMasAlto()
        {
            int maxCodigo = 0;
            try
            {
                using (StreamReader sr = new StreamReader(NOMBRE_ARCHIVO))
                {
                    sr.ReadLine(); // Saltar la primera línea (encabezado)
                    while (!sr.EndOfStream)
                    {
                        string[] campos = sr.ReadLine().Split(',');
                        if (int.TryParse(campos[0], out int codigo))
                        {
                            if (codigo > maxCodigo)
                            {
                                maxCodigo = codigo;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo CSV: {ex.Message}", "Error de Lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return maxCodigo;
        }

        private void pboxAceptarAgregar_Click(object sender, EventArgs e)
        {
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
                }
            }

        }

        private void pboxEliminar_Click(object sender, EventArgs e)
        {
            // Eliminar el producto seleccionado
            if (dtgvListaProductos.SelectedRows.Count > 0)
            {
                DialogResult confirmResult = MessageBox.Show("¿Estás seguro de que quieres eliminar este producto?",
                                                             "Confirmar Eliminación",
                                                             MessageBoxButtons.YesNo,
                                                             MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    DataGridViewRow filaSeleccionada = dtgvListaProductos.SelectedRows[0];
                    string codigo = filaSeleccionada.Cells[0].Value.ToString();
                    EliminarProductoDeCSV(codigo);

                    // Volver a cargar los productos en el DataGridView
                    CargarProductosEnDataGridView();
                    LimpiarCasillas();
                }
            }
        }
        private void EliminarProductoDeCSV(string codigo)
        {
            var lineas = File.ReadAllLines(NOMBRE_ARCHIVO);
            var lineasAGuardar = lineas.Where(linea => !linea.StartsWith(codigo + ","));
            File.WriteAllLines(NOMBRE_ARCHIVO, lineasAGuardar);
        }

        private void txtCantidadMinima_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

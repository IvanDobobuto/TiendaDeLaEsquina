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

namespace sistemaCompra
{
    public partial class CtrlCliente : Form
    {
        private string path = "clientes.csv";
        private string cedulaSeleccionada;

        public CtrlCliente()
        {
            InitializeComponent();
            VerificarSiArchivoExiste();
            // Asignar eventos de teclado para validación de entrada
            txtIdentificacion.KeyPress += new KeyPressEventHandler(ValidarNumerosEnteros);
            txtTelefono.KeyPress += new KeyPressEventHandler(ValidarNumerosEnteros);

            // Asignar eventos de ajuste de nombre y apellido
            txtNombre.Leave += new EventHandler(txtNombre_Leave);
            txtApellido.Leave += new EventHandler(txtApellido_Leave);

            // Asignar eventos de validación de caracteres para nombre y apellido
            txtNombre.KeyPress += new KeyPressEventHandler(txtNombre_KeyPress);
            txtApellido.KeyPress += new KeyPressEventHandler(txtApellido_KeyPress);

            Image imgEditar = Image.FromFile("VentasEditar.png");
            Image imgEliminar = Image.FromFile("ControlEliminar.png");

            // Agregar columna de botón de edición con imagen
            DataGridViewImageColumn editarImageColumn = new DataGridViewImageColumn();
            editarImageColumn.HeaderText = "Editar";
            editarImageColumn.Image = imgEditar;
            editarImageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Ajusta la imagen al tamaño de la celda
            dtgvListaClientes.Columns.Add(editarImageColumn);

            // Agregar columna de botón de eliminación con imagen
            DataGridViewImageColumn eliminarImageColumn = new DataGridViewImageColumn();
            eliminarImageColumn.HeaderText = "Eliminar";
            eliminarImageColumn.Image = imgEliminar;
            eliminarImageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Ajusta la imagen al tamaño de la celda
            dtgvListaClientes.Columns.Add(eliminarImageColumn);
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox.Text.ToLower());
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox.Text.ToLower());
        }

        private void ValidarNumerosEnteros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '(' && e.KeyChar != ')')
            {
                e.Handled = true;
            }
        }

        private void VerificarSiArchivoExiste()
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Cedula,Nombre,Apellido,Direccion,Numero telefono,Correo electronico,Tipo documento,Contribuyente especial");
                }
            }
        }

        private void CtrlCliente_Load(object sender, EventArgs e)
        {
            pnlDesplegar.Visible = false;
            dtgvListaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Cargar datos en DataGridView
            CargarDatosEnDataGridView();

        }
        private void RefrescarDataGridView()
        {
            CargarDatosEnDataGridView();
        }

        private void CargarDatosEnDataGridView()
        {
            DataTable dt = new DataTable();

            // Leer el archivo y cargar los datos en el DataTable
            using (StreamReader sr = new StreamReader(path))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                }

                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }
            }

            // Asignar DataTable a DataGridView
            dtgvListaClientes.DataSource = dt;
        }

        private void pboxAgregar_Click(object sender, EventArgs e)
        {
            pnlDesplegar.Visible = true;
            pboxAceptarEditar.Visible = false;
            pboxCancelar.Visible = false;

            {
                if (CamposEstanCompletos())
                {
                    string cedula = txtIdentificacion.Text;
                    string tipoDocumento = cboxTipoIdentificacion.Text;

                    if (!VerificarCedulaUnica(cedula, tipoDocumento))
                    {
                        MessageBox.Show("La cédula ya está en uso para el tipo de documento indicado.");
                        return;
                    }

                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    string direccion = txtDireccion.Text;
                    string telefono = txtTelefono.Text;
                    string correo = txtCorreo.Text;
                    string contribuyenteEspecial = cboxSiYNo.Text;

                    AgregarClienteAlArchivo(cedula, nombre, apellido, direccion, telefono, correo, tipoDocumento, contribuyenteEspecial);

                    // Limpiar campos después de agregar un cliente
                    LimpiarCampos();
                    CargarDatosEnDataGridView();
                }
                else
                {
                    MessageBox.Show("Por favor complete todos los campos antes de agregar un cliente.");
                }
            }
        }

        private void CargarDatosClienteSeleccionado(string cedula)
        {
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] datos = line.Split(',');
                        if (datos[0] == cedula)
                        {
                            txtIdentificacion.Text = datos[0];
                            txtNombre.Text = datos[1];
                            txtApellido.Text = datos[2];
                            txtDireccion.Text = datos[3];
                            txtTelefono.Text = datos[4];
                            txtCorreo.Text = datos[5];
                            cboxTipoIdentificacion.SelectedItem = datos[6];
                            cboxSiYNo.SelectedItem = datos[7];
                            break;
                        }
                    }
                }
            }
        }

        private void pboxCancelar_Click(object sender, EventArgs e)
        {
            pnlDesplegar.Visible = false;
            LimpiarCampos();
        }

        private void pboxAceptarEditar_Click(object sender, EventArgs e)
        {
            if (CamposEstanCompletos())
            {
                string cedula = txtIdentificacion.Text;
                string tipoDocumento = cboxTipoIdentificacion.Text;

                if (!VerificarCedulaUnica(cedula, tipoDocumento, true, cedulaSeleccionada))
                {
                    MessageBox.Show("La cédula ya está en uso para el tipo de documento indicado al editar.");
                    return;
                }

                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string direccion = txtDireccion.Text;
                string telefono = txtTelefono.Text;
                string correo = txtCorreo.Text;
                string contribuyenteEspecial = cboxSiYNo.Text;

                EditarClienteEnArchivo(cedula, nombre, apellido, direccion, telefono, correo, tipoDocumento, contribuyenteEspecial);

                // Limpiar campos después de editar un cliente
                LimpiarCampos();
                RefrescarDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos antes de editar un cliente.");
            }
        }
        private void EditarClienteEnArchivo(string cedula, string nombre, string apellido, string direccion, string telefono, string correo, string tipoDocumento, string contribuyenteEspecial)
        {
            // Convertir a booleano y luego a minúsculas
            string contribuyenteBoolString = contribuyenteEspecial.Equals("Si", StringComparison.OrdinalIgnoreCase) ? "true" : "false";

            try
            {
                string[] lines = File.ReadAllLines(path);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] datos = lines[i].Split(',');
                    if (datos[0] == cedula)
                    {
                        lines[i] = $"{cedula},{nombre},{apellido},{direccion},{telefono},{correo},{tipoDocumento},{contribuyenteBoolString}";
                        break;
                    }
                }
                File.WriteAllLines(path, lines);
                MessageBox.Show("Cliente editado con éxito.");

                CargarDatosEnDataGridView(); // Actualizar DataGridView después de editar un cliente
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar cliente: {ex.Message}");
            }
        }

        private void AgregarClienteAlArchivo(string cedula, string nombre, string apellido, string direccion, string telefono, string correo, string tipoDocumento, string contribuyenteEspecial)
        {
            // Convertir a booleano y luego a minúsculas
            string contribuyenteBoolString = contribuyenteEspecial.Equals("Si", StringComparison.OrdinalIgnoreCase) ? "true" : "false";

            try
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine($"{cedula},{nombre},{apellido},{direccion},{telefono},{correo},{tipoDocumento},{contribuyenteBoolString}");
                }

                MessageBox.Show("Cliente agregado con éxito.");

                CargarDatosEnDataGridView(); // Actualizar DataGridView después de agregar un cliente
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar cliente: {ex.Message}");
            }
        }
        private bool VerificarCedulaUnica(string cedula, string tipoDocumento, bool edicion = false, string cedulaActual = "")
        {
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] datos = line.Split(',');
                        if (!edicion && datos[0] == cedula && datos[6] == tipoDocumento)
                        {
                            return false; // Cedula ya existe para el mismo tipo de documento al agregar
                        }
                        else if (edicion && datos[0] == cedulaActual && datos[6] == tipoDocumento)
                        {
                            continue; // Omitir la comparación de cédula al editar
                        }
                    }
                }
            }
            return true;
        }

        private bool CamposEstanCompletos()
        {
            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) || cboxTipoIdentificacion.SelectedItem == null || cboxSiYNo.SelectedItem == null)
            {
                return false;
            }
            return true;
        }
        private void LimpiarCampos()
        {
            txtIdentificacion.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            cboxTipoIdentificacion.SelectedIndex = -1;
            cboxSiYNo.SelectedIndex = -1;
        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboxTipoIdentificacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboxSiYNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgvListaClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvListaClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvListaClientes.SelectedRows[0];
                cedulaSeleccionada = selectedRow.Cells["Cedula"].Value.ToString();
                CargarDatosClienteSeleccionado(cedulaSeleccionada);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CargarDatosClienteParaEdicion(string cedula)
        {
            pboxCancelar.Visible = true;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    sr.ReadLine(); // Saltar la primera línea (encabezado)
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] campos = line.Split(',');
                        if (campos[0] == cedula)
                        {
                            txtIdentificacion.Text = campos[0];
                            txtNombre.Text = campos[1];
                            txtApellido.Text = campos[2];
                            txtDireccion.Text = campos[3];
                            txtTelefono.Text = campos[4];
                            txtCorreo.Text = campos[5];
                            cboxTipoIdentificacion.SelectedItem = campos[6];
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

        private void EliminarClienteDeArchivo(string cedula)
        {
            try
            {
                string tempFile = Path.GetTempFileName();
                var linesToKeep = File.ReadLines(path).Where(l => !l.StartsWith(cedula + ","));
                File.WriteAllLines(tempFile, linesToKeep);
                File.Delete(path);
                File.Move(tempFile, path);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el cliente: {ex.Message}", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgvListaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dgv = sender as DataGridView;
                if (e.ColumnIndex >= 0 && e.ColumnIndex < dgv.Columns.Count)
                {
                    if (dgv.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                    {
                        string cedulaValue = dgv.Rows[e.RowIndex].Cells["Cedula"].Value.ToString();
                        string nombreCliente = dgv.Rows[e.RowIndex].Cells["Nombre"].Value.ToString(); // Obtener el nombre del cliente
                        if (dgv.Columns[e.ColumnIndex].HeaderText.Equals("Editar"))
                        {
                            string cedula = dgv.Rows[e.RowIndex].Cells["Cedula"].Value.ToString();
                            CargarDatosClienteParaEdicion(cedula);
                        }
                        else if (dgv.Columns[e.ColumnIndex].HeaderText.Equals("Eliminar"))
                        {
                            var confirmResult = MessageBox.Show($"¿Estás seguro de que deseas eliminar al cliente '{nombreCliente}'?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                            if (confirmResult == DialogResult.Yes)
                            {
                                EliminarClienteDeArchivo(cedulaValue);
                                MessageBox.Show("Cliente eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CargarDatosEnDataGridView();
                                LimpiarCampos();
                                pboxAceptarEditar.Visible = false;
                                pboxCancelar.Visible = false;
                            }
                        }
                    }
                }
            }
        }
    }
}

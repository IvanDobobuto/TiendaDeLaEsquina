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

            // Asociar evento SelectionChanged al DataGridView
            dtgvListaClientes.SelectionChanged += new EventHandler(dtgvListaClientes_SelectionChanged);
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
            // Cargar datos en DataGridView
            CargarDatosEnDataGridView();
            dtgvListaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvListaClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // Ocultar columnas específicas
            OcultarColumnasNoDeseadas();
        }
        private void OcultarColumnasNoDeseadas()
        {
            List<string> columnasDeseadas = new List<string> { "Cedula", "Nombre", "TipoDocumento" };

            foreach (DataGridViewColumn columna in dtgvListaClientes.Columns)
            {
                if (columnasDeseadas.Contains(columna.Name))
                {
                    columna.Visible = true;
                }
                else
                {
                    columna.Visible = false;
                }
            }
        }
        private void RefrescarDataGridView()
        {
            dtgvListaClientes.DataSource = null;
            dtgvListaClientes.Rows.Clear();
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

            // Agregar la columna Tipo de Documento si no existe
            if (!dt.Columns.Contains("TipoDocumento"))
            {
                dt.Columns.Add("TipoDocumento", typeof(string));
            }

            // Actualizar el valor de la columna TipoDocumento en cada fila
            foreach (DataRow row in dt.Rows)
            {
                row["TipoDocumento"] = row["Tipo documento"];
            }

            // Asignar DataTable a DataGridView
            dtgvListaClientes.DataSource = dt;

            // Mostrar la columna TipoDocumento
            if (dtgvListaClientes.Columns.Contains("TipoDocumento"))
            {
                dtgvListaClientes.Columns["TipoDocumento"].Visible = true;
            }
        }

        private void pboxAgregar_Click(object sender, EventArgs e)
        {
            pnlDesplegar.Visible = true;
            LimpiarCampos();
            pboxAceptarAgregar.Visible = true;
            pboxAceptarEditar.Visible = false;
        }

        private void pboxEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cedulaSeleccionada))
            {
                pnlDesplegar.Visible = true;
                pboxAceptarAgregar.Visible = false;
                pboxAceptarEditar.Visible = true;

                // Cargar los campos del cliente seleccionado en los controles correspondientes
                CargarDatosClienteSeleccionado(cedulaSeleccionada);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente para editar.");
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
        }

        private void pboxEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cedulaSeleccionada))
            {
                DialogResult confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    EliminarClienteDeArchivo(cedulaSeleccionada);
                    CargarDatosEnDataGridView(); // Volver a cargar los datos en el DataGridView después de la eliminación
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente para eliminar.");
            }
            RefrescarDataGridView();
            // Ocultar columnas no deseadas después de eliminar
            OcultarColumnasNoDeseadas();
            LimpiarCampos();
        }

        private void EliminarClienteDeArchivo(string cedula)
        {
            try
            {
                List<string> lines = new List<string>(File.ReadAllLines(path));
                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (string line in lines)
                    {
                        if (!line.StartsWith(cedula))
                        {
                            sw.WriteLine(line);
                        }
                    }
                }
                MessageBox.Show("Cliente eliminado con éxito.");

                CargarDatosEnDataGridView(); // Actualizar DataGridView después de eliminar un cliente
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar cliente: {ex.Message}");
            }
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
                // Ocultar columnas no deseadas después de editar
                OcultarColumnasNoDeseadas();
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
        private void pboxAceptarAgregar_Click(object sender, EventArgs e)
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
                RefrescarDataGridView();
                // Ocultar columnas no deseadas después de agregar
                OcultarColumnasNoDeseadas();
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos antes de agregar un cliente.");
            }
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
    }
}

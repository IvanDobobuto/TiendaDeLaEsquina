using iTextSharp.text.pdf.codec.wmf;
using Microsoft.VisualBasic.Logging;
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
    public partial class CtrlUsuario : Form
    {
        private List<Usuario> usuarios = new List<Usuario>();
        private string filePath = "usuarios.csv";

        public CtrlUsuario()
        {
            InitializeComponent();
            VerificarArchivo();
            ConfigurarDataGridView();
            LoadData();
        }
        private void ConfigurarDataGridView()
        {
            dtgvListaUsuarios.ColumnCount = 3;
            dtgvListaUsuarios.Columns[0].Name = "Nombre de Usuario";
            dtgvListaUsuarios.Columns[1].Name = "Contraseña";
            dtgvListaUsuarios.Columns[2].Name = "Tipo de Usuario";

            dtgvListaUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvListaUsuarios.MultiSelect = false;
            dtgvListaUsuarios.AutoGenerateColumns = false;

            // Ajustar el tamaño de las columnas automáticamente
            dtgvListaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ajustar el tamaño de las filas automáticamente
            dtgvListaUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dtgvListaUsuarios.AllowUserToResizeRows = false;
        }
        private void LoadData()
        {
            dtgvListaUsuarios.Rows.Clear(); // Limpiar filas existentes si las hay
            List<string> nombresUsuarios = new List<string>(); // Lista para almacenar nombres de usuario existentes

            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    bool isFirstLine = true; // Bandera para identificar la primera línea

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (isFirstLine)
                        {
                            isFirstLine = false;
                            continue; // Omitir la primera línea si contiene encabezados
                        }

                        if (values.Length >= 3 && values[2].Trim().ToLower() == "cajero") // Verificar el tipo de usuario
                        {
                            string nombreUsuario = values[0];
                            string password = values[1];
                            string tipoUsuario = values[2];

                            // Verificar si el nombre de usuario ya existe en la lista
                            int existingRowIndex = -1;
                            for (int i = 0; i < dtgvListaUsuarios.Rows.Count; i++)
                            {
                                if (dtgvListaUsuarios.Rows[i].Cells[0].Value != null && dtgvListaUsuarios.Rows[i].Cells[0].Value.ToString() == nombreUsuario)
                                {
                                    existingRowIndex = i;
                                    break;
                                }
                            }

                            // Si el nombre de usuario ya existe, actualizar la fila, de lo contrario, agregar una nueva fila
                            if (existingRowIndex != -1)
                            {
                                dtgvListaUsuarios.Rows[existingRowIndex].SetValues(nombreUsuario, password, tipoUsuario);
                            }
                            else
                            {
                                dtgvListaUsuarios.Rows.Add(values);
                                nombresUsuarios.Add(nombreUsuario);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }

        // Función para verificar la existencia del archivo CSV
        private void VerificarArchivo()
        {
            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine("Nombre de Usuario,Contraseña,Tipo de Usuario");
                }
            }
        }

        private void CtrlUsuario_Load(object sender, EventArgs e)
        {
            pnlDesplegar.Visible = false;
            LoadData();
        }

        private void pboxAgregar_Click(object sender, EventArgs e)
        {
            // Limpiar los campos de entrada
            txtNombre.Text = "";
            txtPassword.Text = "";
            txtConfirmarPassword.Text = "";
            pboxAceptarAgregar.Visible = true;
            pnlDesplegar.Visible = true;
            pboxAceptarEditar.Visible = false;
        }

        private void pboxEditar_Click(object sender, EventArgs e)
        {
            if (dtgvListaUsuarios.SelectedRows.Count > 0)
            {
                pboxAceptarEditar.Visible = true;
                pnlDesplegar.Visible = true;
                pboxAceptarAgregar.Visible = false;

                // Obtener los valores de la fila seleccionada
                string nombreUsuario = dtgvListaUsuarios.SelectedRows[0].Cells[0].Value.ToString();
                string password = dtgvListaUsuarios.SelectedRows[0].Cells[1].Value.ToString();
                string tipoUsuario = dtgvListaUsuarios.SelectedRows[0].Cells[2].Value.ToString();

                // Cargar los valores en los campos de texto
                txtNombre.Text = nombreUsuario;
                txtPassword.Text = password;
                txtConfirmarPassword.Text = password; // Mostrar la contraseña actual en el campo de confirmación de contraseña, ya que no se cambió
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para editar.");
            }
        }

        private void pboxCancelar_Click(object sender, EventArgs e)
        {
            pnlDesplegar.Visible = false;
        }

        private void pboxEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvListaUsuarios.SelectedRows.Count > 0)
            {
                string nombreUsuario = dtgvListaUsuarios.SelectedRows[0].Cells[0].Value.ToString();

                // Mostrar un cuadro de diálogo de confirmación
                DialogResult result = MessageBox.Show($"¿Está seguro de que desea eliminar el usuario {nombreUsuario}?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Eliminar el usuario del archivo CSV
                        var lines = File.ReadAllLines(filePath).ToList();
                        for (int i = 1; i < lines.Count; i++)
                        {
                            var values = lines[i].Split(',');
                            if (values.Length >= 3 && values[0].Trim().ToLower() == nombreUsuario.ToLower())
                            {
                                lines.RemoveAt(i);
                                File.WriteAllLines(filePath, lines);
                                break;
                            }
                        }

                        // Actualizar el DataGridView
                        LoadData();

                        MessageBox.Show("Usuario eliminado con éxito.");
                        pnlDesplegar.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar el usuario: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.");
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmarPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pboxAceptarEditar_Click(object sender, EventArgs e)
        {
            if (dtgvListaUsuarios.SelectedRows.Count > 0)
            {
                string nombre = txtNombre.Text;
                string newPassword = txtPassword.Text;
                string confirmNewPassword = txtConfirmarPassword.Text;
                string tipoUsuario = "Cajero"; // Puedes ajustar esto según tus necesidades

                // Validar si los campos no están vacíos y si las contraseñas coinciden
                if (!string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(newPassword) && !string.IsNullOrWhiteSpace(confirmNewPassword))
                {
                    if (newPassword == confirmNewPassword)
                    {
                        if (newPassword.Length >= 4) // Verificar la longitud de la contraseña
                        {
                            try
                            {
                                var lines = File.ReadAllLines(filePath);
                                string selectedNombre = dtgvListaUsuarios.SelectedRows[0].Cells[0].Value.ToString();

                                for (int i = 1; i < lines.Length; i++)
                                {
                                    var values = lines[i].Split(',');
                                    if (values.Length >= 3 && values[0].Trim().ToLower() == selectedNombre.ToLower())
                                    {
                                        lines[i] = $"{nombre},{newPassword},{tipoUsuario}";
                                        File.WriteAllLines(filePath, lines);
                                        LoadData(); // Vuelve a cargar los datos actualizados
                                        pnlDesplegar.Visible = false;
                                        MessageBox.Show("Usuario editado con éxito.");
                                        pnlDesplegar.Visible = false;
                                        return;
                                    }
                                }

                                MessageBox.Show("Error: No se pudo encontrar el usuario seleccionado en el archivo CSV.");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error al editar el usuario: {ex.Message}");
                            }
                        }
                        else
                        {
                            MessageBox.Show("La contraseña debe tener al menos 4 caracteres.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden. Por favor, inténtelo de nuevo.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para editar.");
            }
        }

        private void pboxAceptarAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string password = txtPassword.Text;
            string confirmarPassword = txtConfirmarPassword.Text;
            string tipoUsuario = "Cajero"; // Puedes ajustar esto según tus necesidades

            // Validar si los campos no están vacíos, si las contraseñas coinciden y si la contraseña tiene al menos 4 caracteres
            if (!string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(password) && !string.IsNullOrWhiteSpace(confirmarPassword))
            {
                if (password == confirmarPassword)
                {
                    if (password.Length >= 4) // Verificar la longitud de la contraseña
                    {
                        // Agregar usuario a la lista local
                        usuarios.Add(new Usuario { Nombre = nombre, Password = password, Tipo = tipoUsuario });

                        // Agregar usuario al archivo CSV
                        using (StreamWriter sw = File.AppendText(filePath))
                        {
                            sw.WriteLine($"{nombre},{password},{tipoUsuario}");
                        }

                        // Actualizar el DataGridView
                        LoadData();

                        // Limpiar los campos de entrada
                        txtNombre.Text = "";
                        txtPassword.Text = "";
                        txtConfirmarPassword.Text = "";
                        MessageBox.Show("Usuario agregado con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("La contraseña debe tener al menos 4 caracteres.");
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden. Por favor, inténtelo de nuevo.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
        }

        private void dtgvListaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public class Usuario
        {
            public string Nombre { get; set; }
            public string Password { get; set; }
            public string Tipo { get; set; }
        }
    }
}

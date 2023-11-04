using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace sistemaCompra
{
    public partial class CtrlUsuario : Form
    {
        private List<Usuario> usuarios = new List<Usuario>();
        private const string filePath = "usuarios.csv";
        private const string tipoUsuarioDefault = "Cajero";

        public CtrlUsuario()
        {
            InitializeComponent();
            VerificarArchivo();
            ConfigurarDataGridView();
            LoadData();
        }
        private void ConfigurarDataGridView()
        {
            dtgvListaUsuarios.ColumnCount = 6; // Aumentar el recuento de columnas a 6
            dtgvListaUsuarios.Columns[0].Name = "Editar"; // Nombres de las nuevas columnas
            dtgvListaUsuarios.Columns[1].Name = "Eliminar";
            dtgvListaUsuarios.Columns[2].Name = "Nombre de Usuario";
            dtgvListaUsuarios.Columns[3].Name = "Correo Electrónico";
            dtgvListaUsuarios.Columns[4].Name = "Contraseña";
            dtgvListaUsuarios.Columns[5].Name = "Tipo de Usuario";


            // Ajustar el estilo de las celdas
            dtgvListaUsuarios.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Ajustar la altura de las filas
            dtgvListaUsuarios.RowTemplate.Height = 30;
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

                        if (values.Length >= 4 && values[3].Trim().ToLower() == "cajero") // Verificar el tipo de usuario
                        {
                            string nombreUsuario = values[0];
                            string correoElectronico = values[1];
                            string password = values[2];
                            string tipoUsuario = values[3];

                            // Verificar si el nombre de usuario ya existe en la lista
                            int existingRowIndex = -1;
                            for (int i = 0; i < dtgvListaUsuarios.Rows.Count; i++)
                            {
                                if (dtgvListaUsuarios.Rows[i].Cells[2].Value != null && dtgvListaUsuarios.Rows[i].Cells[2].Value.ToString() == nombreUsuario)
                                {
                                    existingRowIndex = i;
                                    break;
                                }
                            }

                            // Si el nombre de usuario ya existe, actualizar la fila, de lo contrario, agregar una nueva fila
                            if (existingRowIndex != -1)
                            {
                                dtgvListaUsuarios.Rows[existingRowIndex].SetValues("Editar", "Eliminar", nombreUsuario, correoElectronico, password, tipoUsuario);
                            }
                            else
                            {
                                dtgvListaUsuarios.Rows.Add("Editar", "Eliminar", nombreUsuario, correoElectronico, password, tipoUsuario);
                                nombresUsuarios.Add(nombreUsuario);
                            }
                        }
                    }

                    // Obtener la ruta del directorio del programa
                    string directoryPath = AppDomain.CurrentDomain.BaseDirectory;

                    // Agregar botones de edición y eliminación a cada fila
                    for (int i = 0; i < dtgvListaUsuarios.Rows.Count; i++)
                    {
                        // Botón de Edición
                        DataGridViewImageCell imgEdit = new DataGridViewImageCell();
                        string imagePathEdit = Path.Combine(directoryPath, "Edicion.png");
                        Image imageEdit = Image.FromFile(imagePathEdit);
                        imgEdit.Value = imageEdit;
                        imgEdit.ImageLayout = DataGridViewImageCellLayout.Zoom; // Ajustar el diseño de la imagen
                        imgEdit.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centrar la imagen
                        dtgvListaUsuarios.Rows[i].Cells[0] = imgEdit;

                        // Botón de Eliminación
                        DataGridViewImageCell imgDelete = new DataGridViewImageCell();
                        string imagePathDelete = Path.Combine(directoryPath, "Eliminacion.png");
                        Image imageDelete = Image.FromFile(imagePathDelete);
                        imgDelete.Value = imageDelete;
                        imgDelete.ImageLayout = DataGridViewImageCellLayout.Zoom; // Ajustar el diseño de la imagen
                        imgDelete.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centrar la imagen
                        dtgvListaUsuarios.Rows[i].Cells[1] = imgDelete;
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
                    sw.WriteLine("Nombre de Usuario,Correo Electronico,Password,Tipo de Usuario");
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
            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text; // Agregar el correo electrónico del TextBox correspondiente
            string password = txtPassword.Text;
            string confirmarPassword = txtConfirmarPassword.Text;
            string tipoUsuario = "Cajero"; // Puedes ajustar esto según tus necesidades

            // Validar si los campos no están vacíos, si las contraseñas coinciden y si la contraseña tiene al menos 4 caracteres
            if (!string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(correo) && !string.IsNullOrWhiteSpace(password) && !string.IsNullOrWhiteSpace(confirmarPassword))
            {
                if (password == confirmarPassword)
                {
                    if (password.Length >= 4) // Verificar la longitud de la contraseña
                    {
                        // Agregar usuario a la lista local
                        usuarios.Add(new Usuario { Nombre = nombre, Correo = correo, Password = password, Tipo = tipoUsuario }); // Agregar el correo electrónico

                        // Agregar usuario al archivo CSV
                        using (StreamWriter sw = File.AppendText(filePath))
                        {
                            sw.WriteLine($"{nombre},{correo},{password},{tipoUsuario}"); // Agregar el correo electrónico al archivo CSV
                        }

                        // Actualizar el DataGridView
                        LoadData();

                        // Limpiar los campos de entrada
                        txtNombre.Text = "";
                        txtPassword.Text = "";
                        txtConfirmarPassword.Text = "";
                        txtCorreo.Text = "";
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

        private void pboxCancelar_Click(object sender, EventArgs e)
        {
            pnlDesplegar.Visible = false;
            // Limpiar los campos de entrada
            txtNombre.Text = "";
            txtPassword.Text = "";
            txtConfirmarPassword.Text = "";
            txtCorreo.Text = "";
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
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text) && !string.IsNullOrWhiteSpace(txtConfirmarPassword.Text) && !string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                string nombre = txtNombre.Text;
                string newPassword = txtPassword.Text;
                string confirmNewPassword = txtConfirmarPassword.Text;
                string tipoUsuario = "Cajero"; // Puedes ajustar esto según tus necesidades

                if (newPassword == confirmNewPassword)
                {
                    if (newPassword.Length >= 4)
                    {
                        bool usuarioEncontrado = false;
                        string[] lines = File.ReadAllLines(filePath);
                        for (int i = 1; i < lines.Length; i++)
                        {
                            string[] values = lines[i].Split(',');
                            if (values.Length >= 3 && values[0].Trim().ToLower() == nombre.ToLower())
                            {
                                lines[i] = $"{nombre},{txtCorreo.Text},{newPassword},{tipoUsuario}";
                                usuarioEncontrado = true;
                                File.WriteAllLines(filePath, lines);
                                LoadData();
                                pnlDesplegar.Visible = false;
                                MessageBox.Show("Usuario editado con éxito.");
                                // Limpiar los campos de entrada
                                txtNombre.Text = "";
                                txtPassword.Text = "";
                                txtConfirmarPassword.Text = "";
                                txtCorreo.Text = "";
                                break;
                            }
                        }

                        if (!usuarioEncontrado)
                        {
                            MessageBox.Show("No se encontró ningún usuario con ese nombre. Por favor, intente con un nombre de usuario existente.");
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



        private void dtgvListaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgvListaUsuarios.Rows.Count - 1) // Verificar si la fila seleccionada es válida y no es la última fila vacía
            {
                DataGridViewRow row = dtgvListaUsuarios.Rows[e.RowIndex]; // Obtener la fila seleccionada
                if (row.Cells[0].Value != null && row.Cells[1].Value != null) // Verificar si las celdas no son nulas
                {
                    string nombreUsuario = row.Cells[2].Value.ToString();
                    string correoElectronico = row.Cells[3].Value.ToString();
                    string password = row.Cells[4].Value.ToString();
                    string tipoUsuario = row.Cells[5].Value.ToString();

                    // Cargar los valores en los campos de texto
                    txtNombre.Text = nombreUsuario;
                    txtCorreo.Text = correoElectronico;
                    txtPassword.Text = password;
                    txtConfirmarPassword.Text = password; // Mostrar la contraseña actual en el campo de confirmación de contraseña, ya que no se cambió
                    pnlDesplegar.Visible = true;
                    pboxAceptarEditar.Visible = true;
                }
            

            // Verificar si se hizo clic en la columna de Eliminación
            if (e.ColumnIndex == 1)
                {
                    string nombreUsuario = dtgvListaUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();

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
                                    LoadData(); // Vuelve a cargar los datos actualizados
                                    MessageBox.Show($"Usuario {nombreUsuario} eliminado con éxito.");
                                    pnlDesplegar.Visible = false;
                                    txtNombre.Text = "";
                                    txtPassword.Text = "";
                                    txtConfirmarPassword.Text = "";
                                    txtCorreo.Text = "";
                                    return;
                                }
                            }
                            MessageBox.Show("Error: No se pudo encontrar el usuario seleccionado en el archivo CSV.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al eliminar el usuario: {ex.Message}");
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        // No hacer nada si se selecciona "No"
                    }
                }
            }
        }
        public class Usuario
        {
            public string Nombre { get; set; }
            public string Correo { get; set; }
            public string Password { get; set; }
            public string Tipo { get; set; }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

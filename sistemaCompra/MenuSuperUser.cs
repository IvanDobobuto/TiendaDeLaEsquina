using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sistemaCompra
{
    public partial class MenuSuperUser : Form
    {
        public MenuSuperUser()
        {
            InitializeComponent();
        }

        private void MenuSuperUser_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void MenuSuperUser_Load(object sender, EventArgs e)
        {
            pnlMostrarMensaje.Visible = false;
        }

        private void pboxCancelar_Click(object sender, EventArgs e)
        {
            pnlMostrarMensaje.Visible = false;
        }

        private void pboxReseteoUsuarios_Click(object sender, EventArgs e)
        {
            pboxAceptarPassword.Visible = true;
            pboxAceptarResetDatos.Visible = false;
            pboxResetFabrica.Visible = false;
            pnlMostrarMensaje.Visible = true;
            txtMensaje.Text = "¿Estás seguro de resetar las contraseñas? Se perderán los datos de Usuario.";
        }

        private void pboxReseteoDatos_Click(object sender, EventArgs e)
        {
            pboxAceptarResetDatos.Visible = true;
            pboxAceptarPassword.Visible = false;
            pboxResetFabrica.Visible = false;
            pnlMostrarMensaje.Visible = true;
            txtMensaje.Text = "¿Estás seguro de resetear los datos? Se perderán los datos de Producto y Cliente.";
        }

        private void pboxReseteoFabrica_Click(object sender, EventArgs e)
        {
            pboxResetFabrica.Visible = true;
            pboxAceptarPassword.Visible = false;
            pboxAceptarResetDatos.Visible = false;
            pnlMostrarMensaje.Visible = true;
            txtMensaje.Text = "¿Estás seguro de resetear el programa hasta la versión de fábrica? Se perderán todos los datos.";
        }

        private void pboxBaseUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usuarios.csv");
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pboxbaseProductos_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "inventario.csv");
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pboxBaseClientes_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "clientes.csv");
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pboxAceptarPassword_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usuarios.csv");
            string[] defaultUsers = { "Nombre de usuario,Clave,Tipo de usuario", "admin,admin,Admin", "supersu,supersu,Superuser", "cajero,cajero,Cajero" };

            try
            {
                if (File.Exists(filePath))
                {
                    // Lee el archivo y recupera la primera línea
                    string firstLine = File.ReadLines(filePath).First();

                    // Borra el archivo
                    File.WriteAllText(filePath, string.Empty);

                    // Vuelve a escribir la primera línea y los valores predeterminados
                    File.WriteAllLines(filePath, defaultUsers);
                }
                else
                {
                    // Si el archivo no existe, simplemente escribe los valores predeterminados
                    File.WriteAllLines(filePath, defaultUsers);
                }

                // Mensaje de éxito
                MessageBox.Show("Usuarios restablecidos a los valores de fábrica correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restablecer usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pboxAceptarResetDatos_Click(object sender, EventArgs e)
        {
            string inventarioFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "inventario.csv");
            string clientesFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "clientes.csv");

            try
            {
                if (File.Exists(inventarioFilePath))
                {
                    // Lee el archivo y recupera la primera línea
                    string firstLineInventario = File.ReadLines(inventarioFilePath).First();

                    // Borra el archivo excepto la primera línea
                    File.WriteAllText(inventarioFilePath, string.Empty);
                    File.AppendAllText(inventarioFilePath, firstLineInventario + Environment.NewLine);
                }

                if (File.Exists(clientesFilePath))
                {
                    // Lee el archivo y recupera la primera línea
                    string firstLineClientes = File.ReadLines(clientesFilePath).First();

                    // Borra el archivo excepto la primera línea
                    File.WriteAllText(clientesFilePath, string.Empty);
                    File.AppendAllText(clientesFilePath, firstLineClientes + Environment.NewLine);
                }

                // Mensaje de éxito
                MessageBox.Show("Datos de inventario y clientes restablecidos correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restablecer datos de inventario y clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pboxResetFabrica_Click(object sender, EventArgs e)
        {
            string usuariosFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usuarios.csv");
            string inventarioFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "inventario.csv");
            string clientesFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "clientes.csv");
            string[] defaultUsers = { "admin,admin,Admin", "supersu,supersu,Superuser", "cajero,cajero,Cajero" };

            try
            {
                // Reseteo de usuarios.csv
                if (File.Exists(usuariosFilePath))
                {
                    // Lee el archivo y recupera la primera línea
                    string firstLineUsuarios = File.ReadLines(usuariosFilePath).First();

                    // Borra el archivo y escribe los valores predeterminados
                    File.WriteAllText(usuariosFilePath, string.Empty);
                    File.AppendAllText(usuariosFilePath, firstLineUsuarios + Environment.NewLine);
                    File.AppendAllLines(usuariosFilePath, defaultUsers);
                }
                else
                {
                    // Si el archivo no existe, simplemente escribe los valores predeterminados
                    File.WriteAllLines(usuariosFilePath, defaultUsers);
                }

                // Reseteo de inventario.csv
                if (File.Exists(inventarioFilePath))
                {
                    // Lee el archivo y recupera la primera línea
                    string firstLineInventario = File.ReadLines(inventarioFilePath).First();

                    // Borra el archivo excepto la primera línea
                    File.WriteAllText(inventarioFilePath, string.Empty);
                    File.AppendAllText(inventarioFilePath, firstLineInventario + Environment.NewLine);
                }

                // Reseteo de clientes.csv
                if (File.Exists(clientesFilePath))
                {
                    // Lee el archivo y recupera la primera línea
                    string firstLineClientes = File.ReadLines(clientesFilePath).First();

                    // Borra el archivo excepto la primera línea
                    File.WriteAllText(clientesFilePath, string.Empty);
                    File.AppendAllText(clientesFilePath, firstLineClientes + Environment.NewLine);
                }

                // Mensaje de éxito
                MessageBox.Show("Datos restablecidos a los valores de fábrica correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restablecer datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

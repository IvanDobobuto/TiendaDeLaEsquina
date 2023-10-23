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
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void AgregarFormulario(Form ejemplo)
        {
            if (this.pnlMenuAdministrador.Controls.Count > 0)
                this.pnlMenuAdministrador.Controls.RemoveAt(0);
            ejemplo.TopLevel = false;
            ejemplo.Dock = DockStyle.Fill;
            this.pnlMenuAdministrador.Controls.Add(ejemplo);
            this.pnlMenuAdministrador.Tag = ejemplo;
            ejemplo.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En esta ventana se encuentran las distintas opciones \ny funcionalidades a las que tiene acceso el Administrador.");
        }

        private void controlDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<CtrlUsuario>().FirstOrDefault();
            CtrlUsuario ctrlUsuario = form ?? new CtrlUsuario();
            AgregarFormulario(ctrlUsuario);
        }

        private void controlDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<CtrlProducto>().FirstOrDefault();
            CtrlProducto ctrlProducto = form ?? new CtrlProducto();
            AgregarFormulario(ctrlProducto);
        }

        private void controlDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<CtrlCliente>().FirstOrDefault();
            CtrlCliente ctrlCliente = form ?? new CtrlCliente();
            AgregarFormulario(ctrlCliente);
        }

        private void importarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para importar usuarios, el formato a usarse debe ser el siguiente:\nNombre de usuario,Clave,Tipo de usuario");

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory; // Directorio actual del programa
            openFileDialog.Filter = "Archivos CSV|*.csv";
            openFileDialog.Title = "Seleccionar archivo CSV de usuarios";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                List<string> mensajes = new List<string>();
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    if (lines.Length > 0)
                    {
                        string firstLine = lines[0];
                        string[] headers = firstLine.Split(',');
                        if (headers.Length != 3 || headers[0] != "Nombre de usuario" || headers[1] != "Clave" || headers[2] != "Tipo de usuario")
                        {
                            MessageBox.Show("El formato del archivo no es válido. Asegúrate de que cumpla con el formato especificado.");
                            return;
                        }

                        for (int i = 1; i < lines.Length; i++) // Empezar en la segunda línea
                        {
                            string line = lines[i];
                            string[] values = line.Split(',');
                            if (values.Length == 3)
                            {
                                string nombreUsuario = values[0];
                                string clave = values[1];
                                string tipoUsuario = values[2];

                                // Agregar el usuario al archivo de usuarios.csv
                                File.AppendAllText("usuarios.csv", $"{nombreUsuario},{clave},{tipoUsuario}\n");

                                // Agregar el mensaje para la notificación
                                string mensaje = $"Nombre de Usuario: {nombreUsuario}, Clave: {clave}, Tipo de Usuario: {tipoUsuario}";
                                mensajes.Add(mensaje);
                            }
                            else
                            {
                                MessageBox.Show("El formato del archivo no es válido. Asegúrate de que cumpla con el formato especificado.");
                                return;
                            }
                        }

                        // Mostrar todos los usuarios importados en un solo mensaje
                        StringBuilder sb = new StringBuilder();
                        foreach (var mensaje in mensajes)
                        {
                            sb.AppendLine(mensaje);
                            sb.AppendLine("-------------------------------");
                        }
                        MessageBox.Show(sb.ToString(), "Usuarios Importados");
                        MessageBox.Show("Los datos se han importado con éxito. Por favor, cierre la ventana y ábrala de nuevo para actualizar la lista de usuarios.");
                    }
                    else
                    {
                        MessageBox.Show("El archivo está vacío. Asegúrate de que el archivo contenga datos.");
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error al leer el archivo: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
                }
            }
        }

        private void exportarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos CSV|*.csv";
            saveFileDialog.Title = "Guardar usuarios en archivo CSV";
            saveFileDialog.FileName = "usuarios_exportados.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Leer los contenidos del archivo 'usuarios.csv'
                    string[] lines = File.ReadAllLines("usuarios.csv");

                    // Escribir los contenidos en el nuevo archivo CSV seleccionado por el usuario
                    using (StreamWriter file = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (string line in lines)
                        {
                            file.WriteLine(line);
                        }
                    }
                    MessageBox.Show("Usuarios exportados exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al exportar los usuarios: {ex.Message}");
                }
            }
        }

        private void importarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para importar productos, el formato a usarse debe ser el siguiente:\nCodigo,Nombre,Cantidad,CantidadMinima,UnidadDeMedida,CostoUnitario,PrecioDeVenta,tieneIVA");

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory; // Directorio actual del programa
            openFileDialog.Filter = "Archivos CSV|*.csv";
            openFileDialog.Title = "Seleccionar archivo CSV";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                List<string> mensajes = new List<string>();
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    if (lines.Length > 0)
                    {
                        string firstLine = lines[0];
                        string[] headers = firstLine.Split(',');
                        if (headers.Length != 8 || headers[0] != "Codigo" || headers[1] != "Nombre" || headers[2] != "Cantidad" || headers[3] != "CantidadMinima" || headers[4] != "UnidadDeMedida" || headers[5] != "CostoUnitario" || headers[6] != "PrecioDeVenta" || headers[7] != "tieneIVA")
                        {
                            MessageBox.Show("El formato del archivo no es válido. Asegúrate de que cumpla con el formato especificado.");
                            return;
                        }

                        for (int i = 1; i < lines.Length; i++) // Empezar en la segunda línea
                        {
                            string line = lines[i];
                            string[] values = line.Split(',');
                            if (values.Length == 8)
                            {
                                string codigo = values[0];
                                string nombre = values[1];
                                int cantidad = Convert.ToInt32(values[2]);
                                int cantidadMinima = Convert.ToInt32(values[3]);
                                string unidadDeMedida = values[4];
                                decimal costoUnitario = Convert.ToDecimal(values[5]);
                                decimal precioDeVenta = Convert.ToDecimal(values[6]);
                                string tieneIVA;
                                if (values[7].Trim().Equals("SI", StringComparison.OrdinalIgnoreCase))
                                {
                                    tieneIVA = "SI";
                                }
                                else if (values[7].Trim().Equals("NO", StringComparison.OrdinalIgnoreCase))
                                {
                                    tieneIVA = "NO";
                                }
                                else
                                {
                                    throw new FormatException("El valor de tieneIVA debe ser 'SI' o 'NO'.");
                                }

                                // Agregar el producto al archivo de inventario.csv
                                using (StreamWriter file = new StreamWriter("inventario.csv", true))
                                {
                                    file.WriteLine($"{codigo},{nombre},{cantidad},{cantidadMinima},{unidadDeMedida},{costoUnitario},{precioDeVenta},{tieneIVA}");
                                }

                                // Agregar el mensaje para la notificación
                                string mensaje = $"Código: {codigo}, Nombre: {nombre}, Cantidad: {cantidad}, Cantidad Mínima: {cantidadMinima}, Unidad de Medida: {unidadDeMedida}, Costo Unitario: {costoUnitario}, Precio de Venta: {precioDeVenta}, Tiene IVA: {tieneIVA}";
                                mensajes.Add(mensaje);
                            }
                            else
                            {
                                MessageBox.Show("El formato del archivo no es válido. Asegúrate de que cumpla con el formato especificado.");
                                return;
                            }
                        }

                        // Mostrar todos los productos importados en un solo mensaje
                        StringBuilder sb = new StringBuilder();
                        foreach (var mensaje in mensajes)
                        {
                            sb.AppendLine(mensaje);
                            sb.AppendLine("-------------------------------");
                        }
                        MessageBox.Show(sb.ToString(), "Productos Importados");
                        MessageBox.Show("Los datos se han importado con éxito. Por favor, cierre la ventana y ábrala de nuevo para actualizar la lista de productos.");
                    }
                    else
                    {
                        MessageBox.Show("El archivo está vacío. Asegúrate de que el archivo contenga datos.");
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error al leer el archivo: " + ex.Message);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Error de formato en los datos del archivo: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
                }
            }
        }

        private void exportarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos CSV|*.csv";
            saveFileDialog.Title = "Guardar productos en archivo CSV";
            saveFileDialog.FileName = "productos_exportados.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Leer los contenidos del archivo 'inventario.csv'
                    string[] lines = File.ReadAllLines("inventario.csv");

                    // Escribir los contenidos en el nuevo archivo CSV seleccionado por el usuario
                    using (StreamWriter file = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (string line in lines)
                        {
                            file.WriteLine(line);
                        }
                    }
                    MessageBox.Show("Productos exportados exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al exportar los productos: {ex.Message}");
                }
            }
        }


        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para importar clientes, el formato a usarse debe ser el siguiente:\nCedula,Nombre,Apellido,Direccion,Numero telefono,Correo electronico,Tipo documento,Contribuyente especial");

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory; // Directorio actual del programa
            openFileDialog.Filter = "Archivos CSV|*.csv";
            openFileDialog.Title = "Seleccionar archivo CSV de clientes";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                List<string> mensajes = new List<string>();
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    if (lines.Length > 0)
                    {
                        string firstLine = lines[0];
                        string[] headers = firstLine.Split(',');
                        if (headers.Length != 8 || headers[0] != "Cedula" || headers[1] != "Nombre" || headers[2] != "Apellido" || headers[3] != "Direccion" || headers[4] != "Numero telefono" || headers[5] != "Correo electronico" || headers[6] != "Tipo documento" || headers[7] != "Contribuyente especial")
                        {
                            MessageBox.Show("El formato del archivo no es válido. Asegúrate de que cumpla con el formato especificado.");
                            return;
                        }

                        for (int i = 1; i < lines.Length; i++) // Empezar en la segunda línea
                        {
                            string line = lines[i];
                            string[] values = line.Split(',');
                            if (values.Length == 8)
                            {
                                string cedula = values[0];
                                string nombre = values[1];
                                string apellido = values[2];
                                string direccion = values[3];
                                string numeroTelefono = values[4];
                                string correoElectronico = values[5];
                                string tipoDocumento = values[6];
                                string contribuyenteEspecial = values[7];

                                // Agregar el cliente al archivo de clientes.csv
                                File.AppendAllText("clientes.csv", $"{cedula},{nombre},{apellido},{direccion},{numeroTelefono},{correoElectronico},{tipoDocumento},{contribuyenteEspecial}\n");

                                // Agregar el mensaje para la notificación
                                string mensaje = $"Cédula: {cedula}, Nombre: {nombre}, Apellido: {apellido}, Dirección: {direccion}, Número de Teléfono: {numeroTelefono}, Correo Electrónico: {correoElectronico}, Tipo de Documento: {tipoDocumento}, Contribuyente Especial: {contribuyenteEspecial}";
                                mensajes.Add(mensaje);
                            }
                            else
                            {
                                MessageBox.Show("El formato del archivo no es válido. Asegúrate de que cumpla con el formato especificado.");
                                return;
                            }
                        }

                        // Mostrar todos los clientes importados en un solo mensaje
                        StringBuilder sb = new StringBuilder();
                        foreach (var mensaje in mensajes)
                        {
                            sb.AppendLine(mensaje);
                            sb.AppendLine("-------------------------------");
                        }
                        MessageBox.Show(sb.ToString(), "Clientes Importados");
                        MessageBox.Show("Los datos se han importado con éxito. Por favor, cierre la ventana y ábrala de nuevo para actualizar la lista de clientes.");
                    }
                    else
                    {
                        MessageBox.Show("El archivo está vacío. Asegúrate de que el archivo contenga datos.");
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error al leer el archivo: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
                }
            }
        }

        private void exportarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos CSV|*.csv";
            saveFileDialog.Title = "Guardar clientes en archivo CSV";
            saveFileDialog.FileName = "clientes_exportados.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Leer los contenidos del archivo 'clientes.csv'
                    string[] lines = File.ReadAllLines("clientes.csv");

                    // Escribir los contenidos en el nuevo archivo CSV seleccionado por el usuario
                    using (StreamWriter file = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (string line in lines)
                        {
                            file.WriteLine(line);
                        }
                    }
                    MessageBox.Show("Clientes exportados exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al exportar los clientes: {ex.Message}");
                }
            }
        }
        private void pnlMenuAdministrador_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

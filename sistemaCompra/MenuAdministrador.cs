using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

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
        private void MostrarMensajeInstrucciones(string mensaje)
        {
            MessageBox.Show(mensaje, "Instrucciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private T ObtenerFormularioExistente<T>() where T : Form, new()
        {
            return Application.OpenForms.OfType<T>().FirstOrDefault() ?? new T();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var infoAdmin = ObtenerFormularioExistente<InfoAdmin>();
            AgregarFormulario(infoAdmin);
        }

        private void controlDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ctrlUsuario = ObtenerFormularioExistente<CtrlUsuario>();
            ctrlUsuario.Shown += (s, ev) => MostrarMensajeInstrucciones("Debe presionar el Botón + cada vez que desee agregar un nuevo usuario");
            AgregarFormulario(ctrlUsuario);
        }

        private void controlDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ctrlProducto = ObtenerFormularioExistente<CtrlProducto>();
            ctrlProducto.Shown += (s, ev) => MostrarMensajeInstrucciones("Debe presionar el Botón + cada vez que desee agregar un nuevo producto");
            AgregarFormulario(ctrlProducto);
        }

        private void controlDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ctrlCliente = ObtenerFormularioExistente<CtrlCliente>();
            ctrlCliente.Shown += (s, ev) => MostrarMensajeInstrucciones("Debe presionar el Botón + cada vez que desee agregar un nuevo cliente");
            AgregarFormulario(ctrlCliente);
        }
        private void MostrarMensajes(List<string> mensajes, string titulo)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var mensaje in mensajes)
            {
                sb.AppendLine(mensaje);
                sb.AppendLine("-------------------------------");
            }
            MessageBox.Show(sb.ToString(), titulo);
        }

        private void importarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para importar usuarios, el formato a usarse debe ser el siguiente:\nNombre de Usuario,Correo Electronico,Password,Tipo de Usuario");

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = AppDomain.CurrentDomain.BaseDirectory, // Directorio actual del programa
                Filter = "Archivos CSV|*.csv",
                Title = "Seleccionar archivo CSV de usuarios"
            };

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
                        if (headers.Length != 4 || !headers.SequenceEqual(new[] { "Nombre de Usuario", "Correo Electronico", "Password", "Tipo de Usuario" }))
                        {
                            MessageBox.Show("El formato del archivo no es válido. Asegúrate de que cumpla con el formato especificado.");
                            return;
                        }

                        var usuarios = lines.Skip(1)
                            .Select(line => line.Split(','))
                            .Where(values => values.Length == 4)
                            .Select(values =>
                            {
                                string nombreUsuario = values[0];
                                string correoElectronico = values[1];
                                string password = values[2];
                                string tipoUsuario = values[3];

                                // Agregar el usuario al archivo de usuarios.csv
                                File.AppendAllText("usuarios.csv", $"{nombreUsuario},{correoElectronico},{password},{tipoUsuario}\n");

                                // Agregar el mensaje para la notificación
                                return $"Nombre de Usuario: {nombreUsuario}, Correo Electrónico: {correoElectronico}, Password: {password}, Tipo de Usuario: {tipoUsuario}";
                            })
                            .ToList();

                        // Mostrar todos los usuarios importados en un solo mensaje
                        MostrarMensajesEnLotes(usuarios, "Usuarios Importados");
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

                        int batchSize = 10; // Tamaño del lote
                        int totalProducts = lines.Length - 1; // Excluyendo la primera línea de encabezados

                        for (int i = 1; i < totalProducts; i += batchSize)
                        {
                            var currentBatch = lines.Skip(i).Take(batchSize);
                            StringBuilder sb = new StringBuilder();
                            foreach (var line in currentBatch)
                            {
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
                                    sb.AppendLine(mensaje);
                                    sb.AppendLine("-------------------------------");
                                }
                                else
                                {
                                    MessageBox.Show("El formato del archivo no es válido. Asegúrate de que cumpla con el formato especificado.");
                                    return;
                                }
                            }

                            // Mostrar el resumen de cada lote y preguntar al usuario si desea continuar viendo la lista
                            var result = MessageBox.Show(sb.ToString(), "Productos Importados", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                break;
                            }
                        }

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
                        MostrarMensajesEnLotes(mensajes, "Clientes Importados");
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
        private void MostrarMensajesEnLotes(List<string> mensajes, string titulo)
        {
            const int loteSize = 10;
            for (int i = 0; i < mensajes.Count; i += loteSize)
            {
                var loteMensajes = mensajes.Skip(i).Take(loteSize);
                StringBuilder sb = new StringBuilder();
                foreach (var mensaje in loteMensajes)
                {
                    sb.AppendLine(mensaje);
                    sb.AppendLine("-------------------------------");
                }
                sb.AppendLine("Mostrar más resultados (Sí/No)?");
                var respuesta = MessageBox.Show(sb.ToString(), titulo, MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.No)
                {
                    break;
                }
            }
        }

        private void pnlMenuAdministrador_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cerrarMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuAdministrador_Load(object sender, EventArgs e)
        {
            var infoAdmin = ObtenerFormularioExistente<InfoAdmin>();
            AgregarFormulario(infoAdmin);
        }
    }
}

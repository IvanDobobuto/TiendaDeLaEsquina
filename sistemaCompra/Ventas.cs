using Microsoft.VisualBasic.ApplicationServices;
using Org.BouncyCastle.Asn1.Bsi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Media;
using Org.BouncyCastle.Asn1.Pkcs;
using sistemaCompra.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Policy;
using System.util;

namespace sistemaCompra
{
    public partial class Ventas : Form
    {
        private List<Cliente> clientes;
        private List<Producto> productos;
        private Cliente clienteSeleccionado;
        double tipoCambioGlobal = 0;
        int playing = 0;
        SoundPlayer Musica = new SoundPlayer(@"C:\Users\Usuario\Desktop\La Tienda de la Esquina - Grupo 3 - PR2\sistemaCompra\Resources\SFX\Music.wav");

        private void nombreTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void apellidoTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void telefonoTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y ciertos caracteres especiales
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '(' && e.KeyChar != ')')
            {
                e.Handled = true;
            }
        }

        public Ventas()
        {
            InitializeComponent();


            nombreTB.KeyPress += new KeyPressEventHandler(nombreTB_KeyPress);
            apellidoTB.KeyPress += new KeyPressEventHandler(apellidoTB_KeyPress);
            telefonoTB.KeyPress += new KeyPressEventHandler(telefonoTB_KeyPress);

            clientes = new List<Cliente>();
            productos = new List<Producto>();
            Cliente clienteSeleccionado = new Cliente();

            string pathClientes = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "clientes.csv");
            string[] lineasClientes = File.ReadAllLines(pathClientes);

            string pathProductos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "inventario.csv");
            string[] lineasProductos = File.ReadAllLines(pathProductos);


            foreach (string linea in lineasClientes.Skip(1))
            {

                string[] valores = linea.Split(',');

                Cliente cliente = new Cliente();
                cliente.Cedula = Convert.ToInt32(valores[0]);
                cliente.Nombre = valores[1];
                cliente.Apellido = valores[2];
                cliente.Direccion = valores[3];
                cliente.Telefono = valores[4];
                cliente.CorreoElectronico = valores[5];
                cliente.TipoDocumento = Convert.ToChar(valores[6]);
                cliente.ContribuyenteEspecial = Convert.ToBoolean(valores[7]);
                clientes.Add(cliente);
            }

            foreach (string linea in lineasProductos.Skip(1))
            {

                string[] valores = linea.Split(',');

                Producto producto = new Producto();
                producto.Codigo = valores[0];
                producto.Nombre = valores[1];
                producto.Cantidad = Convert.ToInt64(valores[2]);
                producto.CantidadMinima = Convert.ToInt32(valores[3]);
                producto.UnidadDeMedida = valores[4];
                producto.CostoUnitario = Convert.ToDouble(valores[5]);
                producto.PrecioDeVenta = Math.Round(Convert.ToDouble(valores[6]), 2);

                if (valores[7] == "SI")
                {
                    producto.IVA = true;
                }
                else if (valores[7] == "NO")
                {
                    producto.IVA = false;
                }
                productos.Add(producto);
            }
        }

        public void VerificarCantidadDisponible()
        {
            foreach (var producto in productos)
            {
                if (producto.Cantidad < producto.CantidadMinima)
                {
                    MessageBox.Show($"ALERTA: La cantidad disponible del producto {producto.Nombre} es menor a su cantidad mínima especificada.");
                }
            }
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string buscador = textBoxCliente.Text;
            bool cedulaEncontrada = false;

            foreach (Cliente cliente in clientes)
            {
                if (buscador == Convert.ToString(cliente.Cedula))
                {
                    nombreTB.Text = cliente.Nombre;
                    apellidoTB.Text = cliente.Apellido;
                    telefonoTB.Text = cliente.Telefono;
                    emailTB.Text = cliente.CorreoElectronico;
                    direccionTB.Text = cliente.Direccion;
                    tipoDeDocumentoCB.Text = cliente.TipoDocumento.ToString();

                    if (cliente.ContribuyenteEspecial)
                    {
                        Si.Checked = true;
                    }
                    else
                    {
                        No.Checked = true;
                    }

                    clienteSeleccionado = cliente;
                    cedulaEncontrada = true;
                    break;
                }
            }

            if (!cedulaEncontrada)
            {
                MessageBox.Show("La cédula no fue encontrada. Por favor, agregue el cliente utilizando el botón de agregar.");
            }
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            VerificarCantidadDisponible();
            refrescarPrecio();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void restarProducto(string codigoProducto, double cantidadVendida)
        {
            foreach (Producto producto in productos)
            {
                if (codigoProducto == producto.Codigo)
                {
                    producto.Cantidad = producto.Cantidad - cantidadVendida;
                    break;
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(cantidadTB.Text))
            {
                MessageBox.Show("Asegúrate de completar todos los campos.");
                return;
            }

            if (!double.TryParse(cantidadTB.Text, out double cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingresa una cantidad válida.");
                return;
            }

            string buscador = textBox2.Text;

            bool productoEncontrado = false;

            foreach (Producto producto in productos)
            {

                if (buscador == Convert.ToString(producto.Codigo))
                {
                    productoEncontrado = true;
                    if (producto.Cantidad == 0)
                    {
                        MessageBox.Show($"El producto {producto.Nombre} no está disponible.");
                        break;
                    }


                    else if (producto.Cantidad < cantidad)
                    {
                        MessageBox.Show($"La cantidad solicitada del producto {producto.Nombre} es mayor a la disponible.");
                        break;
                    }

                    else
                    {
                        double precioUnitario = producto.PrecioDeVenta;
                        double totalLinea;
                        string IVA;

                        if (producto.IVA)
                        {
                            IVA = "16%";
                            totalLinea = cantidad * precioUnitario * 1.16;
                        }

                        else
                        {
                            IVA = "0%";
                            totalLinea = cantidad * precioUnitario;
                        }

                        factura.Rows.Add(producto.Codigo, producto.Nombre, cantidad, producto.UnidadDeMedida, precioUnitario, totalLinea, IVA);
                        restarProducto(buscador, cantidad);
                        break;
                    }
                }
            }

            if (!productoEncontrado)
            {
                MessageBox.Show("El producto no se encontró en la lista.");
            }
            refrescarPrecio();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && factura.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex < factura.Rows.Count && !factura.Rows[e.RowIndex].IsNewRow)
            {
                string codigo = factura.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                double cantidad = Convert.ToDouble(factura.Rows[e.RowIndex].Cells["Quantity"].Value);
                reStock(codigo, cantidad);
                factura.Rows.RemoveAt(e.RowIndex);
                refrescarPrecio();
            }
        }

        private void reStock(string codigo, double cantidad)
        {
            foreach (Producto producto in productos)
            {
                if (codigo == producto.Codigo)
                {
                    producto.Cantidad = producto.Cantidad + cantidad;
                    break;
                }
            }
        }

        private void cantidadTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgvProductosSeleccionados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private int ObtenerNumeroFactura()
        {
            string pathContador = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "contador_facturas.csv");
            if (!File.Exists(pathContador))
            {
                using (StreamWriter sw = File.CreateText(pathContador))
                {
                    sw.WriteLine("numero_facturas");
                    sw.WriteLine("0");
                }
                return 0;
            }

            string[] lines = File.ReadAllLines(pathContador);
            int numeroFacturas;
            if (int.TryParse(lines[1], out numeroFacturas))
            {
                numeroFacturas++;
                using (StreamWriter sw = new StreamWriter(pathContador, false))
                {
                    sw.WriteLine("numero_facturas");
                    sw.WriteLine(numeroFacturas.ToString());
                }
                return numeroFacturas;
            }
            else
            {
                // Manejo de errores si no se puede leer el número de facturas
                throw new Exception("No se pudo leer el número de facturas.");
            }
        }
        private void ImprimirFactura_Click(object sender, EventArgs e)
        {
            // Reproducir efecto de sonido al imprimir factura
            SoundPlayer kachingsfx = new SoundPlayer(Path.Combine(Application.StartupPath, "Cash.wav"));
            kachingsfx.Play();
            Document doc = new Document();
            string fechaActual = DateTime.Now.ToString("dd-MM-yy");
            string horaActual = DateTime.Now.ToString("HH:mm:ss");
            try
            {
                // Verificar si la carpeta de facturas existe, de lo contrario, crearla
                string pathFacturas = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Facturas");
                if (!Directory.Exists(pathFacturas))
                {
                    Directory.CreateDirectory(pathFacturas);
                }

                // Generar un código único para la factura
                string codigoFactura = Guid.NewGuid().ToString();

                // Nombre y apellido del cliente
                string nombreCliente = $"{nombreTB.Text}";
                string apellidoCliente = $"{apellidoTB.Text}";

                // Obtener el número de factura
                int numeroFactura = ObtenerNumeroFactura();

                // Crear el nombre del archivo PDF con el número de factura
                string numeroFacturaString = numeroFactura.ToString().PadLeft(4, '0');
                string nombreArchivo = $"{nombreCliente}_{apellidoCliente}_{fechaActual}_F{numeroFacturaString}.pdf";
                string pathCompleto = Path.Combine(pathFacturas, nombreArchivo);

                // Crear el archivo PDF
                PdfWriter.GetInstance(doc, new FileStream(pathCompleto, FileMode.Create));
                doc.Open();

                // Agregar el logo al documento
                string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "La Tienda de la Esquina LOGO PRUEBA.png");
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                logo.ScaleToFit(80f, 80f);
                logo.SetAbsolutePosition(doc.Left, doc.Top - logo.ScaledHeight);
                doc.Add(logo);

                // Agregar el título de la empresa al documento
                Paragraph tituloEmpresa = new Paragraph("La Tienda de la Esquina", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18));
                tituloEmpresa.Alignment = Element.ALIGN_CENTER;
                doc.Add(tituloEmpresa);

                // Agregar la fecha y hora de la factura
                Paragraph fecha = new Paragraph($"Fecha: {fechaActual}\nHora: {horaActual}\n\n");
                fecha.Alignment = Element.ALIGN_CENTER;
                doc.Add(fecha);

                // Obtener el número de factura
                int numero_Factura = ObtenerNumeroFactura();

                // Agregar número de factura al documento PDF
                Paragraph numeroFacturaParagraph = new Paragraph($"Factura N°: {numeroFactura}\n\n");
                numeroFacturaParagraph.Alignment = Element.ALIGN_CENTER;
                doc.Add(numeroFacturaParagraph);

                // Agregar detalles del cliente y la factura
                Paragraph encabezado = new Paragraph("Factura de Compra\n\nDatos del Cliente:\n");
                encabezado.Alignment = Element.ALIGN_CENTER;
                doc.Add(encabezado);

                // Agregar detalles del cliente
                Paragraph datosCliente = new Paragraph($"Nombre: {nombreCliente} {apellidoCliente}\nDirección: {direccionTB.Text}\nTeléfono: {telefonoTB.Text}\nCedula: {tipoDeDocumentoCB.Text}{textBoxCliente.Text}\n\n");
                datosCliente.Alignment = Element.ALIGN_LEFT;
                doc.Add(datosCliente);

                // Agregar detalles de la compra y cálculos
                double subtotal = 0;
                double totalIVA = 0;
                PdfPTable table = new PdfPTable(6);
                table.AddCell("Código");
                table.AddCell("Nombre");
                table.AddCell("Cantidad");
                table.AddCell("Precio Unitario");
                table.AddCell("Total");
                table.AddCell("IVA");

                foreach (DataGridViewRow fila in factura.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        string codigo = fila.Cells["Codigo"].Value.ToString();
                        string nombre = fila.Cells["Column1"].Value.ToString();
                        string cantidad = fila.Cells["Quantity"].Value.ToString();
                        string precioUnitario = fila.Cells["Column3"].Value.ToString();
                        string total = fila.Cells["Total"].Value.ToString();
                        string iva = fila.Cells["Column5"].Value.ToString();

                        table.AddCell(codigo);
                        table.AddCell(nombre);
                        table.AddCell(cantidad);
                        table.AddCell(precioUnitario);
                        table.AddCell(total);
                        table.AddCell(iva);

                        double totalLinea = Convert.ToDouble(total);
                        subtotal += totalLinea;
                        if (iva == "16%")
                        {
                            totalIVA += totalLinea * 0.16;
                        }
                    }
                }

                doc.Add(table);

                // Agregar sub total, IVA, total y monto en divisas
                doc.Add(new Paragraph("\n"));
                doc.Add(new Paragraph($"Subtotal: {subtotal.ToString("N2")} Bs.D"));
                doc.Add(new Paragraph($"Total IVA: {totalIVA.ToString("N2")} Bs.D"));

                double tipoCambio = tipoCambioGlobal;
                double totalEnDolares = subtotal / tipoCambio;
                doc.Add(new Paragraph(label4.Text));
                doc.Add(new Paragraph($"Total en dólares: {totalEnDolares:f2} $"));
                // Cerrar el documento
                doc.Close();
                MessageBox.Show($"Factura generada con éxito. Puede encontrarla en la carpeta Facturas.");
                Musica.PlayLooping(); 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al generar la factura: {ex.Message}");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            VerificarCantidadDisponible();
            Musica.Stop();
            this.Hide();
        }

        private void Ventas_Load_1(object sender, EventArgs e)
        {
            refrescarPrecio();
        }

        private void refrescarPrecio()
        {
            double precioTotal = 0;
            double totalIVA = 0;
            double totalEnDolares = 0;

            foreach (DataGridViewRow fila in factura.Rows)
            {
                // Asegúrate de que no estás procesando la fila de encabezado
                if (!fila.IsNewRow)
                {
                    if (fila.Cells["Total"].Value != null)
                    {
                        double precio = Convert.ToDouble(fila.Cells["Total"].Value);
                        precioTotal += precio;

                        string codigoProducto = fila.Cells["Codigo"].Value.ToString();
                        foreach (Producto producto in productos)
                        {
                            if (codigoProducto == producto.Codigo && producto.IVA)
                            {
                                double cantidad = Convert.ToDouble(fila.Cells["Quantity"].Value);
                                double precioUnitario = Convert.ToDouble(fila.Cells["Column3"].Value);
                                totalIVA += (cantidad * precioUnitario * 0.16); // Suponiendo un 16% de IVA
                                break;
                            }
                        }
                    }
                }
            }

            subtotal.Text = $"Subtotal: {precioTotal.ToString("N2")} Bs.D";
            label3.Text = $"Total IVA: {totalIVA.ToString("N2")} Bs.D";

            if (tipoCambioGlobal != 0)
            {
                totalEnDolares = Math.Round(precioTotal / tipoCambioGlobal, 2);
                if (totalEnDolares != 0)
                {
                    LabelDolares.Text = $"Total en dólares: {totalEnDolares:f2}$";
                }
                else
                {
                    LabelDolares.Text = "";
                }
            }
            else
            {
                LabelDolares.Text = "";
            }

            // Mostrar el total en Bs
            label4.Text = $"Total: {precioTotal.ToString("N2")} Bs";
        }

        private void refrescarPrecio(double tipoCambio)
        {
            double precioTotal = 0;
            double totalIVA = 0;
            double totalEnDolares = 0;

            foreach (DataGridViewRow fila in factura.Rows)
            {
                // Asegúrate de que no estás procesando la fila de encabezado
                if (!fila.IsNewRow)
                {
                    if (fila.Cells["Total"].Value != null)
                    {
                        double precio = Convert.ToInt64(fila.Cells["Total"].Value);
                        precioTotal += precio;

                        string codigoProducto = fila.Cells["Codigo"].Value.ToString();
                        foreach (Producto producto in productos)
                        {
                            if (codigoProducto == producto.Codigo && producto.IVA)
                            {
                                double cantidad = Convert.ToDouble(fila.Cells["Quantity"].Value);
                                double precioUnitario = Convert.ToDouble(fila.Cells["Column3"].Value);
                                totalIVA += (cantidad * precioUnitario * 0.16); // Suponiendo un 16% de IVA
                                break;
                            }
                        }
                    }
                }
            }

            totalEnDolares = precioTotal / tipoCambio;

            subtotal.Text = $"Subtotal: {precioTotal.ToString()} Bs.D";
            label3.Text = $"Total IVA: {totalIVA.ToString()} Bs.D";
            LabelDolares.Text = $"Total en dólares: {totalEnDolares:f2} $";
        }

        private void can_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void subtotal_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LabelDolares_Click(object sender, EventArgs e)
        {

        }



        private void Dolar_TextChanged(object sender, EventArgs e)
        {
            // Asegúrate de que el valor ingresado sea un número válido
            if (double.TryParse(Dolar.Text, out double tipoCambio))
            {
                // Asigna el tipo de cambio a la variable global
                tipoCambioGlobal = tipoCambio;
                // Actualiza el precio en dólares utilizando la función refrescarPrecio
                refrescarPrecio(tipoCambioGlobal);
            }
        }

        private void textBoxCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombreTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void apellidoTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void direccionTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefonoTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTB_TextChanged(object sender, EventArgs e)
        {

        }

        private bool esContribuyenteEspecial = false;

        private void Si_CheckedChanged(object sender, EventArgs e)
        {
            esContribuyenteEspecial = true;
        }

        private void No_CheckedChanged(object sender, EventArgs e)
        {
            esContribuyenteEspecial = false;
        }

        private void pboxAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string pathClientes = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "clientes.csv");

                string cedula = textBoxCliente.Text;
                string nombre = nombreTB.Text;
                string apellido = apellidoTB.Text;
                string direccion = direccionTB.Text;
                string telefono = telefonoTB.Text;
                string correoElectronico = emailTB.Text;
                string tipoDocumento = tipoDeDocumentoCB.Text;
                string contribuyenteEspecial = esContribuyenteEspecial ? "true" : "false";

                if (string.IsNullOrWhiteSpace(cedula) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(direccion) || string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(correoElectronico) || string.IsNullOrWhiteSpace(tipoDocumento))
                {
                    MessageBox.Show("Por favor complete todos los campos antes de agregar el cliente.");
                }
                else
                {
                    string newCliente = $"{cedula},{nombre},{apellido},{direccion},{telefono},{correoElectronico},{tipoDocumento},{contribuyenteEspecial}";

                    using (StreamWriter sw = File.AppendText(pathClientes))
                    {
                        sw.WriteLine(newCliente);
                    }

                    MessageBox.Show("Cliente agregado con éxito al archivo clientes.csv.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al agregar el cliente: {ex.Message}");
            }
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            VerProductos verProductos = new VerProductos();
            verProductos.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string pathFacturas = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Facturas");

                if (Directory.Exists(pathFacturas))
                {
                    Process.Start("explorer.exe", pathFacturas);
                }
                else
                {
                    MessageBox.Show("La carpeta de facturas no existe en el directorio del programa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al intentar abrir la carpeta de facturas: {ex.Message}");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (playing == playing % 2)
            {
                Musica.PlayLooping();
                playing++;
                pictureBox1.Image = Properties.Resources.IconoMusicaEncendida;
            }
            if (playing != playing % 2)
            {
                Musica.Stop();
                playing = 0;
                pictureBox1.Image = Properties.Resources.IconoMusicaApagar;
            }
        }
    }
}


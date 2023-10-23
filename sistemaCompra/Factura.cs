using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Rectangle = iTextSharp.text.Rectangle;

namespace sistemaCompra
{
    internal class Factura
    {
        //ATRIBUTOS
        private const string nombreEmpresa = "La Tienda de la Esquina";
        private const string rifEmpresa = "J-1234-0";
        private const string direccionFiscEmpresa = "La Hechicera";
        private string metodoPago;
        private int serialFactura = 0;
        private const double IVA = 0.16;
        private const double IGTF = 0.03;


        public void GenerarFactura(string rutaArchivo)
        {
            string carpetaFacturas = "Facturas";
            string rutaCarpetaFacturas = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, carpetaFacturas);

            // Verifica si la carpeta "Facturas" no existe y la crea si es necesario
            if (!Directory.Exists(rutaCarpetaFacturas))
            {
                Directory.CreateDirectory(rutaCarpetaFacturas);
            }

            // Genera el nombre del archivo de factura
            string nombreArchivo = $"factura_{serialFactura + 1}_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf";
            string rutArchivo = Path.Combine(rutaCarpetaFacturas, nombreArchivo);

            // Ruta del logo de la empresa (debe estar en la misma carpeta que el programa)
            string rutaLogoEmpresa = "logo_empresa.png";

            // Crear un nuevo documento
            Document doc = new Document();

            try
            {
                // Especifica la ruta del archivo donde se guardará la factura
                PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));

                // Abre el documento para editar
                doc.Open();

                // Agrega el logo de la empresa
                iTextSharp.text.Image logoEmpresa = iTextSharp.text.Image.GetInstance(rutaLogoEmpresa);
                logoEmpresa.Alignment = Element.ALIGN_CENTER;
                logoEmpresa.ScaleToFit(100f, 100f);  // Ajusta el tamaño del logo
                doc.Add(logoEmpresa);

                // PdfPTable para organizar elementos
                PdfPTable tableLogo = new PdfPTable(1);
                tableLogo.DefaultCell.Border = Rectangle.NO_BORDER;

                // Agrega datos fiscales de la empresa
                doc.Add(new Paragraph("Datos fiscales de la empresa"));
                doc.Add(new Paragraph($"{nombreEmpresa}"));
                doc.Add(new Paragraph($"{rifEmpresa}"));
                doc.Add(new Paragraph($"{direccionFiscEmpresa}"));

                // Agrega datos del cliente
                doc.Add(new Paragraph("Datos del cliente"));
                doc.Add(new Paragraph($"{rifEmpresa}"));

                // Agrega la lista de productos
                doc.Add(new Paragraph("Lista de productos"));

                // Cierra el documento
                doc.Close();

                Console.WriteLine("Factura generada exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al generar la factura: " + ex.Message);
            } 
        }
    }
}
    /*
    class Program
    {
        static void Main(string[] args)
        {
            string rutaArchivo = "ruta/del/archivo/factura.pdf";

            FacturaGenerator generator = new FacturaGenerator();
            generator.GenerarFactura(rutaArchivo);
        }
    }
    Este es un ejemplo básico y deberás adaptarlo según tu diseño y necesidades específicas.Puedes agregar más detalles y personalizar el formato según tus requisitos, incluyendo el uso adecuado de tablas, fuentes, colores y estilos para crear una factura visualmente atractiva y funcional.






        }
    }
}
    */
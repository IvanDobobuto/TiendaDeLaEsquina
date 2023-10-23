using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Program
    {
        public class Producto
        {
            public int ID { get; set; }
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
            public int CantidadMinima { get; set; }

            public Producto(int id, string nombre, int cantidad, int cantidadMinima)
            {
                ID = id;
                Nombre = nombre;
                Cantidad = cantidad;
                CantidadMinima = cantidadMinima;
            }

            public void SetCantidadMinima(int cantidadMinima)
            {
                CantidadMinima = cantidadMinima;
            }
            public void RealizarPedido(int cantidad)
            {
                Console.WriteLine($"Pedido realizado al Proveedor para el producto {Nombre}.Cantidad:{cantidad}.");

            }
        }

        public class Inventario
        {
            private List<Producto> productos = new List<Producto>();

            public void AgregarProducto(Producto producto)
            {
                productos.Add(producto);
            }

            public void VerificarInventario()
            {
                foreach (var producto in productos)
                {
                    if (producto.Cantidad < producto.CantidadMinima)
                    {
                        Console.WriteLine($"ALERTA: El producto {producto.Nombre} tiene un nivel de stock bajo. Se recomienda solicitar un pedido al proveedor.");
                        int cantidadFaltante = producto.CantidadMinima - producto.Cantidad;
                        producto.RealizarPedido(cantidadFaltante);

                    }
                }
            }
        }
        /*
        static void Main(string[] args)
        {
            // Crear productos y agregarlos al inventario
            Producto producto1 = new Producto(1, "Lapicero", 250, 10);
            Producto producto2 = new Producto(2, "Papel", 0, 55);
            Producto producto3 = new Producto(3, "Borrador", 11, 15);

            Inventario inventario = new Inventario();
            inventario.AgregarProducto(producto1);
            inventario.AgregarProducto(producto2);
            inventario.AgregarProducto(producto3);

            // Verificar el inventario y enviar notificaciones si es necesario
            inventario.VerificarInventario();

            // Configurar cantidad mínima de un producto y verificar el inventario nuevamente
            producto1.SetCantidadMinima(15);
            inventario.VerificarInventario();
        }
        */

    }
}
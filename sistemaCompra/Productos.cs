using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaCompra
{
    internal class Producto
    {
        private string codigo = "";
        private string nombre = "";
        private double cantidad;
        private int cantidadMinima;
        private string unidadDeMedida = ""; //Kilogramos, paquetes, etc
        private double costoUnitario;
        private double precioDeVenta;
        private bool iva;

        public string Codigo { get { return codigo; } set { codigo = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public double Cantidad {  get { return cantidad; } set { cantidad = value; } }
        public int CantidadMinima { get { return cantidadMinima; } set { cantidadMinima = value; } }
        public string UnidadDeMedida { get {  return unidadDeMedida; } set {  unidadDeMedida = value; } }
        public double CostoUnitario { get {  return costoUnitario; } set {  costoUnitario = value; } }
        public double PrecioDeVenta {  get { return precioDeVenta; } set {  precioDeVenta = value; } }
        public bool IVA { get { return iva; } set { iva = value; } }

        public Producto(double _cantidad, int _cantidadMinima, string _unidadDeMedida, double _costoUnitario, double _precioDeVenta, bool _iva, string _codigo, string _nombre)
        {
            Cantidad = _cantidad;
            CantidadMinima = _cantidadMinima;
            UnidadDeMedida = _unidadDeMedida;
            CostoUnitario = _costoUnitario;
            PrecioDeVenta = _precioDeVenta;
            IVA = _iva;
            Codigo = _codigo;
            Nombre = _nombre;
        }

        public Producto()
        {
        }
    }
}

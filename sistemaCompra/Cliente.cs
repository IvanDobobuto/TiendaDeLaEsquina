using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace sistemaCompra
{
    internal class Cliente
    {
        private string nombre;
        private string apellido;
        private string telefono; //Formato: 0000-0000000
        private string correoElectronico = "";
        private int cedula;
        private string direccion = "";
        private char tipoDocumento;
        private bool contribuyenteEspecial;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public string CorreoElectronico { get { return correoElectronico; } set { correoElectronico = value; } }
        public int Cedula { get { return cedula; } set { cedula = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        public char TipoDocumento { get { return tipoDocumento; } set { tipoDocumento = value; } }
        public bool ContribuyenteEspecial { get { return contribuyenteEspecial; } set { contribuyenteEspecial = value; } }

        public Cliente()
        {
            Nombre = "";
            Apellido = "";
            Telefono = "";
            CorreoElectronico = "";
            Cedula = 0;
            Direccion = "";
            TipoDocumento = 'a';
            ContribuyenteEspecial = false;

        }

        public Cliente(string _nombre, string _apellido, string _telefono, string _correoElectronico, char _tipoDeDocumento, int _cedula, string _direccion, bool _contribuyenteEspecial)
        {
            Nombre = _nombre;
            Apellido = _apellido;
            Telefono = _telefono;
            CorreoElectronico = _correoElectronico;
            Cedula = _cedula;
            Direccion = _direccion;
            TipoDocumento = _tipoDeDocumento;
            ContribuyenteEspecial = _contribuyenteEspecial;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaCompra
{
    internal class Usuario
    {
        private string username = "";
        private string password = "";
        private string tipoDeUsuario = "";

        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string TipoDeUsuario { get {  return tipoDeUsuario; } set { tipoDeUsuario = value; } }  

        public Usuario() 
        {
            
        }

        public Usuario(string _username, string _password, string _tipoDeUsuario)
        {
            Username = _username;
            Password = _password;
            TipoDeUsuario = _tipoDeUsuario;
        }
    }
}

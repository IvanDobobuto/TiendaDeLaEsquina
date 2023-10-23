using System.Windows.Forms.VisualStyles;
using System.IO;

namespace sistemaCompra
{
    public partial class Login : Form
    {
        private List<Usuario> usuarios;
        private string filePath = "usuarios.csv";


        public Login()
        {
            InitializeComponent();
            usuarios = new List<Usuario>();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            usuarios.Clear();

            if (File.Exists(filePath))
            {
                string[] lineasUsuarios = File.ReadAllLines(filePath);

                for (int i = 1; i < lineasUsuarios.Length; i++)
                {
                    string linea = lineasUsuarios[i];
                    string[] valores = linea.Split(',');

                    if (valores.Length >= 3)
                    {
                        Usuario usuario = new Usuario();
                        usuario.Username = valores[0];
                        usuario.Password = valores[1];
                        usuario.TipoDeUsuario = valores[2];
                        usuarios.Add(usuario);
                    }
                }
            }
            else
            {
                MessageBox.Show("El archivo de usuarios no se encontró en el directorio de la aplicación.");
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (mostrarPass.Checked)
            {
                cajaClave.UseSystemPasswordChar = false;
            }
            else
            {
                cajaClave.UseSystemPasswordChar = true;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CargarUsuarios();

            if (cajaUsuario.TextLength < 4)
            {
                MessageBox.Show("El nombre de usuario debe tener mas de 4 caracteres");


            }

            if (cajaClave.TextLength < 4)
            {
                MessageBox.Show("La clave debe tener mas de 4 caracteres");
            }

            else
            {
                verificarUsuario();
            }


        }

        private void verificarUsuario()
        {

            string username = cajaUsuario.Text;
            string password = cajaClave.Text;

            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Username == username && usuario.Password == password)
                {
                    switch (usuario.TipoDeUsuario)
                    {
                        case "Superuser":
                            ShowMenuSuperUser();
                            break;

                        case "Admin":
                            ShowMenuAdmin();
                            break;

                        case "Cajero":
                            ShowVentas();
                            break;

                    }
                    break;
                }
            }
        }

        private void ShowMenuSuperUser()
        {
            this.Hide();
            MenuSuperUser menuSuperUser = new MenuSuperUser();
            menuSuperUser.ShowDialog();
            menuSuperUser = null;
            this.Show();
            clearCajas();
        }

        private void ShowVentas()
        {
            this.Hide();
            Ventas ventas = new Ventas();
            ventas.ShowDialog();
            ventas = null;
            this.Show();
            clearCajas();
        }

        private void ShowMenuAdmin()
        {
            this.Hide();
            MenuAdministrador menuAdmin = new MenuAdministrador();
            menuAdmin.ShowDialog();
            menuAdmin = null;
            this.Show();
            clearCajas();
        }

        private void clearCajas()
        {
            cajaClave.Clear();
            cajaUsuario.Clear();
        }

        private void cajaUsuario_TextChanged(object sender, EventArgs e)
        {
            if (cajaUsuario.Text.Contains(" "))
            {
                MessageBox.Show("El nombre de usuario no debe tener espacios");
                cajaUsuario.Clear();
            }

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void cajaClave_TextChanged(object sender, EventArgs e)
        {
            if (cajaClave.Text.Contains(" "))
            {
                MessageBox.Show("La clave no debe tener espacios");
                cajaClave.Clear();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace Iglesia
{
    public partial class LoginJuli : Form
    {
        private OleDbConnection conexion;
        private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
        public LoginJuli()
        {
            InitializeComponent();
            conexion = new OleDbConnection(cadenaConexion);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_MouseEnter(object sender, EventArgs e)
        {
            btnIniciarSesion.ForeColor = Color.White;
        }

        private void btnIniciarSesion_MouseLeave(object sender, EventArgs e)
        {
            btnIniciarSesion.ForeColor = Color.Black;

        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            pbOcultar.BringToFront();
            txtPass.PasswordChar = '\0';
        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            pbMostrar.BringToFront();
            txtPass.PasswordChar = '*';
        }


        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtPass.Text;

            // Verificar si el usuario ya existe en la base de datos
            if (!UsuarioExiste(nombreUsuario))
            {
                // El usuario no existe, agregarlo a la base de datos
                AgregarUsuario(nombreUsuario, EncriptarContraseña(contraseña));
                MessageBox.Show("Usuario registrado correctamente.");
            }
            else
            {
                // Verificar si el usuario ya existe en la base de datos
                if (UsuarioExiste(nombreUsuario))
                {
                    string contraseñaAlmacenada = ObtenerContraseñaAlmacenada(nombreUsuario);

                    // Verificar si la contraseña ingresada coincide con la contraseña almacenada
                    if (VerificarContraseña(contraseña, contraseñaAlmacenada))
                    {
                        MessageBox.Show("Ingresó con éxito.");
                        // Redireccionar o mostrar la siguiente ventana aquí.
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.");
                    }
                }
            }

        }

        private string ObtenerContraseñaAlmacenada(string nombreUsuario)
        {
            // Establece la cadena de conexión a tu base de datos SQL Server.
           // string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                conexion.Open();
                string query = "SELECT contraseña FROM usuarios WHERE nombreUsuario = @nombre";
                using (OleDbCommand command = new OleDbCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@nombre", nombreUsuario);
                    return Convert.ToString(command.ExecuteScalar());
                }
            }
        }

        private bool UsuarioExiste(string nombreUsuario)
        {
            // Establece la cadena de conexión a tu base de datos SQL Server.
            //string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                conexion.Open();
                string query = "SELECT COUNT(*) FROM usuarios WHERE nombreUsuario = @nombre";
                using (OleDbCommand command = new OleDbCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@nombre", nombreUsuario);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void AgregarUsuario(string nombreUsuario, string contraseña)
        {
            // Establece la cadena de conexión a tu base de datos SQL Server.
            //string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                conexion.Open();
                string query = "INSERT INTO usuarios (nombreUsuario, contraseña) VALUES (@nombre, @contraseña)";
                using (OleDbCommand command = new OleDbCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@nombre", nombreUsuario);
                    command.Parameters.AddWithValue("@contraseña", contraseña);
                    command.ExecuteNonQuery();
                }
            }
        }

        private string EncriptarContraseña(string contraseña)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(contraseña);
                byte[] hash = sha256.ComputeHash(bytes);

                // Convierte el hash en una cadena hexadecimal
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    builder.Append(hash[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private bool VerificarContraseña(string contraseñaIngresada, string contraseñaAlmacenada)
        {
            // Encripta la contraseña ingresada y compárala con la contraseña almacenada.
            string contraseñaEncriptada = EncriptarContraseña(contraseñaIngresada);
            return contraseñaEncriptada == contraseñaAlmacenada;
        }


    }
}








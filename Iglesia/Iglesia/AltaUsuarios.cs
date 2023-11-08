using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Iglesia
{
    public partial class AltaUsuarios : Form
    {
        private OleDbConnection conexion;
        private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
        public AltaUsuarios()
        {
            InitializeComponent();
            conexion = new OleDbConnection(cadenaConexion);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string dniABuscar = textBoxDNIBuscar.Text.Trim();

            if (!string.IsNullOrEmpty(dniABuscar))
            {
                string consulta = "SELECT * FROM miembros WHERE DNI = @DNI";

                using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@DNI", dniABuscar);

                    try
                    {
                        conexion.Open();
                        OleDbDataReader reader = comando.ExecuteReader();

                        if (reader.Read())
                        {
                            txtNombre.Text = reader["NOMBRE"].ToString();
                            txtApellido.Text = reader["APELLIDO"].ToString();
                            checkBoxInhabilitado.Checked = Convert.ToBoolean(reader["inhabilitado"]);
                            buttonAceptar.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún registro con el DNI proporcionado.");
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al buscar en la base de datos: " + ex.Message);
                    }
                    finally
                    {
                        conexion.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un DNI válido.");
            }
        }

        private void textBoxDNIBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito numérico o una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número o una tecla de control, ignora la tecla presionada
                e.Handled = true;
            }
        }

        private void textBoxDNIBuscar_TextChanged(object sender, EventArgs e)
        {
            // Verifica si la longitud del texto en el TextBox es mayor a 8
            if (textBoxDNIBuscar.Text.Length > 8)
            {
                // Si es mayor a 8, recorta el texto para que solo tenga 8 caracteres
                //txtDNI.Text = txtDNI.Text.Substring(0, 8);
                // Coloca el cursor al final del texto
                //txtDNI.SelectionStart = txtDNI.Text.Length;
                MessageBox.Show("Solo puede ingresar 8 números. Por favor, verifique el DNI ingresado");
            }
        }
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            string consulta2 = "INSERT INTO Usuarios (tipo_usuario, DNI_User, habilitado) values ('" + comboBoxTipoUsuario.Text + "', " + textBoxDNIBuscar.Text + ", " + checkBoxAltaUser.Checked + ")";

            OleDbCommand comando = new OleDbCommand(consulta2, conexion);
            conexion.Open();
            int cantidad = comando.ExecuteNonQuery();

            if (cantidad < 1)
            {
                MessageBox.Show("Ocurrió un problema");
            }
            else
            {
                MessageBox.Show("Se registró el usuario con exito");
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxDNIBuscar.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            checkBoxInhabilitado.Checked = false;
            comboBoxTipoUsuario.Text = string.Empty;
            checkBoxAltaUser.Checked = false;
        }
    }
}

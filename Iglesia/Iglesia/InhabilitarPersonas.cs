using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iglesia
{
    public partial class InhabilitarPersonas : Form
    {
        private OleDbConnection conexion;
        private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
        public InhabilitarPersonas()
        {
            InitializeComponent();
            conexion = new OleDbConnection(cadenaConexion);
        }

        private void InhabilitarPersonas_Load(object sender, EventArgs e)
        {

        }

        private void buttonBuscarDNI_Click(object sender, EventArgs e)
        {
            string dniABuscar = textBoxBuscarDNI.Text.Trim();

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

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "")
            {
                MessageBox.Show("No debe dejar campos vacíos, por favor ingrese un DNI y presione el boton Buscar.");
            }
            else
            {
                if (checkBoxInhabilitado.Checked == true)
                {

                    string consulta = "UPDATE Miembros SET inhabilitado=" + checkBoxInhabilitado.Checked + " WHERE DNI=" + textBoxBuscarDNI.Text + ";";

                    OleDbCommand comando = new OleDbCommand(consulta, conexion);
                    conexion.Open();
                    int cantidad = comando.ExecuteNonQuery();

                    if (cantidad < 1)
                    {
                        MessageBox.Show("Ocurrió un problema");
                    }

                    else
                    {
                        MessageBox.Show("Se ha inhabilitado a esta persona");
                    }
                    conexion.Close();
                }
                else
                {
                    string consulta1 = "UPDATE Miembros SET inhabilitado=" + checkBoxInhabilitado.Checked + " WHERE DNI=" + textBoxBuscarDNI.Text + ";";
                    OleDbCommand comando = new OleDbCommand(consulta1, conexion);
                    conexion.Open();

                    int cantidad = comando.ExecuteNonQuery();

                    if (cantidad < 1)
                    {
                        MessageBox.Show("Ocurrió un problema");
                    }

                    else
                    {
                        MessageBox.Show("Se ha habilitado nuevamente a esta persona");
                    }
                    conexion.Close();
                }
            }
        }

        private void textBoxBuscarDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito numérico o una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número o una tecla de control, ignora la tecla presionada
                e.Handled = true;
            }
        }

        private void textBoxBuscarDNI_TextChanged_1(object sender, EventArgs e)
        {
            // Verifica si la longitud del texto en el TextBox es mayor a 8
            if (textBoxBuscarDNI.Text.Length > 8)
            {
                // Si es mayor a 8, recorta el texto para que solo tenga 8 caracteres
                //txtDNI.Text = txtDNI.Text.Substring(0, 8);
                // Coloca el cursor al final del texto
                //txtDNI.SelectionStart = txtDNI.Text.Length;
                MessageBox.Show("Solo puede ingresar 8 números. Por favor, verifique el DNI ingresado");
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxBuscarDNI.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            checkBoxInhabilitado.Checked = false;
            buttonAceptar.Enabled = false;
        }
    }
}

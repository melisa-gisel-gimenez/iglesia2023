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

namespace Iglesia
{
    public partial class AltaMentores : Form
    {
        private OleDbConnection conexion;
        private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
        public AltaMentores()
        {
            InitializeComponent();
            conexion = new OleDbConnection(cadenaConexion);
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

        private void textBoxDNIBuscar_TextChanged_1(object sender, EventArgs e)
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

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string dniABuscar = textBoxDNIBuscar.Text.Trim();

            if (!string.IsNullOrEmpty(dniABuscar))
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "SELECT * FROM mentores WHERE DNI_MENTOR = @DNI";
                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@DNI", dniABuscar);
                        try
                        {
                            OleDbDataReader reader = comando.ExecuteReader();

                            if (reader.Read())
                            {
                                MessageBox.Show("Esta persona ya está dada de alta como mentor, por favor verifique el DNI ingresado.");
                            }
                            else
                            {
                                string consulta2 = "SELECT * FROM miembros WHERE DNI = @DNI";
                                using (OleDbCommand comando2 = new OleDbCommand(consulta2, conexion))
                                {
                                    comando2.Parameters.AddWithValue("@DNI", dniABuscar);
                                    try
                                    {
                                        OleDbDataReader reader2 = comando2.ExecuteReader();
                                        if (reader2.Read())
                                        {
                                            textBoxNombre.Text = reader2["NOMBRE"].ToString();
                                            textBoxApellido.Text = reader2["APELLIDO"].ToString();
                                            textBoxDNI.Text = reader2["DNI"].ToString();
                                            buttonAceptar.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("No se encontró ninguna persona registrada con el DNI proporcionado.");
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Error al buscar en la base de datos: " + ex.Message);
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al buscar el DNI en la base de datos: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "" || textBoxApellido.Text == "" || textBoxDNI.Text == "")
            {
                MessageBox.Show("Por favor busque los datos del miembro que desea dar de alta como mentor");
            }
            else
            {

                string consulta = "INSERT INTO Mentores (Nombre, Apellido, DNI_Mentor) values ('" + textBoxNombre.Text + "', '" + textBoxApellido.Text + "', '" + textBoxDNI.Text + "');";
                //OleDbConnection conexion = new OleDbConnection(cadenaConexion);
                conexion.Open();

                //agregar consulta para insertar rol en el miembro designado como miembro

                OleDbCommand cmd = new OleDbCommand(consulta, conexion);

                int cantidad = cmd.ExecuteNonQuery();


                if (cantidad < 1)
                {
                    MessageBox.Show("Ocurrió un problema");
                }
                else
                {
                    MessageBox.Show("Se guardó con éxito!!!");
                }
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxDNIBuscar.Text = "";
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxDNI.Text = "";
            buttonAceptar.Enabled = false;
        }
    }
}
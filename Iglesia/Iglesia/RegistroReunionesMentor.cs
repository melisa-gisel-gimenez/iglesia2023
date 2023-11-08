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
    public partial class RegistroReunionesMentor : Form
    {
        private OleDbConnection conexion;
        private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";

        public RegistroReunionesMentor()
        {
            InitializeComponent();
            conexion = new OleDbConnection(cadenaConexion);
        }


        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string dniABuscar = textBoxDNI.Text.Trim();

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
                            textBoxNombre.Text = reader["NOMBRE"].ToString();
                            textBoxApellido.Text = reader["APELLIDO"].ToString();
                            textBoxIDMiembro.Text = reader["id_miembro"].ToString();
                            textBoxIDMentor.Text = reader["id_mentor"].ToString();
                            buttonGuardar.Enabled = true;
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

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "" || textBoxApellido.Text == "" || textBoxIDMentor.Text == "" || textBoxIDMiembro.Text == "")
            {
                MessageBox.Show("Por favor, seleccione un miembro antes de Guardar los cambios. Ingrese el DNI en el campo correspondiente y presione Buscar.");
            }
            else
            {
                string consulta = "INSERT INTO reuniones_mentor (id_miembro, id_mentor, fecha_reunion, detalle) VALUES (" + textBoxIDMiembro.Text + ", " + textBoxIDMentor.Text + ", '" + dateTimePicker1.Value + "', " + "'" + richTextBox1.Text + "');";

                using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                {

                    try
                    {
                        conexion.Open();

                        int cantidad = comando.ExecuteNonQuery();

                        if (cantidad < 1)
                        {
                            MessageBox.Show("Ocurrió un problema");
                        }
                        else
                        {
                            MessageBox.Show("Se registró la reunion con exito");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al intentar guardar los datos: " + ex.Message);
                    }
                    finally
                    {
                        conexion.Close();
                    }
                }
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxDNI.Text = string.Empty;
            textBoxNombre.Text = string.Empty;
            textBoxApellido.Text = string.Empty;
            textBoxIDMiembro.Text = string.Empty;
            textBoxIDMentor.Text = string.Empty;
            richTextBox1.Text = string.Empty;
            buttonGuardar.Enabled = false;
        }
    }
}

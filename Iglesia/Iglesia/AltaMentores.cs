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
                            
                            textBoxNombre.Text = reader["NOMBRE"].ToString();
                            textBoxApellido.Text = reader["APELLIDO"].ToString();
                            textBoxDNI.Text = reader["DNI"].ToString();

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
            if (textBoxNombre.Text == "" || textBoxApellido.Text == "" || textBoxDNI.Text == "")
            {
                MessageBox.Show("Por favor busque los datos del miembro que desea dar de alta como mentor");
            }
            else
            {
                string consulta = "INSERT INTO Mentores (Nombre, Apellido, DNI_Mentor) values ('" + textBoxNombre.Text + "', '" + textBoxApellido.Text + "', '" + textBoxDNI.Text + "');";
                //OleDbConnection conexion = new OleDbConnection(cadenaConexion);
                conexion.Open();

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
    }
}

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
}

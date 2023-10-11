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
    public partial class PostularADiscipulado : Form
    {
        private OleDbConnection conexion;
        private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
        public PostularADiscipulado()
        {
            InitializeComponent();
            conexion = new OleDbConnection(cadenaConexion);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string dniABuscar = txtDNIBuscar.Text.Trim();

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

                            textNombre.Text = reader["NOMBRE"].ToString();
                            textApellido.Text = reader["APELLIDO"].ToString();
                            textIDEtapaActual.Text = reader["id_etapaespiritual"].ToString();
                            textFechaAlta.Text = reader["fecha_alta"].ToString();
                            textIDMentor.Text = reader["id_mentor"].ToString();
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

            if (textIDEtapaActual.Text == "1")
            {
                textEtapaActual.Text = "Consolidacion";
            }

            if (textIDEtapaActual.Text == "2")
            {
                textEtapaActual.Text = "Discipulado";
            }

            if (textIDEtapaActual.Text == "3")
            {
                textEtapaActual.Text = "Enviado";
            }

            string idMentor = textIDMentor.Text;

            string consulta2 = "SELECT * FROM mentores WHERE id_mentor = @ID_MENTOR";

            if (textIDMentor.Text != "")
            {

                using (OleDbCommand comando = new OleDbCommand(consulta2, conexion))

                {

                    comando.Parameters.AddWithValue("@ID_MENTOR", idMentor);


                    try

                    {

                        conexion.Open();

                        OleDbDataReader reader = comando.ExecuteReader();


                        if (reader.Read())

                        {

                            textNombreMentor.Text = reader["NOMBRE"].ToString();


                        }

                        else

                        {

                            MessageBox.Show("No se encontró ningún mentor con el ID proporcionado.");

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
                MessageBox.Show("Por favor, ingresa un id válido.");
            }
        }
    }
}
    


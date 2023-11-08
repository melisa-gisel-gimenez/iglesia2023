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
            CargarDatosComboBoxMinisterios();
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
                            textBoxIDMiembro.Text = reader["id_miembro"].ToString();
                            textBoxIDMinisterio.Text = reader["id_ministerio"].ToString();
                            checkBoxSI.Checked = Convert.ToBoolean(reader["inhabilitado"]);
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
                        if (conexion.State == ConnectionState.Open)
                        {
                            conexion.Close();
                        }
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
                textProxEtapa.Text = "Discipulado";
                textEtapaActual.Enabled = false;
                textProxEtapa.Enabled = false;
                textBoxIDProxEtapa.Text = "2";
                textBoxIDProxEtapa.Enabled = false;
                comboBoxMinisterios.Enabled = true;

            }

            if (textIDEtapaActual.Text == "2")
            {
                textEtapaActual.Text = "Discipulado";
                textProxEtapa.Text = "Enviado";
                comboBoxMinisterios.Enabled = false;
                textEtapaActual.Enabled = false;
                textProxEtapa.Enabled = false;
                textBoxIDProxEtapa.Text = "3";


                if (textBoxIDMinisterio.Text != "")
                {
                    string idMinisterio = textBoxIDMinisterio.Text;
                    string consulta = "SELECT nombreMinisterio FROM Ministerios WHERE id_ministerio = @IdMinisterio";

                    try
                    {
                        using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@IdMinisterio", idMinisterio);

                            conexion.Open();
                            object resultado = comando.ExecuteScalar();

                            if (resultado != null)
                            {
                                comboBoxMinisterios.Text = resultado.ToString();
                                buttonPostular.Enabled = true;
                            }
                            else
                            {
                                // Manejar el caso donde no se encuentra el ministerio
                                MessageBox.Show("El miembro no tiene un ministerio válido asignado.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener el nombre del ministerio: " + ex.Message);
                    }
                    finally
                    {
                        if (conexion.State == ConnectionState.Open)
                        {
                            conexion.Close();
                        }
                    }

                }
            }

            if (textIDEtapaActual.Text == "3")
            {

                textEtapaActual.Text = "Enviado";
                comboBoxMinisterios.Enabled = false;
                textEtapaActual.Enabled = false;
                textProxEtapa.Enabled = false;
                textBoxIDProxEtapa.Enabled = false;
                buttonPostular.Enabled = false;
                MessageBox.Show("Esta persona ya llegó a la etapa de evolución máxima dentro de la Iglesia. Por favor elija otro miembro o revise los datos");

            }

            if (checkBoxSI.Checked == true)
            {
                MessageBox.Show("No puede postular a una persona inhabilitada. Consulte con Administración o verifique el DNI ingresado");
            }

            if (textIDEtapaActual.Text == "1" || textIDEtapaActual.Text == "2")
            {
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
                                buttonPostular.Enabled = true;

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

                            if (conexion.State == ConnectionState.Open)
                            {
                                conexion.Close();
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un id válido.");
                }
            }
        }

        private void txtDNIBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito numérico o una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número o una tecla de control, ignora la tecla presionada
                e.Handled = true;
            }
        }

        private void textApellido_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtDNIBuscar_TextChanged(object sender, EventArgs e)
        {
            // Verifica si la longitud del texto en el TextBox es mayor a 8
            if (txtDNIBuscar.Text.Length > 8)
            {
                // Si es mayor a 8, recorta el texto para que solo tenga 8 caracteres
                //txtDNI.Text = txtDNI.Text.Substring(0, 8);
                // Coloca el cursor al final del texto
                //txtDNI.SelectionStart = txtDNI.Text.Length;
                MessageBox.Show("Solo puede ingresar 8 números. Por favor, verifique el DNI ingresado");
            }
        }

        private void PostularADiscipulado_Load(object sender, EventArgs e)
        {

        }

        private void buttonPostular_Click(object sender, EventArgs e)
        {
            if (textIDEtapaActual.Text == "1")
            {
                if (comboBoxMinisterios.Text == "")
                {
                    MessageBox.Show("No debe dejar campos vacíos. Por favor seleccione un Ministerio y verifique el restod e los datos.");
                }
                else
                {

                    string consulta2 = "INSERT INTO Postulaciones (id_mentor, id_miembro, id_etapaespiritual) values (" + textIDMentor.Text + "," + textBoxIDMiembro.Text + "," + textBoxIDProxEtapa.Text + ")";

                    OleDbCommand comando = new OleDbCommand(consulta2, conexion);
                    conexion.Open();
                    int cantidad = comando.ExecuteNonQuery();

                    if (cantidad < 1)
                    {
                        MessageBox.Show("Ocurrió un problema");
                    }
                    else
                    {
                        MessageBox.Show("Se registro la postulación con exito!");
                    }

                    string consulta3 = "UPDATE Miembros SET id_ministerio =" + textBoxIDMinisterio.Text + " WHERE id_miembro=" + textBoxIDMiembro.Text + ";";
                    OleDbCommand comando2 = new OleDbCommand(consulta3, conexion);
                    //conexion.Open();

                    int cantidad2 = comando2.ExecuteNonQuery();

                    if (cantidad2 < 1)
                    {
                        MessageBox.Show("Ocurrió un problema");
                    }
                    else
                    {
                        MessageBox.Show("Se registro el Ministerio en el registro del miembro correctamente!");
                    }
                    conexion.Close();
                }
            }

            if (textIDEtapaActual.Text == "2")
            {
                string consulta2 = "INSERT INTO Postulaciones (id_mentor, id_miembro, id_etapaespiritual) values (" + textIDMentor.Text + "," + textBoxIDMiembro.Text + "," + textBoxIDProxEtapa.Text + ")";

                OleDbCommand comando = new OleDbCommand(consulta2, conexion);
                conexion.Open();
                int cantidad = comando.ExecuteNonQuery();

                if (cantidad < 1)
                {
                    MessageBox.Show("Ocurrió un problema");
                }
                else
                {
                    MessageBox.Show("Se registro la postulación con exito!");
                }
                conexion.Close();
            }

            if (textIDEtapaActual.Text == "3")
            {
                MessageBox.Show("Esta persona ya llego a la etapa maxima dentro de la Iglesia. Por favor busque otro Miembro.");
            }

        }

        private void CargarDatosComboBoxMinisterios()
        {
            string consulta = "SELECT nombreMinisterio FROM Ministerios";

            using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
            {
                try
                {
                    conexion.Open();
                    OleDbDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        string nombreMinisterio = reader["nombreMinisterio"].ToString();
                        comboBoxMinisterios.Items.Add(nombreMinisterio);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                    }
                }
            }
        }

        // Evento que se dispara al seleccionar un elemento en el ComboBox
        private void comboBoxMinisterios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMinisterios.SelectedIndex >= 0)
            {
                // Obtener el ID del ministerio seleccionado y mostrarlo en el TextBox
                string ministerioSeleccionado = comboBoxMinisterios.SelectedItem.ToString();
                MostrarIdMinisterio(ministerioSeleccionado);
            }
        }

        private void MostrarIdMinisterio(string nombreMinisterio)
        {
            string consulta = "SELECT Id_Ministerio FROM Ministerios WHERE nombreMinisterio = @NombreMinisterio";

            using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("@NombreMinisterio", nombreMinisterio);

                try
                {
                    conexion.Open();
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        textBoxIDMinisterio.Text = resultado.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el ID del ministerio: " + ex.Message);
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                    }
                }
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtDNIBuscar.Text = string.Empty;
            textNombre.Text = string.Empty;
            textApellido.Text = string.Empty;
            textBoxIDMiembro.Text = string.Empty;
            textEtapaActual.Text = string.Empty;
            textProxEtapa.Text = string.Empty;
            textBoxIDProxEtapa.Text = string.Empty;
            textIDEtapaActual.Text = string.Empty;
            comboBoxMinisterios.Text = "";
            textBoxIDMinisterio.Text = string.Empty;
            textFechaAlta.Text = string.Empty;
            textNombreMentor.Text = string.Empty;
            textIDMentor.Text = string.Empty;
            textMinisterio.Text = string.Empty;
            checkBoxSI.Checked = false;
            buttonPostular.Enabled = false;
        }

    }
}



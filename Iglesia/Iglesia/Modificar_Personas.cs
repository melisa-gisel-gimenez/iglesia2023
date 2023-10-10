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

namespace Iglesia
{
    public partial class Modificar_Personas : Form
    {
        private OleDbConnection conexion;
        private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
        
        public Modificar_Personas()
        {
            InitializeComponent();
            conexion = new OleDbConnection(cadenaConexion);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            //GestionarPersonas ventana = new GestionarPersonas();
            //ventana.ShowDialog();
        }
        private void ModificarBD()
        {
            OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb");
            conexion.Open();
            string Consulta = "UPDATE Miembros SET Nombre='" + txtNombre.Text + "', Apellido='" + txtApellido.Text + "', Dirección= '" + txtDireccion.Text + "', Barrio = '" + txtBarrio.Text + "', Telefono = " + txtTelefono.Text + ",DNI=" + txtDNI.Text + ", fecha_nac = '" + textBoxFechaNac.Text + "' WHERE DNI = " + textBoxBuscarDNI.Text + ";";
            OleDbCommand comando = new OleDbCommand(Consulta, conexion);
            OleDbDataReader dr = comando.ExecuteReader();

            MessageBox.Show("Se modificaron los datos con éxito");
            Close();
            //GestionarPersonas Ventana = new GestionarPersonas();
            //Ventana.ShowDialog();

        }
        private void Modificar_Personas_Load(object sender, EventArgs e)
        {
            
        }        
        
        /*
         * private void button1_Click(object sender, EventArgs e)
        {
            ModificarBD();
            txtDNI.Text = "";
            txtApellido.Text = "";
            txtBarrio.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            dateTimePicker1.Text = "";
            textBoxBuscarDNI.Text="";
                      
        }
        */
        

        private void button3_Click(object sender, EventArgs e)
        {
            
            txtApellido.Text = "";
            txtBarrio.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtDNI.Text = "";
            txtTelefono.Text = "";
            textemail.Text = "";
            textBoxFechaNac.Text = "";
            
        }
                  
        
            private void btnBuscar_Click(object sender, EventArgs e)
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
                                txtDNI.Text = reader["DNI"].ToString();
                                txtNombre.Text = reader["NOMBRE"].ToString();
                                txtApellido.Text = reader["APELLIDO"].ToString();
                                txtDireccion.Text = reader["DIRECCION"].ToString();
                                txtBarrio.Text = reader["BARRIO"].ToString();
                                txtTelefono.Text = reader["TELEFONO"].ToString();
                                textemail.Text = reader["EMAIL"].ToString();
                                textBoxFechaNac.Text = reader["FECHA_NAC"].ToString();
                                checkBoxBautizado.Checked = Convert.ToBoolean(reader["bautizado"]);
                                
                                

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

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito numérico o una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número o una tecla de control, ignora la tecla presionada
                e.Handled = true;
            }
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            // Verifica si la longitud del texto en el TextBox es mayor a 8
            if (txtDNI.Text.Length > 8)
            {
                // Si es mayor a 8, recorta el texto para que solo tenga 8 caracteres
                //txtDNI.Text = txtDNI.Text.Substring(0, 8);
                // Coloca el cursor al final del texto
                //txtDNI.SelectionStart = txtDNI.Text.Length;
                MessageBox.Show("Solo puede ingresar 8 números. Por favor, verifique el DNI ingresado");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dniAModificar = textBoxBuscarDNI.Text.Trim();
            string dniModificado = txtDNI.Text.Trim();

            if (!string.IsNullOrEmpty(dniAModificar))
            {
                string consulta = "UPDATE miembros SET NOMBRE = @Nombre, APELLIDO = @Apellido, " +
                                  "DIRECCION = @Direccion, BARRIO = @Barrio, TELEFONO = @Telefono, " +
                                  "EMAIL = @Email, BAUTIZADO = @Checkbox, fecha_nac = @FECHA_NAC, DNI = @DNI  WHERE DNI = @DNI2";

                using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    comando.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                    comando.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                    comando.Parameters.AddWithValue("@Barrio", txtBarrio.Text);
                    comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    comando.Parameters.AddWithValue("@Email", textemail.Text);
                    comando.Parameters.AddWithValue("@Checkbox",checkBoxBautizado.Checked);                    
                    comando.Parameters.AddWithValue("@FECHA_NAC", textBoxFechaNac.Text);
                    comando.Parameters.AddWithValue("@DNI", dniModificado);
                    comando.Parameters.AddWithValue("@DNI2", dniAModificar);


                    try
                    {
                        conexion.Open();
                        int filasActualizadas = comando.ExecuteNonQuery();

                        if (filasActualizadas > 0)
                        {
                            MessageBox.Show("Los datos se actualizaron correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún registro con el DNI proporcionado.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar en la base de datos: " + ex.Message);
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

        private void textBoxBuscarDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito numérico o una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número o una tecla de control, ignora la tecla presionada
                e.Handled = true;
            }
        }

        private void textBoxBuscarDNI_TextChanged(object sender, EventArgs e)
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
    }
}




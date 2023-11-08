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
using System.Text.RegularExpressions;

namespace Iglesia
{
    public partial class AgregarPersonas : Form
    {
        private OleDbConnection conexion;
        private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
        public AgregarPersonas()
        {
            InitializeComponent();
            conexion = new OleDbConnection(cadenaConexion);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (Validacion() == true)
            {
                GuardarBD();

            }

        }

        private void GuardarBD()
        {
            if ((txtDNI.Text == "" || txtApellido.Text == "" || txtNombre.Text == "" || txtTelefono.Text == "" || textemail.Text == ""))
            {
                MessageBox.Show("Los campos Nombre Apellido telefono DNI y Email son obligatorios. Por favor completelos");
            }
            else
            {
                DateTime fechaAlta = DateTime.Now;

                // string conexion @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb");
                cn.Open();
                String consulta2 = "insert into Miembros (DNI, NOMBRE, APELLIDO, DIRECCION, BARRIO, TELEFONO, FECHA_NAC, BAUTIZADO, EMAIL, ID_ETAPAESPIRITUAL, FECHA_ALTA) values (" + int.Parse(txtDNI.Text) + ", '" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtDireccion.Text + "', '" + txtBarrio.Text + "', '" + txtTelefono.Text + "', '" + dateTimePicker1.Value + " ', " + checkBox_bautismo.Checked + ", '" + textemail.Text + "', " + "'1', '" + fechaAlta + "');";


                OleDbCommand comando1 = new OleDbCommand(consulta2, cn);


                int cantidad = comando1.ExecuteNonQuery();


                if (cantidad < 1)
                {
                    MessageBox.Show("Ocurrió un problema");
                }
                else
                {
                    MessageBox.Show("Se guardó con éxito!!!");
                }

                string consulta = "SELECT * FROM miembros WHERE DNI = @DNI";
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@DNI", txtDNI.Text);

                try
                {
                    conexion.Open();
                    OleDbDataReader reader = comando.ExecuteReader();

                    if (reader.Read())
                    {

                        textBoxParaID.Text = reader["id_miembro"].ToString();

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


                string cadenaFecha2 = "INSERT INTO CambioEtapas (id_miembro, id_etapaEspiritual, fecha_alta_etapa) VALUES ('" + textBoxParaID.Text + "', " + "'1', '" + fechaAlta + "');";
                OleDbCommand comando3 = new OleDbCommand(cadenaFecha2, conexion);
                conexion.Open();

                int cantidad3 = comando3.ExecuteNonQuery();

                if (cantidad3 < 1)
                {
                    MessageBox.Show("Ocurrió un problema");
                }

                else
                {
                    MessageBox.Show("Se registro la fecha de alta en Consolidación, correctamente");
                }
                conexion.Close();

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            txtDNI.Text = "";
            txtApellido.Text = "";
            txtBarrio.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            checkBox_bautismo.Checked = false;
            textemail.Text = "";
            dateTimePicker1.Text = "";

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Agregar_Personas_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private bool Validacion()
        {
            bool validado = true;
            if (txtDNI.Text == "")
            {
                validado = false;
                MessageBox.Show("Debe ingresar al menos el número de DNI", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDNI.Focus();
            }
            else
            {

                if (BuscarDNI(int.Parse(txtDNI.Text)))
                {
                    validado = false;
                    MessageBox.Show("El DNI ya se encuentra registrado", "DNI EXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDNI.Focus();
                    txtDNI.SelectAll();
                }
            }

            return validado;

        }

        private bool BuscarDNI(int DNI)
        {
            bool encontrado = false;

            OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb");
            // OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\OneDrive\Escritorio\Iglesianuevo2023.mdb");
            conexion.Open();
            string Consulta = "select * from Miembros where DNI=" + DNI + ";";
            OleDbCommand comando = new OleDbCommand(Consulta, conexion);
            OleDbDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                encontrado = true;

            }

            return encontrado;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es alfanumérico ni espacio en blanco ni tecla de control, ignora la tecla presionada
                e.Handled = true;
            }

        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es alfanumérico ni espacio en blanco ni tecla de control, ignora la tecla presionada
                e.Handled = true;
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es alfanumérico ni espacio en blanco ni tecla de control, ignora la tecla presionada
                e.Handled = true;
            }
        }

        private void txtBarrio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es alfanumérico ni espacio en blanco ni tecla de control, ignora la tecla presionada
                e.Handled = true;
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

        private void txtDNI_TextChanged_1(object sender, EventArgs e)
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

        private bool EsDireccionDeCorreoValida(string direccionCorreo)
        {
            // Expresión regular para validar una dirección de correo electrónico
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Usar la clase Regex para verificar si la dirección de correo coincide con el patrón
            Regex regex = new Regex(patron);

            return regex.IsMatch(direccionCorreo);
        }
        private void ValidarCorreoElectronico()
        {
            string correo = textemail.Text;

            if (EsDireccionDeCorreoValida(correo))
            {
                // La dirección de correo es válida
                // Puedes realizar otras acciones aquí si es necesario
            }
            else
            {
                MessageBox.Show("La dirección de correo no es válida. Por favor verifiquela");
                // Muestra un mensaje de error o realiza alguna acción de validación adicional
            }
        }

        private void textemail_MouseLeave(object sender, EventArgs e)
        {
            ValidarCorreoElectronico();
        }
    }
}











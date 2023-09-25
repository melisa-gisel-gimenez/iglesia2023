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
        public Modificar_Personas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            GestionarPersonas ventana = new GestionarPersonas();
            ventana.ShowDialog();
        }
        private void ModificarBD()
        {
            OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\lguzman\Documents\Iglesia.accdb");
            conexion.Open();
            string Consulta = "UPDATE Personas SET Nombre='" + txtNombre.Text + "', Apellido='" + txtApellido.Text + "', Dirección= '" + txtDireccion.Text + "', Barrio = '" + txtBarrio.Text + "', Teléfono = " + txtTelefono.Text + ", Consolidador = '" + textBox1.Text + "', Fecha_De_Nacimiento = '" + dateTimePicker1.Value + "' WHERE IdDNI = " + txtDNI.Text + ";";
            OleDbCommand comando = new OleDbCommand(Consulta, conexion);
            OleDbDataReader dr = comando.ExecuteReader();

            MessageBox.Show("Fue Modificado con éxito");
            Close();
            GestionarPersonas Ventana = new GestionarPersonas();
            Ventana.ShowDialog();

        }
        private void Modificar_Personas_Load(object sender, EventArgs e)
        {
            
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModificarBD();
            txtDNI.Text = "";
            txtApellido.Text = "";
            txtBarrio.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            dateTimePicker1.Text = "";
            textBox1.Text="";
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            txtApellido.Text = "";
            txtBarrio.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            dateTimePicker1.Text = "";
            
        }
    }
}

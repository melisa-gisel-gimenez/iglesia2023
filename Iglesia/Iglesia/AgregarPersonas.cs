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
    public partial class AgregarPersonas : Form
    {
        public AgregarPersonas()
        {
            InitializeComponent();
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
                txtDNI.Text = "";
                txtApellido.Text = "";
                txtBarrio.Text = "";
                txtDireccion.Text = "";
                txtNombre.Text = "";
                txtTelefono.Text = "";
                textBox1.Text = "";
                dateTimePicker1.Text = "";
                textemail.Text = "";

            }
            /*
            if (Validacion()==true)
            {
                GuardarBD();
                txtDNI.Text = "";
                txtApellido.Text = "";
                txtBarrio.Text = "";
                txtDireccion.Text = "";
                txtNombre.Text = "";
                txtTelefono.Text = "";
                textBox1.Text = "";
                dateTimePicker1.Text = "";
                //richTextBox1.Text = "";

            }
            */

            //GuardarBD();


        }

        private void GuardarBD()
        {
            //GestionarPersonas Ventana = new GestionarPersonas();

            // string conexion @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
            OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb");
            cn.Open(); 
            String consulta2 = "insert into Miembros (DNI, NOMBRE, APELLIDO, DIRECCION, BARRIO, TELEFONO, FECHA_NAC, BAUTIZADO, EMAIL) values (" + int.Parse(txtDNI.Text) + ", '" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtDireccion.Text + "', '" + txtBarrio.Text + "', " + txtTelefono.Text + ", '" + dateTimePicker1.Value + " ', " + checkBox_bautismo.Checked + ", '" + textemail.Text + "');";

            // String consulta = "insert into Personas (IdDNI, Nombre, Apellido, Dirección, Barrio, Teléfono, Sexo, Fecha de Nacimiento, Puesto1, Puesto2, Puesto3, Puesto4) values ("+int.Parse(txtDNI.Text)+", '"+txtNombre.Text+"', '"+txtApellido.Text+"', '"+txtDireccion.Text+"', '"+txtBarrio.Text+"', "+int.Parse(txtTelefono.Text)+", '"+Convert.ToDateTime(dateTimePicker1.Text)+"', '"+comboBox5.Text+"',"+int.Parse(comboBox1.Text)+ ", " + int.Parse(comboBox2.Text) + ", " + int.Parse(comboBox3.Text) + ", " + int.Parse(comboBox4.Text) + ");";
           // String consulta2 = "insert into Personas values (" + int.Parse(txtDNI.Text) + ", '" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtDireccion.Text + "', '" + txtBarrio.Text + "', '" + txtTelefono.Text + "', '" + textBox1.Text + "', '" + dateTimePicker1.Value + "', '" +  "');";

            //foreach (DataGridViewRow fila in Ventana.dgvConsultaPersonas.Rows)
            //{
            //    if (fila.Cells[0].Value != null)
            //        if (fila.Cells[0].Value.ToString() == txtDNI.Text)
            //        {
            //            MessageBox.Show("La persona ya existe en la Base de Datos");
            //        }
            //        else


            OleDbCommand comando1 = new OleDbCommand(consulta2, cn);




            int cantidad = comando1.ExecuteNonQuery();


            if (cantidad < 1)
            {
                MessageBox.Show("Ocurrió un problema");
            }
        
        MessageBox.Show("Se guardó con éxito!!!");
            
            
            
            
           
            }
        private void button3_Click(object sender, EventArgs e)
        {
            txtDNI.Text = "";
            txtApellido.Text = "";
            txtBarrio.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            textBox1.Text = "";
            dateTimePicker1.Text = "";
            //richTextBox1.Text="";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
           // GestionarPersonas ventana = new GestionarPersonas();
            //ventana.ShowDialog();
           
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
             if (BuscarDNI(int.Parse(txtDNI.Text)))
            {
                validado = false;
                MessageBox.Show("El DNI ya se encuentra registrado", "DNI EXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDNI.Focus();
                txtDNI.SelectAll();
            }
            

            return validado;
            
            
            }
           
        private bool BuscarDNI(int DNI)
        {
            bool encontrado=false;

            OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb");
           // OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\OneDrive\Escritorio\Iglesianuevo2023.mdb");
            conexion.Open();
            string Consulta = "select * from Miembros where DNI='"+ DNI + "';";
            OleDbCommand comando = new OleDbCommand(Consulta, conexion);
            OleDbDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                encontrado = true;

            }

            return encontrado;
            }


    }
}
        

        

        //private void label21_Click(object sender, EventArgs e)
        //{

        //}

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void label15_Click(object sender, EventArgs e)
        //{

        //}

        //private void label16_Click(object sender, EventArgs e)
        //{

        //}

        //private void label19_Click(object sender, EventArgs e)
        //{

        //}

       

        
    //}




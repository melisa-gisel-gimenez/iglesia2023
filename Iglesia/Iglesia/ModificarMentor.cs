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
    public partial class ModificarMentor : Form
    {        
            private OleDbConnection conexion;
            private OleDbDataAdapter adaptador;
            private DataSet dataSet;

            public ModificarMentor()
            {
                InitializeComponent();

            }

            private void AsignarMentor_Load(object sender, EventArgs e)
            {
              CargarMiembros();
              CargarMentores();
            }

            private void CargarMiembros()
            {
              // Establece la cadena de conexión a tu archivo de base de datos Access (MDB).
              string connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";

              // Crea una conexión a la base de datos.
              conexion = new OleDbConnection(connectionString);

              // Define la consulta SQL para seleccionar los registros con ID_Mentor vacío.
              string consulta = "SELECT DNI, nombre, fecha_alta, id_mentor FROM Miembros WHERE id_mentor IS NOT NULL";

              // Crea un adaptador de datos para ejecutar la consulta y llenar el DataSet.
              adaptador = new OleDbDataAdapter(consulta, conexion);

              // Crea un DataSet para almacenar los datos.
              dataSet = new DataSet();

              // Abre la conexión y llena el DataSet con los datos de la tabla Miembros.
              conexion.Open();
              adaptador.Fill(dataSet, "Miembros");
              conexion.Close();

              // Enlaza el DataGridView (DGV1) con el DataSet.
              DGV1.DataSource = dataSet.Tables["Miembros"];
            }

        private void CargarMentores()
        {
            // Establece la cadena de conexión a tu archivo de base de datos Access (MDB).
            string connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";

            // Crea una conexión a la base de datos.
            conexion = new OleDbConnection(connectionString);

            // Define la consulta SQL para seleccionar los registros con ID_Mentor vacío.
            string consulta = "SELECT *FROM mentores";

            // Crea un adaptador de datos para ejecutar la consulta y llenar el DataSet.
            adaptador = new OleDbDataAdapter(consulta, conexion);

            // Crea un DataSet para almacenar los datos.
            dataSet = new DataSet();

            // Abre la conexión y llena el DataSet con los datos de la tabla Miembros.
            conexion.Open();
            adaptador.Fill(dataSet, "Mentores");
            conexion.Close();

            // Enlaza el DataGridView (DGV1) con el DataSet.
            DGV2.DataSource = dataSet.Tables["Mentores"];
        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dni;
            string nombreM;
            
            textBoxDNI.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxNombre.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells[1].Value.ToString();

            button2.Enabled = true;
            dni = int.Parse(textBoxDNI.Text);
            nombreM = textBoxNombre.Text;
            /*
            cb_EDITORIAL.Text = DGV_ListaLibros.Rows[DGV_ListaLibros.CurrentRow.Index].Cells[3].Value.ToString();
            cb_NomApeAut.Text = DGV_ListaLibros.Rows[DGV_ListaLibros.CurrentRow.Index].Cells[4].Value.ToString();
            cb_GENERO.Text = DGV_ListaLibros.Rows[DGV_ListaLibros.CurrentRow.Index].Cells[5].Value.ToString();
            checkBox1.Text = DGV_ListaLibros.Rows[DGV_ListaLibros.CurrentRow.Index].Cells[6].Value.ToString();
            */
        }

        private void DGV2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            string nombreMentor;
            int cantidadMentoreados;
            button2.Enabled = false;

            textBoxIdMentor.Text = DGV2.Rows[DGV2.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxNombreMentor.Text = DGV2.Rows[DGV2.CurrentRow.Index].Cells[1].Value.ToString();
            textBoxCantidad.Text = DGV2.Rows[DGV2.CurrentRow.Index].Cells[3].Value.ToString();
            cantidadMentoreados = int.Parse(textBoxCantidad.Text);

            if (cantidadMentoreados == 5)
            {
                MessageBox.Show("Este mentor ya llegó a la cantidad maxima de 5 mentoreados. Por favor seleccione otro mentor.");
                //button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
            //id = int.Parse(textBoxIdMentor.Text);
            //nombreMentor = textBoxNombreMentor.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBoxDNI.Text == "") || (textBoxNombre.Text) == "")
            {
                MessageBox.Show("No puede dejar campos vacíos, por favor seleccione un miembro.");
            }
            else
            {

                if ((textBoxIdMentor.Text == "") || (textBoxNombreMentor.Text) == "")
                {
                    MessageBox.Show("No puede dejar campos vacíos, por favor seleccione un mentor.");
                }
                else
                {

                    OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb");
                    cn.Open();
                    String consulta3 = "UPDATE Miembros SET id_mentor ='" + int.Parse(textBoxIdMentor.Text) + "' " + " WHERE DNI = '" + int.Parse(textBoxDNI.Text) + "';";
                    String consulta4 = "UPDATE Mentores SET cantidad = cantidad + 1" + " WHERE id_mentor = " + int.Parse(textBoxIdMentor.Text) + ";";

                    OleDbCommand comando1 = new OleDbCommand(consulta3, cn);

                    int cantidad = comando1.ExecuteNonQuery();


                    if (cantidad < 1)
                    {
                        MessageBox.Show("Ocurrió un problema");
                    }

                    else
                    {
                        MessageBox.Show("Se asignó el nuevo mentor con éxito!!!");
                    }

                    OleDbCommand comando2 = new OleDbCommand(consulta4, cn);

                    int cantidad1 = comando2.ExecuteNonQuery();


                    if (cantidad1 < 1)
                    {
                        MessageBox.Show("Ocurrió un problema");
                    }

                    else
                    {
                        MessageBox.Show("Se registró el mentoreado con éxito!!!");
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBoxDNI.Text == "") || (textBoxNombre.Text) == "")
            {
                MessageBox.Show("No puede dejar campos vacíos, por favor seleccione un miembro.");
                button2.Enabled = false;
            }
            else
            {
                
                OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb");
                cn.Open();
                String consulta3 = "UPDATE Miembros SET id_mentor = NULL WHERE DNI = '" + int.Parse(textBoxDNI.Text) + "';";
                OleDbCommand comando1 = new OleDbCommand(consulta3, cn);

                int cantidad = comando1.ExecuteNonQuery();


                if (cantidad < 1)
                {
                    MessageBox.Show("Ocurrió un problema");
                }

                else
                {
                    MessageBox.Show("El Miembro elegido, ya no tiene un mentor asignado.");
                }
            }
        }
    }
}






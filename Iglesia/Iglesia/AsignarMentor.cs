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
    public partial class AsignarMentor : Form
    {
        private OleDbConnection conexion;
        private OleDbDataAdapter adaptador;
        private DataSet dataSet;

        public AsignarMentor()
        {
            InitializeComponent();

        }

        private void AsignarMentor_Load(object sender, EventArgs e)
        {
            ConfigurarDGV1();
            CargarMiembros();
            ConfigurarDGV2();
            CargarMentores();
        }
        private void ConfigurarDGV1()
        {
            // Configura el DataGridView (DGV) para que no genere automáticamente las columnas.
            DGV1.AutoGenerateColumns = false;

            // Crea y agrega las columnas manualmente en el orden deseado.

            // Columna id_miembro
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "id_miembro"; // Nombre de la columna en el origen de datos
            colId.HeaderText = "Nro de Miembro";
            colId.DisplayIndex = 0;
            DGV1.Columns.Add(colId);


            // Columna DNI
            DataGridViewTextBoxColumn colDNI = new DataGridViewTextBoxColumn();
            colDNI.DataPropertyName = "DNI"; // Nombre de la columna en el origen de datos
            colDNI.HeaderText = "DNI";
            colDNI.DisplayIndex = 1;
            DGV1.Columns.Add(colDNI);


            // Columna Nombre
            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.DataPropertyName = "Nombre"; // Nombre de la columna en el origen de datos
            colNombre.HeaderText = "Nombre";
            colNombre.DisplayIndex = 2;
            DGV1.Columns.Add(colNombre);

            // Columna Apellido
            DataGridViewTextBoxColumn colApellido = new DataGridViewTextBoxColumn();
            colApellido.DataPropertyName = "Apellido"; // Nombre de la columna en el origen de datos
            colApellido.HeaderText = "Apellido";
            colApellido.DisplayIndex = 3;
            DGV1.Columns.Add(colApellido);

            // Columna Fecha de alta del miembro
            DataGridViewTextBoxColumn colFechaAsignacion = new DataGridViewTextBoxColumn();
            colFechaAsignacion.DataPropertyName = "Fecha_alta"; // Nombre de la columna en el origen de datos
            colFechaAsignacion.HeaderText = "Alta del miembro";
            colFechaAsignacion.DisplayIndex = 4;
            DGV1.Columns.Add(colFechaAsignacion);

            // Columna ID Mentor
            DataGridViewTextBoxColumn colIdMentor = new DataGridViewTextBoxColumn();
            colIdMentor.DataPropertyName = "id_mentor"; // Nombre de la columna en el origen de datos
            colIdMentor.HeaderText = " Mentor N°";
            colIdMentor.DisplayIndex = 5;
            DGV1.Columns.Add(colIdMentor);

        }
        private void CargarMiembros()
        {
            // Establece la cadena de conexión a tu archivo de base de datos Access (MDB).
            string connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";

            // Crea una conexión a la base de datos.
            conexion = new OleDbConnection(connectionString);

            // Define la consulta SQL para seleccionar los registros con ID_Mentor vacío.
            string consulta = "SELECT id_miembro, DNI, nombre, apellido, fecha_alta, id_mentor FROM Miembros WHERE id_mentor IS NULL";

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
        private void ConfigurarDGV2()
        {
            // Configura el DataGridView (DGV) para que no genere automáticamente las columnas.
            DGV2.AutoGenerateColumns = false;

            // Crea y agrega las columnas manualmente en el orden deseado.

            // Columna id_mentor
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "id_mentor"; // Nombre de la columna en el origen de datos
            colId.HeaderText = "Nro de Mentor";
            colId.DisplayIndex = 0;
            DGV2.Columns.Add(colId);

            // Columna Nombre
            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.DataPropertyName = "Nombre"; // Nombre de la columna en el origen de datos
            colNombre.HeaderText = "Nombre";
            colNombre.DisplayIndex = 1;
            DGV2.Columns.Add(colNombre);

            // Columna Apellido
            DataGridViewTextBoxColumn colApellido = new DataGridViewTextBoxColumn();
            colApellido.DataPropertyName = "Apellido"; // Nombre de la columna en el origen de datos
            colApellido.HeaderText = "Apellido";
            colApellido.DisplayIndex = 2;
            DGV2.Columns.Add(colApellido);

            // Columna DNI
            DataGridViewTextBoxColumn colDNI = new DataGridViewTextBoxColumn();
            colDNI.DataPropertyName = "DNI"; // Nombre de la columna en el origen de datos
            colDNI.HeaderText = "DNI";
            colDNI.DisplayIndex = 3;
            DGV2.Columns.Add(colDNI);

            // Columna cantidad
            DataGridViewTextBoxColumn colCantidad = new DataGridViewTextBoxColumn();
            colCantidad.DataPropertyName = "cantidad"; // Nombre de la columna en el origen de datos
            colCantidad.HeaderText = "Total de asignaciones";
            colCantidad.DisplayIndex = 4;
            DGV2.Columns.Add(colCantidad);

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

            textBoxIDMiembro.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxDNI.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells[1].Value.ToString();
            textBoxNombre.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells[2].Value.ToString();

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

            textBoxIdMentor.Text = DGV2.Rows[DGV2.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxNombreMentor.Text = DGV2.Rows[DGV2.CurrentRow.Index].Cells[1].Value.ToString();
            textBoxCantidad.Text = DGV2.Rows[DGV2.CurrentRow.Index].Cells[4].Value.ToString();
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

                    DateTime fechaAsignacion = DateTime.Now.Date;

                    // MessageBox.Show((fechaAsignacion).ToString());
                    OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb");
                    cn.Open();
                    String consulta3 = "UPDATE Miembros SET id_mentor ='" + int.Parse(textBoxIdMentor.Text) + "' " + " WHERE DNI = " + int.Parse(textBoxDNI.Text) + ";";
                    String consulta4 = "UPDATE Mentores SET cantidad = cantidad + 1" + " WHERE id_mentor = " + int.Parse(textBoxIdMentor.Text) + ";";
                    //agregar consulta para registrar fecha de asignacion de mentor en tabla asignaciones
                    string consulta5 = "INSERT INTO AsignacionMentor (id_miembro, id_mentor, fecha_asignacion) values (" + int.Parse(textBoxIDMiembro.Text) + "," + int.Parse(textBoxIdMentor.Text) + "," + "'" + fechaAsignacion + "');";

                    OleDbCommand comando1 = new OleDbCommand(consulta3, cn);

                    int cantidad = comando1.ExecuteNonQuery();


                    if (cantidad < 1)
                    {
                        MessageBox.Show("Ocurrió un problema");
                    }

                    else
                    {
                        MessageBox.Show("Se asignó el mentor con éxito!!!");
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

                    OleDbCommand comando3 = new OleDbCommand(consulta5, cn);
                    int cantidad2 = comando3.ExecuteNonQuery();

                    if (cantidad2 < 1)
                    {
                        MessageBox.Show("ocurrio un error en la tabla asignacion");
                    }
                    else
                    {

                        MessageBox.Show("se registró la asignación con exito en la tabla asignaciones");

                    }

                    CargarMiembros();
                    CargarMentores();
                }
            }

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxIDMiembro.Text = "";
            textBoxDNI.Text = "";
            textBoxNombre.Text = "";
            textBoxIdMentor.Text = "";
            textBoxNombreMentor.Text = "";
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AltaMentores Form1 = new AltaMentores();
            Form1.Show();

        }

        private void textBoxCantidad_TextChanged(object sender, EventArgs e )
        {

        }
    }
}






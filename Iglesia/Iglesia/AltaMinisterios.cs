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
    public partial class AltaMinisterios : Form
    {
        private OleDbConnection conexion;
        private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
        private OleDbDataAdapter adaptador;
        private DataSet dataSet;
        public AltaMinisterios()
        {
            InitializeComponent();
            conexion = new OleDbConnection(cadenaConexion);
            CargarMinisterios();
        }

        private void CargarMinisterios()
        {
            // Establece la cadena de conexión a tu archivo de base de datos Access (MDB).
            string connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";

            // Crea una conexión a la base de datos.
            conexion = new OleDbConnection(connectionString);

            // Define la consulta SQL para seleccionar los registros con ID_Mentor vacío.
            string consulta = "SELECT id_ministerio AS Nro_Ministerio, nombreMinisterio AS Nombre_Ministerio FROM ministerios";

            // Crea un adaptador de datos para ejecutar la consulta y llenar el DataSet.
            adaptador = new OleDbDataAdapter(consulta, conexion);

            // Crea un DataSet para almacenar los datos.
            dataSet = new DataSet();

            // Abre la conexión y llena el DataSet con los datos de la tabla Miembros.
            conexion.Open();
            adaptador.Fill(dataSet, "Ministerios");
            conexion.Close();

            // Enlaza el DataGridView (DGV1) con el DataSet.
            DGVMini.DataSource = dataSet.Tables["Ministerios"];
        }
        private void buttonCrearMinisterio_Click(object sender, EventArgs e)
        {
            if (textBoxNombreMini.Text == "")
            {
                MessageBox.Show("Por favor, escriba un nombre para el Ministerio que quiere crear. No debe quedar el campo vacío.");
            }
            else
            {

                string consulta = "INSERT INTO Ministerios (nombreMinisterio) VALUES ('" + textBoxNombreMini.Text + "');";

                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                conexion.Open();

                int cantidad3 = comando.ExecuteNonQuery();

                if (cantidad3 < 1)
                {
                    MessageBox.Show("Ocurrió un problema");
                }

                else
                {
                    MessageBox.Show("Se registro el nuevo Ministerio correctamente");
                }
                conexion.Close();

            }
        }

       

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombreMini.Text = string.Empty;
        }

        

        private void textBoxNombreMini_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            buttonCrearMinisterio.Enabled = true;
        }
    }
}

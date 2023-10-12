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
    public partial class PostulacionesRevisar : Form
    {
        private OleDbConnection conexion;
        private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
        public PostulacionesRevisar()
        {
            InitializeComponent();
            conexion = new OleDbConnection(cadenaConexion);
        }

        private void PostulacionesRevisar_Load(object sender, EventArgs e)
        {
            cargarDGV();
        }
        private void cargarDGV()
        {
            

            // Consulta SQL
            string consulta = "SELECT *FROM postulaciones WHERE aprobado = false";

            using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
            {
               // comando.Parameters.AddWithValue("@ID_Mentor", idMentor);
               // comando.Parameters.AddWithValue("@ID_Miembro", idMiembro);
                //comando.Parameters.AddWithValue("@ID_Etapa", idEtapa);

                try
                {
                    conexion.Open();
                    DataTable dataTable = new DataTable();
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                    adaptador.Fill(dataTable);
                    DGV1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }
    }
}

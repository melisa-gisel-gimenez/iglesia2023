using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            ConfigurarDGV1();


        }
        private void cargarDGV()
        {
            string consulta = "SELECT p.id_postulacion,p.id_mentor,p.id_miembro,p.id_etapaespiritual,p.aprobado,m.nombre,m.apellido,m.id_etapaespiritual AS id_etapaespiritual_miembro,ee.etapaEspiritual,ce.fecha_alta_etapa,ce.fecha_fin_etapa " +
                "FROM ((postulaciones p " +
                "INNER JOIN Miembros m ON p.id_miembro = m.id_miembro)" +
                "INNER JOIN EtapaEspiritual ee ON p.id_etapaespiritual = ee.id_etapaespiritual)" +
                "LEFT JOIN CambioEtapas ce ON p.id_miembro = ce.id_miembro " +
                "WHERE p.aprobado = false " +
                "AND ce.fecha_fin_etapa IS NULL;";


            using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
            {


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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConfigurarDGV1()
        {
            DGV1.Columns["id_postulacion"].DisplayIndex = 0;
            DGV1.Columns["id_mentor"].DisplayIndex = 1;
            DGV1.Columns["id_miembro"].DisplayIndex = 2;
            DGV1.Columns["nombre"].DisplayIndex = 3;
            DGV1.Columns["apellido"].DisplayIndex = 4;
            DGV1.Columns["id_etapaespiritual_miembro"].DisplayIndex = 5;
            DGV1.Columns["fecha_alta_etapa"].DisplayIndex = 6;
            DGV1.Columns["id_etapaespiritual"].DisplayIndex = 7;
            DGV1.Columns["etapaEspiritual"].DisplayIndex = 8;
            DGV1.Columns["fecha_fin_etapa"].DisplayIndex = 9;
            DGV1.Columns["aprobado"].DisplayIndex = 10;

            // Cambiar los nombres de los encabezados de las columnas
            DGV1.Columns["id_postulacion"].HeaderText = "Postulación N°";
            DGV1.Columns["id_mentor"].HeaderText = "Mentor N°";
            DGV1.Columns["id_miembro"].HeaderText = "Miembro N°";
            DGV1.Columns["nombre"].HeaderText = "Nombre";
            DGV1.Columns["apellido"].HeaderText = "Apellido";
            DGV1.Columns["id_etapaespiritual_miembro"].HeaderText = "Etapa Actual";
            DGV1.Columns["fecha_alta_etapa"].HeaderText = "Desde";
            DGV1.Columns["id_etapaespiritual"].HeaderText = "ID Proxima Etapa";
            DGV1.Columns["etapaEspiritual"].HeaderText = "Proxima Etapa";
            DGV1.Columns["fecha_fin_etapa"].HeaderText = "Fecha Fin Etapa";
            DGV1.Columns["aprobado"].HeaderText = "Aprobar?";

        }
        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelIDPostulacion.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells[0].Value.ToString();
            labelIDMiembro.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells[2].Value.ToString();
            labelIDProxEtapa.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells[7].Value.ToString();
            //labelFechaAlta.Text= DGV1.Rows[DGV1.CurrentRow.Index].Cells[9].Value.ToString();
        }

        private void buttonAprobar_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;

            if (labelIDPostulacion.Text == "")
            {
                MessageBox.Show("Por favor, haga click en la celda de la postulación que quiere aprobar");
            }
            else
            {
                string cadenaUpdate = "UPDATE Postulaciones SET aprobado = true WHERE Id_postulacion = @IdPostulacion";


                OleDbCommand comando = new OleDbCommand(cadenaUpdate, conexion);
                conexion.Open();

                comando.Parameters.AddWithValue("@IdPostulacion", labelIDPostulacion.Text);

                int cantidad = comando.ExecuteNonQuery();


                if (cantidad < 1)
                {
                    MessageBox.Show("Ocurrió un problema");
                }

                else
                {
                    MessageBox.Show("Se aprobo la postulación con exito!");
                }
                conexion.Close();
            }

            if (labelIDProxEtapa.Text == "1")
            {
                string cadena2 = "UPDATE MIEMBROS SET id_etapaespiritual = 2 WHERE id_miembro = @IdMiembro";
                OleDbCommand comando = new OleDbCommand(cadena2, conexion);
                conexion.Open();

                comando.Parameters.AddWithValue("@IdMiembro", labelIDMiembro.Text);
                int cantidad = comando.ExecuteNonQuery();


                if (cantidad < 1)
                {
                    MessageBox.Show("Ocurrió un problema");
                }

                else
                {
                    MessageBox.Show("Se aprobo la postulación con exito!");
                }

                string cadenaFecha = "UPDATE CAMBIOETAPAS SET fecha_fin_etapa ='" + fecha + "'" + " WHERE id_miembro = @IdMiembro";
                OleDbCommand comando2 = new OleDbCommand(cadenaFecha, conexion);

                comando2.Parameters.AddWithValue("@IdMiembro", labelIDMiembro.Text);
                int cantidad2 = comando2.ExecuteNonQuery();

                if (cantidad2 < 1)
                {
                    MessageBox.Show("Ocurrió un problema");
                }

                else
                {
                    MessageBox.Show("Se registro el cambio con exito!");
                }

                string cadenaFecha2 = "INSERT INTO CambioEtapas (id_miembro, id_etapaEspiritual, fecha_alta_etapa) VALUES ('" + labelIDMiembro.Text + "', " + "'2', " + "'" + fecha + "');";
                OleDbCommand comando3 = new OleDbCommand(cadenaFecha2, conexion);
                int cantidad3 = comando3.ExecuteNonQuery();

                if (cantidad3 < 1)
                {
                    MessageBox.Show("Ocurrió un problema");
                }

                else
                {
                    MessageBox.Show("Se registro la fecha de la nueva etapa con exito!");
                }
                conexion.Close();
            }

            if (labelIDProxEtapa.Text == "2")
            {
                string cadena3 = "UPDATE MIEMBROS SET id_etapaespiritual = 3 WHERE id_miembro = @IdMiembro";
                OleDbCommand comando = new OleDbCommand(cadena3, conexion);
                conexion.Open();

                comando.Parameters.AddWithValue("@IdMiembro", labelIDMiembro.Text);

                int cantidad = comando.ExecuteNonQuery();


                if (cantidad < 1)
                {
                    MessageBox.Show("Ocurrió un problema");
                }

                else
                {
                    MessageBox.Show("Se aprobo la postulación con exito!");
                }

                string cadenaFecha = "UPDATE CAMBIOETAPAS SET fecha_fin_etapa ='" + fecha + "'" + " WHERE id_miembro = @IdMiembro";
                OleDbCommand comando2 = new OleDbCommand(cadenaFecha, conexion);

                comando2.Parameters.AddWithValue("@IdMiembro", labelIDMiembro.Text);
                int cantidad2 = comando2.ExecuteNonQuery();

                if (cantidad2 < 1)
                {
                    MessageBox.Show("Ocurrió un problema");
                }

                else
                {
                    MessageBox.Show("Se registro el cambio con exito!");
                }

                string cadenaFecha2 = "INSERT INTO CambioEtapas (id_miembro, id_etapaEspiritual, fecha_alta_etapa) VALUES ('" + labelIDMiembro.Text + "', " + "'3', " + "'" + fecha + "');";
                OleDbCommand comando3 = new OleDbCommand(cadenaFecha2, conexion);
                int cantidad3 = comando3.ExecuteNonQuery();

                if (cantidad3 < 1)
                {
                    MessageBox.Show("Ocurrió un problema");
                }

                else
                {
                    MessageBox.Show("Se registro la fecha de la nueva etapa con exito!");
                }
                conexion.Close();

            }
        }
    }
}

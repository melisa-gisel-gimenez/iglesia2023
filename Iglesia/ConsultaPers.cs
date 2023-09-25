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
    public partial class ConsultaPers : Form
    {
        public ConsultaPers()
        {
            InitializeComponent();
        }

        private void ConsultaPers_Load(object sender, EventArgs e)
        {
            dgvConsultaPersonas.Columns.Add("0", "Dni");
            dgvConsultaPersonas.Columns.Add("1", "Nombre");
            dgvConsultaPersonas.Columns.Add("2", "Apellido");
            dgvConsultaPersonas.Columns.Add("3", "Dirección");
            dgvConsultaPersonas.Columns.Add("4", "Barrio");
            dgvConsultaPersonas.Columns.Add("5", "Teléfono");
            dgvConsultaPersonas.Columns.Add("6", "Consolidador");
            dgvConsultaPersonas.Columns.Add("7", "Fecha de Nacimiento");
            //dgvConsultaPersonas.Columns.Add("8", "Datos adicionales");
            /*dgvConsultaPersonas.Columns.Add("9", "Puesto 2");
            dgvConsultaPersonas.Columns.Add("10", "Puesto 3");
            dgvConsultaPersonas.Columns.Add("11", "Puesto 4");*/

            dgvConsultaPersonas.Columns[0].ReadOnly = true;
            dgvConsultaPersonas.Columns[1].ReadOnly = true;
            dgvConsultaPersonas.Columns[2].ReadOnly = true;
            dgvConsultaPersonas.Columns[3].ReadOnly = true;
            dgvConsultaPersonas.Columns[4].ReadOnly = true;
            dgvConsultaPersonas.Columns[5].ReadOnly = true;
            dgvConsultaPersonas.Columns[6].ReadOnly = true;
            dgvConsultaPersonas.Columns[7].ReadOnly = true;
            //dgvConsultaPersonas.Columns[8].ReadOnly = true;
            /*dgvConsultaPersonas.Columns[9].ReadOnly = true;
            dgvConsultaPersonas.Columns[10].ReadOnly = true;
            dgvConsultaPersonas.Columns[11].ReadOnly = true;*/



            AbrirBd();
        }

        private void AbrirBd()
        {
            OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\lguzman\Documents\Iglesia.accdb");
            conexion.Open();
            string Consulta = "select * from Personas;";
            OleDbCommand comando = new OleDbCommand(Consulta, conexion);
            OleDbDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                dgvConsultaPersonas.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(),
                    dr[5].ToString(), dr[6].ToString(), dr[7].ToString()/*, dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString()*/);
            }

        }
    private void dgvConsultaPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvConsultaPersonas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ConsultaPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvConsultaPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetallePersonas2 Ventana = new DetallePersonas2();

            foreach (DataGridViewRow fila in dgvConsultaPersonas.SelectedRows)
            {
                Ventana.TxtDNI.Text = fila.Cells[0].Value.ToString();
                Ventana.TxtNombre.Text = fila.Cells[1].Value.ToString() + " " + fila.Cells[2].Value.ToString();
                Ventana.TxtConsolidador.Text = fila.Cells[6].Value.ToString();
                //Ventana.txtDireccion.Text = fila.Cells[3].Value.ToString();


            }

            Ventana.Show();
        }
    }
}

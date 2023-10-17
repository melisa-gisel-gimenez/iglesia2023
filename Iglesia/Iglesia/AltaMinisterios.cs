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
        
        public AltaMinisterios()
        {
            InitializeComponent();
            conexion = new OleDbConnection(cadenaConexion);
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
        
    }
}

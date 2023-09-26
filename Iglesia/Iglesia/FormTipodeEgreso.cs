using Azure.Messaging.EventGrid.SystemEvents;
using ControlIngresoEgreso.Clases;
using ControlIngresoEgreso.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iglesia
{
    public partial class FormTipodeEgreso : Form
    {
        public FormTipodeEgreso()
        {
            InitializeComponent();
        }
        bool Editar;
        int IdTipodeEgresos;
        private void FormTipodeEgreso_Load(object sender, EventArgs e)
        {
            ListarGrid();

        }
        private void ListarGrid()
        {
            dvgDatos.DataSource=TipodeEgreso.Listar();
            Dbdatos.OcultarIds(dgvDatos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Validacion()) return;
            if (!Guardar()) return;

            finalizar();

        }

        private void finalizar()
        {
            ListarGrid();
            limpiar();
        }

        private void limpiar()
        {
            txtEgreso.Text = "";
            Editar = false;
        }

        private bool Validacion()

            if (string IsNullOWhiteSpace (txtEgreso.Text))

        { MessageBox.Show("Ingresar Denominacion")
                return false;
private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
    }
        return true;
        private bool Guardar()

        {
        TipoEgreso tipoEgreso = new TipoEgreso
        {
            Denominacion = txtEgreso.text,
            IdTipodeEgresos = IdtipodeEgresos
        };
        return TipoEgreso.Guardar(TipodeEgresos, Editar);
        }

}
            

    

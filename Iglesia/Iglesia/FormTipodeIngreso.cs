using ControlIngresoEgreso.Clases;
using ControlIngresoEgreso.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iglesia
{
    public partial class FormTipodeIngreso : Form
    {
        public FormTipodeIngreso()
        {
            InitializeComponent();

        }
        bool Editar;
        int IdTipodeIngreso;


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            txtIngreso.Text = "";
            Editar = false;
        }
        private bool Guardar()
        {
            TipoIngreso tipoIngreso = new TipodeIngreso
            {
                Denominacion = txtIngreso.Text,
                IdTipodeIngreso = IdtipodeIngreso
            };
            return TipoIngreso.Guardar(TipodeIngreso, Editar);
        }
          private void finalizar()
           {
            ListarGrid();
            limpiar();
            }

     private void limpiar()
    {
        txtIngreso.Text = "";
        Editar = false;
    }
    

        private bool Validacion() 
        { 
            if (string.IsNullOrWhiteSpace(txtIngreso.Text))

            { MessageBox.Show("Ingresar Denominacion"); 
                return false; 
            }   
                
             return false; 
            return true; 
        }
        private void finalizar()
        {
            ListarGrid();
            Limpiar();
        }

        private void FormTipodeIngreso_Load(object sender, EventArgs e)
        {
            ListarGrid();

        }
        private void ListarGrid()
        {
            dvgDatos.DataSource = TipodeIngreso.Listar();
            Dbdatos.OcultarIds(dgvDatos);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


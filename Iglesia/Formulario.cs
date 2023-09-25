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
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetIglesia.Personas' Puede moverla o quitarla según sea necesario.
            this.PersonasTableAdapter.Fill(this.DataSetIglesia.Personas);

            this.reportViewer1.RefreshReport();
        }
    }
}

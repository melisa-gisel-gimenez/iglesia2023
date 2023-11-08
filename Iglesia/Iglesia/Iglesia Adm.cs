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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
       

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
             AcercaDe Form1 = new AcercaDe();
             Form1.Show();
        }

        private void tesoreríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tesorería Form1 = new Tesorería();
            //Form1.ShowDialog();
        }
               

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }        
                

        private void cargarPersonasNuevasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarPersonas Form1 = new AgregarPersonas();
            Form1.Show();

       
        }

                

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
           
       

        private void asignarMentorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarMentor Form1 = new AsignarMentor();
            Form1.Show();
        }

        private void modificarMentoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarMentor Form1 = new ModificarMentor();
            Form1.Show();
        }

        private void modificarDatosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar_Personas Form1 = new Modificar_Personas();
            Form1.Show();
        }

        private void inhabilitarPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InhabilitarPersonas Form1 = new InhabilitarPersonas();
            Form1.Show();
        }

        private void altaDeMentoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaMentores Form1 =new AltaMentores();
            Form1.Show();
        }

        private void postularMiembrosADiscipuladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PostularADiscipulado Form1 = new PostularADiscipulado();
            Form1.Show();
        }

        private void postulacionesPorRevisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PostulacionesRevisar Form1 = new PostulacionesRevisar();
            Form1 .Show();
        }

        private void altaMinisteriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaMinisterios Form1 = new AltaMinisterios();
            Form1.Show();
        }

        private void registroDeReunionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroReunionesMentor Form1 = new RegistroReunionesMentor();
            Form1.Show();
        }

        private void altaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaUsuarios Form1 = new AltaUsuarios();
            Form1.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginJuli Form1 = new LoginJuli();
            Form1.Show();
        }
    }
}

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

        private void santaSenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SantaCena Form1 = new SantaCena();
            Form1.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acerca_de Form1 = new Acerca_de();
            Form1.ShowDialog();
        }

        private void tesoreríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tesorería Form1 = new Tesorería();
            Form1.ShowDialog();
        }

        private void ensayosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ensayos Form1 = new Ensayos();
            Form1.ShowDialog();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void asistenciaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AsistenciaEnsayos Form1 = new AsistenciaEnsayos();
            Form1.ShowDialog();
        }

        private void informesToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            CronogramaEnsayo Form1 = new CronogramaEnsayo();
            Form1.ShowDialog();
        }

        private void limpiezaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpieza Form1 = new Limpieza();
            Form1.ShowDialog();
        }

        private void cronogramaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CronogramaLimpieza Form1 = new CronogramaLimpieza();
            Form1.ShowDialog();
        }

        private void asistenciaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            AsistenciaLimpieza Form1 = new AsistenciaLimpieza();
            Form1.ShowDialog();
        }

        private void informesToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            informeLimpieza Form1 = new informeLimpieza();
            Form1.ShowDialog();
        }

        private void asistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsistenciaCelulas Form1 = new AsistenciaCelulas();
            Form1.ShowDialog();
        }

        private void informeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformeCelulas Form1 = new InformeCelulas();
            Form1.ShowDialog();
        }

        private void calendarioDeActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalendarioActividades Form1 = new CalendarioActividades();
            Form1.ShowDialog();
        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsistenciaJovenes Form1 = new AsistenciaJovenes();
            Form1.ShowDialog();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformeJovenes Form1 = new InformeJovenes();
            Form1.ShowDialog();
        }

        private void asistenciaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AsistenciaNiños Form1 = new AsistenciaNiños();
            Form1.ShowDialog();
        }

        private void informesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InformeNiños Form1 = new InformeNiños();
            Form1.ShowDialog();
        }

        private void asistenciaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AsistenciaScautt Form1 = new AsistenciaScautt();
            Form1.ShowDialog();
        }

        private void informesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            InformeScautt Form1 = new InformeScautt();
            Form1.ShowDialog();
        }

        private void informesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AlabAdorInforme Form1 = new AlabAdorInforme();
            Form1.ShowDialog();
        }

        private void consultarPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPers Form1 = new ConsultaPers();
            Form1.ShowDialog();
        }

        private void cargarPersonasNuevasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionarPersonas Form1 = new GestionarPersonas();
            Form1.Show();

       
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GestionarPersonas Form1 = new GestionarPersonas();
            Form1.Show();
        }
    }
}

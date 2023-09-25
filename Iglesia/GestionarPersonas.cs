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
//using NegocioListar;
//using EntidadListar;

namespace Iglesia
{
    public partial class GestionarPersonas : Form
    {
        //NegListar NegObjDNI = new NegListar();
        //EntListar EntObjDNI = new EntListar();

        public GestionarPersonas()
        {
            InitializeComponent();

            //comboBox1.DataSource = NegObjDNI.ObtenerDNI();
            //comboBox1.DisplayMember = "_dni";

            BtnEliminar.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Agregar_Personas ventana = new Agregar_Personas();
            ventana.Show();

            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Modificar_Personas ventana = new Modificar_Personas();


            foreach (DataGridViewRow fila in dgvConsultaPersonas.SelectedRows)
            {
                ventana.txtDNI.Text = fila.Cells[0].Value.ToString();
                ventana.txtNombre.Text = fila.Cells[1].Value.ToString();
                ventana.txtApellido.Text = fila.Cells[2].Value.ToString();
                ventana.txtDireccion.Text = fila.Cells[3].Value.ToString();
                ventana.txtBarrio.Text = fila.Cells[4].Value.ToString();
                ventana.txtTelefono.Text = fila.Cells[5].Value.ToString();
                ventana.textBox1.Text = fila.Cells[6].Value.ToString();
                ventana.dateTimePicker1.Text = fila.Cells[7].Value.ToString();


            }

            ventana.Show();

            Close();
        }

        private void GestionarPersonas_Load(object sender, EventArgs e)
        {

            //comboBox1.DataSource = Listar();
            //comboBox1.DisplayMember = "IdDNI";
            BtnPuesto.Visible = false;
            DgvPuesto.Visible = false;

            dgvConsultaPersonas.Columns.Add("0", "Dni");
            dgvConsultaPersonas.Columns.Add("1", "Nombre");
            dgvConsultaPersonas.Columns.Add("2", "Apellido");
            dgvConsultaPersonas.Columns.Add("3", "Dirección");
            dgvConsultaPersonas.Columns.Add("4", "Barrio");
            dgvConsultaPersonas.Columns.Add("5", "Teléfono");
            dgvConsultaPersonas.Columns.Add("6", "Consolidador");
            dgvConsultaPersonas.Columns.Add("7", "Fecha de Nacimiento");
            //dgvConsultaPersonas.Columns.Add("8", "Puesto1");
            //dgvConsultaPersonas.Columns.Add("9", "Puesto2");

            dgvConsultaPersonas.Columns[0].ReadOnly = true;
            dgvConsultaPersonas.Columns[1].ReadOnly = true;
            dgvConsultaPersonas.Columns[2].ReadOnly = true;
            dgvConsultaPersonas.Columns[3].ReadOnly = true;
            dgvConsultaPersonas.Columns[4].ReadOnly = true;
            dgvConsultaPersonas.Columns[5].ReadOnly = true;
            dgvConsultaPersonas.Columns[6].ReadOnly = true;
            dgvConsultaPersonas.Columns[7].ReadOnly = true;
            //dgvConsultaPersonas.Columns[8].ReadOnly = true;
            //dgvConsultaPersonas.Columns[9].ReadOnly = true;

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
                    dr[5].ToString(), dr[6].ToString(), dr[7].ToString()/*, dr[8].ToString(), dr[9].ToString()*/);
            }
        }

        private void Listar()

        { 
            OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\lguzman\Documents\Iglesia.accdb");
        conexion.Open();
            string Consulta = "select Nombre from Personas;";
        OleDbCommand comando = new OleDbCommand(Consulta, conexion);
        OleDbDataReader dr = comando.ExecuteReader();
        //while (dr.Read())
        //{

        //    //comboBox1.Text = dr[0].ToString();
        //    comboBox1.Text = dr[0].ToString();
        //}
    }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formulario VentanaFormulario = new Formulario();
            VentanaFormulario.Show();
        }

        public void Cualquiera()
        {

            foreach (DataGridViewRow fila in dgvConsultaPersonas.Rows)
            {
                //if (fila.Cells[0].Value != null)
                if (fila.Cells[0].Value.ToString() == TxtDNI.Text)
                {
                    //si la encuentra la cambia de color//
                    fila.Cells[0].Style.BackColor = Color.Red;
                    fila.Cells[1].Style.BackColor = Color.Red;
                    fila.Cells[2].Style.BackColor = Color.Red;
                    fila.Cells[3].Style.BackColor = Color.Red;
                    fila.Cells[4].Style.BackColor = Color.Red;
                    fila.Cells[5].Style.BackColor = Color.Red;
                    fila.Cells[6].Style.BackColor = Color.Red;
                    fila.Cells[7].Style.BackColor = Color.Red;
                    TxtNom.Text = fila.Cells[1].Value.ToString();
                    TxtApellido.Text = fila.Cells[2].Value.ToString();
                    TxtDirec.Text = fila.Cells[3].Value.ToString();
                    TxtBarrio.Text = fila.Cells[4].Value.ToString();
                    TxtTel.Text = fila.Cells[5].Value.ToString();
                    TxtSexo.Text = fila.Cells[6].Value.ToString();
                    if (TxtDNI.Text != "")
                    {
                        BtnEliminar.Enabled = true;
                    }
                    //Agregar la fecha
                    //BtnPuesto.Visible = true;
                    //BtnPuesto.Enabled = true;
                    //DgvPuesto.Visible = true;
                    break;

                }
                else if (fila.Cells[1].Value.ToString() == TxtNom.Text)
                {
                    fila.Cells[0].Style.BackColor = Color.Red;
                    fila.Cells[1].Style.BackColor = Color.Red;
                    fila.Cells[2].Style.BackColor = Color.Red;
                    fila.Cells[3].Style.BackColor = Color.Red;
                    fila.Cells[4].Style.BackColor = Color.Red;
                    fila.Cells[5].Style.BackColor = Color.Red;
                    fila.Cells[6].Style.BackColor = Color.Red;
                    fila.Cells[7].Style.BackColor = Color.Red;
                    TxtDNI.Text = fila.Cells[0].Value.ToString();
                    TxtApellido.Text = fila.Cells[2].Value.ToString();
                    TxtDirec.Text = fila.Cells[3].Value.ToString();
                    TxtBarrio.Text = fila.Cells[4].Value.ToString();
                    TxtTel.Text = fila.Cells[5].Value.ToString();
                    TxtSexo.Text = fila.Cells[6].Value.ToString();
                    if (TxtDNI.Text != "")
                    {
                        BtnEliminar.Enabled = true;
                    }
                    //Agregar la fecha
                    //BtnPuesto.Visible = true;
                    //BtnPuesto.Enabled = true;
                    //DgvPuesto.Visible = true;
                    break;
                }

                else if (fila.Cells[2].Value.ToString() == TxtApellido.Text)
                {
                    fila.Cells[0].Style.BackColor = Color.Red;
                    fila.Cells[1].Style.BackColor = Color.Red;
                    fila.Cells[2].Style.BackColor = Color.Red;
                    fila.Cells[3].Style.BackColor = Color.Red;
                    fila.Cells[4].Style.BackColor = Color.Red;
                    fila.Cells[5].Style.BackColor = Color.Red;
                    fila.Cells[6].Style.BackColor = Color.Red;
                    fila.Cells[7].Style.BackColor = Color.Red;
                    TxtDNI.Text = fila.Cells[0].Value.ToString();
                    TxtNom.Text = fila.Cells[1].Value.ToString();
                    TxtDirec.Text = fila.Cells[3].Value.ToString();
                    TxtBarrio.Text = fila.Cells[4].Value.ToString();
                    TxtTel.Text = fila.Cells[5].Value.ToString();
                    TxtSexo.Text = fila.Cells[6].Value.ToString();
                    if (TxtDNI.Text != "")
                    {
                        BtnEliminar.Enabled = true;
                    }
                    //Agregar la fecha
                    //BtnPuesto.Visible = true;
                    //BtnPuesto.Enabled = true;
                    //DgvPuesto.Visible = true;
                    break;

                }
                else if (fila.Cells[3].Value.ToString() == TxtDirec.Text)
                {
                    fila.Cells[0].Style.BackColor = Color.Red;
                    fila.Cells[1].Style.BackColor = Color.Red;
                    fila.Cells[2].Style.BackColor = Color.Red;
                    fila.Cells[3].Style.BackColor = Color.Red;
                    fila.Cells[4].Style.BackColor = Color.Red;
                    fila.Cells[5].Style.BackColor = Color.Red;
                    fila.Cells[6].Style.BackColor = Color.Red;
                    fila.Cells[7].Style.BackColor = Color.Red;
                    TxtDNI.Text = fila.Cells[0].Value.ToString();
                    TxtApellido.Text = fila.Cells[2].Value.ToString();
                    TxtNom.Text = fila.Cells[1].Value.ToString();
                    TxtBarrio.Text = fila.Cells[4].Value.ToString();
                    TxtTel.Text = fila.Cells[5].Value.ToString();
                    TxtSexo.Text = fila.Cells[6].Value.ToString();
                    if (TxtDNI.Text != "")
                    {
                        BtnEliminar.Enabled = true;
                    }
                    //Agregar la fecha
                    //BtnPuesto.Visible = true;
                    //BtnPuesto.Enabled = true;
                    //DgvPuesto.Visible = true;
                    break;
                }

                else if (fila.Cells[4].Value.ToString() == TxtBarrio.Text)
                {
                    fila.Cells[0].Style.BackColor = Color.Red;
                    fila.Cells[1].Style.BackColor = Color.Red;
                    fila.Cells[2].Style.BackColor = Color.Red;
                    fila.Cells[3].Style.BackColor = Color.Red;
                    fila.Cells[4].Style.BackColor = Color.Red;
                    fila.Cells[5].Style.BackColor = Color.Red;
                    fila.Cells[6].Style.BackColor = Color.Red;
                    fila.Cells[7].Style.BackColor = Color.Red;
                    TxtDNI.Text = fila.Cells[0].Value.ToString();
                    TxtApellido.Text = fila.Cells[2].Value.ToString();
                    TxtDirec.Text = fila.Cells[3].Value.ToString();
                    TxtNom.Text = fila.Cells[1].Value.ToString();
                    TxtTel.Text = fila.Cells[5].Value.ToString();
                    TxtSexo.Text = fila.Cells[6].Value.ToString();
                    if (TxtDNI.Text != "")
                    {
                        BtnEliminar.Enabled = true;
                    }
                    //Agregar la fecha
                    //BtnPuesto.Visible = true;
                    //BtnPuesto.Enabled = true;
                    //DgvPuesto.Visible = true;
                    break;
                }

                else if (fila.Cells[5].Value.ToString() == TxtTel.Text)
                {
                    fila.Cells[0].Style.BackColor = Color.Red;
                    fila.Cells[1].Style.BackColor = Color.Red;
                    fila.Cells[2].Style.BackColor = Color.Red;
                    fila.Cells[3].Style.BackColor = Color.Red;
                    fila.Cells[4].Style.BackColor = Color.Red;
                    fila.Cells[5].Style.BackColor = Color.Red;
                    fila.Cells[6].Style.BackColor = Color.Red;
                    fila.Cells[7].Style.BackColor = Color.Red;
                    TxtDNI.Text = fila.Cells[0].Value.ToString();
                    TxtApellido.Text = fila.Cells[2].Value.ToString();
                    TxtDirec.Text = fila.Cells[3].Value.ToString();
                    TxtBarrio.Text = fila.Cells[4].Value.ToString();
                    TxtNom.Text = fila.Cells[1].Value.ToString();
                    TxtSexo.Text = fila.Cells[6].Value.ToString();
                    if (TxtDNI.Text != "")
                    {
                        BtnEliminar.Enabled = true;
                    }
                    //Agregar la fecha
                    //BtnPuesto.Visible = true;
                    //BtnPuesto.Enabled = true;
                    //DgvPuesto.Visible = true;
                    break;
                }
                else if (fila.Cells[6].Value.ToString() == TxtSexo.Text)
                {
                    fila.Cells[0].Style.BackColor = Color.Red;
                    fila.Cells[1].Style.BackColor = Color.Red;
                    fila.Cells[2].Style.BackColor = Color.Red;
                    fila.Cells[3].Style.BackColor = Color.Red;
                    fila.Cells[4].Style.BackColor = Color.Red;
                    fila.Cells[5].Style.BackColor = Color.Red;
                    fila.Cells[6].Style.BackColor = Color.Red;
                    fila.Cells[7].Style.BackColor = Color.Red;
                    TxtDNI.Text = fila.Cells[0].Value.ToString();
                    TxtApellido.Text = fila.Cells[2].Value.ToString();
                    TxtDirec.Text = fila.Cells[3].Value.ToString();
                    TxtBarrio.Text = fila.Cells[4].Value.ToString();
                    TxtTel.Text = fila.Cells[5].Value.ToString();
                    TxtNom.Text = fila.Cells[1].Value.ToString();
                    if (TxtDNI.Text != "")
                    {
                        BtnEliminar.Enabled = true;
                    }
                    //Agregar la fecha
                    //BtnPuesto.Visible = true;
                    //BtnPuesto.Enabled = true;
                    //DgvPuesto.Visible = true;
                    break;
                }



            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            
            //BtnEliminar.Enabled = true;
            /*BtnPuesto.Visible = true;
            DgvPuesto.Visible = true;*/
            if (TxtDNI.Text + TxtDirec.Text + TxtBarrio.Text + TxtApellido.Text + TxtNom.Text + TxtSexo.Text + TxtTel.Text /*+ DtpFechaDeNac.Value.Date*/ == "")
            {
                //BtnPuesto.Visible = false;
                //DgvPuesto.Visible = false;
                MessageBox.Show("No hay datos para buscar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                BtnEliminar.Enabled = false;

                if (TxtDNI.Text != "")
                {
                    BtnEliminar.Enabled = true;
                }
            }

            Cualquiera();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\lguzman\Documents\Iglesia.accdb");
            cn.Open();
            string Eliminar = "Delete From Personas Where IdDNI = " + TxtDNI.Text + ";";
            OleDbCommand cm = new OleDbCommand(Eliminar, cn);
            int cantidad = cm.ExecuteNonQuery();

            MessageBox.Show("Se eliminó con éxito");
            //Limpiar();

            Close();
            GestionarPersonas open = new GestionarPersonas();
            open.Show();
            

                
            
                

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            TxtDNI.Clear();
            TxtNom.Clear();
            TxtApellido.Clear();
            TxtBarrio.Clear();
            TxtDirec.Clear();
            TxtTel.Clear();
            TxtSexo.Clear();
            
            foreach (DataGridViewRow fila in dgvConsultaPersonas.Rows)
            {
                fila.Cells[0].Style.BackColor = Color.White;
                fila.Cells[1].Style.BackColor = Color.White;
                fila.Cells[2].Style.BackColor = Color.White;
                fila.Cells[3].Style.BackColor = Color.White;
                fila.Cells[4].Style.BackColor = Color.White;
                fila.Cells[5].Style.BackColor = Color.White;
                fila.Cells[6].Style.BackColor = Color.White;
                fila.Cells[7].Style.BackColor = Color.White;
            }

            //BtnPuesto.Enabled = false;
            //DgvPuesto.Rows.Clear();
            //DgvPuesto.Columns.Clear();
            //DgvPuesto.Visible = false;
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            BtnEliminar.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DgvPuesto.Visible = true;
            DgvPuesto.Columns.Add("0", "Puestos");

            OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\lguzman\Documents\Iglesia.accdb");
            conexion.Open();
            string Consulta = "SELECT puesto1.nompuesto from personas, puestosporpersonas, Puesto1 where personas.idDNI = puestosporpersonas.idDNI and Puesto1.idPuesto1 = puestosporpersonas.IdPuesto and personas.iddni = " + TxtDNI.Text;
            OleDbCommand comando = new OleDbCommand(Consulta, conexion);
            OleDbDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                DgvPuesto.Rows.Add(dr[0].ToString());
            }

            BtnPuesto.Enabled = false;
            
        }

        private void dgvConsultaPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Modificar_Personas Modificar = new Modificar_Personas();
            DataGridViewRow rellenar = dgvConsultaPersonas.Rows[e.RowIndex];
            /*Modificar.txtNombre.Text.*/
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            DetallePersonas2 Ventana = new DetallePersonas2();
            Ventana.ShowDialog();
        }

        private void dgvConsultaPersonas_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            DetallePersonas2 Ventana = new DetallePersonas2();

            foreach (DataGridViewRow fila in dgvConsultaPersonas.SelectedRows)
            {
                Ventana.TxtDNI.Text = fila.Cells[0].Value.ToString();
                Ventana.TxtNombre.Text = fila.Cells[1].Value.ToString()+" "+ fila.Cells[2].Value.ToString();
                Ventana.TxtConsolidador.Text = fila.Cells[6].Value.ToString();
                //Ventana.txtDireccion.Text = fila.Cells[3].Value.ToString();


            }

            Ventana.Show();

        }

        private void Reporte_Click(object sender, EventArgs e)
        {
            Formulario ventana = new Formulario();
            ventana.Show();
        }
    }
}
    
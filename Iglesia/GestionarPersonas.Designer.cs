namespace Iglesia
{
    partial class GestionarPersonas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarPersonas));
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.dgvConsultaPersonas = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DgvPuesto = new System.Windows.Forms.DataGridView();
            this.BtnPuesto = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.TxtDirec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSexo = new System.Windows.Forms.TextBox();
            this.TxtBarrio = new System.Windows.Forms.TextBox();
            this.BtnReporte = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtDNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Reporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaPersonas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(65, 43);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(100, 20);
            this.TxtNom.TabIndex = 3;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(65, 69);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(100, 20);
            this.TxtApellido.TabIndex = 4;
            // 
            // dgvConsultaPersonas
            // 
            this.dgvConsultaPersonas.AllowUserToAddRows = false;
            this.dgvConsultaPersonas.AllowUserToDeleteRows = false;
            this.dgvConsultaPersonas.AllowUserToOrderColumns = true;
            this.dgvConsultaPersonas.AllowUserToResizeColumns = false;
            this.dgvConsultaPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultaPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaPersonas.Location = new System.Drawing.Point(12, 144);
            this.dgvConsultaPersonas.MultiSelect = false;
            this.dgvConsultaPersonas.Name = "dgvConsultaPersonas";
            this.dgvConsultaPersonas.ReadOnly = true;
            this.dgvConsultaPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaPersonas.Size = new System.Drawing.Size(799, 241);
            this.dgvConsultaPersonas.TabIndex = 5;
            this.dgvConsultaPersonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaPersonas_CellContentClick);
            this.dgvConsultaPersonas.DoubleClick += new System.EventHandler(this.dgvConsultaPersonas_DoubleClick);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Lime;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(644, 12);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(86, 39);
            this.BtnAgregar.TabIndex = 6;
            this.BtnAgregar.Text = "Agregar Nuevo";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(644, 100);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(86, 39);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Yellow;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Location = new System.Drawing.Point(644, 56);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(86, 39);
            this.BtnModificar.TabIndex = 8;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Blue;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(736, 13);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 42);
            this.button7.TabIndex = 10;
            this.button7.Text = "SALIR";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.DgvPuesto);
            this.groupBox1.Controls.Add(this.BtnPuesto);
            this.groupBox1.Controls.Add(this.BtnLimpiar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtTel);
            this.groupBox1.Controls.Add(this.TxtDirec);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtSexo);
            this.groupBox1.Controls.Add(this.TxtBarrio);
            this.groupBox1.Controls.Add(this.BtnReporte);
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.TxtDNI);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtApellido);
            this.groupBox1.Controls.Add(this.TxtNom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 124);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(398, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 48);
            this.button1.TabIndex = 30;
            this.button1.Text = "Detalles";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // DgvPuesto
            // 
            this.DgvPuesto.AllowUserToAddRows = false;
            this.DgvPuesto.AllowUserToDeleteRows = false;
            this.DgvPuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPuesto.Location = new System.Drawing.Point(373, 35);
            this.DgvPuesto.Name = "DgvPuesto";
            this.DgvPuesto.ReadOnly = true;
            this.DgvPuesto.Size = new System.Drawing.Size(145, 76);
            this.DgvPuesto.TabIndex = 29;
            this.DgvPuesto.Visible = false;
            // 
            // BtnPuesto
            // 
            this.BtnPuesto.Location = new System.Drawing.Point(418, 11);
            this.BtnPuesto.Name = "BtnPuesto";
            this.BtnPuesto.Size = new System.Drawing.Size(55, 19);
            this.BtnPuesto.TabIndex = 28;
            this.BtnPuesto.Text = "Puesto";
            this.BtnPuesto.UseVisualStyleBackColor = true;
            this.BtnPuesto.Visible = false;
            this.BtnPuesto.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(541, 74);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 37);
            this.BtnLimpiar.TabIndex = 27;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Teléfono";
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(65, 95);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(100, 20);
            this.TxtTel.TabIndex = 23;
            // 
            // TxtDirec
            // 
            this.TxtDirec.Location = new System.Drawing.Point(257, 17);
            this.TxtDirec.Name = "TxtDirec";
            this.TxtDirec.Size = new System.Drawing.Size(100, 20);
            this.TxtDirec.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(183, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(183, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Consolidador";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(183, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Barrio";
            // 
            // TxtSexo
            // 
            this.TxtSexo.Location = new System.Drawing.Point(257, 69);
            this.TxtSexo.Name = "TxtSexo";
            this.TxtSexo.Size = new System.Drawing.Size(100, 20);
            this.TxtSexo.TabIndex = 18;
            // 
            // TxtBarrio
            // 
            this.TxtBarrio.Location = new System.Drawing.Point(257, 43);
            this.TxtBarrio.Name = "TxtBarrio";
            this.TxtBarrio.Size = new System.Drawing.Size(100, 20);
            this.TxtBarrio.TabIndex = 17;
            // 
            // BtnReporte
            // 
            this.BtnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporte.Location = new System.Drawing.Point(643, 10);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(77, 44);
            this.BtnReporte.TabIndex = 12;
            this.BtnReporte.Text = "Generar Report.";
            this.BtnReporte.UseVisualStyleBackColor = true;
            this.BtnReporte.Visible = false;
            this.BtnReporte.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(541, 17);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 38);
            this.BtnBuscar.TabIndex = 12;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // TxtDNI
            // 
            this.TxtDNI.Location = new System.Drawing.Point(65, 18);
            this.TxtDNI.Name = "TxtDNI";
            this.TxtDNI.Size = new System.Drawing.Size(100, 20);
            this.TxtDNI.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "D.N.I";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // Reporte
            // 
            this.Reporte.Location = new System.Drawing.Point(736, 62);
            this.Reporte.Name = "Reporte";
            this.Reporte.Size = new System.Drawing.Size(75, 38);
            this.Reporte.TabIndex = 31;
            this.Reporte.Text = "REPORTE";
            this.Reporte.UseVisualStyleBackColor = true;
            this.Reporte.Click += new System.EventHandler(this.Reporte_Click);
            // 
            // GestionarPersonas
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 398);
            this.Controls.Add(this.Reporte);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.dgvConsultaPersonas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionarPersonas";
            this.Text = "Gestionar Personas";
            this.Load += new System.EventHandler(this.GestionarPersonas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaPersonas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPuesto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox TxtNom;
        public System.Windows.Forms.TextBox TxtApellido;
        public System.Windows.Forms.DataGridView dgvConsultaPersonas;
        public System.Windows.Forms.Button BtnAgregar;
        public System.Windows.Forms.Button BtnEliminar;
        public System.Windows.Forms.Button BtnModificar;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtDNI;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button BtnReporte;
        public System.Windows.Forms.Button BtnBuscar;
        public System.Windows.Forms.TextBox TxtDirec;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TxtSexo;
        public System.Windows.Forms.TextBox TxtBarrio;
        public System.Windows.Forms.Button BtnLimpiar;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox TxtTel;
        private System.Windows.Forms.Button BtnPuesto;
        private System.Windows.Forms.DataGridView DgvPuesto;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button Reporte;
    }
}
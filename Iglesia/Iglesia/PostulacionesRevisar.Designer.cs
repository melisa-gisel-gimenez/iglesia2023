namespace Iglesia
{
    partial class PostulacionesRevisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostulacionesRevisar));
            this.label1 = new System.Windows.Forms.Label();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.labelIDPostulacion = new System.Windows.Forms.Label();
            this.buttonAprobar = new System.Windows.Forms.Button();
            this.labelIDMiembro = new System.Windows.Forms.Label();
            this.labelIDProxEtapa = new System.Windows.Forms.Label();
            this.labelFechaAlta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Candidatos a Evaluar para  aprobar evolucion espiritual";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToAddRows = false;
            this.DGV1.AllowUserToDeleteRows = false;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(29, 65);
            this.DGV1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV1.Name = "DGV1";
            this.DGV1.ReadOnly = true;
            this.DGV1.RowHeadersWidth = 51;
            this.DGV1.RowTemplate.Height = 24;
            this.DGV1.Size = new System.Drawing.Size(1144, 135);
            this.DGV1.TabIndex = 1;
            this.DGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellContentClick);
            // 
            // labelIDPostulacion
            // 
            this.labelIDPostulacion.AutoSize = true;
            this.labelIDPostulacion.Location = new System.Drawing.Point(40, 290);
            this.labelIDPostulacion.Name = "labelIDPostulacion";
            this.labelIDPostulacion.Size = new System.Drawing.Size(0, 20);
            this.labelIDPostulacion.TabIndex = 2;
            // 
            // buttonAprobar
            // 
            this.buttonAprobar.Location = new System.Drawing.Point(530, 374);
            this.buttonAprobar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAprobar.Name = "buttonAprobar";
            this.buttonAprobar.Size = new System.Drawing.Size(123, 69);
            this.buttonAprobar.TabIndex = 3;
            this.buttonAprobar.Text = "APROBAR";
            this.buttonAprobar.UseVisualStyleBackColor = true;
            this.buttonAprobar.Click += new System.EventHandler(this.buttonAprobar_Click);
            // 
            // labelIDMiembro
            // 
            this.labelIDMiembro.AutoSize = true;
            this.labelIDMiembro.Location = new System.Drawing.Point(426, 271);
            this.labelIDMiembro.Name = "labelIDMiembro";
            this.labelIDMiembro.Size = new System.Drawing.Size(0, 20);
            this.labelIDMiembro.TabIndex = 4;
            // 
            // labelIDProxEtapa
            // 
            this.labelIDProxEtapa.AutoSize = true;
            this.labelIDProxEtapa.Location = new System.Drawing.Point(691, 271);
            this.labelIDProxEtapa.Name = "labelIDProxEtapa";
            this.labelIDProxEtapa.Size = new System.Drawing.Size(0, 20);
            this.labelIDProxEtapa.TabIndex = 5;
            // 
            // labelFechaAlta
            // 
            this.labelFechaAlta.AutoSize = true;
            this.labelFechaAlta.Location = new System.Drawing.Point(776, 271);
            this.labelFechaAlta.Name = "labelFechaAlta";
            this.labelFechaAlta.Size = new System.Drawing.Size(0, 20);
            this.labelFechaAlta.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(863, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(948, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 6;
            // 
            // PostulacionesRevisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 562);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelFechaAlta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelIDProxEtapa);
            this.Controls.Add(this.labelIDMiembro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAprobar);
            this.Controls.Add(this.labelIDPostulacion);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PostulacionesRevisar";
            this.Text = "Postulaciones a Revisar";
            this.Load += new System.EventHandler(this.PostulacionesRevisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.Label labelIDPostulacion;
        private System.Windows.Forms.Button buttonAprobar;
        private System.Windows.Forms.Label labelIDMiembro;
        private System.Windows.Forms.Label labelIDProxEtapa;
        private System.Windows.Forms.Label labelFechaAlta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
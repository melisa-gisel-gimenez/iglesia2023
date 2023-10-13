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
            this.label1 = new System.Windows.Forms.Label();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.labelIDPostulacion = new System.Windows.Forms.Label();
            this.buttonAprobar = new System.Windows.Forms.Button();
            this.labelIDMiembro = new System.Windows.Forms.Label();
            this.labelIDProxEtapa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Candidatos a Evaluar para  aprobar evolucion espiritual";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToAddRows = false;
            this.DGV1.AllowUserToDeleteRows = false;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(26, 52);
            this.DGV1.Name = "DGV1";
            this.DGV1.ReadOnly = true;
            this.DGV1.RowHeadersWidth = 51;
            this.DGV1.RowTemplate.Height = 24;
            this.DGV1.Size = new System.Drawing.Size(1017, 150);
            this.DGV1.TabIndex = 1;
            this.DGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellContentClick);
            // 
            // labelIDPostulacion
            // 
            this.labelIDPostulacion.AutoSize = true;
            this.labelIDPostulacion.Location = new System.Drawing.Point(36, 232);
            this.labelIDPostulacion.Name = "labelIDPostulacion";
            this.labelIDPostulacion.Size = new System.Drawing.Size(0, 16);
            this.labelIDPostulacion.TabIndex = 2;
            // 
            // buttonAprobar
            // 
            this.buttonAprobar.Location = new System.Drawing.Point(466, 232);
            this.buttonAprobar.Name = "buttonAprobar";
            this.buttonAprobar.Size = new System.Drawing.Size(109, 55);
            this.buttonAprobar.TabIndex = 3;
            this.buttonAprobar.Text = "APROBAR";
            this.buttonAprobar.UseVisualStyleBackColor = true;
            this.buttonAprobar.Click += new System.EventHandler(this.buttonAprobar_Click);
            // 
            // labelIDMiembro
            // 
            this.labelIDMiembro.AutoSize = true;
            this.labelIDMiembro.Location = new System.Drawing.Point(379, 217);
            this.labelIDMiembro.Name = "labelIDMiembro";
            this.labelIDMiembro.Size = new System.Drawing.Size(0, 16);
            this.labelIDMiembro.TabIndex = 4;
            // 
            // labelIDProxEtapa
            // 
            this.labelIDProxEtapa.AutoSize = true;
            this.labelIDProxEtapa.Location = new System.Drawing.Point(614, 217);
            this.labelIDProxEtapa.Name = "labelIDProxEtapa";
            this.labelIDProxEtapa.Size = new System.Drawing.Size(0, 16);
            this.labelIDProxEtapa.TabIndex = 5;
            // 
            // PostulacionesRevisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 450);
            this.Controls.Add(this.labelIDProxEtapa);
            this.Controls.Add(this.labelIDMiembro);
            this.Controls.Add(this.buttonAprobar);
            this.Controls.Add(this.labelIDPostulacion);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.label1);
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
    }
}
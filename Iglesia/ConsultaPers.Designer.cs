namespace Iglesia
{
    partial class ConsultaPers
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
            this.dgvConsultaPersonas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaPersonas
            // 
            this.dgvConsultaPersonas.AllowUserToAddRows = false;
            this.dgvConsultaPersonas.AllowUserToDeleteRows = false;
            this.dgvConsultaPersonas.AllowUserToOrderColumns = true;
            this.dgvConsultaPersonas.AllowUserToResizeColumns = false;
            this.dgvConsultaPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultaPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaPersonas.Location = new System.Drawing.Point(12, 43);
            this.dgvConsultaPersonas.MultiSelect = false;
            this.dgvConsultaPersonas.Name = "dgvConsultaPersonas";
            this.dgvConsultaPersonas.ReadOnly = true;
            this.dgvConsultaPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaPersonas.Size = new System.Drawing.Size(802, 206);
            this.dgvConsultaPersonas.TabIndex = 0;
            this.dgvConsultaPersonas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaPersonas_CellClick);
            this.dgvConsultaPersonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ConsultaPersonas_CellContentClick);
            this.dgvConsultaPersonas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaPersonas_RowEnter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(12, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Detalles";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsultaPers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvConsultaPersonas);
            this.Name = "ConsultaPers";
            this.Text = "ConsultaPers";
            this.Load += new System.EventHandler(this.ConsultaPers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaPersonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvConsultaPersonas;
        private System.Windows.Forms.Button button1;
    }
}
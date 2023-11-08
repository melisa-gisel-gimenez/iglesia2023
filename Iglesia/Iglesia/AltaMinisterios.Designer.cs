namespace Iglesia
{
    partial class AltaMinisterios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaMinisterios));
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombreMini = new System.Windows.Forms.TextBox();
            this.DGVMini = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCrearMinisterio = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMini)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Ministerio:";
            // 
            // textBoxNombreMini
            // 
            this.textBoxNombreMini.Location = new System.Drawing.Point(157, 194);
            this.textBoxNombreMini.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxNombreMini.Name = "textBoxNombreMini";
            this.textBoxNombreMini.Size = new System.Drawing.Size(172, 20);
            this.textBoxNombreMini.TabIndex = 2;
            this.textBoxNombreMini.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombreMini_KeyPress_1);
            // 
            // DGVMini
            // 
            this.DGVMini.AllowUserToAddRows = false;
            this.DGVMini.AllowUserToDeleteRows = false;
            this.DGVMini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMini.Location = new System.Drawing.Point(16, 49);
            this.DGVMini.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGVMini.Name = "DGVMini";
            this.DGVMini.ReadOnly = true;
            this.DGVMini.RowHeadersWidth = 51;
            this.DGVMini.RowTemplate.Height = 24;
            this.DGVMini.Size = new System.Drawing.Size(312, 122);
            this.DGVMini.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ministerios Existentes:";
            // 
            // buttonCrearMinisterio
            // 
            this.buttonCrearMinisterio.Enabled = false;
            this.buttonCrearMinisterio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.buttonCrearMinisterio.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonCrearMinisterio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrearMinisterio.Location = new System.Drawing.Point(71, 245);
            this.buttonCrearMinisterio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonCrearMinisterio.Name = "buttonCrearMinisterio";
            this.buttonCrearMinisterio.Size = new System.Drawing.Size(71, 49);
            this.buttonCrearMinisterio.TabIndex = 5;
            this.buttonCrearMinisterio.Text = "Crear Ministerio";
            this.buttonCrearMinisterio.UseVisualStyleBackColor = true;
            this.buttonCrearMinisterio.Click += new System.EventHandler(this.buttonCrearMinisterio_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Location = new System.Drawing.Point(179, 245);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(70, 49);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // AltaMinisterios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 319);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonCrearMinisterio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGVMini);
            this.Controls.Add(this.textBoxNombreMini);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaMinisterios";
            this.Text = "Ministerios";
            ((System.ComponentModel.ISupportInitialize)(this.DGVMini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombreMini;
        private System.Windows.Forms.DataGridView DGVMini;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCrearMinisterio;
        private System.Windows.Forms.Button buttonCancelar;
    }
}
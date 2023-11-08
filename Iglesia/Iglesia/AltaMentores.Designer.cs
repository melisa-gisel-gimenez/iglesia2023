
namespace Iglesia
{
    partial class AltaMentores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaMentores));
            this.textBoxDNIBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDNIBuscar
            // 
            this.textBoxDNIBuscar.Location = new System.Drawing.Point(189, 70);
            this.textBoxDNIBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDNIBuscar.Name = "textBoxDNIBuscar";
            this.textBoxDNIBuscar.Size = new System.Drawing.Size(112, 26);
            this.textBoxDNIBuscar.TabIndex = 0;
            this.textBoxDNIBuscar.TextChanged += new System.EventHandler(this.textBoxDNIBuscar_TextChanged_1);
            this.textBoxDNIBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDNIBuscar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresar DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre ";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(189, 140);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size(112, 26);
            this.textBoxNombre.TabIndex = 4;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBuscar.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.Color.Black;
            this.buttonBuscar.Location = new System.Drawing.Point(318, 61);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(84, 44);
            this.buttonBuscar.TabIndex = 5;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "DNI";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(189, 174);
            this.textBoxApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.ReadOnly = true;
            this.textBoxApellido.Size = new System.Drawing.Size(112, 26);
            this.textBoxApellido.TabIndex = 8;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(189, 208);
            this.textBoxDNI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.ReadOnly = true;
            this.textBoxDNI.Size = new System.Drawing.Size(112, 26);
            this.textBoxDNI.TabIndex = 9;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = false;
            this.buttonAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.buttonAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Location = new System.Drawing.Point(50, 299);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(84, 64);
            this.buttonAceptar.TabIndex = 10;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Location = new System.Drawing.Point(321, 299);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(84, 64);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonLimpiar.Location = new System.Drawing.Point(189, 299);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(84, 64);
            this.buttonLimpiar.TabIndex = 12;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // AltaMentores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 378);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDNIBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AltaMentores";
            this.Text = "AltaMentores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDNIBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}
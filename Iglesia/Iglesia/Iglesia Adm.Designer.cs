namespace Iglesia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarMentorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarMentoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDatosPersonalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inhabilitarPersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeMentoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postularMiembrosADiscipuladoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postulacionesPorRevisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaMinisteriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeReunionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tesoreríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personasToolStripMenuItem,
            this.tesoreríaToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(648, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personasToolStripMenuItem
            // 
            this.personasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarPersonas,
            this.asignarMentorToolStripMenuItem,
            this.modificarMentoresToolStripMenuItem,
            this.modificarDatosPersonalesToolStripMenuItem,
            this.inhabilitarPersonasToolStripMenuItem,
            this.altaDeMentoresToolStripMenuItem,
            this.postularMiembrosADiscipuladoToolStripMenuItem,
            this.postulacionesPorRevisarToolStripMenuItem,
            this.altaMinisteriosToolStripMenuItem,
            this.registroDeReunionesToolStripMenuItem,
            this.altaUsuariosToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            this.personasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.personasToolStripMenuItem.Text = "Personas";
            // 
            // cargarPersonas
            // 
            this.cargarPersonas.Name = "cargarPersonas";
            this.cargarPersonas.Size = new System.Drawing.Size(248, 22);
            this.cargarPersonas.Text = "Alta Miembros";
            this.cargarPersonas.Click += new System.EventHandler(this.cargarPersonasNuevasToolStripMenuItem_Click);
            // 
            // asignarMentorToolStripMenuItem
            // 
            this.asignarMentorToolStripMenuItem.Name = "asignarMentorToolStripMenuItem";
            this.asignarMentorToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.asignarMentorToolStripMenuItem.Text = "Asignar Mentor";
            this.asignarMentorToolStripMenuItem.Click += new System.EventHandler(this.asignarMentorToolStripMenuItem_Click);
            // 
            // modificarMentoresToolStripMenuItem
            // 
            this.modificarMentoresToolStripMenuItem.Name = "modificarMentoresToolStripMenuItem";
            this.modificarMentoresToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.modificarMentoresToolStripMenuItem.Text = "Modificar mentores";
            this.modificarMentoresToolStripMenuItem.Click += new System.EventHandler(this.modificarMentoresToolStripMenuItem_Click);
            // 
            // modificarDatosPersonalesToolStripMenuItem
            // 
            this.modificarDatosPersonalesToolStripMenuItem.Name = "modificarDatosPersonalesToolStripMenuItem";
            this.modificarDatosPersonalesToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.modificarDatosPersonalesToolStripMenuItem.Text = "Modificar Datos Personales";
            this.modificarDatosPersonalesToolStripMenuItem.Click += new System.EventHandler(this.modificarDatosPersonalesToolStripMenuItem_Click);
            // 
            // inhabilitarPersonasToolStripMenuItem
            // 
            this.inhabilitarPersonasToolStripMenuItem.Name = "inhabilitarPersonasToolStripMenuItem";
            this.inhabilitarPersonasToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.inhabilitarPersonasToolStripMenuItem.Text = "Inhabilitar Personas";
            this.inhabilitarPersonasToolStripMenuItem.Click += new System.EventHandler(this.inhabilitarPersonasToolStripMenuItem_Click);
            // 
            // altaDeMentoresToolStripMenuItem
            // 
            this.altaDeMentoresToolStripMenuItem.Name = "altaDeMentoresToolStripMenuItem";
            this.altaDeMentoresToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.altaDeMentoresToolStripMenuItem.Text = "Alta de Mentores";
            this.altaDeMentoresToolStripMenuItem.Click += new System.EventHandler(this.altaDeMentoresToolStripMenuItem_Click);
            // 
            // postularMiembrosADiscipuladoToolStripMenuItem
            // 
            this.postularMiembrosADiscipuladoToolStripMenuItem.Name = "postularMiembrosADiscipuladoToolStripMenuItem";
            this.postularMiembrosADiscipuladoToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.postularMiembrosADiscipuladoToolStripMenuItem.Text = "Postular Miembros a Discipulado";
            this.postularMiembrosADiscipuladoToolStripMenuItem.Click += new System.EventHandler(this.postularMiembrosADiscipuladoToolStripMenuItem_Click);
            // 
            // postulacionesPorRevisarToolStripMenuItem
            // 
            this.postulacionesPorRevisarToolStripMenuItem.Name = "postulacionesPorRevisarToolStripMenuItem";
            this.postulacionesPorRevisarToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.postulacionesPorRevisarToolStripMenuItem.Text = "Postulaciones por revisar";
            this.postulacionesPorRevisarToolStripMenuItem.Click += new System.EventHandler(this.postulacionesPorRevisarToolStripMenuItem_Click);
            // 
            // altaMinisteriosToolStripMenuItem
            // 
            this.altaMinisteriosToolStripMenuItem.Name = "altaMinisteriosToolStripMenuItem";
            this.altaMinisteriosToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.altaMinisteriosToolStripMenuItem.Text = "Alta Ministerios";
            this.altaMinisteriosToolStripMenuItem.Click += new System.EventHandler(this.altaMinisteriosToolStripMenuItem_Click);
            // 
            // registroDeReunionesToolStripMenuItem
            // 
            this.registroDeReunionesToolStripMenuItem.Name = "registroDeReunionesToolStripMenuItem";
            this.registroDeReunionesToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.registroDeReunionesToolStripMenuItem.Text = "Registro de Reuniones";
            this.registroDeReunionesToolStripMenuItem.Click += new System.EventHandler(this.registroDeReunionesToolStripMenuItem_Click);
            // 
            // altaUsuariosToolStripMenuItem
            // 
            this.altaUsuariosToolStripMenuItem.Name = "altaUsuariosToolStripMenuItem";
            this.altaUsuariosToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.altaUsuariosToolStripMenuItem.Text = "Alta Usuarios";
            this.altaUsuariosToolStripMenuItem.Click += new System.EventHandler(this.altaUsuariosToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.loginToolStripMenuItem.Text = "login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // tesoreríaToolStripMenuItem
            // 
            this.tesoreríaToolStripMenuItem.Name = "tesoreríaToolStripMenuItem";
            this.tesoreríaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tesoreríaToolStripMenuItem.Text = "Tesorería";
            this.tesoreríaToolStripMenuItem.Click += new System.EventHandler(this.tesoreríaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(648, 412);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 436);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Iglesia Adm.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarPersonas;
        private System.Windows.Forms.ToolStripMenuItem tesoreríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem asignarMentorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarMentoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarDatosPersonalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inhabilitarPersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeMentoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postularMiembrosADiscipuladoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postulacionesPorRevisarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaMinisteriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeReunionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}


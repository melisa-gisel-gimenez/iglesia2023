namespace Iglesia
{
    partial class Formulario
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetIglesia = new Iglesia.DataSetIglesia();
            this.PersonasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PersonasTableAdapter = new Iglesia.DataSetIglesiaTableAdapters.PersonasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetIglesia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PersonasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Iglesia.Reporte Personas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetIglesia
            // 
            this.DataSetIglesia.DataSetName = "DataSetIglesia";
            this.DataSetIglesia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PersonasBindingSource
            // 
            this.PersonasBindingSource.DataMember = "Personas";
            this.PersonasBindingSource.DataSource = this.DataSetIglesia;
            // 
            // PersonasTableAdapter
            // 
            this.PersonasTableAdapter.ClearBeforeFill = true;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Formulario";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Formulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetIglesia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PersonasBindingSource;
        private DataSetIglesia DataSetIglesia;
        private DataSetIglesiaTableAdapters.PersonasTableAdapter PersonasTableAdapter;
    }
}
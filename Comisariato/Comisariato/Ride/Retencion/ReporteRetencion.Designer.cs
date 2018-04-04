namespace Comisariato.Ride.Retencion
{
    partial class ReporteRetencion
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RetencionEncabezado = new Comisariato.Ride.Retencion.RetencionEncabezado();
            this.EncabezadoOrdenGiroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RetencionDetalle = new Comisariato.Ride.Retencion.RetencionDetalle();
            this.DetalleOrdenGiroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerRetencion = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.RetencionEncabezado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncabezadoOrdenGiroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetencionDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleOrdenGiroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RetencionEncabezado
            // 
            this.RetencionEncabezado.DataSetName = "RetencionEncabezado";
            this.RetencionEncabezado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EncabezadoOrdenGiroBindingSource
            // 
            this.EncabezadoOrdenGiroBindingSource.DataMember = "EncabezadoOrdenGiro";
            this.EncabezadoOrdenGiroBindingSource.DataSource = this.RetencionEncabezado;
            // 
            // RetencionDetalle
            // 
            this.RetencionDetalle.DataSetName = "RetencionDetalle";
            this.RetencionDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DetalleOrdenGiroBindingSource
            // 
            this.DetalleOrdenGiroBindingSource.DataMember = "DetalleOrdenGiro";
            this.DetalleOrdenGiroBindingSource.DataSource = this.RetencionDetalle;
            // 
            // reportViewerRetencion
            // 
            this.reportViewerRetencion.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RetencionDetalle";
            reportDataSource1.Value = this.DetalleOrdenGiroBindingSource;
            reportDataSource2.Name = "RetencionEncabezado";
            reportDataSource2.Value = this.EncabezadoOrdenGiroBindingSource;
            this.reportViewerRetencion.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerRetencion.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerRetencion.LocalReport.ReportEmbeddedResource = "Comisariato.Ride.Retencion.ReporteRideRetencion.rdlc";
            this.reportViewerRetencion.Location = new System.Drawing.Point(0, 0);
            this.reportViewerRetencion.Name = "reportViewerRetencion";
            this.reportViewerRetencion.Size = new System.Drawing.Size(889, 502);
            this.reportViewerRetencion.TabIndex = 0;
            // 
            // ReporteRetencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 502);
            this.Controls.Add(this.reportViewerRetencion);
            this.Name = "ReporteRetencion";
            this.Text = "Retencion";
            this.Load += new System.EventHandler(this.ReporteRetencion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RetencionEncabezado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncabezadoOrdenGiroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetencionDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleOrdenGiroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource EncabezadoOrdenGiroBindingSource;
        private RetencionEncabezado RetencionEncabezado;
        private System.Windows.Forms.BindingSource DetalleOrdenGiroBindingSource;
        private RetencionDetalle RetencionDetalle;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerRetencion;
    }
}
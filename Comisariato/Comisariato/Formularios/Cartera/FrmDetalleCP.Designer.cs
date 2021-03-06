﻿namespace Comisariato.Formularios.Cartera
{
    partial class FrmDetalleCP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDetalleCP = new System.Windows.Forms.DataGridView();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LblNombreProveedor = new System.Windows.Forms.Label();
            this.TxtTotalPagar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTotalHaber = new System.Windows.Forms.TextBox();
            this.TxtTotalDebe = new System.Windows.Forms.TextBox();
            this.BtnPagar = new System.Windows.Forms.Button();
            this.ChkPagarTodo = new System.Windows.Forms.CheckBox();
            this.ElegirImpresero = new System.Windows.Forms.PrintDialog();
            this.ImpresionDetallePago = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalleCP
            // 
            this.dgvDetalleCP.AllowUserToResizeColumns = false;
            this.dgvDetalleCP.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleCP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalleCP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detalle,
            this.debe,
            this.haber,
            this.Fecha,
            this.Pagar});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleCP.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetalleCP.Location = new System.Drawing.Point(11, 79);
            this.dgvDetalleCP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDetalleCP.Name = "dgvDetalleCP";
            this.dgvDetalleCP.RowHeadersVisible = false;
            this.dgvDetalleCP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleCP.Size = new System.Drawing.Size(481, 435);
            this.dgvDetalleCP.TabIndex = 0;
            this.dgvDetalleCP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleCP_CellContentClick);
            this.dgvDetalleCP.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleCP_CellValueChanged);
            this.dgvDetalleCP.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvDetalleCP_CurrentCellDirtyStateChanged);
            // 
            // detalle
            // 
            this.detalle.HeaderText = "Detalle";
            this.detalle.Name = "detalle";
            this.detalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.detalle.Width = 220;
            // 
            // debe
            // 
            this.debe.HeaderText = "Debe";
            this.debe.Name = "debe";
            this.debe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.debe.Width = 95;
            // 
            // haber
            // 
            this.haber.HeaderText = "Haber";
            this.haber.Name = "haber";
            this.haber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.haber.Width = 95;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Visible = false;
            // 
            // Pagar
            // 
            this.Pagar.HeaderText = "Pagar";
            this.Pagar.Name = "Pagar";
            this.Pagar.Width = 45;
            // 
            // LblNombreProveedor
            // 
            this.LblNombreProveedor.AutoSize = true;
            this.LblNombreProveedor.Font = new System.Drawing.Font("Arial", 14F);
            this.LblNombreProveedor.ForeColor = System.Drawing.Color.Teal;
            this.LblNombreProveedor.Location = new System.Drawing.Point(147, 22);
            this.LblNombreProveedor.Name = "LblNombreProveedor";
            this.LblNombreProveedor.Size = new System.Drawing.Size(203, 22);
            this.LblNombreProveedor.TabIndex = 1;
            this.LblNombreProveedor.Text = "Nombre del Proveedor";
            this.LblNombreProveedor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtTotalPagar
            // 
            this.TxtTotalPagar.Font = new System.Drawing.Font("Arial", 20F);
            this.TxtTotalPagar.ForeColor = System.Drawing.Color.Teal;
            this.TxtTotalPagar.Location = new System.Drawing.Point(332, 596);
            this.TxtTotalPagar.Name = "TxtTotalPagar";
            this.TxtTotalPagar.ReadOnly = true;
            this.TxtTotalPagar.Size = new System.Drawing.Size(160, 38);
            this.TxtTotalPagar.TabIndex = 2;
            this.TxtTotalPagar.Text = "0.00";
            this.TxtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(204, 604);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total a Pagar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(304, 570);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tota Haber:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(305, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Debe:";
            // 
            // TxtTotalHaber
            // 
            this.TxtTotalHaber.Font = new System.Drawing.Font("Arial", 10F);
            this.TxtTotalHaber.ForeColor = System.Drawing.Color.Teal;
            this.TxtTotalHaber.Location = new System.Drawing.Point(391, 567);
            this.TxtTotalHaber.Name = "TxtTotalHaber";
            this.TxtTotalHaber.ReadOnly = true;
            this.TxtTotalHaber.Size = new System.Drawing.Size(100, 23);
            this.TxtTotalHaber.TabIndex = 5;
            this.TxtTotalHaber.Text = "0.00";
            this.TxtTotalHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtTotalDebe
            // 
            this.TxtTotalDebe.Font = new System.Drawing.Font("Arial", 10F);
            this.TxtTotalDebe.ForeColor = System.Drawing.Color.Teal;
            this.TxtTotalDebe.Location = new System.Drawing.Point(391, 538);
            this.TxtTotalDebe.Name = "TxtTotalDebe";
            this.TxtTotalDebe.ReadOnly = true;
            this.TxtTotalDebe.Size = new System.Drawing.Size(100, 23);
            this.TxtTotalDebe.TabIndex = 5;
            this.TxtTotalDebe.Text = "0.00";
            this.TxtTotalDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnPagar
            // 
            this.BtnPagar.Font = new System.Drawing.Font("Arial", 12F);
            this.BtnPagar.ForeColor = System.Drawing.Color.Teal;
            this.BtnPagar.Image = global::Comisariato.Properties.Resources.dinero;
            this.BtnPagar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPagar.Location = new System.Drawing.Point(11, 516);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(119, 135);
            this.BtnPagar.TabIndex = 6;
            this.BtnPagar.Text = "Pagar";
            this.BtnPagar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPagar.UseVisualStyleBackColor = true;
            this.BtnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // ChkPagarTodo
            // 
            this.ChkPagarTodo.AutoSize = true;
            this.ChkPagarTodo.Location = new System.Drawing.Point(11, 52);
            this.ChkPagarTodo.Name = "ChkPagarTodo";
            this.ChkPagarTodo.Size = new System.Drawing.Size(92, 20);
            this.ChkPagarTodo.TabIndex = 7;
            this.ChkPagarTodo.Text = "Pagar Todo";
            this.ChkPagarTodo.UseVisualStyleBackColor = true;
            this.ChkPagarTodo.CheckedChanged += new System.EventHandler(this.ChkPagarTodo_CheckedChanged);
            // 
            // ElegirImpresero
            // 
            this.ElegirImpresero.UseEXDialog = true;
            // 
            // ImpresionDetallePago
            // 
            this.ImpresionDetallePago.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ImpresionDetallePago_PrintPage);
            // 
            // FrmDetalleCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(504, 666);
            this.Controls.Add(this.ChkPagarTodo);
            this.Controls.Add(this.BtnPagar);
            this.Controls.Add(this.TxtTotalDebe);
            this.Controls.Add(this.TxtTotalHaber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTotalPagar);
            this.Controls.Add(this.LblNombreProveedor);
            this.Controls.Add(this.dgvDetalleCP);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 704);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 704);
            this.Name = "FrmDetalleCP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Cuenta por Pagar";
            this.Load += new System.EventHandler(this.FrmDetalleCP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalleCP;
        private System.Windows.Forms.Label LblNombreProveedor;
        private System.Windows.Forms.TextBox TxtTotalPagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTotalHaber;
        private System.Windows.Forms.TextBox TxtTotalDebe;
        private System.Windows.Forms.Button BtnPagar;
        private System.Windows.Forms.CheckBox ChkPagarTodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn haber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Pagar;
        private System.Windows.Forms.PrintDialog ElegirImpresero;
        private System.Drawing.Printing.PrintDocument ImpresionDetallePago;
    }
}
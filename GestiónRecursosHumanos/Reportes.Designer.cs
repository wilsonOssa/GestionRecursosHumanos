namespace GestiónRecursosHumanos
{
    partial class frmReportes
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
            this.lblTipodeReporte = new System.Windows.Forms.Label();
            this.lblFechadeGeneración = new System.Windows.Forms.Label();
            this.lblPeríodo = new System.Windows.Forms.Label();
            this.cmbTipoReporte = new System.Windows.Forms.ComboBox();
            this.dtpFechaGeneracion = new System.Windows.Forms.DateTimePicker();
            this.dtpPeriodo = new System.Windows.Forms.DateTimePicker();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipodeReporte
            // 
            this.lblTipodeReporte.AutoSize = true;
            this.lblTipodeReporte.Location = new System.Drawing.Point(50, 43);
            this.lblTipodeReporte.Name = "lblTipodeReporte";
            this.lblTipodeReporte.Size = new System.Drawing.Size(84, 13);
            this.lblTipodeReporte.TabIndex = 0;
            this.lblTipodeReporte.Text = "Tipo de Reporte";
            // 
            // lblFechadeGeneración
            // 
            this.lblFechadeGeneración.AutoSize = true;
            this.lblFechadeGeneración.Location = new System.Drawing.Point(186, 43);
            this.lblFechadeGeneración.Name = "lblFechadeGeneración";
            this.lblFechadeGeneración.Size = new System.Drawing.Size(110, 13);
            this.lblFechadeGeneración.TabIndex = 1;
            this.lblFechadeGeneración.Text = "Fecha de Generación";
            // 
            // lblPeríodo
            // 
            this.lblPeríodo.AutoSize = true;
            this.lblPeríodo.Location = new System.Drawing.Point(369, 43);
            this.lblPeríodo.Name = "lblPeríodo";
            this.lblPeríodo.Size = new System.Drawing.Size(45, 13);
            this.lblPeríodo.TabIndex = 2;
            this.lblPeríodo.Text = "Período";
            // 
            // cmbTipoReporte
            // 
            this.cmbTipoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoReporte.FormattingEnabled = true;
            this.cmbTipoReporte.Items.AddRange(new object[] {
            "Asistencia",
            "Nómina",
            "Desempeño"});
            this.cmbTipoReporte.Location = new System.Drawing.Point(26, 59);
            this.cmbTipoReporte.Name = "cmbTipoReporte";
            this.cmbTipoReporte.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoReporte.TabIndex = 3;
            // 
            // dtpFechaGeneracion
            // 
            this.dtpFechaGeneracion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaGeneracion.Location = new System.Drawing.Point(173, 59);
            this.dtpFechaGeneracion.Name = "dtpFechaGeneracion";
            this.dtpFechaGeneracion.Size = new System.Drawing.Size(133, 20);
            this.dtpFechaGeneracion.TabIndex = 4;
            // 
            // dtpPeriodo
            // 
            this.dtpPeriodo.CustomFormat = "MMMM yyyy";
            this.dtpPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPeriodo.Location = new System.Drawing.Point(334, 59);
            this.dtpPeriodo.Name = "dtpPeriodo";
            this.dtpPeriodo.ShowUpDown = true;
            this.dtpPeriodo.Size = new System.Drawing.Size(123, 20);
            this.dtpPeriodo.TabIndex = 5;
            // 
            // dgvReportes
            // 
            this.dgvReportes.AllowUserToAddRows = false;
            this.dgvReportes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.Location = new System.Drawing.Point(41, 186);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.ReadOnly = true;
            this.dgvReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportes.Size = new System.Drawing.Size(240, 150);
            this.dgvReportes.TabIndex = 6;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(26, 370);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(158, 370);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(123, 23);
            this.btnExportar.TabIndex = 8;
            this.btnExportar.Text = "Exportar a PDF/Excel";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(322, 370);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvReportes);
            this.Controls.Add(this.dtpPeriodo);
            this.Controls.Add(this.dtpFechaGeneracion);
            this.Controls.Add(this.cmbTipoReporte);
            this.Controls.Add(this.lblPeríodo);
            this.Controls.Add(this.lblFechadeGeneración);
            this.Controls.Add(this.lblTipodeReporte);
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de Reportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipodeReporte;
        private System.Windows.Forms.Label lblFechadeGeneración;
        private System.Windows.Forms.Label lblPeríodo;
        private System.Windows.Forms.ComboBox cmbTipoReporte;
        private System.Windows.Forms.DateTimePicker dtpFechaGeneracion;
        private System.Windows.Forms.DateTimePicker dtpPeriodo;
        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnCerrar;
    }
}
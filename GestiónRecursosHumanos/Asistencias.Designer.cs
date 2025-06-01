namespace GestiónRecursosHumanos
{
    partial class frmAsistencias
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
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.cmbEstadoAsistencia = new System.Windows.Forms.ComboBox();
            this.lblEstadoAsistencia = new System.Windows.Forms.Label();
            this.dgvAsistencias = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(41, 32);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(54, 13);
            this.lblEmpleado.TabIndex = 0;
            this.lblEmpleado.Text = "Empleado";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(192, 33);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Location = new System.Drawing.Point(301, 32);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(85, 13);
            this.lblHoraEntrada.TabIndex = 2;
            this.lblHoraEntrada.Text = "Hora de Entrada";
            this.lblHoraEntrada.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Location = new System.Drawing.Point(429, 32);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(77, 13);
            this.lblHoraSalida.TabIndex = 3;
            this.lblHoraSalida.Text = "Hora de Salida";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(12, 48);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpleado.TabIndex = 4;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(151, 49);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(123, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.CustomFormat = "HH:mm";
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(291, 49);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.ShowUpDown = true;
            this.dtpHoraEntrada.Size = new System.Drawing.Size(107, 20);
            this.dtpHoraEntrada.TabIndex = 6;
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.CustomFormat = "HH:mm";
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraSalida.Location = new System.Drawing.Point(423, 49);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.ShowUpDown = true;
            this.dtpHoraSalida.Size = new System.Drawing.Size(94, 20);
            this.dtpHoraSalida.TabIndex = 7;
            // 
            // cmbEstadoAsistencia
            // 
            this.cmbEstadoAsistencia.FormattingEnabled = true;
            this.cmbEstadoAsistencia.Items.AddRange(new object[] {
            "Normal",
            "Tardanza",
            "Ausente"});
            this.cmbEstadoAsistencia.Location = new System.Drawing.Point(12, 109);
            this.cmbEstadoAsistencia.Name = "cmbEstadoAsistencia";
            this.cmbEstadoAsistencia.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoAsistencia.TabIndex = 8;
            // 
            // lblEstadoAsistencia
            // 
            this.lblEstadoAsistencia.AutoSize = true;
            this.lblEstadoAsistencia.Location = new System.Drawing.Point(29, 93);
            this.lblEstadoAsistencia.Name = "lblEstadoAsistencia";
            this.lblEstadoAsistencia.Size = new System.Drawing.Size(88, 13);
            this.lblEstadoAsistencia.TabIndex = 9;
            this.lblEstadoAsistencia.Text = "EstadoAsistencia";
            // 
            // dgvAsistencias
            // 
            this.dgvAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencias.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAsistencias.Location = new System.Drawing.Point(0, 197);
            this.dgvAsistencias.Name = "dgvAsistencias";
            this.dgvAsistencias.ReadOnly = true;
            this.dgvAsistencias.Size = new System.Drawing.Size(784, 164);
            this.dgvAsistencias.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(12, 151);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(104, 151);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(195, 151);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(291, 151);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // frmAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgvAsistencias);
            this.Controls.Add(this.lblEstadoAsistencia);
            this.Controls.Add(this.cmbEstadoAsistencia);
            this.Controls.Add(this.dtpHoraSalida);
            this.Controls.Add(this.dtpHoraEntrada);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.lblHoraSalida);
            this.Controls.Add(this.lblHoraEntrada);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblEmpleado);
            this.Name = "frmAsistencias";
            this.Text = "Registro de Asistencias";
            this.Load += new System.EventHandler(this.frmAsistencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.Label lblHoraSalida;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.ComboBox cmbEstadoAsistencia;
        private System.Windows.Forms.Label lblEstadoAsistencia;
        private System.Windows.Forms.DataGridView dgvAsistencias;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnImprimir;
    }
}
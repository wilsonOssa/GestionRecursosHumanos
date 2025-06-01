namespace GestiónRecursosHumanos
{
    partial class Permisos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblFechadeSolicitud = new System.Windows.Forms.Label();
            this.lblFechadeInicio = new System.Windows.Forms.Label();
            this.lblFechadeFin = new System.Windows.Forms.Label();
            this.lblTipodePermiso = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.cmbTipoPermiso = new System.Windows.Forms.ComboBox();
            this.cmbEstadoPermiso = new System.Windows.Forms.ComboBox();
            this.lblEstadoPermiso = new System.Windows.Forms.Label();
            this.dtpFechaSolicitud = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dgvPermisos = new System.Windows.Forms.DataGridView();
            this.colEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPermisoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(43, 31);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(54, 13);
            this.lblEmpleado.TabIndex = 0;
            this.lblEmpleado.Text = "Empleado";
            // 
            // lblFechadeSolicitud
            // 
            this.lblFechadeSolicitud.AutoSize = true;
            this.lblFechadeSolicitud.Location = new System.Drawing.Point(151, 31);
            this.lblFechadeSolicitud.Name = "lblFechadeSolicitud";
            this.lblFechadeSolicitud.Size = new System.Drawing.Size(95, 13);
            this.lblFechadeSolicitud.TabIndex = 1;
            this.lblFechadeSolicitud.Text = "Fecha de Solicitud";
            // 
            // lblFechadeInicio
            // 
            this.lblFechadeInicio.AutoSize = true;
            this.lblFechadeInicio.Location = new System.Drawing.Point(254, 31);
            this.lblFechadeInicio.Name = "lblFechadeInicio";
            this.lblFechadeInicio.Size = new System.Drawing.Size(80, 13);
            this.lblFechadeInicio.TabIndex = 2;
            this.lblFechadeInicio.Text = "Fecha de Inicio";
            // 
            // lblFechadeFin
            // 
            this.lblFechadeFin.AutoSize = true;
            this.lblFechadeFin.Location = new System.Drawing.Point(364, 31);
            this.lblFechadeFin.Name = "lblFechadeFin";
            this.lblFechadeFin.Size = new System.Drawing.Size(69, 13);
            this.lblFechadeFin.TabIndex = 3;
            this.lblFechadeFin.Text = "Fecha de Fin";
            // 
            // lblTipodePermiso
            // 
            this.lblTipodePermiso.AutoSize = true;
            this.lblTipodePermiso.Location = new System.Drawing.Point(487, 31);
            this.lblTipodePermiso.Name = "lblTipodePermiso";
            this.lblTipodePermiso.Size = new System.Drawing.Size(83, 13);
            this.lblTipodePermiso.TabIndex = 4;
            this.lblTipodePermiso.Text = "Tipo de Permiso";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(12, 47);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpleado.TabIndex = 5;
            // 
            // cmbTipoPermiso
            // 
            this.cmbTipoPermiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPermiso.FormattingEnabled = true;
            this.cmbTipoPermiso.Items.AddRange(new object[] {
            "Enfermedad",
            "Personal",
            "Vacaciones"});
            this.cmbTipoPermiso.Location = new System.Drawing.Point(472, 48);
            this.cmbTipoPermiso.Name = "cmbTipoPermiso";
            this.cmbTipoPermiso.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoPermiso.TabIndex = 6;
            // 
            // cmbEstadoPermiso
            // 
            this.cmbEstadoPermiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoPermiso.FormattingEnabled = true;
            this.cmbEstadoPermiso.Items.AddRange(new object[] {
            "Pendiente",
            "Aprobado",
            "Rechazado"});
            this.cmbEstadoPermiso.Location = new System.Drawing.Point(599, 47);
            this.cmbEstadoPermiso.Name = "cmbEstadoPermiso";
            this.cmbEstadoPermiso.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoPermiso.TabIndex = 7;
            // 
            // lblEstadoPermiso
            // 
            this.lblEstadoPermiso.AutoSize = true;
            this.lblEstadoPermiso.Location = new System.Drawing.Point(622, 31);
            this.lblEstadoPermiso.Name = "lblEstadoPermiso";
            this.lblEstadoPermiso.Size = new System.Drawing.Size(80, 13);
            this.lblEstadoPermiso.TabIndex = 8;
            this.lblEstadoPermiso.Text = "Estado Permiso";
            // 
            // dtpFechaSolicitud
            // 
            this.dtpFechaSolicitud.Enabled = false;
            this.dtpFechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSolicitud.Location = new System.Drawing.Point(141, 48);
            this.dtpFechaSolicitud.Name = "dtpFechaSolicitud";
            this.dtpFechaSolicitud.Size = new System.Drawing.Size(105, 20);
            this.dtpFechaSolicitud.TabIndex = 9;
            this.dtpFechaSolicitud.Value = new System.DateTime(2025, 5, 28, 13, 5, 46, 0);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(252, 48);
            this.dtpFechaInicio.MinDate = new System.DateTime(2025, 5, 28, 0, 0, 0, 0);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(98, 20);
            this.dtpFechaInicio.TabIndex = 10;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(356, 48);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(99, 20);
            this.dtpFechaFin.TabIndex = 11;
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.AllowUserToAddRows = false;
            this.dgvPermisos.AllowUserToDeleteRows = false;
            this.dgvPermisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmpleado,
            this.colFechaSolicitud,
            this.colFechaInicio,
            this.colFechaFin,
            this.colTipoPermiso,
            this.colEstado,
            this.colPermisoID});
            this.dgvPermisos.Location = new System.Drawing.Point(25, 166);
            this.dgvPermisos.MultiSelect = false;
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.ReadOnly = true;
            this.dgvPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPermisos.Size = new System.Drawing.Size(737, 150);
            this.dgvPermisos.TabIndex = 12;
            // 
            // colEmpleado
            // 
            this.colEmpleado.DataPropertyName = "NombreEmpleado";
            this.colEmpleado.HeaderText = "Empleado";
            this.colEmpleado.Name = "colEmpleado";
            this.colEmpleado.ReadOnly = true;
            // 
            // colFechaSolicitud
            // 
            this.colFechaSolicitud.DataPropertyName = "FechaSolicitud";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.colFechaSolicitud.DefaultCellStyle = dataGridViewCellStyle1;
            this.colFechaSolicitud.HeaderText = "Fecha Solicitud";
            this.colFechaSolicitud.Name = "colFechaSolicitud";
            this.colFechaSolicitud.ReadOnly = true;
            // 
            // colFechaInicio
            // 
            this.colFechaInicio.DataPropertyName = "FechaInicio";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.colFechaInicio.DefaultCellStyle = dataGridViewCellStyle2;
            this.colFechaInicio.HeaderText = "Fecha Inicio";
            this.colFechaInicio.Name = "colFechaInicio";
            this.colFechaInicio.ReadOnly = true;
            // 
            // colFechaFin
            // 
            this.colFechaFin.DataPropertyName = "FechaFin";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.colFechaFin.DefaultCellStyle = dataGridViewCellStyle3;
            this.colFechaFin.HeaderText = "Fecha Fin";
            this.colFechaFin.Name = "colFechaFin";
            this.colFechaFin.ReadOnly = true;
            // 
            // colTipoPermiso
            // 
            this.colTipoPermiso.DataPropertyName = "TipoPermiso";
            this.colTipoPermiso.HeaderText = "Tipo Permiso";
            this.colTipoPermiso.Name = "colTipoPermiso";
            this.colTipoPermiso.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "Estado";
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // colPermisoID
            // 
            this.colPermisoID.DataPropertyName = "PermisoID";
            this.colPermisoID.HeaderText = "ID Permiso";
            this.colPermisoID.Name = "colPermisoID";
            this.colPermisoID.ReadOnly = true;
            this.colPermisoID.Visible = false;
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSolicitar.Location = new System.Drawing.Point(25, 341);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(75, 23);
            this.btnSolicitar.TabIndex = 13;
            this.btnSolicitar.Text = "Solicitar";
            this.btnSolicitar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Aqua;
            this.btnCancelar.Location = new System.Drawing.Point(141, 341);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar Permiso";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFiltrar.Location = new System.Drawing.Point(275, 341);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 15;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // Permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSolicitar);
            this.Controls.Add(this.dgvPermisos);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.dtpFechaSolicitud);
            this.Controls.Add(this.lblEstadoPermiso);
            this.Controls.Add(this.cmbEstadoPermiso);
            this.Controls.Add(this.cmbTipoPermiso);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.lblTipodePermiso);
            this.Controls.Add(this.lblFechadeFin);
            this.Controls.Add(this.lblFechadeInicio);
            this.Controls.Add(this.lblFechadeSolicitud);
            this.Controls.Add(this.lblEmpleado);
            this.Name = "Permisos";
            this.Text = "Permisos";
            this.Load += new System.EventHandler(this.Permisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblFechadeSolicitud;
        private System.Windows.Forms.Label lblFechadeInicio;
        private System.Windows.Forms.Label lblFechadeFin;
        private System.Windows.Forms.Label lblTipodePermiso;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.ComboBox cmbTipoPermiso;
        private System.Windows.Forms.ComboBox cmbEstadoPermiso;
        private System.Windows.Forms.Label lblEstadoPermiso;
        private System.Windows.Forms.DateTimePicker dtpFechaSolicitud;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DataGridView dgvPermisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoPermiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPermisoID;
        private System.Windows.Forms.Button btnSolicitar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFiltrar;
    }
}
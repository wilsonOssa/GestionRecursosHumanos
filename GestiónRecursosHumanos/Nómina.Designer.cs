namespace GestiónRecursosHumanos
{
    partial class frmNomina
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
            this.lblFechadePago = new System.Windows.Forms.Label();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.lblHorasExtras = new System.Windows.Forms.Label();
            this.lblBonificaciones = new System.Windows.Forms.Label();
            this.lblDeducciones = new System.Windows.Forms.Label();
            this.lblSalarioNeto = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.txtHorasExtras = new System.Windows.Forms.TextBox();
            this.txtBonificaciones = new System.Windows.Forms.TextBox();
            this.txtDeducciones = new System.Windows.Forms.TextBox();
            this.txtSalarioNeto = new System.Windows.Forms.TextBox();
            this.dgvNominas = new System.Windows.Forms.DataGridView();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNominas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(47, 39);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(54, 13);
            this.lblEmpleado.TabIndex = 0;
            this.lblEmpleado.Text = "Empleado";
            // 
            // lblFechadePago
            // 
            this.lblFechadePago.AutoSize = true;
            this.lblFechadePago.Location = new System.Drawing.Point(142, 39);
            this.lblFechadePago.Name = "lblFechadePago";
            this.lblFechadePago.Size = new System.Drawing.Size(80, 13);
            this.lblFechadePago.TabIndex = 1;
            this.lblFechadePago.Text = "Fecha de Pago";
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.Location = new System.Drawing.Point(253, 39);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(66, 13);
            this.lblSalarioBase.TabIndex = 2;
            this.lblSalarioBase.Text = "Salario Base";
            // 
            // lblHorasExtras
            // 
            this.lblHorasExtras.AutoSize = true;
            this.lblHorasExtras.Location = new System.Drawing.Point(357, 39);
            this.lblHorasExtras.Name = "lblHorasExtras";
            this.lblHorasExtras.Size = new System.Drawing.Size(67, 13);
            this.lblHorasExtras.TabIndex = 3;
            this.lblHorasExtras.Text = "Horas Extras";
            // 
            // lblBonificaciones
            // 
            this.lblBonificaciones.AutoSize = true;
            this.lblBonificaciones.Location = new System.Drawing.Point(484, 39);
            this.lblBonificaciones.Name = "lblBonificaciones";
            this.lblBonificaciones.Size = new System.Drawing.Size(76, 13);
            this.lblBonificaciones.TabIndex = 4;
            this.lblBonificaciones.Text = "Bonificaciones";
            // 
            // lblDeducciones
            // 
            this.lblDeducciones.AutoSize = true;
            this.lblDeducciones.Location = new System.Drawing.Point(589, 39);
            this.lblDeducciones.Name = "lblDeducciones";
            this.lblDeducciones.Size = new System.Drawing.Size(70, 13);
            this.lblDeducciones.TabIndex = 5;
            this.lblDeducciones.Text = "Deducciones";
            // 
            // lblSalarioNeto
            // 
            this.lblSalarioNeto.AutoSize = true;
            this.lblSalarioNeto.Location = new System.Drawing.Point(705, 39);
            this.lblSalarioNeto.Name = "lblSalarioNeto";
            this.lblSalarioNeto.Size = new System.Drawing.Size(65, 13);
            this.lblSalarioNeto.TabIndex = 6;
            this.lblSalarioNeto.Text = "Salario Neto";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(12, 55);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpleado.TabIndex = 7;
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPago.Location = new System.Drawing.Point(140, 56);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(82, 20);
            this.dtpFechaPago.TabIndex = 8;
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Location = new System.Drawing.Point(237, 56);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.ReadOnly = true;
            this.txtSalarioBase.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioBase.TabIndex = 9;
            // 
            // txtHorasExtras
            // 
            this.txtHorasExtras.Location = new System.Drawing.Point(343, 56);
            this.txtHorasExtras.Name = "txtHorasExtras";
            this.txtHorasExtras.Size = new System.Drawing.Size(100, 20);
            this.txtHorasExtras.TabIndex = 10;
            // 
            // txtBonificaciones
            // 
            this.txtBonificaciones.Location = new System.Drawing.Point(473, 56);
            this.txtBonificaciones.Name = "txtBonificaciones";
            this.txtBonificaciones.Size = new System.Drawing.Size(100, 20);
            this.txtBonificaciones.TabIndex = 11;
            this.txtBonificaciones.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtDeducciones
            // 
            this.txtDeducciones.Location = new System.Drawing.Point(579, 56);
            this.txtDeducciones.Name = "txtDeducciones";
            this.txtDeducciones.Size = new System.Drawing.Size(100, 20);
            this.txtDeducciones.TabIndex = 12;
            this.txtDeducciones.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtSalarioNeto
            // 
            this.txtSalarioNeto.BackColor = System.Drawing.Color.LightGray;
            this.txtSalarioNeto.Location = new System.Drawing.Point(688, 55);
            this.txtSalarioNeto.Name = "txtSalarioNeto";
            this.txtSalarioNeto.ReadOnly = true;
            this.txtSalarioNeto.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioNeto.TabIndex = 13;
            // 
            // dgvNominas
            // 
            this.dgvNominas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNominas.Location = new System.Drawing.Point(12, 132);
            this.dgvNominas.Name = "dgvNominas";
            this.dgvNominas.Size = new System.Drawing.Size(240, 150);
            this.dgvNominas.TabIndex = 14;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(26, 326);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(189, 325);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(369, 324);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // frmNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dgvNominas);
            this.Controls.Add(this.txtSalarioNeto);
            this.Controls.Add(this.txtDeducciones);
            this.Controls.Add(this.txtBonificaciones);
            this.Controls.Add(this.txtHorasExtras);
            this.Controls.Add(this.txtSalarioBase);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.lblSalarioNeto);
            this.Controls.Add(this.lblDeducciones);
            this.Controls.Add(this.lblBonificaciones);
            this.Controls.Add(this.lblHorasExtras);
            this.Controls.Add(this.lblSalarioBase);
            this.Controls.Add(this.lblFechadePago);
            this.Controls.Add(this.lblEmpleado);
            this.Name = "frmNomina";
            this.Text = "Nómina";
            this.Load += new System.EventHandler(this.frmNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNominas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblFechadePago;
        private System.Windows.Forms.Label lblSalarioBase;
        private System.Windows.Forms.Label lblHorasExtras;
        private System.Windows.Forms.Label lblBonificaciones;
        private System.Windows.Forms.Label lblDeducciones;
        private System.Windows.Forms.Label lblSalarioNeto;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.TextBox txtHorasExtras;
        private System.Windows.Forms.TextBox txtBonificaciones;
        private System.Windows.Forms.TextBox txtDeducciones;
        private System.Windows.Forms.TextBox txtSalarioNeto;
        private System.Windows.Forms.DataGridView dgvNominas;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}
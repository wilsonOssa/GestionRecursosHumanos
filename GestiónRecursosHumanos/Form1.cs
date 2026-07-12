using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiónRecursosHumanos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProbarConexion();
        }

        private void ProbarConexion()
        {
            try
            {
                using (SqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    MessageBox.Show("¡Conexión exitosa con la base de datos!", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de conexión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            new FrmEmpleados().Show();
        }

        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            new frmAsistencias().Show();
        }

        private void btnNomina_Click(object sender, EventArgs e)
        {
            new frmNomina().Show();
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            new Permisos().Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            new frmReportes().Show();
        }
    }

}

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

namespace CapaPresentación
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        //TODO Metodo para agregar cantidad en el formInicio
        private void frmHome_Load(object sender, EventArgs e)
        {
            string conexion = "data source=.;initial catalog=CRUDF;integrated security=true;";
            string consulta = "SELECT COUNT(*) FROM Proveedor";
            string consulta1 = "SELECT COUNT(*) FROM Vehiculos";
            string consulta2 = "SELECT COUNT(*) FROM Disponibilidad";

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                SqlCommand comando = new SqlCommand(consulta, conn);

                try
                {
                    conn.Open();
                    int cantidad = (int)comando.ExecuteScalar();
                    lblcantidad.Text = $"{cantidad}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al contar registros: " + ex.Message);
                }
            }
            using (SqlConnection conn1 = new SqlConnection(conexion))
            {
                SqlCommand comando = new SqlCommand(consulta1, conn1);

                try
                {
                    conn1.Open();
                    int cantidad = (int)comando.ExecuteScalar();
                    label1.Text = $"{cantidad}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al contar registros: " + ex.Message);
                }
            }
            using (SqlConnection conn2 = new SqlConnection(conexion))
            {
                SqlCommand comando = new SqlCommand(consulta2, conn2);

                try
                {
                    conn2.Open();
                    int cantidad = (int)comando.ExecuteScalar();
                    label2.Text = $"{cantidad}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al contar registros: " + ex.Message);
                }
            }
        }

        private void lblcantidad_Click(object sender, EventArgs e)
        {

        }
    }
}

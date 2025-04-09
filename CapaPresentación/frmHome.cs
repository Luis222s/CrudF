﻿using System;
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

        private void frmHome_Load(object sender, EventArgs e)
        {
            string conexion = "data source=.;initial catalog=CRUDF;integrated security=true;";
            string consulta = "SELECT COUNT(*) FROM Proveedor";

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
        }

        private void lblcantidad_Click(object sender, EventArgs e)
        {

        }
    }
}

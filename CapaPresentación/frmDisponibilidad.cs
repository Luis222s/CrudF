using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CapaDatos;

namespace CapaPresentación
{
    public partial class frmDisponibilidad : Form
    {
        ConsultaVehiculoLN logica = new ConsultaVehiculoLN();
        public frmDisponibilidad()
        {
            InitializeComponent();

            cboEstadoVenta.Enabled = false;
            cboDisponibilidad.Enabled = false;

            btnBuscar1.Text = "Habilitar";

            //Redondear botones
            int radius = 20;
            GraphicsPath pathAgregar1 = new GraphicsPath();
            pathAgregar1.AddArc(0, 0, radius, radius, 180, 90);
            pathAgregar1.AddArc(btnAgregar1.Width - radius, 0, radius, radius, 270, 90);
            pathAgregar1.AddArc(btnAgregar1.Width - radius, btnAgregar1.Height - radius, radius, radius, 0, 90);
            pathAgregar1.AddArc(0, btnAgregar1.Height - radius, radius, radius, 90, 90);
            pathAgregar1.CloseFigure();
            btnAgregar1.Region = new Region(pathAgregar1);

            GraphicsPath pathEditar1 = new GraphicsPath();
            pathEditar1.AddArc(0, 0, radius, radius, 180, 90);
            pathEditar1.AddArc(btnEditar1.Width - radius, 0, radius, radius, 270, 90);
            pathEditar1.AddArc(btnEditar1.Width - radius, btnEditar1.Height - radius, radius, radius, 0, 90);
            pathEditar1.AddArc(0, btnEditar1.Height - radius, radius, radius, 90, 90);
            pathEditar1.CloseFigure();
            btnEditar1.Region = new Region(pathEditar1);

            GraphicsPath pathEliminar1 = new GraphicsPath();
            pathEliminar1.AddArc(0, 0, radius, radius, 180, 90);
            pathEliminar1.AddArc(btnEliminar1.Width - radius, 0, radius, radius, 270, 90);
            pathEliminar1.AddArc(btnEliminar1.Width - radius, btnEliminar1.Height - radius, radius, radius, 0, 90);
            pathEliminar1.AddArc(0, btnEliminar1.Height - radius, radius, radius, 90, 90);
            pathEliminar1.CloseFigure();
            btnEliminar1.Region = new Region(pathEliminar1);

            GraphicsPath pathBuscar1 = new GraphicsPath();
            pathBuscar1.AddArc(0, 0, radius, radius, 180, 90);
            pathBuscar1.AddArc(btnBuscar1.Width - radius, 0, radius, radius, 270, 90);
            pathBuscar1.AddArc(btnBuscar1.Width - radius, btnBuscar1.Height - radius, radius, radius, 0, 90);
            pathBuscar1.AddArc(0, btnBuscar1.Height - radius, radius, radius, 90, 90);
            pathBuscar1.CloseFigure();
            btnBuscar1.Region = new Region(pathBuscar1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvConsultas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
                return;
            }

            DataGridViewRow filaSeleccionada = dgvConsultas.SelectedRows[0];
            int consultaID = Convert.ToInt32(filaSeleccionada.Cells["Consulta_ID"].Value);

            DialogResult confirm = MessageBox.Show("¿Estás seguro de eliminar esta consulta?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                bool eliminado = logica.EliminarConsulta(consultaID);
                if (eliminado)
                {
                    MessageBox.Show("Consulta eliminada correctamente.");
                    LimpiarCampos();
                    dgvConsultas.DataSource = logica.ObtenerConsultas(); // Refresca tabla
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la consulta.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            IConsultaVehiculo consulta = new ConsultaVehiculo()
            {
                Disponibilidad = cboDisponibilidad.SelectedItem.ToString(),
                Estado_Venta = cboEstadoVenta.SelectedItem.ToString(),
                Vehiculo_ID = (int)cboVehiculo.SelectedItem
            };

            if (logica.RegistrarConsulta(consulta))
            {
                MessageBox.Show("Consulta insertada correctamente.");
                LimpiarCampos();
                dgvConsultas.DataSource = logica.ObtenerConsultas();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvConsultas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila para editar.");
                return;
            }

            // Obtener el ID desde la fila seleccionada
            DataGridViewRow fila = dgvConsultas.SelectedRows[0];
            int consultaID = Convert.ToInt32(fila.Cells["Consulta_ID"].Value);

            // Validar campos
            if (cboDisponibilidad.SelectedItem == null || cboEstadoVenta.SelectedItem == null || cboVehiculo.SelectedItem == null)
            {
                MessageBox.Show("Completa todos los campos antes de editar.");
                return;
            }

            // Crear objeto actualizado
            IConsultaVehiculo consulta = new ConsultaVehiculo()
            {
                Consulta_ID = consultaID,
                Disponibilidad = cboDisponibilidad.SelectedItem.ToString(),
                Estado_Venta = cboEstadoVenta.SelectedItem.ToString(),
                Vehiculo_ID = (int)cboVehiculo.SelectedItem
            };

            if (logica.EditarConsulta(consulta))
            {
                MessageBox.Show("Consulta actualizada correctamente.");
                dgvConsultas.DataSource = logica.ObtenerConsultas();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al actualizar la consulta.");
            }
        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            bool estanHabilitados = cboEstadoVenta.Enabled && cboDisponibilidad.Enabled;

            // Alternamos el estado de habilitación
            cboEstadoVenta.Enabled = !estanHabilitados;
            cboDisponibilidad.Enabled = !estanHabilitados;


            // Opcional: cambiar el texto del botón para indicar la acción siguiente
            if (estanHabilitados)
            {
                btnBuscar1.Text = "Habilitar";
            }
            else
            {
                btnBuscar1.Text = "Deshabilitar";
            }
        }

        private void frmDisponibilidad_Load(object sender, EventArgs e)
        {
            cboEstadoVenta.Items.AddRange(new[] { "Disponible", "Vendido" });
            cboDisponibilidad.Items.AddRange(new[] { "Reservado", "No reservado" });
            cboEstadoVenta.SelectedIndex = -1;
            cboDisponibilidad.SelectedIndex = -1;

            cboVehiculo.DataSource = logica.ObtenerVehiculoIDs();
            dgvConsultas.DataSource = logica.ObtenerConsultas();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBox4.Text.Trim();
            DataTable tabla = (DataTable)dgvConsultas.DataSource;

            if (tabla != null)
            {
                tabla.DefaultView.RowFilter = $"Convert(Consulta_ID, 'System.String') LIKE '%{filtro}%'";
            }
        }

        private void dgvConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvConsultas.Rows[e.RowIndex];

                // Cargar los datos en los controles
                cboDisponibilidad.SelectedItem = fila.Cells["Disponibilidad"].Value.ToString();
                cboEstadoVenta.SelectedItem = fila.Cells["Estado_Venta"].Value.ToString();
                cboVehiculo.SelectedItem = Convert.ToInt32(fila.Cells["Vehiculo_ID"].Value);
            }
        }
        private bool ValidarCampos()
        {

            if (cboVehiculo.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un vehículo válido.");
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            cboDisponibilidad.SelectedIndex = 0;
            cboEstadoVenta.SelectedIndex = 0;
            cboVehiculo.SelectedIndex = 0;
        }
    }
}

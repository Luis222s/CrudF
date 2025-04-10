using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentación
{
    public partial class frmVehiculos : Form
    {
        VehiculoLN logica = new VehiculoLN();

        public frmVehiculos()
        {
            InitializeComponent();

            this.Load += frmVehiculos_Load;

            txtModelo.Enabled = false;
            txtMarca.Enabled = false;
            txtAño.Enabled = false;
            txtPrecio.Enabled = false;
            txtCondicion.Enabled = false;
            txtTipo.Enabled = false;

            btnBuscar.Text = "Habilitar";

            // Esquinas redondeadas para los botones
            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btnAgregar.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btnAgregar.Width - radius, btnAgregar.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btnAgregar.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            btnAgregar.Region = new Region(path);

            GraphicsPath pathEliminar = new GraphicsPath();
            pathEliminar.AddArc(0, 0, radius, radius, 180, 90);
            pathEliminar.AddArc(btnEliminar.Width - radius, 0, radius, radius, 270, 90);
            pathEliminar.AddArc(btnEliminar.Width - radius, btnEliminar.Height - radius, radius, radius, 0, 90);
            pathEliminar.AddArc(0, btnEliminar.Height - radius, radius, radius, 90, 90);
            pathEliminar.CloseFigure();
            btnEliminar.Region = new Region(pathEliminar);

            GraphicsPath path2 = new GraphicsPath();
            path2.AddArc(0, 0, radius, radius, 180, 90);
            path2.AddArc(btnEditar.Width - radius, 0, radius, radius, 270, 90);
            path2.AddArc(btnEditar.Width - radius, btnEditar.Height - radius, radius, radius, 0, 90);
            path2.AddArc(0, btnEditar.Height - radius, radius, radius, 90, 90);
            path2.CloseFigure();
            btnEditar.Region = new Region(path2);

            GraphicsPath pathBuscar = new GraphicsPath();
            pathBuscar.AddArc(0, 0, radius, radius, 180, 90);
            pathBuscar.AddArc(btnBuscar.Width - radius, 0, radius, radius, 270, 90);
            pathBuscar.AddArc(btnBuscar.Width - radius, btnBuscar.Height - radius, radius, radius, 0, 90);
            pathBuscar.AddArc(0, btnBuscar.Height - radius, radius, radius, 90, 90);
            pathBuscar.CloseFigure();
            btnBuscar.Region = new Region(pathBuscar);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Vehiculo v = new Vehiculo()
                {
                    Modelo = txtModelo.Text,
                    Marca = txtMarca.Text,
                    Año = int.Parse(txtAño.Text),
                    Precio = decimal.Parse(txtPrecio.Text),
                    Condicion = txtCondicion.Text,
                    Tipo = txtTipo.Text
                };

                if (logica.RegistrarVehiculo(v))
                {
                    MessageBox.Show("Vehículo registrado.");
                    CargarVehiculos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Si los TextBox están habilitados, los deshabilitamos, si están deshabilitados, los habilitamos.
            bool estanHabilitados = txtModelo.Enabled && txtMarca.Enabled && txtAño.Enabled && txtCondicion.Enabled && txtTipo.Enabled && txtPrecio.Enabled;

            // Alternamos el estado de habilitación
            txtModelo.Enabled = !estanHabilitados;
            txtMarca.Enabled = !estanHabilitados;
            txtAño.Enabled = !estanHabilitados;
            txtCondicion.Enabled = !estanHabilitados;
            txtTipo.Enabled = !estanHabilitados;
            txtPrecio.Enabled = !estanHabilitados;


            // Opcional: cambiar el texto del botón para indicar la acción siguiente
            if (estanHabilitados)
            {
                btnBuscar.Text = "Habilitar";
            }
            else
            {
                btnBuscar.Text = "Deshabilitar";
            }
        }

        private void frmVehiculos_Load(object sender, EventArgs e)
        {
            CargarVehiculos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dgvVehiculos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila para editar.");
                return;
            }

            try
            {
                // Obtener el ID desde la fila seleccionada
                int id = Convert.ToInt32(dgvVehiculos.SelectedRows[0].Cells["Vehiculo_ID"].Value);

                // Crear objeto vehículo con los nuevos valores
                Vehiculo v = new Vehiculo()
                {
                    VehiculoID = id, // Este sí es necesario para editar
                    Modelo = txtModelo.Text,
                    Marca = txtMarca.Text,
                    Año = int.Parse(txtAño.Text),
                    Precio = decimal.Parse(txtPrecio.Text),
                    Condicion = txtCondicion.Text,
                    Tipo = txtTipo.Text
                };

                // Enviar a la lógica de negocio
                if (logica.EditarVehiculo(v))
                {
                    MessageBox.Show("Vehículo actualizado correctamente.");
                    CargarVehiculos(); // Refrescar tabla
                    LimpiarCampos();   // Limpiar campos
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el vehículo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validar que haya una fila seleccionada
            if (dgvVehiculos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Usar directamente la fila seleccionada para obtener el ID
                DataGridViewRow filaSeleccionada = dgvVehiculos.SelectedRows[0];
                int id = Convert.ToInt32(filaSeleccionada.Cells["Vehiculo_ID"].Value); // <- Aquí usamos la fila, no un textbox

                // Confirmación
                DialogResult confirm = MessageBox.Show("¿Estás seguro de eliminar este vehículo?", "Confirmar eliminación",
                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    VehiculoLN logica = new VehiculoLN();

                    if (logica.EliminarVehiculo(id))
                    {
                        MessageBox.Show("Vehículo eliminado correctamente.");
                        CargarVehiculos();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el vehículo.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvVehiculos.Rows[e.RowIndex];

                txtModelo.Text = fila.Cells["Modelo"].Value.ToString();
                txtMarca.Text = fila.Cells["Marca"].Value.ToString();
                txtAño.Text = fila.Cells["Año"].Value.ToString();
                txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                txtCondicion.Text = fila.Cells["Condicion"].Value.ToString();
                txtTipo.Text = fila.Cells["Tipo"].Value.ToString();
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();
            DataTable tabla = (DataTable)dgvVehiculos.DataSource;

            if (tabla != null)
            {
                tabla.DefaultView.RowFilter = $"Convert(Vehiculo_ID, 'System.String') LIKE '%{filtro}%'";
            }
        }
        private void LimpiarCampos()
        {
            txtModelo.Clear();
            txtMarca.Clear();
            txtAño.Clear();
            txtPrecio.Clear();
            txtCondicion.Clear();
            txtTipo.Clear();
        }
        private void CargarVehiculos()
        {
            dgvVehiculos.DataSource = logica.ObtenerVehiculos();
            dgvVehiculos.ClearSelection();
        }
    }
}



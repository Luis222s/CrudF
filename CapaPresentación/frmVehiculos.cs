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

namespace CapaPresentación
{
    public partial class frmVehiculos : Form
    {
        public frmVehiculos()
        {
            InitializeComponent();

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;

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

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Si los TextBox están habilitados, los deshabilitamos, si están deshabilitados, los habilitamos.
            bool estanHabilitados = textBox1.Enabled && textBox2.Enabled && textBox3.Enabled && textBox4.Enabled && textBox5.Enabled && textBox6.Enabled;

            // Alternamos el estado de habilitación
            textBox1.Enabled = !estanHabilitados;
            textBox2.Enabled = !estanHabilitados;
            textBox3.Enabled = !estanHabilitados;
            textBox4.Enabled = !estanHabilitados;
            textBox5.Enabled = !estanHabilitados;
            textBox6.Enabled = !estanHabilitados;

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
    }

}

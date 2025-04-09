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

namespace CapaPresentación
{
    public partial class frmDisponibilidad : Form
    {
        public frmDisponibilidad()
        {
            InitializeComponent();
            
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            textBox1.Enabled = false;

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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            bool estanHabilitados = comboBox1.Enabled && comboBox2.Enabled && textBox1.Enabled;

            // Alternamos el estado de habilitación
            comboBox1.Enabled = !estanHabilitados;
            comboBox2.Enabled = !estanHabilitados;
            textBox1.Enabled = !estanHabilitados;


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
    }
}

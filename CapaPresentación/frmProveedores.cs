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

namespace CapaPresentación
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();

            // Redondear botones
            int radius = 20;
            GraphicsPath pathAgregar2 = new GraphicsPath();
            pathAgregar2.AddArc(0, 0, radius, radius, 180, 90);
            pathAgregar2.AddArc(btnAgregar2.Width - radius, 0, radius, radius, 270, 90);
            pathAgregar2.AddArc(btnAgregar2.Width - radius, btnAgregar2.Height - radius, radius, radius, 0, 90);
            pathAgregar2.AddArc(0, btnAgregar2.Height - radius, radius, radius, 90, 90);
            pathAgregar2.CloseFigure();
            btnAgregar2.Region = new Region(pathAgregar2);

            GraphicsPath pathEditar2 = new GraphicsPath();
            pathEditar2.AddArc(0, 0, radius, radius, 180, 90);
            pathEditar2.AddArc(btnEditar2.Width - radius, 0, radius, radius, 270, 90);
            pathEditar2.AddArc(btnEditar2.Width - radius, btnEditar2.Height - radius, radius, radius, 0, 90);
            pathEditar2.AddArc(0, btnEditar2.Height - radius, radius, radius, 90, 90);
            pathEditar2.CloseFigure();
            btnEditar2.Region = new Region(pathEditar2);

            GraphicsPath pathEliminar2 = new GraphicsPath();
            pathEliminar2.AddArc(0, 0, radius, radius, 180, 90);
            pathEliminar2.AddArc(btnEliminar2.Width - radius, 0, radius, radius, 270, 90);
            pathEliminar2.AddArc(btnEliminar2.Width - radius, btnEliminar2.Height - radius, radius, radius, 0, 90);
            pathEliminar2.AddArc(0, btnEliminar2.Height - radius, radius, radius, 90, 90);
            pathEliminar2.CloseFigure();
            btnEliminar2.Region = new Region(pathEliminar2);

            GraphicsPath pathBuscar2 = new GraphicsPath();
            pathBuscar2.AddArc(0, 0, radius, radius, 180, 90);
            pathBuscar2.AddArc(btnBuscar2.Width - radius, 0, radius, radius, 270, 90);
            pathBuscar2.AddArc(btnBuscar2.Width - radius, btnBuscar2.Height - radius, radius, radius, 0, 90);
            pathBuscar2.AddArc(0, btnBuscar2.Height - radius, radius, radius, 90, 90);
            pathBuscar2.CloseFigure();
            btnBuscar2.Region = new Region(pathBuscar2);
        }
    }
}

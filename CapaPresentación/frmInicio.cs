using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CapaPresentación
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();

            AbrirFormHijo(new frmHome());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmHome());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0x0f012, 0);
        }
        //TODO metodo Para abrir formulario hijos
        private void AbrirFormHijo(object FormHijo)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form Vehiculos = FormHijo as Form;
            Vehiculos.TopLevel = false;
            Vehiculos.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(Vehiculos);
            this.panel3.Tag = Vehiculos;
            Vehiculos.Show();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmVehiculos());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmDisponibilidad());
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmProveedores());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has salido del sistema");

            frmLogin formLogin = new frmLogin();
            formLogin.Show();

            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btn_acerca_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmAcercaDe());
        }
    }
}

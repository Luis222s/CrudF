using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using CapaNegocio;

namespace CapaPresentación
{
    public partial class frmLogin : Form
    {
        CN_Proveedor ObjetoCN = new CN_Proveedor();

        private static string connectionString = "Server=.;Database=CRUDF;Integrated Security=true;Encrypt=False;";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int radius = 20;
            GraphicsPath pathLogin = new GraphicsPath();
            pathLogin.AddArc(0, 0, radius, radius, 180, 90);
            pathLogin.AddArc(btnLogin.Width - radius, 0, radius, radius, 270, 90);
            pathLogin.AddArc(btnLogin.Width - radius, btnLogin.Height - radius, radius, radius, 0, 90);
            pathLogin.AddArc(0, btnLogin.Height - radius, radius, radius, 90, 90);
            pathLogin.CloseFigure();
            btnLogin.Region = new Region(pathLogin);
        }

        private void MostrarProveedor()
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Verificar que los campos no estén vacíos
            if (string.IsNullOrEmpty(txtusuario.Text) || string.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.");
                return;
            }


            // Abrir la conexión y realizar la consulta con parámetros
            try
            {
                using (SqlConnection Conexion = new SqlConnection(connectionString))
                {
                    Conexion.Open();

                    string query = "SELECT * FROM Login WHERE Usuario = @Usuario AND Contraseña = @Contraseña";
                    using (SqlCommand cmd = new SqlCommand(query, Conexion))
                    {
                        // Añadir los parámetros de manera segura
                        cmd.Parameters.AddWithValue("@Usuario", txtusuario.Text);
                        cmd.Parameters.AddWithValue("@Contraseña", txtpassword.Text);

                        // Ejecutar la consulta y obtener los resultados
                        using (SqlDataReader Lector = cmd.ExecuteReader())
                        {
                            if (Lector.HasRows)
                            {
                                // Leer los datos del lector para asegurar que son exactamente iguales
                                while (Lector.Read())
                                {
                                    // Obtener los valores de usuario y contraseña de la base de datos
                                    string usuarioBaseDeDatos = Lector["Usuario"].ToString();
                                    string contrasenaBaseDeDatos = Lector["Contraseña"].ToString();

                                    // Comparar estrictamente los valores con los que el usuario ingresó
                                    if (txtusuario.Text.Equals(usuarioBaseDeDatos) && txtpassword.Text.Equals(contrasenaBaseDeDatos))
                                    {
                                        // Si los datos coinciden exactamente, iniciar sesión correctamente
                                        MessageBox.Show("Sesión iniciada de manera exitosa");

                                        // Mostrar el formulario principal
                                        frmInicio formPrincipal = new frmInicio();
                                        formPrincipal.Show();

                                        // Ocultar el formulario de login
                                        this.Hide();
                                    }
                                    else
                                    {
                                        // Si los valores no coinciden, mostrar un mensaje de error
                                        MessageBox.Show("Usuario o Contraseña incorrectos");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usuario o Contraseña incorrectos");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }
    }
}

namespace CapaPresentación
{
    partial class frmDisponibilidad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisponibilidad));
            dgvConsultas = new DataGridView();
            btnAgregar1 = new Button();
            btnEditar1 = new Button();
            btnEliminar1 = new Button();
            btnBuscar1 = new Button();
            textBox4 = new TextBox();
            cboEstadoVenta = new ComboBox();
            cboDisponibilidad = new ComboBox();
            cboVehiculo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).BeginInit();
            SuspendLayout();
            // 
            // dgvConsultas
            // 
            dgvConsultas.BackgroundColor = Color.White;
            dgvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultas.Location = new Point(36, 93);
            dgvConsultas.Name = "dgvConsultas";
            dgvConsultas.Size = new Size(579, 223);
            dgvConsultas.TabIndex = 0;
            dgvConsultas.CellContentClick += dgvConsultas_CellContentClick;
            // 
            // btnAgregar1
            // 
            btnAgregar1.BackColor = Color.SteelBlue;
            btnAgregar1.Cursor = Cursors.Hand;
            btnAgregar1.FlatAppearance.BorderSize = 0;
            btnAgregar1.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnAgregar1.FlatStyle = FlatStyle.Flat;
            btnAgregar1.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar1.ForeColor = Color.White;
            btnAgregar1.Location = new Point(108, 333);
            btnAgregar1.Name = "btnAgregar1";
            btnAgregar1.Size = new Size(112, 46);
            btnAgregar1.TabIndex = 4;
            btnAgregar1.Text = "Agregar";
            btnAgregar1.UseVisualStyleBackColor = false;
            btnAgregar1.Click += button1_Click;
            // 
            // btnEditar1
            // 
            btnEditar1.BackColor = Color.SteelBlue;
            btnEditar1.Cursor = Cursors.Hand;
            btnEditar1.FlatAppearance.BorderSize = 0;
            btnEditar1.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnEditar1.FlatStyle = FlatStyle.Flat;
            btnEditar1.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar1.ForeColor = Color.White;
            btnEditar1.Location = new Point(275, 333);
            btnEditar1.Name = "btnEditar1";
            btnEditar1.Size = new Size(112, 46);
            btnEditar1.TabIndex = 5;
            btnEditar1.Text = "Editar";
            btnEditar1.TextAlign = ContentAlignment.TopCenter;
            btnEditar1.UseVisualStyleBackColor = false;
            btnEditar1.Click += button2_Click;
            // 
            // btnEliminar1
            // 
            btnEliminar1.BackColor = Color.SteelBlue;
            btnEliminar1.Cursor = Cursors.Hand;
            btnEliminar1.FlatAppearance.BorderSize = 0;
            btnEliminar1.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnEliminar1.FlatStyle = FlatStyle.Flat;
            btnEliminar1.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar1.ForeColor = Color.White;
            btnEliminar1.Location = new Point(443, 333);
            btnEliminar1.Name = "btnEliminar1";
            btnEliminar1.Size = new Size(112, 46);
            btnEliminar1.TabIndex = 6;
            btnEliminar1.Text = "Eliminar";
            btnEliminar1.TextAlign = ContentAlignment.TopCenter;
            btnEliminar1.UseVisualStyleBackColor = false;
            btnEliminar1.Click += button3_Click;
            // 
            // btnBuscar1
            // 
            btnBuscar1.BackColor = Color.SteelBlue;
            btnBuscar1.Cursor = Cursors.Hand;
            btnBuscar1.FlatAppearance.BorderSize = 0;
            btnBuscar1.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnBuscar1.FlatStyle = FlatStyle.Flat;
            btnBuscar1.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar1.ForeColor = Color.White;
            btnBuscar1.Location = new Point(485, 51);
            btnBuscar1.Name = "btnBuscar1";
            btnBuscar1.Size = new Size(130, 36);
            btnBuscar1.TabIndex = 11;
            btnBuscar1.Text = "Buscar";
            btnBuscar1.TextAlign = ContentAlignment.TopCenter;
            btnBuscar1.UseVisualStyleBackColor = false;
            btnBuscar1.Click += btnBuscar1_Click;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(91, 51);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(139, 23);
            textBox4.TabIndex = 12;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // cboEstadoVenta
            // 
            cboEstadoVenta.FormattingEnabled = true;
            cboEstadoVenta.Location = new Point(108, 423);
            cboEstadoVenta.Name = "cboEstadoVenta";
            cboEstadoVenta.Size = new Size(143, 23);
            cboEstadoVenta.TabIndex = 13;
            // 
            // cboDisponibilidad
            // 
            cboDisponibilidad.FormattingEnabled = true;
            cboDisponibilidad.Location = new Point(485, 423);
            cboDisponibilidad.Name = "cboDisponibilidad";
            cboDisponibilidad.Size = new Size(143, 23);
            cboDisponibilidad.TabIndex = 14;
            // 
            // cboVehiculo
            // 
            cboVehiculo.FormattingEnabled = true;
            cboVehiculo.Location = new Point(485, 465);
            cboVehiculo.Name = "cboVehiculo";
            cboVehiculo.Size = new Size(143, 23);
            cboVehiculo.TabIndex = 15;
            // 
            // frmDisponibilidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(656, 565);
            Controls.Add(cboVehiculo);
            Controls.Add(cboDisponibilidad);
            Controls.Add(cboEstadoVenta);
            Controls.Add(textBox4);
            Controls.Add(btnBuscar1);
            Controls.Add(btnEliminar1);
            Controls.Add(btnEditar1);
            Controls.Add(btnAgregar1);
            Controls.Add(dgvConsultas);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDisponibilidad";
            Text = "frmDisponibilidad";
            Load += frmDisponibilidad_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvConsultas;
        private Button btnAgregar1;
        private Button btnEditar1;
        private Button btnEliminar1;
        private Button btnBuscar1;
        private TextBox textBox4;
        private ComboBox cboEstadoVenta;
        private ComboBox cboDisponibilidad;
        private ComboBox cboVehiculo;
    }
}
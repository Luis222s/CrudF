namespace CapaPresentación
{
    partial class frmVehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehiculos));
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            txtAño = new TextBox();
            txtPrecio = new TextBox();
            txtCondicion = new TextBox();
            txtTipo = new TextBox();
            dgvVehiculos = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            btnEliminar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtModelo
            // 
            txtModelo.BorderStyle = BorderStyle.FixedSingle;
            txtModelo.Location = new Point(114, 383);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(179, 23);
            txtModelo.TabIndex = 0;
            // 
            // txtMarca
            // 
            txtMarca.BorderStyle = BorderStyle.FixedSingle;
            txtMarca.Location = new Point(114, 423);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(179, 23);
            txtMarca.TabIndex = 1;
            // 
            // txtAño
            // 
            txtAño.BorderStyle = BorderStyle.FixedSingle;
            txtAño.Location = new Point(114, 467);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(179, 23);
            txtAño.TabIndex = 2;
            // 
            // txtPrecio
            // 
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Location = new Point(501, 467);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(128, 23);
            txtPrecio.TabIndex = 3;
            // 
            // txtCondicion
            // 
            txtCondicion.BorderStyle = BorderStyle.FixedSingle;
            txtCondicion.Location = new Point(501, 423);
            txtCondicion.Name = "txtCondicion";
            txtCondicion.Size = new Size(128, 23);
            txtCondicion.TabIndex = 4;
            // 
            // txtTipo
            // 
            txtTipo.BorderStyle = BorderStyle.FixedSingle;
            txtTipo.Location = new Point(501, 383);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(128, 23);
            txtTipo.TabIndex = 5;
            // 
            // dgvVehiculos
            // 
            dgvVehiculos.BackgroundColor = Color.White;
            dgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculos.Location = new Point(26, 80);
            dgvVehiculos.Name = "dgvVehiculos";
            dgvVehiculos.Size = new Size(591, 224);
            dgvVehiculos.TabIndex = 6;
            dgvVehiculos.CellContentClick += dataGridView2_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SteelBlue;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(79, 310);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(111, 42);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += button1_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.SteelBlue;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(266, 310);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(111, 42);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.TopCenter;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.SteelBlue;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(501, 38);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(116, 36);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextAlign = ContentAlignment.TopCenter;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Location = new Point(87, 51);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(139, 23);
            txtBuscar.TabIndex = 11;
            txtBuscar.TextChanged += textBox8_TextChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.SteelBlue;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(458, 310);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(111, 42);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.TopCenter;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(336, 503);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 50);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // frmVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(656, 565);
            Controls.Add(pictureBox1);
            Controls.Add(btnEliminar);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvVehiculos);
            Controls.Add(txtTipo);
            Controls.Add(txtCondicion);
            Controls.Add(txtPrecio);
            Controls.Add(txtAño);
            Controls.Add(txtMarca);
            Controls.Add(txtModelo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmVehiculos";
            Text = "frmVehiculos";
            Load += frmVehiculos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtModelo;
        private TextBox txtMarca;
        private TextBox txtAño;
        private TextBox txtPrecio;
        private TextBox txtCondicion;
        private TextBox txtTipo;
        private DataGridView dgvVehiculos;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Button btnEliminar;
        private PictureBox pictureBox1;
    }
}
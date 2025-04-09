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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            dataGridView1 = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(114, 383);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(114, 423);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(114, 467);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(179, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(501, 467);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(128, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(501, 423);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(128, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(501, 383);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(128, 23);
            textBox6.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(591, 224);
            dataGridView1.TabIndex = 6;
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
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.SteelBlue;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe Fluent Icons", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(454, 310);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(111, 42);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.TopCenter;
            btnEliminar.UseVisualStyleBackColor = false;
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
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Location = new Point(87, 51);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(139, 23);
            textBox7.TabIndex = 11;
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Location = new Point(501, 508);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(128, 23);
            textBox8.TabIndex = 12;
            // 
            // frmVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(656, 565);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmVehiculos";
            Text = "frmVehiculos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private DataGridView dataGridView1;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnBuscar;
        private TextBox textBox7;
        private TextBox textBox8;
    }
}
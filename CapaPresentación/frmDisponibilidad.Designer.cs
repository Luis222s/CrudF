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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnAgregar1 = new Button();
            btnEditar1 = new Button();
            btnEliminar1 = new Button();
            btnBuscar1 = new Button();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(579, 223);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(112, 463);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(495, 448);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(495, 492);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(149, 23);
            textBox3.TabIndex = 3;
            // 
            // btnAgregar1
            // 
            btnAgregar1.BackColor = Color.SteelBlue;
            btnAgregar1.Cursor = Cursors.Hand;
            btnAgregar1.FlatAppearance.BorderSize = 0;
            btnAgregar1.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnAgregar1.FlatStyle = FlatStyle.Flat;
            btnAgregar1.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar1.ForeColor = Color.White;
            btnAgregar1.Location = new Point(149, 332);
            btnAgregar1.Name = "btnAgregar1";
            btnAgregar1.Size = new Size(112, 46);
            btnAgregar1.TabIndex = 4;
            btnAgregar1.Text = "Agregar";
            btnAgregar1.TextAlign = ContentAlignment.TopCenter;
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
            btnEditar1.Location = new Point(316, 332);
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
            btnEliminar1.Location = new Point(484, 332);
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
            btnBuscar1.Location = new Point(516, 51);
            btnBuscar1.Name = "btnBuscar1";
            btnBuscar1.Size = new Size(80, 36);
            btnBuscar1.TabIndex = 11;
            btnBuscar1.Text = "Buscar";
            btnBuscar1.TextAlign = ContentAlignment.TopCenter;
            btnBuscar1.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(100, 55);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(139, 23);
            textBox4.TabIndex = 12;
            // 
            // frmDisponibilidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(656, 565);
            Controls.Add(textBox4);
            Controls.Add(btnBuscar1);
            Controls.Add(btnEliminar1);
            Controls.Add(btnEditar1);
            Controls.Add(btnAgregar1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDisponibilidad";
            Text = "frmDisponibilidad";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnAgregar1;
        private Button btnEditar1;
        private Button btnEliminar1;
        private Button btnBuscar1;
        private TextBox textBox4;
    }
}
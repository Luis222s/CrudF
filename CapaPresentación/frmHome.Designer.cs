namespace CapaPresentación
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            lblcantidad = new Label();
            SuspendLayout();
            // 
            // lblcantidad
            // 
            lblcantidad.AutoSize = true;
            lblcantidad.BackColor = Color.Transparent;
            lblcantidad.Font = new Font("Segoe MDL2 Assets", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcantidad.ForeColor = Color.White;
            lblcantidad.Location = new Point(312, 310);
            lblcantidad.Name = "lblcantidad";
            lblcantidad.Size = new Size(32, 37);
            lblcantidad.TabIndex = 0;
            lblcantidad.Text = "2";
            lblcantidad.Click += lblcantidad_Click;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(656, 565);
            Controls.Add(lblcantidad);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmHome";
            Text = "frmHome";
            Load += frmHome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcantidad;
    }
}
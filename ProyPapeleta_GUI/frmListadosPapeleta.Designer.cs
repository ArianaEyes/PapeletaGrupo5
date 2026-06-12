namespace ProyPapeleta_GUI
{
    partial class frmListadosPapeleta
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
            btnListarPolicias = new Button();
            btnListarInfractores = new Button();
            btnListarInfracciones = new Button();
            lblMensaje = new Label();
            prgBar = new ProgressBar();
            pcdImagen = new PictureBox();
            bkgDatos = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)pcdImagen).BeginInit();
            SuspendLayout();
            // 
            // btnListarPolicias
            // 
            btnListarPolicias.Image = Properties.Resources.book_blue;
            btnListarPolicias.ImageAlign = ContentAlignment.MiddleLeft;
            btnListarPolicias.Location = new Point(87, 58);
            btnListarPolicias.Name = "btnListarPolicias";
            btnListarPolicias.Size = new Size(202, 42);
            btnListarPolicias.TabIndex = 1;
            btnListarPolicias.Text = "Listar Policias";
            btnListarPolicias.UseVisualStyleBackColor = true;
            btnListarPolicias.Click += btnListarPolicias_Click;
            // 
            // btnListarInfractores
            // 
            btnListarInfractores.Image = Properties.Resources.book_blue;
            btnListarInfractores.ImageAlign = ContentAlignment.MiddleLeft;
            btnListarInfractores.Location = new Point(87, 140);
            btnListarInfractores.Name = "btnListarInfractores";
            btnListarInfractores.Size = new Size(202, 42);
            btnListarInfractores.TabIndex = 2;
            btnListarInfractores.Text = "Listar Infractores";
            btnListarInfractores.UseVisualStyleBackColor = true;
            btnListarInfractores.Click += btnListarInfractores_Click;
            // 
            // btnListarInfracciones
            // 
            btnListarInfracciones.Image = Properties.Resources.book_blue;
            btnListarInfracciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnListarInfracciones.Location = new Point(87, 220);
            btnListarInfracciones.Name = "btnListarInfracciones";
            btnListarInfracciones.Size = new Size(202, 42);
            btnListarInfracciones.TabIndex = 3;
            btnListarInfracciones.Text = "Listar Infracciones";
            btnListarInfracciones.UseVisualStyleBackColor = true;
            btnListarInfracciones.Click += btnListarInfracciones_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(169, 307);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(68, 15);
            lblMensaje.TabIndex = 4;
            lblMensaje.Text = "...Cargando";
            // 
            // prgBar
            // 
            prgBar.Location = new Point(87, 343);
            prgBar.Name = "prgBar";
            prgBar.Size = new Size(202, 23);
            prgBar.TabIndex = 5;
            // 
            // pcdImagen
            // 
            pcdImagen.Image = Properties.Resources.waiting;
            pcdImagen.Location = new Point(145, 307);
            pcdImagen.Name = "pcdImagen";
            pcdImagen.Size = new Size(18, 15);
            pcdImagen.TabIndex = 6;
            pcdImagen.TabStop = false;
            // 
            // bkgDatos
            // 
            bkgDatos.WorkerReportsProgress = true;
            bkgDatos.DoWork += bkgDatos_DoWork;
            bkgDatos.ProgressChanged += bkgDatos_ProgressChanged;
            bkgDatos.RunWorkerCompleted += bkgDatos_RunWorkerCompleted;
            // 
            // frmListadosPapeleta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 450);
            Controls.Add(pcdImagen);
            Controls.Add(prgBar);
            Controls.Add(lblMensaje);
            Controls.Add(btnListarInfracciones);
            Controls.Add(btnListarInfractores);
            Controls.Add(btnListarPolicias);
            Name = "frmListadosPapeleta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmListadosPapeleta";
            ((System.ComponentModel.ISupportInitialize)pcdImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListarPolicias;
        private Button btnListarInfractores;
        private Button btnListarInfracciones;
        private Label lblMensaje;
        private ProgressBar prgBar;
        private PictureBox pcdImagen;
        private System.ComponentModel.BackgroundWorker bkgDatos;
    }
}
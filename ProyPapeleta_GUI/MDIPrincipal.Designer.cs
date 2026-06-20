namespace ProyPapeleta_GUI
{
    partial class MDIPrincipal
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
            menuStrip1 = new MenuStrip();
            mantenimientosToolStripMenuItem = new ToolStripMenuItem();
            policíasToolStripMenuItem = new ToolStripMenuItem();
            infractoresToolStripMenuItem = new ToolStripMenuItem();
            infraccionesToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            consultarMultasToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            obtenerExcelsToolStripMenuItem = new ToolStripMenuItem();
            salirDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblUsuario = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mantenimientosToolStripMenuItem, consultasToolStripMenuItem, salirDelSistemaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 1, 0, 1);
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            mantenimientosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { policíasToolStripMenuItem, infractoresToolStripMenuItem, infraccionesToolStripMenuItem });
            mantenimientosToolStripMenuItem.Image = Properties.Resources.Listado;
            mantenimientosToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            mantenimientosToolStripMenuItem.Size = new Size(117, 22);
            mantenimientosToolStripMenuItem.Text = "Mantenimiento";
            // 
            // policíasToolStripMenuItem
            // 
            policíasToolStripMenuItem.Image = Properties.Resources.Usuario;
            policíasToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            policíasToolStripMenuItem.Name = "policíasToolStripMenuItem";
            policíasToolStripMenuItem.Size = new Size(188, 30);
            policíasToolStripMenuItem.Text = "Policías";
            policíasToolStripMenuItem.Click += policíasToolStripMenuItem_Click;
            // 
            // infractoresToolStripMenuItem
            // 
            infractoresToolStripMenuItem.Image = Properties.Resources.users3;
            infractoresToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            infractoresToolStripMenuItem.Name = "infractoresToolStripMenuItem";
            infractoresToolStripMenuItem.Size = new Size(188, 30);
            infractoresToolStripMenuItem.Text = "Infractores";
            infractoresToolStripMenuItem.Click += infractoresToolStripMenuItem_Click;
            // 
            // infraccionesToolStripMenuItem
            // 
            infraccionesToolStripMenuItem.Image = Properties.Resources.database_table;
            infraccionesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            infraccionesToolStripMenuItem.Name = "infraccionesToolStripMenuItem";
            infraccionesToolStripMenuItem.Size = new Size(188, 30);
            infraccionesToolStripMenuItem.Text = "Infracciones";
            infraccionesToolStripMenuItem.Click += infraccionesToolStripMenuItem_Click;
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarMultasToolStripMenuItem, toolStripMenuItem1, obtenerExcelsToolStripMenuItem });
            consultasToolStripMenuItem.Image = Properties.Resources.Buscar;
            consultasToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(87, 22);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultarMultasToolStripMenuItem
            // 
            consultarMultasToolStripMenuItem.Image = Properties.Resources.book_open;
            consultarMultasToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            consultarMultasToolStripMenuItem.Name = "consultarMultasToolStripMenuItem";
            consultarMultasToolStripMenuItem.Size = new Size(188, 30);
            consultarMultasToolStripMenuItem.Text = "Consultar Multas";
            consultarMultasToolStripMenuItem.Click += consultarMultasToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(185, 6);
            // 
            // obtenerExcelsToolStripMenuItem
            // 
            obtenerExcelsToolStripMenuItem.Image = Properties.Resources.form_green;
            obtenerExcelsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            obtenerExcelsToolStripMenuItem.Name = "obtenerExcelsToolStripMenuItem";
            obtenerExcelsToolStripMenuItem.Size = new Size(188, 30);
            obtenerExcelsToolStripMenuItem.Text = "Listado de Excel";
            obtenerExcelsToolStripMenuItem.Click += obtenerExcelsToolStripMenuItem_Click;
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            salirDelSistemaToolStripMenuItem.Image = Properties.Resources.lock_go;
            salirDelSistemaToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new Size(119, 22);
            salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Image = Properties.Resources.arrow_right;
            salirToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUsuario });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            lblUsuario.BackColor = SystemColors.ActiveCaptionText;
            lblUsuario.ForeColor = SystemColors.ButtonHighlight;
            lblUsuario.Image = Properties.Resources.Usuario;
            lblUsuario.ImageScaling = ToolStripItemImageScaling.None;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(109, 17);
            lblUsuario.Text = "Usuario Actual : ";
            // 
            // MDIPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Trafico;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "MDIPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MDIPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += MDIPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mantenimientosToolStripMenuItem;
        private ToolStripMenuItem policíasToolStripMenuItem;
        private ToolStripMenuItem infractoresToolStripMenuItem;
        private ToolStripMenuItem infraccionesToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblUsuario;
        private ToolStripMenuItem consultarMultasToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem obtenerExcelsToolStripMenuItem;
    }
}
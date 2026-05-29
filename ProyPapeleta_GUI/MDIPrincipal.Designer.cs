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
            consultarDatosToolStripMenuItem = new ToolStripMenuItem();
            consultarPorInfractorToolStripMenuItem = new ToolStripMenuItem();
            consultarPorInfracciónToolStripMenuItem = new ToolStripMenuItem();
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
            mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            mantenimientosToolStripMenuItem.Size = new Size(101, 22);
            mantenimientosToolStripMenuItem.Text = "Mantenimiento";
            // 
            // policíasToolStripMenuItem
            // 
            policíasToolStripMenuItem.Name = "policíasToolStripMenuItem";
            policíasToolStripMenuItem.Size = new Size(138, 22);
            policíasToolStripMenuItem.Text = "Policías";
            policíasToolStripMenuItem.Click += policíasToolStripMenuItem_Click;
            // 
            // infractoresToolStripMenuItem
            // 
            infractoresToolStripMenuItem.Name = "infractoresToolStripMenuItem";
            infractoresToolStripMenuItem.Size = new Size(138, 22);
            infractoresToolStripMenuItem.Text = "Infractores";
            infractoresToolStripMenuItem.Click += infractoresToolStripMenuItem_Click;
            // 
            // infraccionesToolStripMenuItem
            // 
            infraccionesToolStripMenuItem.Name = "infraccionesToolStripMenuItem";
            infraccionesToolStripMenuItem.Size = new Size(138, 22);
            infraccionesToolStripMenuItem.Text = "Infracciones";
            infraccionesToolStripMenuItem.Click += infraccionesToolStripMenuItem_Click;
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarDatosToolStripMenuItem, consultarPorInfractorToolStripMenuItem, consultarPorInfracciónToolStripMenuItem });
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(71, 22);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultarDatosToolStripMenuItem
            // 
            consultarDatosToolStripMenuItem.Name = "consultarDatosToolStripMenuItem";
            consultarDatosToolStripMenuItem.Size = new Size(202, 22);
            consultarDatosToolStripMenuItem.Text = "Consultar por Policia";
            consultarDatosToolStripMenuItem.Click += consultarDatosToolStripMenuItem_Click;
            // 
            // consultarPorInfractorToolStripMenuItem
            // 
            consultarPorInfractorToolStripMenuItem.Name = "consultarPorInfractorToolStripMenuItem";
            consultarPorInfractorToolStripMenuItem.Size = new Size(202, 22);
            consultarPorInfractorToolStripMenuItem.Text = "Consultar por Infractor";
            consultarPorInfractorToolStripMenuItem.Click += consultarPorInfractorToolStripMenuItem_Click;
            // 
            // consultarPorInfracciónToolStripMenuItem
            // 
            consultarPorInfracciónToolStripMenuItem.Name = "consultarPorInfracciónToolStripMenuItem";
            consultarPorInfracciónToolStripMenuItem.Size = new Size(202, 22);
            consultarPorInfracciónToolStripMenuItem.Text = "Consultar por Infracción";
            consultarPorInfracciónToolStripMenuItem.Click += consultarPorInfracciónToolStripMenuItem_Click;
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new Size(103, 22);
            salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
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
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(93, 17);
            lblUsuario.Text = "Usuario Actual : ";
            // 
            // MDIPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "MDIPrincipal";
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
        private ToolStripMenuItem consultarDatosToolStripMenuItem;
        private ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblUsuario;
        private ToolStripMenuItem consultarPorInfractorToolStripMenuItem;
        private ToolStripMenuItem consultarPorInfracciónToolStripMenuItem;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyPapeleta_GUI
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            //Mostramos el usuario loqueado en el statusLabel 
            lblUsuario.Text = $"Usuario actual: {clsCredenciales.Usuario}";

            //Manejamos la seguridad por roles... 
            if (clsCredenciales.Nivel == 1)
            {
                mantenimientosToolStripMenuItem.Visible = true;
                consultasToolStripMenuItem.Visible = true;
                salirDelSistemaToolStripMenuItem.Visible = true;
            }
            else if (clsCredenciales.Nivel == 2)
            {
                mantenimientosToolStripMenuItem.Visible = false;
                consultasToolStripMenuItem.Visible = true;
                salirDelSistemaToolStripMenuItem.Visible = true;
            }

        }


        private void policíasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instancia el policíasMan01
            PoliciaMan05 poli05 = new PoliciaMan05();
            poli05.MdiParent = this;
            poli05.Show();

        }

        private void infractoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfractorMan03 infr03 = new InfractorMan03();
            infr03.MdiParent = this;
            infr03.Show();
        }

        private void consultarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instancia el policíasMan02
            PoliciaMan03 poli03 = new PoliciaMan03();
            poli03.MdiParent = this;
            poli03.Show();
        }

        private void consultarPorInfractorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfractorMan05 infr05 = new InfractorMan05();
            infr05.MdiParent = this;
            infr05.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void infraccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfraccionMan05 infracc05 = new InfraccionMan05();
            infracc05.MdiParent = this;
            infracc05.Show();
        }

        private void consultarPorInfracciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfraccionMan03 infr03 = new InfraccionMan03();
            infr03.MdiParent = this;
            infr03.Show();
        }
    }
}


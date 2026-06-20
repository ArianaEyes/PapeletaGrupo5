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
            foreach (Form f in this.MdiChildren)
            {
                if (f is PoliciaMan03)
                {
                    f.Activate();
                    return;
                }
            }
            //Instancia el policíasMan01
            PoliciaMan03 poli05 = new PoliciaMan03();
            poli05.MdiParent = this;
            poli05.Show();

        }

        private void infractoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is InfractorMan03)
                {
                    f.Activate();
                    return;
                }
            }
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
            foreach (Form f in this.MdiChildren)
            {
                if (f is InfractorMan03)
                {
                    f.Activate();
                    return;
                }
            }
            InfractorMan03 infr03 = new InfractorMan03();
            infr03.MdiParent = this;
            infr03.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void infraccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is InfraccionMan03)
                {
                    f.Activate();
                    return;
                }
            }
            InfraccionMan03 infracc05 = new InfraccionMan03();
            infracc05.MdiParent = this;
            infracc05.Show();
        }

        private void consultarPorInfracciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is InfraccionMan03)
                {
                    f.Activate();
                    return;
                }
            }
            InfraccionMan03 infr03 = new InfraccionMan03();
            infr03.MdiParent = this;
            infr03.Show();
        }
        //k
        private void consultarMultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is MultasInfractor)
                {
                    f.Activate();
                    return;
                }
            }
            MultasInfractor multas01 = new MultasInfractor();
            multas01.MdiParent = this;
            multas01.Show();
        }

        private void obtenerExcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadosPapeleta frmPapeleta = new frmListadosPapeleta();
            frmPapeleta.MdiParent = this;
            frmPapeleta.Show();
        }
    }
}
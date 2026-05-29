using ProyPapeletaADO;
using ProyPapeletaBE;
using ProyPapeletaBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyPapeleta_GUI
{
    public partial class InfraccionMan03 : Form
    {
        InfraccionBL objInfraccionBL = new InfraccionBL();
        public string Codigo = "";
        public InfraccionMan05 Formulario;
        public InfraccionMan03()
        {
            InitializeComponent();
        }

        private void InfraccionMan03_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarInfraccion_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCod.Text.Trim();

                InfraccionBE objInfraccionBE =
                    objInfraccionBL.ConsultarInfraccion(codigo);

                if (objInfraccionBE == null)
                {
                    MessageBox.Show("Infractor no existe");
                    return;
                }

                lblDescripcion.Text = objInfraccionBE.DESCRIPCION_SANCION;
                lblCalificacion.Text = objInfraccionBE.CALIFICACION;
                lblPuntos.Text = objInfraccionBE.PUNTOS.ToString();
                lblUIT.Text = objInfraccionBE.UIT.ToString();
         
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void grpDatosPolicia_Enter(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class InfraccionMan02 : Form
    {
        public string Codigo = "";

        string[] calificacion = {
                "--Seleccionar--",
                "LEVE",
                "GRAVE",
                "MUY GRAVE"     };

        public InfraccionMan03 Formulario;
        public InfraccionMan02()
        {
            InitializeComponent();
            Load += InfraccionMan02_Load;
        }

        private void grpDatosPolicia_Enter(object sender, EventArgs e)
        {

        }

        private void InfraccionMan02_Load(object sender, EventArgs e)
        {
            try
            {
                InfraccionADO objADO = new InfraccionADO();

                InfraccionBE objBE = objADO.ConsultarInfraccion(Codigo);

                if (objBE == null)
                {
                    MessageBox.Show("No existe el infracción");
                    this.Close();
                    return;
                }

                lblCodigo.Text = objBE.COD_INFRACCION;
                txtDescripcion.Text = objBE.DESCRIPCION_SANCION;
                cboCalificacion.Text = objBE.CALIFICACION;
                chkActivo.Checked = (objBE.ESTADO == "A");
                nudPuntos.Value = objBE.PUNTOS;
                nudUIT.Value = objBE.UIT;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarInfraccion_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                InfraccionBE objBE = new InfraccionBE();

                objBE.COD_INFRACCION = Codigo;

                objBE.DESCRIPCION_SANCION = txtDescripcion.Text;
                objBE.CALIFICACION = cboCalificacion.Text;
                objBE.PUNTOS = (int)nudPuntos.Value;
                objBE.UIT = nudUIT.Value;
                objBE.ESTADO = chkActivo.Checked ? "A" : "I";

                InfraccionBL bl = new InfraccionBL();

                if (bl.ActualizarInfraccion(objBE))
                {
                    MessageBox.Show("Actualizado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

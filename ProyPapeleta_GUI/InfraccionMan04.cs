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
    public partial class InfraccionMan04 : Form
    {
        public string Codigo = "";
        public InfraccionMan05 Formulario;
        public InfraccionMan04()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void InfraccionMan04_Load(object sender, EventArgs e)
        {
            try
            {
                InfraccionADO objADO = new InfraccionADO();

                InfraccionBE objBE =
                    objADO.ConsultarInfraccion(Codigo);

                txtCod.Text = objBE.COD_INFRACCION;

                lblDescripcion.Text = objBE.DESCRIPCION_SANCION;
                lblCalificacion.Text = objBE.CALIFICACION;
                lblPuntos.Text = objBE.PUNTOS.ToString();
                lblUIT.Text = objBE.UIT.ToString();
                lblEstado.Text = objBE.ESTADO;
                lblMedida.Text = objBE.MEDIDA_PREVENTIVA;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarInfraccion_Click(object sender, EventArgs e)
        {
            try
            {
                string cod = txtCod.Text.Trim();

                if (string.IsNullOrWhiteSpace(cod))
                {
                    MessageBox.Show("No hay código ingresado");
                    return;
                }

                DialogResult rpta = MessageBox.Show(
                    "¿Seguro que deseas eliminar esta infracción?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (rpta == DialogResult.Yes)
                {
                    InfraccionBL bl = new InfraccionBL();

                    bool ok = bl.EliminarInfraccion(cod);

                    if (ok)
                        MessageBox.Show("Infractor eliminado correctamente");
                    else
                        MessageBox.Show("No se pudo eliminar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

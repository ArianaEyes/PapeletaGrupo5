using ProyPapeletaADO;
using ProyPapeletaBE;
using ProyPapeletaBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
namespace ProyPapeleta_GUI
{
    public partial class InfractorMan04 : Form

    {
        public string Codigo = "";

        public InfractorMan03 Formulario;
        public InfractorMan04()
        {
            InitializeComponent();
        }

        private void InfractorMan04_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pcbFoto_Click(object sender, EventArgs e)
        {

        }

        private void InfractorMan04_Load_1(object sender, EventArgs e)
        {
            try
            {
                InfractorADO objADO = new InfractorADO();

                InfractorBE objBE =
                    objADO.ConsultarInfractor(Codigo);

                txtCodigo.Text = objBE.COD_INFRACTOR;

                lblNombres.Text = objBE.NOMBRES;

                lblApePaterno.Text =
                    objBE.APE_PATERNO;

                lblApeMaterno.Text =
                    objBE.APE_MATERNO;

                lblDNI.Text = objBE.DNI;

                lblCorreo.Text = objBE.CORREO;

                lblDireccion.Text =
                    objBE.DIRECCION;

                lblNroBrevete.Text =
                    objBE.NRO_BREVETE;

                lblTipoBrevete.Text =
                    objBE.TIPO_BREVETE;

                lblFecNacimiento.Text =
                    objBE.FEC_NACIMIENTO.ToShortDateString();

                lblSexo.Text = objBE.SEXO;

                if (objBE.FOTO != null)
                {
                    MemoryStream ms =
                        new MemoryStream(objBE.FOTO);

                    pcbFoto.Image =
                        Image.FromStream(ms);

                    pcbFoto.SizeMode =
                        PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string cod = txtCodigo.Text.Trim();

                if (string.IsNullOrWhiteSpace(cod))
                {
                    MessageBox.Show("No hay código ingresado");
                    return;
                }

                DialogResult rpta = MessageBox.Show(
                    "¿Seguro que deseas eliminar este infractor?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (rpta == DialogResult.Yes)
                {
                    InfractorBL bl = new InfractorBL();

                    bool ok = bl.EliminarInfractor(cod);

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

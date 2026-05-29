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

namespace ProyPapeleta_GUI
{
    public partial class PoliciaMan04 : Form
    {
        public string Codigo = "";

        public PoliciaMan05 Formulario;

        public PoliciaMan04()
        {
            InitializeComponent();
        }

        private void PoliciaMan04_Load(object sender, EventArgs e)
        {
            try
            {
                PoliciaADO objPoliciaADO = new PoliciaADO();

                PoliciaBE objPoliciaBE =
                    objPoliciaADO.ConsultarPolicia(Codigo);

                txtCodigo.Text = objPoliciaBE.COD_POLICIA;

                lblNombre.Text = objPoliciaBE.NOMBRE;
                lblApellidoPaterno.Text = objPoliciaBE.PATERNO;
                lblApellidoMaterno.Text = objPoliciaBE.MATERNO;
                lblDNI.Text = objPoliciaBE.DNI;
                lblFechaNacimiento.Text = objPoliciaBE.FECHANACIMIENTO.ToShortDateString();
                lblRango.Text = objPoliciaBE.GRADO;
                lblSexo.Text = objPoliciaBE.SEXO;

                if (objPoliciaBE.FOTO != null)
                {
                    MemoryStream ms =
                        new MemoryStream(objPoliciaBE.FOTO);

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
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
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
                    PoliciaBL bl = new PoliciaBL();

                    bool ok = bl.EliminarPolicia(cod);

                    if (ok)
                        MessageBox.Show("Policia eliminado correctamente");
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

using ProyPapeletaADO;
using ProyPapeletaBE;
using ProyPapeletaBL;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyPapeleta_GUI
{
    public partial class PoliciaMan03 : Form
    {
        PoliciaBL objPoliciaBL = new PoliciaBL();

        public PoliciaMan03()
        {
            InitializeComponent();
        }

        private void PoliciaMan03_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text.Trim();

                PoliciaBE objPoliciaBE =
                    objPoliciaBL.ConsultarPolicia(codigo);

                if (objPoliciaBE == null)
                {
                    MessageBox.Show("Policia no existe");
                    return;
                }

                lblNombre.Text = objPoliciaBE.NOMBRE;
                lblApellidoPaterno.Text = objPoliciaBE.PATERNO;
                lblApellidoMaterno.Text = objPoliciaBE.MATERNO;
                lblDNI.Text = objPoliciaBE.DNI;
                lblSexo.Text = objPoliciaBE.SEXO;
                lblRango.Text = objPoliciaBE.GRADO;
                lblEstado.Text = objPoliciaBE.ESTADO;
                lblFechaNacimiento.Text = objPoliciaBE.FECHANACIMIENTO.ToShortDateString();

                DataTable ubigeo = objPoliciaBL.ObtenerUbigeoPorPolicia(codigo);

                if (ubigeo.Rows.Count > 0)
                {
                    lblDepartamento.Text = ubigeo.Rows[0]["DEPARTAMENTO"].ToString();
                    lblProvincia.Text = ubigeo.Rows[0]["PROVINCIA"].ToString();
                    lblDistrito.Text = ubigeo.Rows[0]["DISTRITO"].ToString();
                }
                else
                {
                    lblDepartamento.Text = "-";
                    lblProvincia.Text = "-";
                    lblDistrito.Text = "-";
                }

                if (objPoliciaBE.FOTO != null)
                {
                    MemoryStream ms = new MemoryStream(objPoliciaBE.FOTO);
                    pcbFoto.Image = Image.FromStream(ms);
                }
                else
                {
                    pcbFoto.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
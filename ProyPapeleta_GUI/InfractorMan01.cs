using ProyPapeletaADO;
using ProyPapeletaBE;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyPapeleta_GUI
{
    public partial class InfractorMan01 : Form
    {
        public InfractorMan03 Formulario;

        public InfractorMan01()
        {
            InitializeComponent();

            Load += InfractorMan01_Load;

            cboDepartamento.SelectedIndexChanged += cboDepartamento_SelectedIndexChanged;
            cboProvincia.SelectedIndexChanged += cboProvincia_SelectedIndexChanged;
        }

        private void InfractorMan01_Load(object sender, EventArgs e)
        {
            try
            {
                InfractorADO objInfractorADO = new InfractorADO();

                cboDepartamento.DataSource = objInfractorADO.ListarDepartamentos();

                cboDepartamento.DisplayMember = "DEPARTAMENTO";

                cboTipoBrevete.DataSource = objInfractorADO.ListarTiposBrevete();

                cboTipoBrevete.DisplayMember = "TIPO_BREVETE";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                InfractorADO objInfractorADO = new InfractorADO();

                cboProvincia.DataSource =
                    objInfractorADO.ListarProvincias(cboDepartamento.Text);

                cboProvincia.DisplayMember = "PROVINCIA";
            }
            catch
            {

            }
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                InfractorADO objInfractorADO = new InfractorADO();

                cboDistrito.DataSource =
                    objInfractorADO.ListarDistritos(cboProvincia.Text);

                cboDistrito.DisplayMember = "DISTRITO";
                cboDistrito.ValueMember = "COD_UBIGEO";
            }
            catch
            {

            }
        }

        private bool ValidarCampos()
        {
            if (txtNombres.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese nombres");
                txtNombres.Focus();
                return false;
            }

            if (txtApePaterno.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese apellido paterno");
                txtApePaterno.Focus();
                return false;
            }

            if (txtApeMaterno.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese apellido materno");
                txtApeMaterno.Focus();
                return false;
            }

            if (txtDNI.Text.Trim().Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 dígitos");
                txtDNI.Focus();
                return false;
            }

            if (txtCorreo.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese correo");
                txtCorreo.Focus();
                return false;
            }

            if (!txtCorreo.Text.Contains("@") || !txtCorreo.Text.Contains("."))
            {
                MessageBox.Show("Correo inválido");
                txtCorreo.Focus();
                return false;
            }

            if (txtDireccion.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese dirección");
                txtDireccion.Focus();
                return false;
            }

            if (cboDistrito.SelectedValue == null)
            {
                MessageBox.Show("Seleccione distrito");
                return false;
            }

            if (txtNumBrevete.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese número de brevete");
                txtNumBrevete.Focus();
                return false;
            }

            if (cboTipoBrevete.Text.Trim() == "")
            {
                MessageBox.Show("Seleccione tipo de brevete");
                return false;
            }

            if (!optMasculino.Checked && !optFemenino.Checked)
            {
                MessageBox.Show("Seleccione sexo");
                return false;
            }

            return true;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;
                InfractorBE objInfractorBE = new InfractorBE();

                objInfractorBE.NOMBRES = txtNombres.Text;
                objInfractorBE.APE_PATERNO = txtApePaterno.Text;
                objInfractorBE.APE_MATERNO = txtApeMaterno.Text;

                objInfractorBE.DNI = txtDNI.Text;

                objInfractorBE.CORREO = txtCorreo.Text;
                objInfractorBE.DIRECCION = txtDireccion.Text;

                objInfractorBE.COD_UBIGEO = cboDistrito.SelectedValue.ToString();

                if (optMasculino.Checked == true)
                {
                    objInfractorBE.SEXO = "M";
                }
                else
                {
                    objInfractorBE.SEXO = "F";
                }

                objInfractorBE.FEC_NACIMIENTO =
                    dtpFecNacimiento.Value;

                objInfractorBE.NRO_BREVETE =
                    txtNumBrevete.Text;

                objInfractorBE.TIPO_BREVETE =
                    cboTipoBrevete.Text;

                objInfractorBE.USU_REGISTRO = "ADMIN";

                if (pcbFoto.Image != null)
                {
                    MemoryStream ms = new MemoryStream();

                    pcbFoto.Image.Save(ms,
                    System.Drawing.Imaging.ImageFormat.Jpeg);

                    objInfractorBE.FOTO = ms.ToArray();
                }

                InfractorADO objInfractorADO =
                    new InfractorADO();

                if (objInfractorADO.InsertarInfractor(objInfractorBE))
                {
                    MessageBox.Show(
                        "Infractor registrado correctamente");

                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo registrar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pcbFoto.Image = Image.FromFile(ofd.FileName);

                pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void InfractorMan01_Load_1(object sender, EventArgs e)
        {

        }
    }
}
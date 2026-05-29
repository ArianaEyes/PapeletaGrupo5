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
    public partial class InfractorMan02 : Form
    {
        public string Codigo = "";

        public InfractorMan03 Formulario;

        public InfractorMan02()
        {
            InitializeComponent();

            Load += InfractorMan02_Load;

            cboDepartamento.SelectedIndexChanged += cboDepartamento_SelectedIndexChanged;
            cboProvincia.SelectedIndexChanged += cboProvincia_SelectedIndexChanged;
        }

        private void InfractorMan02_Load(object sender, EventArgs e)
        {
            try
            {
                InfractorADO objADO = new InfractorADO();

                cboTipoBrevete.DataSource = objADO.ListarTiposBrevete();
                cboTipoBrevete.DisplayMember = "TIPO_BREVETE";

                InfractorBE objBE = objADO.ConsultarInfractor(Codigo);

                if (objBE == null)
                {
                    MessageBox.Show("No existe el infractor");
                    this.Close();
                    return;
                }

                lblCodigo.Text = objBE.COD_INFRACTOR;
                txtNombres.Text = objBE.NOMBRES;
                txtApePaterno.Text = objBE.APE_PATERNO;
                txtApeMaterno.Text = objBE.APE_MATERNO;
                txtDNI.Text = objBE.DNI;
                txtCorreo.Text = objBE.CORREO;
                txtDireccion.Text = objBE.DIRECCION;
                txtNroBrevete.Text = objBE.NRO_BREVETE;
                cboTipoBrevete.Text = objBE.TIPO_BREVETE;

                dtpFecNacimiento.Value =
                    (objBE.FEC_NACIMIENTO > dtpFecNacimiento.MinDate)
                    ? objBE.FEC_NACIMIENTO
                    : DateTime.Today;

                optMasculino.Checked = (objBE.SEXO == "M");
                optFemenino.Checked = (objBE.SEXO == "F");

                if (objBE.FOTO != null)
                {
                    MemoryStream ms = new MemoryStream(objBE.FOTO);
                    pcbFoto.Image = Image.FromStream(ms);
                }

                DataRow ubigeo = objADO.ObtenerUbigeo(objBE.COD_UBIGEO);

                if (ubigeo != null)
                {
                    cboDepartamento.DataSource = objADO.ListarDepartamentos();
                    cboDepartamento.DisplayMember = "DEPARTAMENTO";
                    cboDepartamento.Text = ubigeo["DEPARTAMENTO"].ToString();

                    cboProvincia.DataSource = objADO.ListarProvincias(ubigeo["DEPARTAMENTO"].ToString());
                    cboProvincia.DisplayMember = "PROVINCIA";
                    cboProvincia.Text = ubigeo["PROVINCIA"].ToString();

                    cboDistrito.DataSource = objADO.ListarDistritos(ubigeo["PROVINCIA"].ToString());
                    cboDistrito.DisplayMember = "DISTRITO";
                    cboDistrito.ValueMember = "COD_UBIGEO";
                    cboDistrito.SelectedValue = objBE.COD_UBIGEO;
                }
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
                InfractorADO objADO = new InfractorADO();

                cboProvincia.DataSource =
                    objADO.ListarProvincias(cboDepartamento.Text);

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
                InfractorADO objADO = new InfractorADO();

                cboDistrito.DataSource =
                    objADO.ListarDistritos(cboProvincia.Text);

                cboDistrito.DisplayMember = "DISTRITO";
                cboDistrito.ValueMember = "COD_UBIGEO";
            }
            catch
            {

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                InfractorBE objBE = new InfractorBE();

                objBE.COD_INFRACTOR = Codigo;

                objBE.NOMBRES = txtNombres.Text;
                objBE.APE_PATERNO = txtApePaterno.Text;
                objBE.APE_MATERNO = txtApeMaterno.Text;
                objBE.DNI = txtDNI.Text;
                objBE.CORREO = txtCorreo.Text;
                objBE.DIRECCION = txtDireccion.Text;
                objBE.COD_UBIGEO = cboDistrito.SelectedValue.ToString();
                objBE.NRO_BREVETE = txtNroBrevete.Text;
                objBE.TIPO_BREVETE = cboTipoBrevete.Text;
                objBE.USU_ULT_MODIFICACION = "ADMIN";

                objBE.FEC_NACIMIENTO = dtpFecNacimiento.Value;

                objBE.SEXO = optMasculino.Checked ? "M" : "F";


                if (pcbFoto.Image != null)
                {
                    MemoryStream ms = new MemoryStream();

                    pcbFoto.Image.Save(ms,
                    System.Drawing.Imaging.ImageFormat.Jpeg);

                    objBE.FOTO = ms.ToArray();
                }

                InfractorBL bl = new InfractorBL();
                objBE.NRO_BREVETE = txtNroBrevete.Text;
                if (bl.ActualizarInfractor(objBE))
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void lblCodigo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void InfractorMan02_Load_1(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();

                ofd.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pcbFoto.Image = Image.FromFile(ofd.FileName);

                    pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
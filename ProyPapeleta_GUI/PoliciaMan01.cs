using ProyPapeletaADO;
using ProyPapeletaBE;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ProyPapeleta_GUI;

namespace ProyPapeleta_GUI
{
    public partial class PoliciaMan01 : Form
    {
        public PoliciaMan05 Formulario;
        public PoliciaMan01()
        {
            InitializeComponent();

            Load += PoliciaMan01_Load;

            cboDepartamento.SelectedIndexChanged += cboDepartamento_SelectedIndexChanged;
            cboProvincia.SelectedIndexChanged += cboProvincia_SelectedIndexChanged;
        }

        private void PoliciaMan01_Load(object sender, EventArgs e)
        {

            try
            {

                PoliciaADO objPoliciaADO = new PoliciaADO();
                cboRango.SelectedIndex = 0;
                cboDepartamento.DataSource = objPoliciaADO.ListarDepartamentos();
                cboDepartamento.DisplayMember = "DEPARTAMENTO";
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
                PoliciaADO objPoliciaADO = new PoliciaADO();

                cboProvincia.DataSource =
                    objPoliciaADO.ListarProvincias(cboDepartamento.Text);

                cboProvincia.DisplayMember = "PROVINCIA";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PoliciaADO objPoliciaADO = new PoliciaADO();

                cboDistrito.DataSource = objPoliciaADO.ListarDistritos(cboProvincia.Text);



                cboDistrito.DisplayMember = "DISTRITO";
                cboDistrito.ValueMember = "COD_UBIGEO";
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private bool ValidarCampos()
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese nombres");
                txtNombre.Focus();
                return false;
            }

            if (txtApellidoPaterno.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese apellido paterno");
                txtApellidoPaterno.Focus();
                return false;
            }

            if (txtApellidoMaterno.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese apellido materno");
                txtApellidoMaterno.Focus();
                return false;
            }

            if (txtDNI.Text.Trim().Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 dígitos");
                txtDNI.Focus();
                return false;
            }

            if (cboRango.SelectedIndex <= 0)
            {
                MessageBox.Show("Seleccione Rango");
                cboRango.Focus();
                return false;
            }

            if (cboDistrito.SelectedValue == null)
            {
                MessageBox.Show("Seleccione distrito");
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

        }


        private void grpDatosPolicia_Enter(object sender, EventArgs e)
        {

        }

        private void cboRango_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertarPoli_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;
                PoliciaBE objPoliciaBE = new PoliciaBE();

                objPoliciaBE.NOMBRE = txtNombre.Text;
                objPoliciaBE.PATERNO = txtApellidoPaterno.Text;
                objPoliciaBE.MATERNO = txtApellidoMaterno.Text;
                objPoliciaBE.DNI = txtDNI.Text;
                objPoliciaBE.ESTADO = "A";
                objPoliciaBE.GRADO = cboRango.Text;
                objPoliciaBE.COD_UBIGEO = cboDistrito.SelectedValue.ToString();

                if (optMasculino.Checked == true)
                {
                    objPoliciaBE.SEXO = "M";
                }
                else
                {
                    objPoliciaBE.SEXO = "F";
                }

                objPoliciaBE.FECHANACIMIENTO = dtpFechaNacimiento.Value;
                objPoliciaBE.USU_REGISTRO = "ADMIN";

                if (pcbFoto.Image != null)
                {
                    MemoryStream ms = new MemoryStream();

                    pcbFoto.Image.Save(ms,
                    System.Drawing.Imaging.ImageFormat.Jpeg);

                    objPoliciaBE.FOTO = ms.ToArray();
                }

                PoliciaADO objPoliciaADO = new PoliciaADO();

                if (objPoliciaADO.InsertarPolicia(objPoliciaBE))
                {
                    MessageBox.Show(
                        "Policia registrado correctamente");

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

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pcbFoto.Image = Image.FromFile(ofd.FileName);
                pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

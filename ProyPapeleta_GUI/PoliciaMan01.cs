using ProyPapeleta_GUI;
using ProyPapeletaADO;
using ProyPapeletaBE;
using ProyPapeletaBL;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyPapeleta_GUI
{
    public partial class PoliciaMan01 : Form
    {
        PoliciaBL objPoliciaBL = new PoliciaBL();
        public PoliciaMan03 Formulario;
        ErrorProvider errorProvider1 = new ErrorProvider();

        //Validar componentes
        public PoliciaMan01()
        {
            InitializeComponent();

            Load += PoliciaMan01_Load;

            cboDepartamento.SelectedIndexChanged += cboDepartamento_SelectedIndexChanged;
            cboProvincia.SelectedIndexChanged += cboProvincia_SelectedIndexChanged;

            txtNombre.Validating += txtNombre_Validating;
            txtApellidoPaterno.Validating += txtApellidoPaterno_Validating;
            txtApellidoMaterno.Validating += txtApellidoMaterno_Validating;
            txtDNI.Validating += txtDNI_Validating;

            txtDNI.KeyPress += txtDNI_KeyPress;

            txtDNI.MaxLength = 8;
        }
        //Validar componentes
        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNombre,
                    "Ingrese nombres");


            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }
        }

        private void txtApellidoPaterno_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellidoPaterno.Text.Trim() == "")
            {
                errorProvider1.SetError(txtApellidoPaterno,
                    "Ingrese apellido paterno");

            }
            else
            {
                errorProvider1.SetError(txtApellidoPaterno, "");
            }
        }

        private void txtApellidoMaterno_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellidoMaterno.Text.Trim() == "")
            {
                errorProvider1.SetError(txtApellidoMaterno,
                    "Ingrese apellido materno");

            }
            else
            {
                errorProvider1.SetError(txtApellidoMaterno, "");
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                MessageBox.Show(
                    "Solo se permiten números");

                e.Handled = true;
            }
        }

        private void txtDNI_Validating(object sender, CancelEventArgs e)
        {
            if (txtDNI.Text.Trim() == "")
            {
                errorProvider1.SetError(txtDNI,
                    "Ingrese DNI");

            }
            else if (txtDNI.Text.Length != 8)
            {
                errorProvider1.SetError(txtDNI,
                    "El DNI debe tener 8 dígitos");

            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                MessageBox.Show(
                    "Solo se permiten letras");

                e.Handled = true;
            }
        }

        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                MessageBox.Show(
                    "Solo se permiten letras");

                e.Handled = true;
            }
        }

        private void txtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                MessageBox.Show(
                    "Solo se permiten letras");

                e.Handled = true;
            }
        }

        private void PoliciaMan01_Load(object sender, EventArgs e)
        {

            try
            {

                PoliciaADO objPoliciaADO = new PoliciaADO();
                cboRango.SelectedIndex = 0;
                cboDepartamento.DataSource = objPoliciaADO.ListarDepartamentos();
                cboDepartamento.DisplayMember = "DEPARTAMENTO";

                cboRango.DataSource = objPoliciaBL.ListarRango();

                cboRango.DisplayMember = "NOM_RANGO";
                cboRango.ValueMember = "COD_RANGO";
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
                objPoliciaBE.COD_RANGO = Convert.ToInt32(cboRango.SelectedValue);
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
                    Formulario?.RefrescarGrid();
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

        private void pcbFoto_Click(object sender, EventArgs e)
        {

        }

        private void pcbFoto_Click_1(object sender, EventArgs e)
        {

        }
    }
}

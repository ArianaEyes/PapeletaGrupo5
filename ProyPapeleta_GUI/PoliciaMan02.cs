using ProyPapeletaADO;
using ProyPapeletaBE;
using ProyPapeletaBL;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyPapeleta_GUI
{
    public partial class PoliciaMan02 : Form
    {
        public string Codigo = "";
        public PoliciaMan03 Formulario;
        ErrorProvider errorProvider1 = new ErrorProvider();

        //Validaciones
        public PoliciaMan02()
        {
            InitializeComponent();

            Load += PoliciaMan02_Load;

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

        private void grpDatosPolicia_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void PoliciaMan02_Load(object sender, EventArgs e)
        {
            try
            {
                PoliciaADO objPoliciaADO = new PoliciaADO();

                PoliciaBE objPoliciaBE = objPoliciaADO.ConsultarPolicia(Codigo);

                if (objPoliciaBE == null)
                {
                    MessageBox.Show("No existe el policia");
                    this.Close();
                    return;
                }

                lblCodigo.Text = objPoliciaBE.COD_POLICIA;
                txtNombre.Text = objPoliciaBE.NOMBRE;
                txtApellidoPaterno.Text = objPoliciaBE.PATERNO;
                txtApellidoMaterno.Text = objPoliciaBE.MATERNO;
                txtDNI.Text = objPoliciaBE.DNI;
                chkActivo.Checked = (objPoliciaBE.ESTADO == "A");

                dtpFechaNacimiento.Value = (objPoliciaBE.FECHANACIMIENTO > dtpFechaNacimiento.MinDate)
                    ? objPoliciaBE.FECHANACIMIENTO
                    : DateTime.Today;

                optMasculino.Checked = (objPoliciaBE.SEXO == "M" || objPoliciaBE.SEXO == "MASCULINO");
                optFemenino.Checked = (objPoliciaBE.SEXO == "F" || objPoliciaBE.SEXO == "FEMENINO");

                cboRango.DataSource = objPoliciaADO.ListarRango();
                cboRango.DisplayMember = "NOM_RANGO";
                cboRango.ValueMember = "COD_RANGO";

                if (objPoliciaBE.FOTO != null)
                {
                    MemoryStream ms = new MemoryStream(objPoliciaBE.FOTO);
                    pcbFoto.Image = Image.FromStream(ms);
                }

                // Cargar ubigeo en orden
                DataRow ubigeo = objPoliciaADO.ObtenerUbigeo(objPoliciaBE.COD_UBIGEO);

                if (ubigeo != null)
                {
                    cboDepartamento.DataSource = objPoliciaADO.ListarDepartamentos();
                    cboDepartamento.DisplayMember = "DEPARTAMENTO";
                    cboDepartamento.Text = ubigeo["DEPARTAMENTO"].ToString();

                    cboProvincia.DataSource = objPoliciaADO.ListarProvincias(ubigeo["DEPARTAMENTO"].ToString());
                    cboProvincia.DisplayMember = "PROVINCIA";
                    cboProvincia.Text = ubigeo["PROVINCIA"].ToString();

                    cboDistrito.DataSource = objPoliciaADO.ListarDistritos(ubigeo["PROVINCIA"].ToString());
                    cboDistrito.DisplayMember = "DISTRITO";
                    cboDistrito.ValueMember = "COD_UBIGEO";
                    cboDistrito.SelectedValue = objPoliciaBE.COD_UBIGEO;
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
                PoliciaADO objPoliciaADO = new PoliciaADO();

                cboProvincia.DataSource =
                    objPoliciaADO.ListarProvincias(cboDepartamento.Text);

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
                PoliciaADO objPoliciaADO = new PoliciaADO();

                cboDistrito.DataSource =
                    objPoliciaADO.ListarDistritos(cboProvincia.Text);

                cboDistrito.DisplayMember = "DISTRITO";
                cboDistrito.ValueMember = "COD_UBIGEO";
            }
            catch
            {

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
        private void lblCodigo_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }



        private void btnAgregar_Click_2(object sender, EventArgs e)
        {
            try
            {
                PoliciaBE objPoliciaBE = new PoliciaBE();

                objPoliciaBE.COD_POLICIA = Codigo;
                objPoliciaBE.NOMBRE = txtNombre.Text;
                objPoliciaBE.PATERNO = txtApellidoPaterno.Text;
                objPoliciaBE.MATERNO = txtApellidoMaterno.Text;
                objPoliciaBE.DNI = txtDNI.Text;
                objPoliciaBE.COD_UBIGEO = cboDistrito.SelectedValue.ToString();
                objPoliciaBE.FECHANACIMIENTO = dtpFechaNacimiento.Value;
                objPoliciaBE.ESTADO = chkActivo.Checked ? "A" : "I";
                objPoliciaBE.COD_RANGO = Convert.ToInt32(cboRango.SelectedValue);
                objPoliciaBE.SEXO = optMasculino.Checked ? "M" : "F";
                objPoliciaBE.USU_ULT_MODIFICACION = "ADMIN";

                if (pcbFoto.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pcbFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    objPoliciaBE.FOTO = ms.ToArray();
                }

                PoliciaBL bl = new PoliciaBL();

                if (bl.ActualizarPolicia(objPoliciaBE))
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

        private void btnCargarFoto_Click_1(object sender, EventArgs e)
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
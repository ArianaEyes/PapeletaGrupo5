using ProyPapeletaADO;
using ProyPapeletaBE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyPapeleta_GUI
{
    public partial class MultasInfractor : Form
    {
        public string CodigoInfractor = "";

        DataView dtv;
        DataTable dt;
        public MultasInfractor()
        {
            InitializeComponent();
            Load += MultasInfractor_Load;

            txtCod.KeyPress += txtCod_KeyPress_1;

            dtpFecIni.ValueChanged += (s, e) => { if (!string.IsNullOrEmpty(CodigoInfractor)) CargarMultas(); };
            dtpFecFin.ValueChanged += (s, e) => { if (!string.IsNullOrEmpty(CodigoInfractor)) CargarMultas(); };
        }
        private void MultasInfractor_Load(object sender, EventArgs e)
        {


            ConsultarDatosInfractor();
            dtpFecIni.Value = new DateTime(2025, 1, 1);
            dtpFecFin.Value = DateTime.Today;
        }
       
        private void ConsultarDatosInfractor()
        {
            try
            {
                InfractorADO objInfractorADO = new InfractorADO();


                InfractorBE objInfractorBE = objInfractorADO.ConsultarInfractor(CodigoInfractor);

                if (objInfractorBE == null)
                {
                    MessageBox.Show("No se encontraron los datos del infractor.");
                    this.Close();
                    return;
                }


                txtCod.Text = CodigoInfractor;
                lblDNI.Text = objInfractorBE.DNI;
                lblNombre.Text = objInfractorBE.NOMBRES;

                lblApellido.Text = objInfractorBE.APE_PATERNO + " " + objInfractorBE.APE_MATERNO;

                lblTipoBrevete.Text = objInfractorBE.TIPO_BREVETE;
                lblNumBrevete.Text = objInfractorBE.NRO_BREVETE;
                lblCorreo.Text = objInfractorBE.CORREO;


                lblEstado.Text = objInfractorBE.ESTADO;

                BloquearCamposConsulta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del infractor: " + ex.Message);
            }
        }
        private void BloquearCamposConsulta()
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void CargarMultas()
        {
            if (string.IsNullOrEmpty(CodigoInfractor)) return;
            try
            {
                InfractorADO objADO = new InfractorADO();
                dtgMultas.DataSource = null;

                dt = objADO.ListarMultasPorInfractor(CodigoInfractor, dtpFecIni.Value, dtpFecFin.Value);

                dtv = new DataView(dt);
                dtgMultas.DataSource = dtv;

                FormatearGrid();
                MostrarCantidadRegistros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las multas: " + ex.Message);
            }
        }

        private void MostrarCantidadRegistros()
        {

            lblRegistros.Text = dtgMultas.Rows.Count.ToString();
        }

        private void FormatearGrid()
        {
            if (dtgMultas.Columns.Count > 0)
            {
                dtgMultas.AllowUserToAddRows = false;
                dtgMultas.AllowUserToDeleteRows = false;
                dtgMultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgMultas.RowHeadersVisible = false;
                dtgMultas.ReadOnly = true;
                dtgMultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dtgMultas.Columns["COD_PAPELETA"].HeaderText = "Cód. Papeleta";
                dtgMultas.Columns["COD_PAPELETA"].Width = 80;

                dtgMultas.Columns["ESTADO_PAPELETA"].HeaderText = "Estado";
                dtgMultas.Columns["LUGAR_INFRACCION"].HeaderText = "Lugar";
                dtgMultas.Columns["FALTA_COMETIDA"].HeaderText = "Falta";
                dtgMultas.Columns["CALIFICACION"].HeaderText = "Calificación";
                dtgMultas.Columns["UIT"].HeaderText = "Monto (UIT)";
                dtgMultas.Columns["FECHA_INFRACCION"].HeaderText = "Fecha";
                dtgMultas.Columns["POLICIA"].HeaderText = "Policía a cargo";

                dtgMultas.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            }
        }

        private void txtCod_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 'I' && e.KeyChar != 'i')
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                string codigo = txtCod.Text.Trim().ToUpper();

                if (codigo.Length != 5 || !codigo.StartsWith("I") || !int.TryParse(codigo.Substring(1), out _))
                {
                    MessageBox.Show("El formato debe ser 'I' seguido de 4 números (ej. I0001).",
                                    "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                CodigoInfractor = codigo;
                ConsultarDatosInfractor();
                CargarMultas();
            }
    }
}
}
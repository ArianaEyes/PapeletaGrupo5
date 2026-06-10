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
    public partial class PoliciaMan03 : Form
    {
        PoliciaBE objPoliciaBE = new PoliciaBE();
        PoliciaBL objPoliciaBL = new PoliciaBL();
        DataView dtv;
        DataTable dt;

        public PoliciaMan03()
        {
            InitializeComponent();
        }
        private void CargarDatos(string strFiltro)
        {
            try
            {
                if (dtv == null)
                {
                    dtv = new DataView(objPoliciaBL.ListarPolicia());
                }

                dtv.RowFilter = $"COD_POLICIA LIKE '%{strFiltro}%'";

                dtgPolicia.DataSource = dtv;

                lblRegistros.Text = dtv.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar los datos: " + ex.Message);
            }
        }
        private void PoliciaMan05_Load(object sender, EventArgs e)
        {
            try
            {
                CargarPolicias();
                FormatearGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarPolicias()
        {
            try
            {
                PoliciaADO objADO = new PoliciaADO();

                DataTable dt = objADO.ListarPolicia();

                dtv = new DataView(dt);
                dtgPolicia.DataSource = dtv;

                MostrarCantidadRegistros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void MostrarCantidadRegistros()
        {
            lblRegistros.Text = dtgPolicia.Rows.Count.ToString();
        }
        private void FormatearGrid()
        {
            if (dtgPolicia.Columns.Count > 0)
            {
                dtgPolicia.AllowUserToAddRows = false;
                dtgPolicia.AllowUserToDeleteRows = false;
                dtgPolicia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgPolicia.RowHeadersVisible = false;
                dtgPolicia.ReadOnly = true;
                dtgPolicia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dtgPolicia.Columns["COD_POLICIA"].HeaderText = "Código";
                dtgPolicia.Columns["COD_POLICIA"].Width = 70;
                dtgPolicia.Columns["PATERNO"].HeaderText = "Apellido Paterno";
                dtgPolicia.Columns["MATERNO"].HeaderText = "Apellido Materno";
                dtgPolicia.Columns["NOMBRE"].HeaderText = "Nombres";
                dtgPolicia.Columns["DNI"].HeaderText = "DNI";
                dtgPolicia.Columns["SEXO"].HeaderText = "Sexo";
                dtgPolicia.Columns["COD_UBIGEO"].HeaderText = "Cód. Ubigeo";
                dtgPolicia.Columns["DEPARTAMENTO"].HeaderText = "Departamento";
                dtgPolicia.Columns["PROVINCIA"].HeaderText = "Provincia";
                dtgPolicia.Columns["DISTRITO"].HeaderText = "Distrito";

                // ocultar lo que no se necesita
                if (dtgPolicia.Columns.Contains("FECHANACIMIENTO")) dtgPolicia.Columns["FECHANACIMIENTO"].Visible = false;
                if (dtgPolicia.Columns.Contains("ESTADO")) dtgPolicia.Columns["ESTADO"].Visible = false;
                if (dtgPolicia.Columns.Contains("FOTO")) dtgPolicia.Columns["FOTO"].Visible = false;

                dtgPolicia.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //PoliciaMan02 frm = new PoliciaMan02();
            //frm.Formulario = this;
            //frm.Show();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is PoliciaMan01)
                {
                    f.BringToFront();
                    return;
                }
            }
            PoliciaMan01 frm = new PoliciaMan01();
            frm.Formulario = this;
            frm.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgPolicia.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Seleccione un policia.");
                    return;
                }

                string codigo =
                    dtgPolicia.CurrentRow
                    .Cells["COD_POLICIA"]
                    .Value.ToString();

                DialogResult r =
                    MessageBox.Show(
                        "¿Desea desactivar este policia?",
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    InfractorADO objADO =
                        new InfractorADO();

                    if (new PoliciaADO().EliminarPolicia(codigo))
                    {
                        MessageBox.Show(
                            "Policía desactivado correctamente.");

                        CargarPolicias();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtFiltrooo.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgPolicia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                string codigo = dtgPolicia
                    .Rows[e.RowIndex]
                    .Cells["COD_POLICIA"]
                    .Value
                    .ToString();

                PoliciaMan02 frm = new PoliciaMan02();

                frm.Codigo = codigo;

                frm.ShowDialog();

                CargarPolicias();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtFiltrooo_TextChanged(object sender, EventArgs e)
        {
            if (dtv != null)
            {
                dtv.RowFilter = $"PATERNO LIKE '%{txtFiltrooo.Text.Trim()}%'";
                MostrarCantidadRegistros();
            }
        }
    }
}

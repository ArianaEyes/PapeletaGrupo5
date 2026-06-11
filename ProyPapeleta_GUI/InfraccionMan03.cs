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
    public partial class InfraccionMan03 : Form
    {
        InfraccionBE objInfraccionBE = new InfraccionBE();
        InfraccionBL objInfraccionBL = new InfraccionBL();
        DataView dtv;
        public InfraccionMan03()
        {
            InitializeComponent();
            Load += InfraccionMan03_Load;
        }
        private void CargarDatos(string strFiltro)
        {
            try
            {
                // Solo consultamos la base de datos si el dtv no ha sido cargado aún
                if (dtv == null)
                {
                    // Se construye el DataView con el datatable del método ListarInfraccion
                    dtv = new DataView(objInfraccionBL.ListarInfraccion());
                    dtgInfraccion.DataSource = dtv; // asignar ANTES de formatear
                    FormatearGrid();

                }

                // Filtramos por el campo real de tu SP -> CODIGO
                dtv.RowFilter = $"DESCRIPCION_SANCION LIKE '%{strFiltro}%'";
                // Enlazamos el dataGridView al dtv
                dtgInfraccion.DataSource = dtv;

                // Contamos los registros directamente desde el DataView y lo mostramos
                lblRegistros.Text = dtv.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar los datos: " + ex.Message);
            }
        }
        private void MostrarCantidadRegistros()
        {
            lblRegistros.Text = dtgInfraccion.Rows.Count.ToString();
        }
        private void CargarInfraccion()
        {
            try
            {
                InfraccionADO objADO = new InfraccionADO();

                DataTable dt = objADO.ListarInfraccion();

                dtgInfraccion.DataSource = dt;

                MostrarCantidadRegistros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void InfraccionMan05_Load(object sender, EventArgs e)
        {

            try
            {
                // Invocamos al método para cargar los datos de arranque
                CargarDatos("");

                // Formateamos el dataGrid
                // CargarInfraccion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void FormatearGrid()
        {
            if (dtgInfraccion.Columns.Count > 0)
            {
                // Configuraciones estéticas por defecto (Igualito a los anteriores)
                dtgInfraccion.AllowUserToAddRows = false;
                dtgInfraccion.AllowUserToDeleteRows = false;
                dtgInfraccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgInfraccion.RowHeadersVisible = false;
                dtgInfraccion.ReadOnly = true;
                dtgInfraccion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dtgInfraccion.Columns["COD_INFRACCION"].HeaderText = "Código";
                dtgInfraccion.Columns["COD_INFRACCION"].Width = 70;
                dtgInfraccion.Columns["DESCRIPCION_SANCION"].HeaderText = "Descripción de la Infracción";
                dtgInfraccion.Columns["CALIFICACION"].HeaderText = "Calificación";
                dtgInfraccion.Columns["PUNTOS"].HeaderText = "Puntos";
                dtgInfraccion.Columns["UIT"].HeaderText = "UIT (%)";
                

                if (dtgInfraccion.Columns.Contains("FEC_REGISTRO")) dtgInfraccion.Columns["FEC_REGISTRO"].Visible = false;
                if (dtgInfraccion.Columns.Contains("USU_REGISTRO")) dtgInfraccion.Columns["USU_REGISTRO"].Visible = false;
                if (dtgInfraccion.Columns.Contains("FEC_ULT_MODIFICACION")) dtgInfraccion.Columns["FEC_ULT_MODIFICACION"].Visible = false;
                if (dtgInfraccion.Columns.Contains("USU_ULT_MODIFICACION")) dtgInfraccion.Columns["USU_ULT_MODIFICACION"].Visible = false;

                //estiloxd
                dtgInfraccion.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is InfraccionMan01)
                {
                    f.BringToFront();
                    return;
                }
            }
            InfraccionMan01 frm = new InfraccionMan01();
            frm.Formulario = this;
            frm.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgInfraccion.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Seleccione una infracción.");
                    return;
                }

                string codigo =
                    dtgInfraccion.CurrentRow
                    .Cells["COD_INFRACCION"]
                    .Value.ToString();

                DialogResult r =
                    MessageBox.Show(
                        "¿Desea desactivar esta infracción?",
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    InfraccionADO objADO =
                        new InfraccionADO();

                    if (objADO.EliminarInfraccion(codigo))
                    {
                        MessageBox.Show(
                            "Infracción desactivada correctamente.");

                        CargarInfraccion();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgInfraccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                string codigo =
                    dtgInfraccion.Rows[e.RowIndex].Cells["COD_INFRACCION"].Value.ToString();

                dtgInfraccion.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

                InfraccionMan02 frm = new InfraccionMan02();

                frm.Codigo = codigo;

                frm.ShowDialog();
                CargarInfraccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtFiltro.Text = ""; // Limpia el cuadro de texto
            dtv = null;          // Fuerza a traer los datos limpios de la BD
            CargarDatos("");     // Vuelve a cargar todo
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(txtFiltro.Text.Trim());
        }
    }
}

    


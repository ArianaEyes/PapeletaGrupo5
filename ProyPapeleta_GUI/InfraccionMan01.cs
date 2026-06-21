using Microsoft.Data.SqlClient;
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
    public partial class InfraccionMan01 : Form

    {

        public InfraccionMan03 Formulario;

        string[] calificacion = {
                "--Seleccionar--",
                "LEVE",
                "GRAVE",
                "MUY GRAVE"     };

        string[] medida_preventiva = {
                "--Seleccionar--",
                "Multa",
                "Retención",
                "Internamiento"     };


        public InfraccionMan01()
        {
            InitializeComponent();
            Load += InfraccionMan01_Load;

        }



        private void InfraccionMan01_Load(object sender, EventArgs e)
        {
            cboCalificacion.DataSource = calificacion;
            cboMedida.DataSource = medida_preventiva;
        }

        private bool ValidarDatos()
        {
            if (txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese descripción");
                txtDescripcion.Focus();
                return false;
            }

            if (cboCalificacion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione alguna calificación");
                cboCalificacion.Focus();
                return false;
            }
            return true;

        }

        private void btnAgregarInfraccion_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarDatos())
                    return;

                InfraccionBE objInfraccionBE = new InfraccionBE();

                objInfraccionBE.DESCRIPCION_SANCION = txtDescripcion.Text;
                objInfraccionBE.CALIFICACION = cboCalificacion.Text;
                objInfraccionBE.PUNTOS = (int)nudPuntos.Value;
                objInfraccionBE.UIT = nudUIT.Value;
                objInfraccionBE.ESTADO = "A";
                objInfraccionBE.MEDIDA_PREVENTIVA = cboMedida.Text;
                objInfraccionBE.USU_REGISTRO = "ADMIN";

                InfraccionADO objInfraccionADO = new InfraccionADO();


                if (objInfraccionADO.InsertarInfraccion(objInfraccionBE))
                {
                    MessageBox.Show(
                        "Infraccion registrado correctamente");
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

        private void cboCalificacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpDatosPolicia_Enter(object sender, EventArgs e)
        {

        }
    }
}

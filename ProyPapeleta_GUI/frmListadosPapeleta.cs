using OfficeOpenXml;
using ProyPapeletaBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProyPapeleta_GUI
{
    public partial class frmListadosPapeleta : Form
    {
        public frmListadosPapeleta()
        {
            InitializeComponent();
        }

        private void frmListadosPapeleta_Load(object sender, EventArgs e)
        {
            MostrarControles(false);
            ExcelPackage.License.SetNonCommercialOrganization("ISIL");
        }

        private void MostrarControles(Boolean mostrar)
        {
            pcdImagen.Visible = mostrar;
            lblMensaje.Visible = mostrar;
            prgBar.Visible = mostrar;
        }

        private void btnListarPolicias_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarControles(true);
                PoliciaBL objPoliciaBL = new PoliciaBL();
                DataTable dt = objPoliciaBL.ListarPolicia();
                Int16 fila = 5;

                ExcelPackage.License.SetNonCommercialOrganization("ISIL");
                String rutaarchivo = @"C:\MisExcel\ListadoPolicias.xlsx";
                using var pck = new ExcelPackage(new FileInfo(rutaarchivo));
                ExcelWorksheet ws = pck.Workbook.Worksheets["Hoja1"];

                ws.Cells[4, 1].Value = "Código";
                ws.Cells[4, 2].Value = "Nombre";
                ws.Cells[4, 3].Value = "Apellido Paterno";
                ws.Cells[4, 4].Value = "Apellido Materno";
                ws.Cells[4, 5].Value = "DNI";
                ws.Cells[4, 6].Value = "Fecha de Nacimiento";
                ws.Cells[4, 7].Value = "Rango";
                ws.Cells[4, 8].Value = "Estado";
                ws.Cells[4, 9].Value = "Ubicación";

                foreach (DataRow dr in dt.Rows)
                {
                    ws.Cells[fila, 1].Value = dr["COD_POLICIA"].ToString();
                    ws.Cells[fila, 2].Value = dr["NOMBRE"].ToString();
                    ws.Cells[fila, 3].Value = dr["PATERNO"].ToString();
                    ws.Cells[fila, 4].Value = dr["MATERNO"].ToString();
                    ws.Cells[fila, 5].Value = dr["DNI"].ToString();
                    ws.Cells[fila, 6].Value = dr["FECHANACIMIENTO"].ToString();
                    ws.Cells[fila, 7].Value = dr["RANGO"].ToString();
                    ws.Cells[fila, 8].Value = dr["ESTADO"].ToString();
                    ws.Cells[fila, 9].Value = dr["DEPARTAMENTO"].ToString() + "-" + dr["PROVINCIA"].ToString() + "-" + dr["DISTRITO"].ToString();
                    fila++;
                }

                String filename = "ListadoPolicias_" + clsCredenciales.Usuario + ".xlsx";
                FileStream fs = new FileStream(@"C:\MisExcel\" + filename, FileMode.Create);
                pck.SaveAs(fs);
                fs.Dispose();

                MessageBox.Show("Archivo " + filename + " generado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarControles(false);
            }
            catch (Exception ex)
            {
                MostrarControles(false);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnListarInfractores_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarControles(true);
                InfractorBL objInfractorBL = new InfractorBL();
                DataTable dt = objInfractorBL.ListarInfractores();
                Int16 fila = 5;

                ExcelPackage.License.SetNonCommercialOrganization("ISIL");
                String rutaarchivo = @"C:\MisExcel\ListadoInfractores.xlsx";
                using var pck = new ExcelPackage(new FileInfo(rutaarchivo));
                ExcelWorksheet ws = pck.Workbook.Worksheets["Hoja1"];

                ws.Cells[4, 1].Value = "Código";
                ws.Cells[4, 2].Value = "Nombres";
                ws.Cells[4, 3].Value = "Apellido Paterno";
                ws.Cells[4, 4].Value = "Apellido Materno";
                ws.Cells[4, 5].Value = "Email";
                ws.Cells[4, 6].Value = "DNI";
                ws.Cells[4, 7].Value = "Fecha de Nacimiento";
                ws.Cells[4, 8].Value = "Nro Brevete";
                ws.Cells[4, 9].Value = "Tipo Brevete";
                ws.Cells[4, 10].Value = "Ubicación";


                foreach (DataRow dr in dt.Rows)
                {
                    ws.Cells[fila, 1].Value = dr["COD_INFRACTOR"].ToString();
                    ws.Cells[fila, 2].Value = dr["NOMBRES"].ToString();
                    ws.Cells[fila, 3].Value = dr["APE_PATERNO"].ToString();
                    ws.Cells[fila, 4].Value = dr["APE_MATERNO"].ToString();
                    ws.Cells[fila, 5].Value = dr["CORREO"].ToString();
                    ws.Cells[fila, 6].Value = dr["DNI"].ToString();
                    ws.Cells[fila, 7].Value = dr["FEC_NACIMIENTO"].ToString();
                    ws.Cells[fila, 8].Value = dr["NRO_BREVETE"].ToString();
                    ws.Cells[fila, 9].Value = dr["TIPO_BREVETE"].ToString();
                    ws.Cells[fila, 10].Value = dr["DEPARTAMENTO"].ToString() + "-" + dr["PROVINCIA"].ToString() + "-" + dr["DISTRITO"].ToString();

                    fila++;
                }

                String filename = "ListadoInfractores_" + clsCredenciales.Usuario + ".xlsx";
                FileStream fs = new FileStream(@"C:\MisExcel\" + filename, FileMode.Create);
                pck.SaveAs(fs);
                fs.Dispose();

                MessageBox.Show("Archivo " + filename + " generado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarControles(false);
            }
            catch (Exception ex)
            {
                MostrarControles(false);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnListarInfracciones_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarControles(true);
                bkgDatos.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MostrarControles(false);
                MessageBox.Show(ex.Message);
            }
        }

        private void bkgDatos_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                InfraccionBL objInfraccionBL = new InfraccionBL();
                DataTable dt = objInfraccionBL.ListarInfraccion();

                for (int i = 0; i < 500; i++)
                {
                    bkgDatos.ReportProgress(i / 5);
                    Thread.Sleep(5);
                }

                e.Result = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bkgDatos_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prgBar.Value = e.ProgressPercentage;
        }

        private void bkgDatos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)e.Result;
                Int16 fila = 5;

                ExcelPackage.License.SetNonCommercialOrganization("ISIL");
                String rutaarchivo = @"C:\MisExcel\ListadoInfracciones.xlsx";
                using var pck = new ExcelPackage(new FileInfo(rutaarchivo));
                ExcelWorksheet ws = pck.Workbook.Worksheets["Hoja1"];

                foreach (DataRow dr in dt.Rows)
                {
                    ws.Cells[fila, 1].Value = dr["COD_INFRACCION"].ToString();
                    ws.Cells[fila, 2].Value = dr["DESCRIPCION_SANCION"].ToString();
                    ws.Cells[fila, 3].Value = dr["CALIFICACION"].ToString();
                    ws.Cells[fila, 4].Value = dr["PUNTOS"].ToString();
                    ws.Cells[fila, 5].Value = dr["UIT"].ToString();
                    fila++;
                }

                ws.Column(1).Width = 15;
                ws.Column(2).Width = 50;
                ws.Column(3).Width = 20;
                ws.Column(4).Width = 15;
                ws.Column(5).Width = 15;

                String filename = "ListadoInfracciones_" + clsCredenciales.Usuario + ".xlsx";
                FileStream fs = new FileStream(@"C:\MisExcel\" + filename, FileMode.Create);
                pck.SaveAs(fs);
                fs.Dispose();

                MessageBox.Show("Archivo " + filename + " generado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarControles(false);
            }
            catch (Exception ex)
            {
                MostrarControles(false);
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

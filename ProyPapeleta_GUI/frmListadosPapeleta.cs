using OfficeOpenXml;
using OfficeOpenXml.Style;
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
        private string rutaGuardarInfracciones;

        public frmListadosPapeleta()
        {
            InitializeComponent();
        }

        private void frmListadosPapeleta_Load(object sender, EventArgs e)
        {
            MostrarControles(false);
        }

        private void MostrarControles(Boolean mostrar)
        {
            pcdImagen.Visible = mostrar;
            lblMensaje.Visible = mostrar;
            prgBar.Visible = mostrar;
        }

        private string ElegirRutaGuardado (string nombreSugerido)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivos de Excel (*.xlsx)|*.xlsx*";
                sfd.FileName = nombreSugerido;
                sfd.Title = "Guardar listado como";

                return sfd.ShowDialog() == DialogResult.OK ? sfd.FileName : null;
            }
        }

        private void CrearEncabezado(ExcelWorksheet ws, string titulo, int colMergeIni, int colMergeFin, float fontSizeTitulo, float altoFilaTitulo, string[] headers, Dictionary<int, double> anchosColumna) {
            ws.Cells[1, colMergeIni, 1, colMergeFin].Merge = true;
            ws.Cells[1, colMergeIni].Value = titulo;
            ws.Cells[1, colMergeIni].Style.Font.Bold = true;
            ws.Cells[1, colMergeIni].Style.Font.Size = fontSizeTitulo;
            ws.Cells[1, colMergeIni].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            ws.Row(1).Height = altoFilaTitulo;

            ws.Cells[2, colMergeIni].Value = "Fecha:";
            ws.Cells[2, colMergeIni].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
            ws.Cells[2, colMergeIni + 1].Formula = "NOW()";
            ws.Cells[2, colMergeIni + 1].Style.Numberformat.Format = "m/d/yy h:mm";

            for (int i = 0; i < headers.Length; i++)
            {
                var celda = ws.Cells[4, i + 1];
                celda.Value = headers[i];
                celda.Style.Font.Bold = true;
                celda.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                celda.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            }

            foreach (var kvp in anchosColumna)
            {
                ws.Column(kvp.Key).Width = kvp.Value;
            }
        }

        private void btnListarPolicias_Click(object sender, EventArgs e)
        {
            try
            {
                String nombreSugerido = "ListadoPolicias_" + clsCredenciales.Usuario + ".xlsx";
                string ruta = ElegirRutaGuardado(nombreSugerido);
                if (ruta == null) return;

                MostrarControles(true);

                PoliciaBL objPoliciaBL = new PoliciaBL();
                DataTable dt = objPoliciaBL.ListarPolicia();
                Int16 fila = 5;

                using var pck = new ExcelPackage();
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Hoja1");

                CrearEncabezado(ws, "LISTADO DE POLICIAS", 4, 5, 20f, 26.25f,
                    new[] { "Código", "Nombre", "Apellido Paterno", "Apellido Materno", "DNI", "Fecha de Nacimiento", "Rango", "Estado", "Ubicación" },
                    new Dictionary<int, double> { { 1, 14.14 }, { 2, 22.71 }, { 5, 19.29 }, { 6, 28.14 }, { 7, 24.43 }, { 8, 14.86 }, { 9, 34.29 } });

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

                pck.SaveAs(new FileInfo(ruta));

                MessageBox.Show("Archivo generado con éxito en:\n" + ruta, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                String nombreSugerido = "ListadoInfractores_" + clsCredenciales.Usuario + ".xlsx";
                string ruta = ElegirRutaGuardado(nombreSugerido);
                if (ruta == null) return;

                MostrarControles(true);

                InfractorBL objInfractorBL = new InfractorBL();
                DataTable dt = objInfractorBL.ListarInfractores();
                Int16 fila = 5;

                using var pck = new ExcelPackage();
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Hoja1");

                CrearEncabezado(ws, "LISTADO DE INFRACTORES", 5, 6, 16f, 21f,
                    new[] { "Código", "Nombres", "Apellido Paterno", "Apellido Materno", "Email", "DNI", "Fecha de Nacimiento", "Nro Brevete", "Tipo Brevete", "Ubicación" },
                    new Dictionary<int, double> { { 1, 12.43 }, { 2, 22.71 }, { 5, 32.86 }, { 6, 19.71 }, { 7, 26.29 }, { 8, 18.57 }, { 9, 14.0 }, { 10, 37.29 } });

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

                pck.SaveAs(new FileInfo(ruta));

                MessageBox.Show("Archivo generado con éxito en:\n" + ruta, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                String nombreSugerido = "ListadoInfracciones_" + clsCredenciales.Usuario + ".xlsx";
                rutaGuardarInfracciones = ElegirRutaGuardado(nombreSugerido);
                if (rutaGuardarInfracciones == null) return;

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

                using var pck = new ExcelPackage();
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Hoja1");

                CrearEncabezado(ws, "LISTADO DE INFRACCIONES", 3, 4, 20f, 26.25f,
                    new[] { "Código", "Descripción Sanción", "Calificación", "Puntos", "UIT" },
                    new Dictionary<int, double> { { 1, 22.71 }, { 2, 65.86 }, { 3, 47.71 }, { 4, 38.57 }, { 5, 22.71 } });

                foreach (DataRow dr in dt.Rows)
                {
                    ws.Cells[fila, 1].Value = dr["COD_INFRACCION"].ToString();
                    ws.Cells[fila, 2].Value = dr["DESCRIPCION_SANCION"].ToString();
                    ws.Cells[fila, 3].Value = dr["CALIFICACION"].ToString();
                    ws.Cells[fila, 4].Value = dr["PUNTOS"].ToString();
                    ws.Cells[fila, 5].Value = dr["UIT"].ToString();
                    fila++;
                }

                pck.SaveAs(new FileInfo(rutaGuardarInfracciones));

                MessageBox.Show("Archivo generado con éxito en:\n" + rutaGuardarInfracciones, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

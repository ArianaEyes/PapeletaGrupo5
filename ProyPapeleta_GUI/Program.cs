using OfficeOpenXml;

namespace ProyPapeleta_GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ExcelPackage.License.SetNonCommercialOrganization("ISIL");

            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
        }
    }
}
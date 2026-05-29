using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ProyPapeletaADO
{
    public static class Configuracion
    {
        private static IConfiguration _config;

        static Configuracion()
        {
            try
            {
                // Configuramos el constructor para leer el archivo JSON
                var builder = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

                _config = builder.Build();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al inicializar la configuración: " + ex.Message);
            }
        }
        public static string PAPELETA
        {
            get
            {
                string cadena = _config.GetConnectionString("PAPELETA");

                if (string.IsNullOrEmpty(cadena))
                    throw new Exception("No se encontró la cadena 'PAPELETA' en appsettings.json");

                return cadena;
            }
        }
    }
}

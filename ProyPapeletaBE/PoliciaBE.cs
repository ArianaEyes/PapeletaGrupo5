using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyPapeletaBE
{
    public class PoliciaBE
    {
        public String COD_POLICIA { get; set; }
        public String PATERNO { get; set; }
        public String MATERNO { get; set; }
        public String NOMBRE { get; set; }
        public String DNI { get; set; }
        public String COD_UBIGEO { get; set; }
        public String GRADO { get; set; }
        public String SEXO { get; set; }
        public DateTime FECHANACIMIENTO { get; set; }
        public String ESTADO { get; set; }
        public byte[] FOTO { get; set; }
        public DateTime FEC_REGISTRO { get; set; }
        public String USU_REGISTRO { get; set; }
        public DateTime FEC_ULT_MODIFICACION { get; set; }
        public String USU_ULT_MODIFICACION { get; set; }

    }
}

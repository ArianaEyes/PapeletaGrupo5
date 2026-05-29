using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyPapeletaBE
{
    public class InfractorBE
    {
        public String COD_INFRACTOR { get; set; }
        public String DNI { get; set; }
        public String APE_PATERNO { get; set; }
        public String APE_MATERNO { get; set; }
        public String NOMBRES { get; set; }
        public String CORREO { get; set; }
        public String DIRECCION { get; set; }
        public String COD_UBIGEO { get; set; }
        public String SEXO { get; set; }
        public DateTime FEC_NACIMIENTO { get; set; }
        public byte[] FOTO { get; set; }
        public String NRO_BREVETE { get; set; }
        public String TIPO_BREVETE { get; set; }
        public DateTime FEC_REGISTRO { get; set; }
        public String USU_REGISTRO { get; set; }
        public DateTime FEC_ULT_MODIFICACION { get; set; }
        public String USU_ULT_MODIFICACION { get; set; }

    }
}
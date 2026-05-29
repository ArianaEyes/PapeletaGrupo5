using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using ProyPapeletaADO;
using ProyPapeletaBE;

namespace ProyPapeletaBL
{
    public class PoliciaBL
    {
        PoliciaADO objPoliciaADO = new PoliciaADO();

        public Boolean InsertarPolicia(PoliciaBE objPoliciaBE) 
        {
            return objPoliciaADO.InsertarPolicia(objPoliciaBE);
        }

        public Boolean ActualizarPolicia(PoliciaBE objPoliciaBE)
        {
            return objPoliciaADO.ActualizarPolicia(objPoliciaBE);
        }

        public Boolean EliminarPolicia(String strCodigo)
        {
            return objPoliciaADO.EliminarPolicia(strCodigo);
        }

        public PoliciaBE ConsultarPolicia(String strCodigo)
        {
            return objPoliciaADO.ConsultarPolicia(strCodigo);
        }

        public DataTable ListarPolicia()
        {
            return objPoliciaADO.ListarPolicia();
        }
        public DataTable ObtenerUbigeoPorPolicia(string codInfractor)
        {
            return objPoliciaADO.ObtenerUbigeoPorPolicia(codInfractor);
        }
    }
}

using System;
using System.Data;
using ProyPapeletaADO;
using ProyPapeletaBE;

namespace ProyPapeletaBL
{
    public class InfractorBL
    {
        InfractorADO objInfractorADO = new InfractorADO();

        public Boolean InsertarInfractor(InfractorBE objInfractorBE)
        {
            return objInfractorADO.InsertarInfractor(objInfractorBE);
        }

        public Boolean ActualizarInfractor(InfractorBE objInfractorBE)
        {
            return objInfractorADO.ActualizarInfractor(objInfractorBE);
        }

        public bool EliminarInfractor(string codigo)
        {
            return objInfractorADO.EliminarInfractor(codigo);
        }
        public InfractorBE ConsultarInfractor(String strCodigo)
        {
            return objInfractorADO.ConsultarInfractor(strCodigo);
        }

        public DataTable ListarDepartamentos()
        {
            return objInfractorADO.ListarDepartamentos();
        }

        public DataTable ListarProvincias(string departamento)
        {
            return objInfractorADO.ListarProvincias(departamento);
        }

        public DataTable ListarDistritos(string provincia)
        {
            return objInfractorADO.ListarDistritos(provincia);
        }

        public DataTable ObtenerUbigeoPorInfractor(string codInfractor)
        {
            return objInfractorADO.ObtenerUbigeoPorInfractor(codInfractor);
        }

        public DataTable ListarInfractores()
        {
            return objInfractorADO.ListarInfractores();
        }
    }
}
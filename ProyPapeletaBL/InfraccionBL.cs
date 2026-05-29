using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using ProyPapeletaADO;
using ProyPapeletaBE;

namespace ProyPapeletaBL
{
    public class InfraccionBL
    {

        InfraccionADO objInfraccionADO = new InfraccionADO();
        public Boolean InsertarInfraccion(InfraccionBE objInfraccionBE)
        {
            return objInfraccionADO.InsertarInfraccion(objInfraccionBE);
        }

        public Boolean ActualizarInfraccion(InfraccionBE objInfraccionBE)
        {
            return objInfraccionADO.ActualizarInfraccion(objInfraccionBE);
        }

        public Boolean EliminarInfraccion(String strCodigo)
        {
            return objInfraccionADO.EliminarInfraccion(strCodigo);
        }

        public InfraccionBE ConsultarInfraccion(String strCodigo)
        {
            return objInfraccionADO.ConsultarInfraccion(strCodigo);
        }

        public DataTable ListarInfraccion()
        {
            return objInfraccionADO.ListarInfraccion();
        }
    }
}

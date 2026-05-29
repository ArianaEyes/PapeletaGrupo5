using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Using....
using ProyVentas_ADO;
using ProyVentas_BE;

namespace ProyVentas_BL
{
    public class UsuarioBL
    {
        UsuarioADO objUsuarioADO = new UsuarioADO();

        public UsuarioBE ConsultarUsuario(String strLogin)
        {
            // El login es obligatorio
            if (string.IsNullOrWhiteSpace(strLogin))
            {
                throw new ArgumentException("No se proporciono login de usuario.");

            }
            // Si todo esta OK devolvemos los datos del usuario consultado
            return objUsuarioADO.ConsultarUsuario(strLogin);

        }
    }
}

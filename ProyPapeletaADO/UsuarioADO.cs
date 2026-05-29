using Microsoft.Data.SqlClient;
using ProyPapeletaADO;
using ProyVentas_BE;
using System;
using System.Collections.Generic;
// Agregar using...
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProyVentas_ADO
{
    public class UsuarioADO
    {


        public UsuarioBE ConsultarUsuario(String strLogin)
        {
            UsuarioBE objUsuarioBE = new UsuarioBE();
            try
            {
                using (SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_CONSULTAR_USUARIO", cnx))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Login_Usuario", strLogin);
                        cnx.Open();
                        using (SqlDataReader dtr = cmd.ExecuteReader())
                        {
                            //Codifique

                            if (dtr.Read())
                            {
                                objUsuarioBE.Login_Usuario = dtr["Login_Usuario"].ToString();
                                objUsuarioBE.Pass_Usuario = dtr["Pass_Usuario"].ToString();
                                objUsuarioBE.Niv_Usuario = Convert.ToInt16(dtr["Niv_Usuario"]);
                                objUsuarioBE.Est_Usuario = Convert.ToInt16(dtr["Est_Usuario"]);
                                objUsuarioBE.Fec_Registro = Convert.ToDateTime(dtr["Fec_Registro"]);
                                objUsuarioBE.Usu_Registro = dtr["Usu_Registro"].ToString();
                            }

                        }
                    }
                }
                //Retornamos los datos del usuario logueado
                return objUsuarioBE;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }



        }
    }
}

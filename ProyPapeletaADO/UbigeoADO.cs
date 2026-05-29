using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;
using ProyPapeletaBE;
using System.Configuration;


namespace ProyPapeletaADO
{
    public class UbigeoADO
    {
        public DataTable Ubigeo_Departamentos()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA))
                using (SqlCommand cmd = new SqlCommand("SP_UBIGEO_DEPARTAMENTOS", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using var ada = new SqlDataAdapter(cmd);
                    ada.Fill(dt);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error {ex.Message}");
            }
            return dt;
        }


        public DataTable Ubigeo_ProvinciasDepartamento(String strIdDepartamento)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA))
                using (SqlCommand cmd = new SqlCommand("SP_UBIGEO_PROVINCIASDEPARTAMENTO", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ID_DEPA", SqlDbType.Char).Value = strIdDepartamento;
                    using var ada = new SqlDataAdapter(cmd);
                    ada.Fill(dt);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error {ex.Message}");
            }
            return dt;
        }

        public DataTable Ubigeo_DistritosProvinciaDepartamento(String strIdDepartamento, String strIdProvincia)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA))
                using (SqlCommand cmd = new SqlCommand("SP_UBIGEO_DISTRITOSPROVINCIASDEPARTAMENTO", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ID_DEPA", SqlDbType.Char).Value = strIdDepartamento;
                    cmd.Parameters.Add("@ID_PROV", SqlDbType.Char).Value = strIdProvincia;
                    using var ada = new SqlDataAdapter(cmd);
                    ada.Fill(dt);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error {ex.Message}");
            }
            return dt;
        }
    }
}

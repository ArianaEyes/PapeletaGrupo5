using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ProyPapeletaBE;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;

namespace ProyPapeletaADO
{
    public class InfractorADO
    {
        public Boolean InsertarInfractor(InfractorBE objInfractorBE)
        {
            try
            {

                using (SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_INSERTAR_INFRACTOR", cnx))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@NOMBRES", SqlDbType.VarChar).Value = objInfractorBE.NOMBRES;
                        cmd.Parameters.Add("@APE_PATERNO", SqlDbType.VarChar).Value = objInfractorBE.APE_PATERNO;
                        cmd.Parameters.Add("@APE_MATERNO", SqlDbType.VarChar).Value = objInfractorBE.APE_MATERNO;
                        cmd.Parameters.Add("@DNI", SqlDbType.Char).Value = objInfractorBE.DNI;
                        cmd.Parameters.Add("@CORREO", SqlDbType.VarChar).Value = objInfractorBE.CORREO;
                        cmd.Parameters.Add("@DIRECCION", SqlDbType.VarChar).Value = objInfractorBE.DIRECCION;
                        cmd.Parameters.Add("@COD_UBIGEO", SqlDbType.Char).Value = objInfractorBE.COD_UBIGEO;
                        cmd.Parameters.Add("@SEXO", SqlDbType.Char).Value = objInfractorBE.SEXO;
                        cmd.Parameters.Add("@FEC_NACIMIENTO", SqlDbType.Date).Value = objInfractorBE.FEC_NACIMIENTO;
                        cmd.Parameters.Add("@FOTO", SqlDbType.Image).Value = objInfractorBE.FOTO;
                        cmd.Parameters.Add("@NRO_BREVETE", SqlDbType.Char).Value = objInfractorBE.NRO_BREVETE;
                        cmd.Parameters.Add("@TIPO_BREVETE", SqlDbType.VarChar).Value = objInfractorBE.TIPO_BREVETE;
                        cmd.Parameters.Add("@ESTADO", SqlDbType.Char).Value = objInfractorBE.ESTADO;
                        cmd.Parameters.Add("@USU_REGISTRO", SqlDbType.VarChar).Value = objInfractorBE.USU_REGISTRO;

                        cnx.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al insertar Infractor: {ex.Message}");

            }
        }
        public Boolean ActualizarInfractor(InfractorBE objBE)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_ACTUALIZAR_INFRACTOR", cnx))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@COD_INFRACTOR", objBE.COD_INFRACTOR);
                        cmd.Parameters.AddWithValue("@NOMBRES", objBE.NOMBRES);
                        cmd.Parameters.AddWithValue("@APE_PATERNO", objBE.APE_PATERNO);
                        cmd.Parameters.AddWithValue("@APE_MATERNO", objBE.APE_MATERNO);
                        cmd.Parameters.AddWithValue("@DNI", objBE.DNI);
                        cmd.Parameters.AddWithValue("@CORREO", objBE.CORREO);
                        cmd.Parameters.AddWithValue("@DIRECCION", objBE.DIRECCION);
                        cmd.Parameters.AddWithValue("@COD_UBIGEO", objBE.COD_UBIGEO);
                        cmd.Parameters.AddWithValue("@NRO_BREVETE", objBE.NRO_BREVETE);
                        cmd.Parameters.AddWithValue("@TIPO_BREVETE", objBE.TIPO_BREVETE);
                        cmd.Parameters.AddWithValue("@FEC_NACIMIENTO", objBE.FEC_NACIMIENTO);
                        cmd.Parameters.AddWithValue("@SEXO", objBE.SEXO);
                        cmd.Parameters.AddWithValue("@ESTADO", objBE.ESTADO);
                        cmd.Parameters.AddWithValue("@USU_ULT_MODIFICACION", "ADMIN");

                        SqlParameter pcbFoto = new SqlParameter("@FOTO", SqlDbType.VarBinary, -1);
                        pcbFoto.Value = (object)objBE.FOTO ?? DBNull.Value;
                        cmd.Parameters.Add(pcbFoto);

                        cnx.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar Infractor: " + ex.Message);
            }
        }

        public bool EliminarInfractor(string codigo)
        {
            try
            {
                using (SqlConnection cnx =
                    new SqlConnection(Configuracion.PAPELETA))
                {
                    SqlCommand cmd = new SqlCommand(
                        "SP_ELIMINAR_INFRACTOR", cnx);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@COD_INFRACTOR", codigo);

                    cmd.Parameters.AddWithValue("@USU_ULT_MODIFICACION", "ADMIN");

                    cnx.Open();

                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al eliminar infractor: " + ex.Message);
            }
        }

        public InfractorBE ConsultarInfractor(String strCodigo)
        {
            var objInfractorBE = new InfractorBE();
            try
            {

                using (SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_CONSULTAR_INFRACTOR", cnx))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@COD_INFRACTOR", SqlDbType.Char).Value = strCodigo;

                        cnx.Open();
                        using (SqlDataReader dtr = cmd.ExecuteReader())
                        {
                            if (dtr.Read())
                            {
                                objInfractorBE.COD_INFRACTOR = dtr["COD_INFRACTOR"].ToString();
                                objInfractorBE.NOMBRES = dtr["NOMBRES"].ToString();
                                objInfractorBE.APE_PATERNO = dtr["APE_PATERNO"].ToString();
                                objInfractorBE.APE_MATERNO = dtr["APE_MATERNO"].ToString();
                                objInfractorBE.DNI = dtr["DNI"].ToString();
                                objInfractorBE.CORREO = dtr["CORREO"].ToString();
                                objInfractorBE.DIRECCION = dtr["DIRECCION"].ToString();
                                objInfractorBE.SEXO = dtr["SEXO"].ToString();
                                objInfractorBE.FEC_NACIMIENTO = Convert.ToDateTime(dtr["FEC_NACIMIENTO"]);
                                objInfractorBE.NRO_BREVETE = dtr["NRO_BREVETE"].ToString();
                                objInfractorBE.TIPO_BREVETE = dtr["TIPO_BREVETE"].ToString();
                                objInfractorBE.ESTADO = dtr["ESTADO"].ToString();
                                objInfractorBE.COD_UBIGEO = dtr["COD_UBIGEO"].ToString();
                                if (dtr["FOTO"] != DBNull.Value)
                                {
                                    objInfractorBE.FOTO = (byte[])dtr["FOTO"];
                                }

                            }
                            return objInfractorBE;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al consultar Infractor: {ex.Message}");

            }
        }
        public DataTable ListarDepartamentos()
        {
            DataTable dt = new DataTable();

            using (SqlConnection cnx =
                new SqlConnection(Configuracion.PAPELETA))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT DISTINCT DEPARTAMENTO FROM TB_UBIGEO",
                    cnx);

                da.Fill(dt);
            }

            return dt;
        }
        public DataTable ListarProvincias(string departamento)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT DISTINCT PROVINCIA FROM TB_UBIGEO WHERE DEPARTAMENTO=@DEPARTAMENTO",
                    cnx);

                da.SelectCommand.Parameters.AddWithValue("@DEPARTAMENTO", departamento);

                da.Fill(dt);
            }

            return dt;
        }
        public DataTable ListarDistritos(string provincia)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT COD_UBIGEO, DISTRITO FROM TB_UBIGEO WHERE PROVINCIA=@PROVINCIA",
                    cnx);

                da.SelectCommand.Parameters.AddWithValue("@PROVINCIA", provincia);

                da.Fill(dt);
            }

            return dt;
        }

        public DataTable ObtenerUbigeoPorInfractor(string codInfractor)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA))
            {
                SqlCommand cmd = new SqlCommand("SP_CONSULTAR_INFRACTOR", cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@COD_INFRACTOR", SqlDbType.Char, 5).Value = codInfractor;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }
        public DataTable ListarTiposBrevete()
        {
            DataTable dt = new DataTable();

            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            IConfigurationRoot configuration = builder.Build();

            string cadena = configuration.GetConnectionString("Papeleta");

            SqlConnection cnx = new SqlConnection(cadena);

            SqlCommand cmd = new SqlCommand(
                    "SELECT DISTINCT TIPO_BREVETE FROM TB_INFRACTOR ORDER BY TIPO_BREVETE", cnx);

            try
            {
                cnx.Open();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);

                ada.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }

        public DataTable ListarInfractores()
        {
            DataTable dt = new DataTable();

            using SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA);
            SqlCommand cmd = new SqlCommand("SP_LISTAR_INFRACTOR", cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        public DataRow ObtenerUbigeo(string codUbigeo)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA))
            {
                SqlCommand cmd = new SqlCommand("SP_OBTENER_UBIGEO", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@COD_UBIGEO", SqlDbType.Char, 6).Value = codUbigeo.Trim();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }
        public DataTable ListarMultasPorInfractor(string codigoInfractor, DateTime fecIni, DateTime fecFin)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection cnx = new SqlConnection(Configuracion.PAPELETA))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_LISTARMULTASINFRACTOR", cnx))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        cmd.Parameters.AddWithValue("@COD_INFRACTOR", codigoInfractor);

                        cmd.Parameters.AddWithValue("@FECINI", new DateTime(2000, 1, 1));
                        cmd.Parameters.AddWithValue("@FECFIN", new DateTime(2050, 12, 31));

                        using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                        {
                            ada.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar las papeletas en ADO: " + ex.Message);
            }

            return dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBanco_ADO
{
    public class UbigeoADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public DataTable Ubigeo_Departamentos()
        {
            DataSet dts = new DataSet();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Ubigeo_Departamentos";
                cmd.Parameters.Clear();
                SqlDataAdapter ada;
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Departamentos");
                return dts.Tables["Departamentos"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Ubigeo_ProvinciasDepartamento(String strIdDep)
        {
            DataSet dts = new DataSet();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Ubigeo_ProvinciasDepartamento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdDep", strIdDep);
                SqlDataAdapter ada;
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Provincias");
                return dts.Tables["Provincias"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Ubigeo_DistritosProvinciaDepartamento(String strIdDep, String strIdProv)
        {
            DataSet dts = new DataSet();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Ubigeo_DistritosProvinciaDepartamento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdDep", strIdDep);
                cmd.Parameters.AddWithValue("@IdProv", strIdProv);
                SqlDataAdapter ada;
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Distritos");
                return dts.Tables["Distritos"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public String ObtenerUbigeo(String idUbigeo)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ObtenerUbigeo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idUbigeo", idUbigeo);

                cmd.Parameters.Add("@Ubicacion", SqlDbType.NVarChar, 50);
                cmd.Parameters["@Ubicacion"].Direction = ParameterDirection.Output;

                cnx.Open();
                cmd.ExecuteScalar();
                String ubicacion = Convert.ToString(cmd.Parameters["@Ubicacion"].Value);
                return ubicacion;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}


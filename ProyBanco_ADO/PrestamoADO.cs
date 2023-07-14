using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar....
using System.Data;
using System.Data.SqlClient;
using ProyBanco_BE;

namespace ProyBanco_ADO
{
    public class PrestamoADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarPrestamo()
        {
            try
            {
                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarPrestamo";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Prestamos");
                return dts.Tables["Prestamos"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public PrestamoBE ConsultarPrestamo(String strCodigo)
        {
            try
            {
                PrestamoBE objPrestamoBE = new PrestamoBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarPrestamo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idPrestamo", strCodigo);
                cnx.Open();

                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objPrestamoBE.Cod_Pre = dtr["Codigo"].ToString();
                    objPrestamoBE.Mon_Pre = Convert.ToSingle(dtr["Monto"].ToString());
                    objPrestamoBE.Cuot_Pre = Convert.ToInt16(dtr["Cuotas"].ToString());
                    objPrestamoBE.Fec_Sol = Convert.ToDateTime(dtr["Fecha Solicitud"].ToString());
                    objPrestamoBE.Fec_Rech = Convert.ToDateTime(dtr["Fecha Rechazo"].ToString());
                    objPrestamoBE.Fec_Can = Convert.ToDateTime(dtr["Fecha Cancelacion"].ToString());
                    objPrestamoBE.Pre_Est = Convert.ToInt16(dtr["Pre_Est"].ToString());
                    objPrestamoBE.Com_Deu = Convert.ToInt16(dtr["Com_Deu"].ToString());
                    objPrestamoBE.Est_Pre = Convert.ToInt16(dtr["Est_Pre"].ToString());
                    objPrestamoBE.Cod_Cli = dtr["Cod_Cli"].ToString();
                    objPrestamoBE.Cod_Emp = dtr["Cod_Emp"].ToString();
                    objPrestamoBE.Cod_Age = dtr["Cod_Age"].ToString();
                }
                dtr.Close();
                return objPrestamoBE;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public Boolean InsertarPrestamo(PrestamoBE objPrestamoBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarPrestamo";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@Mon_Pre", objPrestamoBE.Mon_Pre);
                cmd.Parameters.AddWithValue("@Cuot_Pre", objPrestamoBE.Cuot_Pre);
                cmd.Parameters.AddWithValue("@Pre_Est", objPrestamoBE.Pre_Est);
                cmd.Parameters.AddWithValue("@Com_Deu", objPrestamoBE.Com_Deu);
                cmd.Parameters.AddWithValue("@Est_Pre", objPrestamoBE.Est_Pre);
                cmd.Parameters.AddWithValue("@Cod_Cli", objPrestamoBE.Cod_Cli);
                cmd.Parameters.AddWithValue("@Cod_Emp", objPrestamoBE.Cod_Emp);
                cmd.Parameters.AddWithValue("@Cod_Age", objPrestamoBE.Cod_Age);
                cmd.Parameters.AddWithValue("@Usu_Registro", objPrestamoBE.Usu_Registro);

                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public Boolean ActualizarPrestamo(PrestamoBE objPrestamoBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarPrestamo";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@Cod_Pre", objPrestamoBE.Cod_Pre);
                cmd.Parameters.AddWithValue("@Mon_Pre", objPrestamoBE.Mon_Pre);
                cmd.Parameters.AddWithValue("@Cuot_Pre", objPrestamoBE.Cuot_Pre);
                cmd.Parameters.AddWithValue("@Fec_Rech", objPrestamoBE.Fec_Rech);
                cmd.Parameters.AddWithValue("@Fec_Can", objPrestamoBE.Fec_Can);
                cmd.Parameters.AddWithValue("@Pre_Est", objPrestamoBE.Pre_Est);
                cmd.Parameters.AddWithValue("@Com_Deu", objPrestamoBE.Com_Deu);
                cmd.Parameters.AddWithValue("@Est_Pre", objPrestamoBE.Est_Pre);
                cmd.Parameters.AddWithValue("@Cod_Cli", objPrestamoBE.Cod_Cli);
                cmd.Parameters.AddWithValue("@Cod_Emp", objPrestamoBE.Cod_Emp);
                cmd.Parameters.AddWithValue("@Cod_Age", objPrestamoBE.Cod_Age);
                cmd.Parameters.AddWithValue("@Usu_Ult_Mod", objPrestamoBE.Usu_Ult_Mod);

                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public Boolean EliminarPrestamo(String strCodigo)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarPrestamo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idPrestamo", strCodigo);

                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException x)
            {
                return false;
                throw new Exception(x.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public DataTable ListarPrestamos_Paginacion(string strCod_Cli, String strCod_Emp, String strEstado, Int16 intNumPag)
        {
            try
            {
                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarPrestamos_Paginacion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Cod_Cli", strCod_Cli);
                cmd.Parameters.AddWithValue("@Cod_Emp", strCod_Emp);
                cmd.Parameters.AddWithValue("@Estado", strEstado);
                cmd.Parameters.AddWithValue("@NumPag", intNumPag);

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "PrestamosPaginacion");
                return dts.Tables["PrestamosPaginacion"];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Int16 NumPag_ListarPrestamos_Paginacion(String strCod_Cli, String strCod_Emp, String strEstado)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_NumPag_ListarPrestamos_Paginacion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Cod_Cli", strCod_Cli);
                cmd.Parameters.AddWithValue("@Cod_Emp", strCod_Emp);
                cmd.Parameters.AddWithValue("@Estado", strEstado);

                // Parametro de salida
                cmd.Parameters.Add("@Numreg", SqlDbType.Int);
                cmd.Parameters["@Numreg"].Direction = ParameterDirection.Output;

                // Abrir la conexion y ejecutar el procedimiento almacenado
                cnx.Open();
                cmd.ExecuteScalar();
                Int16 numreg = Convert.ToInt16(cmd.Parameters["@Numreg"].Value);
                return numreg;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarPrestamosAnuales()
        {
            try
            {
                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_PrestamosInfo";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "PrestamosAnuales");
                return dts.Tables["PrestamosAnuales"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

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
    public class PagoADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarPago()
        {
            try
            {
                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarPago";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Pagos");
                return dts.Tables["Pagos"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public PagoBE ConsultarPago(String strCodigo)
        {
            try
            {
                PagoBE objPagoBE = new PagoBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarPago";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idPago", strCodigo);
                cnx.Open();

                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objPagoBE.Cod_Pag = dtr["Codigo"].ToString();
                    objPagoBE.Num_cuot_Pag = Convert.ToInt16(dtr["Numero Cuota"].ToString());
                    objPagoBE.Mon_Pag = Convert.ToSingle(dtr["Monto"].ToString());
                    objPagoBE.Fec_pro_Pag = Convert.ToDateTime(dtr["Fecha Programada"].ToString());
                    objPagoBE.Fec_real_Pag = Convert.ToDateTime(dtr["Fecha Real"].ToString());
                    objPagoBE.Cod_Pre = dtr["Codigo Prestamo"].ToString();
                    objPagoBE.Est_Pag = Convert.ToInt16(dtr["Estado"].ToString());
                }
                dtr.Close();
                return objPagoBE;
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

        public Boolean InsertarPago(PagoBE objPagoBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarPago";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@Num_cuot_Pag", objPagoBE.Num_cuot_Pag);
                cmd.Parameters.AddWithValue("@Mon_Pag", objPagoBE.Mon_Pag);
                cmd.Parameters.AddWithValue("@Fec_pro_Pag", objPagoBE.Fec_pro_Pag);
                cmd.Parameters.AddWithValue("@Fec_real_Pag", objPagoBE.Fec_real_Pag);
                cmd.Parameters.AddWithValue("@Cod_Pre", objPagoBE.Cod_Pre);
                cmd.Parameters.AddWithValue("@Est_Pag", objPagoBE.Est_Pag);
                cmd.Parameters.AddWithValue("@Usu_Registro", objPagoBE.Usu_Registro);

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

        public Boolean ActualizarPago(PagoBE objPagoBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarPrestamo";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@Cod_Pag", objPagoBE.Cod_Pag);
                cmd.Parameters.AddWithValue("@Num_cuot_Pag", objPagoBE.Num_cuot_Pag);
                cmd.Parameters.AddWithValue("@Mon_Pag", objPagoBE.Mon_Pag);
                cmd.Parameters.AddWithValue("@Fec_pro_Pag", objPagoBE.Fec_pro_Pag);
                cmd.Parameters.AddWithValue("@Fec_real_Pag", objPagoBE.Fec_real_Pag);
                cmd.Parameters.AddWithValue("@Cod_Pre", objPagoBE.Cod_Pre);
                cmd.Parameters.AddWithValue("@Est_Pag", objPagoBE.Est_Pag);
                cmd.Parameters.AddWithValue("@Usu_Ult_Mod", objPagoBE.Usu_Ult_Mod);

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

        public Boolean EliminarPago(String strCodigo)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarPago";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idPago", strCodigo);

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
    }
}

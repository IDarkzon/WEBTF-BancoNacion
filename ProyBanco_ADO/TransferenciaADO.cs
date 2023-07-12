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
    public class TransferenciaADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarTransferencia()
        {
            try
            {
                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarTransferencia";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Transferencias");
                return dts.Tables["Transferencias"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // TODO
        public TransferenciaBE ConsultarTransferencia(String strCodigo)
        {
            try
            {
                TransferenciaBE objTransferenciaBE = new TransferenciaBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarTransferencia";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo", strCodigo);
                cnx.Open();

                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objTransferenciaBE.Cod_Tran = dtr["Codigo Transferencia"].ToString();
                    objTransferenciaBE.Mon_Tran = Convert.ToSingle(dtr["Monto Transferencia"].ToString());
                    objTransferenciaBE.Cuen_Dest = dtr["Cuenta Destino"].ToString();
                    objTransferenciaBE.Cuen_Orig = dtr["Cuenta Origen"].ToString();
                    objTransferenciaBE.Tran_Int = Convert.ToInt16(dtr["Transferencia Interbancaria"].ToString());
                    objTransferenciaBE.Fec_Tran = Convert.ToDateTime(dtr["fecha"].ToString());
                    
                }
                dtr.Close();
                return objTransferenciaBE;
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

        public Boolean InsertarTransferencia(TransferenciaBE objTransferenciaBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarTransferencia";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@montoTran", objTransferenciaBE.Mon_Tran);
                cmd.Parameters.AddWithValue("@cuentaDest", objTransferenciaBE.Cuen_Dest);
                cmd.Parameters.AddWithValue("@cuentaOrig", objTransferenciaBE.Cuen_Orig);
                cmd.Parameters.AddWithValue("@tranInterb", objTransferenciaBE.Tran_Int);
                cmd.Parameters.AddWithValue("@fechaTran", objTransferenciaBE.Fec_Tran);

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

        public Boolean ActualizarTransferencia(TransferenciaBE objTransferenciaBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarTransferencia";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@codigo", objTransferenciaBE.Cod_Tran);
                cmd.Parameters.AddWithValue("@montoTran", objTransferenciaBE.Mon_Tran);
                cmd.Parameters.AddWithValue("@cuentaDest", objTransferenciaBE.Cuen_Dest);
                cmd.Parameters.AddWithValue("@cuentaOrig", objTransferenciaBE.Cuen_Orig);
                cmd.Parameters.AddWithValue("@tranInterb", objTransferenciaBE.Tran_Int);
                cmd.Parameters.AddWithValue("@fechaTran", objTransferenciaBE.Fec_Tran);

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

        public Boolean EliminarTransferencia(String strCodigo)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarTransferencia";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo", strCodigo);

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

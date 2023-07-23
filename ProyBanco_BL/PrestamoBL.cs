using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Otros
using ProyBanco_ADO;
using ProyBanco_BE;

namespace ProyBanco_BL
{
    public class PrestamoBL
    {
        PrestamoADO objPrestamoADO = new PrestamoADO();

        public DataTable ListarPrestamo()
        {
            return objPrestamoADO.ListarPrestamo();
        }

        public PrestamoBE ConsultarPrestamo(String strCodigo)
        {
            return objPrestamoADO.ConsultarPrestamo(strCodigo);
        }

        public Boolean InsertarPrestamo(PrestamoBE objPrestamoBE)
        {
            return objPrestamoADO.InsertarPrestamo(objPrestamoBE);
        }

        public Boolean ActualizarPrestamo(PrestamoBE objPrestamoBE)
        {
            return objPrestamoADO.ActualizarPrestamo(objPrestamoBE);
        }

        public Boolean EliminarPrestamo(String strCodigo)
        {
            return objPrestamoADO.EliminarPrestamo(strCodigo);
        }

        public DataTable ListarPrestamos_Paginacion(string strCod_Cli, String strCod_Emp, String strEstado, Int16 intNumPag)
        {
            return objPrestamoADO.ListarPrestamos_Paginacion(strCod_Cli, strCod_Emp, strEstado, intNumPag);
        }

        public Int16 NumPag_ListarPrestamos_Paginacion(String strCod_Cli, String strCod_Emp, String strEstado)
        {
            return objPrestamoADO.NumPag_ListarPrestamos_Paginacion(strCod_Cli, strCod_Emp, strEstado);
        }

        public DataTable ListarPrestamosAnuales()
        {
            return objPrestamoADO.ListarPrestamosAnuales();
        }

        public DataTable PrestamosCliente(String Num_doc_cli)
        {
            return objPrestamoADO.PrestamosCliente(Num_doc_cli);
        }
    }
}

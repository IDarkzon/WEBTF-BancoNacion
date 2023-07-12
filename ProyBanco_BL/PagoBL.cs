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
    public class PagoBL
    {
        PagoADO objPagoADO = new PagoADO();

        public DataTable ListarPago()
        {
            return objPagoADO.ListarPago();
        }

        public PagoBE ConsultarPago(String strCodigo)
        {
            return objPagoADO.ConsultarPago(strCodigo);
        }

        public Boolean InsertarPago(PagoBE objPagoBE)
        {
            return objPagoADO.InsertarPago(objPagoBE);
        }

        public Boolean ActualizarPago(PagoBE objPagoBE)
        {
            return objPagoADO.ActualizarPago(objPagoBE);
        }

        public Boolean EliminarPago(String strCodigo)
        {
            return objPagoADO.EliminarPago(strCodigo);
        }
    }
}

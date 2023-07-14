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
    public class TransferenciaBL
    {
        TransferenciaADO objTransferenciaADO = new TransferenciaADO();

        public DataTable ListarTransferencias()
        {
            return objTransferenciaADO.ListarTransferencia();
        }

        public TransferenciaBE ConsultarTransferencia(string strCodTransferencia)
        {
            return objTransferenciaADO.ConsultarTransferencia(strCodTransferencia);
        }

        public Boolean InsertarTransferencia(TransferenciaBE objTransferenciaBE)
        {
            return objTransferenciaADO.InsertarTransferencia(objTransferenciaBE);
        }

        public Boolean ActualizarTransferencia(TransferenciaBE objTransferenciaBE)
        {
            return objTransferenciaADO.ActualizarTransferencia(objTransferenciaBE);
        }

        public Boolean EliminarTransferencia(string strCodTransferencia)
        {
            return objTransferenciaADO.EliminarTransferencia(strCodTransferencia);
        }

        public DataTable TransferenciasInfo()
        {
            return objTransferenciaADO.TransferenciasInfo();
        }
    }
}

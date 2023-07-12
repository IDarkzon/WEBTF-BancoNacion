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
    }
}

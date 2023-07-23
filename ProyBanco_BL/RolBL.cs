using ProyBanco_ADO;
using ProyBanco_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBanco_BL
{
    public class RolBL
    {
        RolADO objRolADO = new RolADO();

        public Boolean Insertar(RolBE objRolBE)
        {
            return objRolADO.Insertar(objRolBE);
        }

        public DataTable ListarRoles()
        {
            return objRolADO.ListarRoles();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Otros
using ProyBanco_ADO;
using ProyBanco_BE;


namespace ProyBanco_BL
{
    public class UsuarioBL
    {
        UsuarioADO objUsuarioADO = new UsuarioADO();

        public Boolean Insertar(UsuarioBE objUsuarioBE)
        {
            return objUsuarioADO.Insertar(objUsuarioBE);
        }
    }
}


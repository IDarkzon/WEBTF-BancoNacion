using ProyBanco_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;


namespace ProyBanco_ADO
{
    public class UsuarioADO
    {
        public Boolean Insertar(UsuarioBE objUsuarioBE)
        {
            try
            {
                Membership.CreateUser(objUsuarioBE.Login, objUsuarioBE.Password, objUsuarioBE.Email);

                Roles.AddUserToRole(objUsuarioBE.Login, objUsuarioBE.Rol);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

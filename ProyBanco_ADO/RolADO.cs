using ProyBanco_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace ProyBanco_ADO
{
    public class RolADO
    {
        public Boolean Insertar(RolBE objRolBE)
        {
            try
            {
                Roles.CreateRole(objRolBE.Rol);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarRoles()
        {
            try
            {
                String[] MisRoles;

                MisRoles = Roles.GetAllRoles();

                DataTable dtRoles = new DataTable();
                dtRoles.Columns.Add("Rol", Type.GetType("System.String"));

                for (int i = 0; i < MisRoles.Length; i++)
                {
                    DataRow row = dtRoles.NewRow();
                    row["Rol"] = MisRoles[i];
                    dtRoles.Rows.Add(row);
                }

                return dtRoles;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

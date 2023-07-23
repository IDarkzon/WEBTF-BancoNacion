using ProyBanco_BE;
using ProyBanco_BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyBanco_GUI.Seguridad
{
    public partial class Roles : System.Web.UI.Page
    {
        RolBE objRolBE = new RolBE();
        RolBL objRolBL = new RolBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsPostBack == false)
                {
                    InyectarRoles();
                }
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = "Error: " + ex.Message;
                PopMensaje.Show();
            }
        }

        private void InyectarRoles()
        {
            lstRoles.DataSource = objRolBL.ListarRoles();
            lstRoles.DataTextField = "Rol";
            lstRoles.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRol.Text.Trim() == String.Empty)
                {
                    throw new Exception("Debe ingresar un rol");
                }

                objRolBE.Rol = txtRol.Text.Trim();

                if (objRolBL.Insertar(objRolBE) == true)
                {
                    InyectarRoles();
                    txtRol.Text = String.Empty;
                }
                else
                {
                    throw new Exception("No se insertó el rol, conctacte con IT.");
                }
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = "Error: " + ex.Message;
                PopMensaje.Show();
            }
        }
    }
}
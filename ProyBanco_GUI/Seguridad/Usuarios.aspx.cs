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
    public partial class Usuarios : System.Web.UI.Page
    {
        RolBL objRolBL = new RolBL();
        UsuarioBE objUsuarioBE = new UsuarioBE();
        UsuarioBL objUsuarioBL = new UsuarioBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    // Enlazamos el combo de roles...
                    if (objRolBL.ListarRoles().Rows.Count == 0)
                    {
                        btnAgregar.Enabled = false;
                        throw new Exception("No existen roles para asignar.");
                    }
                    else
                    {
                        cboRoles.DataSource = objRolBL.ListarRoles();
                        cboRoles.DataTextField = "Rol";
                        cboRoles.DataBind();
                        btnAgregar.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = "Error: " + ex.Message;
                PopMensaje.Show();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUsuario.Text.Trim() == String.Empty)
                {
                    throw new Exception("El ID de Usuario es obligatorio.");
                }

                if (txtPassword.Text.Trim() == String.Empty)
                {
                    throw new Exception("La contraseña es obligatoria.");
                }

                if (txtPassword.Text.Trim().Length < 8)
                {
                    throw new Exception("La contraseña debe tener 8 caracteres.");
                }

                if (txtEmail.Text.Trim() == String.Empty)
                {
                    throw new Exception("El Email es obligatorio.");
                }

                objUsuarioBE.Login = txtUsuario.Text.Trim();
                objUsuarioBE.Password = txtPassword.Text.Trim();
                objUsuarioBE.Email = txtEmail.Text.Trim();
                objUsuarioBE.Rol = cboRoles.Text.Trim();

                if (objUsuarioBL.Insertar(objUsuarioBE))
                {
                    lblMensaje.ForeColor = System.Drawing.Color.YellowGreen;
                    lblMensaje.Text = "Usuario registrado con exito";
                    txtUsuario.Text = String.Empty;
                    txtPassword.Text = String.Empty;
                    txtEmail.Text = String.Empty;
                    cboRoles.SelectedIndex = 0;
                }
                else
                {
                    throw new Exception("Error, usuario no se inserto. Contacte con IT");
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
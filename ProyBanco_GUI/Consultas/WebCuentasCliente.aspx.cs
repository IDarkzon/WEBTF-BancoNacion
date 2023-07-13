using ProyBanco_BE;
using ProyBanco_BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyBanco_GUI.Consultas
{
    public partial class WebCuentasCliente : System.Web.UI.Page
    {
        // Instancias
        ClienteBL objClienteBL = new ClienteBL();
        ClienteBE objClienteBE = new ClienteBE();
        UbigeoBL objUbigeoBL = new UbigeoBL();
        CuentaBL objCuentaBL = new CuentaBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnConsultar.Enabled = false;
            }
        }

        protected void imgBuscar_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                objClienteBE = objClienteBL.ConsultarCliente(txtCodigo.Text.Trim());
                grvCuentas.DataSource = null;
                grvCuentas.DataBind();

                if (objClienteBE.Cod_Cli == null)
                {
                    txtNombre.Text = String.Empty;
                    txtApellidos.Text = String.Empty;
                    txtCorreo.Text = String.Empty;
                    txtDireccion.Text = String.Empty;
                    txtDocumento.Text = String.Empty;
                    txtTelefono.Text = String.Empty;
                    txtTipoDocumento.Text = String.Empty;
                    txtUbigeo.Text = String.Empty;
                    txtFecNacimiento.Text = String.Empty;
                    imgEstado.ImageUrl = "";
                    lblMensaje.Text = String.Empty;
                    btnConsultar.Enabled = false;

                    throw new Exception("El codigo Ingresado no existe.");
                } else
                {
                    txtNombre.Text = objClienteBE.Nom_Cli;
                    txtApellidos.Text = objClienteBE.Ape_pat_Cli + " " + objClienteBE.Ape_mat_Cli;
                    txtCorreo.Text = objClienteBE.Cor_Cli;
                    txtDireccion.Text = objClienteBE.Dir_Cli;
                    txtDocumento.Text = objClienteBE.Num_doc_Cli;
                    txtTelefono.Text = objClienteBE.Tel_Cli;

                    switch(objClienteBE.Tip_doc_Cli)
                    {
                        case 1:
                            txtTipoDocumento.Text = "DNI";
                            break;
                        case 2:
                            txtTipoDocumento.Text = "Carnet de Extranjería";
                            break;
                        case 3:
                            txtTipoDocumento.Text = "Pasaporte";
                            break;
                    }

                    txtUbigeo.Text = objUbigeoBL.ObtenerUbigeo(objClienteBE.Id_Ubigeo);
                    txtFecNacimiento.Text = objClienteBE.Fec_nac_Cli.ToShortDateString();
                    if (objClienteBE.Est_Cli == 1)
                    {
                        imgEstado.ImageUrl = "~/Images/activo.png";
                    }
                    else
                    {
                        imgEstado.ImageUrl = "~/Images/inactivo.png";
                    }
                    lblMensaje.Text = String.Empty;
                    btnConsultar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = "Error: " + ex.Message;
                PopMensaje.Show();
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                grvCuentas.DataSource = objCuentaBL.CuentasCliente(txtCodigo.Text.Trim());
                grvCuentas.DataBind();

                lblMensaje.Text = "El cliente tiene registradas " + grvCuentas.Rows.Count.ToString() + " cuenta(s).";
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = "Error: " + ex.Message;
                PopMensaje.Show();
            }
        }

        protected void grvCuentas_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if(e.Row.Cells[5].Text == "Activo")
                {
                    e.Row.Cells[5].ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    e.Row.Cells[5].ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}
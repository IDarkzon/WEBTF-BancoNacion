using ProyBanco_BE;
using ProyBanco_BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyBanco_GUI.Consultas
{
    public partial class WebTransaccionPagos : System.Web.UI.Page
    {
        //Instancias
        PagoBE objPagoBE = new PagoBE();
        ClienteBE objClienteBE = new ClienteBE();
        PagoBL objPagoBL = new PagoBL();
        PrestamoBL objPrestamoBL = new PrestamoBL();
        ClienteBL objClienteBL = new ClienteBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnRegistrar.Enabled = false;
                cboPrestamo.Enabled = false;
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboPrestamo.SelectedIndex == 0 || cboPrestamo.SelectedIndex == -1)
                {
                    throw new Exception("Debe escoger un codigo de Prestamo.");
                }

                if (Convert.ToInt16(txtMonto.Text.Trim()) < 0)
                {
                    throw new Exception("El monto debe ser un valor positivo.");
                }

                if (txtMonto == null)
                {
                    throw new Exception("Debe ingresar un monto.");
                }

                //Insertar
                objPagoBE.Num_cuot_Pag = Convert.ToInt16(cboCuotas.SelectedItem.ToString());
                objPagoBE.Mon_Pag = Convert.ToSingle(txtMonto.Text.Trim());

                objPagoBE.Fec_real_Pag = Convert.ToDateTime(txtFecReal.Text.Trim());

                objPagoBE.Fec_pro_Pag = Convert.ToDateTime(txtFecProgramada.Text.Trim());

                objPagoBE.Cod_Pre = cboPrestamo.SelectedValue;
                objPagoBE.Est_Pag = Convert.ToInt16(chkActivo.Checked);

                MembershipUser usuarioActual = Membership.GetUser();
                String usuario = usuarioActual.UserName;

                objPagoBE.Usu_Registro = usuario;


                // Enviando datos
                if (objPagoBL.InsertarPago(objPagoBE))
                {
                    lblMensaje.ForeColor = System.Drawing.Color.Green;
                    lblMensaje.Text = "El pago se ha registrado correctamente";

                    // Reiniciamos el registro
                    txtDocCli.Text = String.Empty;
                    cboPrestamo.SelectedIndex = 0;
                    cboPrestamo.DataSource = null;
                    cboPrestamo.DataBind();
                    cboPrestamo.Enabled = false;
                    chkActivo.Checked = false;
                    txtMonto.Text = String.Empty;
                    cboCuotas.SelectedIndex = 0;
                    txtFecReal.Text = String.Empty;
                    txtFecProgramada.Text = String.Empty;
                    btnRegistrar.Enabled = false;
                }
                else
                {
                    throw new Exception("No se insertó el registro, contacte con TI.");
                }
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = "Error: " + ex.Message;
                PopMensaje.Show();
            }
        }

        protected void imgBuscar_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                objClienteBE = objClienteBL.ConsultarClienteDNI(txtDocCli.Text.Trim());

                if (objClienteBE.Cod_Cli == null)
                {
                    cboPrestamo.DataSource = null;
                    cboPrestamo.DataBind();
                    cboPrestamo.Enabled = false;
                    throw new Exception("Debe ingresar un número de documento existente.");
                }
                else
                {
                    DataTable dt = objPrestamoBL.PrestamosCliente(txtDocCli.Text.Trim());
                    DataRow dr = dt.NewRow();
                    dr["Codigo"] = "--Seleccione--";
                    dt.Rows.InsertAt(dr, 0);

                    cboPrestamo.DataSource = dt;
                    cboPrestamo.DataValueField = "Codigo";
                    cboPrestamo.DataTextField = "Codigo";
                    cboPrestamo.DataBind();

                    cboPrestamo.Enabled = true;
                    btnRegistrar.Enabled = true;
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
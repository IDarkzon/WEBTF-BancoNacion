using ProyBanco_BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyBanco_GUI.Consultas
{
    public partial class WebGraficosTransacciones : System.Web.UI.Page
    {
        // Instancia
        TransferenciaBL objTransferenciaBL = new TransferenciaBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                try
                {
                    grvTransferenciasInfo.DataSource = objTransferenciaBL.TransferenciasInfo();
                    grvTransferenciasInfo.DataBind();

                    DataTableReader dtReaderTotales = objTransferenciaBL.TransferenciasInfo().CreateDataReader();
                    DataTableReader dtReaderMonto = objTransferenciaBL.TransferenciasInfo().CreateDataReader();

                    grafCantidad.Series.Add("Totales");
                    grafCantidad.Series["Totales"].Points.DataBindXY(dtReaderTotales, "Mes", dtReaderTotales, "Total");
                    grafCantidad.Series["Totales"].IsValueShownAsLabel = true;
                    grafCantidad.Series["Totales"].LabelFormat = "n";

                    grafMonto.Series.Add("Monto");
                    grafMonto.Series["Monto"].Points.DataBindXY(dtReaderMonto, "Mes", dtReaderMonto, "Monto");
                    grafMonto.Series["Monto"].IsValueShownAsLabel = true;
                    grafMonto.Series["Monto"].LabelFormat = "c";
                }
                catch (Exception ex)
                {
                    lblMensajePopup.Text = "Error: " + ex.Message;
                    PopMensaje.Show();
                }
                

            }
        }
    }
}
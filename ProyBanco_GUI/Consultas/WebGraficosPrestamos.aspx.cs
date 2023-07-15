using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ProyBanco_BL;

namespace ProyBanco_GUI.Consultas
{
    public partial class WebGraficosPrestamos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsPostBack == false) 
                { 
                    //GridView
                    PrestamoBL objPrestamoBL = new PrestamoBL();

                    grvPrestamos.DataSource = objPrestamoBL.ListarPrestamosAnuales();
                    grvPrestamos.DataBind();


                    //Graficos
                    DataTableReader dtReaderPresTotales = objPrestamoBL.ListarPrestamosAnuales().CreateDataReader();
                    DataTableReader dtReaderPresCantidades = objPrestamoBL.ListarPrestamosAnuales().CreateDataReader();

                    //GrafPresTotales
                    grafPresTotales.Series.Add("Totales");
                    grafPresTotales.Series["Totales"].Points.DataBindXY(dtReaderPresTotales,"Año",dtReaderPresTotales,"Monto");
                    grafPresTotales.Series["Totales"].IsValueShownAsLabel = true;
                    grafPresTotales.Series["Totales"].LabelFormat = "c";

                    //GrafPresCantidades
                    grafPresCantidades.Series.Add("Cantidades");
                    grafPresCantidades.Series["Cantidades"].Points.DataBindXY(dtReaderPresCantidades, "Año", dtReaderPresCantidades, "cantPrestamos");
                    grafPresCantidades.Series["Cantidades"].IsValueShownAsLabel = true;
                    grafPresCantidades.Series["Cantidades"].LabelFormat = "n";

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// Agregamos...
using ProyBanco_BL;
using System.Data;


namespace ProyBanco_GUI.Consultas
{
    public partial class WebPrestamosPaginada : System.Web.UI.Page
    {
        // Instancias
        PrestamoBL objPrestamoBL = new PrestamoBL();
        ClienteBL objClienteBL = new ClienteBL();
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();

        // Variables
        String strTextPagina;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsPostBack == false)
                {
                    LlenarCombos();

                    // Filtro en blanco
                    Filtrar(false);
                }
            } catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        private void LlenarCombos()
        {
            // Nuevo item de combos
            DataTable dtCombos = new DataTable();
            DataRow drFila;

            // Llenamos el combo de clientes
            dtCombos = objClienteBL.ListarCliente();
            // Nuevo item
            drFila = dtCombos.NewRow();
            drFila["Codigo"] = "X";
            drFila["Nombre"] = "-- Seleccionar --";
            // Agregamos el item
            dtCombos.Rows.InsertAt(drFila, 0);

            // Combina los campos de nombre y apellido en una sola cadena
            dtCombos.Columns.Add("NombreCompleto", typeof(string));
            foreach (DataRow row in dtCombos.Rows)
            {
                string nombre = row["Nombre"].ToString();
                string apellidoPaterno = row["Apellido_Paterno"].ToString();
                string apellidoMaterno = row["Apellido_Materno"].ToString();
                string nombreCompleto = $"{nombre} {apellidoPaterno} {apellidoMaterno}";
                row["NombreCompleto"] = nombreCompleto;
            }

            // Ordena los elementos del combo alfabéticamente
            dtCombos.DefaultView.Sort = "NombreCompleto ASC";
            dtCombos = dtCombos.DefaultView.ToTable();

            // Asignamos al combo
            cboCliente.DataSource = dtCombos;
            cboCliente.DataTextField = "NombreCompleto";
            cboCliente.DataValueField = "Codigo";
            cboCliente.DataBind();

            // Llenamos el combo de empleados
            dtCombos = objEmpleadoBL.ListarEmpleado();
            // Nuevo item
            drFila = dtCombos.NewRow();
            drFila["Codigo"] = "X";
            drFila["Nombre"] = "-- Seleccionar --";
            // Agregamos el item
            dtCombos.Rows.InsertAt(drFila, 0);

            // Combina los campos de nombre y apellido en una sola cadena
            dtCombos.Columns.Add("NombreCompleto", typeof(string));
            foreach (DataRow row in dtCombos.Rows)
            {
                string nombre = row["Nombre"].ToString();
                string apellidoPaterno = row["Apellido Paterno"].ToString();
                string apellidoMaterno = row["Apellido Materno"].ToString();
                string nombreCompleto = $"{nombre} {apellidoPaterno} {apellidoMaterno}";
                row["NombreCompleto"] = nombreCompleto;
            }

            // Ordena los elementos del combo alfabéticamente
            dtCombos.DefaultView.Sort = "NombreCompleto ASC";
            dtCombos = dtCombos.DefaultView.ToTable();

            // Asignamos al combo
            cboEmpleado.DataSource = dtCombos;
            cboEmpleado.DataTextField = "NombreCompleto";
            cboEmpleado.DataValueField = "Codigo";
            cboEmpleado.DataBind();
        }

        private void Filtrar(Boolean blnFlag)
        {
            Int16 pagina = 0;
            String estado;
            String codCli;
            String codEmp;

            // Tamaño de la página
            Int16 size = 50;
            Int16 numPag;

            // Obtenemos los valores de los combos
            if (cboCliente.SelectedValue == "X")
            {
                codCli = "";
            }
            else
            {
                codCli = cboCliente.SelectedValue;
            }

            if (cboEmpleado.SelectedValue == "X")
            {
                codEmp = "";
            }
            else
            {
                codEmp = cboEmpleado.SelectedValue;
            }

            if (cboEstado.SelectedValue == "X")
            {
                estado = "";
            }
            else
            {
                estado = cboEstado.SelectedValue;
            }

            // Si el flag es true, es porque se ha pulsado el botón de paginación
            if (blnFlag == true)
            {
                strTextPagina = cboPaginas.SelectedItem.ToString();
                pagina = Convert.ToInt16(strTextPagina);
                pagina = Convert.ToInt16(pagina - 1);
            } 
            else
            {
                pagina = 0;
            }

            // Si el combo de paginas está vacío, es porque es la primera vez que se carga la página
            if (cboPaginas.Items.Count == 0)
            {
                grvPrestamos.DataSource = objPrestamoBL.ListarPrestamos_Paginacion("", "", "", 0);
            }
            else
            {
                grvPrestamos.DataSource = objPrestamoBL.ListarPrestamos_Paginacion(codCli, codEmp, estado, pagina);
            }

            grvPrestamos.DataBind();

            // Obtenemos el número de registros
            Int16 intNumRegistros = objPrestamoBL.NumPag_ListarPrestamos_Paginacion(codCli, codEmp, estado);

            // Se carga el combo de páginas
            String strValue = cboPaginas.Text;
            cboPaginas.Items.Clear();

            if (intNumRegistros == 0)
            {
                // Si no hay registros
                cboPaginas.Items.Add("0");
                cboPaginas.SelectedIndex = 0;
            }
            else
            {
                // Si hay registros
                if (intNumRegistros % size == 0)
                {
                    numPag = Convert.ToInt16(intNumRegistros / size);
                }
                else
                {
                    numPag = Convert.ToInt16((intNumRegistros / size) + 1);
                }

                // Llenamos el combo
                for (int indice = 1; indice <= numPag; indice++)
                {
                    cboPaginas.Items.Add(indice.ToString());
                }
            }

            if (blnFlag == true)
            {
                cboPaginas.Text = strValue;
            }

            // Dormimos la aplicación por 2 segundos
            System.Threading.Thread.Sleep(1000);

        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                Filtrar(false);
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        protected void cboPaginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrar(true);
        }

        protected void grvPrestamos_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[11].Font.Bold = true;

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                switch (e.Row.Cells[11].Text)
                {
                    case "Por Aprobar":
                        e.Row.Cells[11].ForeColor = System.Drawing.Color.Orange;
                        break;
                    case "Aprobado":
                        e.Row.Cells[11].ForeColor = System.Drawing.Color.Green;
                        break;
                    case "Rechazado":
                        e.Row.Cells[11].ForeColor = System.Drawing.Color.Red;
                        break;
                    case "En Pago":
                        e.Row.Cells[11].ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "Cancelado":
                        e.Row.Cells[11].ForeColor = System.Drawing.Color.Black;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
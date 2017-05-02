using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace cedocabar.TerapiaResp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Session"] != null)
            {
                if (!IsPostBack)
                {
                    Button1.Enabled = false;                   
                    CargarGrid();
                }
            }
            else
            {

                string devuelveFecha = "<script language='JavaScript'>" +
                    "window.document.forms[0].target = '_parent'; window.document.forms[0].action = '../salida.aspx';" +
                    "window.document.forms[0].submit(); </script>";
                ClientScript.RegisterStartupScript(this.GetType(), "CambiaTarget", devuelveFecha);
            }
        }
        protected void Continuar(object sender, EventArgs e)
        {
            string idpac = vhpaciente.Value;
            string iddoc = vhdocumento.Value;
            Response.Redirect("ExamenF.aspx?idpac=" + idpac + "&iddoc=" + iddoc);
        }
        protected void Modificar(object sender, EventArgs e)
        {
            Response.Redirect("Modificar.aspx");
        }
        private void CargarGrid()
        {
            if (Session["Session"] != null)
            {
                string hmedico = (string)this.Session["hmedico"];
                string tipousuario = (string)this.Session["tipousuario"];
                DateTime dt = DateTime.Now;
                int d = dt.Day;
                int m = dt.Month;
                int y = dt.Year;
                string dia;
                string mes;
                if (d < 10)
                {
                    dia = "0" + Convert.ToString(d);
                }
                else
                {
                    dia = Convert.ToString(d);
                }
                if (m < 10)
                {
                    mes = "0" + Convert.ToString(m);
                }
                else
                {
                    mes = Convert.ToString(m);
                }
                string fecha = y + "-" + mes + "-" + dia;
                DBConnect conexion = new DBConnect();
                DataTable datos = new DataTable();
                if (tipousuario == "9")
                {
                    datos = conexion.SPacCardAD("16", hmedico, fecha);

                }
                else
                {
                    datos = conexion.SPacCardADADM("16", fecha);
                }
                if (datos.Rows.Count > 0)
                {
                    GridView1.DataSource = datos;
                    GridView1.DataBind();
                    GridView1.SelectedIndex = 0;
                }
                else
                {
                    DataTable datos2 = new DataTable();
                    DataColumn columna1 = new DataColumn("Numero");
                    DataColumn columna2 = new DataColumn("Nombre");
                    DataColumn columna3 = new DataColumn("Cedula");
                    DataColumn columna4 = new DataColumn("Edad");
                    DataColumn columna5 = new DataColumn("Sexo");
                    columna1.AllowDBNull = true;
                    columna2.AllowDBNull = true;
                    columna3.AllowDBNull = true;
                    columna4.AllowDBNull = true;
                    columna5.AllowDBNull = true;
                    datos2.Columns.Add(columna1);
                    datos2.Columns.Add(columna2);
                    datos2.Columns.Add(columna3);
                    datos2.Columns.Add(columna4);
                    datos2.Columns.Add(columna5);
                    DataRow dr = datos2.NewRow();
                    dr["Numero"] = null;
                    dr["Nombre"] = null;
                    dr["Cedula"] = null;
                    dr["Edad"] = null;
                    dr["Sexo"] = null;
                    datos2.Rows.Add(dr);
                    GridView1.DataSource = datos2;
                    GridView1.DataBind();
                    int TotalColumns = GridView1.Rows[0].Cells.Count;
                    GridView1.Rows[0].Cells.Clear();
                    GridView1.Rows[0].Cells.Add(new TableCell());
                    GridView1.Rows[0].Cells[0].ColumnSpan = TotalColumns;
                    GridView1.Rows[0].Cells[0].Text = "No existen pacientes por atender!!";
                }
            }
            else
            {

                string devuelveFecha = "<script language='JavaScript'>" +
                    "window.document.forms[0].target = '_parent'; window.document.forms[0].action = '../salida.aspx';" +
                    "window.document.forms[0].submit(); </script>";
                ClientScript.RegisterStartupScript(this.GetType(), "CambiaTarget", devuelveFecha);
            }            
        }
        protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            CargarGrid();
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
        protected void gridView_SelectedIndex(object sender, EventArgs e)
        {
            if (Session["Session"] != null)
            {
                string hmedico = (string)this.Session["hmedico"];
                string tipousuario = (string)this.Session["tipousuario"];
                DateTime dt = DateTime.Now;
                int d = dt.Day;
                int m = dt.Month;
                int y = dt.Year;
                string dia;
                string mes;
                if (d < 10)
                {
                    dia = "0" + Convert.ToString(d);
                }
                else
                {
                    dia = Convert.ToString(d);
                }
                if (m < 10)
                {
                    mes = "0" + Convert.ToString(m);
                }
                else
                {
                    mes = Convert.ToString(m);
                }
                string fecha = y + "-" + mes + "-" + dia;
                DBConnect conexion = new DBConnect();
                DataTable datos = new DataTable();
                Label Lblnumero = GridView1.Rows[Convert.ToInt32(GridView1.SelectedIndex.ToString())].FindControl("Lblnumero") as Label;
                Label Lblnombre = GridView1.Rows[Convert.ToInt32(GridView1.SelectedIndex.ToString())].FindControl("Lblnombre") as Label;
                Label Lblcedula = GridView1.Rows[Convert.ToInt32(GridView1.SelectedIndex.ToString())].FindControl("Lblcedula") as Label;
                Label Lbledad = GridView1.Rows[Convert.ToInt32(GridView1.SelectedIndex.ToString())].FindControl("Lbledad") as Label;
                Label Lblsexo = GridView1.Rows[Convert.ToInt32(GridView1.SelectedIndex.ToString())].FindControl("Lblsexo") as Label;
                string numero = Lblnumero.Text;
                string nombre = Lblnombre.Text;
                string cedula = Lblcedula.Text;
                string edad = Lbledad.Text;
                string sexo = Lblsexo.Text;
                string hdocumento = "";
                string hpaciente = "";
                if (tipousuario == "9")
                {
                    datos = conexion.SPacCardADIND(numero,"16", hmedico, fecha);
                    for (int i = 0; i < datos.Rows.Count; i++)
                    {
                        hdocumento = datos.Rows[i]["hdocumento"].ToString();
                        hpaciente = datos.Rows[i]["hpaciente"].ToString();
                    }
                }
                else
                {
                    datos = conexion.SPacCardADADMIND(numero,"16", fecha);
                    for (int i = 0; i < datos.Rows.Count; i++)
                    {
                        hdocumento = datos.Rows[i]["hdocumento"].ToString();
                        hpaciente = datos.Rows[i]["hpaciente"].ToString();
                    }
                }
                Button1.Enabled = true;
                Button2.Enabled = false;
                vhdocumento.Value = hdocumento;
                vhpaciente.Value = hpaciente;
            }
            else
            {

                string devuelveFecha = "<script language='JavaScript'>" +
                    "window.document.forms[0].target = '_parent'; window.document.forms[0].action = '../salida.aspx';" +
                    "window.document.forms[0].submit(); </script>";
                ClientScript.RegisterStartupScript(this.GetType(), "CambiaTarget", devuelveFecha);
            } 
        }
    }
}
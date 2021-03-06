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


namespace cedocabar.Facturacionp
{
	public partial class Default : System.Web.UI.Page
	{
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Session"] != null)
            {
                if (!IsPostBack)
                {
					factura.Enabled=false;
                    paciente.Disabled = true;
                    historia.Disabled = true;
                    string modal9 = "showPopWin('frmBPaciente.aspx', 550, 200,returnRefresh);";
                    BotonBuscar.Attributes.Add("onclick", modal9);
                    DBConnect conector = new DBConnect();
                    DataTable servicios = new DataTable();
                    servicios = conector.SPruebas();
                    ListItem opciont = new ListItem();
                    opciont.Text = "Seleccione";
                    opciont.Value = "0";
                    servicio.Items.Add(opciont);
                    for (int i = 0; i < servicios.Rows.Count; i++)
                    {
                        ListItem opciont2 = new ListItem();
                        opciont2.Text = servicios.Rows[i]["nombre"].ToString();
                        opciont2.Value = servicios.Rows[i]["id"].ToString();
                        servicio.Items.Add(opciont2);
                    }
                    servicio.DataBind();
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
        protected void callMedicoserv(object sender, EventArgs e)
        {
            DBConnect conector = new DBConnect();
            string codigo = conector.ScodPrueba(servicio.SelectedValue);
            string sqserv = conector.Snfactura(codigo);
            string nfactura = codigo.Trim() + "-" + sqserv.Trim();
            nfactura = nfactura.PadLeft(10, '0');
            factura.Text = nfactura;
        }
        protected void Buscarced(object sender, EventArgs e)
        {
            DBConnect conector = new DBConnect();
            string ced = cedula.Text.Trim();
            DataTable org_geog = new DataTable();
            org_geog = conector.Scedpaciente(ced);
            for (int i = 0; i < org_geog.Rows.Count; i++)
            {
                historia.Value = org_geog.Rows[i]["historia"].ToString();
                paciente.Value = org_geog.Rows[i]["nombre"].ToString();
                idpaciente.Value = org_geog.Rows[i]["id"].ToString();
            }
        }
        protected void Guardar(object sender, EventArgs e)
        {
            DBConnect conector = new DBConnect();
            string vservicio = servicio.SelectedValue;
            string vidpaciente = idpaciente.Value;
            int vasignados = conector.SVasignadosp(vidpaciente, vservicio);
            if ((vservicio == "0") || (vidpaciente == "") || (vasignados > 0))
            {
                if (vservicio == "0") { LblV5.Text = "*"; Label3.Text = "Faltan datos!! Verifique los campos marcados (*)"; }
                if (vidpaciente == "") { LblV2.Text = "*"; Label3.Text = "Faltan datos!! Verifique los campos marcados (*)"; }
                if (vasignados > 0) { LblV2.Text = "*"; Label3.Text = "Error el paciente ya tiene cupo asignado!!"; }
            }
            else
            {
                string iddoc = conector.insolprueba(factura.Text, idpaciente.Value, servicio.SelectedValue, "3", "0", observaciones.Text);
                Label3.Text = iddoc;
                Response.Redirect("Insert.aspx?iddoc=" + iddoc);
            }
        }	
	}
}


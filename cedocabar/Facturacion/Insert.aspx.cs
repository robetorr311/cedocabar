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

namespace cedocabar.Facturacion
{
    public partial class Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Session"] != null)
            {
                if (!IsPostBack)
                {
                    iddoc.Value = Server.HtmlEncode(Request.QueryString["iddoc"]);
                    DBConnect conector = new DBConnect();
                    DataTable DTdocumento = conector.SDocumento(iddoc.Value);
                    DataTable DTcupos = conector.Scupos(iddoc.Value);
                    string vfactura = "";
                    string vhservicio = "";
                    string vhistoria = "";
                    string vpaciente = "";
                    string vmedico = "";
                    string vfecha = "";
                    string vcedula = "";
                    string vnombre = "";
                    string vnommedico = "";
                    string vnomservicio = "";
                    string vhturno = "";
                    for (int i = 0; i < DTdocumento.Rows.Count; i++)
                    {
                        vfactura = DTdocumento.Rows[i]["numero"].ToString();
                        vhservicio = DTdocumento.Rows[i]["hdestino"].ToString();
                        vfecha = DTdocumento.Rows[i]["fecha"].ToString();
                        vmedico = DTdocumento.Rows[i]["hmedico"].ToString();
                        vpaciente = DTdocumento.Rows[i]["horigen"].ToString();
                    }
                    for (int i = 0; i < DTcupos.Rows.Count; i++)
                    {
                        vhturno = DTcupos.Rows[i]["hturno"].ToString();
                    }
                    factura.Text = vfactura;
                    DataTable DTpaciente = conector.Spaciente(vpaciente);
                    for (int j = 0; j < DTpaciente.Rows.Count; j++)
                    {
                        vhistoria = DTpaciente.Rows[j]["historia"].ToString();
                        vcedula = DTpaciente.Rows[j]["cedula"].ToString();
                        vnombre = DTpaciente.Rows[j]["nombre"].ToString();
                    }
                    paciente.Text = vnombre;
                    historia.Text = vhistoria;
                    DataTable DTmedico = conector.Smedicos(vmedico);
                    for (int k = 0; k < DTmedico.Rows.Count; k++)
                    {
                        vnommedico = DTmedico.Rows[k]["nombre"].ToString();
                    }
                    medico.Text = vnommedico;
                    DataTable DTservicio = conector.Sservicio_IND(vhservicio);
                    for (int l = 0; l < DTservicio.Rows.Count; l++)
                    {
                        vnomservicio = DTservicio.Rows[l]["nombre"].ToString();
                    }
                    servicio.Text = vnomservicio;
                    string dia = vfecha.Substring(0, 2);
                    string mes = vfecha.Substring(3, 2);
                    string anio = vfecha.Substring(6, 4);
                    string vnfecha = anio + "-" + mes + "-" + dia;
                    fecha.Text = vnfecha;
                    numero.Text = conector.Snumerocupo(vhservicio, vmedico, vnfecha, vpaciente);
                    hora.Text = conector.SHORA(vhservicio, vmedico, vhturno);
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
        protected void Finalizar(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

    }
}
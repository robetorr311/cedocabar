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

namespace cedocabar.MedicinaInterna
{
    public partial class Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Session"] != null)
            {
                if (!IsPostBack)
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
                    vfecha.Value = fecha;
                    DBConnect conexion = new DBConnect();
                    vhdocumento.Value = Server.HtmlEncode(Request.QueryString["iddoc"]);
                    vhpaciente.Value = Server.HtmlEncode(Request.QueryString["idpac"]);
                    videx.Value = Server.HtmlEncode(Request.QueryString["idex"]);
                    vidmorb.Value = Server.HtmlEncode(Request.QueryString["idmorb"]);
                    DataTable paciente = new DataTable();
                    paciente = conexion.Spaciente(vhpaciente.Value);
                    string strhistoria = "";
                    string strnombre = "";
                    string stredad = "";
                    string strsexo = "";
                    string strcedula = "";
                    for (int i = 0; i < paciente.Rows.Count; i++)
                    {
                        strhistoria = paciente.Rows[i]["historia"].ToString();
                        strnombre = paciente.Rows[i]["nombre"].ToString();
                        stredad = paciente.Rows[i]["edad"].ToString();
                        strsexo = paciente.Rows[i]["sexo"].ToString();
                        strcedula = paciente.Rows[i]["cedula"].ToString();
                    }
                    historia.Text = strhistoria;
                    nombre.Text = strnombre;
                    edad.Text = stredad;
                    sexo.Text = strsexo;
                    cedula.Text = strcedula;
                    DataTable examenf = new DataTable();
                    examenf = conexion.SExamenf(videx.Value);
                    string strta = "";
                    string strfc = "";
                    string strfr = "";
                    string strpeso = "";
                    string strtalla = "";
                    string strtemperatura = "";
                    string strecg = "";
                    string straspecto = "";
                    for (int i = 0; i < examenf.Rows.Count; i++)
                    {
                        strta = examenf.Rows[i]["tensionarterial"].ToString();
                        strfc = examenf.Rows[i]["frecuenciacardiaca"].ToString();
                        strfr = examenf.Rows[i]["frecuenciarespiratoria"].ToString();
                        strpeso = examenf.Rows[i]["peso"].ToString();
                        strtalla = examenf.Rows[i]["talla"].ToString();
                        strtemperatura = examenf.Rows[i]["temperatura"].ToString();
                        strecg = examenf.Rows[i]["electrocardiograma"].ToString();
                        straspecto = examenf.Rows[i]["aspecto"].ToString();
                    }
                    ta.Text = strta;
                    fc.Text = strfc;
                    fr.Text = strfr;
                    peso.Text = strpeso;
                    talla.Text = strtalla;
                    temperatura.Text = strtemperatura;
                    aspecto.Text = straspecto;
                    DataTable morbilidad = new DataTable();
                    morbilidad = conexion.Smedicinainterna(vidmorb.Value);
                    string strdiagnostico = "";
                    string strtratamiento = "";
                    for (int i = 0; i < examenf.Rows.Count; i++)
                    {
                        strdiagnostico = morbilidad.Rows[i]["diagnostico"].ToString();
                        strtratamiento = morbilidad.Rows[i]["tratamiento"].ToString();
                    }
                    diagnostico.Text = strdiagnostico;
                    tratamiento.Text = strtratamiento;
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
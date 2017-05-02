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

namespace cedocabar.CardiologiaInf
{
    public partial class Morbilidad : System.Web.UI.Page
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
                    ta.Text = Server.HtmlEncode(Request.QueryString["ta"]); ;
                    fc.Text = Server.HtmlEncode(Request.QueryString["fc"]); ;
                    fr.Text = Server.HtmlEncode(Request.QueryString["fr"]); ;
                    peso.Text = Server.HtmlEncode(Request.QueryString["peso"]); ;
                    talla.Text = Server.HtmlEncode(Request.QueryString["talla"]); ;
                    temperatura.Text = Server.HtmlEncode(Request.QueryString["temperatura"]); ;
                    aspecto.Text = Server.HtmlEncode(Request.QueryString["aspecto"]); ;
                    string modal9 = "showPopWin('DatosPaciente.aspx?hpaciente="+ vhpaciente.Value + "', 800, 400);";
                    Button2.Attributes.Add("onclick", modal9);
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
            if ((diagnostico.Text == "") || (tratamiento.Text == ""))
            {
                if (diagnostico.Text == "") { Label13.Text = "*"; }
                if (tratamiento.Text == "") { Label5.Text = "*"; }
                Label2.Text = "Faltan datos verifique los campos marcados (*)";
            }
            else
            {
                DBConnect conexion = new DBConnect();
                conexion.uEnEpera(idpac);
                conexion.uEnProceso(iddoc);
                conexion.uEnConsulta(idpac);
                string idexamenf = conexion.insexamenf(idpac, vfecha.Value, ta.Text, fc.Text, fr.Text, peso.Text, talla.Text, temperatura.Text, "archivo", aspecto.Text, iddoc,"3","NULL");
                string hmedico = (string)this.Session["hmedico"];
                string idmorb = conexion.imorbilidad(idpac, motivo.Text, enfermedad.Text, diagnostico.Text, tratamiento.Text, iddoc, idexamenf, hmedico);
                conexion.uProcesado(iddoc);
                Response.Redirect("Insert.aspx?idpac=" + idpac + "&iddoc=" + iddoc + "&idex=" + idexamenf + "&idmorb=" + idmorb);
            }
        }
        protected void Cancelar(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}
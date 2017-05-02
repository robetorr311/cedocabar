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
    public partial class ExamenF : System.Web.UI.Page
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
            if ((ta.Text == "") || (fc.Text == "") || (fr.Text == "") || (peso.Text == "") || (talla.Text == "") || (temperatura.Text == ""))
            {
                if (ta.Text == "") { Label13.Text = "*"; }
                if (fc.Text == "") { Label5.Text = "*"; }
                if (fr.Text == "") { Label7.Text = "*"; }
                if (peso.Text == "") { Label4.Text = "*"; }
                if (talla.Text == "") { Label8.Text = "*"; }
                if (temperatura.Text == "") { Label11.Text = "*"; }
                if (aspecto.Text == "") { Label6.Text = "*"; }
                Label2.Text = "Faltan datos verifique los campos marcados (*)";
            }
            else
            {
                DBConnect conexion = new DBConnect();
                Response.Redirect("Morbilidad.aspx?idpac=" + idpac + 
                                                  "&iddoc=" + iddoc + 
                                                  "&ta=" + ta.Text +
                                                  "&fc=" + fc.Text +
                                                  "&fr=" + fr.Text +
                                                  "&peso=" + peso.Text +
                                                  "&talla=" + talla.Text +
                                                  "&temperatura=" + temperatura.Text +
                                                  "&sao2=" + sao2.Text +
                                                  "&aspecto=" + aspecto.Text);
            }        
        }
        protected void Cancelar(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}
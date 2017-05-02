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
namespace cedocabar
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Session"] != null)
            {
                Server.Transfer("Menu/Menu.aspx");
            }
            else
            {
                DBConnect conector = new DBConnect();
                DataTable servicios = new DataTable();
                servicios = conector.Stipousuario();
                ListItem opciont = new ListItem();
                opciont.Text = "Seleccione";
                opciont.Value = "0";
                tipousuario.Items.Add(opciont);
                for (int i = 0; i < servicios.Rows.Count; i++)
                {
                    ListItem opciont2 = new ListItem();
                    opciont2.Text = servicios.Rows[i]["nombre"].ToString();
                    opciont2.Value = servicios.Rows[i]["id"].ToString();
                    tipousuario.Items.Add(opciont2);
                }
                tipousuario.DataBind();
            }
        }
        protected void Ingresar(object sender, EventArgs e)
        {         
            DBConnect conector = new DBConnect();
            DataTable usuarios = new DataTable();
            DataTable medicos = new DataTable();
            if (tipousuario.SelectedValue == "9")
            {
                medicos = conector.Susuariosmedico(Loggin.Text, Password.Text);
                int rec = medicos.Rows.Count;
                if (rec == 0)
                {
                    Response.Redirect("denegado.aspx");
                }
                else
                {
                    string nombusuario = medicos.Rows[0]["loggin"].ToString();
                    string passusuario = medicos.Rows[0]["password"].ToString();
                    string nivel = "2";
                    string nombre = medicos.Rows[0]["nombre"].ToString();
                    string hmedico = medicos.Rows[0]["id"].ToString();
                    this.Session["Session"] = "1";
                    this.Session["Us"] = nombusuario;
                    this.Session["Nbr"] = nombre;
                    this.Session["Nvl"] = nivel;
                    this.Session["pwd"] = passusuario;
                    this.Session["hmedico"] = hmedico;
                    this.Session["tipousuario"] = tipousuario.SelectedValue;
                    this.Session.Timeout = 60;
                    Server.Transfer("Menu/Menu.aspx");
                }
            }
            else
            {
                usuarios = conector.Susuarios(Loggin.Text, Password.Text);
                int rec = usuarios.Rows.Count;
                if (rec == 0)
                {
                    Response.Redirect("denegado.aspx");
                }
                else
                {

                    string nombusuario = usuarios.Rows[0]["loggin"].ToString();
                    string passusuario = usuarios.Rows[0]["password"].ToString();
                    string nivel = usuarios.Rows[0]["hnivel"].ToString();
                    string nombre = usuarios.Rows[0]["nombre"].ToString();
                    string hdepartamento = usuarios.Rows[0]["hdepartamento"].ToString();
                    string htipousuario = usuarios.Rows[0]["htipousuario"].ToString();
                    if (htipousuario != tipousuario.SelectedValue)
                    {
                        Response.Redirect("denegado.aspx");
                    }
                    else
                    {
                        this.Session["Session"] = "1";
                        this.Session["Us"] = nombusuario;
                        this.Session["Nbr"] = nombre;
                        this.Session["Nvl"] = nivel;
                        this.Session["hdep"] = hdepartamento;
                        this.Session["pwd"] = passusuario;
                        this.Session["tipousuario"] = tipousuario.SelectedValue;
                        this.Session.Timeout = 60;
                        Server.Transfer("Menu/Menu.aspx");
                    }
                }
            }
        }

    }
}

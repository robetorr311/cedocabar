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
    public partial class DatosPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Session"] != null)
            {
                if (!IsPostBack)
                {
                    DBConnect conector = new DBConnect();
                    string id = Server.HtmlEncode(Request.QueryString["hpaciente"]);
                    HiddenField1.Value = id;
                    string modal9 = "showPopWin('org_geografica.aspx', 600, 200);";
                    string modal10 = "showPopWin('herencia.aspx?form=" + "herp" + "', 600, 200);";
                    string modal11 = "showPopWin('herencia.aspx?form=" + "herm" + "', 600, 200);";
                    string modal12 = "showPopWin('herencia.aspx?form=" + "herh" + "', 600, 200);";
                    string modal13 = "showPopWin('Antecedentes.aspx?form=antec&hpaciente="+ id +"', 750, 350);";
                    string modal15 = "showPopWin('ExamenesPrev.aspx?form=examp&hpaciente=" + id + "', 750, 350);";
                    string modal16 = "showPopWin('ConsultasPrev.aspx?form=cons&hpaciente=" + id + "', 750, 350);";
                    string modal14 = "window.parent.hidePopWin();";
                    Button2.Attributes.Add("onclick", modal9);
                    herenciap.Attributes.Add("onclick", modal10);
                    herenciam.Attributes.Add("onclick", modal11);
                    herenciah.Attributes.Add("onclick", modal12);
                    Button6.Attributes.Add("onclick", modal15);
                    Button7.Attributes.Add("onclick", modal16);
                    Button5.Attributes.Add("onclick", modal13);
                    Button4.Attributes.Add("onclick", modal14);
                    ListItem opcions = new ListItem();
                    opcions.Text = "Seleccione";
                    opcions.Value = "0";
                    ListItem opcionm = new ListItem();
                    opcionm.Text = "Masculino";
                    opcionm.Value = "M";
                    ListItem opcionf = new ListItem();
                    opcionf.Text = "Femenino";
                    opcionf.Value = "F";
                    sexo.Items.Add(opcions);
                    sexo.Items.Add(opcionm);
                    sexo.Items.Add(opcionf);
                    DataTable listado = conector.SConyugal();
                    ListItem opcionc = new ListItem();
                    opcionc.Text = "Seleccione";
                    opcionc.Value = "0";
                    conyugal.Items.Add(opcionc);
                    for (int i = 0; i < listado.Rows.Count; i++)
                    {
                        ListItem opcionc2 = new ListItem();
                        opcionc2.Text = listado.Rows[i]["nombre"].ToString();
                        opcionc2.Value = listado.Rows[i]["id"].ToString();
                        conyugal.Items.Add(opcionc2);
                    }
                    conyugal.DataBind();
                    DataTable listado2 = conector.SOcupacion();
                    ListItem opciono = new ListItem();
                    opciono.Text = "Seleccione";
                    opciono.Value = "0";
                    ocupacion.Items.Add(opciono);
                    for (int i = 0; i < listado2.Rows.Count; i++)
                    {
                        ListItem opciono2 = new ListItem();
                        opciono2.Text = listado2.Rows[i]["nombre"].ToString();
                        opciono2.Value = listado2.Rows[i]["id"].ToString();
                        ocupacion.Items.Add(opciono2);
                    }
                    ocupacion.DataBind();
                    string ReGhistoria = "";
                    string ReGcedula = "";
                    string ReGnombre = "";
                    string ReGfechanac = "";
                    string ReGedad = "";
                    string ReGsexo = "";
                    string ReGdireccion = "";
                    string ReGcorreo = "";
                    string ReGtelefonov = "";
                    string ReGtelefonom = "";
                    string ReGorg_geografica = "";
                    string ReGnum_region = "";
                    string ReGherenciap = "";
                    string ReGherenciam = "";
                    string ReGherenciah = "";
                    string ReGtabaquismo = "";
                    string ReGprofesion = "";
                    string ReGhprofesion = "";
                    string ReGestadocivil = "";
                    string ReGhestadocivil = "";
                    string ReGestatus = "";
                DataTable paciente = conector.Spaciente(id);
                if (paciente.Rows.Count > 0)
                {
                    for (int dd = 0; dd < paciente.Rows.Count; dd++)
                    {
                        ReGhistoria = paciente.Rows[dd]["historia"].ToString();
                        ReGcedula = paciente.Rows[dd]["cedula"].ToString();
                        ReGnombre = paciente.Rows[dd]["nombre"].ToString();
                        ReGfechanac = paciente.Rows[dd]["fecha"].ToString();
                        ReGedad = paciente.Rows[dd]["edad"].ToString();
                        ReGsexo = paciente.Rows[dd]["sexo"].ToString();
                        ReGdireccion = paciente.Rows[dd]["direcciondomicilio"].ToString();
                        ReGcorreo = paciente.Rows[dd]["correo"].ToString();
                        ReGtelefonov = paciente.Rows[dd]["telefonodomicilio"].ToString();
                        ReGtelefonom = paciente.Rows[dd]["telefono_m"].ToString();
                        ReGorg_geografica = paciente.Rows[dd]["region"].ToString();
                        ReGnum_region = conector.Snum_region(ReGorg_geografica);
                        ReGherenciap = paciente.Rows[dd]["herenciapadre"].ToString();
                        ReGherenciam = paciente.Rows[dd]["herenciamadre"].ToString();
                        ReGherenciah = paciente.Rows[dd]["herenciahermanos"].ToString();
                        ReGtabaquismo = paciente.Rows[dd]["tabaquismo"].ToString();
                        ReGprofesion = paciente.Rows[dd]["profesion"].ToString();
                        ReGestadocivil = paciente.Rows[dd]["conyugal"].ToString();
                        ReGestatus = paciente.Rows[dd]["estatus"].ToString();
                        ReGhprofesion = conector.Shprofesion(ReGprofesion);
                        ReGhestadocivil = conector.Shconyugal(ReGestadocivil);
                    }
                }
                    historia.Disabled = true;
                    cedula.Disabled = true;
                    nombre.Disabled = true;
                    ocupacion.Enabled = false;
                    conyugal.Enabled = false;
                    edad.Disabled = true;
                    sexo.Enabled = false;
                    dateArrival.Disabled = true;
                    direccion.Enabled = false;
                    Button2.Disabled = true;
                    TextBox1.Disabled = true;
                    telefonof.Disabled = true;
                    telefonom.Disabled = true;
                    correo.Disabled = true;
                    herenciap.Disabled = true;
                    herenciam.Disabled = true;
                    herenciah.Disabled = true;
                    tabaquismo0.Disabled = true;
                    tabaquismo1.Disabled = true;
                    Button3.Visible = false;
                    VerRegistro(
                                 ReGhistoria,
                                 ReGcedula,
                                 ReGnombre,
                                 ReGfechanac,
                                 ReGedad,
                                 ReGsexo,
                                 ReGdireccion,
                                 ReGcorreo,
                                 ReGtelefonov,
                                 ReGtelefonom,
                                 ReGorg_geografica,
                                 ReGnum_region,
                                 ReGherenciap,
                                 ReGherenciam,
                                 ReGherenciah,
                                 ReGtabaquismo,
                                 ReGprofesion,
                                 ReGhprofesion,
                                 ReGestadocivil,
                                 ReGhestadocivil,
                                 ReGestatus
                                 );
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
        protected string acentos(string cadena)
        {
            string valora = cadena.Replace("&#225;", "á");
            string valorA = valora.Replace("&#193;", "Á");
            string valore = valorA.Replace("&#233;", "é");
            string valorE = valore.Replace("&#201;", "É");
            string valori = valorE.Replace("&#237;", "í");
            string valorI = valori.Replace("&#205;", "Í");
            string valoro = valorI.Replace("&#243;", "ó");
            string valorO = valoro.Replace("&#211;", "Ó");
            string valoru = valorO.Replace("&#250;", "ú");
            string valorU = valoru.Replace("&#218;", "Ú");
            return valorU;
        }
        private void VerRegistro(string ReGhistoria,
                             string ReGcedula,
                             string ReGnombre,
                             string ReGfechanac,
                             string ReGedad,
                             string ReGsexo,
                             string ReGdireccion,
                             string ReGcorreo,
                             string ReGtelefonov,
                             string ReGtelefonom,
                             string ReGorg_geografica,
                             string ReGnum_region,
                             string ReGherenciap,
                             string ReGherenciam,
                             string ReGherenciah,
                             string ReGtabaquismo,
                             string ReGprofesion,
                             string ReGhprofesion,
                             string ReGestadocivil,
                             string ReGhestadocivil,
                             string ReGestatus)
        {
            historia.Value = ReGhistoria;
            cedula.Value = ReGcedula;
            nombre.Value = ReGnombre;
            dateArrival.Value = ReGfechanac;
            edad.Value = ReGedad;
            sexo.SelectedValue = ReGsexo;
            if (ReGsexo == "M")
            {
                sexo.SelectedItem.Text = "Masculino";
            }
            else
            {
                sexo.SelectedItem.Text = "Femenino";
            }
            direccion.Text = ReGdireccion;
            correo.Value = ReGcorreo;
            telefonof.Value = ReGtelefonov;
            telefonom.Value = ReGtelefonom;
            TextBox1.Value = ReGorg_geografica;
            num_region.Value = ReGnum_region;
            herenciap.Value = ReGherenciap;
            herenciam.Value = ReGherenciam;
            herenciah.Value = ReGherenciah;
            ocupacion.SelectedItem.Text = ReGprofesion;
            ocupacion.SelectedValue = ReGhprofesion;
            conyugal.SelectedItem.Text = ReGestadocivil;
            conyugal.SelectedValue = ReGhestadocivil;
            if (ReGtabaquismo == "S")
            {
                tabaquismo0.Checked = false;
                tabaquismo1.Checked = true;
            }
            else
            {
                tabaquismo0.Checked = true;
                tabaquismo1.Checked = false;
            }
            historia.Disabled = true;
            cedula.Disabled = true;
            nombre.Disabled = true;
            ocupacion.Enabled = false;
            conyugal.Enabled = false;
            edad.Disabled = true;
            sexo.Enabled = false;
            dateArrival.Disabled = true;
            direccion.Enabled = false;
            Button2.Disabled = true;
            TextBox1.Disabled = true;
            telefonof.Disabled = true;
            telefonom.Disabled = true;
            correo.Disabled = true;
            herenciap.Disabled = true;
            herenciam.Disabled = true;
            herenciah.Disabled = true;
            tabaquismo0.Disabled = true;
            tabaquismo1.Disabled = true;
            Button3.Visible = false;
        }
        protected void Modificar(object sender, EventArgs e)
        {
            DBConnect conector = new DBConnect();
            historia.Disabled = false;
            cedula.Disabled = false;
            nombre.Disabled = false;
            ocupacion.Enabled = true;
            conyugal.Enabled = true;
            edad.Disabled = false;
            sexo.Enabled = true;
            dateArrival.Disabled = false;
            direccion.Enabled = true;
            Button2.Disabled = false;
            TextBox1.Disabled = false;
            telefonof.Disabled = false;
            telefonom.Disabled = false;
            correo.Disabled = false;
            herenciap.Disabled = false;
            herenciam.Disabled = false;
            herenciah.Disabled = false;
            tabaquismo0.Disabled = false;
            tabaquismo1.Disabled = false;
            Button3.Visible = true;
        }
        protected void Actualizar(object sender, EventArgs e)
        {
            DBConnect conector = new DBConnect();
            string tabaco = "";
            if (tabaquismo0.Checked == true)
            {
                tabaco = "N";
            }
            if (tabaquismo1.Checked == true)
            {
                tabaco = "S";
            }
            if ((historia.Value == "") ||
                (cedula.Value == "") ||
                (nombre.Value == "") ||
                (dateArrival.Value == "") ||
                (edad.Value == "") ||
                (sexo.SelectedValue == "0") ||
                (direccion.Text == "") ||
                (correo.Value == "") ||
                (telefonof.Value == "") ||
                (telefonom.Value == "") ||
                (num_region.Value == "") ||
                (herenciap.Value == "") ||
                (herenciam.Value == "") ||
                (herenciah.Value == "") ||
                (ocupacion.SelectedValue == "0") ||
                (conyugal.SelectedValue == "0") ||
                (tabaco == ""))
            {
                if (historia.Value == "") { historia.Attributes.Add("class", "campoerror"); Label9.Text = "*"; }
                if (cedula.Value == "") { cedula.Attributes.Add("class", "campoerror"); LblV1.Text = "*"; }
                if (nombre.Value == "") { nombre.Attributes.Add("class", "campoerror"); LblV2.Text = "*"; }
                if (dateArrival.Value == "") { dateArrival.Attributes.Add("class", "campoerror"); Label2.Text = "*"; }
                if (edad.Value == "") { edad.Attributes.Add("class", "campoerror"); Label3.Text = "*"; }
                if (sexo.SelectedValue == "0") { sexo.Attributes.Add("CssClass", "campoerror"); Label4.Text = "*"; }
                if (direccion.Text == "") { direccion.Attributes.Add("CssClass", "campoerror"); LblV8.Text = "*"; }
                if (correo.Value == "") { correo.Attributes.Add("class", "campoerror"); Label5.Text = "*"; }
                if (telefonof.Value == "") { telefonof.Attributes.Add("class", "campoerror"); LblV6.Text = "*"; }
                if (telefonom.Value == "") { telefonom.Attributes.Add("class", "campoerror"); LblV7.Text = "*"; }
                if (num_region.Value == "") { LblV9.Text = "*"; }
                if (herenciap.Value == "") { herenciap.Attributes.Add("class", "campoerror"); Label6.Text = "*"; }
                if (herenciam.Value == "") { herenciam.Attributes.Add("class", "campoerror"); Label7.Text = "*"; }
                if (herenciah.Value == "") { herenciah.Attributes.Add("class", "campoerror"); Label8.Text = "*"; }
                if (ocupacion.SelectedValue == "0") { ocupacion.Attributes.Add("CssClass", "campoerror"); Label13.Text = "*"; }
                if (conyugal.SelectedValue == "0") { conyugal.Attributes.Add("CssClass", "campoerror"); Label12.Text = "*"; }
                if (tabaco == "") { Label10.Text = "*"; }
                Label14.Attributes.Add("CssClass", "alerta");
                Label14.Text = "Faltan Datos!!! Complete la información para poder Guardar el Registro!!";
            }
            else
            {
                Label14.Text = conector.upacientes(HiddenField1.Value,
                                    historia.Value,
                                    cedula.Value,
                                    nombre.Value,
                                    dateArrival.Value.Substring(0, 10),
                                    edad.Value,
                                    sexo.SelectedValue,
                                    direccion.Text,
                                    correo.Value,
                                    telefonof.Value,
                                    telefonom.Value,
                                    num_region.Value,
                                    herenciap.Value,
                                    herenciam.Value,
                                    herenciah.Value,
                                    ocupacion.SelectedValue,
                                    conyugal.SelectedValue,
                                    tabaco,
                                    "6");
                historia.Disabled = true;
                cedula.Disabled = true;
                nombre.Disabled = true;
                ocupacion.Enabled = false;
                conyugal.Enabled = false;
                edad.Disabled = true;
                sexo.Enabled = false;
                dateArrival.Disabled = true;
                direccion.Enabled = false;
                Button2.Disabled = true;
                TextBox1.Disabled = true;
                telefonof.Disabled = true;
                telefonom.Disabled = true;
                correo.Disabled = true;
                herenciap.Disabled = true;
                herenciam.Disabled = true;
                herenciah.Disabled = true;
                tabaquismo0.Disabled = true;
                tabaquismo1.Disabled = true;
                Button3.Visible = false;
            }
        }

    }
}
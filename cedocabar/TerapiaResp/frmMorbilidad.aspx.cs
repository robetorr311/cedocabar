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
    public partial class frmMorbilidad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DBConnect conexion = new DBConnect();
                string hpaciente = Server.HtmlEncode(Request.QueryString["hpaciente"]);
                string hmorbilidad = Server.HtmlEncode(Request.QueryString["hmorbilidad"]);
                vhpaciente.Value = hpaciente;
                vidmorb.Value = hmorbilidad;
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
                DataTable morbilidad = new DataTable();
                morbilidad = conexion.Sterapiaresp(vidmorb.Value);
                string strdiagnostico = "";
                string strsugerencias = "";
                string strterapia = "";
                string strejercicios = "";
                string strespirometria = "";
                string strinhaloterapia = "";
                string strtecnicas = "";
                string strentrenamiento = "";
                string strhexamenf = "";
                for (int i = 0; i < morbilidad.Rows.Count; i++)
                {
                    strdiagnostico = morbilidad.Rows[i]["diagnostico"].ToString();
                    strterapia = morbilidad.Rows[i]["fisioterapiatorax"].ToString();
                    strejercicios = morbilidad.Rows[i]["ejerciciosrespiratorios"].ToString();
                    strespirometria = morbilidad.Rows[i]["espirometriaincentiva"].ToString();
                    strinhaloterapia = morbilidad.Rows[i]["inhaloterapia"].ToString();
                    strtecnicas = morbilidad.Rows[i]["tecnicasrelajacion"].ToString();
                    strentrenamiento = morbilidad.Rows[i]["entrenamientofisico"].ToString();
                    strsugerencias = morbilidad.Rows[i]["sugerencias"].ToString();
                    strhexamenf = morbilidad.Rows[i]["hexamenfisico"].ToString();
                    videx.Value = strhexamenf;
                }
                diagnostico.Text = strdiagnostico;
                terapia.Text = strterapia;
                ejercicios.Text = strejercicios;
                inhaloterapia.Text = strinhaloterapia;
                espirometria.Text = strespirometria;
                tecnicas.Text = strtecnicas;
                entrenamiento.Text = strentrenamiento;
                sugerencias.Text = strsugerencias;
                DataTable examenf = new DataTable();
                examenf = conexion.SExamenf(strhexamenf);
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
                ta.Enabled = false;
                fc.Enabled = false;
                fr.Enabled = false;
                peso.Enabled = false;
                talla.Enabled = false;
                temperatura.Enabled = false;
                aspecto.Enabled = false;
                diagnostico.Enabled = false;
                terapia.Enabled = false;
                ejercicios.Enabled = false;
                inhaloterapia.Enabled = false;
                espirometria.Enabled = false;
                tecnicas.Enabled = false;
                entrenamiento.Enabled = false;
                sugerencias.Enabled = false;
                Button1.Visible = true;
                Button2.Visible = false;
                Button3.Visible = true;
            }
        }
        protected void Modificar(object sender, EventArgs e)
        {
            ta.Enabled = true;
            fc.Enabled = true;
            fr.Enabled = true;
            peso.Enabled = true;
            talla.Enabled = true;
            temperatura.Enabled = true;
            aspecto.Enabled = true;
            diagnostico.Enabled = true;
            terapia.Enabled = true;
            ejercicios.Enabled = true;
            inhaloterapia.Enabled = true;
            espirometria.Enabled = true;
            tecnicas.Enabled = true;
            entrenamiento.Enabled = true;
            sugerencias.Enabled = true;
            Button1.Visible = false;
            Button2.Visible = true;
            Button3.Visible = false; 
        }
        protected void Actualizar(object sender, EventArgs e)
        {
            DBConnect conexion = new DBConnect();
            string sql1=conexion.uexamenf(videx.Value, ta.Text, fc.Text, fr.Text, peso.Text, talla.Text, temperatura.Text, aspecto.Text);
            string sql2 = conexion.uterapiaresp(vidmorb.Value, diagnostico.Text,sugerencias.Text,terapia.Text,ejercicios.Text,espirometria.Text,inhaloterapia.Text,tecnicas.Text,entrenamiento.Text);
            //Label2.Text = sql1 + " " + sql2;
            ta.Enabled = false;
            fc.Enabled = false;
            fr.Enabled = false;
            peso.Enabled = false;
            talla.Enabled = false;
            temperatura.Enabled = false;
            aspecto.Enabled = false;
            diagnostico.Enabled = false;
            terapia.Enabled = false;
            ejercicios.Enabled = false;
            inhaloterapia.Enabled = false;
            espirometria.Enabled = false;
            tecnicas.Enabled = false;
            entrenamiento.Enabled = false;
            sugerencias.Enabled = false;
            Button1.Visible = true;
            Button2.Visible = false;
            Button3.Visible = true;
        }
        protected void Finalizar(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}
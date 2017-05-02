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
    public partial class ConsultasPrev : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                vhpaciente.Value = Server.HtmlEncode(Request.QueryString["hpaciente"]);
                string modal14 = "window.parent.hidePopWin();";
                Button4.Attributes.Add("onclick", modal14);
                diagnostico.Enabled = false;
                terapia.Enabled = false;
                ejercicios.Enabled = false;
                inhaloterapia.Enabled = false;
                espirometria.Enabled = false;
                tecnicas.Enabled = false;
                entrenamiento.Enabled = false;
                sugerencias.Enabled = false;
                FillCustomerInGrid();
                GridView1.Enabled = true;
            }

        }
        private void FillCustomerInGrid()
        {
            DBConnect conector = new DBConnect();
            DataTable datos = conector.Svterapiaresp(vhpaciente.Value);
            if (datos.Rows.Count > 0)
            {
                GridView1.DataSource = datos;
                GridView1.DataBind();
            }
            else
            {
                datos.Rows.Add(datos.NewRow());
                GridView1.DataSource = datos;
                GridView1.DataBind();
                int TotalColumns = GridView1.Rows[0].Cells.Count;
                GridView1.Rows[0].Cells.Clear();
                GridView1.Rows[0].Cells.Add(new TableCell());
                GridView1.Rows[0].Cells[0].ColumnSpan = TotalColumns;
                GridView1.Rows[0].Cells[0].Text = "No se encontraron registros";
            }
        }
        protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            FillCustomerInGrid();
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
        protected void gridView_SelectedIndex(object sender, EventArgs e)
        {
            Label LblID = GridView1.Rows[Convert.ToInt32(GridView1.SelectedIndex.ToString())].FindControl("LblID") as Label;
            ImageButton ImageButton5 = (ImageButton)GridView1.Rows[GridView1.SelectedRow.RowIndex].FindControl("ImageButton5");
            ImageButton5.Enabled = true;
            HiddenField1.Value = LblID.Text;
        }
        protected void Save(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Registro"))
            {
                string strdiagnostico = "";
                string strsugerencias = "";
                string strterapia = "";
                string strejercicios = "";
                string strespirometria = "";
                string strinhaloterapia = "";
                string strtecnicas = "";
                string strentrenamiento = "";
                DBConnect conector = new DBConnect();
                string id = HiddenField1.Value;
                DataTable paciente = conector.Sterapiaresp(id);
                if (paciente.Rows.Count > 0)
                {
                    for (int i = 0; i < paciente.Rows.Count; i++)
                    {
                        strdiagnostico = paciente.Rows[i]["diagnostico"].ToString();
                        strterapia = paciente.Rows[i]["fisioterapiatorax"].ToString();
                        strejercicios = paciente.Rows[i]["ejerciciosrespiratorios"].ToString();
                        strespirometria = paciente.Rows[i]["espirometriaincentiva"].ToString();
                        strinhaloterapia = paciente.Rows[i]["inhaloterapia"].ToString();
                        strtecnicas = paciente.Rows[i]["tecnicasrelajacion"].ToString();
                        strentrenamiento = paciente.Rows[i]["entrenamientofisico"].ToString();
                        strsugerencias = paciente.Rows[i]["sugerencias"].ToString();
                    }
                    diagnostico.Text = strdiagnostico;
                    terapia.Text = strterapia;
                    ejercicios.Text = strejercicios;
                    inhaloterapia.Text = strinhaloterapia;
                    espirometria.Text = strespirometria;
                    tecnicas.Text = strtecnicas;
                    entrenamiento.Text = strentrenamiento;
                    sugerencias.Text = strsugerencias;
                }
                VerRegistro(strdiagnostico,
                 strsugerencias,
                 strterapia,
                 strejercicios,
                 strespirometria,
                 strinhaloterapia,
                 strtecnicas,
                 strentrenamiento);

            }
            if (e.CommandName.Equals("Add"))
            {
                DBConnect conector = new DBConnect();
                FillCustomerInGrid();
            }
        }
        private void VerRegistro(string strdiagnostico, 
                string strsugerencias,
                string strterapia,
                string strejercicios,
                string strespirometria,
                string strinhaloterapia ,
                string strtecnicas ,
                string strentrenamiento)
        {
            diagnostico.Text = strdiagnostico;
            terapia.Text = strterapia;
            ejercicios.Text = strejercicios;
            inhaloterapia.Text = strinhaloterapia;
            espirometria.Text = strespirometria;
            tecnicas.Text = strtecnicas;
            entrenamiento.Text = strentrenamiento;
            sugerencias.Text = strsugerencias;
            GridView1.Enabled = false;
        }
    }
}
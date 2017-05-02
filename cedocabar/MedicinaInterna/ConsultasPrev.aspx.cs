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
                tratamiento.Enabled = false;
                FillCustomerInGrid();
                GridView1.Enabled = true;
            }

        }
        private void FillCustomerInGrid()
        {
            DBConnect conector = new DBConnect();
            DataTable datos = conector.Svmedicinainterna(vhpaciente.Value);
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
                string ReGdiagnostico = "";
                string ReGtratamiento = "";
                DBConnect conector = new DBConnect();
                string id = HiddenField1.Value;
                DataTable paciente = conector.Smedicinainterna(id);
                if (paciente.Rows.Count > 0)
                {
                    for (int dd = 0; dd < paciente.Rows.Count; dd++)
                    {
                        ReGdiagnostico = paciente.Rows[dd]["diagnostico"].ToString();
                        ReGtratamiento = paciente.Rows[dd]["tratamiento"].ToString();
                    }
                }
                VerRegistro(ReGdiagnostico, ReGtratamiento);

            }
            if (e.CommandName.Equals("Add"))
            {
                DBConnect conector = new DBConnect();
                FillCustomerInGrid();
            }
        }
        private void VerRegistro(string ReGdiagnostico, string ReGtratamiento)
        {
            diagnostico.Text = ReGdiagnostico;
            tratamiento.Text = ReGtratamiento;
            GridView1.Enabled = false;
        }
    }
}
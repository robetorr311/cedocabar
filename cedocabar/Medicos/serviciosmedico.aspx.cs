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

namespace cedocabar.Medicos
{
    public partial class serviciosmedico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string idmedico = Server.HtmlEncode(Request.QueryString["id"]);
                HiddenField1.Value = idmedico;
                DBConnect conector = new DBConnect();
                DataTable servicios = new DataTable();
                servicios = conector.SServicios();
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
                DataTable horarios = new DataTable();
                horarios = conector.SHorarios();
                ListItem opcionh = new ListItem();
                opcionh.Text = "Seleccione";
                opcionh.Value = "0";
                hhorario.Items.Add(opcionh);
                for (int i = 0; i < horarios.Rows.Count; i++)
                {
                    ListItem opcionh2 = new ListItem();
                    opcionh2.Text = horarios.Rows[i]["nombre"].ToString();
                    opcionh2.Value = horarios.Rows[i]["id"].ToString();
                    hhorario.Items.Add(opcionh2);
                }
                hhorario.DataBind();
                DataTable turnos = new DataTable();
                turnos = conector.STurnos();
                ListItem opciontu = new ListItem();
                opciontu.Text = "Seleccione";
                opciontu.Value = "0";
                hturno.Items.Add(opcionh);
                for (int i = 0; i < turnos.Rows.Count; i++)
                {
                    ListItem opciontu2 = new ListItem();
                    opciontu2.Text = turnos.Rows[i]["nombre"].ToString();
                    opciontu2.Value = turnos.Rows[i]["id"].ToString();
                    hturno.Items.Add(opciontu2);
                }
                hturno.DataBind();
                pacientesm.Enabled = false;
                pacientest.Enabled = false;
                CargarGrid();
            }
        }
        protected void controles(object sender, EventArgs e)
        {
            if (hturno.SelectedValue == "1")
            {
                pacientesm.Enabled = true;
                pacientest.Enabled = false;
                pacientest.Text = "0";
            }
            if (hturno.SelectedValue == "2")
            {
                pacientesm.Enabled = false;
                pacientest.Enabled = true;
                pacientesm.Text = "0";
            }
            if (hturno.SelectedValue == "3")
            {
                pacientesm.Enabled = true;
                pacientest.Enabled = true;
            }
        }
        private void CargarGrid()
        {
            DataTable temporal = (DataTable)Session["tempmed"];
            string criterio= "hmedico=" + HiddenField1.Value;
            temporal.DefaultView.RowFilter = string.Format(criterio);
            DataTable datos = temporal.DefaultView.ToTable();
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
        protected void Guardar(object sender, EventArgs e)
        {
            DBConnect conector = new DBConnect();
            string vservicios = servicio.SelectedItem.Text;
            string vhservicios = servicio.SelectedValue;
            string vhorario = hhorario.SelectedItem.Text;
            string vhhorario = hhorario.SelectedValue;
            string vturno = hturno.SelectedItem.Text;
            string vhturno = hturno.SelectedValue;
            string vpacientesm = pacientesm.Text;
            string vpacientest = pacientest.Text;
            string vhmedico = HiddenField1.Value;
            if ((vhservicios == "0") | (vhhorario == "0") | (vhturno == "0") | (vhmedico == ""))
            {
                if (vhservicios == "0")
                {
                    LblV5.Text = "*";
                }
                if (vhhorario == "0")
                {
                    LblV11.Text = "*";
                }
                if (vhturno == "0")
                {
                    LblV12.Text = "*";
                }
                Label1.CssClass = "alerta";
                Label1.Text = "Faltan Datos no es posible guardar!! Por favor complete los campos marcados como vacios!!";
            }
            else
            {
                DataTable temporal = (DataTable)Session["tempmed"];
                DataRow dr = temporal.NewRow();
                dr["hmedico"] = vhmedico;
                dr["hservicio"] = vhservicios;
                dr["hhorario"] = vhhorario;
                dr["hturno"] = vhturno;
                dr["npersonasm"] = vpacientesm;
                dr["npersonast"] = vpacientest;
                dr["medico"] = "16";
                dr["servicio"] = vservicios;
                dr["horario"] = vhhorario;
                dr["turno"] = vturno;
                temporal.Rows.Add(dr);
                Response.Redirect("serviciosmedico.aspx?id=" + System.Web.HttpUtility.UrlEncode(HiddenField1.Value));
            }
        }
        protected void Cerrar(object sender, EventArgs e)
        {
            string devuelveFecha = "<script language='JavaScript'>" +
                "window.parent.hidePopWin(true, '.','.'); " +
                "</script>";
            ClientScript.RegisterStartupScript(this.GetType(), "Devolver", devuelveFecha);
        }
        protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            CargarGrid();
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DBConnect conexion = new DBConnect();
            string iddram = GridView1.Rows[Convert.ToInt32(GridView1.SelectedIndex.ToString())].Cells[2].Text.ToString();
            string criterio = "id=" + iddram;
            DataTable temporal = (DataTable)Session["temporal"];
            DataRow[] temporalt = temporal.Select(criterio);
            for (int i = 0; i < temporalt.Length; i++)
            {
                temporalt[i].Delete();
            }
            Response.Redirect("serviciosmedico.aspx?id=" + System.Web.HttpUtility.UrlEncode(HiddenField1.Value));
        }
        protected void gridView_SelectedIndex(object sender, EventArgs e)
        {
            Label LblID = GridView1.Rows[Convert.ToInt32(GridView1.SelectedIndex.ToString())].FindControl("LblID") as Label;
            ImageButton ImageButton2 = (ImageButton)GridView1.Rows[GridView1.SelectedRow.RowIndex].FindControl("ImageButton2");
            ImageButton2.Enabled = true;
            idsrvmed.Value = LblID.Text;
            Label1.Text = "";
        }
        protected void Borrar(object sender, GridViewDeleteEventArgs e)
        {
            string criterio = "id=" + idsrvmed.Value;
            DataTable temporal = (DataTable)Session["tempmed"];
            DataRow[] temporalt = temporal.Select(criterio);
            for (int i = 0; i < temporalt.Length; i++)
            {
                temporalt[i].Delete();
            }
            Response.Redirect("serviciosmedico.aspx?id=" + System.Web.HttpUtility.UrlEncode(HiddenField1.Value));
        }
    }
}
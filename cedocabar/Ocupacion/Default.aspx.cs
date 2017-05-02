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

namespace cedocabar.Ocupacion
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Session"] != null)
            {
                if (!IsPostBack)
                {
                    nombre.Enabled = false;
                    codigo.Enabled = false;
                    Button1.Visible = false;
                    ImageButton1.Visible = false;
                    Button3.Visible = false;
                    Button4.Visible = true;
                    GridView1.Enabled = true;
                    FillCustomerInGrid();
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
        protected void Guardar(object sender, EventArgs e)
        {
            DBConnect conector = new DBConnect();
            conector.iExamenes(
                codigo.Text,
                nombre.Text);
            Response.Redirect("Default.aspx");
        }
        private void FillCustomerInGrid()
        {
            DBConnect conector = new DBConnect();
            DataTable datos = conector.SOcupacion();
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
            ImageButton ImageButton1 = (ImageButton)GridView1.Rows[GridView1.SelectedRow.RowIndex].FindControl("ImageButton1");
            ImageButton ImageButton2 = (ImageButton)GridView1.Rows[GridView1.SelectedRow.RowIndex].FindControl("ImageButton2");
            ImageButton ImageButton5 = (ImageButton)GridView1.Rows[GridView1.SelectedRow.RowIndex].FindControl("ImageButton5");
            ImageButton1.Enabled = true;
            ImageButton2.Enabled = true;
            ImageButton5.Enabled = true;
            HiddenField1.Value = LblID.Text;
        }
        protected void gridView_DeletedIndex(object sender, GridViewDeleteEventArgs e)
        {
            DBConnect conector = new DBConnect();
            string sql = "";
            if (HiddenField1.Value == "")
            {
                sql = "Seleccione la fila para poder eliminar el registro;";
                Label2.Text = sql;
            }
            else
            {
                conector.docupacion(HiddenField1.Value);
                FillCustomerInGrid();
                Label1.Text = "";
                HiddenField1.Value = "";
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
        protected void Editar(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            FillCustomerInGrid();
        }
        protected void Cancelar(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            FillCustomerInGrid();
        }
        protected void Borrar(object sender, GridViewDeleteEventArgs e)
        {
            Label LblID = (Label)GridView1.Rows[e.RowIndex].FindControl("LblID");
            DBConnect conector = new DBConnect();
            conector.docupacion(LblID.Text);
            FillCustomerInGrid();
        }
        protected void upd(object sender, GridViewUpdateEventArgs e)
        {
            DBConnect conector = new DBConnect();
            Label LblID = (Label)GridView1.Rows[e.RowIndex].FindControl("LblID");
            TextBox TBXnombre = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TBXnombre");
            TextBox TBXcodigo = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TBXcodigo");
            conector.uGOcupacion(LblID.Text,
                              TBXnombre.Text,
                              TBXcodigo.Text);
            GridView1.EditIndex = -1;
            FillCustomerInGrid();
        }
        protected void Save(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Registro"))
            {
                string ReGnombre = "";
                string ReGcodigo = "";
                DBConnect conector = new DBConnect();
                string id = HiddenField1.Value;
                DataTable medicos = conector.Sexamenes_IND(id);
                if (medicos.Rows.Count > 0)
                {
                    for (int dd = 0; dd < medicos.Rows.Count; dd++)
                    {
                        ReGnombre = medicos.Rows[dd]["nombre"].ToString();
                        ReGcodigo = medicos.Rows[dd]["codigo"].ToString();
                    }
                }
                VerRegistro(ReGnombre,
                            ReGcodigo);

            }
            if (e.CommandName.Equals("Add"))
            {
                DBConnect conector = new DBConnect();
                FillCustomerInGrid();
            }
        }
        private void VerRegistro(string ReGnombre,
                string ReGcodigo)
        {
            DBConnect conector = new DBConnect();
            nombre.Text = ReGnombre;
            codigo.Text = ReGcodigo;
            nombre.Enabled = false;
            codigo.Enabled = false;
            Button1.Visible = true;
            ImageButton1.Visible = false;
            GridView1.Enabled = false;
            Button3.Visible = false;
            Button4.Visible = false;
        }
        protected void Modificar(object sender, EventArgs e)
        {
            nombre.Enabled = true;
            codigo.Enabled = true;
            Button1.Visible = false;
            ImageButton1.Visible = false;
            GridView1.Enabled = false;
            Button3.Visible = true;
            Button4.Visible = false;
        }
        protected void Actualizar(object sender, EventArgs e)
        {
            DBConnect conector = new DBConnect();
            conector.uOcupacion(HiddenField1.Value,
                nombre.Text,
                codigo.Text);
            Response.Redirect("Default.aspx");

        }
        protected void Nuevo(object sender, EventArgs e)
        {
            nombre.Enabled = true;
            codigo.Enabled = true;
            GridView1.Enabled = false;
            Button1.Visible = false;
            ImageButton1.Visible = true;
            GridView1.Enabled = false;
            Button3.Visible = false;
            Button4.Visible = false;
        }
        private void deshabilitar()
        {
            nombre.Enabled = false;
            codigo.Enabled = false;
        }

    }
}
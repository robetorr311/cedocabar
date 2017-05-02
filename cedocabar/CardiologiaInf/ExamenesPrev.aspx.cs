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
    public partial class ExamenesPrev : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                vhpaciente.Value = Server.HtmlEncode(Request.QueryString["hpaciente"]);
                string modal14 = "window.parent.hidePopWin();";
                Button4.Attributes.Add("onclick", modal14);
                FillCustomerInGrid();
                GridView1.Enabled = true;
            }
        }
        private void FillCustomerInGrid()
        {
            DBConnect conector = new DBConnect();
            DataTable datos = conector.SExamenesf(vhpaciente.Value);
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
            ImageButton1.Enabled = true;
            ImageButton2.Enabled = true;
            HiddenField1.Value = LblID.Text;
        }
        protected void gridView_DeletedIndex(object sender, GridViewDeleteEventArgs e)
        {
            DBConnect conector = new DBConnect();
            string sql = "";
            if (HiddenField1.Value == "")
            {
                sql = "Seleccione la fila para poder eliminar el registro;";
                Label11.Text = sql;
            }
            else
            {
                conector.dexamenf(vhpaciente.Value);
                FillCustomerInGrid();
                Label1.Text = "";
                HiddenField1.Value = "";
            }
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
            conector.dexamenf(vhpaciente.Value);
            FillCustomerInGrid();
        }
        protected void upd(object sender, GridViewUpdateEventArgs e)
        {
            DBConnect conector = new DBConnect();
            Label LblID = (Label)GridView1.Rows[e.RowIndex].FindControl("LblID");
            TextBox TBXfecha = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TBXfecha");
            TextBox TBXta = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TBXta");
            TextBox TBXfc = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TBXfc");
            TextBox TBXfr = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TBXfr");
            TextBox TBXpeso = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TBXpeso");
            TextBox TBXtalla = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TBXtalla");
            TextBox TBXtemperatura = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TBXtemperatura");
            conector.uGExamenf(LblID.Text,
                              vhpaciente.Value,
                              TBXta.Text,
                              TBXfc.Text,
                              TBXfr.Text,
                              TBXpeso.Text,
                              TBXtalla.Text,
                              TBXtemperatura.Text);
            GridView1.EditIndex = -1;
            FillCustomerInGrid();
        }
        protected void Save(object sender, GridViewCommandEventArgs e)
        {

        }


    }
}
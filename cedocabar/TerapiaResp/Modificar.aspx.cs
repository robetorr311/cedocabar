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
    public partial class Modificar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                if (!IsPostBack)
                {
                    FillCustomerInGrid();
                    GridView1.Enabled = true;
                    Button1.Enabled = false;
                    Button2.Visible = false;
                }
        }
        private void FillCustomerInGrid2()
        {
            DBConnect conector = new DBConnect();
            DataTable datos = conector.Svterapiaresp(vhpaciente.Value);
            if (datos.Rows.Count > 0)
            {
                GridView2.DataSource = datos;
                GridView2.DataBind();
            }
            else
            {
                datos.Rows.Add(datos.NewRow());
                GridView2.DataSource = datos;
                GridView2.DataBind();
                int TotalColumns = GridView1.Rows[0].Cells.Count;
                GridView2.Rows[0].Cells.Clear();
                GridView2.Rows[0].Cells.Add(new TableCell());
                GridView2.Rows[0].Cells[0].ColumnSpan = TotalColumns;
                GridView2.Rows[0].Cells[0].Text = "No se encontraron registros";
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
            vhpaciente.Value = LblID.Text;
            Button1.Enabled = true;
        }
        protected void consulta(object sender, EventArgs e)
        {
            string idpac = vhpaciente.Value;
            FillCustomerInGrid2();
        }
        private void FillCustomerInGrid()
        {
            DBConnect conector = new DBConnect();
            DataTable datos = conector.Svgterapiaresp();
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
        protected void gridView_PageIndexChanging2(object sender, GridViewPageEventArgs e)
        {
            FillCustomerInGrid();
            GridView2.PageIndex = e.NewPageIndex;
            GridView2.DataBind();
        }
        protected void gridView_SelectedIndex2(object sender, EventArgs e)
        {
            Label LblID = GridView2.Rows[Convert.ToInt32(GridView2.SelectedIndex.ToString())].FindControl("LblID") as Label;
            vhmorbilidad.Value = LblID.Text;
            Button2.Visible = true;
        }
        protected void Continuar(object sender, EventArgs e)
        {
            Response.Redirect("frmMorbilidad.aspx?hpaciente=" + vhpaciente.Value + "&hmorbilidad=" + vhmorbilidad.Value);
        }
        protected void Finalizar(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}
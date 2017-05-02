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

namespace cedocabar.CardiologiaAd
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
            HiddenField1.Value = LblID.Text;
        }
    }
}
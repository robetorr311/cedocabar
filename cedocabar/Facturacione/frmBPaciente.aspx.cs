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


namespace cedocabar.Facturacione
{
    public partial class frmBPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }
        private void CargarGrid()
        {
            DBConnect conexion = new DBConnect();
            DataTable datos = conexion.SLISTApacientes();
            if (datos.Rows.Count > 0)
            {
                GridView1.DataSource = datos;
                GridView1.DataBind();
                GridView1.SelectedIndex = 0;
            }
            else
            {
                DataTable datos2 = new DataTable();
                DataColumn columna1 = new DataColumn("id");
                DataColumn columna2 = new DataColumn("historia");
                DataColumn columna3 = new DataColumn("nombre");
                DataColumn columna4 = new DataColumn("edad");
                DataColumn columna5 = new DataColumn("sexo"); 
                columna1.AllowDBNull = true;
                columna2.AllowDBNull = true;
                columna3.AllowDBNull = true;
                columna4.AllowDBNull = true;
                columna5.AllowDBNull = true; 
                datos2.Columns.Add(columna1);
                datos2.Columns.Add(columna2);
                datos2.Columns.Add(columna3);
                datos2.Columns.Add(columna4);
                datos2.Columns.Add(columna5); 
                DataRow dr = datos2.NewRow();
                dr["id"] = null;
                dr["historia"] = null;
                dr["nombre"] = null;
                dr["edad"] = null;
                dr["sexo"] = null; 
                datos2.Rows.Add(dr);
                GridView1.DataSource = datos2;
                GridView1.DataBind();
                int TotalColumns = GridView1.Rows[0].Cells.Count;
                GridView1.Rows[0].Cells.Clear();
                GridView1.Rows[0].Cells.Add(new TableCell());
                GridView1.Rows[0].Cells[0].ColumnSpan = TotalColumns;
                GridView1.Rows[0].Cells[0].Text = "No existen solicitudes pendientes!!";
            }
        }
        protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            CargarGrid();
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
        protected void gridView_SelectedIndex(object sender, EventArgs e)
        {
            idpac.Value = GridView1.Rows[GridView1.SelectedIndex].Cells[1].Text;
            string devuelveFecha = "<script language='JavaScript'>" +
            "window.parent.hidePopWin(true, '" + GridView1.Rows[GridView1.SelectedIndex].Cells[2].Text + "','" + GridView1.Rows[GridView1.SelectedIndex].Cells[3].Text + "','" + GridView1.Rows[GridView1.SelectedIndex].Cells[4].Text +"','" +idpac.Value + "'); " +
            "</script>";
            ClientScript.RegisterStartupScript(this.GetType(), "Devolver", devuelveFecha);
        }
    }
}
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
    public partial class org_geografica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                estado.Items.Clear();
                DBConnect conector = new DBConnect();
                DataTable org_geog = new DataTable();
                org_geog = conector.Sorg_geografica("1");
                ListItem opciont = new ListItem();
                opciont.Text = "Seleccione";
                opciont.Value = "0";
                estado.Items.Add(opciont);
                for (int i = 0; i < org_geog.Rows.Count; i++)
                {
                    ListItem opciont2 = new ListItem();
                    opciont2.Text = org_geog.Rows[i]["des_region"].ToString();
                    opciont2.Value = org_geog.Rows[i]["num_region"].ToString();
                    estado.Items.Add(opciont2);
                }
                estado.DataBind();
                Button1.Enabled = false;
            }
        }
        protected void munic(object sender, EventArgs e)
        {
            municipio.Items.Clear();
            DBConnect conector = new DBConnect();
            DataTable org_geog = new DataTable();
            org_geog = conector.Sorg_geografica(estado.SelectedValue);
            ListItem opciont = new ListItem();
            opciont.Text = "Seleccione";
            opciont.Value = "0";
            municipio.Items.Add(opciont);
            for (int i = 0; i < org_geog.Rows.Count; i++)
            {
                ListItem opciont2 = new ListItem();
                opciont2.Text = org_geog.Rows[i]["des_region"].ToString();
                opciont2.Value = org_geog.Rows[i]["num_region"].ToString();
                municipio.Items.Add(opciont2);
            }
            municipio.DataBind();
        }
        protected void parroq(object sender, EventArgs e)
        {
            parroquia.Items.Clear();
            DBConnect conector = new DBConnect();
            DataTable org_geog = new DataTable();
            org_geog = conector.Sorg_geografica(municipio.SelectedValue);
            ListItem opciont = new ListItem();
            opciont.Text = "Seleccione";
            opciont.Value = "0";
            parroquia.Items.Add(opciont);
            for (int i = 0; i < org_geog.Rows.Count; i++)
            {
                ListItem opciont2 = new ListItem();
                opciont2.Text = org_geog.Rows[i]["des_region"].ToString();
                opciont2.Value = org_geog.Rows[i]["num_region"].ToString();
                parroquia.Items.Add(opciont2);
            }
            parroquia.DataBind();
        }
        protected void sect(object sender, EventArgs e)
        {
            sector.Items.Clear();
            DBConnect conector = new DBConnect();
            DataTable org_geog = new DataTable();
            org_geog = conector.Sorg_geografica(parroquia.SelectedValue);
            ListItem opciont = new ListItem();
            opciont.Text = "Seleccione";
            opciont.Value = "0";
            sector.Items.Add(opciont);
            for (int i = 0; i < org_geog.Rows.Count; i++)
            {
                ListItem opciont2 = new ListItem();
                opciont2.Text = org_geog.Rows[i]["des_region"].ToString();
                opciont2.Value = org_geog.Rows[i]["num_region"].ToString();
                sector.Items.Add(opciont2);
            }
            sector.DataBind();
        }
        protected void nombrelargo(object sender, EventArgs e)
        {
            DBConnect conector = new DBConnect();
            string nomblargo = conector.Snombrelargo(sector.SelectedValue);
            nmbrlargo.Value = nomblargo;
            this.Session["nmbrlargo"] = nomblargo;
            this.Session["num_region"] = sector.SelectedValue;
            this.Session["modal"] = "1";
            Button1.Enabled = true;

        }
        protected void Cerrar(object sender, EventArgs e)
        {
            string devuelveFecha = "<script language='JavaScript'>" +
                "window.parent.hidePopWin(true, 'geo', '" + nmbrlargo.Value + "'," + "'" + sector.SelectedValue + "'); " +
                "</script>";
            ClientScript.RegisterStartupScript(this.GetType(), "Devolver", devuelveFecha);
        }
    }
}
﻿using System;
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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Session"] != null)
            {
                if (!IsPostBack)
                {
                    DataTable temporal = new DataTable();
                    DataColumn columna1 = new DataColumn("id");
                    DataColumn columna2 = new DataColumn("hmedico");
                    DataColumn columna3 = new DataColumn("hservicio");
                    DataColumn columna4 = new DataColumn("hhorario");
                    DataColumn columna5 = new DataColumn("hturno");
                    DataColumn columna6 = new DataColumn("npersonasm");
                    DataColumn columna7 = new DataColumn("npersonast");
                    DataColumn columna8 = new DataColumn("medico");
                    DataColumn columna9 = new DataColumn("servicio");
                    DataColumn columna10 = new DataColumn("horario");
                    DataColumn columna11 = new DataColumn("turno");
                    columna1.AutoIncrement = true;
                    columna2.AllowDBNull = true;
                    columna3.AllowDBNull = true;
                    columna4.AllowDBNull = true;
                    columna5.AllowDBNull = true;
                    columna6.AllowDBNull = true;
                    columna7.AllowDBNull = true;
                    columna8.AllowDBNull = true;
                    columna9.AllowDBNull = true;
                    columna10.AllowDBNull = true;
                    columna11.AllowDBNull = true;
                    columna1.AutoIncrement = true;
                    temporal.Columns.Add(columna1);
                    temporal.Columns.Add(columna2);
                    temporal.Columns.Add(columna3);
                    temporal.Columns.Add(columna4);
                    temporal.Columns.Add(columna5);
                    temporal.Columns.Add(columna6);
                    temporal.Columns.Add(columna7);
                    temporal.Columns.Add(columna8);
                    temporal.Columns.Add(columna9);
                    temporal.Columns.Add(columna10);
                    temporal.Columns.Add(columna11);
                    Session.Add("tempmed", temporal);
                    string modal9 = "showPopWin('org_geografica.aspx', 600, 200,returnRefresh);";
                    Button2.Attributes.Add("onclick", modal9);
                    nombre.Enabled = false;
                    cedula.Enabled = false;
                    mpps.Enabled = false;
                    colegio.Enabled = false;
                    telefonof.Enabled = false;
                    telefonom.Enabled = false;
                    direccion.Enabled = false;
                    correo.Enabled = false;
                    Button1.Visible = false;
                    ImageButton1.Visible = false;
                    Button3.Visible = false;
                    Button4.Visible = true;
                    GridView1.Enabled = true;
                    TextBox1.Disabled = true;
                    Button2.Disabled = true;
                    Button5.Visible = false;
                    Button6.Visible = false;
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
            conector.imedicos(HiddenField1.Value,
                nombre.Text,
                cedula.Text,
                mpps.Text,
                colegio.Text,
                telefonof.Text,
                telefonom.Text,
                direccion.Text,
                num_region.Value,
                correo.Text,
                "4");
            DataTable temporales = (DataTable)Session["tempmed"];
            int reg = temporales.Rows.Count;
            int j = 0;
            for (j = 0; j < reg; j++)
            {
                    conector.iserviciosmedico(temporales.Rows[j]["hmedico"].ToString(),
                    temporales.Rows[j]["hservicio"].ToString(),
                    temporales.Rows[j]["hhorario"].ToString(),
                    temporales.Rows[j]["hturno"].ToString(),
                    temporales.Rows[j]["npersonasm"].ToString(),
                    temporales.Rows[j]["npersonast"].ToString());
            }
            temporales.Dispose();
            temporales.Columns.Clear();
            Response.Redirect("Default.aspx");

        }
        private void FillCustomerInGrid()
        {
            DBConnect conector = new DBConnect();
            DataTable datos = conector.Svistamedicos();
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
                conector.dmedicos(HiddenField1.Value);
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
            Label Lblestatus = (Label)GridView1.Rows[e.NewEditIndex].Cells[6].FindControl("Lblestatus");
            string seleccion = Lblestatus.Text;
            string estat = "";
            if (seleccion == "ACTIVO")
            {
                estat = "4";
            }
            if (seleccion == "INACTIVO")
            {
                estat = "5";
            }
            Lblestatus.Visible = false;
            DropDownList DDGestatus = (DropDownList)GridView1.Rows[e.NewEditIndex].Cells[6].FindControl("DDGestatus");
            DBConnect conector = new DBConnect();
            DataTable listado = conector.Sestatus();
            ListItem opciond = new ListItem();
            opciond.Text = seleccion;
            opciond.Value = "estat";
            DDGestatus.Items.Add(opciond);
            for (int i = 0; i < listado.Rows.Count; i++)
            {
                ListItem opcion = new ListItem();
                opcion.Text = listado.Rows[i]["nombre"].ToString();
                opcion.Value = listado.Rows[i]["codigo"].ToString();
                DDGestatus.Items.Add(opcion);
            }
            DDGestatus.DataBind();
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
            conector.dmedicos(LblID.Text);
            FillCustomerInGrid();
        }
        protected void upd(object sender, GridViewUpdateEventArgs e)
        {
            DBConnect conector = new DBConnect();
            Label LblID = (Label)GridView1.Rows[e.RowIndex].FindControl("LblID");
            TextBox TBXnombre = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TBXnombre");
            TextBox TBXcedula = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TBXcedula");
            TextBox TBXmpps = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TBXmpps");
            TextBox TBXcolegio = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TBXcolegio");
            DropDownList DDGestatus = (DropDownList)GridView1.Rows[e.RowIndex].Cells[6].FindControl("DDGestatus");
            conector.uGmedicos(LblID.Text,
                              TBXnombre.Text,
                              TBXcedula.Text,
                              TBXmpps.Text,
                              TBXcolegio.Text,
                              DDGestatus.SelectedValue);
            GridView1.EditIndex = -1;
            FillCustomerInGrid();
        }
        protected void Save(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Registro"))
            {
                string ReGnombre = "";
                string ReGcedula = "";
                string ReGmpps = "";
                string ReGcolegio = "";
                string ReGtelefonod = "";
                string ReGtelefonom = "";
                string ReGdireccion = "";
                string ReGorg_geografica = "";
                string ReGnum_region = "";
                string ReGcorreo = "";
                string ReGestatus = "";
                DBConnect conector = new DBConnect();
                string id = HiddenField1.Value;
                DataTable medicos = conector.Smedicos(id);
                if (medicos.Rows.Count > 0)
                {
                    for (int dd = 0; dd < medicos.Rows.Count; dd++)
                    {
                        ReGnombre = medicos.Rows[dd]["nombre"].ToString();
                        ReGcedula = medicos.Rows[dd]["cedula"].ToString();
                        ReGmpps = medicos.Rows[dd]["mpps"].ToString();
                        ReGcolegio = medicos.Rows[dd]["colegio"].ToString();
                        ReGtelefonod = medicos.Rows[dd]["telefono_d"].ToString();
                        ReGtelefonom = medicos.Rows[dd]["telefono_m"].ToString();
                        ReGdireccion = medicos.Rows[dd]["direccion"].ToString();
                        ReGorg_geografica = medicos.Rows[dd]["region"].ToString();
                        ReGnum_region = conector.Snum_region(ReGorg_geografica);
                        ReGcorreo = medicos.Rows[dd]["correo"].ToString();
                        ReGestatus = medicos.Rows[dd]["estatus"].ToString();
                    }
                }
                VerRegistro(ReGnombre,
                            ReGcedula,
                            ReGmpps,
                            ReGcolegio,
                            ReGtelefonod,
                            ReGtelefonom,
                            ReGdireccion,
                            ReGorg_geografica,
                            ReGnum_region,
                            ReGcorreo,
                            ReGestatus);

            }
            if (e.CommandName.Equals("Add"))
            {
                DBConnect conector = new DBConnect();
                FillCustomerInGrid();
            }
        }
        private void VerRegistro(
                string ReGnombre,
                string ReGcedula,
                string ReGmpps,
                string ReGcolegio,
                string ReGtelefonod,
                string ReGtelefonom,
                string ReGdireccion,
                string ReGorg_geografica,
                string ReGnum_region,
                string ReGcorreo,
                string ReGestatus)
        {
            DBConnect conector = new DBConnect();
            nombre.Text = ReGnombre;
            cedula.Text = ReGcedula;
            mpps.Text = ReGmpps;
            colegio.Text = ReGcolegio;
            telefonof.Text = ReGtelefonod;
            telefonom.Text = ReGtelefonom;
            direccion.Text = ReGdireccion;
            TextBox1.Value = ReGorg_geografica;
            num_region.Value = ReGnum_region;
            correo.Text = ReGcorreo;
            estatus.Value = ReGestatus;
            nombre.Enabled = false;
            cedula.Enabled = false;
            mpps.Enabled = false;
            colegio.Enabled = false;
            telefonof.Enabled = false;
            telefonom.Enabled = false;
            direccion.Enabled = false;
            correo.Enabled = false;
            Button1.Visible = true;
            ImageButton1.Visible = false;
            GridView1.Enabled = false;
            Button3.Visible = false;
            Button4.Visible = false;
            Button5.Visible = false;
            Button6.Visible = false;
            TextBox1.Disabled = true;
            //TextBox1.Visible = false;

        }
        protected void Modificar(object sender, EventArgs e)
        {
            nombre.Enabled = true;
            cedula.Enabled = true;
            mpps.Enabled = true;
            colegio.Enabled = true;
            telefonof.Enabled = true;
            telefonom.Enabled = true;
            direccion.Enabled = true;
            correo.Enabled = true;
            Button1.Visible = false;
            ImageButton1.Visible = false;
            GridView1.Enabled = false;
            Button3.Visible = true;
            Button4.Visible = false;
            Button2.Disabled = false;
            Button5.Visible = false;
            Button6.Visible = true;
            string modal9 = "showPopWin('Mserviciosmedico.aspx?id=" + HiddenField1.Value + "&num_region=" + num_region.Value + "&des_region=" + TextBox1.Value + "', 600, 300,returnRefresh);";
            Button6.Attributes.Add("onclick", modal9);
        }
        protected void Actualizar(object sender, EventArgs e)
        {
            DBConnect conector = new DBConnect();
            conector.umedicos(HiddenField1.Value,
                nombre.Text,
                cedula.Text,
                mpps.Text,
                colegio.Text,
                telefonof.Text,
                telefonom.Text,
                direccion.Text,
                num_region.Value,
                correo.Text,
                estatus.Value);
            Response.Redirect("Default.aspx");

        }
        protected void Nuevo(object sender, EventArgs e)
        {
            DBConnect conector = new DBConnect();
            string nhist = conector.Sid_medicos();
            HiddenField1.Value = nhist;
            nombre.Enabled = true;
            cedula.Enabled = true;
            mpps.Enabled = true;
            colegio.Enabled = true;
            telefonof.Enabled = true;
            telefonom.Enabled = true;
            direccion.Enabled = true;
            TextBox1.Disabled = true;
            correo.Enabled = true;
            GridView1.Enabled = false;
            Button1.Visible = false;
            ImageButton1.Visible = true;
            GridView1.Enabled = false;
            Button3.Visible = false;
            Button4.Visible = false;
            Button2.Disabled = false;
            Button5.Visible = true;
            string modal9 = "showPopWin('serviciosmedico.aspx?id=" + HiddenField1.Value + "', 600, 300,returnRefresh);";
            Button5.Attributes.Add("onclick", modal9);
        }
        private void deshabilitar()
        {
            nombre.Enabled = false;
            cedula.Enabled = false;
            mpps.Enabled = false;
            colegio.Enabled = false;
            telefonof.Enabled = false;
            telefonom.Enabled = false;
            direccion.Enabled = false;
            TextBox1.Disabled = true;
            correo.Enabled = false;
            Button2.Disabled = true;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Web;
using System.Configuration;
using System.Collections;
using System.Data;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Npgsql;
using System.Text;
using System.IO;

namespace cedocabar.MedicinaInterna
{
    public partial class ECG : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["hpaciente"];
                hpaciente.Value = id;
                CargarListadImagenes();
                string modal14 = "window.parent.hidePopWin();";
                Button1.Attributes.Add("onclick", modal14);
            }
        }
        protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            CargarListadImagenes();
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
        protected void gridView_SelectedIndex(object sender, EventArgs e)
        {
            Label LblID = GridView1.Rows[Convert.ToInt32(GridView1.SelectedIndex.ToString())].FindControl("LblID") as Label;
            HyperLink descarga = (HyperLink)GridView1.Rows[GridView1.SelectedRow.RowIndex].FindControl("descarga");
            descarga.NavigateUrl = "Download.aspx?id=" + LblID.Text;
            descarga.Enabled = true;
            idekg.Value = LblID.Text;
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            DBConnect conector = new DBConnect();
            string idecg = "";
            string strFileNameOnServer = FileUpload1.PostedFile.FileName;
            string strBaseLocation = Server.MapPath("../Imagenes/ecg/");
            if (FileUpload1.HasFile)
            {
                if ((FileUpload1.PostedFile.ContentType.ToString() == "image/pjpeg") || (FileUpload1.PostedFile.ContentType.ToString() == "image/gif"))
                {
                    idecg = conector.GuardarImagen(hpaciente.Value, FileUpload1.PostedFile.FileName,
                       FileUpload1.PostedFile.ContentType.ToString(),
                       FileUpload1.PostedFile.ContentLength.ToString());
                    string arch = conector.GetArchivoId(idecg);
                    FileUpload1.PostedFile.SaveAs(strBaseLocation + arch);
                    CargarListadImagenes();
                }
                else
                {
                    Label4.Text = "Error - Solo puede guardar archivo de imagene tipo (.jpg) o (.gif)!!";
                }
            }
            else
            {
                Label4.Text = "Error - No ha seleccionado ningun archivo!!";
            }
        }
        private void CargarListadImagenes()
        {
            DBConnect conector = new DBConnect();
            DataTable ekg = new DataTable();
            ekg = conector.GetImagenesByhpaciente(hpaciente.Value);
            GridView1.DataSource = conector.GetImagenList();
            GridView1.DataBind();
        }

    }
}
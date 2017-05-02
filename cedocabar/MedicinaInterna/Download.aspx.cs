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
    public partial class Download : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            DBConnect Image = new DBConnect();
            DataTable ekg = new DataTable();
            string strhpaciente="";
            string strarchivo="";
            string strtipo="";
            string strsize="";
            string Ext="";
            byte[] img = null;
            int lenght = 0;
            ekg = Image.GetImgById(id);
            if (ekg.Rows.Count > 0)
            {
                for (int dd = 0; dd < ekg.Rows.Count; dd++)
                {
                    strhpaciente = ekg.Rows[dd]["hpaciente"].ToString();
                    strarchivo = ekg.Rows[dd]["archivo"].ToString();
                    strtipo = ekg.Rows[dd]["tipo"].ToString();
                    strsize = ekg.Rows[dd]["size"].ToString();
                }
                lenght = Convert.ToInt32(strsize);
                switch (strtipo.TrimEnd())
                {
                    case "image/pjpeg":
                        Ext=".jpg";
                        break;
                    case "image/gif":
                        Ext = ".gif";
                        break;
                    case "image/x-png":
                        Ext = ".png";
                        break;
                }
                string nombredearchivo = strhpaciente + id + Ext;
                string strBaseLocation = Server.MapPath("../Imagenes/ecg/");
                string arc = strBaseLocation + strarchivo;
                FileStream fs = new FileStream(arc, FileMode.Open);
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    img = reader.ReadBytes(lenght);                  
                }
                Response.Clear();
                Response.Buffer = true;
                Response.AddHeader("Content-Type", strtipo.TrimEnd());
                Response.AddHeader("Content-Length", strsize.TrimEnd());
                Response.AddHeader("content-disposition", string.Format("attachment;filename="+ nombredearchivo));
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.ContentType = strtipo.TrimEnd();
                Response.BinaryWrite(img);
                Response.Flush();
                Response.End();
            }
        }
    }
}
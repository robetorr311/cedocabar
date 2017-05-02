using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cedocabar.CardiologiaInf
{
    public partial class ECG : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnUploadTheFile_Click(object Source, EventArgs evArgs)
        {
            string strFileNameOnServer = File1.PostedFile.FileName;
            string strBaseLocation = Server.MapPath("../Imagenes/");
            if ("" == strFileNameOnServer)
            {
                Label4.Text = "Error - a file name must be specified.";
                return;
            }

            if (null != File1.PostedFile)
            {
                try
                {
                    //File1.PostedFile.SaveAs(strBaseLocation + strFileNameOnServer);
                    Label4.Text = "Correcto: " +
                      strBaseLocation + strFileNameOnServer + "</b> uploaded successfully";
                }
                catch (Exception e)
                {
                    Label4.Text = "Error saving <b>" +
                      strBaseLocation + strFileNameOnServer + "</b><br>" + e.ToString();
                }
            }
        }
    }
}
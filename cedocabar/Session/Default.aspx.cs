using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cedocabar.Session
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Session.Clear();
            this.Session.Abandon();
            string devuelveFecha = "<script language='JavaScript'>" +
                "window.document.forms[0].target = '_parent'; window.document.forms[0].action = '../salida.aspx';" +
                "window.document.forms[0].submit(); </script>";
            ClientScript.RegisterStartupScript(this.GetType(), "CambiaTarget", devuelveFecha);
        }
    }
}
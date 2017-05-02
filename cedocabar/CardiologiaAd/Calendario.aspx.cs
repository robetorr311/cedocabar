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
    public partial class Calendario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }
        protected void cal_SelectionChanged(object sender, EventArgs e)
        {
            //fecha.Value = cal.SelectedDate.ToShortDateString();

            string devuelveFecha = "<script language='JavaScript'>" +
                "returnValue = document.getElementById('txtFecha').value;" +
                "close();</script>";

            //ClientScript.RegisterStartupScript(this.GetType(), "Devolver", devuelveFecha);
        }
    }
}
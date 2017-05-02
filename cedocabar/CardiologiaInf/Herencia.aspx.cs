using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cedocabar.CardiologiaInf
{
    public partial class Herencia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ide = Server.HtmlEncode(Request.QueryString["form"]);
            control.Value = ide;
        }
        protected void Ninguna(object sender, EventArgs e)
        {
            if (Checkbox3.Checked == true)
            {
                Checkbox1.Checked = false;
                Checkbox2.Checked = false;
                Checkbox4.Checked = false;
                Checkbox5.Checked = false;
                Checkbox6.Checked = false;
            }
        }
        protected void Cerrar(object sender, EventArgs e)
        {
            string chk1 = "";
            string chk2 = "";
            string chk4 = "";
            string chk5 = "";
            string chk6 = "";
            herencia.Value = "";
            if (Checkbox1.Checked)
            {
                chk1 = "HTA ";
            }
            if (Checkbox2.Checked)
            {
            chk2 = "DM ";
            }
            if (Checkbox4.Checked)
            {
             chk4 = "IM ";
            }
            if (Checkbox5.Checked)
            {
            chk5 = "ECV ";
            }
            if (Checkbox6.Checked){
            chk6 = "MS ";
            }
            if (Checkbox3.Checked)
            {
                herencia.Value = "Ninguna";
            }
            else
            {
                herencia.Value = chk1 + chk2 + chk4 + chk5 + chk6;
            }
            string ide = control.Value;
            string devuelveFecha = "";
            if (ide == "herp")
            {
                devuelveFecha = "<script language='JavaScript'>" +
                    "window.parent.hidePopWin(true, 'herp', '" + herencia.Value + "'," + "'0'); " +
                    "</script>";
            }
            if (ide == "herm")
            {
                devuelveFecha = "<script language='JavaScript'>" +
                    "window.parent.hidePopWin(true, 'herm', '" + herencia.Value + "'," + "'0'); " +
                    "</script>";
            }
            if (ide == "herh")
            {
                devuelveFecha = "<script language='JavaScript'>" +
                    "window.parent.hidePopWin(true, 'herh', '" + herencia.Value + "'," + "'0'); " +
                    "</script>";
            }         
            ClientScript.RegisterStartupScript(this.GetType(), "Devolver", devuelveFecha);
        }
    }
}
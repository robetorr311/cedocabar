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

namespace cedocabar.Menu
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Session.Timeout = 60;
            DateTime dt = DateTime.Now;
            int d = dt.Day;
            int m = dt.Month;
            int y = dt.Year;
            int h = dt.Hour;
            int min = dt.Minute;
            string dia = "";
            string mes = "";
            string minu = "";
            if (d < 10)
            {
                dia = "0" + Convert.ToString(d);
            }
            else
            {
                dia = Convert.ToString(d);
            }
            if (min < 10)
            {
                minu = "0" + Convert.ToString(min);
            }
            else
            {
                minu = Convert.ToString(min);
            }
            if (m < 10)
            {
                mes = "0" + Convert.ToString(m);
            }
            else
            {
                mes = Convert.ToString(m);
            }
            string nombre = (string)this.Session["Nbr"];
            string login = (string)this.Session["Us"];
            string nivel = (string)this.Session["Nvl"];
            string hdep2 = (string)this.Session["hdep"];
            string password = (string)this.Session["pwd"];
            string tipousuario = (string)this.Session["tipousuario"];
            string texto = "BIENVENIDOS AL SISTEMA INTEGRADO DE ATENCI&Oacute;N AL PACIENTE DEL CENTRO DOCENTE CARDIOL&Oacute;GICO BOLIVARIANO DE ARAGUA || HOY ES: " +
                            dia + "/" + mes + "/" + y + " || SESION INICIADA POR: " + nombre;
            Label1.Text = texto;
            int ni = Convert.ToInt16(nivel);
            DBConnect conexion = new DBConnect();
            DataTable principal = conexion.Smenu(0);
            int rec = principal.Rows.Count;
            string[,] ParentNode = new string[100, 3];
            int i = 0;
            int count = 0;
            while (i < rec)
            {
                ParentNode[count, 0] = principal.Rows[i]["id"].ToString();
                ParentNode[count++, 1] = principal.Rows[i]["nombre"].ToString();
                i++;
            }
            for (int loop = 0; loop < count; loop++)
            {
                MenuItem root = new MenuItem();
                root.Value = ParentNode[loop, 0];
                root.Text = ParentNode[loop, 1];
                root.ImageUrl = "../Imagenes/1x1.gif";
                root.Selectable = false;
                int hp = Convert.ToInt16(ParentNode[loop, 0]);
                int j = 0;
                DataTable segundonivel = new DataTable();
                segundonivel = conexion.Smenu(hp);
                int recsn = segundonivel.Rows.Count;
                while (j < recsn)
                {
                    if ((nivel == "1")&&(tipousuario=="13"))
                    {
                        MenuItem child = new MenuItem();
                        child.ImageUrl = "../Imagenes/" + segundonivel.Rows[j]["img"].ToString();
                        child.Value = segundonivel.Rows[j]["id"].ToString();
                        child.Text = " " + segundonivel.Rows[j]["nombre"].ToString();
                        child.NavigateUrl = "../" + segundonivel.Rows[j]["ruta"].ToString();
                        child.Target = "contenido";
                        root.ChildItems.Add(child);
                        DataTable tercernivel = new DataTable();
                        tercernivel = conexion.Smenu(Convert.ToInt16(segundonivel.Rows[j]["id"].ToString()));
                        int k = 0;
                        int recsntn = tercernivel.Rows.Count;
                        while (k < recsntn)
                        {
                            MenuItem childtn = new MenuItem();
                            childtn.ImageUrl = "~/Imagenes/" + tercernivel.Rows[k]["img"].ToString();
                            childtn.Value = tercernivel.Rows[k]["id"].ToString();
                            childtn.Text = " " + tercernivel.Rows[k]["nombre"].ToString();
                            childtn.NavigateUrl = "../" + tercernivel.Rows[k]["ruta"].ToString();
                            childtn.Target = "contenido";
                            child.ChildItems.Add(childtn);
                            k++;
                        }
                    }
                    if ((nivel == "2")&&(tipousuario=="9"))
                    {
                        if ((segundonivel.Rows[j]["nivel"].ToString() == "2") || (segundonivel.Rows[j]["nivel"].ToString() == "3"))
                        {
                            if (segundonivel.Rows[j]["id"].ToString() != "2")
                            {
                                MenuItem child = new MenuItem();
                                child.ImageUrl = "../Imagenes/" + segundonivel.Rows[j]["img"].ToString();
                                child.Value = segundonivel.Rows[j]["id"].ToString();
                                child.Text = " " + segundonivel.Rows[j]["nombre"].ToString();
                                child.NavigateUrl = "../" + segundonivel.Rows[j]["ruta"].ToString();
                                child.Target = "contenido";
                                root.ChildItems.Add(child);
                                DataTable tercernivel = new DataTable();
                                tercernivel = conexion.Smenu(Convert.ToInt16(segundonivel.Rows[j]["id"].ToString()));
                                int k = 0;
                                int recsntn = tercernivel.Rows.Count;
                                while (k < recsntn)
                                {
                                    MenuItem childtn = new MenuItem();
                                    childtn.ImageUrl = "~/Imagenes/" + tercernivel.Rows[k]["img"].ToString();
                                    childtn.Value = tercernivel.Rows[k]["id"].ToString();
                                    childtn.Text = " " + tercernivel.Rows[k]["nombre"].ToString();
                                    childtn.NavigateUrl = "../" + tercernivel.Rows[k]["ruta"].ToString();
                                    childtn.Target = "contenido";
                                    child.ChildItems.Add(childtn);
                                    k++;
                                }
                            }
                        }
                    }
                    if (nivel == "3")
                    {
                        if (segundonivel.Rows[j]["nivel"].ToString() == "3")
                        {
                            MenuItem child = new MenuItem();
                            child.ImageUrl = "../Imagenes/" + segundonivel.Rows[j]["img"].ToString();
                            child.Value = segundonivel.Rows[j]["id"].ToString();
                            child.Text = " " + segundonivel.Rows[j]["nombre"].ToString();
                            child.NavigateUrl = "../" + segundonivel.Rows[j]["ruta"].ToString();
                            child.Target = "contenido";
                            root.ChildItems.Add(child);
                            DataTable tercernivel = new DataTable();
                            tercernivel = conexion.Smenu(Convert.ToInt16(segundonivel.Rows[j]["id"].ToString()));
                            int k = 0;
                            int recsntn = tercernivel.Rows.Count;
                            while (k < recsntn)
                            {
                                MenuItem childtn = new MenuItem();
                                childtn.ImageUrl = "~/Imagenes/" + tercernivel.Rows[k]["img"].ToString();
                                childtn.Value = tercernivel.Rows[k]["id"].ToString();
                                childtn.Text = " " + tercernivel.Rows[k]["nombre"].ToString();
                                childtn.NavigateUrl = "../" + tercernivel.Rows[k]["ruta"].ToString();
                                childtn.Target = "contenido";
                                child.ChildItems.Add(childtn);
                                k++;
                            }
                        }
                    }
                    j++;

                }
                MenudeOpciones.Items.Add(root);
            }

        }
    }
}
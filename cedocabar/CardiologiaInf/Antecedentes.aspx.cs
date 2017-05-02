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

namespace cedocabar.CardiologiaInf
{
    public partial class Antecedentes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        string modal14 = "window.parent.hidePopWin();";
        Button4.Attributes.Add("onclick", modal14);
        string str_id="";
        string str_has="";
        string str_diabetes="";
        string str_dislipidemias="";
        string str_tabaquismo="";
        string str_sedentarismo="";
        string str_obesidad="";
        string str_historiafm60="";
        string str_diagnosticoeac="";
        string str_anginaest="";
        string str_cf="";
        string str_im="";
        string str_angioplastia="";
        string str_cirugia="";
        string str_arritmias="";
        string str_sv="";
        string str_bloqueoav="";
        string str_mpd="";
        string str_acv="";
        string str_enfcarotidea="";
        string str_enfperiferica="";
        string str_chagas="";
        string str_cardreumatica="";
        string str_hpaciente="";
        string str_hmotivo = "";
            vhpaciente.Value = Server.HtmlEncode(Request.QueryString["hpaciente"]);
            DBConnect conexion = new DBConnect();
            DataTable antecedentes = new DataTable();
            antecedentes = conexion.Santecedente(vhpaciente.Value);
            int rec = antecedentes.Rows.Count;
            if (rec > 0)
            {
                
                Button1.Visible = false;
                Button2.Visible = true;
                Button3.Visible = false;
                for (int i = 0; i < antecedentes.Rows.Count; i++)
                {
                    str_id = antecedentes.Rows[i]["id"].ToString();
                    str_has = antecedentes.Rows[i]["has"].ToString();
                    str_diabetes = antecedentes.Rows[i]["diabetes"].ToString();
                    str_dislipidemias = antecedentes.Rows[i]["dislipidemias"].ToString();
                    str_tabaquismo = antecedentes.Rows[i]["tabaquismo"].ToString();
                    str_sedentarismo = antecedentes.Rows[i]["sedentarismo"].ToString();
                    str_obesidad = antecedentes.Rows[i]["obesidad"].ToString();
                    str_historiafm60 = antecedentes.Rows[i]["historiafm60"].ToString();
                    str_diagnosticoeac = antecedentes.Rows[i]["diagnosticoeac"].ToString();
                    str_anginaest = antecedentes.Rows[i]["anginaest"].ToString();
                    str_cf = antecedentes.Rows[i]["cf"].ToString();
                    str_im = antecedentes.Rows[i]["im"].ToString();
                    str_angioplastia = antecedentes.Rows[i]["angioplastia"].ToString();
                    str_cirugia = antecedentes.Rows[i]["cirugia"].ToString();
                    str_arritmias = antecedentes.Rows[i]["arritmias"].ToString();
                    str_sv = antecedentes.Rows[i]["sv"].ToString();
                    str_bloqueoav = antecedentes.Rows[i]["bloqueoav"].ToString();
                    str_mpd = antecedentes.Rows[i]["mpd"].ToString();
                    str_acv = antecedentes.Rows[i]["acv"].ToString();
                    str_enfcarotidea = antecedentes.Rows[i]["enfcarotidea"].ToString();
                    str_enfperiferica = antecedentes.Rows[i]["enfperiferica"].ToString();
                    str_chagas = antecedentes.Rows[i]["chagas"].ToString();
                    str_cardreumatica = antecedentes.Rows[i]["cardreumatica"].ToString();
                    str_hpaciente = antecedentes.Rows[i]["hpaciente"].ToString();
                    str_hmotivo = antecedentes.Rows[i]["hmotivo"].ToString();
                }
                if (str_has == "1") { hassi.Checked = true; } else { hasno.Checked = true; }
                if (str_diabetes == "1") { diabetessi.Checked = true; } else { diabetesno.Checked = true; }
                if (str_dislipidemias == "1") { dislipidemiassi.Checked = true; } else { dislipidemiasno.Checked = true; }
                if (str_tabaquismo == "1") { tabaquismosi.Checked = true; } else { tabaquismono.Checked = true; }
                if (str_sedentarismo == "1") { sedentarismosi.Checked = true; } else { sedentarismono.Checked = true; }
                if (str_obesidad == "1") { obesidadsi.Checked = true; } else { obesidadno.Checked = true; }
                if (str_historiafm60 == "1") { historiafm60si.Checked = true; } else { historiafm60no.Checked = true; }
                if (str_diagnosticoeac == "1") { diagnosticoeacsi.Checked = true; } else { diagnosticoeacno.Checked = true; }
                if (str_anginaest == "1") { anginaestsi.Checked = true; } else { anginaestno.Checked = true; }
                if (str_cf == "1") { cfsi.Checked = true; } else { cfno.Checked = true; }
                if (str_im == "1") { imsi.Checked = true; } else { imno.Checked = true; }
                if (str_angioplastia == "1") { angioplastiasi.Checked = true; } else { angioplastiano.Checked = true; }
                if (str_cirugia == "1") { cirugiasi.Checked = true; } else { cirugiano.Checked = true; }
                if (str_arritmias == "1") { arritmiassi.Checked = true; } else { arritmiasno.Checked = true; }
                if (str_sv == "1") { svsi.Checked = true; } else { svno.Checked = true; }
                if (str_bloqueoav == "1") { bloqueoavsi.Checked = true; } else { bloqueoavno.Checked = true; }
                if (str_mpd == "1") { mpdsi.Checked = true; } else { mpdno.Checked = true; }
                if (str_acv == "1") { acvsi.Checked = true; } else { acvno.Checked = true; }
                if (str_enfcarotidea == "1") { enfcarotideasi.Checked = true; } else { enfcarotideano.Checked = true; }
                if (str_enfperiferica == "1") { enfperifericasi.Checked = true; } else { enfperifericano.Checked = true; }
                if (str_chagas == "1") { chagassi.Checked = true; } else { chagasno.Checked = true; }
                if (str_cardreumatica == "1") { cardreumaticasi.Checked = true; } else { cardreumaticano.Checked = true; }
                if (str_hmotivo == "1") { motivo1.Checked = true; }
                if (str_hmotivo == "2") { motivo2.Checked = true; }
                if (str_hmotivo == "3") { motivo3.Checked = true; }
                if (str_hmotivo == "4") { motivo4.Checked = true; }
                if (str_hmotivo == "5") { motivo5.Checked = true; }
                if (str_hmotivo == "6") { motivo6.Checked = true; }
                if (str_hmotivo == "7") { motivo7.Checked = true; }
                if (str_hmotivo == "8") { motivo8.Checked = true; }
                if (str_hmotivo == "9") { motivo9.Checked = true; }
                hassi.Enabled = false;
                hasno.Enabled = false;
                diabetessi.Enabled = false;
                diabetesno.Enabled = false;
                dislipidemiassi.Enabled = false;
                dislipidemiasno.Enabled = false;
                tabaquismosi.Enabled = false;
                tabaquismono.Enabled = false;
                sedentarismosi.Enabled = false;
                sedentarismono.Enabled = false;
                obesidadsi.Enabled = false;
                obesidadno.Enabled = false;
                historiafm60si.Enabled = false;
                historiafm60no.Enabled = false;
                diagnosticoeacsi.Enabled = false;
                diagnosticoeacno.Enabled = false;
                anginaestsi.Enabled = false;
                anginaestno.Enabled = false;
                cfsi.Enabled = false;
                cfno.Enabled = false;
                imsi.Enabled = false;
                imno.Enabled = false;
                angioplastiasi.Enabled = false;
                angioplastiano.Enabled = false;
                cirugiasi.Enabled = false;
                cirugiano.Enabled = false;
                arritmiassi.Enabled = false;
                arritmiasno.Enabled = false;
                svsi.Enabled = false;
                svno.Enabled = false;
                bloqueoavsi.Enabled = false;
                bloqueoavno.Enabled = false;
                mpdsi.Enabled = false;
                mpdno.Enabled = false;
                acvsi.Enabled = false;
                acvno.Enabled = false;
                enfcarotideasi.Enabled = false;
                enfcarotideano.Enabled = false;
                enfperifericasi.Enabled = false;
                enfperifericano.Enabled = false;
                chagassi.Enabled = false;
                chagasno.Enabled = false;
                cardreumaticasi.Enabled = false;
                cardreumaticano.Enabled = false;
                motivo1.Enabled = false;
                motivo2.Enabled = false;
                motivo3.Enabled = false;
                motivo4.Enabled = false;
                motivo5.Enabled = false;
                motivo6.Enabled = false;
                motivo7.Enabled = false;
                motivo8.Enabled = false;
                motivo9.Enabled = false;
            }
            else
            {
                Button1.Visible = true;
                Button2.Visible = false;
                Button3.Visible = false;
                hassi.Enabled = true;
                hasno.Enabled = true;
                diabetessi.Enabled = true;
                diabetesno.Enabled = true;
                dislipidemiassi.Enabled = true;
                dislipidemiasno.Enabled = true;
                tabaquismosi.Enabled = true;
                tabaquismono.Enabled = true;
                sedentarismosi.Enabled = true;
                sedentarismono.Enabled = true;
                obesidadsi.Enabled = true;
                obesidadno.Enabled = true;
                historiafm60si.Enabled = true;
                historiafm60no.Enabled = true;
                diagnosticoeacsi.Enabled = true;
                diagnosticoeacno.Enabled = true;
                anginaestsi.Enabled = true;
                anginaestno.Enabled = true;
                cfsi.Enabled = true;
                cfno.Enabled = true;
                imsi.Enabled = true;
                imno.Enabled = true;
                angioplastiasi.Enabled = true;
                angioplastiano.Enabled = true;
                cirugiasi.Enabled = true;
                cirugiano.Enabled = true;
                arritmiassi.Enabled = true;
                arritmiasno.Enabled = true;
                svsi.Enabled = true; 
                svno.Enabled = true;
                bloqueoavsi.Enabled = true;
                bloqueoavno.Enabled = true;
                mpdsi.Enabled = true;
                mpdno.Enabled = true;
                acvsi.Enabled = true;
                acvno.Enabled = true;
                enfcarotideasi.Enabled = true;
                enfcarotideano.Enabled = true;
                enfperifericasi.Enabled = true;
                enfperifericano.Enabled = true;
                chagassi.Enabled = true;
                chagasno.Enabled = true;
                cardreumaticasi.Enabled = true;
                cardreumaticano.Enabled = true;
                motivo1.Enabled = true;
                motivo2.Enabled = true;
                motivo3.Enabled = true;
                motivo4.Enabled = true;
                motivo5.Enabled = true;
                motivo6.Enabled = true;
                motivo7.Enabled = true;
                motivo8.Enabled = true;
                motivo9.Enabled = true;
            }

        }
        protected void Guardar(object sender, EventArgs e)
        {
            string str_has = "";
            string str_diabetes = "";
            string str_dislipidemias = "";
            string str_tabaquismo = "";
            string str_sedentarismo = "";
            string str_obesidad = "";
            string str_historiafm60 = "";
            string str_diagnosticoeac = "";
            string str_anginaest = "";
            string str_cf = "";
            string str_im = "";
            string str_angioplastia = "";
            string str_cirugia = "";
            string str_arritmias = "";
            string str_sv = "";
            string str_bloqueoav = "";
            string str_mpd = "";
            string str_acv = "";
            string str_enfcarotidea = "";
            string str_enfperiferica = "";
            string str_chagas = "";
            string str_cardreumatica = "";
            string str_hmotivo = "";
            if (((hassi.Checked == false) && (hasno.Checked == false)) ||
            ((diabetessi.Checked == false) && (diabetesno.Checked == false)) ||
            ((dislipidemiassi.Checked == false) && (dislipidemiasno.Checked == false)) ||
            ((tabaquismosi.Checked == false) && (tabaquismono.Checked == false)) ||
            ((sedentarismosi.Checked == false) && (sedentarismono.Checked == false)) ||
            ((obesidadsi.Checked == false) && (obesidadno.Checked == false)) ||
            ((historiafm60si.Checked == false) && (historiafm60no.Checked == false)) ||
            ((diagnosticoeacsi.Checked == false) && (diagnosticoeacno.Checked == false)) ||
            ((anginaestsi.Checked == false) && (anginaestno.Checked == false)) ||
            ((cfsi.Checked == false) && (cfno.Checked == false)) ||
            ((imsi.Checked == false) && (imno.Checked == false)) ||
            ((angioplastiasi.Checked == false) && (angioplastiano.Checked == false)) ||
            ((cirugiasi.Checked == false) && (cirugiano.Checked == false)) ||
            ((arritmiassi.Checked == false) && (arritmiasno.Checked == false)) ||
            ((svsi.Checked == false) && (svno.Checked == false)) ||
            ((bloqueoavsi.Checked == false) && (bloqueoavno.Checked == false)) ||
            ((mpdsi.Checked == false) && (mpdno.Checked == false)) ||
            ((acvsi.Checked == false) && (acvno.Checked == false)) ||
            ((enfcarotideasi.Checked == false) && (enfcarotideano.Checked == false)) ||
            ((enfperifericasi.Checked == false) && (enfperifericano.Checked == false)) ||
            ((chagassi.Checked == false) && (chagasno.Checked == false)) ||
            ((cardreumaticasi.Checked == false) && (cardreumaticano.Checked == false)) ||
            ((motivo1.Checked == false) && (motivo2.Checked == false) && (motivo3.Checked == false) && (motivo4.Checked == false) && (motivo5.Checked == false) && (motivo6.Checked == false) && (motivo7.Checked == false) && (motivo8.Checked == false) && (motivo9.Checked == false)))
            {
                if ((hassi.Checked == false) && (hasno.Checked == false)) { Label9.Text = "*"; }
                if ((diabetessi.Checked == false) && (diabetesno.Checked == false)) { LblV1.Text = "*"; }
                if ((dislipidemiassi.Checked == false) && (dislipidemiasno.Checked == false)) { Label2.Text = "*"; }
                if ((tabaquismosi.Checked == false) && (tabaquismono.Checked == false)) { Label3.Text = "*"; }
                if ((sedentarismosi.Checked == false) && (sedentarismono.Checked == false)) { Label4.Text = "*"; }
                if ((obesidadsi.Checked == false) && (obesidadno.Checked == false)) { Label5.Text = "*"; }
                if ((historiafm60si.Checked == false) && (historiafm60no.Checked == false)) { Label6.Text = "*"; }
                if ((diagnosticoeacsi.Checked == false) && (diagnosticoeacno.Checked == false)) { Label7.Text = "*"; }
                if ((anginaestsi.Checked == false) && (anginaestno.Checked == false)) { Label8.Text = "*"; }
                if ((cfsi.Checked == false) && (cfno.Checked == false)) { Label10.Text = "*"; }
                if ((imsi.Checked == false) && (imno.Checked == false)) { Label11.Text = "*"; }
                if ((angioplastiasi.Checked == false) && (angioplastiano.Checked == false)) { Label12.Text = "*"; }
                if ((cirugiasi.Checked == false) && (cirugiano.Checked == false)) { Label13.Text = "*"; }
                if ((arritmiassi.Checked == false) && (arritmiasno.Checked == false)) { Label14.Text = "*"; }
                if ((svsi.Checked == false) && (svno.Checked == false)) { Label15.Text = "*"; }
                if ((bloqueoavsi.Checked == false) && (bloqueoavno.Checked == false)) { Label16.Text = "*"; }
                if ((mpdsi.Checked == false) && (mpdno.Checked == false)) { Label17.Text = "*"; }
                if ((acvsi.Checked == false) && (acvno.Checked == false)) { Label18.Text = "*"; }
                if ((enfcarotideasi.Checked == false) && (enfcarotideano.Checked == false)) { Label19.Text = "*"; }
                if ((enfperifericasi.Checked == false) && (enfperifericano.Checked == false)) { Label20.Text = "*"; }
                if ((chagassi.Checked == false) && (chagasno.Checked == false)) { Label21.Text = "*"; }
                if ((cardreumaticasi.Checked == false) && (cardreumaticano.Checked == false)) { Label22.Text = "*"; }
                if ((motivo1.Checked == false) && (motivo2.Checked == false) && (motivo3.Checked == false) && (motivo4.Checked == false) && (motivo5.Checked == false) && (motivo6.Checked == false) && (motivo7.Checked == false) && (motivo8.Checked == false) && (motivo9.Checked == false))
                {
                    Label23.Text = "*";
                }
            }
            else
            {
                if (hassi.Checked == true) { str_has = "1"; }
                if (hasno.Checked == true) { str_has = "0"; }
                if (diabetessi.Checked == true) { str_diabetes = "1"; }
                if (diabetesno.Checked == true) { str_diabetes = "0"; }
                if (dislipidemiassi.Checked == true) { str_dislipidemias = "1"; }
                if (dislipidemiasno.Checked == true) { str_dislipidemias = "0"; }
                if (tabaquismosi.Checked == true) { str_tabaquismo = "1"; }
                if (tabaquismono.Checked == true) { str_tabaquismo = "0"; }
                if (sedentarismosi.Checked == true) { str_sedentarismo = "1"; }
                if (sedentarismono.Checked == true) { str_sedentarismo = "0"; }
                if (obesidadsi.Checked == true) { str_obesidad = "1"; }
                if (obesidadno.Checked == true) { str_obesidad = "0"; }
                if (historiafm60si.Checked == true) { str_historiafm60 = "1"; }
                if (historiafm60no.Checked == true) { str_historiafm60 = "0"; }
                if (diagnosticoeacsi.Checked == true) { str_diagnosticoeac = "1"; }
                if (diagnosticoeacno.Checked == true) { str_diagnosticoeac = "0"; }
                if (anginaestsi.Checked == true) { str_anginaest = "1"; }
                if (anginaestno.Checked == true) { str_anginaest = "0"; }
                if (cfsi.Checked == true) { str_cf = "1"; }
                if (cfno.Checked == true) { str_cf = "0"; }
                if (imsi.Checked == true) { str_im = "1"; }
                if (imno.Checked == true) { str_im = "0"; }
                if (angioplastiasi.Checked == true) { str_angioplastia = "1"; }
                if (angioplastiano.Checked == true) { str_angioplastia = "0"; }
                if (cirugiasi.Checked == true) { str_cirugia = "1"; }
                if (cirugiano.Checked == true) { str_cirugia = "0"; }
                if (arritmiassi.Checked == true) { str_arritmias = "1"; }
                if (arritmiasno.Checked == true) { str_arritmias = "0"; }
                if (svsi.Checked == true) { str_sv = "1"; }
                if (svno.Checked == true) { str_sv = "0"; }
                if (bloqueoavsi.Checked == true) { str_bloqueoav = "1"; }
                if (bloqueoavno.Checked == true) { str_bloqueoav = "0"; }
                if (mpdsi.Checked == true) { str_mpd = "1"; }
                if (mpdno.Checked == true) { str_mpd = "0"; }
                if (acvsi.Checked == true) { str_acv = "1"; }
                if (acvno.Checked == true) { str_acv = "0"; }
                if (enfcarotideasi.Checked == true) { str_enfcarotidea = "1"; }
                if (enfcarotideano.Checked == true) { str_enfcarotidea = "0"; }
                if (enfperifericasi.Checked == true) { str_enfperiferica = "1"; }
                if (enfperifericano.Checked == true) { str_enfperiferica = "0"; }
                if (chagassi.Checked == true) { str_chagas = "1"; }
                if (chagasno.Checked == true) { str_chagas = "0"; }
                if (cardreumaticasi.Checked == true) { str_cardreumatica = "1"; }
                if (cardreumaticano.Checked == true) { str_cardreumatica = "0"; }
                if (motivo1.Checked == true) { str_hmotivo = "1"; }
                if (motivo2.Checked == true) { str_hmotivo = "2"; }
                if (motivo3.Checked == true) { str_hmotivo = "3"; }
                if (motivo4.Checked == true) { str_hmotivo = "4"; }
                if (motivo5.Checked == true) { str_hmotivo = "5"; }
                if (motivo6.Checked == true) { str_hmotivo = "6"; }
                if (motivo7.Checked == true) { str_hmotivo = "7"; }
                if (motivo8.Checked == true) { str_hmotivo = "8"; }
                if (motivo9.Checked == true) { str_hmotivo = "9"; }
                DBConnect conexion = new DBConnect();
                string sql = conexion.iantecedente(
                                                    vhpaciente.Value, 
                                                    str_has, 
                                                    str_diabetes, 
                                                    str_dislipidemias, 
                                                    str_tabaquismo, 
                                                    str_sedentarismo, 
                                                    str_obesidad, 
                                                    str_historiafm60, 
                                                    str_diagnosticoeac, 
                                                    str_anginaest, 
                                                    str_cf, 
                                                    str_im, 
                                                    str_angioplastia, 
                                                    str_cirugia, 
                                                    str_arritmias, 
                                                    str_sv, 
                                                    str_bloqueoav, 
                                                    str_mpd, 
                                                    str_acv, 
                                                    str_enfcarotidea, 
                                                    str_enfperiferica, 
                                                    str_chagas, 
                                                    str_cardreumatica,
                                                    vhpaciente.Value, 
                                                    str_hmotivo);
                 Label24.Text = sql;   
           }
        }
        protected void Actualizar(object sender, EventArgs e)
        {
            string str_has = "";
            string str_diabetes = "";
            string str_dislipidemias = "";
            string str_tabaquismo = "";
            string str_sedentarismo = "";
            string str_obesidad = "";
            string str_historiafm60 = "";
            string str_diagnosticoeac = "";
            string str_anginaest = "";
            string str_cf = "";
            string str_im = "";
            string str_angioplastia = "";
            string str_cirugia = "";
            string str_arritmias = "";
            string str_sv = "";
            string str_bloqueoav = "";
            string str_mpd = "";
            string str_acv = "";
            string str_enfcarotidea = "";
            string str_enfperiferica = "";
            string str_chagas = "";
            string str_cardreumatica = "";
            string str_hmotivo = "";
            if (((hassi.Checked == false) && (hasno.Checked == false)) ||
            ((diabetessi.Checked == false) && (diabetesno.Checked == false)) ||
            ((dislipidemiassi.Checked == false) && (dislipidemiasno.Checked == false)) ||
            ((tabaquismosi.Checked == false) && (tabaquismono.Checked == false)) ||
            ((sedentarismosi.Checked == false) && (sedentarismono.Checked == false)) ||
            ((obesidadsi.Checked == false) && (obesidadno.Checked == false)) ||
            ((historiafm60si.Checked == false) && (historiafm60no.Checked == false)) ||
            ((diagnosticoeacsi.Checked == false) && (diagnosticoeacno.Checked == false)) ||
            ((anginaestsi.Checked == false) && (anginaestno.Checked == false)) ||
            ((cfsi.Checked == false) && (cfno.Checked == false)) ||
            ((imsi.Checked == false) && (imno.Checked == false)) ||
            ((angioplastiasi.Checked == false) && (angioplastiano.Checked == false)) ||
            ((cirugiasi.Checked == false) && (cirugiano.Checked == false)) ||
            ((arritmiassi.Checked == false) && (arritmiasno.Checked == false)) ||
            ((svsi.Checked == false) && (svno.Checked == false)) ||
            ((bloqueoavsi.Checked == false) && (bloqueoavno.Checked == false)) ||
            ((mpdsi.Checked == false) && (mpdno.Checked == false)) ||
            ((acvsi.Checked == false) && (acvno.Checked == false)) ||
            ((enfcarotideasi.Checked == false) && (enfcarotideano.Checked == false)) ||
            ((enfperifericasi.Checked == false) && (enfperifericano.Checked == false)) ||
            ((chagassi.Checked == false) && (chagasno.Checked == false)) ||
            ((cardreumaticasi.Checked == false) && (cardreumaticano.Checked == false)) ||
            ((motivo1.Checked == false) && (motivo2.Checked == false) && (motivo3.Checked == false) && (motivo4.Checked == false) && (motivo5.Checked == false) && (motivo6.Checked == false) && (motivo7.Checked == false) && (motivo8.Checked == false) && (motivo9.Checked == false)))
            {
                if ((hassi.Checked == false) && (hasno.Checked == false)) { Label9.Text = "*"; }
                if ((diabetessi.Checked == false) && (diabetesno.Checked == false)) { LblV1.Text = "*"; }
                if ((dislipidemiassi.Checked == false) && (dislipidemiasno.Checked == false)) { Label2.Text = "*"; }
                if ((tabaquismosi.Checked == false) && (tabaquismono.Checked == false)) { Label3.Text = "*"; }
                if ((sedentarismosi.Checked == false) && (sedentarismono.Checked == false)) { Label4.Text = "*"; }
                if ((obesidadsi.Checked == false) && (obesidadno.Checked == false)) { Label5.Text = "*"; }
                if ((historiafm60si.Checked == false) && (historiafm60no.Checked == false)) { Label6.Text = "*"; }
                if ((diagnosticoeacsi.Checked == false) && (diagnosticoeacno.Checked == false)) { Label7.Text = "*"; }
                if ((anginaestsi.Checked == false) && (anginaestno.Checked == false)) { Label8.Text = "*"; }
                if ((cfsi.Checked == false) && (cfno.Checked == false)) { Label10.Text = "*"; }
                if ((imsi.Checked == false) && (imno.Checked == false)) { Label11.Text = "*"; }
                if ((angioplastiasi.Checked == false) && (angioplastiano.Checked == false)) { Label12.Text = "*"; }
                if ((cirugiasi.Checked == false) && (cirugiano.Checked == false)) { Label13.Text = "*"; }
                if ((arritmiassi.Checked == false) && (arritmiasno.Checked == false)) { Label14.Text = "*"; }
                if ((svsi.Checked == false) && (svno.Checked == false)) { Label15.Text = "*"; }
                if ((bloqueoavsi.Checked == false) && (bloqueoavno.Checked == false)) { Label16.Text = "*"; }
                if ((mpdsi.Checked == false) && (mpdno.Checked == false)) { Label17.Text = "*"; }
                if ((acvsi.Checked == false) && (acvno.Checked == false)) { Label18.Text = "*"; }
                if ((enfcarotideasi.Checked == false) && (enfcarotideano.Checked == false)) { Label19.Text = "*"; }
                if ((enfperifericasi.Checked == false) && (enfperifericano.Checked == false)) { Label20.Text = "*"; }
                if ((chagassi.Checked == false) && (chagasno.Checked == false)) { Label21.Text = "*"; }
                if ((cardreumaticasi.Checked == false) && (cardreumaticano.Checked == false)) { Label22.Text = "*"; }
                if ((motivo1.Checked == false) && (motivo2.Checked == false) && (motivo3.Checked == false) && (motivo4.Checked == false) && (motivo5.Checked == false) && (motivo6.Checked == false) && (motivo7.Checked == false) && (motivo8.Checked == false) && (motivo9.Checked == false))
                {
                    Label23.Text = "*";
                }
            }
            else
            {
                if (hassi.Checked == true) { str_has = "1"; }
                if (hasno.Checked == true) { str_has = "0"; }
                if (diabetessi.Checked == true) { str_diabetes = "1"; }
                if (diabetesno.Checked == true) { str_diabetes = "0"; }
                if (dislipidemiassi.Checked == true) { str_dislipidemias = "1"; }
                if (dislipidemiasno.Checked == true) { str_dislipidemias = "0"; }
                if (tabaquismosi.Checked == true) { str_tabaquismo = "1"; }
                if (tabaquismono.Checked == true) { str_tabaquismo = "0"; }
                if (sedentarismosi.Checked == true) { str_sedentarismo = "1"; }
                if (sedentarismono.Checked == true) { str_sedentarismo = "0"; }
                if (obesidadsi.Checked == true) { str_obesidad = "1"; }
                if (obesidadno.Checked == true) { str_obesidad = "0"; }
                if (historiafm60si.Checked == true) { str_historiafm60 = "1"; }
                if (historiafm60no.Checked == true) { str_historiafm60 = "0"; }
                if (diagnosticoeacsi.Checked == true) { str_diagnosticoeac = "1"; }
                if (diagnosticoeacno.Checked == true) { str_diagnosticoeac = "0"; }
                if (anginaestsi.Checked == true) { str_anginaest = "1"; }
                if (anginaestno.Checked == true) { str_anginaest = "0"; }
                if (cfsi.Checked == true) { str_cf = "1"; }
                if (cfno.Checked == true) { str_cf = "0"; }
                if (imsi.Checked == true) { str_im = "1"; }
                if (imno.Checked == true) { str_im = "0"; }
                if (angioplastiasi.Checked == true) { str_angioplastia = "1"; }
                if (angioplastiano.Checked == true) { str_angioplastia = "0"; }
                if (cirugiasi.Checked == true) { str_cirugia = "1"; }
                if (cirugiano.Checked == true) { str_cirugia = "0"; }
                if (arritmiassi.Checked == true) { str_arritmias = "1"; }
                if (arritmiasno.Checked == true) { str_arritmias = "0"; }
                if (svsi.Checked == true) { str_sv = "1"; }
                if (svno.Checked == true) { str_sv = "0"; }
                if (bloqueoavsi.Checked == true) { str_bloqueoav = "1"; }
                if (bloqueoavno.Checked == true) { str_bloqueoav = "0"; }
                if (mpdsi.Checked == true) { str_mpd = "1"; }
                if (mpdno.Checked == true) { str_mpd = "0"; }
                if (acvsi.Checked == true) { str_acv = "1"; }
                if (acvno.Checked == true) { str_acv = "0"; }
                if (enfcarotideasi.Checked == true) { str_enfcarotidea = "1"; }
                if (enfcarotideano.Checked == true) { str_enfcarotidea = "0"; }
                if (enfperifericasi.Checked == true) { str_enfperiferica = "1"; }
                if (enfperifericano.Checked == true) { str_enfperiferica = "0"; }
                if (chagassi.Checked == true) { str_chagas = "1"; }
                if (chagasno.Checked == true) { str_chagas = "0"; }
                if (cardreumaticasi.Checked == true) { str_cardreumatica = "1"; }
                if (cardreumaticano.Checked == true) { str_cardreumatica = "0"; }
                if (motivo1.Checked == true) { str_hmotivo = "1"; }
                if (motivo2.Checked == true) { str_hmotivo = "2"; }
                if (motivo3.Checked == true) { str_hmotivo = "3"; }
                if (motivo4.Checked == true) { str_hmotivo = "4"; }
                if (motivo5.Checked == true) { str_hmotivo = "5"; }
                if (motivo6.Checked == true) { str_hmotivo = "6"; }
                if (motivo7.Checked == true) { str_hmotivo = "7"; }
                if (motivo8.Checked == true) { str_hmotivo = "8"; }
                if (motivo9.Checked == true) { str_hmotivo = "9"; }
                Button1.Visible = false;
                Button2.Visible = true;
                Button3.Visible = false;
                hassi.Enabled = false;
                hasno.Enabled = false;
                diabetessi.Enabled = false;
                diabetesno.Enabled = false;
                dislipidemiassi.Enabled = false;
                dislipidemiasno.Enabled = false;
                tabaquismosi.Enabled = false;
                tabaquismono.Enabled = false;
                sedentarismosi.Enabled = false;
                sedentarismono.Enabled = false;
                obesidadsi.Enabled = false;
                obesidadno.Enabled = false;
                historiafm60si.Enabled = false;
                historiafm60no.Enabled = false;
                diagnosticoeacsi.Enabled = false;
                diagnosticoeacno.Enabled = false;
                anginaestsi.Enabled = false;
                anginaestno.Enabled = false;
                cfsi.Enabled = false;
                cfno.Enabled = false;
                imsi.Enabled = false;
                imno.Enabled = false;
                angioplastiasi.Enabled = false;
                angioplastiano.Enabled = false;
                cirugiasi.Enabled = false;
                cirugiano.Enabled = false;
                arritmiassi.Enabled = false;
                arritmiasno.Enabled = false;
                svsi.Enabled = false;
                svno.Enabled = false;
                bloqueoavsi.Enabled = false;
                bloqueoavno.Enabled = false;
                mpdsi.Enabled = false;
                mpdno.Enabled = false;
                acvsi.Enabled = false;
                acvno.Enabled = false;
                enfcarotideasi.Enabled = false;
                enfcarotideano.Enabled = false;
                enfperifericasi.Enabled = false;
                enfperifericano.Enabled = false;
                chagassi.Enabled = false;
                chagasno.Enabled = false;
                cardreumaticasi.Enabled = false;
                cardreumaticano.Enabled = false;
                motivo1.Enabled = false;
                motivo2.Enabled = false;
                motivo3.Enabled = false;
                motivo4.Enabled = false;
                motivo5.Enabled = false;
                motivo6.Enabled = false;
                motivo7.Enabled = false;
                motivo8.Enabled = false;
                motivo9.Enabled = false;
                DBConnect conexion = new DBConnect();
                string sql = conexion.uantecedente(vhpaciente.Value, 
                                                    str_has, 
                                                    str_diabetes, 
                                                    str_dislipidemias, 
                                                    str_tabaquismo, 
                                                    str_sedentarismo, 
                                                    str_obesidad, 
                                                    str_historiafm60, 
                                                    str_diagnosticoeac, 
                                                    str_anginaest, 
                                                    str_cf, 
                                                    str_im, 
                                                    str_angioplastia, 
                                                    str_cirugia, 
                                                    str_arritmias, 
                                                    str_sv, 
                                                    str_bloqueoav, 
                                                    str_mpd, 
                                                    str_acv, 
                                                    str_enfcarotidea, 
                                                    str_enfperiferica, 
                                                    str_chagas, 
                                                    str_cardreumatica,
                                                    vhpaciente.Value, 
                                                    str_hmotivo);
                 Label24.Text = sql;
           }
        } 
        protected void Modificar(object sender, EventArgs e)
        {
            Button1.Visible = false;
            Button2.Visible = false;
            Button3.Visible = true;
            hassi.Enabled = true;
            hasno.Enabled = true;
            diabetessi.Enabled = true;
            diabetesno.Enabled = true;
            dislipidemiassi.Enabled = true;
            dislipidemiasno.Enabled = true;
            tabaquismosi.Enabled = true;
            tabaquismono.Enabled = true;
            sedentarismosi.Enabled = true;
            sedentarismono.Enabled = true;
            obesidadsi.Enabled = true;
            obesidadno.Enabled = true;
            historiafm60si.Enabled = true;
            historiafm60no.Enabled = true;
            diagnosticoeacsi.Enabled = true;
            diagnosticoeacno.Enabled = true;
            anginaestsi.Enabled = true;
            anginaestno.Enabled = true;
            cfsi.Enabled = true;
            cfno.Enabled = true;
            imsi.Enabled = true;
            imno.Enabled = true;
            angioplastiasi.Enabled = true;
            angioplastiano.Enabled = true;
            cirugiasi.Enabled = true;
            cirugiano.Enabled = true;
            arritmiassi.Enabled = true;
            arritmiasno.Enabled = true;
            svsi.Enabled = true;
            svno.Enabled = true;
            bloqueoavsi.Enabled = true;
            bloqueoavno.Enabled = true;
            mpdsi.Enabled = true;
            mpdno.Enabled = true;
            acvsi.Enabled = true;
            acvno.Enabled = true;
            enfcarotideasi.Enabled = true;
            enfcarotideano.Enabled = true;
            enfperifericasi.Enabled = true;
            enfperifericano.Enabled = true;
            chagassi.Enabled = true;
            chagasno.Enabled = true;
            cardreumaticasi.Enabled = true;
            cardreumaticano.Enabled = true;
            motivo1.Enabled = true;
            motivo2.Enabled = true;
            motivo3.Enabled = true;
            motivo4.Enabled = true;
            motivo5.Enabled = true;
            motivo6.Enabled = true;
            motivo7.Enabled = true;
            motivo8.Enabled = true;
            motivo9.Enabled = true;
        }
    }
}
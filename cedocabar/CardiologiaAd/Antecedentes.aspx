<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Antecedentes.aspx.cs" Inherits="cedocabar.CardiologiaAd.Antecedentes" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
	<link rel="stylesheet" type="text/css" href="~/Styles/Skin Style.css" />
	<link rel="stylesheet" type="text/css" href="~/Styles/style.css" />
	<link rel="stylesheet" type="text/css" href="~/Styles/subModal.css" />
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />

</head>
<body>
     <form id="form1" target="_self" runat="server">      
    <center>
    <table width="700" border="0" cellspacing="0" cellpadding="0">
            <tr>
                <td align="center" class="nombreform">
                    <asp:Label ID="Label1" CssClass="main" runat="server" Text="ANTECEDENTES PERSONALES DEL PACIENTE"></asp:Label>
                </td>
            </tr>
     </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
  <tr>
      <td align="left" class="loginDisplay" width="150">Motivo de Ingreso:</td>
      <td align="left" class="loginDisplay">
      <asp:RadioButton ID="motivo1" GroupName="motivo" runat="server" Text="Dolor Toraxico" />
      <asp:RadioButton ID="motivo2" GroupName="motivo" runat="server" Text="Disnea" />
      <asp:RadioButton ID="motivo3" GroupName="motivo" runat="server" Text="Palpitaciones" />
      <asp:RadioButton ID="motivo4" GroupName="motivo" runat="server" Text="Desmayo" />
      <asp:RadioButton ID="motivo5" GroupName="motivo" runat="server" Text="Debilidad" />
      <asp:RadioButton ID="motivo6" GroupName="motivo" runat="server" Text="Mareo" />
      <asp:RadioButton ID="motivo7" GroupName="motivo" runat="server" Text="Cefalea" />
      <asp:RadioButton ID="motivo8" GroupName="motivo" runat="server" Text="Sintomas Neurovegetativos" />
      <asp:RadioButton ID="motivo9" GroupName="motivo" runat="server" Text="PCR Resucitado" />
      </td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label23" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img23" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
  </tr>
  </table>
    <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="200">HAS:</td>
      <td align="left" class="loginDisplay"><asp:RadioButton ID="hassi" GroupName="has" runat="server" Text="Si" /><asp:RadioButton ID="hasno" GroupName="has" Text="No" runat="server"/></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label9" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img14" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="200">Diabetes</td>
      <td align="left" class="loginDisplay"><asp:RadioButton ID="diabetessi" GroupName="diabetes" runat="server" Text="Si" /><asp:RadioButton ID="diabetesno" GroupName="diabetes" Text="No" runat="server"/></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="LblV1" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img1" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
    <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="200">Dislipidemias:</td>
      <td align="left" class="loginDisplay"><asp:RadioButton ID="dislipidemiassi" GroupName="dislipidemias" runat="server" Text="Si" /><asp:RadioButton ID="dislipidemiasno" GroupName="dislipidemias" Text="No" runat="server"/></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label2" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img2" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="200">Tabaquismo:</td>
      <td align="left" class="loginDisplay"><asp:RadioButton ID="tabaquismosi" GroupName="tabaquismo" runat="server" Text="Si" /><asp:RadioButton ID="tabaquismono" GroupName="tabaquismo" Text="No" runat="server"/></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label3" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img3" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="200">Sedentarismo:</td>
      <td align="left" class="loginDisplay"><asp:RadioButton ID="sedentarismosi" GroupName="sedentarismo" runat="server" Text="Si" /><asp:RadioButton ID="sedentarismono" GroupName="sedentarismo" Text="No" runat="server"/></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label4" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img4" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="200">Obesidad:</td>
      <td align="left" class="loginDisplay"><asp:RadioButton ID="obesidadsi" GroupName="obesidad" runat="server" Text="Si" /><asp:RadioButton ID="obesidadno" GroupName="obesidad" Text="No" runat="server"/></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label5" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img5" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>   
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="200">Historia Familiares < 60 años:</td>
      <td align="left" class="loginDisplay"><asp:RadioButton ID="historiafm60si" GroupName="historiafm60" runat="server" Text="Si" /><asp:RadioButton ID="historiafm60no" GroupName="historiafm60" Text="No" runat="server"/></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label6" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img6" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="200">Diagnostico EAC:</td>
      <td align="left" class="loginDisplay"><asp:RadioButton ID="diagnosticoeacsi" GroupName="diagnosticoeac" runat="server" Text="Si" /><asp:RadioButton ID="diagnosticoeacno" GroupName="diagnosticoeac" Text="No" runat="server"/></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label7" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img7" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="200">Angina Estable:</td>
      <td align="left" class="loginDisplay"><asp:RadioButton ID="anginaestsi" GroupName="anginaest" runat="server" Text="Si" /><asp:RadioButton ID="anginaestno" GroupName="anginaest" Text="No" runat="server"/></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label8" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img8" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="200">CF:</td>
      <td align="left" class="loginDisplay"><asp:RadioButton ID="cfsi" GroupName="cf" runat="server" Text="Si" /><asp:RadioButton ID="cfno" GroupName="cf" Text="No" runat="server"/></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label10" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img9" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="200">IM:</td>
      <td align="left" class="loginDisplay"><asp:RadioButton ID="imsi" GroupName="im" runat="server" Text="Si" /><asp:RadioButton ID="imno" GroupName="im" Text="No" runat="server"/></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label11" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img10" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="200">Angioplastia:</td>
      <td align="left" class="loginDisplay"><asp:RadioButton ID="angioplastiasi" GroupName="angioplastia" runat="server" Text="Si" /><asp:RadioButton ID="angioplastiano" GroupName="angioplastia" Text="No" runat="server"/></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label12" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img11" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="200">Cirugia:</td>
      <td align="left" class="loginDisplay"><asp:RadioButton ID="cirugiasi" GroupName="cirugia" runat="server" Text="Si" /><asp:RadioButton ID="cirugiano" GroupName="cirugia" Text="No" runat="server"/></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label13" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img12" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="200">Arritmias:</td>
      <td align="left" class="loginDisplay"><asp:RadioButton ID="arritmiassi" GroupName="arritmias" runat="server" Text="Si" /><asp:RadioButton ID="arritmiasno" GroupName="arritmias" Text="No" runat="server"/></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label14" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img13" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="200">S V:</td>
      <td align="left" class="loginDisplay"><asp:RadioButton ID="svsi" GroupName="sv" runat="server" Text="Si" /><asp:RadioButton ID="svno" GroupName="sv" Text="No" runat="server"/></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label15" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img15" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="200">Bloqueo AV:</td>
      <td align="left" class="loginDisplay"><asp:RadioButton ID="bloqueoavsi" GroupName="bloqueoav" runat="server" Text="Si" /><asp:RadioButton ID="bloqueoavno" GroupName="bloqueoav" Text="No" runat="server"/></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label16" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img16" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="200">MPD:</td>
      <td align="left" class="loginDisplay"><asp:RadioButton ID="mpdsi" GroupName="mpd" runat="server" Text="Si" /><asp:RadioButton ID="mpdno" GroupName="mpd" Text="No" runat="server"/></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label17" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img17" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="200">ACV:</td>
      <td align="left" class="loginDisplay"><asp:RadioButton ID="acvsi" GroupName="acv" runat="server" Text="Si" /><asp:RadioButton ID="acvno" GroupName="acv" Text="No" runat="server"/></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label18" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img18" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="200">Enfermedad Carotidea:</td>
      <td align="left" class="loginDisplay"><asp:RadioButton ID="enfcarotideasi" GroupName="enfcarotidea" runat="server" Text="Si" /><asp:RadioButton ID="enfcarotideano" GroupName="enfcarotidea" Text="No" runat="server"/></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label19" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img19" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="200">Enfermedad Periferica:</td>
      <td align="left" class="loginDisplay"><asp:RadioButton ID="enfperifericasi" GroupName="enfperiferica" runat="server" Text="Si" /><asp:RadioButton ID="enfperifericano" GroupName="enfperiferica" Text="No" runat="server"/></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label20" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img20" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="200">Enfermedad de Chagas:</td>
      <td align="left" class="loginDisplay"><asp:RadioButton ID="chagassi" GroupName="chagas" runat="server" Text="Si" /><asp:RadioButton ID="chagasno" GroupName="chagas" Text="No" runat="server"/></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label21" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img21" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="200">Cardiopatia Reumatica:</td>
      <td align="left" class="loginDisplay"><asp:RadioButton ID="cardreumaticasi" GroupName="cardreumatica" runat="server" Text="Si" /><asp:RadioButton ID="cardreumaticano" GroupName="cardreumatica" Text="No" runat="server"/></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label22" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img22" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>      
      <td align="left" class="loginDisplay" width="58">
      <asp:Button ID="Button1" CssClass="buttons2" runat="server" OnClick="Guardar" Text="Guardar" />
      <asp:Button ID="Button2" CssClass="buttons2" runat="server" OnClick="Modificar" Text="Modificar" />
      <asp:Button ID="Button3" CssClass="buttons2" runat="server" OnClick="Actualizar" Text="Actualizar" />
      <input type="button" ID="Button4" class="buttons2" runat="server" value="Cerrar" />
      </td>
    </tr>
  </table>
        <asp:Label ID="Label24" runat="server" Text=""></asp:Label>
  <input type="hidden" id="vhpaciente" runat="server" />
    </center>
    </form>
</body>
</html>

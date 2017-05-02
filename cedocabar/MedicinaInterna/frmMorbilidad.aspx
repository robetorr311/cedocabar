<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmMorbilidad.aspx.cs" Inherits="cedocabar.MedicinaInterna.frmMorbilidad" %>

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
                    <asp:Label ID="Label1" CssClass="main" runat="server" Text="CONSULTA CARDIOLOGIA ADULTO"></asp:Label>
                </td>
            </tr>
     </table>
    <table width="700" border="0" cellspacing="0" cellpadding="0">
      <tr>
         <td align="center"  class="subnombreform" >DATOS B&Aacute;SICOS DEL PACIENTE</td>
      </tr>
    </table>
    <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="50">N&uacute;mero de Historia:</td>
      <td align="left" class="loginDisplay"><asp:Label ID="historia" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label9" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img14" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="50">C&eacute;dula:</td>
      <td align="left" class="loginDisplay"><asp:Label ID="cedula" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="LblV1" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img1" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
    <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="58">Nombre:</td>
      <td align="left" class="loginDisplay"><asp:Label ID="nombre" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="LblV2" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img2" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="58">Edad:</td>
      <td align="left" class="loginDisplay"><asp:Label ID="edad" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label12" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img17" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="58">Sexo:</td>
      <td align="left" class="loginDisplay"><asp:Label ID="sexo" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label13" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img18" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
    <table width="700" border="0" cellspacing="0" cellpadding="0">
      <tr>
         <td align="center"  class="subnombreform" >DATOS EXAMEN FISICO PRE-CONSULTA</td>
      </tr>
    </table>
    <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="58">Tension Arterial:</td>
      <td align="left" class="loginDisplay"><asp:TextBox ID="ta" runat="server" Text="Label"></asp:TextBox></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label3" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img3" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="58">Frecuencia Cardiaca:</td>
      <td align="left" class="loginDisplay"><asp:TextBox ID="fc" runat="server" Text="Label"></asp:TextBox></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label5" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img4" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="58">Frecuencia Respiratoria:</td>
      <td align="left" class="loginDisplay"><asp:TextBox ID="fr" runat="server" Text="Label"></asp:TextBox></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label7" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img5" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
    <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="58">Peso:</td>
      <td align="left" class="loginDisplay"><asp:TextBox ID="peso" runat="server" Text="Label"></asp:TextBox></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label4" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img6" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="58">Talla:</td>
      <td align="left" class="loginDisplay"><asp:TextBox ID="talla" runat="server" Text="Label"></asp:TextBox></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label8" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img7" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="58">Temperatura:</td>
      <td align="left" class="loginDisplay"><asp:TextBox ID="temperatura" runat="server" Text="Label"></asp:TextBox></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label11" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img8" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="58">Aspecto:</td>
      <td align="left" class="loginDisplay"><asp:TextBox ID="aspecto" runat="server" Text=""></asp:TextBox></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label15" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img12" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
    <table width="700" border="0" cellspacing="0" cellpadding="0">
      <tr>
         <td align="center"  class="subnombreform" >DIAGNOSTICO</td>
      </tr>
    </table>
    <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay"><asp:TextBox ID="diagnostico"  CssClass="textolargo" TextMode="MultiLine" runat="server" Text=""></asp:TextBox></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label10" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img9" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
    </table>
     <table width="700" border="0" cellspacing="0" cellpadding="0">
      <tr>
         <td align="center"  class="subnombreform" >TRATAMIENTO</td>
      </tr>
    </table>    
    <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay"><asp:TextBox ID="tratamiento"  CssClass="textolargo" TextMode="MultiLine" runat="server" Text=""></asp:TextBox></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label6" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img10" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
    </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>      
      <td align="left" class="loginDisplay" width="58">
      <asp:Button ID="Button1" CssClass="buttons2" runat="server" OnClick="Modificar" Text="Modificar" />
      <asp:Button ID="Button2" CssClass="buttons2" runat="server" OnClick="Actualizar" Text="Actualizar" />
      <asp:Button ID="Button3" CssClass="buttons2" runat="server" OnClick="Finalizar" Text="Finalizar" />
      </td>
    </tr>
  </table>  
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>       
    </center>
   <input type="hidden" id="vhpaciente" runat="server" />
   <input type="hidden" id="videx" runat="server" /> 
   <input type="hidden" id="vidmorb" runat="server" />      
    </form>
</body>
</html>

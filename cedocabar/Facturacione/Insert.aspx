<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="cedocabar.Facturacione.Insert" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
	<link rel="stylesheet" type="text/css" href="~/Styles/Skin Style.css" />
	<link rel="stylesheet" type="text/css" href="~/Styles/style.css" />
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
<form id="form1" target="_self" runat="server">      
  <center>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="center" class="nombreform"><asp:Label ID="Label1" CssClass="main" runat="server" Text="CUPO RESERVADO"></asp:Label></td>
    </tr>
  </table>                   
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="58">Factura:</td>
      <td align="left" class="loginDisplay">
          <asp:Label ID="factura" runat="server" Text="Label"></asp:Label></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="LblV1" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img1" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
   </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="58">Numero de Historia:</td>
      <td align="left" class="loginDisplay"><asp:Label ID="historia" runat="server" Text="Label"></asp:Label></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label3" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img2" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="58">Nombre del Paciente:</td>
      <td align="left" class="loginDisplay"><asp:Label ID="paciente" runat="server" Text="Label"></asp:Label></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label4" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img3" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
   </table>  
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left"  class="subnombreform"><asp:Label ID="Label2" runat="server" Text="ORDEN DE SERVICIO PARA:"></asp:Label></td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="58">Servicio:</td>
      <td align="left" class="loginDisplay">
          <asp:Label ID="servicio" runat="server" Text="Label"></asp:Label></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label6" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img4" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
   </table>       
   <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="subnombreform"><asp:Label ID="Label5" runat="server" Text="CON EL DOCTOR:"></asp:Label></td>
    </tr>
  </table>  
   <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="58">Doctor:</td>
      <td align="left" class="loginDisplay">
          <asp:Label ID="medico" runat="server" Text="Label"></asp:Label></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label8" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img5" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
   </table>
   <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="subnombreform"><asp:Label ID="Label7" CssClass="main" runat="server" Text="PRESENTARSE EL DIA:"></asp:Label></td>
    </tr>
  </table>        
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="58">Fecha:</td>
      <td align="left" class="loginDisplay"><asp:Label ID="fecha" runat="server" Text="Label"></asp:Label></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label10" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img6" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="58">Hora:</td>
      <td align="left" class="loginDisplay"><asp:Label ID="hora" runat="server" Text="Label"></asp:Label></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label12" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img7" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="58">Usted es el numero:</td>
      <td align="left" class="loginDisplay"><asp:Label ID="numero" runat="server" Text="Label"></asp:Label></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label11" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img8" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      </tr>   
   </table>  
   <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>      
      <td align="left" class="loginDisplay" width="58"><asp:Button ID="Button1" CssClass="buttons2" runat="server" OnClientClick="window.document.forms[0].target='_self';" OnClick="Finalizar"  Text="Aceptar" /></td>
    </tr>
  </table>
      <asp:Label ID="Label9" runat="server" Text=""></asp:Label> 
      <input type="hidden" id="iddoc" runat="server" />       
    </center>
    </form>
</body>
</html>

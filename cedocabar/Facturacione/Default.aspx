<%@ Page Language="C#"   AutoEventWireup="true" ValidateRequest="false" CodeBehind="Default.aspx.cs" Inherits="cedocabar.Facturacione.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
	<link rel="stylesheet" type="text/css" href="~/Styles/Skin Style.css" />
	<link rel="stylesheet" type="text/css" href="~/Styles/style.css" />
	<link rel="stylesheet" type="text/css" href="~/Styles/subModal.css" />
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
	<script type="text/javascript" src="../Scripts/common.js"></script>
	<script type="text/javascript" src="../Scripts/frmBPacien.js"></script>
	<script type="text/javascript" src="../Scripts/medicos.js"></script>
</head>
<body>
<form id="form1" target="_self" runat="server">      
  <center>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="center" class="nombreform"><asp:Label ID="Label1" CssClass="main" runat="server" Text="FACTURACION DE CONSULTAS"></asp:Label></td>
    </tr>
  </table>                   
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="58">Factura:</td>
      <td align="left" class="loginDisplay"><asp:TextBox ID="factura" runat="server"></asp:TextBox></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="LblV1" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
   </table>
   <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="50">Servicio:</td>
      <td align="left" class="loginDisplay"><asp:DropDownList ID="servicio" runat="server" AutoPostBack="true" OnSelectedIndexChanged="callMedicoserv"></asp:DropDownList></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="LblV5" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img2" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="58">Cedula:</td>
      <td align="left" class="loginDisplay"><asp:TextBox ID="cedula" OnTextChanged="Buscarced" AutoPostBack="true" runat="server" ></asp:TextBox><input type="button" id="BotonBuscar" value="Buscar" class="buttons2" runat="server" /></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="LblV2" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="100">Nombre del Paciente:</td>
      <td align="left" class="loginDisplay"><input type="text" ID="paciente" runat="server" /><input type="hidden" ID="idpaciente" runat="server" /></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="LblV3" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="80">Historia Numero:</td>
      <td align="left" class="loginDisplay"><input type="text" ID="historia" runat="server" /></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="LblV4" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>      
      <td align="left" class="loginDisplay" width="58">Medico:</td>
      <td align="left" class="loginDisplay"><asp:DropDownList ID="medico" runat="server"></asp:DropDownList></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="LblV6" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>  
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>      
      <td align="left" colspan="3" class="loginDisplay" width="58">Observaciones:</td>
    </tr>
    <tr>
      <td align="left" class="loginDisplay">
          <asp:TextBox ID="observaciones" CssClass="direccion" TextMode="MultiLine" runat="server"></asp:TextBox></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label2" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img1" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>      
      <td align="left" class="loginDisplay" width="58"><asp:Button ID="Button1" CssClass="buttons2" OnClick="Guardar" runat="server" Text="Guardar" /></td>
    </tr>
  </table>
      <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
  </center>
</form>
</body>
</html>
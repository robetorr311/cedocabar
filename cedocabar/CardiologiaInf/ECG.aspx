<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ECG.aspx.cs" Inherits="cedocabar.CardiologiaInf.ECG" %>

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
    <form id="form1" target="_self" enctype="multipart/form-data" runat="server">      
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
      <td align="left" class="loginDisplay" width="50">Seleccione el Archivo:</td>
      <td align="left" class="loginDisplay"><input id="File1" type="file" runat="server" /></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label9" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img14" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
    </table>
    <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="50">Archivo:</td>
      <td align="left" class="loginDisplay"><asp:Label ID="Label3" runat="server" Text="" /></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label2" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img1" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
    </table>
    <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
    <td align="left" class="loginDisplay" width="50">
          <input id="Button1" type="button" value="button" OnServerClick="btnUploadTheFile_Click" runat="server" /></td>      
    </tr>
    </table>
    <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
    </center>
    </form>
</body>
</html>

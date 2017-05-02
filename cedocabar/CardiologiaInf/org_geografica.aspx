<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" CodeBehind="org_geografica.aspx.cs" Inherits="cedocabar.CardiologiaInf.org_geografica" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title></title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
	<script type="text/javascript" src="../Scripts/org_geografica.js"></script>
</head>
<body>
     <form id="form1" target="_self" runat="server">      
    <center>
          <table width="500" border="0" cellspacing="0" cellpadding="0">
                <tr>
                    <td align="center" class="nombreform">
                        <asp:Label ID="Label1" CssClass="main" runat="server" Text="UBICACION GEOGRAFICA"></asp:Label>
                    </td>
                </tr>
          </table>
          <table width="500" border="0" cellspacing="0" cellpadding="0">
            <tr>
              <td align="left" class="loginDisplay" >Seleccione el Estado: </td>
              <td align="left" class="loginDisplay" >
                  <asp:DropDownList ID="estado" runat="server" AutoPostBack="true" OnSelectedIndexChanged="munic">
                  <asp:ListItem Value="0" Text="SELECCIONE"></asp:ListItem>
                  </asp:DropDownList>
              </td>
              <td align="left" class="loginDisplay" width="2">*</td>
              <td align="left" class="loginDisplay" width="20"><img id="Img1" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
            </tr>
          </table>
          <table width="500" border="0" cellspacing="0" cellpadding="0">
            <tr>
              <td align="left" class="loginDisplay" >Seleccione el Municipio: </td>
              <td align="left" class="loginDisplay" >
                  <asp:DropDownList ID="municipio"  AutoPostBack="true" OnSelectedIndexChanged="parroq" runat="server">
                   <asp:ListItem Value="0" Text="SELECCIONE"></asp:ListItem>
                 </asp:DropDownList>
              </td>
              <td align="left" class="loginDisplay" width="2">*</td>
              <td align="left" class="loginDisplay" width="20"><img id="Img2" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
            </tr>
          </table>
          <table width="500" border="0" cellspacing="0" cellpadding="0">
            <tr>
              <td align="left" class="loginDisplay" >Seleccione la Parroquia: </td>
              <td align="left" class="loginDisplay" >
                  <asp:DropDownList ID="parroquia"  AutoPostBack="true" OnSelectedIndexChanged="sect" runat="server">
                  <asp:ListItem Value="0" Text="SELECCIONE"></asp:ListItem>
                  </asp:DropDownList>
              </td>
              <td align="left" class="loginDisplay" width="2">*</td>
              <td align="left" class="loginDisplay" width="20"><img id="Img3" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
            </tr>
          </table>
          <table width="500" border="0" cellspacing="0" cellpadding="0">
            <tr>
              <td align="left" class="loginDisplay" >Seleccione el Sector: </td>
              <td align="left" class="loginDisplay" >
                  <asp:DropDownList ID="sector"  AutoPostBack="true"  OnSelectedIndexChanged="nombrelargo" runat="server">
                   <asp:ListItem Value="0" Text="SELECCIONE"></asp:ListItem>
                 </asp:DropDownList>
              </td>
              <td align="left" class="loginDisplay" width="2">*</td>
              <td align="left" class="loginDisplay" width="20"><img id="Img4" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
            </tr>
          </table>
  <table width="500" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="center" class="loginDisplay" >
          <asp:Button ID="Button1" CssClass="buttons2" OnClick="Cerrar" runat="server" Text="Cerrar" />
      </td>
    </tr>
  </table>
        <table class="topbottom" width="500" border="0" cellspacing="0" cellpadding="0">
            <tr>
                <td align="left" class="topbottom">
                    <img id="Img5"  alt="" src="~/Imagenes/bottom.gif" width="500" runat="server" />
                </td>
            </tr>
        </table>
    </center>
     <input type="hidden" name="nmbrlargo" ID="nmbrlargo" runat="server" />                   
    </form>
</body>
</html>

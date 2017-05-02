<%@ Page Title="Página principal" Language="C#" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="cedocabar._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
<center>
    <table class="topbanner" width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td> 
                <img id="Img1" src="../Imagenes/banner.png" alt="" runat="server" />
            </td>
        </tr>
    </table> 
    <table class="banner" width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
        <td >
            <img id="Img2" src="../Imagenes/bannercedocabar.png" alt="" runat="server" />
        </td>
        </tr>
    </table> 
    <br />
    <br />
    <br />
     <form id="form1" runat="server">      
       <table width="500" border="0" cellspacing="0" cellpadding="0">
            <tr>
                <td align="center" class="nombreform">
                    <asp:Label ID="Label4" CssClass="main" runat="server" Text="BIENVENIDOS"></asp:Label>
                </td>
            </tr>
        </table>
       <table class="loginDisplay" width="500" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td  align="left" width="200">
            Ingrese su nombre de usuario:
            </td>
            <td class="loginDisplay" align="left" >
            <asp:TextBox ID="Loggin" runat="server"></asp:TextBox>
            </td>
            <td  class="loginDisplay" align="left" width="2">
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </td>
            <td class="loginDisplay"  align="left" width="18">
            <img src="Imagenes/sign_question.png" alt="" width="16" height="16" />
            </td>
        </tr>
        <tr>
            <td  class="loginDisplay" align="left" width="200">
            Ingrese su password:
            </td>
            <td class="loginDisplay" align="left" >
            <asp:TextBox ID="Password" TextMode="Password" runat="server"></asp:TextBox>
            </td>
            <td  class="loginDisplay"  align="left" width="2">
                <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            </td>
            <td  class="loginDisplay"  align="left" width="18">
            <img src="Imagenes/sign_question.png" alt="" width="16" height="16" />
            </td>
        </tr>
        <tr>
            <td  class="loginDisplay"  align="justify" width="200">
            Inicio de aplicacion como:
            </td>
            <td class="loginDisplay"  align="left"><asp:DropDownList ID="tipousuario" runat="server"></asp:DropDownList>
            </td>
            <td  class="loginDisplay" align="left" width="2">
                <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            </td>
            <td  class="loginDisplay" align="left" width="18">
            <img src="Imagenes/sign_question.png" alt="" width="16" height="16" />
            </td>
        </tr>
        </table>
        <table class="loginDisplay" width="500" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td  class="loginDisplay"  align="center">
            <asp:Button ID="Button1" CssClass="buttons2" runat="server" Text="Ingresar" OnClick="Ingresar" />
            </td>
        </tr>
        </table>
    </form>
</center>
</body>

</html>

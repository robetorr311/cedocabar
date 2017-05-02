<%@ Page Language="C#" AutoEventWireup="true"  enableViewStateMAC="false" CodeBehind="Salida.aspx.cs" Inherits="cedocabar.Salida" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <table class="topbanner" width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td> 
                <img id="Img1" src="../Imagenes/banner.png" alt="" runat="server" />
            </td>
        </tr>
    </table>
    <table class="banner" width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
        <td>
            <img id="Img2" src="../Imagenes/bannercedocabar.png" alt="" runat="server" />
        </td>
        </tr>
    </table>
    <br />
    <br />
    <br />
     <form id="form1" runat="server">      
    <center>
       <table width="500" border="0" cellspacing="0" cellpadding="0">
            <tr>
                <td align="center" class="nombreform">
                    <asp:Label ID="Label4" CssClass="main" runat="server" Text="HASTA LUEGO!!"></asp:Label>
                </td>
            </tr>
        </table>
       <table class="loginDisplay" width="500" border="0" cellspacing="0" cellpadding="0">
            <tr>
                <td align="left">
                Su conexion ha finalizado
                </td>
            </tr>
        </table>
        <table class="loginDisplay" width="500" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td align="center">
            <asp:Button ID="Button1" runat="server" Text="Finalizar" OnClick="Finalizar"/>
            </td>
        </tr>
        </table>
        <table  class="topbottom" width="500" border="0" cellspacing="0" cellpadding="0">
            <tr>
                <td>
                    <asp:Image ID="Image2" ImageUrl="~/Imagenes/bottom.gif" runat="server" />
                </td>
            </tr>
        </table>
    </center>
    </form>
</body>
</html>


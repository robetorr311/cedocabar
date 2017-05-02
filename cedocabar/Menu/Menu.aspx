<%@ Page Title="Menu de Opciones" Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="cedocabar.Menu.Menu" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en">
<head id="Head1" runat="server">
<meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title></title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table class="topbanner" width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td> 
                <img src="../Imagenes/banner.png" alt="" runat="server" />
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
    <marquee behavior="scroll" direction="left"><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></marquee>
    <asp:Menu ID="MenudeOpciones"
                     CssClass="tdmenu" 
                     DynamicMenuItemStyle-CssClass="tdmenu" 
                     StaticMenuItemStyle-CssClass="tdmenu" 
                     Orientation="Horizontal" 
                     runat="server">
    </asp:Menu>  
    <iframe id="contenido" src="fondo.htm" name="contenido" runat="server"  frameborder="0" width="100%" height="500px"></iframe>
</div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Herencia.aspx.cs" Inherits="cedocabar.CardiologiaInf.Herencia" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
     <form id="form1" target="_self" runat="server">      
    <center>
          <table width="400" border="0" cellspacing="0" cellpadding="0">
            <tr>
              <td align="left" class="loginDisplay" >
                  <asp:CheckBox ID="Checkbox1" runat="server" Text="Hipertension Arterial (HTA)"  />               
              </td>
            </tr>
            <tr>
              <td align="left" class="loginDisplay" >
                  <asp:CheckBox ID="Checkbox2" runat="server" Text="Diabetes"  />               
              </td>
            </tr>
            <tr>
              <td align="left" class="loginDisplay" >
                  <asp:CheckBox ID="Checkbox4" runat="server" Text="Infarto de Miocardio"  />               
              </td>
            </tr>
            <tr>
              <td align="left" class="loginDisplay" >
                  <asp:CheckBox ID="Checkbox5" runat="server" Text="Enfermedad Cerebro Vascular"  />               
               </td>
            </tr>
            <tr>
              <td align="left" class="loginDisplay" >
                  <asp:CheckBox ID="Checkbox6" runat="server" Text="Muerte Subita"  />               
              </td>
            </tr>
            <tr>
              <td align="left" class="loginDisplay" >
                  <asp:CheckBox ID="Checkbox3" OnCheckedChanged="Ninguna" runat="server" AutoPostBack="true" Text="Ninguna"  />                              
              </td>
            </tr>
            <tr>
              <td align="left" class="loginDisplay" >
                  <asp:Button ID="Button1" runat="server" OnClick="Cerrar" Text="Cerrar" />
              </td>
            </tr>
          </table>
          <input type="text" id="herencia" name="herencia" runat="server" />
          <input type="text" id="control" name="control" runat="server" />
    </center>               
    </form>
</body>
</html>

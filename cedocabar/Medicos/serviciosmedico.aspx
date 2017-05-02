<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="serviciosmedico.aspx.cs" Inherits="cedocabar.Medicos.serviciosmedico" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="~/Styles/Skin Style.css" />
	<link rel="stylesheet" type="text/css" href="~/Styles/style.css" />
	<link rel="stylesheet" type="text/css" href="~/Styles/subModal.css" />
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
     <form id="form1" target="_self" runat="server">      
    <center>
       <table width="500" border="0" cellspacing="0" cellpadding="0">
            <tr>
                <td align="center" class="nombreform">
                    <asp:Label ID="Label1" CssClass="main" runat="server" Text="SERVICIOS QUE PRESTA EL MEDICO"></asp:Label>
                </td>
            </tr>
        </table> 
  <table width="500" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" >Servicio: </td>
      <td align="left" class="loginDisplay" >
          <asp:DropDownList ID="servicio" runat="server">
          </asp:DropDownList>
      </td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="LblV5" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img5" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>                          
  <table width="500" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" >Horario:</td>
      <td align="left" class="loginDisplay" ><asp:DropDownList ID="hhorario" runat="server"></asp:DropDownList></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="LblV11" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img11" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
  <table width="500" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" >Turno: </td>
      <td align="left" class="loginDisplay" ><asp:DropDownList ID="hturno" runat="server" AutoPostBack="true" OnTextChanged="controles"></asp:DropDownList></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="LblV12" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img12" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>    
    </tr>
  </table>
  <table width="500" border="0" cellspacing="0" cellpadding="0">
    <tr>      
      <td align="left" class="loginDisplay" >Pacientes M: </td>
      <td align="left" class="loginDisplay" ><asp:TextBox ID="pacientesm" runat="server"></asp:TextBox></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="LblV13" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img13" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" >Pacientes T: </td>
      <td align="left" class="loginDisplay" ><asp:TextBox ID="pacientest" runat="server"></asp:TextBox></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="LblV14" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img14" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
<table width="500" border="1" cellspacing="0" cellpadding="0">
  <tr>
    <td  class="loginDisplay" align="center">
    <span onmouseover="muestraAyuda(event, 'CdRom: Guardar');">
    <asp:Button ID="Button1" OnClick="Guardar" CssClass="buttons2" Text="Guardar" runat="server" />
    </span>
    <span id="Span1">
    <asp:Button ID="Button2" OnClick="Cerrar" OnClientClick="window.parent.hidePopWin()" CssClass="buttons2" Text="Cerrar" ImageUrl="../Imagenes/cerrarw.gif" runat="server" />
    </span>    
    </td>
  </tr>
</table>
<table width="500" border="1" cellspacing="0" cellpadding="0">
  <tr>
    <td  class="loginDisplay">
                <asp:GridView ID="GridView1" 
                    Width="500" 
                    CellSpacing="10"
                    CellPadding="10" 
                    CssClass="GridRowsTABLE"  
                    SelectedRowStyle-CssClass="GridRowSelectedTR" 
                    AlternatingRowStyle-BackColor="Beige" 
                    RowStyle-BackColor="Ivory" 
                    AllowPaging = "true" 
                    PageSize="5"
                    AutoGenerateColumns="false" 
                    OnSelectedIndexChanged="gridView_SelectedIndex"
                    OnRowCommand="Guardar"                   
	                OnRowDeleting="Borrar" 
                    OnPageIndexChanging = "gridView_PageIndexChanging"
                    PagerSettings-Mode="NextPreviousFirstLast"
                    PagerSettings-LastPageImageUrl="../Imagenes/PageLastOver.gif"
                    PagerSettings-FirstPageImageUrl="../Imagenes/PageFirstOver.gif"
                    PagerSettings-NextPageImageUrl="../Imagenes/PageNextOver.gif"
                    PagerSettings-PreviousPageImageUrl="../Imagenes/PagePrevOver.gif"  
                    PagerSettings-Position="Bottom"
                    PagerStyle-CssClass="small"  
                    runat="server">
                    <Columns>
					<asp:TemplateField HeaderText="Edit" ShowHeader="False"> 
						<ItemTemplate>
							<span onmouseover="muestraAyuda(event, 'Consultas: Seleccionar');"><asp:ImageButton ID="ImageButton6" CommandName="Select" Text="Seleccionar" CausesValidation="false" ButtonType="Image" ImageUrl="../Imagenes/form_go.gif" runat="server" /></span>
							<span onmouseover="muestraAyuda(event, 'Consultas: Eliminar');"><asp:ImageButton ID="ImageButton2" CommandName="Delete"  Enabled="false" Text="Delete" CausesValidation="false" ButtonType="Image" ImageUrl="../Imagenes/CntMnuDelete.gif" runat="server" /></span>
						</ItemTemplate> 
					</asp:TemplateField>
                     <asp:TemplateField HeaderText="Id" Visible="true">
                        <ItemTemplate>
                            <asp:Label ID="LblID" runat="server" Text='<%# Eval("id") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Medico" Visible="true">					
						<ItemTemplate>
                            <asp:Label ID="Lblserial" runat="server" Text='<%# Eval("medico") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Servicio" Visible="true">					
						<ItemTemplate>
                            <asp:Label ID="Lblmarca" runat="server" Text='<%# Eval("servicio") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Horario" Visible="true">					
						<ItemTemplate>
                            <asp:Label ID="Lblnumero" runat="server" Text='<%# Eval("horario") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Turno" Visible="true">					
						<ItemTemplate>
                            <asp:Label ID="Lblnombre" runat="server" Text='<%# Eval("turno") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Turno Mañana" Visible="true">					
						<ItemTemplate>
                            <asp:Label ID="Lblresponsable" runat="server" Text='<%# Eval("npersonasm") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Turno Tarde" Visible="true">					
						<ItemTemplate>
                            <asp:Label ID="Lbldepartamento" runat="server" Text='<%# Eval("npersonast") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>            
                    </Columns>
                </asp:GridView>
    </td>
  </tr>
</table> 
<table class="loginDisplay" width="500" border="1" cellspacing="0" cellpadding="0">
  <tr>
    <td  class="topbottom">
        <img src="../Imagenes/bottom.gif" width="500" height="10" alt=""  /></td>
  </tr>
</table> 
<asp:Label ID="Label2" CssClass="alerta" runat="server" Text=""></asp:Label>
    <input type="hidden" id="HiddenField1" runat="server" />
    <input type="hidden" id="idequipo" runat="server" />
    <input type="hidden" id="idsrvmed" runat="server" />
    <input type="text" id="des_region" runat ="server" />
    <input type="text" id="num_region" runat="server" />
  </center>
</form>
</body>
</html>

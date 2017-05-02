<%@ Page Language="C#"  AutoEventWireup="true" ValidateRequest="false" CodeBehind="Default.aspx.cs" Inherits="cedocabar.Cajeros.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
	<link rel="stylesheet" type="text/css" href="~/Styles/Skin Style.css" />
	<link rel="stylesheet" type="text/css" href="~/Styles/style.css" />
	<link rel="stylesheet" type="text/css" href="~/Styles/subModal.css" />
	<script type="text/javascript" src="../Scripts/common.js"></script>
	<script type="text/javascript" src="../Scripts/subModal_Md.js"></script>
	<script type="text/javascript" src="../Scripts/cajero.js"></script>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />

</head>
<body onload="cargar()">
     <form id="form1" target="_self" runat="server">      
    <center>
       <table width="700" border="0" cellspacing="0" cellpadding="0">
            <tr>
                <td align="center" class="nombreform">
                    <asp:Label ID="Label1" CssClass="main" runat="server" Text="FORMULARIO PARA EL INGRESO DE PERSONAL DE FACTURACIONES"></asp:Label>
                </td>
            </tr>
        </table>                   
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="50">Cedula:</td>
      <td align="left" class="loginDisplay"><asp:TextBox ID="cedula" runat="server"></asp:TextBox></td>
      <td align="left" class="loginDisplay" width="2">
          <asp:Label ID="LblV1" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay"width="20"><img onmouseover="muestraAyuda(event, 'Cedula');" id="Img1" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="58">Nombre:</td>
      <td align="left" class="loginDisplay"><asp:TextBox ID="nombre" runat="server"></asp:TextBox></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="LblV2" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay"width="20"><img onmouseover="muestraAyuda(event, 'Nombre');" id="Img2" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" >Telefono Fijo: </td>
      <td align="left" class="loginDisplay" ><asp:TextBox ID="telefonof" runat="server"></asp:TextBox></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="LblV6" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay"width="20"><img onmouseover="muestraAyuda(event, 'Telefono Fijo');" id="Img6" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" >Telefono Movil: </td>
      <td align="left" class="loginDisplay" ><asp:TextBox ID="telefonom" runat="server"></asp:TextBox></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="LblV7" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay"width="20"><img onmouseover="muestraAyuda(event, 'Telefono Movil');" id="Img7" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" >Direcci&oacute;n de Domicilio: </td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="472"><asp:TextBox ID="direccion" TextMode="MultiLine" CssClass="direccion" runat="server"></asp:TextBox></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="LblV8" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay"width="20"><img onmouseover="muestraAyuda(event, 'Direccion');" id="Img8" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" >Ubicacion: <input type="button" ID="Button2" runat="server"  class="buttons2" value="Seleccione" />
      </td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="472">
          <input ID="TextBox1" type="text" class="org_geografica" runat="server" />
          <input type="hidden" ID="num_region" runat="server" />
      </td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="LblV9" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay"width="20"><img onmouseover="muestraAyuda(event, 'Ubicacion');" id="Img9" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" >Correo:</td>
      <td align="left" class="loginDisplay" ><asp:TextBox ID="correo" runat="server"></asp:TextBox></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="LblV10" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay"width="20"><img onmouseover="muestraAyuda(event, 'Correo');" id="Img10" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="center" class="loginDisplay" >
          <span onmouseover="muestraAyuda(event, 'Guardar');"><asp:Button ID="ImageButton1" OnClick="Guardar" CssClass="buttons2" runat="server"  Text="Guardar" /></span>
          <span onmouseover="muestraAyuda(event, 'Modificar');"><asp:Button ID="Button1" OnClick="Modificar" CssClass="buttons2" runat="server"  Text="Modificar" /></span>
          <span onmouseover="muestraAyuda(event, 'Actualizar');"><asp:Button ID="Button3" OnClick="Actualizar" CssClass="buttons2" runat="server"  Text="Actualizar" /></span>
          <span onmouseover="muestraAyuda(event, 'Nuevo');"><asp:Button ID="Button4" OnClick="Nuevo" CssClass="buttons2" runat="server"  Text="Nuevo" /></span>
      </td>
    </tr>
  </table>
        <table class="topbottom" width="700" border="0" cellspacing="0" cellpadding="0">
            <tr>
                <td align="left" class="topbottom">
                    <img id="Img15"  alt="" src="~/Imagenes/bottom.gif" width="700" runat="server" />
                </td>
            </tr>
        </table>
    <table border="0" width="700" cellspacing="0" cellpadding="0">
        <tr>
            <td  class="loginDisplay">
                <asp:GridView ID="GridView1" 
                    Width="700" 
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
                    OnRowCommand="Save"                   
                    OnRowEditing="Editar" 
	                OnRowDeleting="Borrar" 
	                OnRowCancelingEdit="Cancelar" 
	                OnRowUpdating="upd"
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
					<asp:TemplateField HeaderText="Controles" ShowHeader="False"> 
						<ItemTemplate>
							<span onmouseover="muestraAyuda(event, 'Seleccionar');"><asp:ImageButton ID="ImageButton6" CommandName="Select" Text="Seleccionar" CausesValidation="false" ButtonType="Image" ImageUrl="../Imagenes/form_go.gif" runat="server" /></span>
							<span onmouseover="muestraAyuda(event, 'Editar Fila');"><asp:ImageButton ID="ImageButton1" CommandName="Edit" Enabled="false" Text="Edit" CausesValidation="false" ButtonType="Image" ImageUrl="../Imagenes/form_edit.gif" runat="server" /></span>
							<span onmouseover="muestraAyuda(event, 'Eliminar');"><asp:ImageButton ID="ImageButton2" CommandName="Delete"  Enabled="false" Text="Delete" CausesValidation="false" ButtonType="Image" ImageUrl="../Imagenes/CntMnuDelete.gif" runat="server" /></span>
							<span onmouseover="muestraAyuda(event, 'Editar Registro');"><asp:ImageButton ID="ImageButton5" CommandName="Registro"  Enabled="false" Text="Delete" CausesValidation="false" ButtonType="Image" ImageUrl="../Imagenes/CntMnuEdit.gif" runat="server" /></span>
						</ItemTemplate> 
					<EditItemTemplate>    
							<span onmouseover="muestraAyuda(event, 'Cancelar');"><asp:ImageButton ID="ImageButton3" ButtonType="Image" CommandName="Cancel" Text="Cancel" CausesValidation="false" ImageUrl="../Imagenes/cancelar.gif" runat="server" /></span>
							<span onmouseover="muestraAyuda(event, 'Guardar');"><asp:ImageButton ID="ImageButton4" ButtonType="Image" CommandName="Update" Text="Update" CausesValidation="true" ImageUrl="../Imagenes/form_save.gif" runat="server" /></span>
					</EditItemTemplate>
					</asp:TemplateField>
                     <asp:TemplateField HeaderText="Id" Visible="true">
                        <ItemTemplate>
                            <asp:Label ID="LblID" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Label ID="LblID" runat="server" Text='<%# Eval("id") %>'></asp:Label> 
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nombre" Visible="true">					
						<ItemTemplate>
                            <asp:Label ID="Lblnombre" runat="server" Text='<%# Eval("nombre") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TBXnombre" CssClass="textboxgrid" runat="server" Text='<%# Eval("nombre") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Cedula" Visible="true">					
						<ItemTemplate>
                            <asp:Label ID="Lblcedula" runat="server" Text='<%# Eval("cedula") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TBXcedula" CssClass="textboxgrid" runat="server" Text='<%# Eval("cedula") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Estatus" Visible="true">					
						<ItemTemplate>
                            <asp:Label ID="Lblestatus" runat="server" Text='<%# Eval("estatus") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Label ID="Lblestatus" runat="server" Text='<%# Eval("estatus") %>'></asp:Label>
                           <asp:DropDownList ID="DDGestatus" runat="server">
                            </asp:DropDownList>                                                    </EditItemTemplate>
                    </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td> 
            </tr>
  </table>
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        <asp:HiddenField ID="HiddenField1" runat="server" />
        <asp:HiddenField ID="estatus" runat="server" />
  </center>
  </form>
<div id="mensajesAyuda">
	<div id="ayudaTitulo"></div>
	<div id="ayudaTexto"></div>
</div>
</body>
</html>


<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="cedocabar.Pacientes.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
	<link rel="stylesheet" type="text/css" href="~/Styles/Skin Style.css" />
	<link rel="stylesheet" type="text/css" href="~/Styles/style.css" />
	<link rel="stylesheet" type="text/css" href="~/Styles/subModal.css" />
	<script type="text/javascript" src="../Scripts/common.js"></script>
	<script type="text/javascript" src="../Scripts/subModal_Pacient.js"></script>
	<script type="text/javascript" src="../Scripts/popcalendar.js"></script>
	<script type="text/javascript" src="../Scripts/pacientes.js"></script>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />

</head>
<body onload="cargar();">
     <form id="form1" target="_self" runat="server">      
    <center>
       <table width="700" border="0" cellspacing="0" cellpadding="0">
            <tr>
                <td align="center" class="nombreform">
                    <asp:Label ID="Label1" CssClass="main" runat="server" Text="FORMULARIO HISTORIAS MEDICAS"></asp:Label>
                </td>
            </tr>
        </table>                   
      <table width="700" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td align="center"  class="subnombreform" >DATOS B&Aacute;SICOS </td>
        </tr>
      </table>
    <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="50">N&uacute;mero de Historia:</td>
      <td align="left" class="loginDisplay"><input type="text" ID="historia" runat="server" /></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label9" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img onmouseover="muestraAyuda(event, 'Historia');" id="Img14" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="50">C&eacute;dula:</td>
      <td align="left" class="loginDisplay"><input type="text" ID="cedula" runat="server" /></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="LblV1" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img onmouseover="muestraAyuda(event, 'Cedula');" id="Img1" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
    <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="58">Nombre:</td>
      <td align="left" class="loginDisplay"><input type="text" ID="nombre" runat="server" /></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="LblV2" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img onmouseover="muestraAyuda(event, 'Nombre');" id="Img2" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="58">Estado Civil:</td>
      <td align="left" class="loginDisplay"><asp:DropDownList ID="conyugal" runat="server"></asp:DropDownList></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label12" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img onmouseover="muestraAyuda(event, 'Conyugal');" id="Img17" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="58">Ocupaci&oacute;n:</td>
      <td align="left" class="loginDisplay"><asp:DropDownList ID="ocupacion" runat="server"></asp:DropDownList></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label13" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img onmouseover="muestraAyuda(event, 'Ocupacion');" id="Img18" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="50">Fecha de Nacimiento:</td>
      <td align="left" class="loginDisplay">                
      <input name="dateArrival" type="text" id="dateArrival" onclick="popUpCalendar(this, form1.dateArrival, 'dd/mm/yyyy');" size="10" runat="server" /> </td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label2" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img onmouseover="muestraAyuda(event, 'Fecha');" id="Img3" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="50">Edad:</td>
      <td align="left" class="loginDisplay"><input type="text" ID="edad" runat="server" /></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label3" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img onmouseover="muestraAyuda(event, 'Edad');" id="Img4" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" width="58">Sexo:</td>
      <td align="left" class="loginDisplay"><asp:DropDownList ID="sexo" runat="server"></asp:DropDownList></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label4" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img onmouseover="muestraAyuda(event, 'Sexo');" id="Img5" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="center"  class="subnombreform" >DIRECCI&Oacute;N DE DOMICILIO </td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="472"><asp:TextBox ID="direccion" TextMode="MultiLine" CssClass="direccion" runat="server"></asp:TextBox></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="LblV8" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img onmouseover="muestraAyuda('Direccion');" id="Img8" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" >Ubicaci&oacute;n: <input type="button" ID="Button2" runat="server"  class="buttons2" value="Seleccione" /><asp:Label ID="LblV9" runat="server" Text=""></asp:Label>
      </td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="472">
          <input ID="TextBox1" type="text" class="org_geografica" runat="server" />
          <input type="hidden" ID="num_region" runat="server" />
      </td>
      <td align="left" class="loginDisplay" width="2"></td>
      <td align="left" class="loginDisplay" width="20"><img onmouseover="muestraAyuda(event, 'Ubicacion');" id="Img9" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" >Tel&eacute;fono Fijo: </td>
      <td align="left" class="loginDisplay" ><input type="text" ID="telefonof" runat="server" /></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="LblV6" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img onmouseover="muestraAyuda(event, 'Telefono Fijo');" id="Img6" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" >Tel&eacute;fono Movil: </td>
      <td align="left" class="loginDisplay" ><input type="text" ID="telefonom" runat="server" /></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="LblV7" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img onmouseover="muestraAyuda(event, 'Telefono Movil');" id="Img7" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" >Correo: </td>
      <td align="left" class="loginDisplay" ><input type="text" ID="correo" runat="server" /></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label5" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img onmouseover="muestraAyuda(event, 'Correo');" id="Img10" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
    <td colspan="12" align="center" class="subnombreform">
    HERENCIA FAMILIAR
    </td>
    </tr>
    <tr>
      <td align="left" class="loginDisplay" >Padre: </td>
      <td align="left" class="loginDisplay" ><input type="text" ID="herenciap" runat="server" /></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label6" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img onmouseover="muestraAyuda(event, 'Herencia Padre');" id="Img11" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" >Madre: </td>
      <td align="left" class="loginDisplay" ><input type="text" ID="herenciam" runat="server" /></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label7" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img onmouseover="muestraAyuda(event, 'Herencia Madre');" id="Img12" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
      <td align="left" class="loginDisplay" >Hermano(s): </td>
      <td align="left" class="loginDisplay" ><input type="text" ID="herenciah" runat="server" /></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label8" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img onmouseover="muestraAyuda(event, 'Herencia Hermanos');" id="Img13" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" >Tabaquismo: </td>
      <td align="left" class="loginDisplay" >
          <input  id="tabaquismo1" type="radio" name="tabaquismo" value="S" runat="server" /> Si <input id="tabaquismo0" name="tabaquismo" type="radio" value="N"  runat="server" /> No</td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label10" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img onmouseover="muestraAyuda(event, 'Tabaquismo');" id="Img15" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
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
                    <img id="Img16"  alt="" src="~/Imagenes/bottom.gif" width="700" runat="server" />
                </td>
            </tr>
        </table>
        <asp:Label ID="Label14" runat="server" Text=""></asp:Label>
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
                            <asp:Label ID="LblID" runat="server" Text='<%# Eval("id") %>'></asp:Label>
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
                    <asp:TemplateField HeaderText="Edad" Visible="true">					
						<ItemTemplate>
                            <asp:Label ID="Lbledad" runat="server" Text='<%# Eval("edad") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TBXedad" CssClass="textboxgrid" runat="server" Text='<%# Eval("edad") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Sexo" Visible="true">					
						<ItemTemplate>
                            <asp:Label ID="Lblsexo" runat="server" Text='<%# Eval("sexo") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TBXsexo" CssClass="textboxgrid" runat="server" Text='<%# Eval("sexo") %>'></asp:TextBox>
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
        <asp:Label ID="Label11" runat="server" Text=""></asp:Label>
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


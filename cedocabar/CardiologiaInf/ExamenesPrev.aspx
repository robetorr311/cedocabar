<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExamenesPrev.aspx.cs" Inherits="cedocabar.CardiologiaInf.ExamenesPrev" %>

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
<body>
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
          <td align="center"  class="subnombreform" >EXAMENES FISICOS REALIZADOS ANTERIORMENTE </td>
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
							<span onmouseover="muestraAyuda(event, 'Consultas: Seleccionar');"><asp:ImageButton ID="ImageButton6"  CommandName="Select" Text="Seleccionar" CausesValidation="false" ButtonType="Image" ImageUrl="../Imagenes/form_go.gif" runat="server" /></span>
							<span onmouseover="muestraAyuda(event, 'Consultas: Editar Fila');"><asp:ImageButton ID="ImageButton1" CommandName="Edit" Enabled="false" Text="Edit" CausesValidation="false" ButtonType="Image" ImageUrl="../Imagenes/form_edit.gif" runat="server" /></span>
							<span onmouseover="muestraAyuda(event, 'Consultas: Eliminar');"><asp:ImageButton ID="ImageButton2" CommandName="Delete"  Enabled="false" Text="Delete" CausesValidation="false" ButtonType="Image" ImageUrl="../Imagenes/CntMnuDelete.gif" runat="server" /></span>
						</ItemTemplate> 
					<EditItemTemplate>    
							<span onmouseover="muestraAyuda(event, 'Consultas: Cancelar');"><asp:ImageButton ID="ImageButton3" ButtonType="Image" CommandName="Cancel" Text="Cancel" CausesValidation="false" ImageUrl="../Imagenes/cancelar.gif" runat="server" /></span>
							<span onmouseover="muestraAyuda(event, 'Consultas: Guardar');"><asp:ImageButton ID="ImageButton4" ButtonType="Image" CommandName="Update" Text="Update" CausesValidation="true" ImageUrl="../Imagenes/form_save.gif" runat="server" /></span>
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
                    <asp:TemplateField HeaderText="Fecha" Visible="true">					
						<ItemTemplate>
                            <asp:Label ID="Lblfecha" runat="server" Text='<%# Eval("fecha") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                           <asp:Label ID="Lblfecha" runat="server" Text='<%# Eval("fecha") %>'></asp:Label>
                        </EditItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="TA" Visible="true">					
						<ItemTemplate>
                            <asp:Label ID="Lblta" runat="server" Text='<%# Eval("ta") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TBXta" CssClass="textGrid" runat="server" Text='<%# Eval("ta") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="FC" Visible="true">					
						<ItemTemplate>
                            <asp:Label ID="Lblfc" runat="server" Text='<%# Eval("fc") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TBXfc" CssClass="textGrid" runat="server" Text='<%# Eval("fc") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="FR" Visible="true">					
						<ItemTemplate>
                            <asp:Label ID="Lblfr" runat="server" Text='<%# Eval("fr") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TBXfr" CssClass="textGrid" runat="server" Text='<%# Eval("fr") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Peso" Visible="true">					
						<ItemTemplate>
                            <asp:Label ID="Lblpeso" runat="server" Text='<%# Eval("peso") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TBXpeso" CssClass="textGrid" runat="server" Text='<%# Eval("peso") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Talla" Visible="true">					
						<ItemTemplate>
                            <asp:Label ID="Lbltalla" runat="server" Text='<%# Eval("talla") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TBXtalla" CssClass="textGrid" runat="server" Text='<%# Eval("talla") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Temperatura" Visible="true">					
						<ItemTemplate>
                            <asp:Label ID="Lbltemperatura" runat="server" Text='<%# Eval("temperatura") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TBXtemperatura" CssClass="textGrid" runat="server" Text='<%# Eval("temperatura") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td> 
            </tr>
  </table>
    <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>      
      <td align="left" class="loginDisplay" width="58">
      <input type="button" ID="Button4" class="buttons2" runat="server" value="Cerrar" />
      </td>
    </tr>
  </table>
        <asp:Label ID="Label11" runat="server" Text=""></asp:Label>
        <asp:HiddenField ID="HiddenField1" runat="server" />
        <asp:HiddenField ID="estatus" runat="server" />
        <asp:Label ID="Label24" runat="server" Text=""></asp:Label>
        <input type="hidden" id="vhpaciente" runat="server" />
</center>
    </form>
</body>
</html>

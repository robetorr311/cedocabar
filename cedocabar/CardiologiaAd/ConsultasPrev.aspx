<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultasPrev.aspx.cs" Inherits="cedocabar.CardiologiaAd.ConsultasPrev" %>

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
          <td align="center"  class="subnombreform" >CONSULTAS REALIZADAS ANTERIORMENTE </td>
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
                            <span onmouseover="muestraAyuda(event, 'Consultas: Editar Registro');"><asp:ImageButton ID="ImageButton5" CommandName="Registro"  Enabled="false" Text="Delete" CausesValidation="false" ButtonType="Image" ImageUrl="../Imagenes/CntMnuEdit.gif" runat="server" /></span>						
                        </ItemTemplate> 
					</asp:TemplateField>
                     <asp:TemplateField HeaderText="ID" Visible="true">
                        <ItemTemplate>
                            <asp:Label ID="LblID" runat="server" Text='<%# Eval("id") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="FECHA DE CONSULTA" Visible="true">					
						<ItemTemplate>
                            <asp:Label ID="Lblfecha" runat="server" Text='<%# Eval("fecha") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="NOMBRE DEL PACIENTE" Visible="true">					
						<ItemTemplate>
                            <asp:Label ID="Lblta" runat="server" Text='<%# Eval("nombre") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td> 
            </tr>
  </table>
    <table width="700" border="0" cellspacing="0" cellpadding="0">
      <tr>
         <td align="center"  class="subnombreform" >DIAGNOSTICO</td>
      </tr>
    </table>
    <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay"><asp:TextBox ID="diagnostico" CssClass="textolargo" TextMode="MultiLine" runat="server"></asp:TextBox></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label10" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img9" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
    </table>
     <table width="700" border="0" cellspacing="0" cellpadding="0">
      <tr>
         <td align="center"  class="subnombreform" >TRATAMIENTO</td>
      </tr>
    </table>    
    <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay"><asp:TextBox ID="tratamiento" CssClass="textolargo" TextMode="MultiLine" runat="server"></asp:TextBox></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label6" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img10" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
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

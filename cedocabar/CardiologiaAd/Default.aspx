﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="cedocabar.CardiologiaAd.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
	<link rel="stylesheet" type="text/css" href="~/Styles/Skin Style.css" />
	<link rel="stylesheet" type="text/css" href="~/Styles/style.css" />
	<link rel="stylesheet" type="text/css" href="~/Styles/subModal.css" />
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />

</head>
<body>
     <form id="form1" target="_self" runat="server">      
    <center>
    <table width="700" border="0" cellspacing="0" cellpadding="0">
            <tr>
                <td align="center" class="nombreform">
                    <asp:Label ID="Label1" CssClass="main" runat="server" Text="CONSULTA CARDIOLOGIA ADULTO"></asp:Label>
                </td>
            </tr>
     </table>
     <table width="700" border="0" cellspacing="0" cellpadding="0">
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
                    OnPageIndexChanging = "gridView_PageIndexChanging"
                    OnSelectedIndexChanged="gridView_SelectedIndex"
                    PagerSettings-Mode="NextPreviousFirstLast"
                    PagerSettings-LastPageImageUrl="../Imagenes/PageLastOver.gif"
                    PagerSettings-FirstPageImageUrl="../Imagenes/PageFirstOver.gif"
                    PagerSettings-NextPageImageUrl="../Imagenes/PageNextOver.gif"
                    PagerSettings-PreviousPageImageUrl="../Imagenes/PagePrevOver.gif"  
                    PagerSettings-Position="Bottom"
                    PagerStyle-CssClass="small"  
                    AutoGenerateColumns="false" 
                    runat="server">
                    <Columns>
					<asp:TemplateField HeaderText="Controles" ShowHeader="False"> 
						<ItemTemplate>
							<asp:ImageButton ID="ImageButton6" CommandName="Select" Text="Seleccionar" CausesValidation="false" ButtonType="Image" ImageUrl="../Imagenes/form_go.gif" runat="server" />
						</ItemTemplate> 
					</asp:TemplateField>
                     <asp:TemplateField HeaderText="Numero" Visible="true">
                        <ItemTemplate>
                            <asp:Label ID="Lblnumero" runat="server" Text='<%# Eval("numero") %>'></asp:Label>
                        </ItemTemplate>
                     </asp:TemplateField>
                     <asp:TemplateField HeaderText="Nombre" Visible="true">
                        <ItemTemplate>
                            <asp:Label ID="Lblnombre" runat="server" Text='<%# Eval("nombre") %>'></asp:Label>
                        </ItemTemplate>
                     </asp:TemplateField>
                     <asp:TemplateField HeaderText="Cedula" Visible="true">
                        <ItemTemplate>
                            <asp:Label ID="Lblcedula" runat="server" Text='<%# Eval("cedula") %>'></asp:Label>
                        </ItemTemplate>
                     </asp:TemplateField>
                     <asp:TemplateField HeaderText="Edad" Visible="true">
                        <ItemTemplate>
                            <asp:Label ID="Lbledad" runat="server" Text='<%# Eval("edad") %>'></asp:Label>
                        </ItemTemplate>
                     </asp:TemplateField>
                     <asp:TemplateField HeaderText="Sexo" Visible="true">
                        <ItemTemplate>
                            <asp:Label ID="Lblsexo" runat="server" Text='<%# Eval("sexo") %>'></asp:Label>
                        </ItemTemplate>
                     </asp:TemplateField>
                   </Columns>
                </asp:GridView>
            </td> 
            </tr>
    </table>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>      
      <td align="left" class="loginDisplay" width="58">
      <asp:Button ID="Button1" CssClass="buttons2" OnClick="Continuar" runat="server" Text="Continuar" />
      <asp:Button ID="Button2" CssClass="buttons2" OnClick="Modificar" runat="server" Text="Modificar" />
      </td>
    </tr>
  </table> 
  <input type="hidden" id="vhpaciente" runat="server" />
  <input type="hidden" id="vhdocumento" runat="server" />                               
  </center>
  </form>
</body>
</html>

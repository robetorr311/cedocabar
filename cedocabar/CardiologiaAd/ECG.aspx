<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ECG.aspx.cs" Inherits="cedocabar.CardiologiaAd.ECG" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
	<link rel="stylesheet" type="text/css" href="~/Styles/Skin Style.css" />
	<link rel="stylesheet" type="text/css" href="~/Styles/style.css" />
    <link rel="stylesheet" type="text/css" href="~/Styles/subModal.css" />
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
	<script type="text/javascript" src="../Scripts/common.js"></script>
	<script type="text/javascript" src="../Scripts/subModal.js"></script>
</head>
<body>
     <form id="form1" target="_self" runat="server">      
    <table width="700" border="0" cellspacing="0" cellpadding="0">
            <tr>
                <td align="center" class="nombreform">
                    <asp:Label ID="Label1" CssClass="main" runat="server" Text="GUARDAR IMAGEN DE ELECTROCARDIOGRAMA"></asp:Label>
                </td>
            </tr>
     </table>
    <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay" width="50">N&uacute;mero de Historia:</td>
      <td align="left" class="loginDisplay">
          <asp:FileUpload ID="FileUpload1"  runat="server"  />
        <asp:Button ID="btnGuardar" runat="server" CssClass="buttons2" Text="Guardar Archivo" OnClick="btnGuardar_Click" /></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label9" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img14" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
    <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay"><input type="button" ID="Button1" runat="server" class="buttons2" value="Cerrar" /></td>
      <td align="left" class="loginDisplay" width="2"><asp:Label ID="Label2" runat="server" Text=""></asp:Label></td>
      <td align="left" class="loginDisplay" width="20"><img id="Img1" src="~/Imagenes/sign_question.png" alt="" width="16" height="16" runat="server"/></td>
    </tr>
  </table>
     <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left" class="loginDisplay">
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
                            <asp:HyperLink ID="descarga" runat="server" Enabled="false">
                               <img src="../Imagenes/download.gif" alt="" width="16px" height="16px" style="border-width:0px;" />
                            </asp:HyperLink>
                        </ItemTemplate> 
					</asp:TemplateField>
                     <asp:TemplateField HeaderText="ID" Visible="true">
                        <ItemTemplate>
                            <asp:Label ID="LblID" runat="server" Text='<%# Eval("id") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="FECHA" Visible="true">					
						<ItemTemplate>
                            <asp:Label ID="Lblfecha" runat="server" Text='<%# Eval("fecha") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td> 
            </tr>
  </table>
    <input type="hidden" id="hpaciente" runat="server" />
    <input type="hidden" id="idekg" runat="server" />
     <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>


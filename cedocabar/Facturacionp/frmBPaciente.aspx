<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmBPaciente.aspx.cs" Inherits="cedocabar.Facturacionp.frmBPaciente" %>

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
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="center" class="nombreform"><asp:Label ID="Label1" CssClass="main" runat="server" Text="LISTADO DE PACIENTES"></asp:Label></td>
    </tr>
  </table>
    <table border="0" width="500" onmouseover="self()">
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
                    OnPageIndexChanging = "gridView_PageIndexChanging"
                    OnSelectedIndexChanged="gridView_SelectedIndex"
                    PagerSettings-Mode="NextPreviousFirstLast"
                    PagerSettings-LastPageImageUrl="../Imagenes/PageLastOver.gif"
                    PagerSettings-FirstPageImageUrl="../Imagenes/PageFirstOver.gif"
                    PagerSettings-NextPageImageUrl="../Imagenes/PageNextOver.gif"
                    PagerSettings-PreviousPageImageUrl="../Imagenes/PagePrevOver.gif"  
                    PagerSettings-Position="Bottom"
                    PagerStyle-CssClass="small"  
                    runat="server">
                    <Columns>
                    <asp:CommandField ShowSelectButton="true"  ButtonType="Image"  SelectImageUrl="../Imagenes/form_go.gif" />         
                    </Columns>
                </asp:GridView>
            </td> 
            </tr>
  </table>
  <input type="hidden" id="idpac" runat="server" />   
  </center>
  </form>
</body>
</html>

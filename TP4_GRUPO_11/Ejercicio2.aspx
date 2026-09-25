<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TP4_GRUPO_11.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
    Id Producto:
    <asp:DropDownList ID="ddlOperadorProducto" runat="server">
        <asp:ListItem Text="Igual a:" Value="="></asp:ListItem>
        <asp:ListItem Text="Mayor a:" Value=">"></asp:ListItem>
        <asp:ListItem Text="Menor a:" Value="<"></asp:ListItem>
    </asp:DropDownList>
    <asp:TextBox ID="txtIdProducto" runat="server"></asp:TextBox>

    <br />

    IdCategoria:
    <asp:DropDownList ID="ddlOperadorCategoria" runat="server">
        <asp:ListItem Text="Igual a:" Value="="></asp:ListItem>
        <asp:ListItem Text="Mayor a:" Value=">"></asp:ListItem>
        <asp:ListItem Text="Menor a:" Value="<"></asp:ListItem>
    </asp:DropDownList>
    <asp:TextBox ID="txtIdCategoria" runat="server"></asp:TextBox>

    <br /><br />

    <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" />
    <asp:Button ID="btnQuitarFiltro" runat="server" Text="Quitar filtro" />

    <br /><br />

    <asp:GridView ID="gvProductos" runat="server">
    </asp:GridView>
        </div>
    </form>
</body>
</html>

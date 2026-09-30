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

        <asp:CompareValidator
    ID="cvIdProducto"
    runat="server"
    ControlToValidate="txtIdProducto"
    Operator="DataTypeCheck"
    Type="Integer"
    ErrorMessage="Ingresá un número entero en Id Producto."
    ForeColor="Red"
    Display="Dynamic"
    ValidationGroup="Filtros">
</asp:CompareValidator>

    <br />

    IdCategoria:
    <asp:DropDownList ID="ddlOperadorCategoria" runat="server">
        <asp:ListItem Text="Igual a:" Value="="></asp:ListItem>
        <asp:ListItem Text="Mayor a:" Value=">"></asp:ListItem>
        <asp:ListItem Text="Menor a:" Value="<"></asp:ListItem>
    </asp:DropDownList>
    <asp:TextBox ID="txtIdCategoria" runat="server"></asp:TextBox>

            <asp:CompareValidator
    ID="cvIdCategoria"
    runat="server"
    ControlToValidate="txtIdCategoria"
    Operator="DataTypeCheck"
    Type="Integer"
    ErrorMessage="Ingresá un número entero en Id Categoría."
    ForeColor="Red"
    Display="Dynamic"
    ValidationGroup="Filtros">
</asp:CompareValidator>

    <br /><br />

<asp:Button ID="btnFiltrar" runat="server"
    Text="Filtrar"
    OnClick="btnFiltrar_Click"
    ValidationGroup="Filtros" />

 <asp:Button ID="btnQuitarFiltro" runat="server"
    Text="Quitar filtro"
    OnClick="btnQuitarFiltro_Click"
    CausesValidation="false" />

 <asp:Label ID="lblCompletar" runat="server" ForeColor="Red">
 </asp:Label>

    <br /><br />

    <asp:GridView ID="gvProductos" runat="server">
    </asp:GridView>
        </div>
    </form>
</body>
</html>

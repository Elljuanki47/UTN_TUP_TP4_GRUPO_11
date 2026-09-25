<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3.aspx.cs" Inherits="TP4_GRUPO_11.Ejercicio3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
         <asp:Panel ID="pnlSeleccion" runat="server">
             Seleccionar Tema:
    
         <asp:DropDownList ID="ddlTemas" runat="server"></asp:DropDownList>
         <br /><br />
         <asp:LinkButton ID="lbVerLibros" runat="server" OnClick="lbVerLibros_Click"> 
             Ver libros
        </asp:LinkButton>            
        </asp:Panel>

            <asp:Panel ID="pnlListado" runat="server" Visible="false">
            <h2>Listado de Libros</h2>
            </asp:Panel>
        </div>
    </form>
</body>
</html>

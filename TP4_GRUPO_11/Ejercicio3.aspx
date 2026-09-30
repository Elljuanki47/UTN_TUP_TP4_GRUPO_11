<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3.aspx.cs" Inherits="TP4_GRUPO_11.Ejercicio3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Seleccionar Tema:

            <asp:DropDownList ID="ddlTemas" runat="server">
            </asp:DropDownList>

            <br /><br />

            <asp:Label ID="lblMensaje" runat="server"
                ForeColor="Red"
                Visible="False">
            </asp:Label>

            <asp:LinkButton ID="lbVerLibros" runat="server"
                OnClick="lbVerLibros_Click">
                Ver libros
            </asp:LinkButton>

        </div>
    </form>
</body>
</html>
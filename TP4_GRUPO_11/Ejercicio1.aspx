<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP4_GRUPO_11.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>DESTINO INICIO</h3>

            Provincia:
            <asp:DropDownList ID="ddlProvinciaInicio" runat="server"
                AutoPostBack="true"
                OnSelectedIndexChanged="ddlProvinciaInicio_SelectedIndexChanged">
            </asp:DropDownList>

            <br />

            Localidad:
            <asp:DropDownList ID="ddlLocalidadInicio" runat="server">
            </asp:DropDownList>
            <h3>DESTINO FINAL</h3>
            
            Provincia:
            <asp:DropDownList ID="ddlProvinciaFinal" runat="server"
                AutoPostBack="true"
                OnSelectedIndexChanged="ddlProvinciaFinal_SelectedIndexChanged">
            </asp:DropDownList>
            
            <br />
            
            Localidad:
            <asp:DropDownList ID="ddlLocalidadFinal" runat="server">
            </asp:DropDownList>

            <br />
            <br />

            <asp:Button ID="btnGenerarBoleto" runat="server" 
                Text="Generar Boleto" 
                OnClick="btnGenerarBoleto_Click" />

            <asp:Button ID="btnLimpiar" runat="server"
                Text="Limpiar Seleccion"
                OnClick="btnLimpiar_Click" />

            <br />
            <br />

            <asp:Label ID="lblBoleto" runat="server" 
                Font-Size="14pt" Font-Bold="True"
                ForeColor="Yellow"></asp:Label>

        </div>
    </form>
</body>
</html>

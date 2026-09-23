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
        </div>
    </form>
</body>
</html>

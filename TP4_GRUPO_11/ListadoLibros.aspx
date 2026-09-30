<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoLibros.aspx.cs" Inherits="TP4_GRUPO_11.ListadoLibros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h2>Listado de Libros</h2>

            <asp:GridView ID="gvLibros" runat="server"
                CellPadding="10"
                AutoGenerateColumns="false">

                <Columns>
                    <asp:BoundField DataField="idLibro"
                        HeaderText="ID Libro" />

                    <asp:BoundField DataField="idTema"
                        HeaderText="ID Tema" />

                    <asp:BoundField DataField="Titulo"
                        HeaderText="Titulo" />

                    <asp:BoundField DataField="Precio"
                        HeaderText="Precio" 
                        DataFormatString="{0:N2}" />

                    <asp:BoundField DataField="Autor"
                        HeaderText="Autor" />

                </Columns>
                
                <HeaderStyle HorizontalAlign="Center" />
                <RowStyle HorizontalAlign="Center" />

            </asp:GridView>

            <br />

            <asp:LinkButton ID="lbConsultarOtroTema" runat="server"
                OnClick="lbConsultarOtroTema_Click">
                Consultar otro tema
            </asp:LinkButton>

        </div>
    </form>
</body>
</html>

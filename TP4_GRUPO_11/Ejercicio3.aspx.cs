using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace TP4_GRUPO_11
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        private const string cadenaConexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "SELECT * FROM Temas";

                    SqlCommand comando = new SqlCommand(consulta, conexion);

                    SqlDataReader reader = comando.ExecuteReader();

                    ddlTemas.DataSource = reader;
                    ddlTemas.DataTextField = "Tema";
                    ddlTemas.DataValueField = "IdTema";
                    ddlTemas.DataBind();
                }

                ddlTemas.Items.Insert(0, new ListItem("--Seleccione un tema--", "0"));

                ddlTemas.SelectedValue = "0";
            }
        }

        protected void lbVerLibros_Click(object sender, EventArgs e)
        {
            if (ddlTemas.SelectedValue == "0")
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Seleccione un tema para poder ver los libros.";
                return;
            }

            Response.Redirect("ListadoLibros.aspx?idTema=" + ddlTemas.SelectedValue);
        }
    }
}
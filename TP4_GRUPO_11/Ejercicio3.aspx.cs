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
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                conexion.Open();

                string consulta = "SELECT * FROM Temas";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                ddlTemas.DataSource = reader;
                ddlTemas.DataTextField = "Tema";
                ddlTemas.DataValueField = "IdTema";
                ddlTemas.DataBind();

                conexion.Close();
            }
        }

        protected void lbVerLibros_Click(object sender, EventArgs e)
        {
            pnlSeleccion.Visible = false;
            pnlListado.Visible = true;

            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            string consulta = "SELECT * FROM Libros WHERE IdTema = @IdTema";

            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@IdTema", ddlTemas.SelectedValue);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            DataSet ds = new DataSet();
            adaptador.Fill(ds, "Libros");

            gvLibros.DataSource = ds.Tables["Libros"];
            gvLibros.DataBind();

            conexion.Close();
        }
    }
}
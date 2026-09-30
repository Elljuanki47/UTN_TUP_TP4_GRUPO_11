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
    public partial class ListadoLibros : System.Web.UI.Page
    {
        private const string cadenaConexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string idTema = Request.QueryString["idTema"];

                if (idTema != null)
                {
                    CargarLibros(idTema);
                }
            }
        }

        private void CargarLibros(string idTema)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                string consulta = "SELECT * FROM Libros WHERE IdTema = @IdTema";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@IdTema", idTema);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                DataSet ds = new DataSet();

                adaptador.Fill(ds, "Libros");

                gvLibros.DataSource = ds.Tables["Libros"];
                gvLibros.DataBind();
            }
        }

        protected void lbConsultarOtroTema_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio3.aspx");
        }
    }
}
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
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        private const string cadenaConexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                conexion.Open();

                string consulta = "SELECT * FROM Productos";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);

                DataSet ds = new DataSet();
                adaptador.Fill(ds, "Productos");

                gvProductos.DataSource = ds.Tables["Productos"];
                gvProductos.DataBind();

                conexion.Close();
            }
        }

       protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtIdProducto.Text.Trim() != "")
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                conexion.Open();

                string operador = ddlOperadorProducto.SelectedValue;

                string consulta = "SELECT * FROM Productos WHERE IdProducto "
                                 + operador + " @IdProducto";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@IdProducto",
                    Convert.ToInt32(txtIdProducto.Text));

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                DataSet ds = new DataSet();
                adaptador.Fill(ds, "Productos");

                gvProductos.DataSource = ds.Tables["Productos"];
                gvProductos.DataBind();

                conexion.Close();
            }

            if (txtIdCategoria.Text.Trim() != "")
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                conexion.Open();

                string operador = ddlOperadorCategoria.SelectedValue;

                string consulta = "SELECT * FROM Productos WHERE IdCategoría " + operador + " @IdCategoría";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@IdCategoría", Convert.ToInt32(txtIdCategoria.Text));

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                DataSet ds = new DataSet();
                adaptador.Fill(ds, "Productos");

                gvProductos.DataSource = ds.Tables["Productos"];
                gvProductos.DataBind();

                conexion.Close();
            }
        }

        protected void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            string consulta = "SELECT * FROM Productos";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);

            DataSet ds = new DataSet();
            adaptador.Fill(ds, "Productos");

            gvProductos.DataSource = ds.Tables["Productos"];
            gvProductos.DataBind();

            conexion.Close();
        }
    }
}
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
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

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
            if (!Page.IsValid)
            {
                return;
            }
            if (txtIdProducto.Text.Trim() == "" && txtIdCategoria.Text.Trim() == "")
            {
                lblCompletar.Text = "No pueden quedar ambos espacios vacios";
                return;
            }

            if (txtIdProducto.Text.Trim() != "" && txtIdCategoria.Text.Trim() != "")
            {
                lblCompletar.Text = "";

                SqlConnection conexion = new SqlConnection(cadenaConexion);
                conexion.Open();

                string operadorProducto = ddlOperadorProducto.SelectedValue;
                string operadorCategoria = ddlOperadorCategoria.SelectedValue;

                string consulta =
                    "SELECT * FROM Productos WHERE IdProducto " + operadorProducto +
                    " @IdProducto AND IdCategoría " + operadorCategoria +
                    " @IdCategoria";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@IdProducto",
                    Convert.ToInt32(txtIdProducto.Text));

                comando.Parameters.AddWithValue("@IdCategoria",
                    Convert.ToInt32(txtIdCategoria.Text));

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                DataSet ds = new DataSet();
                adaptador.Fill(ds, "Productos");

                gvProductos.DataSource = ds.Tables["Productos"];
                gvProductos.DataBind();

                conexion.Close();

                txtIdProducto.Text = "";
                txtIdCategoria.Text = "";

                return;
            }

            if (txtIdProducto.Text.Trim() != "")
            {
                lblCompletar.Text = "";
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

                txtIdProducto.Text = "";
                txtIdCategoria.Text = "";

                return;
            }

            if (txtIdCategoria.Text.Trim() != "")
            {
                lblCompletar.Text = "";

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

                txtIdProducto.Text = "";
                txtIdCategoria.Text = "";

                return;
            }
            if (txtIdProducto.Text.Trim() == "" && txtIdCategoria.Text.Trim() == "")
            {
                lblCompletar.Text = "";
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

        protected void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            lblCompletar.Text = "";
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
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
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        private const string cadenaConexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Viajes;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                conexion.Open();

                string consulta = "SELECT IdProvincia, NombreProvincia FROM Provincias";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);

                DataSet ds = new DataSet();
                adaptador.Fill(ds, "Provincias");

                ddlProvinciaInicio.DataSource = ds.Tables["Provincias"];
                ddlProvinciaInicio.DataTextField = "NombreProvincia";
                ddlProvinciaInicio.DataValueField = "IdProvincia";
                ddlProvinciaInicio.DataBind();

                ddlProvinciaFinal.DataSource = ds.Tables["Provincias"];
                ddlProvinciaFinal.DataTextField = "NombreProvincia";
                ddlProvinciaFinal.DataValueField = "IdProvincia";
                ddlProvinciaFinal.DataBind();

                CargarLocalidadesInicio();
                CargarLocalidadesFinal();

                conexion.Close();
                ListItem item = new ListItem("--Seleccione una provincia--", "0");
                ddlProvinciaInicio.Items.Add(item);
                ddlProvinciaInicio.SelectedValue = "0";
            }
        }
        private void CargarProvinciasFinal()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            string consulta = @"SELECT IdProvincia, NombreProvincia
                        FROM Provincias
                        WHERE IdProvincia <> @IdProvincia";

            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@IdProvincia",
                                            ddlProvinciaInicio.SelectedValue);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            DataSet ds = new DataSet();
            adaptador.Fill(ds, "Provincias");

            ddlProvinciaFinal.DataSource = ds.Tables["Provincias"];
            ddlProvinciaFinal.DataTextField = "NombreProvincia";
            ddlProvinciaFinal.DataValueField = "IdProvincia";
            ddlProvinciaFinal.DataBind();

            conexion.Close();
        }

        protected void ddlProvinciaInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarLocalidadesInicio();
            CargarProvinciasFinal();
            CargarLocalidadesFinal();
        }


        private void CargarLocalidadesInicio()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            string consulta = "SELECT IdLocalidad, NombreLocalidad FROM Localidades WHERE IdProvincia = @IdProvincia";

            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@IdProvincia", ddlProvinciaInicio.SelectedValue);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            DataSet ds = new DataSet();
            adaptador.Fill(ds, "Localidades");

            ddlLocalidadInicio.DataSource = ds.Tables["Localidades"];
            ddlLocalidadInicio.DataTextField = "NombreLocalidad";
            ddlLocalidadInicio.DataValueField = "IdLocalidad";
            ddlLocalidadInicio.DataBind();
            
            conexion.Close();

            ListItem item = new ListItem("--Seleccione una localidad--", "0");
            ddlLocalidadInicio.Items.Add(item);
            ddlLocalidadInicio.SelectedValue = "0";
        }

        protected void ddlProvinciaFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarLocalidadesFinal();
        }

        private void CargarLocalidadesFinal()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            string consulta = "SELECT IdLocalidad, NombreLocalidad FROM Localidades WHERE IdProvincia = @IdProvincia";

            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@IdProvincia", ddlProvinciaFinal.SelectedValue);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            DataSet ds2 = new DataSet();
            adaptador.Fill(ds2, "Localidades");

            ddlLocalidadFinal.DataSource = ds2.Tables["Localidades"];
            ddlLocalidadFinal.DataTextField = "NombreLocalidad";
            ddlLocalidadFinal.DataValueField = "IdLocalidad";
            ddlLocalidadFinal.DataBind();

            conexion.Close();
        }
    }
}
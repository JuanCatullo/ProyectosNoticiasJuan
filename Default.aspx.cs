using ProyectosNoticiasJuan.Manager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectosNoticiasJuan
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                CargarCategoriasNoticias();
                CargarNoticias();


            }

        }
        void CargarNoticias()
        {
            string sRet = "";
            DataTable dt = new DataTable();
            sRet = Utilidades.Datos.ObtenerNoticias(1, int.Parse(dlCategorias.SelectedValue.ToString()), ref dt);

            gvNoticias.DataSource = dt;
            gvNoticias.DataBind();
        }

        void CargarCategoriasNoticias()
        {
            string sRet = "";
            DataTable dt = new DataTable();
            sRet = Utilidades.Datos.ObtenerCategoriasNoticias(ref dt);

            dlCategorias.DataTextField = "descripcion";
            dlCategorias.DataValueField = "id";

            dlCategorias.DataSource = dt;
            dlCategorias.DataBind();
        }

        protected void dlCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarNoticias();
        }
    }
}
using ProyectosNoticiasJuan.Manager;
using ProyectosNoticiasJuan.Utilidades;
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


        public string ImagenNoticia(object imagenDB)
        {
            string sRet = "";

            if (imagenDB != null)
            {
                sRet = "uploads/" + imagenDB;
            }
            else
            {
                sRet = "";
            }

            return sRet;
        }



        public string LinkNoticia(object IdNoticia)
        {
            string sRet = "";

            if (IdNoticia != null)
            {
                sRet = "DetalleNoticia.aspx?id=" + IdNoticia;
            }
            else
            {
                sRet = "";
            }

            return sRet;
        }

        protected void Btn_Crear(object sender, EventArgs e)
        {

            Response.Redirect("/manager/NoticiaEditar.aspx");

        }

        protected void gvNoticias_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.ToString() == "EDITAR")
            {
                Response.Redirect("NoticiaEditar.aspx" + "?noticia_id=" + e.CommandArgument.ToString());
            }
            if (e.CommandName.ToString() == "ELIMINAR")
            {
                string sRetorno = "";
                sRetorno = Datos.EliminarNoticia(Convert.ToInt32(e.CommandArgument.ToString()));
                if (sRetorno == "")
                {
                    Utils.ShowAlertAjax(this.Page, "Noticia eliminada exitosamente", "");
                    CargarNoticias();
                }
                else
                {
                    Utils.ShowAlertAjax(this.Page, "Error al buscar " + sRetorno, "");
                }
            }
        }
    }
}
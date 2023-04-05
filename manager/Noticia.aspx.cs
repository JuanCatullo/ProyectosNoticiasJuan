using ProyectosNoticiasJuan.Manager;
using ProyectosNoticiasJuan.Utilidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectosNoticiasJuan.Manager
{
    public partial class Noticias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(Request.QueryString["usuario_id"]))
            {

            }


            if (!Page.IsPostBack)
            {
                CargarNoticias();

            }
        }

        void CargarNoticias()
        {
            string sRet = "";
            DataTable dt = new DataTable();

            sRet = Datos.ObtenerNoticias(ref dt);

            if (sRet == "")
            {
                gvNoticias.DataSource = dt;
                gvNoticias.DataBind();

            }
            else
            {
                Utils.ShowAlertAjax(this.Page, sRet, "");
            }

        }

        protected void Btn_Crear(object sender, EventArgs e)
        {

            Response.Redirect("/Manager/NoticiaEditar.aspx");

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
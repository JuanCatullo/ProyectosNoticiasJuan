using ProyectoNoticiasJuan.Utilidades;
using ProyectosNoticiasJuan.Utilidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ProyectosNoticiasJuan.aspx
{
    public partial class UsuariosRegistrados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CargarUsuariosRegistrados();
            }
        }


        void CargarUsuariosRegistrados()
        {
            string sRett = "";
            DataTable dt = new DataTable();

            sRett = Datos.ObtenerUsuariosRegistrados(ref dt);

            if (sRett == "")
            {
                //cono.DataValueField = "id";
                //cono.DataTextField = "descripcion";
                //cono.DataSource = dt;
                //cono.DataBind();
                gvUsuarios.DataSource = dt;
                gvUsuarios.DataBind();
            }




        }

        protected void gvUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.ToString() == "EDITAR")
            {
                Response.Redirect("Usuario.aspx" + "?usuario_id=" + e.CommandArgument.ToString());
            }
            if (e.CommandName.ToString() == "ELIMINAR")
            {
                string sRetorno = "";
                sRetorno = Datos.EliminarUsuario(Convert.ToInt32(e.CommandArgument.ToString()));
                if (sRetorno == "")
                {
                    Utils.ShowAlertAjax(this.Page, "Usuario eliminado exitosamente", "");
                    CargarUsuariosRegistrados();
                }
                else
                {
                    Utils.ShowAlertAjax(this.Page, "Error al buscar " + sRetorno, "");
                }
            }

            

        }


            

    }

}
    

    
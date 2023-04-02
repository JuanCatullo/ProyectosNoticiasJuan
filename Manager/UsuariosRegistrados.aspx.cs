using ProyectosNoticiasJuan.Utilidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectosNoticiasJuan.manager
{
    public partial class Usuarios : System.Web.UI.Page
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
            string sRet = "";
            DataTable dt = new DataTable();

            sRet = Datos.ObtenerUsuariosRegistrados(ref dt);

            if (sRet == "")
            {
                gvUsuarios.DataSource = dt;
                gvUsuarios.DataBind();
            }
            else
            {
                Utils.ShowAlertAjax(this.Page, sRet, "");
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
                //LLAMO A LA FUNCION QUE ELIMINA AL USUARIO
                string sRetorno = "";
                sRetorno = Datos.EliminarUsuario(Convert.ToInt32(e.CommandArgument.ToString()));

                if (sRetorno == "")
                {
                    Utils.ShowAlertAjax(this.Page, "Usuario eliminado exitosamente", "");
                    //RECARGO LA GRILLA ASI MUESTRA LOS CAMBIOS
                    CargarUsuariosRegistrados();
                }
                else
                {
                    Utils.ShowAlertAjax(this.Page, "Error al borrar: " + sRetorno, "");
                }

            }
        }
    }
}
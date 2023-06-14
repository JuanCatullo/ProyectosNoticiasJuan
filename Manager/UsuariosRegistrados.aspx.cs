using ProyectosNoticiasJuan.Utilidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectosNoticiasJuan.manager
{
    public partial class UsuariosRegistrados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USUARIO"] != null)
            {
                Clases.Usuario UsuarioActual = (Clases.Usuario)Session["USUARIO"];

                //if (UsuarioActual.PerfilID == 2) 
                //{
                //	Utils.ShowAlertAjax(this.Page, "No tiene permisos para ver esta página", "/Default.aspx");
                //	return;
                //}

                if (Utils.TieneAcceso("USUARIOS", UsuarioActual.PerfilID) == false)
                {
                    Utils.ShowAlertAjax(this.Page, "No tiene permisos para ver esta página", "/Default.aspx");
                    return;
                }

            }


            if (!Page.IsPostBack)
            {
                CargarUsuariosRegistrados(Convert.ToString(ViewState["sSort1"]), Convert.ToString(ViewState["sDirection1"]));
            }
        }

        void CargarUsuariosRegistrados(string sSort, string sDirection)
        {
            string sRet = "";
            DataTable dt = new DataTable();

            if ((ViewState["sSort1"] == null))
            {
                ViewState["sSort1"] = "";
            }

            if ((ViewState["sDirection1"] == null))
            {
                ViewState["sDirection1"] = "";
            }


            sRet = Utilidades.Datos.ObtenerUsuariosRegistrados(ref dt);

            if (sRet == "")
            {

                DataView dv = new DataView();
                dv = dt.DefaultView;

                if (((sSort != "") && (sDirection != "")))
                {
                    dv.Sort = (sSort + (" " + sDirection));
                }


                gvUsuarios.DataSource = dv;
                gvUsuarios.DataBind();

                lblCuentaRegistros.Text = "Hay " + dv.Count.ToString() + " registros.";
            }
            else
            {
                Utilidades.Utils.ShowAlertAjax(this.Page, sRet, "");
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
                    CargarUsuariosRegistrados((string)ViewState["sSort1"], (string)ViewState["sDirection1"]);

                }
                else
                {
                    Utils.ShowAlertAjax(this.Page, "Error al borrar: " + sRetorno, "");
                }

            }
        }

        protected void gvUsuarios_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvUsuarios.PageIndex = e.NewPageIndex;

            gvUsuarios.SelectedIndex = -1;
            CargarUsuariosRegistrados((string)ViewState["sSort1"], (string)ViewState["sDirection1"]);

          //  CargarRegistros(ViewState("sSort1"), ViewState("sDirection1"))
        }

        protected void gvUsuarios_Sorting(object sender, GridViewSortEventArgs e)
        {
            string sortExpression = e.SortExpression;
            ViewState["sSort1"] = sortExpression.ToString();
            string sortDirection = Convert.ToString(ViewState["sDirection1"]);


            Utilidades.Datos.SortGridView(ref sortExpression, ref sortDirection);
            ViewState["sSort1"] = sortExpression.ToString();
            ViewState["sDirection1"] = sortDirection.ToString();

           CargarUsuariosRegistrados((string)ViewState["sSort1"], (string)ViewState["sDirection1"]);
        }
    }
}
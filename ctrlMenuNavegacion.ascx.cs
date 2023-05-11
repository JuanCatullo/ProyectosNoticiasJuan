using ProyectosNoticiasJuan.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectosNoticiasJuan
{
    
    public partial class ctrlMenuNavegacion : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                plcManager.Visible = true;
                lnkSalir.Visible = true;

                if (Session["USUARIO"] != null)
                {
                    Clases.Usuario UsuarioActual = (Clases.Usuario)Session["USUARIO"];

                    if (Utils.TieneAcceso("USUARIOS", UsuarioActual.PerfilID) == false)
                    {
                        plcUsuarios.Visible = false;
                    }


                }


            }
            else
            {

                plcManager.Visible = false;
                lnkSalir.Visible = false;

            }

        }
        protected void lnkSalir_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            System.Web.Security.FormsAuthentication.SignOut();
            Response.Redirect("~/Default.aspx");
        }

      
    }
}

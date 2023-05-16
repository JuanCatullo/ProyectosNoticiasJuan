using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectosNoticiasJuan
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USUARIO"] != null)
            {

                Clases.Usuario UsuarioActual = (Clases.Usuario)Session["USUARIO"];

                lblUsuario.Text = "Hola " + UsuarioActual.Apellido + ", " + UsuarioActual.Nombre;
                //plcManager.Visible = true;

            }
            else
            {
                lblUsuario.Text = "Usuario sin autenticar";
                //plcManager.Visible = false;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            FormsAuthentication.SignOut();
            Response.Redirect("/Default.aspx");
        }
    }
}

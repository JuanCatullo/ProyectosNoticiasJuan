using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectosNoticiasJuan
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USUARIO_NOMBRE"] is null)
            {

            }
            else
            {
                if (!string.IsNullOrEmpty(Session["USUARIO_NOMBRE"].ToString()))
                {
                    lblUsuario.Text = Session["USUARIO_NOMBRE"].ToString();
                }
            }


        }
    }
}

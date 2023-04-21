using ProyectosNoticiasJuan.Utilidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectosNoticiasJuan
{
    
    public partial class DetalleNoticia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadUI();
        }

        void LoadUI()
        {
          CargarNoticia(int.Parse(Request.QueryString["id"].ToString()));
        }


        void CargarNoticia(int iId)
        {
            try
            {
                string sRet = "";
                DataTable dt = new DataTable();
                sRet = Datos.ObtenerNoticia(iId, ref dt);

                if (dt.Rows.Count == 1)
                {

                    lblTitulo.Text = dt.Rows[0]["titulo"].ToString();

                    if (!string.IsNullOrEmpty(dt.Rows[0]["imagen"].ToString()))
                    {
                        imgNoticia.ImageUrl = "uploads/" + dt.Rows[0]["imagen"].ToString();
                        imgNoticia.Visible = true;
                    }
                    else
                    {
                        imgNoticia.Visible = false;
                    }

                    lblCopete.Text = dt.Rows[0]["copete"].ToString();

                   

                }



            }
            catch (Exception ex)
            {
                Utils.ShowAlertAjax(this.Page, ex.Message.ToString(), "");
            }

        }



    }
}
    
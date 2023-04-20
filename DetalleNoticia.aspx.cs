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
         //  lblID.Text = Request.QueryString["id"].ToString();

         //  CargarNoticia(int.Parse(Request.QueryString["id"].ToString()));


        }


        void CargarNoticia(int iId)
        {
            try
            {
                string sRet = "";
                DataTable dt = new DataTable();
                sRet = Utilidades.Datos.ObtenerNoticia(iId, ref dt);

                if (dt.Rows.Count == 1)
                {
                    lblTitulo.Text = dt.Rows[0]["titulo"].ToString();
                }



            }
            catch (Exception ex)
            {
                Utils.ShowAlertAjax(this.Page, ex.Message.ToString(), "");
            }

        }



    }
}
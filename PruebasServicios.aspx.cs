using ProyectosNoticiasJuan.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectosNoticiasJuan
{
{
	public partial class PruebasServicios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HolaMundoPorServicio();
            //SumarPorServicio();
            //ListarNoticiasPorServicio();

            ListarNoticiasListaServicio();

        }


        void HolaMundoPorServicio()
        {
            ServicioNoticias.ws_NoticiasSoapClient MiServicio = new ServicioNoticias.ws_NoticiasSoapClient();

            lblHola.Text = MiServicio.HolaMundo().ToString();

        }

        void SumarPorServicio()
        {
            ServicioNoticias.ws_NoticiasSoapClient MiServicio = new ServicioNoticias.ws_NoticiasSoapClient();

            lblSumar.Text = MiServicio.Sumar(100, 200).ToString();
        }

        void ListarNoticiasPorServicio()
        {
            ServicioNoticias.ws_NoticiasSoapClient MiServicio = new ServicioNoticias.ws_NoticiasSoapClient();
            System.Data.DataSet ds = MiServicio.ObtenerNoticiasDS();

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }


        void ListarNoticiasListaServicio()
        {
            ServicioNoticias.ws_NoticiasSoapClient MiServicio = new ServicioNoticias.ws_NoticiasSoapClient();

            ServicioNoticias.Noticia[] myLista = MiServicio.ObtenerListaNoticias();

            if (myLista is null)
            {
                Utils.ShowAlertAjax(this.Page, "El servicio dio algún error", "");
            }
            else
            {
                GridView1.DataSource = myLista;
                GridView1.DataBind();
            }


        }

        protected void cmdEnviarMail_Click(object sender, EventArgs e)
        {
            bool bRetorno = false;
            string sMessageErrorMail = "";

            bRetorno = Utils.SendMail("mdopazo@gmail.com", "", "", "", "Mail de prueba 2", "Este es el texto de un mail de prueba 2", System.Net.Mail.MailPriority.Normal, "Martin Dopazo", ref sMessageErrorMail);

            if (bRetorno)
            {
                Utils.ShowAlertAjax(this.Page, "El mail se envio correctamente", "");
            }
            else
            {
                Utils.ShowAlertAjax(this.Page, "Hubo un error: " + sMessageErrorMail, "");
            }


        }
    }
}
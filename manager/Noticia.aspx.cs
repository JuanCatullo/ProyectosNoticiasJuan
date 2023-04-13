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
        String sFolderUploads = "uploads";
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

            Response.Redirect("/manager/NoticiaEditar.aspx");

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

        string SubirFoto(ref string sFileName)
        {

            string sRet = "";


            if (imgFoto.ImageUrl == "")
            {

                if (FileUpload1.HasFile)
                {
                    if (System.IO.Path.GetExtension(FileUpload1.FileName.ToString().ToUpper()) == ".JPG")
                    {

                        sFileName = System.Guid.NewGuid().ToString() + ".jpg";

                        FileUpload1.PostedFile.SaveAs(HttpContext.Current.Server.MapPath("/") + sFolderUploads + "/" + sFileName);

                        //imgFoto.ImageUrl = "../uploads/" + sFileName;
                    }
                    else
                    {
                        sRet = "El archivo no es JPG";
                    }
                }
                else
                {
                    sRet = "No subiste archivo";
                }

            }
            else
            {

                if (FileUpload1.HasFile)
                {
                    if (System.IO.Path.GetExtension(FileUpload1.FileName.ToString().ToUpper()) == ".JPG")
                    {

                        sFileName = System.Guid.NewGuid().ToString() + ".jpg";

                        FileUpload1.PostedFile.SaveAs(HttpContext.Current.Server.MapPath("/") + sFolderUploads + "/" + sFileName);

                        //imgFoto.ImageUrl = "../uploads/" + sFileName;
                    }
                    else
                    {
                        sRet = "El archivo no es JPG";
                    }
                }
                else
                {
                    sFileName = imgFoto.ImageUrl.ToString().Replace("../uploads/", "").Trim();
                }


            }



            return sRet;

        }
    }
}